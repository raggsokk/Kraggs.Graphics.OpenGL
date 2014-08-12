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
				103, 108, 68, 101, 98, 117, 103, 77, 101, 115, 115, 97, 103, 101, 67, 111, 110, 116, 114, 111, 108, 65, 82, 66, 0, // glDebugMessageControlARB
				103, 108, 68, 101, 98, 117, 103, 77, 101, 115, 115, 97, 103, 101, 73, 110, 115, 101, 114, 116, 65, 82, 66, 0, // glDebugMessageInsertARB
				103, 108, 68, 101, 98, 117, 103, 77, 101, 115, 115, 97, 103, 101, 67, 97, 108, 108, 98, 97, 99, 107, 65, 82, 66, 0, // glDebugMessageCallbackARB
				103, 108, 71, 101, 116, 68, 101, 98, 117, 103, 77, 101, 115, 115, 97, 103, 101, 76, 111, 103, 65, 82, 66, 0, // glGetDebugMessageLogARB
				103, 108, 71, 101, 116, 80, 111, 105, 110, 116, 101, 114, 118, 65, 82, 66, 0, // glGetPointervARB
				103, 108, 84, 101, 120, 80, 97, 103, 101, 67, 111, 109, 109, 105, 116, 109, 101, 110, 116, 65, 82, 66, 0, // glTexPageCommitmentARB
				103, 108, 78, 97, 109, 101, 100, 83, 116, 114, 105, 110, 103, 65, 82, 66, 0, // glNamedStringARB
				103, 108, 68, 101, 108, 101, 116, 101, 78, 97, 109, 101, 100, 83, 116, 114, 105, 110, 103, 65, 82, 66, 0, // glDeleteNamedStringARB
				103, 108, 67, 111, 109, 112, 105, 108, 101, 83, 104, 97, 100, 101, 114, 73, 110, 99, 108, 117, 100, 101, 65, 82, 66, 0, // glCompileShaderIncludeARB
				103, 108, 73, 115, 78, 97, 109, 101, 100, 83, 116, 114, 105, 110, 103, 65, 82, 66, 0, // glIsNamedStringARB
				103, 108, 71, 101, 116, 78, 97, 109, 101, 100, 83, 116, 114, 105, 110, 103, 65, 82, 66, 0, // glGetNamedStringARB
				103, 108, 71, 101, 116, 78, 97, 109, 101, 100, 83, 116, 114, 105, 110, 103, 105, 118, 65, 82, 66, 0, // glGetNamedStringivARB
				103, 108, 67, 108, 105, 112, 67, 111, 110, 116, 114, 111, 108, 65, 82, 66, 0, // glClipControlARB
				103, 108, 77, 101, 109, 111, 114, 121, 66, 97, 114, 114, 105, 101, 114, 66, 121, 82, 101, 103, 105, 111, 110, 65, 82, 66, 0, // glMemoryBarrierByRegionARB
				103, 108, 71, 101, 116, 84, 101, 120, 116, 117, 114, 101, 83, 117, 98, 73, 109, 97, 103, 101, 65, 82, 66, 0, // glGetTextureSubImageARB
				103, 108, 71, 101, 116, 67, 111, 109, 112, 114, 101, 115, 115, 101, 100, 84, 101, 120, 116, 117, 114, 101, 83, 117, 98, 73, 109, 97, 103, 101, 65, 82, 66, 0, // glGetCompressedTextureSubImageARB
				103, 108, 84, 101, 120, 116, 117, 114, 101, 66, 97, 114, 114, 105, 101, 114, 65, 82, 66, 0, // glTextureBarrierARB
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
				365, // SlotID: 14 = glDebugMessageControlARB
				390, // SlotID: 15 = glDebugMessageInsertARB
				414, // SlotID: 16 = glDebugMessageCallbackARB
				440, // SlotID: 17 = glGetDebugMessageLogARB
				464, // SlotID: 18 = glGetPointervARB
				481, // SlotID: 19 = glTexPageCommitmentARB
				504, // SlotID: 20 = glNamedStringARB
				521, // SlotID: 21 = glDeleteNamedStringARB
				544, // SlotID: 22 = glCompileShaderIncludeARB
				570, // SlotID: 23 = glIsNamedStringARB
				589, // SlotID: 24 = glGetNamedStringARB
				609, // SlotID: 25 = glGetNamedStringivARB
				631, // SlotID: 26 = glClipControlARB
				648, // SlotID: 27 = glMemoryBarrierByRegionARB
				675, // SlotID: 28 = glGetTextureSubImageARB
				699, // SlotID: 29 = glGetCompressedTextureSubImageARB
				733, // SlotID: 30 = glTextureBarrierARB
            };
     
            EntryPoints = new IntPtr[EntryPointNameOffsets.Length];       
        }
    }
}
