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
        #region OpenGL DLLImports

        // ARB_multitexture
        [EntryPointSlot(64)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glActiveTexture(TextureUnit texUnit);
        // ARB_multisample
        [EntryPointSlot(65)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glSampleCoverage(float value, bool Invert);
        // ARB_texture_compression
        [EntryPointSlot(66)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTexImage1D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int border, int imageSize, IntPtr data);
        [EntryPointSlot(67)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTexImage2D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, int imageSize, IntPtr data);
        [EntryPointSlot(68)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTexImage3D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
        [EntryPointSlot(69)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelInternalFormat format, int imageSize, IntPtr data);
        [EntryPointSlot(70)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelInternalFormat format, int imageSize, IntPtr data);
        [EntryPointSlot(71)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelInternalFormat format, int imageSize, IntPtr data);
        [EntryPointSlot(72)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetCompressedTexImage(TextureTarget target, int level, IntPtr img);

        #endregion

        #region Public functions

        //[EntryPoint(FunctionName = "gl")]
        //public static void BindTexture(TextureTarget target, uint textureid) { throw new NotImplementedException(); }

        // ARB_multitexture
        /// <summary>
        /// Set the active Texture unit
        /// glActiveTexture selects which texture unit subsequent texture state calls will affect. The number of texture units an implementation supports is implementation dependent, but must be at least 80.
        /// </summary>
        /// <param name="texUnit">Specifies which texture unit to make active. The number of texture units is implementation dependent, but must be at least 80. texture must be one of GL_TEXTUREi, where i ranges from 0 (GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS - 1). The initial value is GL_TEXTURE0.</param>
        [EntryPoint(FunctionName = "glActiveTexture")]
        public static void ActiveTexture(TextureUnit texUnit) { throw new NotImplementedException(); }
        // ARB_multisample
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
        [EntryPoint(FunctionName = "glSampleCoverage")]
        public static void SampleCoverage(float value, bool Invert) { throw new NotImplementedException(); }
        // ARB_texture_compression
        /// <summary>
        /// CompressedTexImage1D allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the last two parameters, CompressedTexImage1D work identically to their glTexImage*​ counterparts.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        [EntryPoint(FunctionName = "glCompressedTexImage1D")]
        //public static void CompressedTexImage1D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int border, int imageSize, IntPtr data) { throw new NotImplementedException(); }
        public static void CompressedTexImage1D(TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int border, int imageSize, IntPtr data) { throw new NotImplementedException(); }
        /// <summary>
        /// CompressedTexImage1D allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the last two parameters, CompressedTexImage1D work identically to their glTexImage*​ counterparts.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from</param>               
        /// <param name="border">Depricated in core context. must be 0.</param>
        public static void CompressedTexImage1D(TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int imageSize, long offset, int border = 0)
        {
            CompressedTexImage1D(target, level, sciformat, width, border, imageSize, (IntPtr)offset);
        }
        /// <summary>
        /// CompressedTexImage1D allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the last two parameters, CompressedTexImage1D work identically to their glTexImage*​ counterparts.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>        
        /// <param name="cdata">buffer with already compressed image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <param name="imageSize">Defaults to cdata.length. The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="border">Depricated in core context.</param>
        unsafe public static void CompressedTexImage1D(TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, byte[] cdata, int index = 0, int imageSize = -1, int border = 0)
        {
            if (imageSize == -1)
                imageSize = cdata.Length;

            // SHOULD WE SILENTLY CLAMP ARRAY DATA?
            imageSize = Math.Min(cdata.Length - index, index + imageSize);

            fixed(byte* ptr = &cdata[index])
            {
                CompressedTexImage1D(target, level, sciformat, width, border, imageSize, (IntPtr)ptr);
            }
        }

        /// <summary>
        /// CompressedTexImage2D allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the last two parameters, CompressedTexImage2D work identically to their glTexImage*​ counterparts.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        [EntryPoint(FunctionName = "glCompressedTexImage2D")]
        public static void CompressedTexImage2D(TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int height, int border, int imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>
        /// CompressedTexImage2D allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the last two parameters, CompressedTexImage2D work identically to their glTexImage*​ counterparts.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        public static void CompressedTexImage2D(TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int height, int imageSize, long offset, int border = 0)
        {
            CompressedTexImage2D(target, level, sciformat, width, height, border, imageSize, (IntPtr)offset);
        }
        /// <summary>
        /// CompressedTexImage2D allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the last two parameters, CompressedTexImage2D work identically to their glTexImage*​ counterparts.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="cdata">buffer with already compressed image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <param name="imageSize">Defaults to cdata.length. The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        unsafe public static void CompressedTexImage2D(TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int height, byte[] cdata, int index = 0, int imageSize = -1, int border = 0)
        {
            if (imageSize == -1)
                imageSize = cdata.Length;

            // SHOULD WE SILENTLY CLAMP ARRAY DATA?
            imageSize = Math.Min(cdata.Length - index, index + imageSize);

            fixed (byte* ptr = &cdata[index])
            {
                CompressedTexImage2D(target, level, sciformat, width,height, border, imageSize, (IntPtr)ptr);
            }

        }

        /// <summary>
        /// CompressedTexImage3D allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the last two parameters, CompressedTexImage3D work identically to their glTexImage*​ counterparts.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="border">depricated in core context, must be 0</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        [EntryPoint(FunctionName = "glCompressedTexImage3D")]
        public static void CompressedTexImage3D(TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int height, int depth, int border, int imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>
        /// CompressedTexImage3D allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the last two parameters, CompressedTexImage3D work identically to their glTexImage*​ counterparts.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        public static void CompressedTexImage3D(TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int height, int depth, int imageSize, long offset, int border = 0)
        {
            CompressedTexImage3D(target, level, sciformat, width, height, depth, border, imageSize, (IntPtr)offset);
        }
        /// <summary>
        /// CompressedTexImage3D allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the last two parameters, CompressedTexImage3D work identically to their glTexImage*​ counterparts.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="cdata">buffer with already compressed image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <param name="imageSize">Defaults to cdata.length. The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        unsafe public static void CompressedTexImage3D(TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int height, int depth, byte[] cdata, int index = 0, int imageSize = -1, int border = 0)
        {
            if (imageSize == -1)
                imageSize = cdata.Length;

            // SHOULD WE SILENTLY CLAMP ARRAY DATA?
            imageSize = Math.Min(cdata.Length - index, index + imageSize);

            fixed (byte* ptr = &cdata[index])
            {
                CompressedTexImage3D(target, level, sciformat, width, height, depth, border, imageSize, (IntPtr)ptr);
            }
        }

        /// <summary>
        /// Upload compressed 1d image data into an existing bound texture image and its existing mipmap level.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        /// <remarks>
        /// glCompressedTexSubImage1D redefines a contiguous subregion of an existing one-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture format. The format of the compressed texture image is selected by the GL implementation that compressed it (see glTexImage1D), and should be queried at the time the texture was compressed with glGetTexLevelParameter.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        [EntryPoint(FunctionName = "glCompressedTexSubImage1D")]
        public static void CompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, SizedCompressedInternalFormat sciformat, int imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>
        /// Upload compressed 1d image data into an existing bound texture image and its existing mipmap level.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        /// <remarks>
        /// glCompressedTexSubImage1D redefines a contiguous subregion of an existing one-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture format. The format of the compressed texture image is selected by the GL implementation that compressed it (see glTexImage1D), and should be queried at the time the texture was compressed with glGetTexLevelParameter.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        public static void CompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, SizedCompressedInternalFormat sciformat, int imageSize, long offset)
        {
            CompressedTexSubImage1D(target, level, xoffset, width, sciformat, imageSize, (IntPtr)offset);
        }

        /// <summary>
        /// Upload compressed 1d image data into an existing bound texture image and its existing mipmap level.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="cdata">buffer with already compressed image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <param name="imageSize">Defaults to cdata.length. The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <remarks>
        /// glCompressedTexSubImage1D redefines a contiguous subregion of an existing one-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture format. The format of the compressed texture image is selected by the GL implementation that compressed it (see glTexImage1D), and should be queried at the time the texture was compressed with glGetTexLevelParameter.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        unsafe public static void CompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, SizedCompressedInternalFormat sciformat, byte[] cdata, int index = 0, int imageSize = -1)
        {
            if (imageSize == -1)
                imageSize = cdata.Length;

            // SHOULD WE SILENTLY CLAMP ARRAY DATA?
            imageSize = Math.Min(cdata.Length - index, index + imageSize);

            fixed (byte* ptr = &cdata[index])
            {
                CompressedTexSubImage1D(target, level, xoffset, width, sciformat, imageSize, (IntPtr)ptr);
            }
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
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        [EntryPoint(FunctionName = "glCompressedTexSubImage2D")]
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, SizedCompressedInternalFormat sciformat, int imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>
        /// Upload compressed 2d image data into an existing bound texture image and its existing mipmap level.
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, SizedCompressedInternalFormat sciformat, int imageSize, long offset)
        {
            CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, sciformat, imageSize, (IntPtr)offset);
        }

        /// <summary>
        /// Upload compressed 2d image data into an existing bound texture image and its existing mipmap level.
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="cdata">buffer with already compressed image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <param name="imageSize">Defaults to cdata.length. The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        unsafe public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, SizedCompressedInternalFormat sciformat, byte[] cdata, int index = 0, int imageSize = 0)
        {
            if (imageSize == -1)
                imageSize = cdata.Length;

            // SHOULD WE SILENTLY CLAMP ARRAY DATA?
            imageSize = Math.Min(cdata.Length - index, index + imageSize);

            fixed (byte* ptr = &cdata[index])
            {
                CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, sciformat, imageSize, (IntPtr)ptr);
            }
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
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        /// <remarks>
        /// glCompressedTexSubImage3D redefines a contiguous subregion of an existing three-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , and the y indices yoffset and yoffset + height - 1 , and the z indices zoffset and zoffset + depth - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture format. The format of the compressed texture image is selected by the GL implementation that compressed it (see glTexImage3D) and should be queried at the time the texture was compressed with glGetTexLevelParameter.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        [EntryPoint(FunctionName = "glCompressedTexSubImage3D")]
        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, SizedCompressedInternalFormat sciformat, int imageSize, IntPtr data) { throw new NotImplementedException(); }

        /// <summary>
        /// Upload compressed 3d image data into an existing bound texture image and its existing mipmap level.
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_3D or 2darray?</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="zoffset">Specifies a texel offset in the z direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        /// <remarks>
        /// glCompressedTexSubImage3D redefines a contiguous subregion of an existing three-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , and the y indices yoffset and yoffset + height - 1 , and the z indices zoffset and zoffset + depth - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture format. The format of the compressed texture image is selected by the GL implementation that compressed it (see glTexImage3D) and should be queried at the time the texture was compressed with glGetTexLevelParameter.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, SizedCompressedInternalFormat sciformat, int imageSize, long offset)
        {
            CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, sciformat, imageSize, (IntPtr)offset);
        }

        /// <summary>
        /// Upload compressed 3d image data into an existing bound texture image and its existing mipmap level.
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_3D or 2darray?</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="zoffset">Specifies a texel offset in the z direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="cdata">buffer with already compressed image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <param name="imageSize">Defaults to cdata.length. The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        unsafe public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, SizedCompressedInternalFormat sciformat, byte[] cdata, int index = 0, int imageSize = -1)
        {
            if (imageSize == -1)
                imageSize = cdata.Length;

            // SHOULD WE SILENTLY CLAMP ARRAY DATA?
            imageSize = Math.Min(cdata.Length - index, index + imageSize);

            fixed (byte* ptr = &cdata[index])
            {
                CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, sciformat, imageSize, (IntPtr)ptr);
            }
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
        [EntryPoint(FunctionName = "glGetCompressedTexImage")]
        public static void GetCompressedTexImage(TextureTarget target, int level, IntPtr img) { throw new NotImplementedException(); }

        /// <summary>
        /// glGetCompressedTexImage returns the compressed texture image associated with target and lod into img.
        /// Retrives the Compressed texture data from current bound target and specified mipmap level into img.
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_PACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="target">The target, which our texture is currently bound to.Specifies which texture is to be obtained. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, and GL_TEXTURE_CUBE_MAP_NEGATIVE_Z are accepted.</param>
        /// <param name="level">Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="data">a preallocated buffer big enough to store the compressed image data.</param>
        /// <param name="index">index into data to start writing at.</param>
        unsafe public static void GetCompressedTexImage(TextureTarget target, int level, byte[] data, int index = 0)
        {
            fixed(byte* ptr = &data[index])
            {
                GetCompressedTexImage(target, level, (IntPtr)ptr);
            }
        }

        /// <summary>
        /// GetCompressedTexImage quires opengl for the correct buffer size and returns the compressed texture image associated with target and lod
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_PACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// NOTE: if image is not compressed returns 'new byte[0]', otherwise compressed image data.
        /// </summary>
        /// <param name="target">The target, which our texture is currently bound to.Specifies which texture is to be obtained. GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, and GL_TEXTURE_CUBE_MAP_NEGATIVE_Z are accepted.</param>
        /// <param name="level">Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <returns>if image is not compressed returns 'new byte[0]', otherwise compressed image data.</returns>
        public static byte[] GetCompressedTexImage(TextureTarget target, int level)
        {
            bool iscompressed = GetTexLevelParameteriv(target, level, TextureLevelParameters.Compressed) == (int)All.TRUE;

            if (iscompressed)
            {
                var size = GetTexLevelParameteriv(target, level, TextureLevelParameters.CompressedImageSize);

                var buf = new byte[size];

                GetCompressedTexImage(target, level, buf);

                return buf;
            }
            else
                return new byte[0];
        }

        #endregion

        #region Public Helper Functions

        #endregion

    }
}
