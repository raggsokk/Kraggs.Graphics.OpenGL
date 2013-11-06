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
    // template class until gl 4.4 where its not neede for another year.
    partial class GL
    {
        #region Delegate Class

        partial class Delegates
        {

            #region Delegates

            // EXT_blend_color
            public delegate void delBlendColor(float red, float green, float blue, float alpha);
            // EXT_blend_minmax
            public delegate void delBlendEquation(BlendEquationMode mode);
            // EXT_multi_draw_arrays
            public delegate void delMultiDrawArrays(BeginMode mode, int first, int count, int drawcount);
            public delegate void delMultiDrawElements(BeginMode mode, int count, IndicesType type, IntPtr indices, int drawCount);
            // ARB_point_parameters
            public delegate void delPointParameteri(PointParameters pname, int param);
            public delegate void delPointParameterf(PointParameters pname, float param);

            public delegate void delPointParameterfv(PointParameters pname, float[] values);
            public delegate void delPointParameteriv(PointParameters pname, int[] values);
            // EXT_blend_func_separate
            public delegate void delBlendFuncSeparate(BlendFactorSrc sfactorRGB, BlendFactorDst dfactorRGB, BlendFactorSrc sfactorAlpha, BlendFactorDst dfactorAlpha);


            public delegate void delStencilFuncSeparate(CullMode face, StencilFunction func, int @ref, uint mask);
            public delegate void delStencilMaskSeparate(CullMode face, uint mask);
            public delegate void delStencilOpSeparate(CullMode face, StencilOperation StencilFails, StencilOperation DepthFails,StencilOperation StencilPasses);

            #endregion

            #region GL Fields

            public static delBlendColor glBlendColor;
            public static delBlendEquation glBlendEquation;
            public static delMultiDrawArrays glMultiDrawArrays;
            public static delMultiDrawElements glMultiDrawElements;
            public static delPointParameteri glPointParameteri;
            public static delPointParameterfv glPointParameterfv;
            public static delPointParameterf glPointParameterf;
            public static delPointParameteriv glPointParameteriv;
            public static delBlendFuncSeparate glBlendFuncSeparate;

            public static delStencilFuncSeparate glStencilFuncSeparate;
            public static delStencilMaskSeparate glStencilMaskSeparate;
            public static delStencilOpSeparate glStencilOpSeparate;

            #endregion
        }

        #endregion

        #region Public functions.

        public static void BlendColor(float red, float green, float blue, float alpha)
        {
            Delegates.glBlendColor(red, green, blue, alpha);
        }
        public static void BlendEquation(BlendEquationMode mode)
        {
            Delegates.glBlendEquation(mode);
        }
        public static void MultiDrawArrays(BeginMode mode, int first, int count, int drawcount)
        {
            Delegates.glMultiDrawArrays(mode, first, count, drawcount);
        }

        public static void MultiDrawElements(BeginMode mode, int count, IndicesType type, IntPtr indices, int drawCount)
        {
            Delegates.glMultiDrawElements(mode, count, type, indices, drawCount);
        }
        public static void PointParameteri(PointParameters pname, int param)
        {
            Delegates.glPointParameteri(pname, @param);
        }
        public static void PointParameterf(PointParameters pname, float param)
        {
            Delegates.glPointParameterf(pname, @param);
        }
        public static void PointParameterfv(PointParameters pname, float[] values)
        {
            Delegates.glPointParameterfv(pname, values);
        }
        public static void PointParameteriv(PointParameters pname, int[] values)
        {
            Delegates.glPointParameteriv(pname, values);
        }
        public static void BlendFuncSeparate(BlendFactorSrc sfactorRGB, BlendFactorDst dfactorRGB, BlendFactorSrc sfactorAlpha, BlendFactorDst dfactorAlpha)
        {
            Delegates.glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        }

        public static void StencilFuncSeparate(CullMode face, StencilFunction func, int @ref, uint mask)
        {
            Delegates.glStencilFuncSeparate(face, func, @ref, mask);
        }

        public static void StencilMaskSeparate(CullMode face, uint mask)
        {
            Delegates.glStencilMaskSeparate(face, mask);
        }
        public static void StencilOpSeparate(CullMode face, StencilOperation StencilFails, StencilOperation DepthFails, StencilOperation StencilPasses)
        {
            Delegates.glStencilOpSeparate(face, StencilFails, DepthFails, StencilPasses);
        }

        #endregion
    }
}
