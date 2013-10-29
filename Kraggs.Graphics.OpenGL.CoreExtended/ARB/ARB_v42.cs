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

    partial class ARB
    {
        #region Delegate Class

        partial class Delegates
        {

            #region Delegates

            ////ARB_internalformat_query
            //public delegate void delGetInternalformativARB(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname, int bufSize, ref int @params);


            ////ARB_texture_storage
            //public delegate void delTexStorage1DARB(TextureTarget target, int levels, PixelInternalFormat piformat, int Width);
            //public delegate void delTexStorage2DARB(TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height);
            //public delegate void delTexStorage3DARB(TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height, int Depth);

            #endregion

            #region GL Fields

            ////ARB_internalformat_query
            //public static delGetInternalformativARB glGetInternalformativARB;

            ////ARB_texture_storage
            //public static delTexStorage1DARB glTexStorage1DARB;
            //public static delTexStorage2DARB glTexStorage2DARB;
            //public static delTexStorage3DARB glTexStorage3DARB;

            #endregion
        }

        #endregion

        #region Public functions.

        //ARB_internalformat_query
        ///// <summary>
        ///// Information about implementation-dependent support for internal formats can be queried with the command GetInternalformativ
        ///// </summary>
        ///// <param name="target">target indicates the usage of the internalformat, and must be one the targets listed in enum.</param>
        ///// <param name="internalFormat">internalformat can be any value</param>
        ///// <param name="pname">The INTERNALFORMAT_SUPPORTED pname can be used to determine if the internal format is supported, and the other pnames are defined in terms of whether or not the format is supported</param>
        ///// <param name="params">No more than @params.Length integers will be written into params. If more data are available, they will be ignored and no error will be generated.</param>
        //public static void GetInternalformativARB(GetInternalformatTargets target, PixelInternalFormat internalFormat, GetInternalformatParameters pname, int[] @params)
        //{
        //    Delegates.glGetInternalformativARB(target, internalFormat, pname, @params.Length, ref @params[0]);
        //}
        ///// <summary>
        ///// Information about implementation-dependent support for internal formats can be queried with the command GetInternalformativ
        ///// No more than 1 int will be returned. If more data are available, they will be ignored and no error will be generated.
        ///// </summary>
        ///// <param name="target">target indicates the usage of the internalformat, and must be one the targets listed in enum.</param>
        ///// <param name="internalFormat">internalformat can be any value</param>
        ///// <param name="pname">The INTERNALFORMAT_SUPPORTED pname can be used to determine if the internal format is supported, and the other pnames are defined in terms of whether or not the format is supported</param>
        ///// <returns>No more than 1 int will be returned. If more data are available, they will be ignored and no error will be generated.</returns>
        //public static int GetInternalformativARB(GetInternalformatTargets target, PixelInternalFormat internalFormat, GetInternalformatParameters pname)
        //{
        //    int tmp = 0;
        //    Delegates.glGetInternalformativARB(target, internalFormat, pname, 1, ref tmp);
        //    return tmp;
        //}


        ////ARB_texture_storage
        ///// <summary>
        ///// TexStorageXX allocates images with the given size (width​, height​, and depth​, where appropriate), with the number of mipmaps given by levels​. The storage is created here, but the contents of that storage is undefined.
        ///// </summary>
        ///// <param name="target">Valid target​: GL_TEXTURE_1D​</param>
        ///// <param name="levels">Number of mipmaps to alloc.</param>
        ///// <param name="piformat">Any Sized Internal format.</param>
        ///// <param name="Width">Width of base mipmap.</param>
        ///// <remarks>
        /////  immutable storage allocates all of the images for the texture all at once. Every mipmap level, array layer, and cube map face is all allocated with a single call, giving all of these images a specific Image Format. It is called "immutable" because once the storage is allocated, the storage cannot be changed. The texture can be deleted as normal, but the storage cannot be altered. A 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format will *always* be a 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format.
        /////  Note that what immutable storage refers to is the allocation of the memory, not the contents of that memory. You can upload different pixel data to immutable storage all you want. With mutable storage, you can re-vamp the storage of a texture object entirely, changing a 256x256 texture into a 1024x1024 texture.
        ///// </remarks>
        //public static void TexStorage1DARB(TextureTarget target, int levels, PixelInternalFormat piformat, int Width)
        //{
        //    Delegates.glTexStorage1DARB(target, levels, piformat, Width);
        //}
        ///// <summary>
        ///// TexStorageXX allocates images with the given size (width​, height​, and depth​, where appropriate), with the number of mipmaps given by levels​. The storage is created here, but the contents of that storage is undefined.
        ///// For 1D array textures, the number of array layers in each mipmap level is the height​ value. For rectangle textures, the number of mipmap levels must be 1.
        ///// </summary>
        ///// <param name="target">Valid target​s: GL_TEXTURE_2D​, GL_TEXTURE_RECTANGE​, GL_TEXTURE_CUBEMAP​, or GL_TEXTURE_1D_ARRAY​.</param>
        ///// <param name="levels">Number of mipmaps to alloc.</param>
        ///// <param name="piformat">Any Sized Internal format.</param>
        ///// <param name="Width">Width of base mipmap.</param>
        ///// <param name="Height">Height of base mipmap. For 1D array textures, the number of array layers in each mipmap level is the height​ value. For rectangle textures, the number of mipmap levels must be 1.</param>
        ///// <remarks>
        /////  immutable storage allocates all of the images for the texture all at once. Every mipmap level, array layer, and cube map face is all allocated with a single call, giving all of these images a specific Image Format. It is called "immutable" because once the storage is allocated, the storage cannot be changed. The texture can be deleted as normal, but the storage cannot be altered. A 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format will *always* be a 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format.
        /////  Note that what immutable storage refers to is the allocation of the memory, not the contents of that memory. You can upload different pixel data to immutable storage all you want. With mutable storage, you can re-vamp the storage of a texture object entirely, changing a 256x256 texture into a 1024x1024 texture.
        ///// </remarks>
        //public static void TexStorage2DARB(TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height)
        //{
        //    Delegates.glTexStorage2DARB(target, levels, piformat, Width, Height);
        //}
        ///// <summary>
        ///// TexStorageXX allocates images with the given size (width​, height​, and depth​, where appropriate), with the number of mipmaps given by levels​. The storage is created here, but the contents of that storage is undefined.
        ///// For 2D array textures, the number of array layers in each mipmap level is the depth​ value. For 2D cubemap array textures, the number of cubemap layer-faces is the depth​, which must be a multiple of 6. Therefore, the number of individual cubemaps in the array is given by depth​ / 6.
        ///// </summary>
        ///// <param name="target">Valid target​s: GL_TEXTURE_3D​, GL_TEXTURE_2D_ARRAY​, GL_TEXTURE_CUBE_ARRAY​</param>
        ///// <param name="levels">Number of mipmaps to alloc.</param>
        ///// <param name="piformat">Any Sized Internal format.</param>
        ///// <param name="Width">Width of base mipmap.</param>
        ///// <param name="Height">Height of base mipmap.</param>
        ///// <param name="Depth">Depth of base mipmap.For 2D array textures, the number of array layers in each mipmap level is the depth​ value.</param>
        ///// <remarks>
        /////  immutable storage allocates all of the images for the texture all at once. Every mipmap level, array layer, and cube map face is all allocated with a single call, giving all of these images a specific Image Format. It is called "immutable" because once the storage is allocated, the storage cannot be changed. The texture can be deleted as normal, but the storage cannot be altered. A 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format will *always* be a 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format.
        /////  Note that what immutable storage refers to is the allocation of the memory, not the contents of that memory. You can upload different pixel data to immutable storage all you want. With mutable storage, you can re-vamp the storage of a texture object entirely, changing a 256x256 texture into a 1024x1024 texture.
        ///// </remarks>
        //public static void TexStorage3DARB(TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height, int Depth)
        //{
        //    Delegates.glTexStorage3DARB(target, levels, piformat, Width, Height, Depth);
        //}

        #endregion
    }
}
