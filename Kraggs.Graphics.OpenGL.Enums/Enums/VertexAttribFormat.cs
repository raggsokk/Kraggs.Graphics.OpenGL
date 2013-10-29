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
    public enum VertexAttribFormat
    {
        Byte = All.BYTE,
        UByte = All.UNSIGNED_BYTE,
        Short = All.SHORT,
        UShort = All.UNSIGNED_SHORT,
        Int = All.INT,
        UInt = All.UNSIGNED_INT,
        Half = All.HALF_FLOAT,
        Float = All.FLOAT,
        Double = All.DOUBLE,
        Fixed = All.FIXED,

        Int_2_10_10_10_Rev = All.INT_2_10_10_10_REV,
        UInt_2_10_10_10_Rev = All.UNSIGNED_INT_2_10_10_10_REV,
        UInt_10F_11F_11F_Rev = All.UNSIGNED_INT_10F_11F_11F_REV,

        //ARB_vertex_array_bgra or GL 3.2

    }
}
