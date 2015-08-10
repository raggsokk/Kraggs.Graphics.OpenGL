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
    partial class ARB
    {
        #region OpenGL DLLImports

        [EntryPointSlot(26)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferSampleLocationsfvARB(FramebufferTarget target, uint start, int count, ref float v);

        [EntryPointSlot(27)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, int count, ref float v);

        [EntryPointSlot(28)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glEvaluateDepthValuesARB();

        #endregion

        #region Public functions

        [EntryPoint(FunctionName = "glFramebufferSampleLocationsfvARB")]
        public static void FramebufferSampleLocationsfvARB(FramebufferTarget target, uint start, int count, ref float v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glNamedFramebufferSampleLocationsfvARB")]
        public static void NamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, int count, ref float v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glEvaluateDepthValuesARB")]
        public static void EvaluateDepthValuesARB() { throw new NotImplementedException(); }


        #endregion

        #region Public Helper Functions

        //public static void FramebufferSampleLocationsfvARB(FramebufferTarget target, uint start, long count, ref float v)
        //{
        //    FramebufferSampleLocationsfvARB(target, start, (IntPtr)count, ref v);
        //}

        //public static void NamedFramebufferSampleLocationsfvARB(uint framebuffer, uint start, long count, ref float v)
        //{
        //    NamedFramebufferSampleLocationsfvARB(framebuffer, start, (IntPtr)count, ref v);
        //}

        #endregion

    }
}
