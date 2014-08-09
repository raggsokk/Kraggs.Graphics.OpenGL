using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;


namespace Kraggs.Graphics.OpenGL
{
    partial class DSA
    {
        static DSA()
        {
            EntryPointNames = new byte[]
            {
                0, 0, 0, 0, // dummy function name.
				103, 108, 66, 105, 110, 100, 77, 117, 108, 116, 105, 84, 101, 120, 116, 117, 114, 101, 69, 88, 84, 0, // glBindMultiTextureEXT
				103, 108, 84, 101, 120, 116, 117, 114, 101, 80, 97, 114, 97, 109, 101, 116, 101, 114, 105, 69, 88, 84, 0, // glTextureParameteriEXT
				103, 108, 84, 101, 120, 116, 117, 114, 101, 80, 97, 114, 97, 109, 101, 116, 101, 114, 105, 118, 69, 88, 84, 0, // glTextureParameterivEXT
				103, 108, 84, 101, 120, 116, 117, 114, 101, 80, 97, 114, 97, 109, 101, 116, 101, 114, 102, 69, 88, 84, 0, // glTextureParameterfEXT
				103, 108, 84, 101, 120, 116, 117, 114, 101, 80, 97, 114, 97, 109, 101, 116, 101, 114, 102, 118, 69, 88, 84, 0, // glTextureParameterfvEXT
				103, 108, 84, 101, 120, 116, 117, 114, 101, 73, 109, 97, 103, 101, 49, 68, 69, 88, 84, 0, // glTextureImage1DEXT
				103, 108, 84, 101, 120, 116, 117, 114, 101, 73, 109, 97, 103, 101, 50, 68, 69, 88, 84, 0, // glTextureImage2DEXT
				103, 108, 84, 101, 120, 116, 117, 114, 101, 83, 117, 98, 73, 109, 97, 103, 101, 49, 68, 69, 88, 84, 0, // glTextureSubImage1DEXT
				103, 108, 84, 101, 120, 116, 117, 114, 101, 83, 117, 98, 73, 109, 97, 103, 101, 50, 68, 69, 88, 84, 0, // glTextureSubImage2DEXT
				103, 108, 71, 101, 116, 84, 101, 120, 116, 117, 114, 101, 73, 109, 97, 103, 101, 69, 88, 84, 0, // glGetTextureImageEXT
				103, 108, 71, 101, 116, 84, 101, 120, 116, 117, 114, 101, 80, 97, 114, 97, 109, 101, 116, 101, 114, 105, 118, 69, 88, 84, 0, // glGetTextureParameterivEXT
				103, 108, 71, 101, 116, 84, 101, 120, 116, 117, 114, 101, 80, 97, 114, 97, 109, 101, 116, 101, 114, 102, 118, 69, 88, 84, 0, // glGetTextureParameterfvEXT
				103, 108, 71, 101, 116, 84, 101, 120, 116, 117, 114, 101, 76, 101, 118, 101, 108, 80, 97, 114, 97, 109, 101, 116, 101, 114, 102, 118, 69, 88, 84, 0, // glGetTextureLevelParameterfvEXT
				103, 108, 71, 101, 116, 84, 101, 120, 116, 117, 114, 101, 76, 101, 118, 101, 108, 80, 97, 114, 97, 109, 101, 116, 101, 114, 105, 118, 69, 88, 84, 0, // glGetTextureLevelParameterivEXT
				103, 108, 84, 101, 120, 116, 117, 114, 101, 73, 109, 97, 103, 101, 51, 68, 69, 88, 84, 0, // glTextureImage3DEXT
				103, 108, 84, 101, 120, 116, 117, 114, 101, 83, 117, 98, 73, 109, 97, 103, 101, 51, 68, 69, 88, 84, 0, // glTextureSubImage3DEXT
				103, 108, 67, 111, 112, 121, 84, 101, 120, 116, 117, 114, 101, 83, 117, 98, 73, 109, 97, 103, 101, 51, 68, 69, 88, 84, 0, // glCopyTextureSubImage3DEXT
				103, 108, 67, 111, 109, 112, 114, 101, 115, 115, 101, 100, 84, 101, 120, 116, 117, 114, 101, 73, 109, 97, 103, 101, 49, 68, 69, 88, 84, 0, // glCompressedTextureImage1DEXT
				103, 108, 67, 111, 109, 112, 114, 101, 115, 115, 101, 100, 84, 101, 120, 116, 117, 114, 101, 73, 109, 97, 103, 101, 50, 68, 69, 88, 84, 0, // glCompressedTextureImage2DEXT
				103, 108, 67, 111, 109, 112, 114, 101, 115, 115, 101, 100, 84, 101, 120, 116, 117, 114, 101, 73, 109, 97, 103, 101, 51, 68, 69, 88, 84, 0, // glCompressedTextureImage3DEXT
				103, 108, 67, 111, 109, 112, 114, 101, 115, 115, 101, 100, 84, 101, 120, 116, 117, 114, 101, 83, 117, 98, 73, 109, 97, 103, 101, 49, 68, 69, 88, 84, 0, // glCompressedTextureSubImage1DEXT
				103, 108, 67, 111, 109, 112, 114, 101, 115, 115, 101, 100, 84, 101, 120, 116, 117, 114, 101, 83, 117, 98, 73, 109, 97, 103, 101, 50, 68, 69, 88, 84, 0, // glCompressedTextureSubImage2DEXT
				103, 108, 67, 111, 109, 112, 114, 101, 115, 115, 101, 100, 84, 101, 120, 116, 117, 114, 101, 83, 117, 98, 73, 109, 97, 103, 101, 51, 68, 69, 88, 84, 0, // glCompressedTextureSubImage3DEXT
				103, 108, 71, 101, 116, 67, 111, 109, 112, 114, 101, 115, 115, 101, 100, 84, 101, 120, 116, 117, 114, 101, 73, 109, 97, 103, 101, 69, 88, 84, 0, // glGetCompressedTextureImageEXT
				103, 108, 78, 97, 109, 101, 100, 66, 117, 102, 102, 101, 114, 68, 97, 116, 97, 69, 88, 84, 0, // glNamedBufferDataEXT
				103, 108, 78, 97, 109, 101, 100, 66, 117, 102, 102, 101, 114, 83, 117, 98, 68, 97, 116, 97, 69, 88, 84, 0, // glNamedBufferSubDataEXT
				103, 108, 77, 97, 112, 78, 97, 109, 101, 100, 66, 117, 102, 102, 101, 114, 69, 88, 84, 0, // glMapNamedBufferEXT
				103, 108, 85, 110, 109, 97, 112, 78, 97, 109, 101, 100, 66, 117, 102, 102, 101, 114, 69, 88, 84, 0, // glUnmapNamedBufferEXT
				103, 108, 71, 101, 116, 78, 97, 109, 101, 100, 66, 117, 102, 102, 101, 114, 80, 97, 114, 97, 109, 101, 116, 101, 114, 105, 118, 69, 88, 84, 0, // glGetNamedBufferParameterivEXT
				103, 108, 71, 101, 116, 78, 97, 109, 101, 100, 66, 117, 102, 102, 101, 114, 80, 111, 105, 110, 116, 101, 114, 118, 69, 88, 84, 0, // glGetNamedBufferPointervEXT
				103, 108, 71, 101, 116, 78, 97, 109, 101, 100, 66, 117, 102, 102, 101, 114, 83, 117, 98, 68, 97, 116, 97, 69, 88, 84, 0, // glGetNamedBufferSubDataEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 49, 102, 69, 88, 84, 0, // glProgramUniform1fEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 49, 105, 69, 88, 84, 0, // glProgramUniform1iEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 50, 102, 69, 88, 84, 0, // glProgramUniform2fEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 50, 105, 69, 88, 84, 0, // glProgramUniform2iEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 51, 102, 69, 88, 84, 0, // glProgramUniform3fEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 51, 105, 69, 88, 84, 0, // glProgramUniform3iEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 52, 102, 69, 88, 84, 0, // glProgramUniform4fEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 52, 105, 69, 88, 84, 0, // glProgramUniform4iEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 49, 102, 118, 69, 88, 84, 0, // glProgramUniform1fvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 49, 105, 118, 69, 88, 84, 0, // glProgramUniform1ivEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 50, 102, 118, 69, 88, 84, 0, // glProgramUniform2fvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 50, 105, 118, 69, 88, 84, 0, // glProgramUniform2ivEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 51, 102, 118, 69, 88, 84, 0, // glProgramUniform3fvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 51, 105, 118, 69, 88, 84, 0, // glProgramUniform3ivEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 52, 102, 118, 69, 88, 84, 0, // glProgramUniform4fvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 52, 105, 118, 69, 88, 84, 0, // glProgramUniform4ivEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 50, 102, 118, 69, 88, 84, 0, // glProgramUniformMatrix2fvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 51, 102, 118, 69, 88, 84, 0, // glProgramUniformMatrix3fvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 52, 102, 118, 69, 88, 84, 0, // glProgramUniformMatrix4fvEXT
            };

            EntryPointNameOffsets = new int[]
            {
				0, // SlotID: 0 is Empty
				4, // SlotID: 1 = glBindMultiTextureEXT
				26, // SlotID: 2 = glTextureParameteriEXT
				49, // SlotID: 3 = glTextureParameterivEXT
				73, // SlotID: 4 = glTextureParameterfEXT
				96, // SlotID: 5 = glTextureParameterfvEXT
				120, // SlotID: 6 = glTextureImage1DEXT
				140, // SlotID: 7 = glTextureImage2DEXT
				160, // SlotID: 8 = glTextureSubImage1DEXT
				183, // SlotID: 9 = glTextureSubImage2DEXT
				206, // SlotID: 10 = glGetTextureImageEXT
				227, // SlotID: 11 = glGetTextureParameterivEXT
				254, // SlotID: 12 = glGetTextureParameterfvEXT
				281, // SlotID: 13 = glGetTextureLevelParameterfvEXT
				313, // SlotID: 14 = glGetTextureLevelParameterivEXT
				345, // SlotID: 15 = glTextureImage3DEXT
				365, // SlotID: 16 = glTextureSubImage3DEXT
				388, // SlotID: 17 = glCopyTextureSubImage3DEXT
				415, // SlotID: 18 = glCompressedTextureImage1DEXT
				445, // SlotID: 19 = glCompressedTextureImage2DEXT
				475, // SlotID: 20 = glCompressedTextureImage3DEXT
				505, // SlotID: 21 = glCompressedTextureSubImage1DEXT
				538, // SlotID: 22 = glCompressedTextureSubImage2DEXT
				571, // SlotID: 23 = glCompressedTextureSubImage3DEXT
				604, // SlotID: 24 = glGetCompressedTextureImageEXT
				635, // SlotID: 25 = glNamedBufferDataEXT
				656, // SlotID: 26 = glNamedBufferSubDataEXT
				680, // SlotID: 27 = glMapNamedBufferEXT
				700, // SlotID: 28 = glUnmapNamedBufferEXT
				722, // SlotID: 29 = glGetNamedBufferParameterivEXT
				753, // SlotID: 30 = glGetNamedBufferPointervEXT
				781, // SlotID: 31 = glGetNamedBufferSubDataEXT
				808, // SlotID: 32 = glProgramUniform1fEXT
				830, // SlotID: 33 = glProgramUniform1iEXT
				852, // SlotID: 34 = glProgramUniform2fEXT
				874, // SlotID: 35 = glProgramUniform2iEXT
				896, // SlotID: 36 = glProgramUniform3fEXT
				918, // SlotID: 37 = glProgramUniform3iEXT
				940, // SlotID: 38 = glProgramUniform4fEXT
				962, // SlotID: 39 = glProgramUniform4iEXT
				984, // SlotID: 40 = glProgramUniform1fvEXT
				1007, // SlotID: 41 = glProgramUniform1ivEXT
				1030, // SlotID: 42 = glProgramUniform2fvEXT
				1053, // SlotID: 43 = glProgramUniform2ivEXT
				1076, // SlotID: 44 = glProgramUniform3fvEXT
				1099, // SlotID: 45 = glProgramUniform3ivEXT
				1122, // SlotID: 46 = glProgramUniform4fvEXT
				1145, // SlotID: 47 = glProgramUniform4ivEXT
				1168, // SlotID: 48 = glProgramUniformMatrix2fvEXT
				1197, // SlotID: 49 = glProgramUniformMatrix3fvEXT
				1226, // SlotID: 50 = glProgramUniformMatrix4fvEXT
            };
     
            EntryPoints = new IntPtr[EntryPointNameOffsets.Length];       
        }
    }
}
