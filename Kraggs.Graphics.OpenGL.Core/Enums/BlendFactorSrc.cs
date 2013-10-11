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
    public enum BlendFactorSrc
    {
        Zero = All.ZERO,
        One = All.ONE,
        SrcColor = All.SRC_COLOR,
        OneMinusSrcColor = All.ONE_MINUS_SRC_COLOR,
        DstColor = All.DST_COLOR,
        OneMinusDstColor = All.ONE_MINUS_DST_COLOR,
        SrcAlpha = All.SRC_ALPHA,
        OneMinusSrcAlpha = All.ONE_MINUS_SRC_ALPHA,
        DstAlpha = All.DST_ALPHA,
        OneMinusDstAlpha = All.ONE_MINUS_DST_ALPHA,
        ConstantColor,
        OneMinusConstantColor, // = All.one
        ConstantAlpha,
        OneMinusConstantAlpha,
        SrcAlphaSaturate = All.SRC_ALPHA_SATURATE,
        Src1Color = All.SRC1_COLOR,
        OneMinusSrc1Color = All.ONE_MINUS_SRC1_COLOR,
        Src1Alpha = All.SRC1_ALPHA,
        OneMinusSrc1Alpha = All.ONE_MINUS_SRC1_ALPHA,
    }
}
