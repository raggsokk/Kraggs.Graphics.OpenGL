using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Diagnostics;

namespace EntryPointGenerator
{
    /// <summary>
    /// Uber Simple Code Writer.
    /// </summary>
    public static class SimpleCodeWriter
    {
        private static readonly string sHeader =
@"

namespace NAMESPACE
{
    partial class CLASSNAME
    {
        static CLASSNAME()
        {
            EntryPointNames = new byte[]
            {
                0, 0, 0, 0, // dummy function name.
";
        private static readonly string sMiddle =
@"            };

            EntryPointNameOffsets = new int[]
            {
";

        private static readonly string sFooter =
@"            };
     
            EntryPoints = new IntPtr[EntryPointNameOffsets.Length];       
        }
    }
}
";
        public static void Write(EntryPointSlotScanner result, clsWorkUnit work)
        {
            // Stage 1.
            // Preprocess result for later usage.
            // eh, refactored away, it seems.

            // Stage 2.
            // Write initial header, Set up common code, osv.
            var sb = new StringBuilder();

            if (result.Usings != null && result.Usings.Count > 0)
            {
                foreach (var s in result.Usings)
                    sb.AppendFormat("using {0};{1}", s, Environment.NewLine);
            }
            else
            {
                sb.AppendLine("using System;");
                sb.AppendLine("using System.Runtime.InteropServices;");
            }

            var header = sHeader.Replace("NAMESPACE", result.NameSpace)
                .Replace("CLASSNAME", result.ClassName);

            sb.Append(header);


            // Stage 3
            // Generate Arrays.
            // First EntryPointNames Array
            var lstSorted = result.Entries.OrderBy(l => l.SlotID);

            var curByteOffset = 4; // start at 4 to keep dummy array in place.
            //var curArrayOffset = 0;

            foreach (var e in lstSorted)
            {
                // TODO: this might need duble slot id checkup.
                //array_offsets[curArrayOffset++] = curByteOffset;
                e.EntryPointNameOffset = curByteOffset;

                sb.Append("\t\t\t\t");
                var ascii = Encoding.ASCII.GetBytes(e.FunctionName);

                foreach (var b in ascii)
                    sb.AppendFormat("{0}, ", b);
                sb.Append("0, // ");
                sb.AppendLine(e.FunctionName);
                curByteOffset += ascii.Length + 1;
            }


            // 3b.
            // Second EntryPointOffsets
            sb.Append(sMiddle);

            var lstMultiSort = new SortedList<int, List<clsEntryPoint>>();
            foreach (var e in lstSorted)
            {
                List<clsEntryPoint> lst;
                if (lstMultiSort.TryGetValue(e.SlotID, out lst))
                {
                    lst.Add(e);
                }
                else
                {
                    lst = new List<clsEntryPoint>();
                    lst.Add(e);
                    lstMultiSort.Add(e.SlotID, lst);
                }
            }

            int max = -1;
            result.Entries.ForEach(e =>
            {
                max = Math.Max(max, e.SlotID);
            });

            for (int i = 0; i < max + 1; i++)
            {
                List<clsEntryPoint> lst;
                if (lstMultiSort.TryGetValue(i, out lst))
                {
                    if (lst.Count == 1)
                    {
                        var e = lst[0];
                        sb.AppendFormat("\t\t\t\t{0}, ", e.EntryPointNameOffset);
                        sb.AppendFormat("// SlotID: {0} = {1}", e.SlotID, e.FunctionName);
                        sb.AppendLine("");
                    }
                    else
                    {
                        // write invalid count and such.
                        //sb.AppendLine("\t\t\t\t0, // Dummy placeholder. SlotID is used several places.");
                        sb.AppendFormat("\t\t\t\t0, // ERROR SlotID: {0} is used by several DllImports. Below is a list of them.", i);
                        sb.AppendLine("");

                        foreach (var e in lst)
                        {
                            sb.AppendFormat("\t\t\t\t// DUPLICATE SlotID: {0} is used by {1}", e.SlotID, e.FunctionName);
                            sb.AppendLine("");
                        }
                    }
                }
                else
                {
                    // write placeholder so that array offsets is consistent.
                    sb.AppendFormat("\t\t\t\t0, // SlotID: {0} is Empty", i);
                    sb.AppendLine("");
                }
            }

            // Stage 4.
            // Footer
            sb.Append(sFooter);

#if DEBUG
            Console.WriteLine(sb.ToString());
#endif

            File.WriteAllText(work.Output, sb.ToString());
        }
    }
}
