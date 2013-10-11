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
    /// When colors are written to the frame buffer, they are written into the color buffers specified by glDrawBuffer. The specifications are as follows:
    /// </summary>
    public enum DrawBufferTarget
    {
        /// <summary>
        /// No color buffers are written.
        /// </summary>
        None = All.NONE,

        /// <summary>
        /// Only the front left color buffer is written.
        /// </summary>
        FrontLeft = All.FRONT_LEFT,
        /// <summary>
        /// Only the front right color buffer is written.
        /// </summary>
        FrontRight = All.FRONT_RIGHT,
        /// <summary>
        /// Only the back left color buffer is written.
        /// </summary>
        BackLeft = All.BACK_LEFT,
        /// <summary>
        /// Only the back right color buffer is written.
        /// </summary>
        BackRight = All.BACK_RIGHT,
        /// <summary>
        /// Only the front left and front right color buffers are written. If there is no front right color buffer, only the front left color buffer is written.
        /// </summary>
        Front = All.FRONT,
        /// <summary>
        /// Only the back left and back right color buffers are written. If there is no back right color buffer, only the back left color buffer is written.
        /// </summary>
        Back = All.BACK,
        /// <summary>
        /// Only the front left and back left color buffers are written. If there is no back left color buffer, only the front left color buffer is written.
        /// </summary>
        Left = All.LEFT,
        /// <summary>
        /// Only the front right and back right color buffers are written. If there is no back right color buffer, only the front right color buffer is written.
        /// </summary>
        Right = All.RIGHT,
        /// <summary>
        /// All the front and back color buffers (front left, front right, back left, back right) are written. If there are no back color buffers, only the front left and front right color buffers are written. If there are no right color buffers, only the front left and back left color buffers are written. If there are no right or back color buffers, only the front left color buffer is written.
        /// </summary>
        FrontAndBack = All.FRONT_AND_BACK,

    }
}
