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
    
    partial class GL
    {
        #region Delegate Class

        partial class Delegates
        {

            #region Delegates

            // ARB_multitexture
            public delegate void delActiveTexture(TextureUnit texUnit);
            // ARB_multisample
            public delegate void delSampleCoverage(float value, bool Invert);
            // ARB_texture_compression
            public delegate void delCompressedTexImage1D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int border, int imageSize, IntPtr data);
            public delegate void delCompressedTexImage2D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, int imageSize, IntPtr data);
            public delegate void delCompressedTexImage3D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
            public delegate void delCompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelInternalFormat format, int imageSize, IntPtr data);
            public delegate void delCompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelInternalFormat format, int imageSize, IntPtr data);
            public delegate void delCompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelInternalFormat format, int imageSize, IntPtr data);
            public delegate void delGetCompressedTexImage(TextureTarget target, int level, IntPtr img);

            #endregion

            #region GL Fields

            public static delActiveTexture glActiveTexture;
            public static delSampleCoverage glSampleCoverage;
            public static delCompressedTexImage1D glCompressedTexImage1D;
            public static delCompressedTexImage2D glCompressedTexImage2D;
            public static delCompressedTexImage3D glCompressedTexImage3D;
            public static delCompressedTexSubImage1D glCompressedTexSubImage1D;
            public static delCompressedTexSubImage2D glCompressedTexSubImage2D;
            public static delCompressedTexSubImage3D glCompressedTexSubImage3D;
            public static delGetCompressedTexImage glGetCompressedTexImage;

            #endregion
        }

        #endregion

        #region Public functions.

        /// <summary>
        /// Set the active Texture unit
        /// glActiveTexture selects which texture unit subsequent texture state calls will affect. The number of texture units an implementation supports is implementation dependent, but must be at least 80.
        /// </summary>
        /// <param name="texUnit">Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least 80. texture must be one of GL_TEXTUREi, where i ranges from 0 (GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS - 1). The initial value is GL_TEXTURE0.</param>
        public static void ActiveTexture(TextureUnit texUnit)
        {
            Delegates.glActiveTexture(texUnit);
        }
        /// <summary>
        /// specify multisample coverage parameters
        /// </summary>
        /// <param name="value">Specify a single floating-point sample coverage value. The value is clamped to the range 0 1 . The initial value is 1.0.</param>
        /// <param name="Invert">Specify a single boolean value representing if the coverage masks should be inverted. GL_TRUE and GL_FALSE are accepted. The initial value is GL_FALSE.</param>
        /// <remarks>
        /// Multisampling samples a pixel multiple times at various implementation-dependent subpixel locations to generate antialiasing effects. Multisampling transparently antialiases points, lines, polygons, and images if it is enabled.
        /// value is used in constructing a temporary mask used in determining which samples will be used in resolving the final fragment color. This mask is bitwise-anded with the coverage mask generated from the multisampling computation. If the invert flag is set, the temporary mask is inverted (all bits flipped) and then the bitwise-and is computed.
        /// If an implementation does not have any multisample buffers available, or multisampling is disabled, rasterization occurs with only a single sample computing a pixel's final RGB color.
        /// Provided an implementation supports multisample buffers, and multisampling is enabled, then a pixel's final color is generated by combining several samples per pixel. Each sample contains color, depth, and stencil information, allowing those operations to be performed on each sample.
        /// </remarks>
        public static void SampleCoverage(float value, bool Invert)
        {
            Delegates.glSampleCoverage(value, Invert);
        }
        /// <summary>
        /// CompressedTexImage1D allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the last two parameters, CompressedTexImage1D work identically to their glTexImage*​ counterparts.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="piformat">internalformat​ must not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        public static void CompressedTexImage1D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int imageSize, IntPtr data)
        {
            Delegates.glCompressedTexImage1D(target, level, piformat, width, 0, imageSize, data);
        }
        ///// <summary>
        ///// CompressedTexImage1D allocates image with compressed formats and simultaneously fills them with compressed data
        ///// With the exception of the last two parameters, CompressedTexImage1D work identically to their glTexImage*​ counterparts.
        ///// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        ///// </summary>
        ///// <param name="target"></param>
        ///// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        ///// <param name="piformat">internalformat​ can not be a generic compressed format.</param>
        ///// <param name="width">Specifies the width of the texture subimage.</param>
        ///// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        ///// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        //public static void CompressedTexImage1D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int imageSize, IntPtr data)
        //{
        //    Delegates.glCompressedTexImage1D(target, level, piformat, width, 0, imageSize, data);
        //}

        /// <summary>
        /// CompressedTexImage2D allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the last two parameters, CompressedTexImage2D work identically to their glTexImage*​ counterparts.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="piformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        public static void CompressedTexImage2D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int imageSize, IntPtr data)
        {
            Delegates.glCompressedTexImage2D(target, level, piformat, width, height, 0, imageSize, data);
        }
        ///// <summary>
        ///// CompressedTexImage2D allocates image with compressed formats and simultaneously fills them with compressed data
        ///// With the exception of the last two parameters, CompressedTexImage2D work identically to their glTexImage*​ counterparts.
        ///// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        ///// </summary>
        ///// <param name="target"></param>
        ///// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        ///// <param name="piformat">Requires the correct Sized Compressed format used to compress image with.</param>
        ///// <param name="width">Specifies the width of the texture subimage.</param>
        ///// <param name="height">Specifies the height of the texture subimage.</param>
        ///// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        ///// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        //public static void CompressedTexImage2D(TextureTarget target, int level, PixelInternalFormatV2 piformat, int width, int height, int imageSize, IntPtr data)
        //{
        //    Delegates.glCompressedTexImage2D(target, level, (SizedCompressedInternalFormat) piformat, width, height, 0, imageSize, data);
        //}

        /// <summary>
        /// CompressedTexImage3D allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the last two parameters, CompressedTexImage3D work identically to their glTexImage*​ counterparts.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="piformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        public static void CompressedTexImage3D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int imageSize, IntPtr data)
        {
            Delegates.glCompressedTexImage3D(target, level, piformat, width, height, depth, 0, imageSize, data);
        }

        /// <summary>
        /// Upload compressed 1d image data into an existing bound texture image and its existing mipmap level.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="format">format​ can not be a generic compressed format.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        /// <remarks>
        /// glCompressedTexSubImage1D redefines a contiguous subregion of an existing one-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture format. The format of the compressed texture image is selected by the GL implementation that compressed it (see glTexImage1D), and should be queried at the time the texture was compressed with glGetTexLevelParameter.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        public static void CompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelInternalFormat format, int imageSize, IntPtr data)
        {
            Delegates.glCompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
        }

        /// <summary>
        /// Upload compressed 2d image data into an existing bound texture image and its existing mipmap level.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">format​ can not be a generic compressed format.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelInternalFormat format, int imageSize, IntPtr data)
        {
            Delegates.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }
        /// <summary>
        /// Upload compressed 3d image data into an existing bound texture image and its existing mipmap level.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_3D or 2darray?</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="zoffset">Specifies a texel offset in the z direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="format">format​ can not be a generic compressed format.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        /// <remarks>
        /// glCompressedTexSubImage3D redefines a contiguous subregion of an existing three-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , and the y indices yoffset and yoffset + height - 1 , and the z indices zoffset and zoffset + depth - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture format. The format of the compressed texture image is selected by the GL implementation that compressed it (see glTexImage3D) and should be queried at the time the texture was compressed with glGetTexLevelParameter.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelInternalFormat format, int imageSize, IntPtr data)
        {
            Delegates.glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        /// <summary>
        /// glGetCompressedTexImage returns the compressed texture image associated with target and lod into img.
        /// Retrives the Compressed texture data from current bound target and specified mipmap level into img.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_PACK_BUFFER target (see glBindBuffer) while a texture image is requested, img is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target">The target, which our texture is currently bound to.Specifies which texture is to be obtained. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, and GL_TEXTURE_CUBE_MAP_NEGATIVE_Z are accepted.</param>
        /// <param name="level">Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="img">If GL_PACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to write to, otherwise a pointer to where compressed image data should be written in system memory. </param>
        /// <remarks>
        /// glGetCompressedTexImage returns the compressed texture image associated with target and lod into img. img should be an array of GL_TEXTURE_COMPRESSED_IMAGE_SIZE bytes. target specifies whether the desired texture image was one specified by glTexImage1D (GL_TEXTURE_1D), glTexImage2D (GL_TEXTURE_2D or any of GL_TEXTURE_CUBE_MAP_*), or glTexImage3D (GL_TEXTURE_3D). lod specifies the level-of-detail number of the desired image.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_PACK_BUFFER target (see glBindBuffer) while a texture image is requested, img is treated as a byte offset into the buffer object's data store.
        /// To minimize errors, first verify that the texture is compressed by calling glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED. If the texture is compressed, then determine the amount of memory required to store the compressed texture by calling glGetTexLevelParameter with argument GL_TEXTURE_COMPRESSED_IMAGE_SIZE. Finally, retrieve the internal format of the texture by calling glGetTexLevelParameter with argument GL_TEXTURE_INTERNAL_FORMAT. To store the texture for later use, associate the internal format and size with the retrieved texture image. These data can be used by the respective texture or subtexture loading routine used for loading target textures.
        /// </remarks>
        public static void GetCompressedTexImage(TextureTarget target, int level, IntPtr img)
        {
            Delegates.glGetCompressedTexImage(target, level, img);
        }

        #endregion
    }
}
