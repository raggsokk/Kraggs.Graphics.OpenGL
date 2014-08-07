using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace EntryPointGenerator
{
    //public class EntryPointSlotScanner : CSharpSyntaxVisitor<MethodDeclarationSyntax>
    public class EntryPointSlotScanner : CSharpSyntaxWalker
    {
        public readonly List<clsEntryPoint> Entries = new List<clsEntryPoint>();
        public string ClassName { get; set; }
        public string NameSpace { get; set; }

        public readonly SortedSet<string> Usings = new SortedSet<string>();

        protected clsWorkUnit pWork;

        protected EntryPointSlotScanner(clsWorkUnit work) : base(SyntaxWalkerDepth.Token)
        {
            // store this reference for use in visitor methods.
            this.pWork = work;
        }

        public static EntryPointSlotScanner ScanWorkUnit(clsWorkUnit work)
        {
            var visitor = new EntryPointSlotScanner(work);

            foreach (var sourcefile in work.PartialClasses)
            {
                var tree = CSharpSyntaxTree.ParseFile(sourcefile);

                var root = (CompilationUnitSyntax)tree.GetRoot();

                if (string.IsNullOrWhiteSpace(visitor.NameSpace))
                {
                    // get namespace and classname from first code file.
                    var ns = root.ChildNodes().OfType<NamespaceDeclarationSyntax>().Single();
                    visitor.NameSpace = ns.Name.ToString();

                    var cs = ns.ChildNodes().OfType<ClassDeclarationSyntax>().Single();
                    visitor.ClassName = cs.Identifier.ValueText;
                }

                visitor.Visit(root);
            }

            return visitor;
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (node.AttributeLists.Count >= 2)
            {
                var entry = new clsEntryPoint() { FunctionName = node.Identifier.Text };

                foreach (var a in node.AttributeLists)
                {
                    if (a.Attributes[0].Name.ToString() == pWork.SlotAttributeName)
                    {
                        // this is an entrypoint attribute, get its argument.
                        var arg1 = a.Attributes[0].ArgumentList.Arguments.First();
                        entry.SlotID = (int)((arg1.Expression as LiteralExpressionSyntax)
                            .Token.Value);
                        break; // skip scanning additional attributes.
                    }
                }

                // if slotid found. add it.
                if (entry.SlotID != -1)
                    Entries.Add(entry);
            }

            base.VisitMethodDeclaration(node); // Is this needed??
        }


        public override void VisitUsingDirective(UsingDirectiveSyntax node)
        {
            // Collect usings directives in the partial classes.
            // (The EntryPoint arrays don't need them, but stil..)
            var us = node.Name.ToString();

            if (!this.Usings.Contains(us))
                this.Usings.Add(us);

            base.VisitUsingDirective(node); // Is this needed??
        }
    }
}
