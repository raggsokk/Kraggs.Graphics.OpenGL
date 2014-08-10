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

        [EntryPointSlot(18)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTextureImage1DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int border, int imageSize, IntPtr data);
        [EntryPointSlot(19)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTextureImage2DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, int imageSize, IntPtr data);
        [EntryPointSlot(20)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTextureImage3DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
        [EntryPointSlot(21)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, PixelInternalFormat format, int imageSize, IntPtr data);
        [EntryPointSlot(22)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelInternalFormat format, int imageSize, IntPtr data);
        [EntryPointSlot(23)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelInternalFormat format, int imageSize, IntPtr data);
        [EntryPointSlot(24)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetCompressedTextureImageEXT(uint TextureID, TextureTarget target, int level, IntPtr img);

        #endregion

        #region Public functions

        /// <summary>
        /// CompressedTextureImage1DEXT allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the first parameter, CompressedTextureImage1DEXT work identically to their glCompressedTexImage*​ counterparts.        
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">The Texture target treat TextureID as.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>        
        [EntryPoint(FunctionName = "glCompressedTextureImage1DEXT")]
        public static void CompressedTextureImage1DEXT(uint TextureID, TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int border, int imageSize, IntPtr data){ throw new NotImplementedException(); }

        /// <summary>
        /// CompressedTextureImage1DEXT allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the first parameter, CompressedTextureImage1DEXT work identically to their glCompressedTexImage*​ counterparts.        
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">The Texture target treat TextureID as.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        public static void CompressedTextureImage1DEXT(uint TextureID, TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int imageSize, long offset, int border = 0)
        {
            CompressedTextureImage1DEXT(TextureID, target, level, sciformat, width, border, imageSize, (IntPtr)offset);
        }

        /// <summary>
        /// CompressedTextureImage1DEXT allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the first parameter, CompressedTextureImage1DEXT work identically to their glCompressedTexImage*​ counterparts.        
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">The Texture target treat TextureID as.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="cdata">buffer with already compressed image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <param name="imageSize">Defaults to cdata.length. The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="border">Depricated in core context.</param>
        unsafe public static void CompressedTextureImage1DEXT(uint TextureID, TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, byte[] cdata, int index = 0, int imageSize = -1, int border = 0)
        {
            if (imageSize == -1)
                imageSize = cdata.Length;

            // SHOULD WE SILENTLY CLAMP ARRAY DATA?
            imageSize = Math.Min(cdata.Length - index, index + imageSize);

            fixed (byte* ptr = &cdata[index])
            {
                CompressedTextureImage1DEXT(TextureID, target, level, sciformat, width, border, imageSize, (IntPtr)ptr);
            }
        }

        /// <summary>
        /// CompressedTextureImage2DEXT allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the first parameter, CompressedTextureImage*EXT work identically to their glCompressedTexImage*​ counterparts.        
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">The Texture target treat TextureID as.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>        
        [EntryPoint(FunctionName = "glCompressedTextureImage2DEXT")]
        public static void CompressedTextureImage2DEXT(uint TextureID, TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int height, int border, int imageSize, IntPtr data){ throw new NotImplementedException(); }

        /// <summary>
        /// CompressedTextureImage2DEXT allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the first parameter, CompressedTextureImage2DEXT work identically to their glCompressedTexImage*​ counterparts.        
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">The Texture target treat TextureID as.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        public static void CompressedTextureImage2DEXT(uint TextureID, TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int height, int imageSize, long offset, int border = 0)
        {
            CompressedTextureImage2DEXT(TextureID, target, level, sciformat, width, height, border, imageSize, (IntPtr)offset);
        }

        /// <summary>
        /// CompressedTextureImage2DEXT allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the first parameter, CompressedTextureImage2DEXT work identically to their glCompressedTexImage*​ counterparts.        
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">The Texture target treat TextureID as.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="cdata">buffer with already compressed image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <param name="imageSize">Defaults to cdata.length. The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        unsafe public static void CompressedTextureImage2DEXT(uint TextureID, TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int height, byte[] cdata, int index = 0, int imageSize = -1, int border = 0)
        {
            if (imageSize == -1)
                imageSize = cdata.Length;

            // SHOULD WE SILENTLY CLAMP ARRAY DATA?
            imageSize = Math.Min(cdata.Length - index, index + imageSize);

            fixed (byte* ptr = &cdata[index])
            {
                CompressedTextureImage2DEXT(TextureID, target, level, sciformat, width, height, border, imageSize, (IntPtr)ptr);
            }
        }

        /// <summary>
        /// CompressedTextureImage3DEXT allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the first parameter, CompressedTextureImage*EXT work identically to their glCompressedTexImage*​ counterparts.        
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">The Texture target treat TextureID as.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>        
        [EntryPoint(FunctionName = "glCompressedTextureImage3DEXT")]
        public static void CompressedTextureImage3DEXT(uint TextureID, TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int height, int depth, int border, int imageSize, IntPtr data){ throw new NotImplementedException(); }

        /// <summary>
        /// CompressedTextureImage3DEXT allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the first parameter, CompressedTextureImage3DEXT work identically to their glCompressedTexImage*​ counterparts.        
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">The Texture target treat TextureID as.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        public static void CompressedTextureImage3DEXT(uint TextureID, TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int height, int depth, int imageSize, long offset, int border = 0)
        {
            CompressedTextureImage3DEXT(TextureID, target, level, sciformat, width, height, depth, border, imageSize, (IntPtr)offset);
        }

        /// <summary>
        /// CompressedTextureImage3DEXT allocates image with compressed formats and simultaneously fills them with compressed data
        /// With the exception of the first parameter, CompressedTextureImage3DEXT work identically to their glCompressedTexImage*​ counterparts.        
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">The Texture target treat TextureID as.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="sciformat">internalformat​ can not be a generic compressed format.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="cdata">buffer with already compressed image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <param name="imageSize">Defaults to cdata.length. The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        unsafe public static void CompressedTextureImage3DEXT(uint TextureID, TextureTarget target, int level, SizedCompressedInternalFormat sciformat, int width, int height, int depth, byte[] cdata, int index = 0, int imageSize = -1, int border = 0)
        {
            if (imageSize == -1)
                imageSize = cdata.Length;

            // SHOULD WE SILENTLY CLAMP ARRAY DATA?
            imageSize = Math.Min(cdata.Length - index, index + imageSize);

            fixed (byte* ptr = &cdata[index])
            {
                CompressedTextureImage3DEXT(TextureID, target, level, sciformat, width, height, depth, border, imageSize, (IntPtr)ptr);
            }
        }

        /// <summary>
        /// Upload compressed 1d image data into an existing bound texture image and its existing mipmap level.
        /// With the exception of the first parameter, CompressedTextureSubImage1DEXT work identically to their glCompressedTexSubImage*​ counterparts.        
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        /// <remarks>
        /// CompressedTextureSubImage1DEXT redefines a contiguous subregion of an existing one-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture format. The format of the compressed texture image is selected by the GL implementation that compressed it (see glTexImage1D), and should be queried at the time the texture was compressed with glGetTexLevelParameter.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        [EntryPoint(FunctionName = "glCompressedTextureSubImage1DEXT")]
        public static void CompressedTextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, SizedCompressedInternalFormat sciformat, int imageSize, IntPtr data){ throw new NotImplementedException(); }

        /// <summary>
        /// Upload compressed 1d image data into an existing bound texture image and its existing mipmap level.
        /// With the exception of the first parameter, CompressedTextureSubImage1DEXT work identically to their glCompressedTexSubImage*​ counterparts.        
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        /// <remarks>
        /// CompressedTextureSubImage1DEXT redefines a contiguous subregion of an existing one-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture format. The format of the compressed texture image is selected by the GL implementation that compressed it (see glTexImage1D), and should be queried at the time the texture was compressed with glGetTexLevelParameter.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        public static void CompressedTextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, SizedCompressedInternalFormat sciformat, int imageSize, long offset)
        {
            CompressedTextureSubImage1DEXT(TextureID, target, level, xoffset, width, sciformat, imageSize, (IntPtr)offset);
        }

        /// <summary>
        /// Upload compressed 1d image data into an existing bound texture image and its existing mipmap level.
        /// With the exception of the first parameter, CompressedTextureSubImage1DEXT work identically to their glCompressedTexSubImage*​ counterparts.        
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="cdata">buffer with already compressed image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <param name="imageSize">Defaults to cdata.length. The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <remarks>
        /// CompressedTextureSubImage1DEXT redefines a contiguous subregion of an existing one-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture format. The format of the compressed texture image is selected by the GL implementation that compressed it (see glTexImage1D), and should be queried at the time the texture was compressed with glGetTexLevelParameter.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        unsafe public static void CompressedTextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, SizedCompressedInternalFormat sciformat, byte[] cdata, int index = 0, int imageSize = -1)
        {
            if (imageSize == -1)
                imageSize = cdata.Length;

            // SHOULD WE SILENTLY CLAMP ARRAY DATA?
            imageSize = Math.Min(cdata.Length - index, index + imageSize);

            fixed (byte* ptr = &cdata[index])
            {
                CompressedTextureSubImage1DEXT(TextureID, target, level, xoffset, width, sciformat, imageSize, (IntPtr)ptr);
            }

        }

        /// <summary>
        /// Upload compressed 2d image data into an existing bound texture image and its existing mipmap level.
        /// With the exception of the first parameter, CompressedTextureSubImage2DEXT work identically to their glCompressedTexSubImage*​ counterparts.        
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">id of texture to upload compressed image data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="data">If GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from, otherwise a pointer to the compressed image data in system memory. </param>
        [EntryPoint(FunctionName = "glCompressedTextureSubImage2DEXT")]
        public static void CompressedTextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, SizedCompressedInternalFormat sciformat, int imageSize, IntPtr data){ throw new NotImplementedException(); }

        /// <summary>
        /// Upload compressed 2d image data into an existing bound texture image and its existing mipmap level.
        /// With the exception of the first parameter, CompressedTextureSubImage2DEXT work identically to their glCompressedTexSubImage*​ counterparts.        
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="imageSize">The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        public static void CompressedTextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, SizedCompressedInternalFormat sciformat, int imageSize, long offset)
        {
            CompressedTextureSubImage2DEXT(TextureID, target, level, xoffset, yoffset, width, height, sciformat, imageSize, (IntPtr)offset);
        }

        /// <summary>
        /// Upload compressed 2d image data into an existing bound texture image and its existing mipmap level.
        /// With the exception of the first parameter, CompressedTextureSubImage2DEXT work identically to their glCompressedTexSubImage*​ counterparts.        
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="sciformat">format​ can not be a generic compressed format.</param>
        /// <param name="cdata">buffer with already compressed image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <param name="imageSize">Defaults to cdata.length. The imageSize​ must match with what OpenGL would compute based on the dimensions of the image and the internalformat​.</param>
        unsafe public static void CompressedTextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, SizedCompressedInternalFormat sciformat, byte[] cdata, int index = 0, int imageSize = -1)
        {
            if (imageSize == -1)
                imageSize = cdata.Length;

            // SHOULD WE SILENTLY CLAMP ARRAY DATA?
            imageSize = Math.Min(cdata.Length - index, index + imageSize);

            fixed (byte* ptr = &cdata[index])
            {
                CompressedTextureSubImage2DEXT(TextureID, target, level, xoffset, yoffset, width, height, sciformat, imageSize, (IntPtr)ptr);
            }

        }

        /// <summary>
        /// Upload compressed 3d image data into an existing bound texture image and its existing mipmap level.
        /// With the exception of the first parameter, CompressedTextureSubImage3DEXT work identically to their glCompressedTexSubImage*​ counterparts.        
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">id of texture to upload compressed image data to.</param>
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
        /// CompressedTextureSubImage3DEXT redefines a contiguous subregion of an existing three-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , and the y indices yoffset and yoffset + height - 1 , and the z indices zoffset and zoffset + depth - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture format. The format of the compressed texture image is selected by the GL implementation that compressed it (see glTexImage3D) and should be queried at the time the texture was compressed with glGetTexLevelParameter.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        [EntryPoint(FunctionName = "glCompressedTextureSubImage3DEXT")]
        public static void CompressedTextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, SizedCompressedInternalFormat sciformat, int imageSize, IntPtr data){ throw new NotImplementedException(); }

        /// <summary>
        /// Upload compressed 3d image data into an existing bound texture image and its existing mipmap level.
        /// With the exception of the first parameter, CompressedTextureSubImage2DEXT work identically to their glCompressedTexSubImage*​ counterparts.        
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
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
        /// CompressedTextureSubImage3DEXT redefines a contiguous subregion of an existing three-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , and the y indices yoffset and yoffset + height - 1 , and the z indices zoffset and zoffset + depth - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture format. The format of the compressed texture image is selected by the GL implementation that compressed it (see glTexImage3D) and should be queried at the time the texture was compressed with glGetTexLevelParameter.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        public static void CompressedTextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, SizedCompressedInternalFormat sciformat, int imageSize, long offset)
        {
            CompressedTextureSubImage3DEXT(TextureID, target, level, xoffset, yoffset, zoffset, width, height, depth, sciformat, imageSize, (IntPtr)offset);
        }

        /// <summary>
        /// Upload compressed 3d image data into an existing bound texture image and its existing mipmap level.
        /// With the exception of the first parameter, CompressedTextureSubImage2DEXT work identically to their glCompressedTexSubImage*​ counterparts.        
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload compressed data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
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
        /// <remarks>
        /// CompressedTextureSubImage3DEXT redefines a contiguous subregion of an existing three-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , and the y indices yoffset and yoffset + height - 1 , and the z indices zoffset and zoffset + depth - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// internalformat must be a known compressed image format (such as GL_RGTC) or an extension-specified compressed-texture format. The format of the compressed texture image is selected by the GL implementation that compressed it (see glTexImage3D) and should be queried at the time the texture was compressed with glGetTexLevelParameter.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        unsafe public static void CompressedTextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, SizedCompressedInternalFormat sciformat, byte[] cdata, int index = 0, int imageSize = -1)
        {
            if (imageSize == -1)
                imageSize = cdata.Length;

            // SHOULD WE SILENTLY CLAMP ARRAY DATA?
            imageSize = Math.Min(cdata.Length - index, index + imageSize);

            fixed (byte* ptr = &cdata[index])
            {
                CompressedTextureSubImage3DEXT(TextureID, target, level, xoffset, yoffset, zoffset, width, height, depth, sciformat, imageSize, (IntPtr)ptr);
            }

        }


        [EntryPoint(FunctionName = "glGetCompressedTextureImageEXT")]
        public static void GetCompressedTextureImageEXT(uint TextureID, TextureTarget target, int level, IntPtr img){ throw new NotImplementedException(); }

        #endregion

        #region Public Helper Functions

        #endregion

    }
}

