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
    public enum CompressedInternalFormat
    {
        // Generic
        Red_Generic = All.COMPRESSED_RED,
        RG_Generic = All.COMPRESSED_RG,
        RGB_Generic = All.COMPRESSED_RGB,
        RGBA_Generic = All.COMPRESSED_RGBA,
        SRGB_Generic = All.COMPRESSED_SRGB,
        SRGBAlpha_Generic = All.COMPRESSED_SRGB_ALPHA,

        // Specific
        Red_RGTC1 = All.COMPRESSED_RED_RGTC1,
        Signed_Red_RGTC1 = All.COMPRESSED_SIGNED_RED_RGTC1,
        RG_RGTC2 = All.COMPRESSED_RG_RGTC2,
        Signed_RG_RGTC2 = All.COMPRESSED_SIGNED_RG_RGTC2,

        //RGBA_BPTC_UNorm = All.
        //SRGB_Alpha_BPTC_UNorm = All.
        //RGB_BPTC_Signed_Float = All.
        //RGB_BTTC_Unsigned_Float = All.
        RGBA_BPTC_UNorm = All.COMPRESSED_RGBA_BPTC_UNORM_ARB,
        SRGBAlpha_BPTC_UNorm = All.COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB,
        Signed_RGB_BPTC_Float = All.COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB,
        Unsigned_RGB_BPTC_Float = All.COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB,

        RGB8_ETC2 = All.COMPRESSED_RGB8_ETC2,
        SRGB8_ETC2 = All.COMPRESSED_SRGB8_ETC2,
        RGB8_PunchThrough_Alpha1_ETC2 = All.COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2,
        SRGB8_PunchThrough_Alpha1_ETC2 = All.COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2,
        RGBA8_ETC2_EAC = All.COMPRESSED_RGBA8_ETC2_EAC,
        SRGB8_Alpha9_ETC2_EAC = All.COMPRESSED_SRGB8_ALPHA8_ETC2_EAC,
        R11_EAC = All.COMPRESSED_RG11_EAC,
        Signed_R11_EAC = All.COMPRESSED_SIGNED_R11_EAC,
        RG11_EAC = All.COMPRESSED_RG11_EAC,
        Signed_RG11_EAC = All.COMPRESSED_SIGNED_RG11_EAC,

        //KHR_texture_compression_astc_hdr - part of ARB_ES3_2_compatibility
        // to fit in with rest of enum values.
        RGBA_ASTC_4x4 = All.COMPRESSED_RGBA_ASTC_4x4_KHR,
        RGBA_ASTC_5x4 = All.COMPRESSED_RGBA_ASTC_5x4_KHR,
        RGBA_ASTC_5x5 = All.COMPRESSED_RGBA_ASTC_5x5_KHR,
        RGBA_ASTC_6x5 = All.COMPRESSED_RGBA_ASTC_6x5_KHR,
        RGBA_ASTC_6x6 = All.COMPRESSED_RGBA_ASTC_6x6_KHR,
        RGBA_ASTC_8x5 = All.COMPRESSED_RGBA_ASTC_8x5_KHR,
        RGBA_ASTC_8x6 = All.COMPRESSED_RGBA_ASTC_8x6_KHR,
        RGBA_ASTC_8x8 = All.COMPRESSED_RGBA_ASTC_8x8_KHR,
        RGBA_ASTC_10x5 = All.COMPRESSED_RGBA_ASTC_10x5_KHR,
        RGBA_ASTC_10x6 = All.COMPRESSED_RGBA_ASTC_10x6_KHR,
        RGBA_ASTC_10x8 = All.COMPRESSED_RGBA_ASTC_10x8_KHR,
        RGBA_ASTC_10x10 = All.COMPRESSED_RGBA_ASTC_10x10_KHR,
        RGBA_ASTC_12x10 = All.COMPRESSED_RGBA_ASTC_12x10_KHR,
        RGBA_ASTC_12x12 = All.COMPRESSED_RGBA_ASTC_12x12_KHR,

        SRGB8_ALPHA8_ASTC_4x4 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_4x4_KHR,
        SRGB8_ALPHA8_ASTC_5x4 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_5x4_KHR,
        SRGB8_ALPHA8_ASTC_5x5 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_5x5_KHR,
        SRGB8_ALPHA8_ASTC_6x5 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_6x5_KHR,
        SRGB8_ALPHA8_ASTC_6x6 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_6x6_KHR,
        SRGB8_ALPHA8_ASTC_8x5 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_8x5_KHR,
        SRGB8_ALPHA8_ASTC_8x6 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_8x6_KHR,
        SRGB8_ALPHA8_ASTC_8x8 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_8x8_KHR,
        SRGB8_ALPHA8_ASTC_10x5 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_10x5_KHR,
        SRGB8_ALPHA8_ASTC_10x6 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_10x6_KHR,
        SRGB8_ALPHA8_ASTC_10x8 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_10x8_KHR,
        SRGB8_ALPHA8_ASTC_10x10 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_10x10_KHR,
        SRGB8_ALPHA8_ASTC_12x10 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_12x10_KHR,
        SRGB8_ALPHA8_ASTC_12x12 = All.COMPRESSED_SRGB8_ALPHA8_ASTC_12x12_KHR,

    }
}
