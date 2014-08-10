using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;


namespace Kraggs.Graphics.OpenGL
{
    partial class AMD
    {
        static AMD()
        {
            EntryPointNames = new byte[]
            {
                0, 0, 0, 0, // dummy function name.
				103, 108, 68, 101, 98, 117, 103, 77, 101, 115, 115, 97, 103, 101, 69, 110, 97, 98, 108, 101, 65, 77, 68, 0, // glDebugMessageEnableAMD
				103, 108, 68, 101, 98, 117, 103, 77, 101, 115, 115, 97, 103, 101, 73, 110, 115, 101, 114, 116, 65, 77, 68, 0, // glDebugMessageInsertAMD
				103, 108, 68, 101, 98, 117, 103, 77, 101, 115, 115, 97, 103, 101, 67, 97, 108, 108, 98, 97, 99, 107, 65, 77, 68, 0, // glDebugMessageCallbackAMD
				103, 108, 71, 101, 116, 68, 101, 98, 117, 103, 77, 101, 115, 115, 97, 103, 101, 76, 111, 103, 65, 77, 68, 0, // glGetDebugMessageLogAMD
            };

            EntryPointNameOffsets = new int[]
            {
				0, // SlotID: 0 is Empty
				4, // SlotID: 1 = glDebugMessageEnableAMD
				28, // SlotID: 2 = glDebugMessageInsertAMD
				52, // SlotID: 3 = glDebugMessageCallbackAMD
				78, // SlotID: 4 = glGetDebugMessageLogAMD
            };
     
            EntryPoints = new IntPtr[EntryPointNameOffsets.Length];       
        }
    }
}
