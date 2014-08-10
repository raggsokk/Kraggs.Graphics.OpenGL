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
    partial class NV
    {
        #region OpenGL DLLImports

        [EntryPointSlot(20)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCopyImageSubDataNV(uint srcName, CopyImageTargetNV srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageTargetNV dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth);

        #endregion

        #region Public functions

        [EntryPoint(FunctionName = "glCopyImageSubDataNV")]        
        public static void CopyImageSubDataNV(uint srcName, CopyImageTargetNV srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, CopyImageTargetNV dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int width, int height, int depth) { throw new NotImplementedException(); }

        #endregion

        #region Public Helper Functions

        #endregion
    }
}
