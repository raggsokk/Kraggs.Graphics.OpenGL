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
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 50, 120, 51, 102, 118, 69, 88, 84, 0, // glProgramUniformMatrix2x3fvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 50, 120, 52, 102, 118, 69, 88, 84, 0, // glProgramUniformMatrix2x4fvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 51, 120, 50, 102, 118, 69, 88, 84, 0, // glProgramUniformMatrix3x2fvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 51, 120, 52, 102, 118, 69, 88, 84, 0, // glProgramUniformMatrix3x4fvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 52, 120, 50, 102, 118, 69, 88, 84, 0, // glProgramUniformMatrix4x2fvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 52, 120, 51, 102, 118, 69, 88, 84, 0, // glProgramUniformMatrix4x3fvEXT
				103, 108, 71, 101, 116, 84, 101, 120, 116, 117, 114, 101, 80, 97, 114, 97, 109, 101, 116, 101, 114, 73, 105, 118, 69, 88, 84, 0, // glGetTextureParameterIivEXT
				103, 108, 71, 101, 116, 84, 101, 120, 116, 117, 114, 101, 80, 97, 114, 97, 109, 101, 116, 101, 114, 73, 117, 105, 118, 69, 88, 84, 0, // glGetTextureParameterIuivEXT
				103, 108, 84, 101, 120, 116, 117, 114, 101, 80, 97, 114, 97, 109, 101, 116, 101, 114, 73, 105, 118, 69, 88, 84, 0, // glTextureParameterIivEXT
				103, 108, 84, 101, 120, 116, 117, 114, 101, 80, 97, 114, 97, 109, 101, 116, 101, 114, 73, 117, 105, 118, 69, 88, 84, 0, // glTextureParameterIuivEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 49, 117, 105, 69, 88, 84, 0, // glProgramUniform1uiEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 50, 117, 105, 69, 88, 84, 0, // glProgramUniform2uiEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 51, 117, 105, 69, 88, 84, 0, // glProgramUniform3uiEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 52, 117, 105, 69, 88, 84, 0, // glProgramUniform4uiEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 49, 117, 105, 118, 69, 88, 84, 0, // glProgramUniform1uivEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 50, 117, 105, 118, 69, 88, 84, 0, // glProgramUniform2uivEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 51, 117, 105, 118, 69, 88, 84, 0, // glProgramUniform3uivEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 52, 117, 105, 118, 69, 88, 84, 0, // glProgramUniform4uivEXT
				103, 108, 78, 97, 109, 101, 100, 82, 101, 110, 100, 101, 114, 98, 117, 102, 102, 101, 114, 83, 116, 111, 114, 97, 103, 101, 69, 88, 84, 0, // glNamedRenderbufferStorageEXT
				103, 108, 71, 101, 116, 78, 97, 109, 101, 100, 82, 101, 110, 100, 101, 114, 98, 117, 102, 102, 101, 114, 80, 97, 114, 97, 109, 101, 116, 101, 114, 105, 118, 69, 88, 84, 0, // glGetNamedRenderbufferParameterivEXT
				103, 108, 78, 97, 109, 101, 100, 82, 101, 110, 100, 101, 114, 98, 117, 102, 102, 101, 114, 83, 116, 111, 114, 97, 103, 101, 77, 117, 108, 116, 105, 115, 97, 109, 112, 108, 101, 69, 88, 84, 0, // glNamedRenderbufferStorageMultisampleEXT
				103, 108, 78, 97, 109, 101, 100, 82, 101, 110, 100, 101, 114, 98, 117, 102, 102, 101, 114, 83, 116, 111, 114, 97, 103, 101, 77, 117, 108, 116, 105, 115, 97, 109, 112, 108, 101, 67, 111, 118, 101, 114, 97, 103, 101, 69, 88, 84, 0, // glNamedRenderbufferStorageMultisampleCoverageEXT
				103, 108, 67, 104, 101, 99, 107, 78, 97, 109, 101, 100, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 83, 116, 97, 116, 117, 115, 69, 88, 84, 0, // glCheckNamedFramebufferStatusEXT
				103, 108, 78, 97, 109, 101, 100, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 84, 101, 120, 116, 117, 114, 101, 49, 68, 69, 88, 84, 0, // glNamedFramebufferTexture1DEXT
				103, 108, 78, 97, 109, 101, 100, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 84, 101, 120, 116, 117, 114, 101, 50, 68, 69, 88, 84, 0, // glNamedFramebufferTexture2DEXT
				103, 108, 78, 97, 109, 101, 100, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 84, 101, 120, 116, 117, 114, 101, 51, 68, 69, 88, 84, 0, // glNamedFramebufferTexture3DEXT
				103, 108, 78, 97, 109, 101, 100, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 82, 101, 110, 100, 101, 114, 98, 117, 102, 102, 101, 114, 69, 88, 84, 0, // glNamedFramebufferRenderbufferEXT
				103, 108, 71, 101, 116, 78, 97, 109, 101, 100, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 65, 116, 116, 97, 99, 104, 109, 101, 110, 116, 80, 97, 114, 97, 109, 101, 116, 101, 114, 105, 118, 69, 88, 84, 0, // glGetNamedFramebufferAttachmentParameterivEXT
				103, 108, 71, 101, 110, 101, 114, 97, 116, 101, 84, 101, 120, 116, 117, 114, 101, 77, 105, 112, 109, 97, 112, 69, 88, 84, 0, // glGenerateTextureMipmapEXT
				103, 108, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 68, 114, 97, 119, 66, 117, 102, 102, 101, 114, 69, 88, 84, 0, // glFramebufferDrawBufferEXT
				103, 108, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 68, 114, 97, 119, 66, 117, 102, 102, 101, 114, 115, 69, 88, 84, 0, // glFramebufferDrawBuffersEXT
				103, 108, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 82, 101, 97, 100, 66, 117, 102, 102, 101, 114, 69, 88, 84, 0, // glFramebufferReadBufferEXT
				103, 108, 71, 101, 116, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 80, 97, 114, 97, 109, 101, 116, 101, 114, 105, 118, 69, 88, 84, 0, // glGetFramebufferParameterivEXT
				103, 108, 86, 101, 114, 116, 101, 120, 65, 114, 114, 97, 121, 86, 101, 114, 116, 101, 120, 65, 116, 116, 114, 105, 98, 79, 102, 102, 115, 101, 116, 69, 88, 84, 0, // glVertexArrayVertexAttribOffsetEXT
				103, 108, 86, 101, 114, 116, 101, 120, 65, 114, 114, 97, 121, 86, 101, 114, 116, 101, 120, 65, 116, 116, 114, 105, 98, 73, 79, 102, 102, 115, 101, 116, 69, 88, 84, 0, // glVertexArrayVertexAttribIOffsetEXT
				103, 108, 69, 110, 97, 98, 108, 101, 86, 101, 114, 116, 101, 120, 65, 114, 114, 97, 121, 65, 116, 116, 114, 105, 98, 69, 88, 84, 0, // glEnableVertexArrayAttribEXT
				103, 108, 68, 105, 115, 97, 98, 108, 101, 86, 101, 114, 116, 101, 120, 65, 114, 114, 97, 121, 65, 116, 116, 114, 105, 98, 69, 88, 84, 0, // glDisableVertexArrayAttribEXT
				103, 108, 71, 101, 116, 86, 101, 114, 116, 101, 120, 65, 114, 114, 97, 121, 73, 110, 116, 101, 103, 101, 114, 118, 69, 88, 84, 0, // glGetVertexArrayIntegervEXT
				103, 108, 71, 101, 116, 86, 101, 114, 116, 101, 120, 65, 114, 114, 97, 121, 80, 111, 105, 110, 116, 101, 114, 118, 69, 88, 84, 0, // glGetVertexArrayPointervEXT
				103, 108, 71, 101, 116, 86, 101, 114, 116, 101, 120, 65, 114, 114, 97, 121, 73, 110, 116, 101, 103, 101, 114, 105, 95, 118, 69, 88, 84, 0, // glGetVertexArrayIntegeri_vEXT
				103, 108, 71, 101, 116, 86, 101, 114, 116, 101, 120, 65, 114, 114, 97, 121, 80, 111, 105, 110, 116, 101, 114, 105, 95, 118, 69, 88, 84, 0, // glGetVertexArrayPointeri_vEXT
				103, 108, 70, 108, 117, 115, 104, 77, 97, 112, 112, 101, 100, 78, 97, 109, 101, 100, 66, 117, 102, 102, 101, 114, 82, 97, 110, 103, 101, 69, 88, 84, 0, // glFlushMappedNamedBufferRangeEXT
				103, 108, 77, 97, 112, 78, 97, 109, 101, 100, 66, 117, 102, 102, 101, 114, 82, 97, 110, 103, 101, 69, 88, 84, 0, // glMapNamedBufferRangeEXT
				103, 108, 84, 101, 120, 116, 117, 114, 101, 66, 117, 102, 102, 101, 114, 69, 88, 84, 0, // glTextureBufferEXT
				103, 108, 78, 97, 109, 101, 100, 67, 111, 112, 121, 66, 117, 102, 102, 101, 114, 83, 117, 98, 68, 97, 116, 97, 69, 88, 84, 0, // glNamedCopyBufferSubDataEXT
				103, 108, 86, 101, 114, 116, 101, 120, 65, 114, 114, 97, 121, 86, 101, 114, 116, 101, 120, 65, 116, 116, 114, 105, 98, 68, 105, 118, 105, 115, 111, 114, 69, 88, 84, 0, // glVertexArrayVertexAttribDivisorEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 49, 100, 69, 88, 84, 0, // glProgramUniform1dEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 50, 100, 69, 88, 84, 0, // glProgramUniform2dEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 51, 100, 69, 88, 84, 0, // glProgramUniform3dEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 52, 100, 69, 88, 84, 0, // glProgramUniform4dEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 49, 100, 118, 69, 88, 84, 0, // glProgramUniform1dvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 50, 100, 118, 69, 88, 84, 0, // glProgramUniform2dvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 51, 100, 118, 69, 88, 84, 0, // glProgramUniform3dvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 52, 100, 118, 69, 88, 84, 0, // glProgramUniform4dvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 50, 100, 118, 69, 88, 84, 0, // glProgramUniformMatrix2dvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 51, 100, 118, 69, 88, 84, 0, // glProgramUniformMatrix3dvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 52, 100, 118, 69, 88, 84, 0, // glProgramUniformMatrix4dvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 50, 120, 51, 100, 118, 69, 88, 84, 0, // glProgramUniformMatrix2x3dvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 50, 120, 52, 100, 118, 69, 88, 84, 0, // glProgramUniformMatrix2x4dvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 51, 120, 50, 100, 118, 69, 88, 84, 0, // glProgramUniformMatrix3x2dvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 51, 120, 52, 100, 118, 69, 88, 84, 0, // glProgramUniformMatrix3x4dvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 52, 120, 50, 100, 118, 69, 88, 84, 0, // glProgramUniformMatrix4x2dvEXT
				103, 108, 80, 114, 111, 103, 114, 97, 109, 85, 110, 105, 102, 111, 114, 109, 77, 97, 116, 114, 105, 120, 52, 120, 51, 100, 118, 69, 88, 84, 0, // glProgramUniformMatrix4x3dvEXT
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
				1255, // SlotID: 51 = glProgramUniformMatrix2x3fvEXT
				1286, // SlotID: 52 = glProgramUniformMatrix2x4fvEXT
				1317, // SlotID: 53 = glProgramUniformMatrix3x2fvEXT
				1348, // SlotID: 54 = glProgramUniformMatrix3x4fvEXT
				1379, // SlotID: 55 = glProgramUniformMatrix4x2fvEXT
				1410, // SlotID: 56 = glProgramUniformMatrix4x3fvEXT
				1441, // SlotID: 57 = glGetTextureParameterIivEXT
				1469, // SlotID: 58 = glGetTextureParameterIuivEXT
				1498, // SlotID: 59 = glTextureParameterIivEXT
				1523, // SlotID: 60 = glTextureParameterIuivEXT
				1549, // SlotID: 61 = glProgramUniform1uiEXT
				1572, // SlotID: 62 = glProgramUniform2uiEXT
				1595, // SlotID: 63 = glProgramUniform3uiEXT
				1618, // SlotID: 64 = glProgramUniform4uiEXT
				1641, // SlotID: 65 = glProgramUniform1uivEXT
				1665, // SlotID: 66 = glProgramUniform2uivEXT
				1689, // SlotID: 67 = glProgramUniform3uivEXT
				1713, // SlotID: 68 = glProgramUniform4uivEXT
				1737, // SlotID: 69 = glNamedRenderbufferStorageEXT
				1767, // SlotID: 70 = glGetNamedRenderbufferParameterivEXT
				1804, // SlotID: 71 = glNamedRenderbufferStorageMultisampleEXT
				1845, // SlotID: 72 = glNamedRenderbufferStorageMultisampleCoverageEXT
				1894, // SlotID: 73 = glCheckNamedFramebufferStatusEXT
				1927, // SlotID: 74 = glNamedFramebufferTexture1DEXT
				1958, // SlotID: 75 = glNamedFramebufferTexture2DEXT
				1989, // SlotID: 76 = glNamedFramebufferTexture3DEXT
				2020, // SlotID: 77 = glNamedFramebufferRenderbufferEXT
				2054, // SlotID: 78 = glGetNamedFramebufferAttachmentParameterivEXT
				2100, // SlotID: 79 = glGenerateTextureMipmapEXT
				2127, // SlotID: 80 = glFramebufferDrawBufferEXT
				2154, // SlotID: 81 = glFramebufferDrawBuffersEXT
				2182, // SlotID: 82 = glFramebufferReadBufferEXT
				2209, // SlotID: 83 = glGetFramebufferParameterivEXT
				2240, // SlotID: 84 = glVertexArrayVertexAttribOffsetEXT
				2275, // SlotID: 85 = glVertexArrayVertexAttribIOffsetEXT
				2311, // SlotID: 86 = glEnableVertexArrayAttribEXT
				2340, // SlotID: 87 = glDisableVertexArrayAttribEXT
				2370, // SlotID: 88 = glGetVertexArrayIntegervEXT
				2398, // SlotID: 89 = glGetVertexArrayPointervEXT
				2426, // SlotID: 90 = glGetVertexArrayIntegeri_vEXT
				2456, // SlotID: 91 = glGetVertexArrayPointeri_vEXT
				2486, // SlotID: 92 = glFlushMappedNamedBufferRangeEXT
				2519, // SlotID: 93 = glMapNamedBufferRangeEXT
				2544, // SlotID: 94 = glTextureBufferEXT
				2563, // SlotID: 95 = glNamedCopyBufferSubDataEXT
				2591, // SlotID: 96 = glVertexArrayVertexAttribDivisorEXT
				2627, // SlotID: 97 = glProgramUniform1dEXT
				2649, // SlotID: 98 = glProgramUniform2dEXT
				2671, // SlotID: 99 = glProgramUniform3dEXT
				2693, // SlotID: 100 = glProgramUniform4dEXT
				2715, // SlotID: 101 = glProgramUniform1dvEXT
				2738, // SlotID: 102 = glProgramUniform2dvEXT
				2761, // SlotID: 103 = glProgramUniform3dvEXT
				2784, // SlotID: 104 = glProgramUniform4dvEXT
				2807, // SlotID: 105 = glProgramUniformMatrix2dvEXT
				2836, // SlotID: 106 = glProgramUniformMatrix3dvEXT
				2865, // SlotID: 107 = glProgramUniformMatrix4dvEXT
				2894, // SlotID: 108 = glProgramUniformMatrix2x3dvEXT
				2925, // SlotID: 109 = glProgramUniformMatrix2x4dvEXT
				2956, // SlotID: 110 = glProgramUniformMatrix3x2dvEXT
				2987, // SlotID: 111 = glProgramUniformMatrix3x4dvEXT
				3018, // SlotID: 112 = glProgramUniformMatrix4x2dvEXT
				3049, // SlotID: 113 = glProgramUniformMatrix4x3dvEXT
            };
     
            EntryPoints = new IntPtr[EntryPointNameOffsets.Length];       
        }
    }
}
