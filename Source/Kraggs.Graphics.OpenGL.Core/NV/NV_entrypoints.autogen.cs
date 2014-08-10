using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;


namespace Kraggs.Graphics.OpenGL
{
    partial class NV
    {
        static NV()
        {
            EntryPointNames = new byte[]
            {
                0, 0, 0, 0, // dummy function name.
				103, 108, 68, 114, 97, 119, 84, 101, 120, 116, 117, 114, 101, 78, 86, 0, // glDrawTextureNV
				103, 108, 77, 97, 107, 101, 66, 117, 102, 102, 101, 114, 82, 101, 115, 105, 100, 101, 110, 116, 78, 86, 0, // glMakeBufferResidentNV
				103, 108, 77, 97, 107, 101, 66, 117, 102, 102, 101, 114, 78, 111, 110, 82, 101, 115, 105, 100, 101, 110, 116, 78, 86, 0, // glMakeBufferNonResidentNV
				103, 108, 73, 115, 66, 117, 102, 102, 101, 114, 82, 101, 115, 105, 100, 101, 110, 116, 78, 86, 0, // glIsBufferResidentNV
				103, 108, 77, 97, 107, 101, 78, 97, 109, 101, 100, 66, 117, 102, 102, 101, 114, 82, 101, 115, 105, 100, 101, 110, 116, 78, 86, 0, // glMakeNamedBufferResidentNV
				103, 108, 77, 97, 107, 101, 78, 97, 109, 101, 100, 66, 117, 102, 102, 101, 114, 78, 111, 110, 82, 101, 115, 105, 100, 101, 110, 116, 78, 86, 0, // glMakeNamedBufferNonResidentNV
				103, 108, 73, 115, 78, 97, 109, 101, 100, 66, 117, 102, 102, 101, 114, 82, 101, 115, 105, 100, 101, 110, 116, 78, 86, 0, // glIsNamedBufferResidentNV
				103, 108, 71, 101, 116, 66, 117, 102, 102, 101, 114, 80, 97, 114, 97, 109, 101, 116, 101, 114, 117, 105, 54, 52, 118, 78, 86, 0, // glGetBufferParameterui64vNV
				103, 108, 71, 101, 116, 78, 97, 109, 101, 100, 66, 117, 102, 102, 101, 114, 80, 97, 114, 97, 109, 101, 116, 101, 114, 117, 105, 54, 52, 118, 78, 86, 0, // glGetNamedBufferParameterui64vNV
				103, 108, 71, 101, 116, 73, 110, 116, 101, 103, 101, 114, 117, 105, 54, 52, 118, 78, 86, 0, // glGetIntegerui64vNV
				103, 108, 85, 110, 105, 102, 111, 114, 109, 117, 105, 54, 52, 78, 86, 0, // glUniformui64NV
				103, 108, 85, 110, 105, 102, 111, 114, 109, 117, 105, 54, 52, 118, 78, 86, 0, // glUniformui64vNV
				103, 108, 71, 101, 116, 85, 110, 105, 102, 111, 114, 109, 117, 105, 54, 52, 118, 78, 86, 0, // glGetUniformui64vNV
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 117, 105, 54, 52, 78, 86, 0, // glProgramUniformui64NV
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 117, 105, 54, 52, 118, 78, 86, 0, // glProgramUniformui64vNV
				103, 108, 66, 117, 102, 102, 101, 114, 65, 100, 100, 114, 101, 115, 115, 82, 97, 110, 103, 101, 78, 86, 0, // glBufferAddressRangeNV
				103, 108, 86, 101, 114, 116, 101, 120, 65, 116, 116, 114, 105, 98, 70, 111, 114, 109, 97, 116, 78, 86, 0, // glVertexAttribFormatNV
				103, 108, 86, 101, 114, 116, 101, 120, 65, 116, 116, 114, 105, 98, 73, 70, 111, 114, 109, 97, 116, 78, 86, 0, // glVertexAttribIFormatNV
				103, 108, 71, 101, 116, 73, 110, 116, 101, 103, 101, 114, 117, 105, 54, 52, 105, 95, 118, 78, 86, 0, // glGetIntegerui64i_vNV
            };

            EntryPointNameOffsets = new int[]
            {
				0, // SlotID: 0 is Empty
				4, // SlotID: 1 = glDrawTextureNV
				20, // SlotID: 2 = glMakeBufferResidentNV
				43, // SlotID: 3 = glMakeBufferNonResidentNV
				69, // SlotID: 4 = glIsBufferResidentNV
				90, // SlotID: 5 = glMakeNamedBufferResidentNV
				118, // SlotID: 6 = glMakeNamedBufferNonResidentNV
				149, // SlotID: 7 = glIsNamedBufferResidentNV
				175, // SlotID: 8 = glGetBufferParameterui64vNV
				203, // SlotID: 9 = glGetNamedBufferParameterui64vNV
				236, // SlotID: 10 = glGetIntegerui64vNV
				256, // SlotID: 11 = glUniformui64NV
				272, // SlotID: 12 = glUniformui64vNV
				289, // SlotID: 13 = glGetUniformui64vNV
				309, // SlotID: 14 = glProgramUniformui64NV
				332, // SlotID: 15 = glProgramUniformui64vNV
				356, // SlotID: 16 = glBufferAddressRangeNV
				379, // SlotID: 17 = glVertexAttribFormatNV
				402, // SlotID: 18 = glVertexAttribIFormatNV
				426, // SlotID: 19 = glGetIntegerui64i_vNV
            };
     
            EntryPoints = new IntPtr[EntryPointNameOffsets.Length];       
        }
    }
}
