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
    // template class until gl 4.4 where its not neede for another year.
    partial class DSA
    {

        #region OpenGL DLLImports

        [EntryPointSlot(15)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureImage3DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels);
        [EntryPointSlot(16)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels);
        [EntryPointSlot(17)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCopyTextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);


        #endregion

        #region Public functions

        
        [EntryPoint(FunctionName = "glTextureImage3DEXT")]
        public static void TextureImage3DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureSubImage3DEXT")]
        public static void TextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glCopyTextureSubImage3DEXT")]
        public static void CopyTextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height){ throw new NotImplementedException(); }

        #endregion

        #region Public Helper Functions

        #endregion

    }
}

