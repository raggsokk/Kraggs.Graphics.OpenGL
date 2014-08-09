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

        [EntryPointSlot(94)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureBufferEXT(uint TextureID, BufferTextureTarget target, TextureBufferInternalFormat format, uint BufferID);
        [EntryPointSlot(95)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedCopyBufferSubDataEXT(uint ReadBufferID, uint WriteBufferID, IntPtr readOffset, IntPtr writeOffset, IntPtr Size);


        #endregion

        #region Public functions


        /// <summary>
        /// Creates a texture buffer on named texture with named buffer as backing store.
        /// </summary>
        /// <param name="TextureID">Valid unallocated texture id.</param>
        /// <param name="format">BufferTexture Format</param>
        /// <param name="BufferID">Buffer id of backing store to texture buffer.</param>
        /// <param name="target">Type of buffer texture to create.</param>
        [EntryPoint(FunctionName = "glTextureBufferEXT")]
        public static void TextureBufferEXT(uint TextureID, BufferTextureTarget target, TextureBufferInternalFormat format, uint BufferID) { throw new NotImplementedException(); }
        /// <summary>
        /// Creates a texture buffer on named texture with named buffer as backing store.
        /// </summary>
        /// <param name="TextureID">Valid unallocated texture id.</param>
        /// <param name="format">BufferTexture Format</param>
        /// <param name="BufferID">Buffer id of backing store to texture buffer.</param>
        /// <param name="target">Type of buffer texture to create.</param>
        public static void TextureBufferEXT(uint TextureID, TextureBufferInternalFormat format, uint BufferID, BufferTextureTarget target = BufferTextureTarget.TextureBuffer)
        {
            TextureBufferEXT(TextureID, target, format, BufferID);
        }

        /// <summary>
        /// Copies data from read buffer id to write buffer id.
        /// </summary>
        /// <param name="ReadBufferID">id of buffer to read data from.</param>
        /// <param name="WriteBufferID">id of buffer to write data to.</param>
        /// <param name="readOffset">Offset in bytes in read buffer to start copying at.</param>
        /// <param name="writeOffset">Offset in bytes in write buffer to start copying to.</param>
        /// <param name="Size">Size in bytes of data to copy.</param>
        [EntryPoint(FunctionName = "glNamedCopyBufferSubDataEXT")]
        public static void NamedCopyBufferSubDataEXT(uint ReadBufferID, uint WriteBufferID, IntPtr readOffset, IntPtr writeOffset, IntPtr Size) { throw new NotImplementedException(); }
        /// <summary>
        /// Copies data from read buffer id to write buffer id.
        /// </summary>
        /// <param name="ReadBufferID">id of buffer to read data from.</param>
        /// <param name="WriteBufferID">id of buffer to write data to.</param>
        /// <param name="readOffset">Offset in bytes in read buffer to start copying at.</param>
        /// <param name="writeOffset">Offset in bytes in write buffer to start copying to.</param>
        /// <param name="Size">Size in bytes of data to copy.</param>        
        public static void NamedCopyBufferSubDataEXT(uint ReadBufferID, uint WriteBufferID, long readOffset, long writeOffset, long Size)
        {
            NamedCopyBufferSubDataEXT(ReadBufferID, WriteBufferID, (IntPtr)readOffset, (IntPtr)writeOffset, (IntPtr)Size);
        }


        #endregion

        #region Public Helper Functions

        #endregion

    }
}
