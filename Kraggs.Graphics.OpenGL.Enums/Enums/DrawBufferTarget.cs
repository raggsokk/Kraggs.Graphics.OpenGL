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
    /// When colors are written to the frame buffer, they are written into the color buffers specified by DrawBuffer,DrawBuffers.
    /// DrawBufferTarget is used by DrawBuffer,DrawBuffers and ReadBuffer but has very specific valid values
    /// depenedent on wether default framebuffer is bound or a framebuffer object is bound.
    /// DRAW_BUFFERSi is used by GetInteger to find out what is bound.
    /// </summary>
    public enum DrawBufferTarget
    {
        /// <summary>
        /// No color buffers are written.
        /// Disables a binding, valid in all cases.
        /// </summary>
        None = All.NONE,

        #region Default Framebuffer valid targets

        /// <summary>
        /// Only the front left color buffer is written/read
        /// Default framebuffer bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        FrontLeft = All.FRONT_LEFT,
        /// <summary>
        /// Only the front right color buffer is written/read.
        /// Default framebuffer bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        FrontRight = All.FRONT_RIGHT,
        /// <summary>
        /// Only the back left color buffer is written/read.
        /// Default framebuffer bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        BackLeft = All.BACK_LEFT,
        /// <summary>
        /// Only the back right color buffer is written/read.
        /// Default framebuffer bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        BackRight = All.BACK_RIGHT,
        /// <summary>
        /// Only the front left and front right color buffers are written/read. If there is no front right color buffer, only the front left color buffer is written/read.
        /// Default framebuffer bound, accepted by DrawBuffer and ReadBuffer ONLY!
        /// </summary>
        Front = All.FRONT,
        /// <summary>
        /// Only the back left and back right color buffers are written/read. If there is no back right color buffer, only the back left color buffer is written/read.
        /// Default framebuffer bound, accepted by DrawBuffer and ReadBuffer ONLY!
        /// </summary>
        Back = All.BACK,
        /// <summary>
        /// Only the front left and back left color buffers are written/read. If there is no back left color buffer, only the front left color buffer is written/read.
        /// Default framebuffer bound, accepted by DrawBuffer and ReadBuffer ONLY!
        /// </summary>
        Left = All.LEFT,
        /// <summary>
        /// Only the front right and back right color buffers are written/read. If there is no back right color buffer, only the front right color buffer is written/read.
        /// Default framebuffer bound, accepted by DrawBuffer and ReadBuffer ONLY!
        /// </summary>
        Right = All.RIGHT,
        /// <summary>
        /// All the front and back color buffers (front left, front right, back left, back right) are written. If there are no back color buffers, only the front left and front right color buffers are written. If there are no right color buffers, only the front left and back left color buffers are written. If there are no right or back color buffers, only the front left color buffer is written.
        /// Default framebuffer bound, accepted by DrawBuffer and ReadBuffer ONLY!
        /// </summary>
        FrontAndBack = All.FRONT_AND_BACK,

        #endregion

        #region FramebufferObject valid targets

        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment0 = All.COLOR_ATTACHMENT0,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment1 = All.COLOR_ATTACHMENT1,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment2 = All.COLOR_ATTACHMENT2,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment3 = All.COLOR_ATTACHMENT3,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment4 = All.COLOR_ATTACHMENT4,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment5 = All.COLOR_ATTACHMENT5,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment6 = All.COLOR_ATTACHMENT6,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment7 = All.COLOR_ATTACHMENT7,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment8 = All.COLOR_ATTACHMENT8,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment9 = All.COLOR_ATTACHMENT9,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment10 = All.COLOR_ATTACHMENT10,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment11 = All.COLOR_ATTACHMENT11,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment12 = All.COLOR_ATTACHMENT12,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment13 = All.COLOR_ATTACHMENT13,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment14 = All.COLOR_ATTACHMENT14,
        /// <summary>
        /// Framebuffer object bound, accepted by DrawBuffer,DrawBuffers and ReadBuffer
        /// </summary>
        ColorAttachment15 = All.COLOR_ATTACHMENT15,

        #endregion
    }
}
