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

        [EntryPointSlot(29)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMaxShaderCompilerThreadsARB(uint count);

        #endregion

        #region Public functions

        /// <summary>
        /// Application may use the following to hint to the driver the maximum number background threads it would like to be used in the process of compiling shaders or linking programs
        /// </summary>
        /// <param name="count">A [count] of zero specifies a request for no parallel compiling or linking and a[count] of 0xFFFFFFFF requests an implementation-specific maximum.</param>
        /// <remarks>
        /// An implementation may combine the maximum compiler thread request from multiple contexts in a share group in an implementation-specific way.
        /// An application can query the current MaxShaderCompilerThreads() [count] by calling GetIntegerv with [pname] set to MAX_SHADER_COMPILER_THREADS.
        /// </remarks>
        [EntryPoint(FunctionName = "glMaxShaderCompilerThreadsARB")]
        public static void MaxShaderCompilerThreadsARB(uint count) { throw new NotImplementedException(); }

        #endregion

        #region Public Helper Functions

        #endregion
    }
}
