using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;


namespace Kraggs.Graphics.OpenGL
{
    partial class ARB
    {
        static ARB()
        {
            EntryPointNames = new byte[]
            {
                0, 0, 0, 0, // dummy function name.
				103, 108, 71, 101, 116, 84, 101, 120, 116, 117, 114, 101, 72, 97, 110, 100, 108, 101, 65, 82, 66, 0, // glGetTextureHandleARB
				103, 108, 71, 101, 116, 84, 101, 120, 116, 117, 114, 101, 83, 97, 109, 112, 108, 101, 114, 72, 97, 110, 100, 108, 101, 65, 82, 66, 0, // glGetTextureSamplerHandleARB
				103, 108, 77, 97, 107, 101, 84, 101, 120, 116, 117, 114, 101, 72, 97, 110, 100, 108, 101, 82, 101, 115, 105, 100, 101, 110, 116, 65, 82, 66, 0, // glMakeTextureHandleResidentARB
				103, 108, 77, 97, 107, 101, 84, 101, 120, 116, 117, 114, 101, 72, 97, 110, 100, 108, 101, 78, 111, 110, 82, 101, 115, 105, 100, 101, 110, 116, 65, 82, 66, 0, // glMakeTextureHandleNonResidentARB
				103, 108, 71, 101, 116, 73, 109, 97, 103, 101, 72, 97, 110, 100, 108, 101, 65, 82, 66, 0, // glGetImageHandleARB
				103, 108, 77, 97, 107, 101, 73, 109, 97, 103, 101, 72, 97, 110, 100, 108, 101, 82, 101, 115, 105, 100, 101, 110, 116, 65, 82, 66, 0, // glMakeImageHandleResidentARB
				103, 108, 77, 97, 107, 101, 73, 109, 97, 103, 101, 72, 97, 110, 100, 108, 101, 78, 111, 110, 82, 101, 115, 105, 100, 101, 110, 116, 65, 82, 66, 0, // glMakeImageHandleNonResidentARB
				103, 108, 85, 110, 105, 102, 111, 114, 109, 72, 97, 110, 100, 108, 101, 117, 105, 54, 52, 65, 82, 66, 0, // glUniformHandleui64ARB
				103, 108, 85, 110, 105, 102, 111, 114, 109, 72, 97, 110, 100, 108, 101, 117, 105, 54, 52, 118, 65, 82, 66, 0, // glUniformHandleui64vARB
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 72, 97, 110, 100, 108, 101, 117, 105, 54, 52, 65, 82, 66, 0, // glProgramUniformHandleui64ARB
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 72, 97, 110, 100, 108, 101, 117, 105, 54, 52, 118, 65, 82, 66, 0, // glProgramUniformHandleui64vARB
				103, 108, 73, 115, 84, 101, 120, 116, 117, 114, 101, 72, 97, 110, 100, 108, 101, 82, 101, 115, 105, 100, 101, 110, 116, 65, 82, 66, 0, // glIsTextureHandleResidentARB
				103, 108, 73, 115, 73, 109, 97, 103, 101, 72, 97, 110, 100, 108, 101, 82, 101, 115, 105, 100, 101, 110, 116, 65, 82, 66, 0, // glIsImageHandleResidentARB
            };

            EntryPointNameOffsets = new int[]
            {
				0, // SlotID: 0 is Empty
				4, // SlotID: 1 = glGetTextureHandleARB
				26, // SlotID: 2 = glGetTextureSamplerHandleARB
				55, // SlotID: 3 = glMakeTextureHandleResidentARB
				86, // SlotID: 4 = glMakeTextureHandleNonResidentARB
				120, // SlotID: 5 = glGetImageHandleARB
				140, // SlotID: 6 = glMakeImageHandleResidentARB
				169, // SlotID: 7 = glMakeImageHandleNonResidentARB
				201, // SlotID: 8 = glUniformHandleui64ARB
				224, // SlotID: 9 = glUniformHandleui64vARB
				248, // SlotID: 10 = glProgramUniformHandleui64ARB
				278, // SlotID: 11 = glProgramUniformHandleui64vARB
				309, // SlotID: 12 = glIsTextureHandleResidentARB
				338, // SlotID: 13 = glIsImageHandleResidentARB
            };
     
            EntryPoints = new IntPtr[EntryPointNameOffsets.Length];       
        }
    }
}
