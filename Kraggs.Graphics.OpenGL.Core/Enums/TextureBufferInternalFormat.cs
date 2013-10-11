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
    public enum TextureBufferInternalFormat
    {
        R8_Int = All.R8I,
        R8_UInt = All.R8UI,

        R16_Int = All.R16I,
        R16_UInt = All.R16UI,
        R16_Float = All.R16F,

        R32_Int = All.R32I,
        R32_UInt = All.R32UI,
        R32_Float = All.R32F,

        RG8_Int = All.RG8I,
        RG8_UInt = All.RG8UI,

        RG16_Int = All.RG16I,
        RG16_UInt = All.RG16UI,
        RG16_Float = All.RG16F,

        RG32_Int = All.RG32I,
        RG32_UInt = All.RG32UI,
        RG32_Float = All.RG32F,

        RGB8_Int = All.RGB8I,
        RGB8_UInt = All.RGB8UI,

        RGB32_Int = All.RGB32I,
        RGB32_UInt = All.RGB32UI,
        RGB32_Float = All.RGB32F,

        RGBA8_Int = All.RGBA8I,
        RGBA8_UInt = All.RGBA8UI,

        RGBA16_Int = All.RGBA16I,
        RGBA16_UInt = All.RGBA16UI,
        RGBA16_Float = All.RGBA16F,

        RGBA32_Int = All.RGBA32I,
        RGBA32_UInt = All.RGBA32UI,
        RGBA32_Float = All.RGBA32F,
    }
}
