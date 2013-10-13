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
    
    partial class DSA
    {
        #region Delegate Class

        partial class Delegates
        {

            #region Delegates

            // ARB_texture_storage
            public delegate void delTextureStorage1DEXT(uint textureId, TextureTarget target, int levels, PixelInternalFormat piformat, int Width);
            public delegate void delTextureStorage2DEXT(uint textureId, TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height);
            public delegate void delTextureStorage3DEXT(uint textureId, TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height, int Depth);


            #endregion

            #region GL Fields

            // ARB_texture_storage
            public static delTextureStorage1DEXT glTextureStorage1DEXT;
            public static delTextureStorage2DEXT glTextureStorage2DEXT;
            public static delTextureStorage3DEXT glTextureStorage3DEXT;


            #endregion
        }

        #endregion

        #region Public functions.

        // ARB_texture_storage
        /// <summary>
        /// TexStorageXX allocates images with the given size (width​, height​, and depth​, where appropriate), with the number of mipmaps given by levels​. The storage is created here, but the contents of that storage is undefined.
        /// </summary>
        /// <param name="textureId"></param>
        /// <param name="target">Valid target​: GL_TEXTURE_1D</param>
        /// <param name="levels">Number of mipmaps to alloc.</param>
        /// <param name="piformat">Any Sized Internal format.</param>
        /// <param name="Width">Width of base mipmap.</param>
        /// <remarks>
        ///  immutable storage allocates all of the images for the texture all at once. Every mipmap level, array layer, and cube map face is all allocated with a single call, giving all of these images a specific Image Format. It is called "immutable" because once the storage is allocated, the storage cannot be changed. The texture can be deleted as normal, but the storage cannot be altered. A 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format will *always* be a 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format.
        ///  Note that what immutable storage refers to is the allocation of the memory, not the contents of that memory. You can upload different pixel data to immutable storage all you want. With mutable storage, you can re-vamp the storage of a texture object entirely, changing a 256x256 texture into a 1024x1024 texture.
        /// </remarks>
        public static void TextureStorage1DEXT(uint textureId, TextureTarget target, int levels, PixelInternalFormat piformat, int Width)
        {
            Delegates.glTextureStorage1DEXT(textureId, target, levels, piformat, Width);
        }
        /// <summary>
        /// TexStorageXX allocates images with the given size (width​, height​, and depth​, where appropriate), with the number of mipmaps given by levels​. The storage is created here, but the contents of that storage is undefined.
        /// For 1D array textures, the number of array layers in each mipmap level is the height​ value. For rectangle textures, the number of mipmap levels must be 1.
        /// </summary>
        /// <param name="textureId"></param>
        /// <param name="target">Valid target​s: GL_TEXTURE_2D​, GL_TEXTURE_RECTANGE​, GL_TEXTURE_CUBEMAP​, or GL_TEXTURE_1D_ARRAY​.</param>
        /// <param name="levels">Number of mipmaps to alloc</param>
        /// <param name="piformat">Any Sized Internal format.</param>
        /// <param name="Width">Width of base mipmap.</param>
        /// <param name="Height">Height of base mipmap.For 1D array textures, the number of array layers in each mipmap level is the height​ value. For rectangle textures, the number of mipmap levels must be 1.</param>
        /// <remarks>
        ///  immutable storage allocates all of the images for the texture all at once. Every mipmap level, array layer, and cube map face is all allocated with a single call, giving all of these images a specific Image Format. It is called "immutable" because once the storage is allocated, the storage cannot be changed. The texture can be deleted as normal, but the storage cannot be altered. A 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format will *always* be a 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format.
        ///  Note that what immutable storage refers to is the allocation of the memory, not the contents of that memory. You can upload different pixel data to immutable storage all you want. With mutable storage, you can re-vamp the storage of a texture object entirely, changing a 256x256 texture into a 1024x1024 texture.
        /// </remarks>
        public static void TextureStorage2DEXT(uint textureId, TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height)
        {
            Delegates.glTextureStorage2DEXT(textureId, target, levels, piformat, Width, Height);
        }
        /// <summary>
        /// TexStorageXX allocates images with the given size (width​, height​, and depth​, where appropriate), with the number of mipmaps given by levels​. The storage is created here, but the contents of that storage is undefined.
        /// For 2D array textures, the number of array layers in each mipmap level is the depth​ value. For 2D cubemap array textures, the number of cubemap layer-faces is the depth​, which must be a multiple of 6. Therefore, the number of individual cubemaps in the array is given by depth​ / 6.
        /// </summary>
        /// <param name="textureId"></param>
        /// <param name="target">Valid target​s: GL_TEXTURE_3D​, GL_TEXTURE_2D_ARRAY​, GL_TEXTURE_CUBE_ARRAY</param>
        /// <param name="levels">Number of mipmaps to alloc</param>
        /// <param name="piformat">Any Sized Internal format.</param>
        /// <param name="Width">Width of base mipmap.</param>
        /// <param name="Height">Height of base mipmap.</param>
        /// <param name="Depth">Depth of base mipmap.For 2D array textures, the number of array layers in each mipmap level is the depth​ value. For 2D cubemap array textures, the number of cubemap layer-faces is the depth​, which must be a multiple of 6. Therefore, the number of individual cubemaps in the array is given by depth​ / 6.</param>
        /// <remarks>
        ///  immutable storage allocates all of the images for the texture all at once. Every mipmap level, array layer, and cube map face is all allocated with a single call, giving all of these images a specific Image Format. It is called "immutable" because once the storage is allocated, the storage cannot be changed. The texture can be deleted as normal, but the storage cannot be altered. A 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format will *always* be a 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format.
        ///  Note that what immutable storage refers to is the allocation of the memory, not the contents of that memory. You can upload different pixel data to immutable storage all you want. With mutable storage, you can re-vamp the storage of a texture object entirely, changing a 256x256 texture into a 1024x1024 texture.
        /// </remarks>
        public static void TextureStorage3DEXT(uint textureId, TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height, int Depth)
        {
            Delegates.glTextureStorage3DEXT(textureId, target, levels, piformat, Width, Height, Depth);
        }


        #endregion
    }
}
