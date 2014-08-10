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

        /// <summary>
        /// specify a three-dimensional texture image
        /// With the exception of the first parameter, TextureImage3DEXT work identically to their glTexImage*​ counterparts.          
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// The first element corresponds to the lower left corner of the texture image. Subsequent elements progress left-to-right through the remaining texels in the lowest row of the texture image, and then in successively higher rows of the texture image. The final element corresponds to the upper right corner of the texture image.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be one of GL_TEXTURE_3D, GL_PROXY_TEXTURE_3D, GL_TEXTURE_2D_ARRAY or GL_PROXY_TEXTURE_2D_ARRAY.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the n th mipmap reduction image.</param>
        /// <param name="piformat">Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.</param>
        /// <param name="width">Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high.</param>
        /// <param name="depth">Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        [EntryPoint(FunctionName = "glTextureImage3DEXT")]
        public static void TextureImage3DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels){ throw new NotImplementedException(); }

        /// <summary>
        /// specify a three-dimensional texture image
        /// With the exception of the first parameter, TextureImage3DEXT work identically to their glTexImage*​ counterparts.          
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// The first element corresponds to the lower left corner of the texture image. Subsequent elements progress left-to-right through the remaining texels in the lowest row of the texture image, and then in successively higher rows of the texture image. The final element corresponds to the upper right corner of the texture image.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be one of GL_TEXTURE_3D, GL_PROXY_TEXTURE_3D, GL_TEXTURE_2D_ARRAY or GL_PROXY_TEXTURE_2D_ARRAY.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the n th mipmap reduction image.</param>
        /// <param name="piformat">Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.</param>
        /// <param name="width">Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high.</param>
        /// <param name="depth">Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.</param>        
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        public static void TextureImage3DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, PixelFormat format, PixelType type, long offset, int border = 0)
        {
            TextureImage3DEXT(TextureID, target, level, piformat, width, height, depth, border, format, type, (IntPtr)offset);
        }

        /// <summary>
        /// specify a three-dimensional texture image
        /// With the exception of the first parameter, TextureImage3DEXT work identically to their glTexImage*​ counterparts.          
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be one of GL_TEXTURE_3D, GL_PROXY_TEXTURE_3D, GL_TEXTURE_2D_ARRAY or GL_PROXY_TEXTURE_2D_ARRAY.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the n th mipmap reduction image.</param>
        /// <param name="piformat">Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.</param>
        /// <param name="width">Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high.</param>
        /// <param name="depth">Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.</param>        
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="pixels">buffer with image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        unsafe public static void TextureImage3DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, PixelFormat format, PixelType type, byte[] pixels, int index = 0, int border = 0)
        {
            fixed (byte* ptr = &pixels[index])
            {
                TextureImage3DEXT(TextureID, target, level, piformat, width, height, depth, border, format, type, (IntPtr)ptr);
            }
        }
        /// <summary>
        /// specify a three-dimensional texture image
        /// With the exception of the first parameter, TextureImage3DEXT work identically to their glTexImage*​ counterparts.          
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be one of GL_TEXTURE_3D, GL_PROXY_TEXTURE_3D, GL_TEXTURE_2D_ARRAY or GL_PROXY_TEXTURE_2D_ARRAY.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the n th mipmap reduction image.</param>
        /// <param name="piformat">Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.</param>
        /// <param name="width">Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high.</param>
        /// <param name="depth">Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.</param>        
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="pixels">buffer with image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        public static void TextureImage3DEXT<TValueType>(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, PixelFormat format, PixelType type, TValueType[] pixels, int index = 0, int border = 0) where TValueType : struct
        {
            GCHandle handle = GCHandle.Alloc(pixels, GCHandleType.Pinned);

            var ptr = IntPtr.Zero;
            if (index == 0)
                ptr = handle.AddrOfPinnedObject();
            else
                ptr = Marshal.UnsafeAddrOfPinnedArrayElement(pixels, index);

            TextureImage3DEXT(TextureID, target, level, piformat, width, height, depth, border, format, type, ptr);

            handle.Free();
        }

        /// <summary>
        /// specify a three-dimensional texture subimage
        /// With the exception of the first parameter, TextureSubImage3DEXT work identically to their glTexSubImage*​ counterparts.          
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="zoffset">Specifies a texel offset in the z direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        /// <remarks>
        /// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled.
        /// glTexSubImage3D redefines a contiguous subregion of an existing three-dimensional or two-dimensioanl array texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive, y indices yoffset and yoffset + height - 1 , inclusive, and z indices zoffset and zoffset + depth - 1 , inclusive. For three-dimensional textures, the z index refers to the third dimension. For two-dimensional array textures, the z index refers to the slice index. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with zero width, height, or depth but such a specification has no effect.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        [EntryPoint(FunctionName = "glTextureSubImage3DEXT")]
        public static void TextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels){ throw new NotImplementedException(); }

        /// <summary>
        /// Upload 3d image data into an existing bound texture image and its existing mipmap level.      
        /// With the exception of the first parameter, TextureSubImage3DEXT work identically to their glTexSubImage*​ counterparts.          
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="zoffset">Specifies a texel offset in the z direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        /// <remarks>
        /// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled.
        /// TextureSubImage3DEXT redefines a contiguous subregion of an existing three-dimensional or two-dimensioanl array texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive, y indices yoffset and yoffset + height - 1 , inclusive, and z indices zoffset and zoffset + depth - 1 , inclusive. For three-dimensional textures, the z index refers to the third dimension. For two-dimensional array textures, the z index refers to the slice index. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with zero width, height, or depth but such a specification has no effect.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        public static void TextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, long offset)
        {
            TextureSubImage3DEXT(TextureID, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (IntPtr)offset);
        }

        /// <summary>
        /// Upload 3d image data into an existing bound texture image and its existing mipmap level.      
        /// With the exception of the first parameter, TextureSubImage3DEXT work identically to their glTexSubImage*​ counterparts.          
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="zoffset">Specifies a texel offset in the z direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="imgdata">buffer with image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <remarks>
        /// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled.
        /// TextureSubImage3DEXT redefines a contiguous subregion of an existing three-dimensional or two-dimensioanl array texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive, y indices yoffset and yoffset + height - 1 , inclusive, and z indices zoffset and zoffset + depth - 1 , inclusive. For three-dimensional textures, the z index refers to the third dimension. For two-dimensional array textures, the z index refers to the slice index. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with zero width, height, or depth but such a specification has no effect.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        unsafe public static void TextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, byte[] imgdata, int index = 0)
        {
            fixed (byte* ptr = &imgdata[index])
            {
                TextureSubImage3DEXT(TextureID, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (IntPtr)ptr);
            }
        }
        /// <summary>
        /// Upload 3d image data into an existing bound texture image and its existing mipmap level.      
        /// With the exception of the first parameter, TextureSubImage3DEXT work identically to their glTexSubImage*​ counterparts.          
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="zoffset">Specifies a texel offset in the z direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="depth">Specifies the depth of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="imgdata">buffer with image data.</param>
        /// <param name="index">Index in cdata array to start reading at.</param>
        /// <remarks>
        /// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled.
        /// TextureSubImage3DEXT redefines a contiguous subregion of an existing three-dimensional or two-dimensioanl array texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive, y indices yoffset and yoffset + height - 1 , inclusive, and z indices zoffset and zoffset + depth - 1 , inclusive. For three-dimensional textures, the z index refers to the third dimension. For two-dimensional array textures, the z index refers to the slice index. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with zero width, height, or depth but such a specification has no effect.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </remarks>
        public static void TextureSubImage3DEXT<TValueType>(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, TValueType[] imgdata, int index = 0) where TValueType : struct        
        {
            GCHandle handle = GCHandle.Alloc(imgdata, GCHandleType.Pinned);

            var ptr = IntPtr.Zero;
            if (index == 0)
                ptr = handle.AddrOfPinnedObject();
            else
                ptr = Marshal.UnsafeAddrOfPinnedArrayElement(imgdata, index);

            TextureSubImage3DEXT(TextureID, target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, ptr);

            handle.Free();
        }



        [EntryPoint(FunctionName = "glCopyTextureSubImage3DEXT")]
        public static void CopyTextureSubImage3DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height){ throw new NotImplementedException(); }

        #endregion

        #region Public Helper Functions

        #endregion

    }
}

