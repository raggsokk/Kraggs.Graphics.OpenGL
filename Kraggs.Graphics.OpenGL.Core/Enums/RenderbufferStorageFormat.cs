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
    public enum RenderbufferStorageFormat
    {
        Red = All.RED,
        RG = All.RG,
        RGB = All.RGB,
        RGBA = All.RGBA,
        RGBA_Int = All.RGBA_INTEGER,
        StencilIndex = All.STENCIL_INDEX,
        DepthComponent = All.DEPTH_COMPONENT,
        DepthStencil = All.DEPTH_STENCIL,

        // sized internal format

        RGBA32Float = All.RGBA32F,

        Depth16 = All.DEPTH_COMPONENT16,
        Depth24 = All.DEPTH_COMPONENT24,
        Depth32 = All.DEPTH_COMPONENT32,
        Depth24Stencil8 = All.DEPTH24_STENCIL8,
        Depth32F = All.DEPTH_COMPONENT32F,
        Depth32FStencil8 = All.DEPTH32F_STENCIL8,

        Stencil1 = All.STENCIL_INDEX1,
        Stencil4 = All.STENCIL_INDEX4,
        Stencil8 = All.STENCIL_INDEX8,
        Stencil16 = All.STENCIL_INDEX16,
    }
}
