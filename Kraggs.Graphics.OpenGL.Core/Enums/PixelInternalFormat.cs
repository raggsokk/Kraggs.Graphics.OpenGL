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
    public enum PixelInternalFormat
    {
        // base internal format
        // opengl 4.3 core, table 8.11
        DepthComponent = All.DEPTH_COMPONENT,
        DepthStencil = All.DEPTH_STENCIL,
        Red = All.RED,
        RG = All.RG,
        RGB = All.RGB,
        RGBA = All.RGBA,

        // sized internal format
        // opengl 4.3 core, table 8.12 & 8.13
        //Base : Red
        R8 = All.R8,
        R8_SNorm = All.R8_SNORM,
        R16 = All.R16,
        R16_SNorm = All.R16_SNORM,

        //Base : RG
        RG8 = All.RG8,
        RG8_SNorm = All.RG8_SNORM,
        RG16 = All.RG16,
        RG16_SNorm = All.RG16_SNORM,

        // Base : RGB
        R3_G3_B2 = All.R3_G3_B2,

        RGB4 = All.RGB4,
        RGB5 = All.RGB5,
        RGB565 = All.RGB565,
        RGB8 = All.RGB8,
        RGB8_SNorm = All.RGB8_SNORM,
        RGB10 = All.RGB10,
        RGB12 = All.RGB12,
        RGB16 = All.RGB16,
        RGB16_SNorm = All.RGB16_SNORM,

        // Base : RGBA
        RGBA2 = All.RGBA2,
        RGBA4 = All.RGBA4,
        RGB5_A1 = All.RGB5_A1,
        RGBA8 = All.RGBA8,
        RGBA8_SNorm = All.RGBA8_SNORM,
        RGB10_A2 = All.RGB10_A2,
        RGB10_A2UI = All.RGB10_A2UI,
        RGBA12 = All.RGBA12,
        RGBA16 = All.RGBA16,
        RGBA16_SNorm = All.RGBA16_SNORM,

        SRGB8 = All.SRGB8, // Base : RGB
        SRGB8_Alpha8 = All.SRGB8_ALPHA8, // Base : RGBA

        R16F = All.R16F, // Base: RED
        RG16F = All.RG16F,
        RGB16F = All.RGB16F,
        RGBA16F = All.RGBA16F,

        R32F = All.R32F,
        RG32F = All.RG32F,
        RGB32F = All.RGB32F,
        RGBA32F = All.RGBA32F,

        R11F_G11F_B10F = All.R11F_G11F_B10F,
        RGB9_E5 = All.RGB9_E5,

        R8I = All.R8I,
        R8UI = All.R8UI,
        R16I = All.R16I,
        R16UI = All.R16UI,
        R32I = All.R32I,
        R32UI = All.R32UI,

        RG8I = All.RG8I,
        RG8UI = All.RG8UI,
        RG16I = All.RG16I,
        RG16UI = All.RG16UI,
        RG32I = All.RG32I,
        RG32UI = All.RG32UI,

        RGB8I = All.RGB8I,
        RGB8UI = All.RGB8UI,
        RGB16I = All.RGB16I,
        RGB16UI = All.RGB16UI,
        RGB32I = All.RGB32I,
        RGB32UI = All.RGB32UI,

        RGBA8I = All.RGBA8I,
        RGBA8UI = All.RGBA8UI,
        RGBA16I = All.RGBA16I,
        RGBA16UI = All.RGBA16UI,
        RGBA32I = All.RGBA32I,
        RGBA32UI = All.RGBA32UI,

        // sized depth/stencil formats, aka table 8.13
        DepthComponent16 = All.DEPTH_COMPONENT16,
        DepthComponent24 = All.DEPTH_COMPONENT24,
        DepthComponent32 = All.DEPTH_COMPONENT32,
        DepthComponent32F = All.DEPTH_COMPONENT32F,
        Depth24Stencil8 = All.DEPTH24_STENCIL8,
        Depth32FStencil8 = All.DEPTH32F_STENCIL8,

        // generic compressed format
        // opengl 4.3 core, table 8.14
        Compressed_Red = All.COMPRESSED_RED,
        Compressed_RG = All.COMPRESSED_RG,
        Compressed_RGB = All.COMPRESSED_RGB,
        Compressed_RGBA = All.COMPRESSED_RGBA,
        Compressed_SRGB = All.COMPRESSED_SRGB,
        Compressed_SRGBAlpha = All.COMPRESSED_SRGB_ALPHA,

        // specific compressed format
        // opengl 4.3 core, table 8.14
        Compressed_Red_RGTC1 = All.COMPRESSED_RED_RGTC1,
        Compressed_Signed_Red_RGTC1 = All.COMPRESSED_SIGNED_RED_RGTC1,
        Compressed_RG_RGTC2 = All.COMPRESSED_RG_RGTC2,
        Compressed_Signed_RG_RGTC2 = All.COMPRESSED_SIGNED_RG_RGTC2,

        Compressed_RGBA_BPTC_UNorm = All.COMPRESSED_RGBA_BPTC_UNORM_ARB,
        Compressed_SRGBAlpha_BPTC_UNorm = All.COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB,
        Compressed_Signed_RGB_BPTC_Float = All.COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB,
        Compressed_Unsigned_RGB_BPTC_Float = All.COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB,
        //Compressed_SRGB_Alpha_BPTC_UNorm = All.
        //Compressed_RGB_BPTC_Signed_Float = All.
        //Compressed_RGB_BTTC_Unsigned_Float = All.
        Compressed_RGB8_ETC2 = All.COMPRESSED_RGB8_ETC2,
        Compressed_SRGB8_ETC2 = All.COMPRESSED_SRGB8_ETC2,
        Compressed_RGB8_PunchThrough_Alpha1_ETC2 = All.COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2,
        Compressed_SRGB8_PunchThrough_Alpha1_ETC2 = All.COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2,
        Compressed_RGBA8_ETC2_EAC = All.COMPRESSED_RGBA8_ETC2_EAC,
        Compressed_SRGB8_Alpha9_ETC2_EAC = All.COMPRESSED_SRGB8_ALPHA8_ETC2_EAC,
        Compressed_R11_EAC = All.COMPRESSED_RG11_EAC,
        Compressed_Signed_R11_EAC = All.COMPRESSED_SIGNED_R11_EAC,
        Compressed_RG11_EAC = All.COMPRESSED_RG11_EAC,
        Compressed_Signed_RG11_EAC = All.COMPRESSED_SIGNED_RG11_EAC,

        StencilIndex8 = All.STENCIL_INDEX8,
    }
}
