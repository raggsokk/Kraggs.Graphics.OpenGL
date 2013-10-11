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
    public enum PixelType
    {
        UByte = All.UNSIGNED_BYTE,
        Byte = All.BYTE,
        UShort = All.UNSIGNED_SHORT,
        Short = All.SHORT,
        UInt = All.UNSIGNED_INT,
        Int = All.INT,
        Float = All.FLOAT,
        HalfFloat = All.HALF_FLOAT,
        Float32UnsignedUnt238Reverse = All.FLOAT_32_UNSIGNED_INT_24_8_REV,

        UByte332 = All.UNSIGNED_BYTE_3_3_2,
        UByte233Reversed = All.UNSIGNED_BYTE_2_3_3_REV,
        UShort565 = All.UNSIGNED_SHORT_5_6_5,
        UShort565Reversed = All.UNSIGNED_SHORT_5_6_5_REV,
        UShort4444 = All.UNSIGNED_SHORT_4_4_4_4,
        UShort4444Reversed = All.UNSIGNED_SHORT_4_4_4_4_REV,
        UShort5551 = All.UNSIGNED_SHORT_5_5_5_1,
        UShort1555Reversed = All.UNSIGNED_SHORT_1_5_5_5_REV,
        UInt8888 = All.UNSIGNED_INT_8_8_8_8,
        UInt8888Reversed = All.UNSIGNED_INT_8_8_8_8_REV,
        UInt1010102 = All.UNSIGNED_INT_10_10_10_2,
        UInt2101010Reversed = All.UNSIGNED_INT_2_10_10_10_REV,

        UInt248 = All.UNSIGNED_INT_24_8,
        UInt10F11F11FReversed = All.UNSIGNED_INT_10F_11F_11F_REV,
        UInt5999Reversed = All.UNSIGNED_INT_5_9_9_9_REV,
        Float32Uint248Reversed = All.FLOAT_32_UNSIGNED_INT_24_8_REV,
    }
}
