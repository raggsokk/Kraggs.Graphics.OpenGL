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

        //[EntryPointSlot(1)]
        //[DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //private static extern void glBindTexture(TextureTarget target, uint textureid);

        [EntryPointSlot(1)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindMultiTextureEXT(TextureUnit texUnit, TextureTarget target, uint TextureID);

        [EntryPointSlot(2)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureParameteriEXT(uint TextureID, TextureTarget target, TextureParameters pname, int param);
        [EntryPointSlot(3)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int* param);
        [EntryPointSlot(4)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureParameterfEXT(uint TextureID, TextureTarget target, TextureParameters pname, float param);
        [EntryPointSlot(5)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float* param);

        [EntryPointSlot(6)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureImage1DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int border, PixelFormat format, PixelType type, IntPtr data);
        [EntryPointSlot(7)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureImage2DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr data);
        [EntryPointSlot(8)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr data);
        [EntryPointSlot(9)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr data);
        [EntryPointSlot(10)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetTextureImageEXT(uint TextureID, TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr img);
        [EntryPointSlot(11)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int* result);
        [EntryPointSlot(12)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float* result);
        [EntryPointSlot(13)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureLevelParameterfvEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, float* result);
        [EntryPointSlot(14)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureLevelParameterivEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, int* result);


        #endregion

        #region Public functions

        /// <summary>
        /// Binds a texture to a texture unit and texture target in one call.
        /// </summary>
        /// <param name="texUnit">The TextureUnit to bind texture to.</param>
        /// <param name="target">The TextureTarget to bind texture as.</param>
        /// <param name="TextureID">The id of the texture to bind.</param>
        [EntryPoint(FunctionName = "glBindMultiTextureEXT")]
        public static void BindMultiTextureEXT(TextureUnit texUnit, TextureTarget target, uint TextureID){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glTextureParameteriEXT")]
        public static void TextureParameteriEXT(uint TextureID, TextureTarget target, TextureParameters pname, int param){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureParameterivEXT")]
        unsafe public static void TextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int* param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterivEXT")]
        public static void TextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int[] param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterivEXT")]
        public static void TextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref int param) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glTextureParameterfEXT")]
        public static void TextureParameterfEXT(uint TextureID, TextureTarget target, TextureParameters pname, float param){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureParameterfvEXT")]
        unsafe public static void TextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float* param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterfvEXT")]
        public static void TextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float[] param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterfvEXT")]
        public static void TextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref float param) { throw new NotImplementedException(); }

        /// <summary>
        /// specify a one-dimensional texture image
        /// With the exception of the first parameter, TextureImage1DEXT work identically to their glTexImage*​ counterparts.        
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D or GL_PROXY_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="piformat">Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.</param>
        /// <param name="width">Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide. The height of the 1D texture image is 1.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="data">Specifies a pointer to the image data in memory.</param>
        /// <remarks>
        /// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled. To enable and disable one-dimensional texturing, call glEnable and glDisable with argument GL_TEXTURE_1D.
        /// Texture images are defined with TextureImage1DEXT. The arguments describe the parameters of the texture image, such as width, width of the border, level-of-detail number (see glTexParameter), and the internal resolution and format used to store the image. The last three arguments describe how the image is represented in memory.
        /// If target is GL_PROXY_TEXTURE_1D, no data is read from data, but all of the texture image state is recalculated, checked for consistency, and checked against the implementation's capabilities. If the implementation cannot handle a texture of the requested texture size, it sets all of the image state to 0, but does not generate an error (see glGetError). To query for an entire mipmap array, use an image array level greater than or equal to 1.
        /// If target is GL_TEXTURE_1D, data is read from data as a sequence of signed or unsigned bytes, shorts, or longs, or single-precision floating-point values, depending on type. These values are grouped into sets of one, two, three, or four values, depending on format, to form elements. Each data byte is treated as eight 1-bit elements, with bit ordering determined by GL_UNPACK_LSB_FIRST (see glPixelStore).
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// The first element corresponds to the left end of the texture array. Subsequent elements progress left-to-right through the remaining texels in the texture array. The final element corresponds to the right end of the texture array.
        /// </remarks>
        [EntryPoint(FunctionName = "glTextureImage1DEXT")]
        public static void TextureImage1DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int border, PixelFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }

        /// <summary>
        /// specify a one-dimensional texture image
        /// With the exception of the first parameter, TextureImage1DEXT work identically to their glTexImage*​ counterparts.        
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D or GL_PROXY_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="piformat">Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.</param>
        /// <param name="width">Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide. The height of the 1D texture image is 1.</param>        
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        public static void TextureImage1DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, PixelFormat format, PixelType type, long offset, int border = 0)
        {
            TextureImage1DEXT(TextureID, target, level, piformat, width, border, format, type, (IntPtr)offset);
        }
        /// <summary>
        /// specify a one-dimensional texture image
        /// With the exception of the first parameter, TextureImage1DEXT work identically to their glTexImage*​ counterparts.        
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D or GL_PROXY_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="piformat">Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.</param>
        /// <param name="width">Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide. The height of the 1D texture image is 1.</param>        
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="pixels">buffer with image data.</param>
        /// <param name="index">Index in pixels array to start reading at.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        unsafe public static void TextureImage1DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, PixelFormat format, PixelType type, byte[] pixels, int index = 0, int border = 0)
        {
            fixed(byte* ptr = &pixels[index])
            {
                TextureImage1DEXT(TextureID, target, level, piformat, width, border, format, type, (IntPtr)ptr);
            }
        }

        /// <summary>
        /// specify a two-dimensional texture image
        /// With the exception of the first parameter, TextureImage2DEXT work identically to their glTexImage*​ counterparts.        
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.</param>
        /// <param name="piformat">Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.</param>
        /// <param name="width">Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>        
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="data">Specifies a pointer to the image data in memory.</param>
        /// <remarks>
        /// Texturing allows elements of an image array to be read by shaders.
        /// To define texture images, call glTexImage2D. The arguments describe the parameters of the texture image, such as height, width, width of the border, level-of-detail number (see glTexParameter), and number of color components provided. The last three arguments describe how the image is represented in memory.
        /// If target is GL_PROXY_TEXTURE_2D, GL_PROXY_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_CUBE_MAP, or GL_PROXY_TEXTURE_RECTANGLE, no data is read from data, but all of the texture image state is recalculated, checked for consistency, and checked against the implementation's capabilities. If the implementation cannot handle a texture of the requested texture size, it sets all of the image state to 0, but does not generate an error (see glGetError). To query for an entire mipmap array, use an image array level greater than or equal to 1.
        /// If target is GL_TEXTURE_2D, GL_TEXTURE_RECTANGLE or one of the GL_TEXTURE_CUBE_MAP targets, data is read from data as a sequence of signed or unsigned bytes, shorts, or longs, or single-precision floating-point values, depending on type. These values are grouped into sets of one, two, three, or four values, depending on format, to form elements. Each data byte is treated as eight 1-bit elements, with bit ordering determined by GL_UNPACK_LSB_FIRST (see glPixelStore).
        /// If target is GL_TEXTURE_1D_ARRAY, data is interpreted as an array of one-dimensional images.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// The first element corresponds to the lower left corner of the texture image. Subsequent elements progress left-to-right through the remaining texels in the lowest row of the texture image, and then in successively higher rows of the texture image. The final element corresponds to the upper right corner of the texture image.
        /// </remarks>
        [EntryPoint(FunctionName = "glTextureImage2DEXT")]
        public static void TextureImage2DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }

        /// <summary>
        /// specify a two-dimensional texture image
        /// With the exception of the first parameter, TextureImage2DEXT work identically to their glTexImage*​ counterparts.        
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.</param>
        /// <param name="piformat">Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.</param>
        /// <param name="width">Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.</param>        
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>
        /// <remarks>
        /// Texturing allows elements of an image array to be read by shaders.
        /// To define texture images, call glTexImage2D. The arguments describe the parameters of the texture image, such as height, width, width of the border, level-of-detail number (see glTexParameter), and number of color components provided. The last three arguments describe how the image is represented in memory.
        /// If target is GL_PROXY_TEXTURE_2D, GL_PROXY_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_CUBE_MAP, or GL_PROXY_TEXTURE_RECTANGLE, no data is read from data, but all of the texture image state is recalculated, checked for consistency, and checked against the implementation's capabilities. If the implementation cannot handle a texture of the requested texture size, it sets all of the image state to 0, but does not generate an error (see glGetError). To query for an entire mipmap array, use an image array level greater than or equal to 1.
        /// If target is GL_TEXTURE_2D, GL_TEXTURE_RECTANGLE or one of the GL_TEXTURE_CUBE_MAP targets, data is read from data as a sequence of signed or unsigned bytes, shorts, or longs, or single-precision floating-point values, depending on type. These values are grouped into sets of one, two, three, or four values, depending on format, to form elements. Each data byte is treated as eight 1-bit elements, with bit ordering determined by GL_UNPACK_LSB_FIRST (see glPixelStore).
        /// If target is GL_TEXTURE_1D_ARRAY, data is interpreted as an array of one-dimensional images.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// The first element corresponds to the lower left corner of the texture image. Subsequent elements progress left-to-right through the remaining texels in the lowest row of the texture image, and then in successively higher rows of the texture image. The final element corresponds to the upper right corner of the texture image.
        /// </remarks>
        public static void TextureImage2DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, PixelFormat format, PixelType type, long offset, int border = 0)
        {
            TextureImage2DEXT(TextureID, target, level, piformat, width, height, border, format, type, (IntPtr)offset);
        }
        /// <summary>
        /// specify a two-dimensional texture image
        /// With the exception of the first parameter, TextureImage2DEXT work identically to their glTexImage*​ counterparts.        
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D, GL_PROXY_TEXTURE_2D, GL_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY, GL_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_PROXY_TEXTURE_CUBE_MAP.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image. If target is GL_TEXTURE_RECTANGLE or GL_PROXY_TEXTURE_RECTANGLE, level must be 0.</param>
        /// <param name="piformat">Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.</param>
        /// <param name="width">Specifies the width of the texture image. All implementations support texture images that are at least 1024 texels wide.</param>
        /// <param name="height">Specifies the height of the texture image, or the number of layers in a texture array, in the case of the GL_TEXTURE_1D_ARRAY and GL_PROXY_TEXTURE_1D_ARRAY targets. All implementations support 2D texture images that are at least 1024 texels high, and texture arrays that are at least 256 layers deep.</param>        
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="pixels">buffer with image data.</param>
        /// <param name="index">Index in pixels array to start reading at.</param>
        /// <param name="border">Depricated in core context. must be 0.</param>        
        /// <remarks>
        /// Texturing allows elements of an image array to be read by shaders.
        /// To define texture images, call glTexImage2D. The arguments describe the parameters of the texture image, such as height, width, width of the border, level-of-detail number (see glTexParameter), and number of color components provided. The last three arguments describe how the image is represented in memory.
        /// If target is GL_PROXY_TEXTURE_2D, GL_PROXY_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_CUBE_MAP, or GL_PROXY_TEXTURE_RECTANGLE, no data is read from data, but all of the texture image state is recalculated, checked for consistency, and checked against the implementation's capabilities. If the implementation cannot handle a texture of the requested texture size, it sets all of the image state to 0, but does not generate an error (see glGetError). To query for an entire mipmap array, use an image array level greater than or equal to 1.
        /// If target is GL_TEXTURE_2D, GL_TEXTURE_RECTANGLE or one of the GL_TEXTURE_CUBE_MAP targets, data is read from data as a sequence of signed or unsigned bytes, shorts, or longs, or single-precision floating-point values, depending on type. These values are grouped into sets of one, two, three, or four values, depending on format, to form elements. Each data byte is treated as eight 1-bit elements, with bit ordering determined by GL_UNPACK_LSB_FIRST (see glPixelStore).
        /// If target is GL_TEXTURE_1D_ARRAY, data is interpreted as an array of one-dimensional images.
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// The first element corresponds to the lower left corner of the texture image. Subsequent elements progress left-to-right through the remaining texels in the lowest row of the texture image, and then in successively higher rows of the texture image. The final element corresponds to the upper right corner of the texture image.
        /// </remarks>
        unsafe public static void TextureImage2DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, PixelFormat format, PixelType type, byte[] pixels, int index = 0, int border = 0)
        {
            fixed (byte* ptr = &pixels[index])
            {
                TextureImage2DEXT(TextureID, target, level, piformat, width, height, border, format, type, (IntPtr)ptr);
            }
        }

        /// <summary>
        /// Upload 1d image data into an existing bound texture image and its existing mipmap level.      
        /// With the exception of the first parameter, TextureSubImage1DEXT work identically to their glTexSubImage*​ counterparts.          
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="data">Specifies a pointer to the image data in memory.</param>
        /// <remarks>
        /// TextureSubImage1DEXT redefines a contiguous subregion of an existing one-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// </remarks>
        [EntryPoint(FunctionName = "glTextureSubImage1DEXT")]
        public static void TextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }

        /// <summary>
        /// Upload 1d image data into an existing bound texture image and its existing mipmap level.      
        /// With the exception of the first parameter, TextureSubImage1DEXT work identically to their glTexSubImage*​ counterparts.          
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        /// <remarks>
        /// TextureSubImage1DEXT redefines a contiguous subregion of an existing one-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// </remarks>
        public static void TextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, long offset)
        {
            TextureSubImage1DEXT(TextureID, target, level, xoffset, width, format, type, (IntPtr)offset);
        }

        /// <summary>
        /// Upload 1d image data into an existing bound texture image and its existing mipmap level.      
        /// With the exception of the first parameter, TextureSubImage1DEXT work identically to their glTexSubImage*​ counterparts.          
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_1D.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="pixels">buffer with image data.</param>
        /// <param name="index">Index in pixels array to start reading at.</param>
        /// <remarks>
        /// TexSubImage1D redefines a contiguous subregion of an existing one-dimensional texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with width of 0, but such a specification has no effect.
        /// </remarks>
        unsafe public static void TextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, byte[] pixels, int index)
        {
            fixed(byte* ptr = &pixels[index])
            {
                TextureSubImage1DEXT(TextureID, target, level, xoffset, width, format, type, (IntPtr)ptr);
            }
        }

        /// <summary>        
        /// Upload 2d image data into an existing bound texture image and its existing mipmap level.      
        /// With the exception of the first parameter, TextureSubImage2DEXT work identically to their glTexSubImage*​ counterparts.          
        /// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="data">Specifies a pointer to the image data in memory.</param>
        [EntryPoint(FunctionName = "glTextureSubImage2DEXT")]
        public static void TextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }

        /// <summary>
        /// Upload 1d image data into an existing bound texture image and its existing mipmap level.      
        /// With the exception of the first parameter, TextureSubImage2DEXT work identically to their glTexSubImage*​ counterparts.          
        /// NOTE: REQUIRES a non-zero named buffer object bound to GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="offset">When GL_UNPACK_BUFFER binding is non-zero, data is a byte-offset from start of bound buffer to read from.</param>
        public static void TextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, long offset)
        {
            TextureSubImage2DEXT(TextureID, target, level, xoffset, yoffset, width, height, format, type, (IntPtr)offset);
        }

        /// <summary>
        /// Upload 1d image data into an existing bound texture image and its existing mipmap level.      
        /// With the exception of the first parameter, TextureSubImage2DEXT work identically to their glTexSubImage*​ counterparts.          
        /// NOTE: REQUIRES zero named buffer object bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified.
        /// </summary>
        /// <param name="TextureID">Id of named texture to upload pixel data to.</param>
        /// <param name="target">Specifies the target texture. Must be GL_TEXTURE_2D, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.</param>
        /// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        /// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        /// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        /// <param name="width">Specifies the width of the texture subimage.</param>
        /// <param name="height">Specifies the height of the texture subimage.</param>
        /// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        /// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        /// <param name="pixels">buffer with image data.</param>
        /// <param name="index">Index in pixels array to start reading at.</param>
        unsafe public static void TextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, byte[] pixels, int index)
        {
            fixed (byte* ptr = &pixels[index])
            {
                TextureSubImage2DEXT(TextureID, target, level, xoffset, yoffset, width, height, format, type, (IntPtr)ptr);
            }
        }

        /// <summary>
        /// Retrives from the specified texture, the specified mipmap image data.
        /// </summary>
        /// <param name="TextureID">id of texture to retrive image data from.</param>
        /// <param name="target">Texturetarget texture is bound to.</param>
        /// <param name="level">mipmap level to retrive.</param>
        /// <param name="format">format of retrived data.</param>
        /// <param name="type">byte type of retrived data.</param>
        /// <param name="img">preallocated buffer big enough to store image data.</param>
        [EntryPoint(FunctionName = "glGetTextureImageEXT")]
        public static void GetTextureImageEXT(uint TextureID, TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr img){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrives from the current bound texture, the specified mipmap image data.
        /// </summary>
        /// <param name="target">Texturetarget texture is bound to.</param>
        /// <param name="level">mipmap level to retrive.</param>
        /// <param name="format">format of retrived data.</param>
        /// <param name="type">byte type of retrived data.</param>
        /// <param name="data">preallocated buffer big enough to store image data.</param>
        /// <param name="index">index in data buffer to start writing at.</param>
        unsafe public static void GetTextureImageEXT(uint TextureID, TextureTarget target, int level, PixelFormat format, PixelType type, byte[] data, int index = 0)
        {
            fixed (byte* ptr = &data[index])
            {
                GetTextureImageEXT(TextureID, target, level, format, type, (IntPtr)ptr);
            }
        }


        [EntryPoint(FunctionName = "glGetTextureParameterivEXT")]
        unsafe public static void GetTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterivEXT")]
        public static void GetTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterivEXT")]
        public static void GetTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref int result) { throw new NotImplementedException(); }
        public static int GetTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname)
        {
            int tmp = 0;
            GetTextureParameterivEXT(TextureID, target, pname, ref tmp);
            return tmp;
        }

        [EntryPoint(FunctionName = "glGetTextureParameterfvEXT")]
        unsafe public static void GetTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterfvEXT")]
        public static void GetTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterfvEXT")]
        public static void GetTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref float result) { throw new NotImplementedException(); }
        
        public static float GetTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname)
        {
            float tmp = 0.0f;
            GetTextureParameterfvEXT(TextureID, target, pname, ref tmp);
            return tmp;
        }

        [EntryPoint(FunctionName = "glGetTextureLevelParameterfvEXT")]
        unsafe public static void GetTextureLevelParameterfvEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, float* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureLevelParameterfvEXT")]
        public static void GetTextureLevelParameterfvEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, float[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureLevelParameterfvEXT")]
        public static void GetTextureLevelParameterfvEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, ref float result) { throw new NotImplementedException(); }

        public static float GetTextureLevelParameterfvEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname)
        {
            float tmp = 0.0f;
            GetTextureLevelParameterfvEXT(TextureID, target, level, pname, ref tmp);
            return tmp;
        }

        [EntryPoint(FunctionName = "glGetTextureLevelParameterivEXT")]
        unsafe public static void GetTextureLevelParameterivEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureLevelParameterivEXT")]
        public static void GetTextureLevelParameterivEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureLevelParameterivEXT")]
        public static void GetTextureLevelParameterivEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, ref int result) { throw new NotImplementedException(); }
        
        public static int GetTextureLevelParameterivEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname)
        {
            int tmp = 0;
            GetTextureLevelParameterivEXT(TextureID, target, level, pname, ref tmp);
            return tmp;
        }

        #endregion

        #region Public Helper Functions

        #endregion
    }
}
