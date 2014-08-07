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
    /// OpenGL Pixel Data Type Format Enumeration.
    /// </summary>
    public enum PixelType
    {
                TYPE_NONE               = 0,
        TYPE_I8                 = 0x1400,
        /// <summary>
        /// GL_UNSIGNED_BYTE
        /// </summary>
        TYPE_U8                 = 0x1401,	    //GL_UNSIGNED_BYTE
        TYPE_I16                = 0x1402,		//GL_SHORT
        TYPE_U16                = 0x1403,		//GL_UNSIGNED_SHORT
        TYPE_I32                = 0x1404,		//GL_INT
        TYPE_U32                = 0x1405,		//GL_UNSIGNED_INT
        TYPE_F16                = 0x140B,		//GL_HALF_FLOAT
        TYPE_F32                = 0x1406,		//GL_FLOAT
        TYPE_UINT32_RGB9_E5     = 0x8C3E,		//GL_UNSIGNED_INT_5_9_9_9_REV
        TYPE_UINT32_RG11B10F    = 0x8C3B,		//GL_UNSIGNED_INT_10F_11F_11F_REV
        TYPE_UINT8_RG3B2        = 0x8032,		//GL_UNSIGNED_BYTE_3_3_2
        TYPE_UINT8_RG3B2_REV    = 0x8362,		//GL_UNSIGNED_BYTE_2_3_3_REV
        TYPE_UINT16_RGB5A1      = 0x8034,		//GL_UNSIGNED_SHORT_5_5_5_1
        TYPE_UINT16_RGB5A1_REV  = 0x8366,	    //GL_UNSIGNED_SHORT_1_5_5_5_REV
        TYPE_UINT16_R5G6B5      = 0x8363,		//GL_UNSIGNED_SHORT_5_6_5
        TYPE_UINT16_R5G6B5_REV  = 0x8364,	    //GL_UNSIGNED_SHORT_5_6_5_REV
        TYPE_UINT16_RGBA4       = 0x8033,		//GL_UNSIGNED_SHORT_4_4_4_4
        TYPE_UINT16_RGBA4_REV   = 0x8365,		//GL_UNSIGNED_SHORT_4_4_4_4_REV
        TYPE_UINT32_RGB10A2     = 0x8036,		//GL_UNSIGNED_INT_10_10_10_2
        TYPE_UINT32_RGB10A2_REV = 0x8368,	    //GL_UNSIGNED_INT_2_10_10_10_REV

        TYPE_UINT32_RGBA8       = All.UNSIGNED_INT_8_8_8_8,
        TYPE_UINT32_RGBA8_REV   = All.UNSIGNED_INT_8_8_8_8_REV,

        //UByte = All.UNSIGNED_BYTE,
        //Byte = All.BYTE,
        //UShort = All.UNSIGNED_SHORT,
        //Short = All.SHORT,
        //UInt = All.UNSIGNED_INT,
        //Int = All.INT,
        //Float = All.FLOAT,
        //HalfFloat = All.HALF_FLOAT,
        //Float32UnsignedUnt238Reverse = All.FLOAT_32_UNSIGNED_INT_24_8_REV,

        //UByte332 = All.UNSIGNED_BYTE_3_3_2,
        //UByte233Reversed = All.UNSIGNED_BYTE_2_3_3_REV,
        //UShort565 = All.UNSIGNED_SHORT_5_6_5,
        //UShort565Reversed = All.UNSIGNED_SHORT_5_6_5_REV,
        //UShort4444 = All.UNSIGNED_SHORT_4_4_4_4,
        //UShort4444Reversed = All.UNSIGNED_SHORT_4_4_4_4_REV,
        //UShort5551 = All.UNSIGNED_SHORT_5_5_5_1,
        //UShort1555Reversed = All.UNSIGNED_SHORT_1_5_5_5_REV,
        //UInt8888 = All.UNSIGNED_INT_8_8_8_8,
        //UInt8888Reversed = All.UNSIGNED_INT_8_8_8_8_REV,
        //UInt1010102 = All.UNSIGNED_INT_10_10_10_2,
        //UInt2101010Reversed = All.UNSIGNED_INT_2_10_10_10_REV,

        //UInt248 = All.UNSIGNED_INT_24_8,
        //UInt10F11F11FReversed = All.UNSIGNED_INT_10F_11F_11F_REV,
        //UInt5999Reversed = All.UNSIGNED_INT_5_9_9_9_REV,
        //Float32Uint248Reversed = All.FLOAT_32_UNSIGNED_INT_24_8_REV,
    }
}
