#region License

// Kraggs.Graphics.OpenGL (github.com/raggsokk)
//
// Copyright (c) 2014 Jarle Hansen (github.com/raggsokk)
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

#endregion

using System;
using System.Collections.Generic;
using System.Text;

using System.Security;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Kraggs.Graphics.OpenGL
{

    partial class DSA
    {
        #region OpenGL DLLImports

        //ARB_clear_buffer_object
        [EntryPointSlot(118)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glClearNamedBufferDataEXT(uint buffer, TextureBufferInternalFormat internalformat, ClearBufferDataFormat format, PixelType type, IntPtr data);
        [EntryPointSlot(119)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glClearNamedBufferSubDataEXT(uint buffer, TextureBufferInternalFormat internalformat, IntPtr offset, IntPtr size, ClearBufferDataFormat format, PixelType type, IntPtr data);

        //ARB_texture_buffer_range
        [EntryPointSlot(120)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureBufferRangeEXT(uint TextureID, BufferTextureTarget target, TextureBufferInternalFormat iformat, uint BufferId, IntPtr Offset, IntPtr Size);

        //ARB_texture_storage_multisample
        [EntryPointSlot(121)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureStorage2DMultisampleEXT(uint TextureID, TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations);
        [EntryPointSlot(122)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureStorage3DMultisampleEXT(uint TextureID, TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations);

        //ARB_vertex_attrib_binding
        [EntryPointSlot(123)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayBindVertexBufferEXT(uint vaobj, uint BindingIndex, uint BufferID, IntPtr Offset, int Stride);
        [EntryPointSlot(124)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayVertexAttribFormatEXT(uint vaobj, uint AttribIndex, int Size, VertexAttribFormat type, bool normalized, uint relativeOffset);
        [EntryPointSlot(125)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayVertexAttribIFormatEXT(uint vaobj, uint AttribIndex, int Size, VertexAttribIFormat type, uint relativeOffset);
        [EntryPointSlot(126)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayVertexAttribLFormatEXT(uint vaobj, uint AttribIndex, int Size, VertexAttribLFormat type, uint relativeOffset);

        [EntryPointSlot(127)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayVertexAttribBindingEXT(uint vaobj, uint AttribIndex, uint BindingIndex);
        [EntryPointSlot(128)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayVertexBindingDivisorEXT(uint vaobj, uint BindingIndex, uint Divisor);

        //ARB_framebuffer_no_attachments
        [EntryPointSlot(129)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedFramebufferParameteriEXT(uint framebuffer, FramebufferParameters pname, int param);
        [EntryPointSlot(130)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetNamedFramebufferParameterivEXT(uint framebuffer, FramebufferParameters pname, int* result);

        #endregion

        #region Public functions

        //ARB_clear_buffer_object        
        [EntryPoint(FunctionName = "glClearNamedBufferDataEXT")]
        public static void ClearNamedBufferDataEXT(uint buffer, TextureBufferInternalFormat internalformat, ClearBufferDataFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glClearNamedBufferSubDataEXT")]
        public static void ClearNamedBufferSubDataEXT(uint buffer, TextureBufferInternalFormat internalformat, IntPtr offset, IntPtr size, ClearBufferDataFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }

        //ARB_texture_buffer_range
        [EntryPoint(FunctionName = "glTextureBufferRangeEXT")]
        public static void TextureBufferRangeEXT(uint TextureID, BufferTextureTarget target, TextureBufferInternalFormat iformat, uint BufferId, IntPtr Offset, IntPtr Size){ throw new NotImplementedException(); }
        public static void TextureBufferRangeEXT(uint TextureID, TextureBufferInternalFormat iformat, uint BufferId, long Offset, long Size, BufferTextureTarget target = BufferTextureTarget.TextureBuffer)
        {
            TextureBufferRangeEXT(TextureID, target, iformat, BufferId, (IntPtr)Offset, (IntPtr)Size);
        }

        //ARB_texture_storage_multisample
        /// <summary>
        /// Allocates multisample storage for a named texture id.
        /// </summary>
        /// <param name="TextureID">id of texture to allocat multisample storage.</param>
        /// <param name="target">Texture target of texture.</param>
        /// <param name="samples">Number of samples to allocate</param>
        /// <param name="piformat">Format of storage.</param>
        /// <param name="width">Width of texture.</param>
        /// <param name="height">Height of texture.</param>
        /// <param name="fixedSampleLocations">Should we use fixed sample locations?</param>
        [EntryPoint(FunctionName = "glTextureStorage2DMultisampleEXT")]
        public static void TextureStorage2DMultisampleEXT(uint TextureID, TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations){ throw new NotImplementedException(); }

        /// <summary>
        /// Allocates multisample storage for a named texture id.
        /// </summary>
        /// <param name="TextureID">id of texture to allocat multisample storage.</param>
        /// <param name="target">Texture target of texture.</param>
        /// <param name="samples">Number of samples to allocate</param>
        /// <param name="piformat">Format of storage.</param>
        /// <param name="width">Width of texture.</param>
        /// <param name="height">Height of texture.</param>
        /// <param name="depth">Depth of texture.</param>
        /// <param name="fixedSampleLocations">Should we use fixed sample locations?</param>
        [EntryPoint(FunctionName = "glTextureStorage3DMultisampleEXT")]
        public static void TextureStorage3DMultisampleEXT(uint TextureID, TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations){ throw new NotImplementedException(); }

        //ARB_vertex_attrib_binding
        [EntryPoint(FunctionName = "glVertexArrayBindVertexBufferEXT")]
        public static void VertexArrayBindVertexBufferEXT(uint vaobj, uint BindingIndex, uint BufferID, IntPtr Offset, int Stride){ throw new NotImplementedException(); }
        public static void VertexArrayBindVertexBufferEXT(uint vaobj, uint BindingIndex, uint BufferID, int Stride, long Offset = 0)
        {
            Debug.Assert(Stride != 0, "OpenGL Vertex Binding API dont support 0 stride any more!");
            VertexArrayBindVertexBufferEXT(vaobj, BindingIndex, BufferID, (IntPtr)Offset, Stride);
        }

        [EntryPoint(FunctionName = "glVertexArrayVertexAttribFormatEXT")]
        public static void VertexArrayVertexAttribFormatEXT(uint vaobj, uint AttribIndex, int Size, VertexAttribFormat type, bool normalized, uint relativeOffset){ throw new NotImplementedException(); }
        public static void VertexArrayVertexAttribFormatEXT(uint vaobj, uint AttribIndex, int Size, VertexAttribFormat type, uint relativeOffset, bool normalized = false)
        {
            VertexArrayVertexAttribFormatEXT(vaobj, AttribIndex, Size, type, normalized, relativeOffset);
        }
        [EntryPoint(FunctionName = "glVertexArrayVertexAttribIFormatEXT")]
        public static void VertexArrayVertexAttribIFormatEXT(uint vaobj, uint AttribIndex, int Size, VertexAttribIFormat type, uint relativeOffset){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glVertexArrayVertexAttribLFormatEXT")]
        public static void VertexArrayVertexAttribLFormatEXT(uint vaobj, uint AttribIndex, int Size, VertexAttribLFormat type, uint relativeOffset){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glVertexArrayVertexAttribBindingEXT")]
        public static void VertexArrayVertexAttribBindingEXT(uint vaobj, uint AttribIndex, uint BindingIndex){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glVertexArrayVertexBindingDivisorEXT")]
        public static void VertexArrayVertexBindingDivisorEXT(uint vaobj, uint BindingIndex, uint Divisor){ throw new NotImplementedException(); }

        //ARB_framebuffer_no_attachments        
        [EntryPoint(FunctionName = "glNamedFramebufferParameteriEXT")]
        public static void NamedFramebufferParameteriEXT(uint framebuffer, FramebufferParameters pname, int param){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetNamedFramebufferParameterivEXT")]
        unsafe public static void GetNamedFramebufferParameterivEXT(uint framebuffer, FramebufferParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedFramebufferParameterivEXT")]
        public static void GetNamedFramebufferParameterivEXT(uint framebuffer, FramebufferParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedFramebufferParameterivEXT")]
        public static void GetNamedFramebufferParameterivEXT(uint framebuffer, FramebufferParameters pname, ref int result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedFramebufferParameterivEXT")]
        public static int GetNamedFramebufferParameterivEXT(uint framebuffer, FramebufferParameters pname) { throw new NotImplementedException(); }


        #endregion

        #region Public Helper Functions

        #endregion

    }
}
