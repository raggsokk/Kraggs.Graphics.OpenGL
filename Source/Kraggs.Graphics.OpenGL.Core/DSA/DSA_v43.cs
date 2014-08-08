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
        //#region Delegate Class

        //partial class Delegates
        //{

        //    #region Delegates

        //    //ARB_clear_buffer_object
        //    public delegate void delClearNamedBufferDataEXT(uint buffer, TextureBufferInternalFormat internalformat, ClearBufferDataFormat format, PixelType type, IntPtr data);
        //    public delegate void delClearNamedBufferSubDataEXT(uint buffer, TextureBufferInternalFormat internalformat, IntPtr offset, IntPtr size, ClearBufferDataFormat format, PixelType type, IntPtr data);

        //    //ARB_texture_buffer_range
        //    public delegate void delTextureBufferRangeEXT(uint TextureID, BufferTextureTarget target, TextureBufferInternalFormat iformat, uint BufferId, IntPtr Offset, IntPtr Size);

        //    //ARB_texture_storage_multisample
        //    public delegate void delTextureStorage2DMultisampleEXT(uint TextureID, TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations);
        //    public delegate void delTextureStorage3DMultisampleEXT(uint TextureID, TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations);

        //    //ARB_vertex_attrib_binding
        //    public delegate void delVertexArrayBindVertexBufferEXT(uint vaobj, uint BindingIndex, uint BufferID, IntPtr Offset, int Stride);
        //    public delegate void delVertexArrayVertexAttribFormatEXT(uint vaobj, uint AttribIndex, int Size, VertexAttribFormat type, bool normalized, uint relativeOffset);
        //    public delegate void delVertexArrayVertexAttribIFormatEXT(uint vaobj, uint AttribIndex, int Size, VertexAttribIFormat type, uint relativeOffset);
        //    public delegate void delVertexArrayVertexAttribLFormatEXT(uint vaobj, uint AttribIndex, int Size, VertexAttribLFormat type, uint relativeOffset);

        //    public delegate void delVertexArrayVertexAttribBindingEXT(uint vaobj, uint AttribIndex, uint BindingIndex);
        //    public delegate void delVertexArrayVertexBindingDivisorEXT(uint vaobj, uint BindingIndex, uint Divisor);

        //    //ARB_framebuffer_no_attachments
        //    public delegate void delNamedFramebufferParameteriEXT(uint framebuffer, FramebufferParameters pname, int param);
        //    public delegate void delGetNamedFramebufferParameterivEXT(uint framebuffer, FramebufferParameters pname, ref int @params);

        //    #endregion

        //    #region GL Fields

        //    //ARB_clear_buffer_object
        //    public static delClearNamedBufferDataEXT glClearNamedBufferDataEXT;
        //    public static delClearNamedBufferSubDataEXT glClearNamedBufferSubDataEXT;

        //    //ARB_texture_buffer_range
        //    public static delTextureBufferRangeEXT glTextureBufferRangeEXT;

        //    //ARB_texture_storage_multisample
        //    public static delTextureStorage2DMultisampleEXT glTextureStorage2DMultisampleEXT;
        //    public static delTextureStorage3DMultisampleEXT glTextureStorage3DMultisampleEXT;

        //    //ARB_vertex_attrib_binding
        //    public static delVertexArrayBindVertexBufferEXT glVertexArrayBindVertexBufferEXT;
        //    public static delVertexArrayVertexAttribFormatEXT glVertexArrayVertexAttribFormatEXT;
        //    public static delVertexArrayVertexAttribIFormatEXT glVertexArrayVertexAttribIFormatEXT;
        //    public static delVertexArrayVertexAttribLFormatEXT glVertexArrayVertexAttribLFormatEXT;

        //    public static delVertexArrayVertexAttribBindingEXT glVertexArrayVertexAttribBindingEXT;
        //    public static delVertexArrayVertexBindingDivisorEXT glVertexArrayVertexBindingDivisorEXT;

        //    //ARB_framebuffer_no_attachments
        //    public static delNamedFramebufferParameteriEXT glNamedFramebufferParameteriEXT;
        //    public static delGetNamedFramebufferParameterivEXT glGetNamedFramebufferParameterivEXT;


        //    #endregion
        //}

        //#endregion

        //#region Public functions.

        ////ARB_clear_buffer_object
        //public static void ClearNamedBufferDataEXT(uint buffer, TextureBufferInternalFormat internalformat, ClearBufferDataFormat format, PixelType type, IntPtr data)
        //{
        //    Delegates.glClearNamedBufferDataEXT(buffer, internalformat, format, type, data);
        //}
        //public static void ClearNamedBufferSubDataEXT(uint buffer, TextureBufferInternalFormat internalformat, long offset, long size, ClearBufferDataFormat format, PixelType type, IntPtr data)
        //{
        //    Delegates.glClearNamedBufferSubDataEXT(buffer, internalformat, (IntPtr)offset, (IntPtr)size, format, type, data);
        //}

        ////ARB_texture_buffer_range
        //public static void TextureBufferRangeEXT(uint TextureID, BufferTextureTarget target, TextureBufferInternalFormat iformat, uint BufferId, IntPtr Offset, IntPtr Size)
        //{
        //    Delegates.glTextureBufferRangeEXT(TextureID, target, iformat, BufferId, Offset, Size);
        //}

        ////ARB_texture_storage_multisample
        ///// <summary>
        ///// Allocates multisample storage for a named texture id.
        ///// </summary>
        ///// <param name="TextureID">id of texture to allocat multisample storage.</param>
        ///// <param name="target">Texture target of texture.</param>
        ///// <param name="samples">Number of samples to allocate</param>
        ///// <param name="piformat">Format of storage.</param>
        ///// <param name="width">Width of texture.</param>
        ///// <param name="height">Height of texture.</param>
        ///// <param name="fixedSampleLocations">Should we use fixed sample locations?</param>
        //public static void TextureStorage2DMultisampleEXT(uint TextureID, TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations)
        //{
        //    Delegates.glTextureStorage2DMultisampleEXT(TextureID, target, samples, piformat, width, height, fixedSampleLocations);
        //}
        ///// <summary>
        ///// Allocates multisample storage for a named texture id.
        ///// </summary>
        ///// <param name="TextureID">id of texture to allocat multisample storage.</param>
        ///// <param name="target">Texture target of texture.</param>
        ///// <param name="samples">Number of samples to allocate</param>
        ///// <param name="piformat">Format of storage.</param>
        ///// <param name="width">Width of texture.</param>
        ///// <param name="height">Height of texture.</param>
        ///// <param name="depth">Depth of texture.</param>
        ///// <param name="fixedSampleLocations">Should we use fixed sample locations?</param>
        //public static void TextureStorage3DMultisampleEXT(uint TextureID, TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations)
        //{
        //    Delegates.glTextureStorage3DMultisampleEXT(TextureID, target, samples, piformat, width, height, depth, fixedSampleLocations);
        //}

        ////ARB_vertex_attrib_binding
        //public static void VertexArrayBindVertexBufferEXT(uint vaobj, uint BindingIndex, uint BufferID, int Stride, long Offset = 0)
        //{
        //    Debug.Assert(Stride != 0, "OpenGL Vertex Binding API dont support 0 stride any more!");
        //    Delegates.glVertexArrayBindVertexBufferEXT(vaobj, BindingIndex, BufferID, (IntPtr)Offset, Stride);
        //}
        //public static void VertexArrayVertexAttribFormatEXT(uint vaobj, uint AttribIndex, int Size, VertexAttribFormat type, uint relativeOffset, bool normalized = false)
        //{
        //    Delegates.glVertexArrayVertexAttribFormatEXT(vaobj, AttribIndex, Size, type, normalized, relativeOffset);
        //}
        //public static void VertexArrayVertexAttribIFormatEXT(uint vaobj, uint AttribIndex, int Size, VertexAttribIFormat type, uint relativeOffset)
        //{
        //    Delegates.glVertexArrayVertexAttribIFormatEXT(vaobj, AttribIndex, Size, type, relativeOffset);
        //}
        //public static void VertexArrayVertexAttribLFormatEXT(uint vaobj, uint AttribIndex, int Size, VertexAttribLFormat type, uint relativeOffset)
        //{
        //    Delegates.glVertexArrayVertexAttribLFormatEXT(vaobj, AttribIndex, Size, type, relativeOffset);
        //}

        //public static void VertexArrayVertexAttribBindingEXT(uint vaobj, uint AttribIndex, uint BindingIndex)
        //{
        //    Delegates.glVertexArrayVertexAttribBindingEXT(vaobj, AttribIndex, BindingIndex);
        //}
        //public static void VertexArrayVertexBindingDivisorEXT(uint vaobj, uint BindingIndex, uint Divisor)
        //{
        //    Delegates.glVertexArrayVertexBindingDivisorEXT(vaobj, BindingIndex, Divisor);
        //}

        ////ARB_framebuffer_no_attachments
        //public static void NamedFramebufferParameteriEXT(uint framebuffer, FramebufferParameters pname, int param)
        //{
        //    Delegates.glNamedFramebufferParameteriEXT(framebuffer, pname, param);
        //}
        //public static void GetNamedFramebufferParameterivEXT(uint framebuffer, FramebufferParameters pname, int[] @params)
        //{
        //    Delegates.glGetNamedFramebufferParameterivEXT(framebuffer, pname, ref @params[0]);
        //}
        //public static int GetNamedFramebufferParameterivEXT(uint framebuffer, FramebufferParameters pname)
        //{
        //    int tmp = 0;
        //    Delegates.glGetNamedFramebufferParameterivEXT(framebuffer, pname, ref tmp);
        //    return tmp;
        //}

        //#endregion
    }
}
