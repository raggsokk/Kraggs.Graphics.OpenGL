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
        #region OpenGL DLLImports

        // EXT_blend_color
        [EntryPointSlot(73)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBlendColor(float red, float green, float blue, float alpha);
        // EXT_blend_minmax
        [EntryPointSlot(74)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBlendEquation(BlendEquationMode mode);
        // EXT_multi_draw_arrays
        [EntryPointSlot(75)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMultiDrawArrays(BeginMode mode, int first, int count, int drawcount);
        [EntryPointSlot(76)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMultiDrawElements(BeginMode mode, int count, IndicesType type, IntPtr indices, int drawCount);
        // ARB_point_parameters
        [EntryPointSlot(77)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glPointParameteri(PointParameters pname, int param);
        [EntryPointSlot(78)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glPointParameterf(PointParameters pname, float param);

        [EntryPointSlot(79)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glPointParameterfv(PointParameters pname, float* values);
        [EntryPointSlot(80)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glPointParameteriv(PointParameters pname, int* values);
        // EXT_blend_func_separate
        [EntryPointSlot(81)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBlendFuncSeparate(BlendFactorSrc sfactorRGB, BlendFactorDst dfactorRGB, BlendFactorSrc sfactorAlpha, BlendFactorDst dfactorAlpha);

        [EntryPointSlot(82)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glStencilFuncSeparate(CullMode face, StencilFunction func, int @ref, uint mask);
        [EntryPointSlot(83)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glStencilMaskSeparate(CullMode face, uint mask);
        [EntryPointSlot(84)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glStencilOpSeparate(CullMode face, StencilOperation StencilFails, StencilOperation DepthFails, StencilOperation StencilPasses);


        #endregion

        #region Public functions

        // EXT_blend_color
        [EntryPoint(FunctionName = "glBlendColor")]
        public static void BlendColor(float red, float green, float blue, float alpha){ throw new NotImplementedException(); }
        // EXT_blend_minmax
        [EntryPoint(FunctionName = "glBlendEquation")]
        public static void BlendEquation(BlendEquationMode mode){ throw new NotImplementedException(); }
        // EXT_multi_draw_arrays
        [EntryPoint(FunctionName = "glMultiDrawArrays")]
        public static void MultiDrawArrays(BeginMode mode, int first, int count, int drawcount){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glMultiDrawElements")]
        public static void MultiDrawElements(BeginMode mode, int count, IndicesType type, IntPtr indices, int drawCount){ throw new NotImplementedException(); }
        // ARB_point_parameters
        [EntryPoint(FunctionName = "glPointParameteri")]
        public static void PointParameteri(PointParameters pname, int param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glPointParameterf")]
        public static void PointParameterf(PointParameters pname, float param){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glPointParameterfv")]
        unsafe public static void PointParameterfv(PointParameters pname, float* values) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glPointParameterfv")]
        public static void PointParameterfv(PointParameters pname, float[] values){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glPointParameteriv")]
        unsafe public static void PointParameteriv(PointParameters pname, int* values) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glPointParameteriv")]
        public static void PointParameteriv(PointParameters pname, int[] values){ throw new NotImplementedException(); }
        // EXT_blend_func_separate
        [EntryPoint(FunctionName = "glBlendFuncSeparate")]
        public static void BlendFuncSeparate(BlendFactorSrc sfactorRGB, BlendFactorDst dfactorRGB, BlendFactorSrc sfactorAlpha, BlendFactorDst dfactorAlpha){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glStencilFuncSeparate")]
        public static void StencilFuncSeparate(CullMode face, StencilFunction func, int @ref, uint mask){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glStencilMaskSeparate")]
        public static void StencilMaskSeparate(CullMode face, uint mask){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glStencilOpSeparate")]
        public static void StencilOpSeparate(CullMode face, StencilOperation StencilFails, StencilOperation DepthFails, StencilOperation StencilPasses){ throw new NotImplementedException(); }


        #endregion

        #region Public Helper Functions

        #endregion

    }
}
