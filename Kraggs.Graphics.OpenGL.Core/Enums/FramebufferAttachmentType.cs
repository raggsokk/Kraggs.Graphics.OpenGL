﻿#region License

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
    public enum FramebufferAttachmentType
    {
        //Depth = All.DEPTH,
        //FrontLeft = All.FRONT_LEFT,
        //FrontRight = All.FRONT_RIGHT,
        //Stencil = All.STENCIL,
        //BackLeft = All.BACK_LEFT,
        //BackRight = All.BACK_RIGHT,

        DepthAttachment = All.DEPTH_ATTACHMENT,
        StencilAttachment = All.STENCIL_ATTACHMENT,
        DepthStencilAttachment = All.DEPTH_STENCIL_ATTACHMENT,
        ColorAttachment0 = All.COLOR_ATTACHMENT0,
        ColorAttachment1 = All.COLOR_ATTACHMENT1,
        ColorAttachment2 = All.COLOR_ATTACHMENT2,
        ColorAttachment3 = All.COLOR_ATTACHMENT3,
        ColorAttachment4 = All.COLOR_ATTACHMENT4,
        ColorAttachment5 = All.COLOR_ATTACHMENT5,
        ColorAttachment6 = All.COLOR_ATTACHMENT6,
        ColorAttachment7 = All.COLOR_ATTACHMENT7,
        ColorAttachment8 = All.COLOR_ATTACHMENT8,
        ColorAttachment9 = All.COLOR_ATTACHMENT9,
        ColorAttachment10 = All.COLOR_ATTACHMENT10,
        ColorAttachment11 = All.COLOR_ATTACHMENT11,
        ColorAttachment12 = All.COLOR_ATTACHMENT12,
        ColorAttachment13 = All.COLOR_ATTACHMENT13,
        ColorAttachment14 = All.COLOR_ATTACHMENT14,
        ColorAttachment15 = All.COLOR_ATTACHMENT15,
    }
}
