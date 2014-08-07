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
        //#region DllImports

        //partial class DllImports
        //{

        //}

        //#endregion

        //#region Delegates

        //partial class Delegates
        //{
        //    #region Delegates

        //    // EXT_texture3d
        //    public delegate void delTexImage3D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels);
        //    public delegate void delTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels);
        //    public delegate void delCopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        //    // EXT_draw_range_elements
        //    public delegate void delDrawRangeElements(BeginMode mode, uint start, uint end, int count, IndicesType type, IntPtr indices);

        //    #endregion

        //    #region Fields

        //    public static delTexImage3D glTexImage3D;
        //    public static delTexSubImage3D glTexSubImage3D;
        //    public static delCopyTexSubImage3D glCopyTexSubImage3D;
        //    public static delDrawRangeElements glDrawRangeElements;

        //    #endregion
        //}

        //#endregion

        //#region Public Functions

        ///// <summary>
        ///// specify a three-dimensional texture image
        ///// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        ///// The first element corresponds to the lower left corner of the texture image. Subsequent elements progress left-to-right through the remaining texels in the lowest row of the texture image, and then in successively higher rows of the texture image. The final element corresponds to the upper right corner of the texture image.
        ///// </summary>
        ///// <param name="target">Specifies the target texture. Must be one of GL_TEXTURE_3D, GL_PROXY_TEXTURE_3D, GL_TEXTURE_2D_ARRAY or GL_PROXY_TEXTURE_2D_ARRAY.</param>
        ///// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the n th mipmap reduction image.</param>
        ///// <param name="piformat">Specifies the number of color components in the texture. Must be one of base internal formats given in Table 1, one of the sized internal formats given in Table 2, or one of the compressed internal formats given in Table 3, below.</param>
        ///// <param name="width">Specifies the width of the texture image. All implementations support 3D texture images that are at least 16 texels wide.</param>
        ///// <param name="height">Specifies the height of the texture image. All implementations support 3D texture images that are at least 256 texels high.</param>
        ///// <param name="depth">Specifies the depth of the texture image, or the number of layers in a texture array. All implementations support 3D texture images that are at least 256 texels deep, and texture arrays that are at least 256 layers deep.</param>
        ///// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_BGRA, GL_RED_INTEGER, GL_RG_INTEGER, GL_RGB_INTEGER, GL_BGR_INTEGER, GL_RGBA_INTEGER, GL_BGRA_INTEGER, GL_STENCIL_INDEX, GL_DEPTH_COMPONENT, GL_DEPTH_STENCIL.</param>
        ///// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        ///// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        //public static void TexImage3D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
        //{
        //    Delegates.glTexImage3D(target, level, piformat, width, height, depth, 0, format, type, pixels);
        //}
        ///// <summary>
        ///// specify a three-dimensional texture subimage
        ///// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        ///// </summary>
        ///// <param name="target">Specifies the target texture. Must be GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.</param>
        ///// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        ///// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        ///// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        ///// <param name="zoffset">Specifies a texel offset in the z direction within the texture array.</param>
        ///// <param name="width">Specifies the width of the texture subimage.</param>
        ///// <param name="height">Specifies the height of the texture subimage.</param>
        ///// <param name="depth">Specifies the depth of the texture subimage.</param>
        ///// <param name="format">Specifies the format of the pixel data. The following symbolic values are accepted: GL_RED, GL_RG, GL_RGB, GL_BGR, GL_RGBA, GL_DEPTH_COMPONENT, and GL_STENCIL_INDEX.</param>
        ///// <param name="type">Specifies the data type of the pixel data. The following symbolic values are accepted: GL_UNSIGNED_BYTE, GL_BYTE, GL_UNSIGNED_SHORT, GL_SHORT, GL_UNSIGNED_INT, GL_INT, GL_FLOAT, GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_2_3_3_REV, GL_UNSIGNED_SHORT_5_6_5, GL_UNSIGNED_SHORT_5_6_5_REV, GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_REV, GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_1_5_5_5_REV, GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_REV, GL_UNSIGNED_INT_10_10_10_2, and GL_UNSIGNED_INT_2_10_10_10_REV.</param>
        ///// <param name="pixels">Specifies a pointer to the image data in memory.</param>
        ///// <remarks>
        ///// Texturing maps a portion of a specified texture image onto each graphical primitive for which texturing is enabled.
        ///// glTexSubImage3D redefines a contiguous subregion of an existing three-dimensional or two-dimensioanl array texture image. The texels referenced by data replace the portion of the existing texture array with x indices xoffset and xoffset + width - 1 , inclusive, y indices yoffset and yoffset + height - 1 , inclusive, and z indices zoffset and zoffset + depth - 1 , inclusive. For three-dimensional textures, the z index refers to the third dimension. For two-dimensional array textures, the z index refers to the slice index. This region may not include any texels outside the range of the texture array as it was originally specified. It is not an error to specify a subtexture with zero width, height, or depth but such a specification has no effect.
        ///// If a non-zero named buffer object is bound to the GL_PIXEL_UNPACK_BUFFER target (see glBindBuffer) while a texture image is specified, data is treated as a byte offset into the buffer object's data store.
        ///// </remarks>
        //public static void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
        //{
        //    Delegates.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        //}
        ///// <summary>
        ///// copy a three-dimensional texture subimage
        ///// glCopyTexSubImage3D replaces a rectangular portion of a three-dimensional or two-dimensional array texture image with pixels from the current GL_READ_BUFFER (rather than from main memory, as is the case for glTexSubImage3D).
        ///// </summary>
        ///// <param name="target">Specifies the target texture. Must be GL_TEXTURE_3D or GL_TEXTURE_2D_ARRAY.</param>
        ///// <param name="level">Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.</param>
        ///// <param name="xoffset">Specifies a texel offset in the x direction within the texture array.</param>
        ///// <param name="yoffset">Specifies a texel offset in the y direction within the texture array.</param>
        ///// <param name="zoffset">Specifies a texel offset in the z direction within the texture array.</param>
        ///// <param name="x">Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.</param>
        ///// <param name="y">Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.</param>
        ///// <param name="width">Specifies the width of the texture subimage.</param>
        ///// <param name="height">Specifies the height of the texture subimage.</param>
        ///// <remarks>
        ///// The screen-aligned pixel rectangle with lower left corner at (x, y) and with width width and height height replaces the portion of the texture array with x indices xoffset through xoffset + width - 1 , inclusive, and y indices yoffset through yoffset + height - 1 , inclusive, at z index zoffset and at the mipmap level specified by level.
        ///// The pixels in the rectangle are processed exactly as if glReadPixels had been called, but the process stops just before final conversion. At this point, all pixel component values are clamped to the range 0 1 and then converted to the texture's internal format for storage in the texel array.
        ///// The destination rectangle in the texture array may not include any texels outside the texture array as it was originally specified. It is not an error to specify a subtexture with zero width or height, but such a specification has no effect.
        ///// If any of the pixels within the specified rectangle of the current GL_READ_BUFFER are outside the read window associated with the current rendering context, then the values obtained for those pixels are undefined.
        ///// No change is made to the internalformat, width, height, depth, or border parameters of the specified texture array or to texel values outside the specified subregion.
        ///// </remarks>
        //public static void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
        //{
        //    Delegates.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        //}
        ///// <summary>
        ///// render primitives from array data
        ///// 
        ///// </summary>
        ///// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.</param>
        ///// <param name="start">Specifies the minimum array index contained in indices.</param>
        ///// <param name="end">Specifies the maximum array index contained in indices.</param>
        ///// <param name="count">Specifies the number of elements to be rendered.</param>
        ///// <param name="type">Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</param>
        ///// <param name="offset">Specifies the offset in the element/indices buffer bound to source from.</param>
        //public static void DrawRangeElements(BeginMode mode, uint start, uint end, int count, IndicesType type, long offset)
        //{
        //    Delegates.glDrawRangeElements(mode, start, end, count, type, (IntPtr)offset);
        //}
        ///// <summary>
        ///// render primitives from array data
        ///// 
        ///// </summary>
        ///// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.</param>
        ///// <param name="start">Specifies the minimum array index contained in indices.</param>
        ///// <param name="end">Specifies the maximum array index contained in indices.</param>
        ///// <param name="count">Specifies the number of elements to be rendered.</param>
        ///// <param name="type">Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</param>
        ///// <param name="indices">Specifies a pointer to the location where the indices are stored.</param>
        //public static void DrawRangeElements(BeginMode mode, uint start, uint end, int count, IndicesType type, IntPtr indices)
        //{
        //    Delegates.glDrawRangeElements(mode, start, end, count, type, indices);
        //}

        //#endregion
    }
}
