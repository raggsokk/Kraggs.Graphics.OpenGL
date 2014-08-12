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

        [EntryPointSlot(31)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBufferPageCommitmentARB(BufferTarget target, IntPtr offset, IntPtr size, bool commit);

        [EntryPointSlot(32)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedBufferPageCommitmentARB(uint buffer, IntPtr offset, IntPtr size, bool commit);

        #endregion

        #region Public functions

        [EntryPoint(FunctionName = "glBufferPageCommitmentARB")]
        public static void BufferPageCommitmentARB(BufferTarget target, IntPtr offset, IntPtr size, bool commit) { throw new NotImplementedException(); }
        
        public static void BufferPageCommitmentARB(BufferTarget target, long offset, long size, bool commit)
        {
            BufferPageCommitmentARB(target, offset, size, commit);
        }

        [EntryPoint(FunctionName = "glNamedBufferPageCommitmentARB")]
        public static void NamedBufferPageCommitmentARB(uint buffer, IntPtr offset, IntPtr size, bool commit) { throw new NotImplementedException(); }

        public static void NamedBufferPageCommitmentARB(uint buffer, long offset, long size, bool commit)
        {
            NamedBufferPageCommitmentARB(buffer, offset, size, commit);
        }

        #endregion

        #region Public Helper Functions

        #endregion
    }
}
