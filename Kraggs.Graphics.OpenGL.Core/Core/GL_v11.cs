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
        #region DllImports

        partial class DllImports
        {
            [DllImport(OPENGL_LIBRARY)]
            public static extern void glBindTexture(TextureTarget target, uint textureid);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glBlendFunc(BlendFactorSrc sfactor, BlendFactorDst dfactor);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glClear(ClearBufferFlags flags);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glClearColor(float red, float green, float blue, float alpha);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glColorMask(bool red, bool green,
                bool blue, bool alpha);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glCullFace(CullMode mode);

            [DllImport(OPENGL_LIBRARY)]
            public unsafe static extern void glDeleteTextures(int number, ref uint textures);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glDepthFunc(DepthFunction function);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glDepthMask(bool writeable);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glDepthRange(double nearVal, double farVal);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glDisable(EnableState cap);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glDrawArrays(BeginMode mode, int first, int count);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glDrawBuffer(DrawBufferTarget mode);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glDrawElements(BeginMode mode, int count,
                IndicesType type, IntPtr ptr);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glEnable(EnableState cap);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glFinish();

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glFlush();

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glFrontFace(FrontFaceMode mode);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glGenTextures(int number, ref uint textures);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glGetBooleanv(GetParameters pname, ref bool @params);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glGetDoublev(GetParameters pname, ref double @params);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glGetFloatv(GetParameters pname, ref float @params);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glGetIntegerv(GetParameters pname, ref int @params);

            [DllImport(OPENGL_LIBRARY)]
            public static extern ErrorCode glGetError();

            [DllImport(OPENGL_LIBRARY)]
            public static extern IntPtr glGetString(StringName name);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glGetTexImage(TextureTarget target, int level,
                PixelFormat format, PixelType type, IntPtr img);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glGetTexLevelParameterfv(TextureTarget target, int level,
                TextureLevelParameters pname, ref float @params);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glGetTexLevelParameteriv(TextureTarget target, int level,
                TextureLevelParameters pname, ref int @params);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glGetTexParameteriv(TextureTarget target, TextureParameters pname, ref int @params);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glGetTexParameterfv(TextureTarget target, TextureParameters pname, ref float @params);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glHint(HintTarget target, HintMode mode);

            [DllImport(OPENGL_LIBRARY)]
            public static extern bool glIsEnabled(EnableState cap);

            [DllImport(OPENGL_LIBRARY)]
            [return: MarshalAs(UnmanagedType.Bool)]
            public static extern bool glIsTexture(uint textureid);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glLineWidth(float width);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glLogicOp(LogicOpEnum opcode);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glPixelStorei(PixelStoreParameters pname, int param);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glPixelStoref(PixelStoreParameters pname, float param);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glPointSize(float size);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glPolygonMode(PolygonFace face, PolygonMode mode);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glPolygonOffset(float factor, float units);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glReadBuffer(ReadBufferMode mode);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glReadPixels(int x, int y, int width, int height,
                PixelFormat format, PixelType type, IntPtr data);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glScissor(int x, int y, int width, int height);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glStencilFunc(StencilFunction function, int @ref, uint mask);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glStencilMask(uint mask);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glStencilOp(StencilOperation fail, StencilOperation zfail, StencilOperation zpass);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glTexImage1D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int border, PixelFormat format, PixelType type, IntPtr data);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glTexImage2D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr data);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glTexParameteri(TextureTarget target, TextureParameters pname, int param);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glTexParameteriv(TextureTarget target, TextureParameters pname, int[] param);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glTexParameterf(TextureTarget target, TextureParameters pname, float param);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glTexParameterfv(TextureTarget target, TextureParameters pname, float[] param);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr data);


            [DllImport(OPENGL_LIBRARY)]
            public static extern void glTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr data);

            [DllImport(OPENGL_LIBRARY)]
            public static extern void glViewport(int x, int y, int width, int height);

        }

        #endregion

        #region Delegates

        partial class Delegates
        {
            #region Delegate signature

            public delegate void delBindTexture(TextureTarget target, uint textureid);
            public delegate void delBlendFunc(BlendFactorSrc sfactor, BlendFactorDst dfactor);
            public delegate void delClear(ClearBufferFlags flags);
            public delegate void delClearColor(float red, float green, float blue, float alpha);
            public delegate void delColorMask(bool red, bool green, bool blue, bool alpha);
            public delegate void delCullFace(CullMode mode);
            public delegate void delDeleteTextures(int number, ref uint textures);
            public delegate void delDepthFunc(DepthFunction function);
            public delegate void delDepthMask(bool writeable);
            public delegate void delDepthRange(double nearVal, double farVal);
            public delegate void delDisable(EnableState cap);
            public delegate void delDrawArrays(BeginMode mode, int first, int count);
            public delegate void delDrawBuffer(DrawBufferTarget mode);
            public delegate void delDrawElements(BeginMode mode, int count, IndicesType type, IntPtr ptr);
            public delegate void delEnable(EnableState cap);
            public delegate void delFinish();
            public delegate void delFlush();
            public delegate void delFrontFace(FrontFaceMode mode);
            public delegate void delGenTextures(int number, ref uint textures);
            public delegate void delGetBooleanv(GetParameters pname, ref bool @params);
            public delegate void delGetDoublev(GetParameters pname, ref double @params);
            public delegate void delGetFloatv(GetParameters pname, ref float @params);
            public delegate void delGetIntegerv(GetParameters pname, ref int @params);
            public delegate ErrorCode delGetError();
            public delegate IntPtr delGetString(StringName name);
            public delegate void delGetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr img);
            public delegate void delGetTexLevelParameterfv(TextureTarget target, int level, TextureLevelParameters pname, ref float @params);
            public delegate void delGetTexLevelParameteriv(TextureTarget target, int level, TextureLevelParameters pname, ref int @params);
            public delegate void delGetTexParameteriv(TextureTarget target, TextureParameters pname, ref int @params);
            public delegate void delGetTexParameterfv(TextureTarget target, TextureParameters pname, ref float @params);
            //public delegate void delGetTexParameterIiv(TextureTarget target, TexParameterName pname, int[] @params);
            //public delegate void delGetTexParameterIfv(TextureTarget target, TexParameterName pname, float[] @params);
            public delegate void delHint(HintTarget target, HintMode mode);
            public delegate bool delIsEnabled(EnableState cap);
            //[return: MarshalAs(UnmanagedType.Bool)]
            public delegate bool delIsTexture(uint textureid);
            public delegate void delLineWidth(float width);
            public delegate void delLogicOp(LogicOpEnum opcode);
            public delegate void delPixelStorei(PixelStoreParameters pname, int param);
            public delegate void delPixelStoref(PixelStoreParameters pname, float param);
            public delegate void delPointSize(float size);
            public delegate void delPolygonMode(PolygonFace face, PolygonMode mode);
            public delegate void delPolygonOffset(float factor, float units);
            public delegate void delReadBuffer(ReadBufferMode mode);
            public delegate void delReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr data);
            public delegate void delScissor(int x, int y, int width, int height);
            public delegate void delStencilFunc(StencilFunction function, int @ref, uint mask);
            public delegate void delStencilMask(uint mask);
            public delegate void delStencilOp(StencilOperation fail, StencilOperation zfail, StencilOperation zpass);
            public delegate void delTexImage1D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int border, PixelFormat format, PixelType type, IntPtr data);
            public delegate void delTexImage2D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr data);
            public delegate void delTexParameteri(TextureTarget target, TextureParameters pname, int param);
            public delegate void delTexParameteriv(TextureTarget target, TextureParameters pname, int[] param);
            //public delegate void delTexParameterIiv(TextureTarget target, TexParameterName pname, int[] param);
            public delegate void delTexParameterf(TextureTarget target, TextureParameters pname, float param);
            public delegate void delTexParameterfv(TextureTarget target, TextureParameters pname, float[] param);
            //public delegate void delTexParameterIfv(TextureTarget target, TexParameterName pname, float[] param);
            public delegate void delTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr data);
            public delegate void delTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr data);
            public delegate void delViewport(int x, int y, int width, int height);

            #endregion

            #region Delegate Fields

            public static delBindTexture glBindTexture;
            public static delBlendFunc glBlendFunc;
            public static delClear glClear;
            public static delClearColor glClearColor;
            public static delColorMask glColorMask;
            public static delCullFace glCullFace;
            public static delDeleteTextures glDeleteTextures;

            public static delDepthFunc glDepthFunc;
            public static delDepthMask glDepthMask;
            public static delDepthRange glDepthRange;
            public static delDisable glDisable;
            public static delDrawArrays glDrawArrays;
            public static delDrawBuffer glDrawBuffer;
            public static delDrawElements glDrawElements;
            public static delEnable glEnable;
            public static delFinish glFinish;
            public static delFlush glFlush;
            public static delFrontFace glFrontFace;
            public static delGenTextures glGenTextures;
            public static delGetBooleanv glGetBooleanv;
            public static delGetDoublev glGetDoublev;
            public static delGetFloatv glGetFloatv;
            public static delGetIntegerv glGetIntegerv;
            public static delGetError glGetError;
            public static delGetString glGetString;
            public static delGetTexImage glGetTexImage;
            public static delGetTexLevelParameterfv glGetTexLevelParameterfv;
            public static delGetTexLevelParameteriv glGetTexLevelParameteriv;
            public static delGetTexParameteriv glGetTexParameteriv;
            public static delGetTexParameterfv glGetTexParameterfv;
            //public static delGetTexParameterIiv glGetTexParameterIiv;
            //public static delGetTexParameterIfv glGetTexParameterIfv;
            public static delHint glHint;
            public static delIsEnabled glIsEnabled;
            //[return: MarshalAs(UnmanagedType.Bool)]
            public static delIsTexture glIsTexture;
            public static delLineWidth glLineWidth;
            public static delLogicOp glLogicOp;
            public static delPixelStorei glPixelStorei;
            public static delPixelStoref glPixelStoref;
            public static delPointSize glPointSize;
            public static delPolygonMode glPolygonMode;
            public static delPolygonOffset glPolygonOffset;
            public static delReadBuffer glReadBuffer;
            public static delReadPixels glReadPixels;
            public static delScissor glScissor;
            public static delStencilFunc glStencilFunc;
            public static delStencilMask glStencilMask;
            public static delStencilOp glStencilOp;
            public static delTexImage1D glTexImage1D;
            public static delTexImage2D glTexImage2D;
            public static delTexParameteri glTexParameteri;
            public static delTexParameteriv glTexParameteriv;
            //public static delTexParameterIiv glTexParameterIiv;
            public static delTexParameterf glTexParameterf;
            public static delTexParameterfv glTexParameterfv;
            //public static delTexParameterIfv glTexParameterIfv;
            public static delTexSubImage1D glTexSubImage1D;
            public static delTexSubImage2D glTexSubImage2D;
            public static delViewport glViewport;

            #endregion

        }

        #endregion

        #region Public Functions

        /// <summary>
        /// Bind a named texture to a texturing target
        /// NOTE: The GL_TEXTURE_2D_MULTISAMPLE and GL_TEXTURE_2D_MULTISAMPLE_ARRAY targets are available only if the GL version is 3.2 or higher.
        /// </summary>
        /// <param name="target">Specifies the target to which the texture is bound. Must be one of GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_BUFFER, GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY.</param>
        /// <param name="textureid">Specifies the name of a texture.</param>
        /// <remarks>
        /// glBindTexture lets you create or use a named texture. Calling glBindTexture with target set to GL_TEXTURE_1D, GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_BUFFER, GL_TEXTURE_2D_MULTISAMPLE or GL_TEXTURE_2D_MULTISAMPLE_ARRAY and texture set to the name of the new texture binds the texture name to the target. When a texture is bound to a target, the previous binding for that target is automatically broken.
        /// Texture names are unsigned integers. The value zero is reserved to represent the default texture for each texture target. Texture names and the corresponding texture contents are local to the shared object space of the current GL rendering context; two rendering contexts share texture names only if they explicitly enable sharing between contexts through the appropriate GL windows interfaces functions.
        /// You must use glGenTextures to generate a set of new texture names.
        /// When a texture is first bound, it assumes the specified target: A texture first bound to GL_TEXTURE_1D becomes one-dimensional texture, a texture first bound to GL_TEXTURE_2D becomes two-dimensional texture, a texture first bound to GL_TEXTURE_3D becomes three-dimensional texture, a texture first bound to GL_TEXTURE_1D_ARRAY becomes one-dimensional array texture, a texture first bound to GL_TEXTURE_2D_ARRAY becomes two-dimensional arary texture, a texture first bound to GL_TEXTURE_RECTANGLE becomes rectangle texture, a texture first bound to GL_TEXTURE_CUBE_MAP becomes a cube-mapped texture, a texture first bound to GL_TEXTURE_CUBE_MAP_ARRAY becomes a cube-mapped array texture, a texture first bound to GL_TEXTURE_BUFFER becomes a buffer texture, a texture first bound to GL_TEXTURE_2D_MULTISAMPLE becomes a two-dimensional multisampled texture, and a texture first bound to GL_TEXTURE_2D_MULTISAMPLE_ARRAY becomes a two-dimensional multisampled array texture. The state of a one-dimensional texture immediately after it is first bound is equivalent to the state of the default GL_TEXTURE_1D at GL initialization, and similarly for the other texture types.
        /// 
        /// While a texture is bound, GL operations on the target to which it is bound affect the bound texture, and queries of the target to which it is bound return state from the bound texture. In effect, the texture targets become aliases for the textures currently bound to them, and the texture name zero refers to the default textures that were bound to them at initialization.
        /// 
        /// A texture binding created with glBindTexture remains active until a different texture is bound to the same target, or until the bound texture is deleted with glDeleteTextures.
        /// 
        /// Once created, a named texture may be re-bound to its same original target as often as needed. It is usually much faster to use glBindTexture to bind an existing named texture to one of the texture targets than it is to reload the texture image using glTexImage1D, glTexImage2D, glTexImage3D or another similar function.
        /// </remarks>
        public static void BindTexture(TextureTarget target, uint textureid)
        {
            Delegates.glBindTexture(target, textureid);
        }

        /// <summary>
        /// specify pixel arithmetic
        /// Pixels can be drawn using a function that blends the incoming (source) RGBA values with the RGBA values that are already in the frame buffer (the destination values). Blending is initially disabled. Use glEnable and glDisable with argument GL_BLEND to enable and disable blending.
        /// </summary>
        /// <param name="sfactor">Specifies how the red, green, blue, and alpha source blending factors are computed. The initial value is GL_ONE.</param>
        /// <param name="dfactor">Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic constants are accepted: GL_ZERO, GL_ONE, GL_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR, GL_DST_COLOR, GL_ONE_MINUS_DST_COLOR, GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_DST_ALPHA, GL_ONE_MINUS_DST_ALPHA. GL_CONSTANT_COLOR, GL_ONE_MINUS_CONSTANT_COLOR, GL_CONSTANT_ALPHA, and GL_ONE_MINUS_CONSTANT_ALPHA. The initial value is GL_ZERO.</param>
        public static void BlendFunc(BlendFactorSrc sfactor, BlendFactorDst dfactor)
        {
            Delegates.glBlendFunc(sfactor, dfactor);
        }
        /// <summary>
        /// clear buffers to preset values
        /// glClear sets the bitplane area of the window to values previously selected by glClearColor, glClearDepth, and glClearStencil. Multiple color buffers can be cleared simultaneously by selecting more than one buffer at a time using glDrawBuffer.
        /// </summary>
        /// <param name="flags">Bitwise OR of masks that indicate the buffers to be cleared. The three masks are GL_COLOR_BUFFER_BIT, GL_DEPTH_BUFFER_BIT, and GL_STENCIL_BUFFER_BIT.</param>
        /// <remarks>
        /// glClear sets the bitplane area of the window to values previously selected by glClearColor, glClearDepth, and glClearStencil. Multiple color buffers can be cleared simultaneously by selecting more than one buffer at a time using glDrawBuffer.
        /// The pixel ownership test, the scissor test, dithering, and the buffer writemasks affect the operation of glClear. The scissor box bounds the cleared region. Alpha function, blend function, logical operation, stenciling, texture mapping, and depth-buffering are ignored by glClear.
        /// </remarks>
        public static void Clear(ClearBufferFlags flags)
        {
            Delegates.glClear(flags);
        }
        /// <summary>
        /// specify clear values for the color buffers
        /// glClearColor specifies the red, green, blue, and alpha values used by glClear to clear the color buffers. Values specified by glClearColor are clamped to the range 0 1 .
        /// </summary>
        /// <param name="red">Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0</param>
        /// <param name="green">Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0</param>
        /// <param name="blue">Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0</param>
        /// <param name="alpha">Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0</param>
        public static void ClearColor(float red, float green, float blue, float alpha)
        {
            Delegates.glClearColor(red, green, blue, alpha);
        }
        /// <summary>
        /// enable and disable writing of frame buffer color components
        /// </summary>
        /// <param name="red">Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written.</param>
        /// <param name="green">Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written.</param>
        /// <param name="blue">Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written.</param>
        /// <param name="alpha">Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all GL_TRUE, indicating that the color components are written.</param>
        /// <remarks>
        /// glColorMask and glColorMaski specify whether the individual color components in the frame buffer can or cannot be written. glColorMaski sets the mask for a specific draw buffer, whereas glColorMask sets the mask for all draw buffers. If red is GL_FALSE, for example, no change is made to the red component of any pixel in any of the color buffers, regardless of the drawing operation attempted.
        /// Changes to individual bits of components cannot be controlled. Rather, changes are either enabled or disabled for entire color components.
        /// </remarks>
        public static void ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            Delegates.glColorMask(red, green, blue, alpha);
        }

        /// <summary>
        /// specify whether front- or back-facing facets can be culled
        /// </summary>
        /// <param name="mode">Specifies whether front- or back-facing facets are candidates for culling. Symbolic constants GL_FRONT, GL_BACK, and GL_FRONT_AND_BACK are accepted. The initial value is GL_BACK.</param>
        /// <remarks>
        /// glCullFace specifies whether front- or back-facing facets are culled (as specified by mode) when facet culling is enabled. Facet culling is initially disabled. To enable and disable facet culling, call the glEnable and glDisable commands with the argument GL_CULL_FACE. Facets include triangles, quadrilaterals, polygons, and rectangles.
        /// glFrontFace specifies which of the clockwise and counterclockwise facets are front-facing and back-facing. See glFrontFace.
        /// </remarks>
        public static void CullFace(CullMode mode)
        {
            Delegates.glCullFace(mode);
        }
        /// <summary>
        /// delete named textures
        /// </summary>
        /// <param name="textures">Specifies an array of textures to be deleted.</param>
        /// <remarks>
        /// glDeleteTextures deletes n textures named by the elements of the array textures. After a texture is deleted, it has no contents or dimensionality, and its name is free for reuse (for example by glGenTextures). If a texture that is currently bound is deleted, the binding reverts to 0 (the default texture).
        /// </remarks>
        public static void DeleteTexture(uint[] textures)
        {
            Delegates.glDeleteTextures(textures.Length, ref textures[0]);
        }
        /// <summary>
        /// delete a named texture
        /// </summary>
        /// <param name="texture">Specifies a texture to be deleted.</param>
        /// <remarks>glDeleteTextures deletes n textures named by the elements of the array textures. After a texture is deleted, it has no contents or dimensionality, and its name is free for reuse (for example by glGenTextures). If a texture that is currently bound is deleted, the binding reverts to 0 (the default texture).</remarks>
        public static void DeleteTexture(uint texture)
        {
            Delegates.glDeleteTextures(1, ref texture);
        }
        /// <summary>
        /// specify the value used for depth buffer comparisons
        /// </summary>
        /// <param name="function">Specifies the depth comparison function. Symbolic constants GL_NEVER, GL_LESS, GL_EQUAL, GL_LEQUAL, GL_GREATER, GL_NOTEQUAL, GL_GEQUAL, and GL_ALWAYS are accepted. The initial value is GL_LESS.</param>
        /// <remarks>glDepthFunc specifies the function used to compare each incoming pixel depth value with the depth value present in the depth buffer. The comparison is performed only if depth testing is enabled. (See glEnable and glDisable of GL_DEPTH_TEST.)</remarks>
        public static void DepthFunc(DepthFunction function)
        {
            Delegates.glDepthFunc(function);
        }
        /// <summary>
        /// enable or disable writing into the depth buffer
        /// </summary>
        /// <param name="writeable">Specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled.</param>
        /// <remarks>glDepthMask specifies whether the depth buffer is enabled for writing. If flag is GL_FALSE, depth buffer writing is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled.</remarks>
        public static void DepthMask(bool writeable)
        {
            Delegates.glDepthMask(writeable);
        }
        /// <summary>
        /// specify mapping of depth values from normalized device coordinates to window coordinates
        /// </summary>
        /// <param name="nearVal">Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.</param>
        /// <param name="farVal">Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.</param>
        /// <remarks>
        /// After clipping and division by w, depth coordinates range from -1 to 1, corresponding to the near and far clipping planes. glDepthRange specifies a linear mapping of the normalized depth coordinates in this range to window depth coordinates. Regardless of the actual depth buffer implementation, window coordinate depth values are treated as though they range from 0 through 1 (like color components). Thus, the values accepted by glDepthRange are both clamped to this range before they are accepted.
        /// The setting of (0,1) maps the near plane to 0 and the far plane to 1. With this mapping, the depth buffer range is fully utilized.
        /// It is not necessary that nearVal be less than farVal. Reverse mappings such as nearVal = 1 , and farVal = 0 are acceptable.
        /// </remarks>
        public static void DepthRange(double nearVal, double farVal)
        {
            Delegates.glDepthRange(nearVal, farVal);
        }
        /// <summary>
        /// enable or disable server-side GL capabilities
        /// </summary>
        /// <param name="cap">Specifies a symbolic constant indicating a GL capability.</param>
        /// <remarks>
        /// glEnable and glDisable enable and disable various capabilities. Use glIsEnabled or glGet to determine the current setting of any capability. The initial value for each capability with the exception of GL_DITHER and GL_MULTISAMPLE is GL_FALSE. The initial value for GL_DITHER and GL_MULTISAMPLE is GL_TRUE.
        /// </remarks>
        public static void Disable(EnableState cap)
        {
            Delegates.glDisable(cap);
        }
        /// <summary>
        /// render primitives from array data
        /// When glDrawArrays is called, it uses count sequential elements from each enabled array to construct a sequence of geometric primitives, beginning with element first. mode specifies what kind of primitives are constructed and how the array elements construct those primitives.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.</param>
        /// <param name="first">Specifies the starting index in the enabled arrays.</param>
        /// <param name="count">Specifies the number of indices to be rendered.</param>
        /// <remarks>GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY and GL_TRIANGLES_ADJACENCY are available only if the GL version is 3.2 or greater.</remarks>
        public static void DrawArrays(BeginMode mode, int first, int count)
        {
            Delegates.glDrawArrays(mode, first, count);
        }
        /// <summary>
        /// specify which color buffers are to be drawn into
        /// When colors are written to the frame buffer, they are written into the color buffers specified by glDrawBuffer.
        /// </summary>
        /// <param name="mode">Specifies up to four color buffers to be drawn into. Symbolic constants GL_NONE, GL_FRONT_LEFT, GL_FRONT_RIGHT, GL_BACK_LEFT, GL_BACK_RIGHT, GL_FRONT, GL_BACK, GL_LEFT, GL_RIGHT, and GL_FRONT_AND_BACK are accepted. The initial value is GL_FRONT for single-buffered contexts, and GL_BACK for double-buffered contexts.</param>
        public static void DrawBuffer(DrawBufferTarget mode)
        {
            Delegates.glDrawBuffer(mode);
        }
        /// <summary>
        /// render primitives from array data
        /// When glDrawElements is called, it uses count sequential elements from an enabled array, starting at indices to construct a sequence of geometric primitives. mode specifies what kind of primitives are constructed and how the array elements construct these primitives. If more than one array is enabled, each is used.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</param>
        /// <param name="ptr">Specifies a offset to the location where the indices are stored.</param>
        public static void DrawElements(BeginMode mode, int count, IndicesType type, long offset = 0)
        {
            Delegates.glDrawElements(mode, count, type, (IntPtr)offset);
        }
        /// <summary>
        /// render primitives from array data
        /// When glDrawElements is called, it uses count sequential elements from an enabled array, starting at indices to construct a sequence of geometric primitives. mode specifies what kind of primitives are constructed and how the array elements construct these primitives. If more than one array is enabled, each is used.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY and GL_PATCHES are accepted.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</param>
        /// <param name="ptr">Specifies a pointer to the location where the indices are stored.</param>
        public static void DrawElements(BeginMode mode, int count, IndicesType type, IntPtr ptr)
        {
            Delegates.glDrawElements(mode, count, type, ptr);
        }
        /// <summary>
        /// enable or disable server-side GL capabilities
        /// </summary>
        /// <param name="cap">pecifies a symbolic constant indicating a GL capability.</param>
        /// <remarks>glEnable and glDisable enable and disable various capabilities. Use glIsEnabled or glGet to determine the current setting of any capability. The initial value for each capability with the exception of GL_DITHER and GL_MULTISAMPLE is GL_FALSE. The initial value for GL_DITHER and GL_MULTISAMPLE is GL_TRUE.</remarks>
        public static void Enable(EnableState cap)
        {
            Delegates.glEnable(cap);
        }
        /// <summary>
        /// block until all GL execution is complete
        /// glFinish does not return until the effects of all previously called GL commands are complete. Such effects include all changes to GL state, all changes to connection state, and all changes to the frame buffer contents.        
        /// </summary>
        /// <remarks>glFinish requires a round trip to the server.</remarks>
        public static void Finish()
        {
            Delegates.glFinish();
        }
        /// <summary>
        /// force execution of GL commands in finite time
        /// </summary>
        /// <remarks>
        /// Different GL implementations buffer commands in several different locations, including network buffers and the graphics accelerator itself. glFlush empties all of these buffers, causing all issued commands to be executed as quickly as they are accepted by the actual rendering engine. Though this execution may not be completed in any particular time period, it does complete in finite time.
        /// Because any GL program might be executed over a network, or on an accelerator that buffers commands, all programs should call glFlush whenever they count on having all of their previously issued commands completed. For example, call glFlush before waiting for user input that depends on the generated image.
        /// glFlush can return at any time. It does not wait until the execution of all previously issued GL commands is complete.
        /// </remarks>
        public static void Flush()
        {
            Delegates.glFlush();
        }
        /// <summary>
        /// define front- and back-facing polygons
        /// </summary>
        /// <param name="mode">Specifies the orientation of front-facing polygons. GL_CW and GL_CCW are accepted. The initial value is GL_CCW.</param>
        /// <remarks>
        /// In a scene composed entirely of opaque closed surfaces, back-facing polygons are never visible. Eliminating these invisible polygons has the obvious benefit of speeding up the rendering of the image. To enable and disable elimination of back-facing polygons, call glEnable and glDisable with argument GL_CULL_FACE.
        /// The projection of a polygon to window coordinates is said to have clockwise winding if an imaginary object following the path from its first vertex, its second vertex, and so on, to its last vertex, and finally back to its first vertex, moves in a clockwise direction about the interior of the polygon. The polygon's winding is said to be counterclockwise if the imaginary object following the same path moves in a counterclockwise direction about the interior of the polygon. glFrontFace specifies whether polygons with clockwise winding in window coordinates, or counterclockwise winding in window coordinates, are taken to be front-facing. Passing GL_CCW to mode selects counterclockwise polygons as front-facing; GL_CW selects clockwise polygons as front-facing. By default, counterclockwise polygons are taken to be front-facing.
        /// </remarks>
        public static void FrontFace(FrontFaceMode mode)
        {
            Delegates.glFrontFace(mode);
        }
        /// <summary>
        /// generate texture names
        /// </summary>
        /// <param name="textures">Specifies an array in which the generated texture names are stored.</param>
        /// <remarks>
        /// glGenTextures returns n texture names in textures. There is no guarantee that the names form a contiguous set of integers; however, it is guaranteed that none of the returned names was in use immediately before the call to glGenTextures.
        /// The generated textures have no dimensionality; they assume the dimensionality of the texture target to which they are first bound (see glBindTexture).
        /// Texture names returned by a call to glGenTextures are not returned by subsequent calls, unless they are first deleted with glDeleteTextures.
        /// </remarks>
        public static void GenTexture(uint[] textures)
        {
            Delegates.glGenTextures(textures.Length, ref textures[0]);
        }
        /// <summary>
        /// generate a texture name
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// glGenTextures returns n texture names in textures. There is no guarantee that the names form a contiguous set of integers; however, it is guaranteed that none of the returned names was in use immediately before the call to glGenTextures.
        /// The generated textures have no dimensionality; they assume the dimensionality of the texture target to which they are first bound (see glBindTexture).
        /// Texture names returned by a call to glGenTextures are not returned by subsequent calls, unless they are first deleted with glDeleteTextures.
        /// </remarks>
        public static uint GenTexture()
        {
            uint tmp = 0;
            Delegates.glGenTextures(1, ref tmp);
            return tmp;
        }

        /// <summary>
        /// return the value or values of a selected parameter
        /// These four commands return values for simple state variables in GL. pname is a symbolic constant indicating the state variable to be returned, and params is a pointer to an array of the indicated type in which to place the returned data.
        /// </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the enum are accepted.</param>
        /// <param name="params">Returns the value or values of the specified parameter.</param>
        /// <remarks>Type conversion is performed if params has a different type than the state variable value being requested. If glGetBooleanv is called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). Otherwise, it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, and most floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are returned with a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most negative representable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or GL_FALSE, and integer values are converted to floating-point values.</remarks>
        public static void GetBooleanv(GetParameters pname, bool[] @params)
        {
            Delegates.glGetBooleanv(pname, ref @params[0]);
        }
        /// <summary>
        /// return the value or values of a selected parameter
        /// These four commands return values for simple state variables in GL. pname is a symbolic constant indicating the state variable to be returned, and params is a pointer to an array of the indicated type in which to place the returned data.
        /// </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the enum are accepted.</param>
        /// <param name="params">Returns the value or values of the specified parameter.</param>
        /// <remarks>Type conversion is performed if params has a different type than the state variable value being requested. If glGetBooleanv is called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). Otherwise, it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, and most floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are returned with a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most negative representable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or GL_FALSE, and integer values are converted to floating-point values.</remarks>
        public static void GetDoublev(GetParameters pname, double[] @params)
        {
            Delegates.glGetDoublev(pname, ref @params[0]);
        }        
        /// <summary>
        /// return the value or values of a selected parameter
        /// These four commands return values for simple state variables in GL. pname is a symbolic constant indicating the state variable to be returned, and params is a pointer to an array of the indicated type in which to place the returned data.
        /// </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the enum are accepted.</param>
        /// <param name="params">Returns the value or values of the specified parameter.</param>
        /// <remarks>Type conversion is performed if params has a different type than the state variable value being requested. If glGetBooleanv is called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). Otherwise, it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, and most floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are returned with a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most negative representable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or GL_FALSE, and integer values are converted to floating-point values.</remarks>
        public static void GetFloatv(GetParameters pname, float[] @params)
        {
            Delegates.glGetFloatv(pname, ref @params[0]);
        }
        /// <summary>
        /// return the value or values of a selected parameter
        /// These four commands return values for simple state variables in GL. pname is a symbolic constant indicating the state variable to be returned, and params is a pointer to an array of the indicated type in which to place the returned data.
        /// </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the enum are accepted.</param>
        /// <param name="params">Returns the value or values of the specified parameter.</param>
        /// <remarks>Type conversion is performed if params has a different type than the state variable value being requested. If glGetBooleanv is called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). Otherwise, it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, and most floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are returned with a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most negative representable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or GL_FALSE, and integer values are converted to floating-point values.</remarks>
        public static void GetIntegerv(GetParameters pname, int[] @params)
        {
            Delegates.glGetIntegerv(pname, ref @params[0]);
        }
        /// <summary>
        /// return the value or values of a selected parameter
        /// These four commands return values for simple state variables in GL. pname is a symbolic constant indicating the state variable to be returned, and params is a pointer to an array of the indicated type in which to place the returned data.
        /// </summary>
        /// <param name="pname">Specifies the parameter value to be returned. The symbolic constants in the enum are accepted.</param>
        /// <returns>Returns the value or values of the specified parameter.</returns>
        /// <remarks>Type conversion is performed if params has a different type than the state variable value being requested. If glGetBooleanv is called, a floating-point (or integer) value is converted to GL_FALSE if and only if it is 0.0 (or 0). Otherwise, it is converted to GL_TRUE. If glGetIntegerv is called, boolean values are returned as GL_TRUE or GL_FALSE, and most floating-point values are rounded to the nearest integer value. Floating-point colors and normals, however, are returned with a linear mapping that maps 1.0 to the most positive representable integer value and -1.0 to the most negative representable integer value. If glGetFloatv or glGetDoublev is called, boolean values are returned as GL_TRUE or GL_FALSE, and integer values are converted to floating-point values.</remarks>
        public static int GetIntegerv(GetParameters pname)
        {
            int tmp = 0;
            Delegates.glGetIntegerv(pname, ref tmp);
            return tmp;
        }
        /// <summary>
        /// glGetError returns the value of the error flag. Each detectable error is assigned a numeric code and symbolic name. When an error occurs, the error flag is set to the appropriate error code value. No other errors are recorded until glGetError is called, the error code is returned, and the flag is reset to GL_NO_ERROR. If a call to glGetError returns GL_NO_ERROR, there has been no detectable error since the last call to glGetError, or since the GL was initialized.
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// To allow for distributed implementations, there may be several error flags. If any single error flag has recorded an error, the value of that flag is returned and that flag is reset to GL_NO_ERROR when glGetError is called. If more than one flag has recorded an error, glGetError returns and clears an arbitrary error flag value. Thus, glGetError should always be called in a loop, until it returns GL_NO_ERROR, if all error flags are to be reset.
        /// When an error flag is set, results of a GL operation are undefined only if GL_OUT_OF_MEMORY has occurred. In all other cases, the command generating the error is ignored and has no effect on the GL state or frame buffer contents. If the generating command returns a value, it returns 0. If glGetError itself generates an error, it returns 0.
        /// </remarks>        
        public static ErrorCode GetError()
        {
            return Delegates.glGetError();
        }
        /// <summary>
        /// return a string describing the current GL connection
        /// glGetString returns a pointer to a static string describing some aspect of the current GL connection.
        /// </summary>
        /// <param name="name">Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_SHADING_LANGUAGE_VERSION. Additionally, glGetStringi accepts the GL_EXTENSIONS token.</param>
        /// <returns></returns>
        /// <remarks>
        /// Strings GL_VENDOR and GL_RENDERER together uniquely specify a platform. They do not change from release to release and should be used by platform-recognition algorithms.
        /// 
        /// The GL_VERSION and GL_SHADING_LANGUAGE_VERSION strings begin with a version number. The version number uses one of these forms:
        /// major_number.minor_number major_number.minor_number.release_number
        /// Vendor-specific information may follow the version number. Its format depends on the implementation, but a space always separates the version number and the vendor-specific information.
        /// </remarks>
        public static string GetString(StringName name)
        {
            var ptr = Delegates.glGetString(name);
            return Marshal.PtrToStringAnsi(ptr);
            //return Delegates.glGetString(name);
        }
        public static void GetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr img)
        {
            Delegates.glGetTexImage(target, level, format, type, img);
        }
        public static void GetTexLevelParameterfv(TextureTarget target, int level, TextureLevelParameters pname, float[] @params)
        {
            Delegates.glGetTexLevelParameterfv(target, level, pname, ref @params[0]);
        }
        public static void GetTexLevelParameteriv(TextureTarget target, int level, TextureLevelParameters pname, int[] @params)
        {
            Delegates.glGetTexLevelParameteriv(target, level, pname, ref @params[0]);
        }
        public static void GetTexParameteriv(TextureTarget target, TextureParameters pname, int[] @params)
        {
            Delegates.glGetTexParameteriv(target, pname, ref @params[0]);
        }
        public static int GetTexParameteriv(TextureTarget target, TextureParameters pname)
        {
            int tmp = 0;
            Delegates.glGetTexParameteriv(target, pname, ref tmp);
            return tmp;
        }
        public static void GetTexParameterfv(TextureTarget target, TextureParameters pname, float[] @params)
        {
            Delegates.glGetTexParameterfv(target, pname, ref @params[0]);
        }
        //public static void GetTexParameteriv(TextureTarget target, TexParameterName pname, int[] @params)
        //{
        //    Delegates.glGetTexParameteriv(target, pname, @params);
        //}
        //public static void GetTexParameterfv(TextureTarget target, TexParameterName pname, float[] @params)
        //{
        //    Delegates.glGetTexParameterfv(target, pname, @params);
        //}
        public static void Hint(HintTarget target, HintMode mode)
        {
            Delegates.glHint(target, mode);
        }
        public static bool IsEnabled(EnableState cap)
        {
            return Delegates.glIsEnabled(cap);
        }
        //[return: MarshalAs(UnmanagedType.Bool)]
        public static bool IsTexture(uint textureid)
        {
            return Delegates.glIsTexture(textureid);
        }
        public static void LineWidth(float width)
        {
            Delegates.glLineWidth(width);
        }
        public static void LogicOp(LogicOpEnum opcode)
        {
            Delegates.glLogicOp(opcode);
        }
        public static void PixelStorei(PixelStoreParameters pname, int param)
        {
            Delegates.glPixelStorei(pname, param);
        }
        public static void PixelStoref(PixelStoreParameters pname, float param)
        {
            Delegates.glPixelStoref(pname, param);
        }
        public static void PointSize(float size)
        {
            Delegates.glPointSize(size);
        }
        public static void PolygonMode(PolygonFace face, PolygonMode mode)
        {
            Delegates.glPolygonMode(face, mode);
        }
        public static void PolygonOffset(float factor, float units)
        {
            Delegates.glPolygonOffset(factor, units);
        }
        public static void ReadBuffer(ReadBufferMode mode)
        {
            Delegates.glReadBuffer(mode);
        }
        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr data)
        {
            Delegates.glReadPixels(x, y, width, height, format, type, data);
        }
        public static void Scissor(int x, int y, int width, int height)
        {
            Delegates.glScissor(x, y, width, height);
        }
        public static void StencilFunc(StencilFunction function, int @ref, uint mask)
        {
            Delegates.glStencilFunc(function, @ref, mask);
        }
        public static void StencilMask(uint mask)
        {
            Delegates.glStencilMask(mask);
        }
        public static void StencilOp(StencilOperation fail, StencilOperation zfail, StencilOperation zpass)
        {
            Delegates.glStencilOp(fail, zfail, zpass);
        }
        public static void TexImage1D(TextureTarget target, int level, PixelInternalFormat piformat, int width, PixelFormat format, PixelType type, IntPtr data)
        {
            Delegates.glTexImage1D(target, level, piformat, width, 0, format, type, data);
        }
        public static void TexImage2D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, PixelFormat format, PixelType type, IntPtr data)
        {
            Delegates.glTexImage2D(target, level, piformat, width, height, 0, format, type, data);
        }
        public static void TexParameteri(TextureTarget target, TextureParameters pname, int param)
        {
            Delegates.glTexParameteri(target, pname, param);
        }
        public static void TexParameteriv(TextureTarget target, TextureParameters pname, int[] param)
        {
            Delegates.glTexParameteriv(target, pname, @param);
        }
        //public static void TexParameterIiv(TextureTarget target, TexParameterName pname, int[] param)
        //{
        //    Delegates.glTexParameterIiv(target, pname, @param);
        //}
        public static void TexParameterf(TextureTarget target, TextureParameters pname, float param)
        {
            Delegates.glTexParameterf(target, pname, @param);
        }
        public static void TexParameterfv(TextureTarget target, TextureParameters pname, float[] param)
        {
            Delegates.glTexParameterfv(target, pname, @param);
        }
        //public static void TexParameterIfv(TextureTarget target, TexParameterName pname, float[] param)
        //{
        //    Delegates.glTexParameterIfv(target, pname, @param);
        //}
        public static void TexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr data)
        {
            Delegates.glTexSubImage1D(target, level, xoffset, width, format, type, data);
        }
        public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr data)
        {
            Delegates.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, data);
        }
        public static void Viewport(int x, int y, int width, int height)
        {
            Delegates.glViewport(x, y, width, height);
        }


        #endregion
    }
}
