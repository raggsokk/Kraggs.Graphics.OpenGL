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
        //#region Delegate Class

        //partial class Delegates
        //{

        //    #region Delegates

        //    public delegate void delCompressedTextureImage1DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int border, int imageSize, IntPtr data);
        //    public delegate void delCompressedTextureImage2DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, int imageSize, IntPtr data);
        //    public delegate void delCompressedTextureImage3DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
        //    public delegate void delCompressedTextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, PixelInternalFormat format, int imageSize, IntPtr data);
        //    public delegate void delCompressedTextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelInternalFormat format, int imageSize, IntPtr data);
        //    public delegate void delCompressedTextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelInternalFormat format, int imageSize, IntPtr data);
        //    public delegate void delGetCompressedTextureImageEXT(uint TextureID, TextureTarget target, int level, IntPtr img);


        //    #endregion

        //    #region GL Fields

        //    public static delCompressedTextureImage1DEXT glCompressedTextureImage1DEXT;
        //    public static delCompressedTextureImage2DEXT glCompressedTextureImage2DEXT;
        //    public static delCompressedTextureImage3DEXT glCompressedTextureImage3DEXT;
        //    public static delCompressedTextureSubImage1DEXT glCompressedTextureSubImage1DEXT;
        //    public static delCompressedTextureSubImage2DEXT glCompressedTextureSubImage2DEXT;
        //    public static delCompressedTextureSubImage3DEXT glCompressedTextureSubImage3DEXT;

        //    public static delGetCompressedTextureImageEXT glGetCompressedTextureImageEXT;

        //    #endregion
        //}

        //#endregion

        //#region Public functions.

        ///// <summary>
        ///// Uploads already compressed data to a texture object.
        ///// </summary>
        ///// <param name="TextureID"></param>
        ///// <param name="target"></param>
        ///// <param name="level"></param>
        ///// <param name="piformat">A non-generic compressed format.</param>
        ///// <param name="width"></param>
        ///// <param name="border"></param>
        ///// <param name="imageSize"></param>
        ///// <param name="data"></param>
        //public static void CompressedTextureImage1DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int border, int imageSize, IntPtr data)
        //{
        //    Delegates.glCompressedTextureImage1DEXT(TextureID, target, level, piformat, width, border, imageSize, data);
        //}
        ///// <summary>
        ///// Uploads already compressed data to a texture object.
        ///// </summary>
        ///// <param name="TextureID"></param>
        ///// <param name="target"></param>
        ///// <param name="level"></param>
        ///// <param name="piformat">A non-generic compressed format.</param>
        ///// <param name="width"></param>
        ///// <param name="height"></param>
        ///// <param name="border"></param>
        ///// <param name="imageSize"></param>
        ///// <param name="data"></param>
        //public static void CompressedTextureImage2DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, int imageSize, IntPtr data)
        //{
        //    Delegates.glCompressedTextureImage2DEXT(TextureID, target, level, piformat, width, height, border, imageSize, data);
        //}
        ///// <summary>
        ///// Uploads already compressed data to a texture object.
        ///// </summary>
        ///// <param name="TextureID"></param>
        ///// <param name="target"></param>
        ///// <param name="level"></param>
        ///// <param name="piformat">A non-generic compressed format.</param>
        ///// <param name="width"></param>
        ///// <param name="height"></param>
        ///// <param name="depth"></param>
        ///// <param name="border"></param>
        ///// <param name="imageSize"></param>
        ///// <param name="data"></param>
        //public static void CompressedTextureImage3DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
        //{
        //    Delegates.glCompressedTextureImage3DEXT(TextureID, target, level, piformat, width, height, depth, border, imageSize, data);
        //}
        ///// <summary>
        ///// Uploads already compressed data to a texture object.
        ///// </summary>
        ///// <param name="TextureID"></param>
        ///// <param name="target"></param>
        ///// <param name="level"></param>
        ///// <param name="xoffset"></param>
        ///// <param name="width"></param>
        ///// <param name="format">A non-generic compressed format.</param>
        ///// <param name="imageSize"></param>
        ///// <param name="data"></param>
        //public static void CompressedTextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, PixelInternalFormat format, int imageSize, IntPtr data)
        //{
        //    Delegates.glCompressedTextureSubImage1DEXT(TextureID, target, level, xoffset, width, format, imageSize, data);
        //}
        ///// <summary>
        ///// Uploads already compressed data to a texture object.
        ///// </summary>
        ///// <param name="TextureID"></param>
        ///// <param name="target"></param>
        ///// <param name="level"></param>
        ///// <param name="xoffset"></param>
        ///// <param name="yoffset"></param>
        ///// <param name="width"></param>
        ///// <param name="height"></param>
        ///// <param name="format">A non-generic compressed format.</param>
        ///// <param name="imageSize"></param>
        ///// <param name="data"></param>
        //public static void CompressedTextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelInternalFormat format, int imageSize, IntPtr data)
        //{
        //    Delegates.glCompressedTextureSubImage2DEXT(TextureID, target, level, xoffset, yoffset, width, height, format, imageSize, data);
        //}
        ///// <summary>
        ///// Uploads already compressed data to a texture object.
        ///// </summary>
        ///// <param name="TextureID"></param>
        ///// <param name="target"></param>
        ///// <param name="level"></param>
        ///// <param name="xoffset"></param>
        ///// <param name="yoffset"></param>
        ///// <param name="zoffset"></param>
        ///// <param name="width"></param>
        ///// <param name="height"></param>
        ///// <param name="depth"></param>
        ///// <param name="format">A non-generic compressed format.</param>
        ///// <param name="imageSize"></param>
        ///// <param name="data"></param>
        //public static void CompressedTextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelInternalFormat format, int imageSize, IntPtr data)
        //{
        //    Delegates.glCompressedTextureSubImage3DEXT(TextureID, target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        //}
        ///// <summary>
        ///// Retrives a compressed image.
        ///// </summary>
        ///// <param name="TextureID"></param>
        ///// <param name="target"></param>
        ///// <param name="level"></param>
        ///// <param name="img"></param>
        //public static void GetCompressedTextureImageEXT(uint TextureID, TextureTarget target, int level, IntPtr img)
        //{
        //    Delegates.glGetCompressedTextureImageEXT(TextureID, target, level, img);
        //}

        //#endregion
    }
}

