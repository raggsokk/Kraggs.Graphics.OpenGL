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
    /// <summary>
    /// The following errors are currently defined:
    /// Copyright © 1991-2006 Silicon Graphics, Inc. Copyright © 2010 Khronos Group. This document is licensed under the SGI Free Software B License. For details, see http://oss.sgi.com/projects/FreeB/.
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// No error has been recorded. The value of this symbolic constant is guaranteed to be 0.
        /// </summary>
        NoError = All.NO_ERROR,
        /// <summary>
        /// An unacceptable value is specified for an enumerated argument. The offending command is ignored and has no other side effect than to set the error flag.
        /// </summary>
        InvalidEnum = All.INVALID_ENUM,
        /// <summary>
        /// A numeric argument is out of range. The offending command is ignored and has no other side effect than to set the error flag.
        /// </summary>
        InvalidValue = All.INVALID_VALUE,
        /// <summary>
        /// The specified operation is not allowed in the current state. The offending command is ignored and has no other side effect than to set the error flag.
        /// </summary>
        InvalidOperation = All.INVALID_OPERATION,
        /// <summary>
        /// The framebuffer object is not complete. The offending command is ignored and has no other side effect than to set the error flag.
        /// </summary>
        InvalidFramebufferOperation = All.INVALID_FRAMEBUFFER_OPERATION,
        /// <summary>
        /// There is not enough memory left to execute the command. The state of the GL is undefined, except for the state of the error flags, after this error is recorded.
        /// </summary>
        OutOfMemory = All.OUT_OF_MEMORY,
        /// <summary>
        /// An attempt has been made to perform an operation that would cause an internal stack to underflow.
        /// </summary>
        StackUnderflow = All.STACK_UNDERFLOW,
        /// <summary>
        /// An attempt has been made to perform an operation that would cause an internal stack to overflow.
        /// </summary>
        StackOverflow = All.STACK_OVERFLOW,
    }
}
