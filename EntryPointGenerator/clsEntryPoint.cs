using System;
using System.Collections.Generic;
using System.Text;

using System.Diagnostics;

namespace EntryPointGenerator
{
    /// <summary>
    /// Represents a single EntryPoint entry.
    /// </summary>
    [DebuggerDisplay("{SlotID} : {FunctionName}")]
    [DebuggerNonUserCode()]
    public class clsEntryPoint
    {
        public int SlotID { get; set; } = -1;
        public string FunctionName { get; set; }

        // Used by SimpleCodeWriter.
        public int EntryPointNameOffset { get; set; } = 0;
    }
}
