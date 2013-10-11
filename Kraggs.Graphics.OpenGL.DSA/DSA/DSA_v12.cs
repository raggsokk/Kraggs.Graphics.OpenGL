#region License

// Kraggs.Graphics.OpenGL (github.com/raggsokk)
//
// Copyright (c) 2013 Jarle Hansen (github.com/raggsokk)
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
        #region Delegate Class

        partial class Delegates
        {
            #region Delegates

            public delegate void delTextureImage3DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels);
            public delegate void delTextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels);
            public delegate void delCopyTextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

            #endregion

            #region GL Fields

            public static delTextureImage3DEXT glTextureImage3DEXT;
            public static delTextureSubImage3DEXT glTextureSubImage3DEXT;
            public static delCopyTextureSubImage3DEXT glCopyTextureSubImage3DEXT;

            #endregion
        }

        #endregion

        #region Public functions.

        public static void TextureImage3DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
        {
            Delegates.glTextureImage3DEXT(TextureID, target, level, piformat, width, height, depth, 0, format, type, pixels);
        }
        public static void TextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
        {
            Delegates.glTextureSubImage3DEXT(TextureID, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }
        public static void CopyTextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
        {
            Delegates.glCopyTextureSubImage3DEXT(TextureID, target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }


        #endregion
    }
}

