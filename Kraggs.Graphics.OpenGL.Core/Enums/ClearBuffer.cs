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
    /// Used by ClearBuffer[f,i,ui,fi] to clear buffer.
    /// </summary>
    public enum ClearBuffer
    {
        /// <summary>
        /// If buffer is COLOR, a particular draw buffer DRAW_BUFFERi is specified by passing i as the parameter drawbuffer, and value points to a four-element vector specifying the R, G, B, and A color to clear that draw buffer to. 
        /// </summary>
        Color = All.COLOR,
        /// <summary>
        /// Only ClearBufferfv should be used to clear depth buffers.
        /// If buffer is DEPTH, drawbuffer must be zero, and value points to the single depth value to clear the depth buffer to.
        /// </summary>
        Depth = All.DEPTH,
        /// <summary>
        /// Only ClearBufferiv should be used to clear stencil buffers.
        /// If buffer is STENCIL, drawbuffer must be zero, and value points to the single stencil value to clear the stencil buffer to.
        /// </summary>
        Stencil = All.STENCIL,
        /// <summary>
        /// ClearBufferfi buffer must be DEPTH_STENCIL and drawbuffer must be zero. depth and sten-cil are the values to clear the depth and stencil buffers to.
        /// </summary>
        DepthStencil = All.DEPTH_STENCIL,
    }
}
