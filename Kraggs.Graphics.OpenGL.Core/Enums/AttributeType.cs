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
    public enum AttributeType
    {
        Float = All.FLOAT,
        Double = All.DOUBLE,
        Int = All.INT,
        UInt = All.UNSIGNED_INT,
        //Bool = All.BOOL,

        Vec2f = All.FLOAT_VEC2,
        Vec3f = All.FLOAT_VEC3,
        Vec4f = All.FLOAT_VEC4,

        Vec2d = All.DOUBLE_VEC2,
        Vec3d = All.DOUBLE_VEC3,
        Vec4d = All.DOUBLE_VEC4,

        Vec2i = All.INT_VEC2,
        Vec3i = All.INT_VEC3,
        Vec4i = All.INT_VEC4,

        Vec2ui = All.UNSIGNED_INT_VEC2,
        Vec3ui = All.UNSIGNED_INT_VEC3,
        Vec4ui = All.UNSIGNED_INT_VEC4,

        //Vec2b = All.BOOL_VEC2,
        //Vec3b = All.BOOL_VEC3,
        //Vec4b = All.BOOL_VEC4,

        Mat2d = All.DOUBLE_MAT2,
        Mat2x3d = All.DOUBLE_MAT2x3,
        Mat2x4d = All.DOUBLE_MAT2x4,

        Mat3d = All.DOUBLE_MAT3,
        Mat3x2 = All.DOUBLE_MAT3x2,
        Mat3x4 = All.DOUBLE_MAT3x4,

        Mat4d = All.DOUBLE_MAT4,
        Mat4x2d = All.DOUBLE_MAT4x2,
        Mat4x3d = All.DOUBLE_MAT4x3,

        Mat2f = All.FLOAT_MAT2,
        Mat2x3f = All.FLOAT_MAT2x3,
        Mat2x4f = All.FLOAT_MAT2x4,

        Mat3f = All.FLOAT_MAT3,
        Mat3x2f = All.FLOAT_MAT3x2,
        Mat3x4f = All.FLOAT_MAT3x4,

        Mat4f = All.FLOAT_MAT4,
        Mat4x2f = All.FLOAT_MAT4x2,
        Mat4x3f = All.FLOAT_MAT4x3,

    }
}
