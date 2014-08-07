using System;
using System.Collections.Generic;
using System.Text;


namespace Kraggs.Graphics
{
    /// <summary>
    /// Decorates a function with its corrosponding dllimport.
    /// Used only during rewrite of il code. Can be removed afterwards.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    public class AssemblyRewrittenAttribute : Attribute
    {
        /// <summary>
        /// Is assembly rewritten.
        /// </summary>
        public bool Rewritten { get; protected set; }

        /// <summary>
        /// Decorates a function with its corrosponding dllimport.
        /// </summary>
        /// <param name="rewritten">Is this assembly rewritten.</param>
        public AssemblyRewrittenAttribute(bool rewritten)
        {
            this.Rewritten = rewritten;
        }
    }
}
