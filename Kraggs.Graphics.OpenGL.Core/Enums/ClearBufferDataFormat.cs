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
    public enum ClearBufferDataFormat
    {
        Red = All.RED,
        Green = All.GREEN,
        Blue = All.BLUE,
        RG = All.RG,
        RGB = All.RGB,
        RGBA = All.RGBA,
        BGR = All.BGR,
        BGRA = All.BGRA,
        Red_Int = All.RED_INTEGER,
        Green_Int = All.GREEN_INTEGER,
        Blue_Int = All.BLUE_INTEGER,
        RG_Int = All.RG_INTEGER,
        RGB_Int = All.RGB_INTEGER,
        RGBA_Int = All.RGBA_INTEGER,
        BGR_Int = All.BGR_INTEGER,
        BGRA_Int = All.BGRA_INTEGER,
        StencilIndex = All.STENCIL_INDEX,
        DepthComponent = All.DEPTH_COMPONENT,
        DepthStencil = All.DEPTH_STENCIL,
    }
}
