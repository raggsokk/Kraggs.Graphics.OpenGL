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
    /// Redesigned all the num formats. Not sure if its any better thou.
    /// </summary>
    public enum PixelInternalFormatV2
    {
        Null = All.NONE,

        // Base Formats
        /// <summary>
        /// Base unsized Red format.
        /// </summary>
        BaseRed = All.RED,
        /// <summary>
        /// Base unsized RG format.
        /// </summary>
        BaseRG = All.RG,
        /// <summary>
        /// Base unsized RGB format.
        /// </summary>
        BaseRGB = All.RGB,
        /// <summary>
        /// Base unsized RGBA format.
        /// </summary>
        BaseRGBA = All.RGBA,        
        BaseDepthComponent = All.DEPTH_COMPONENT,
        BaseDepthStencil = All.DEPTH_STENCIL,
        BaseStencil = All.STENCIL, // is this corrent??
        BaseSRGB = All.SRGB,
        BaseSRGBA = All.SRGB_ALPHA,

        // Generic Compressed Formats
        CompressedRed = All.COMPRESSED_RED,
        CompressedRG = All.COMPRESSED_RG,
        CompressedRGB = All.COMPRESSED_RGB,
        CompressedRGBA = All.COMPRESSED_RGBA,
        CompressedSRGB = All.COMPRESSED_SRGB,
        CompressedSRGBA = All.COMPRESSED_SRGB_ALPHA,

        // Sized Internal Formats
        R8_UNORM = All.R8,
        RG8_UNORM = All.RG8,
        RGB8_UNORM = All.RGB8,
        RGBA8_UNORM = All.RGBA8,

        R16_UNORM = All.R16,
        RG16_UNORM = All.RG16,
        RGB16_UNORM = All.RGB16,
        RGBA16_UNORM = All.RGBA16,

        // snorm formats
        R8_SNORM = All.R8_SNORM,
        RG8_SNORM = All.RG8_SNORM,
        RGB8_SNORM = All.RGB8_SNORM,
        RGBA8_SNORM = All.RGBA8_SNORM,

        R16_SNORM = All.R16_SNORM,
        RG16_SNORM = All.RG16_SNORM,
        RGB16_SNORM = All.RGB16_SNORM,
        RGBA16_SNORM = All.RGBA16_SNORM,

        // Unsigned integer formats
        R8U = All.R8UI,
        RG8U = All.RG8UI,
        RGB8U = All.RGB8UI,
        RGBA8U = All.RGBA8UI,

        R16U = All.R16UI,
        RG16U = All.RG16UI,
        RGB16U = All.RGB16UI,
        RGBA16U = All.RGBA16UI,

        R32U = All.R32UI,
        RG32U = All.RG32UI,
        RGB32U = All.RGB32UI,
        RGBA32U = All.RGBA32UI,

        // Signed integer formats
        R8I = All.R8I,
        RG8I = All.RG8I,
        RGB8I = All.RGB8I,
        RGBA8I = All.RGBA8I,

        R16I = All.R16I,
        RG16I = All.RG16I,
        RGB16I = All.RGB16I,
        RGBA16I = All.RGBA16I,

        R32I = All.R32I,
        RG32I = All.RG32I,
        RGB32I = All.RGB32I,
        RGBA32I = All.RGBA32I,

        // Floating formats
        R16F = All.R16F,
        RG16F = All.RG16F,
        RGB16F = All.RGB16F,
        RGBA16F = All.RGBA16F,

        R32F = All.R32F,
        RG32F = All.RG32F,
        RGB32F = All.RGB32F,
        RGBA32F = All.RGBA32F,

        // Packed formats
        PackedRGB9E5 = All.RGB9_E5,
        PackedRG11B10F = All.R11F_G11F_B10F,
        PackedR3G3B2 = All.R3_G3_B2,
        PackedR5G6B5 = All.RGB565,
        PackedRGB5A1 = All.RGB5_A1,
        PackedRGBA4 = All.RGBA4,
        PackedRGB10A2 = All.RGB10_A2,

        // Depth formats
        D16 = All.DEPTH_COMPONENT16,
        D24X8 = All.DEPTH_COMPONENT24,
        D24S8 = All.DEPTH24_STENCIL8,
        D32 = All.DEPTH_COMPONENT32,
        D32F = All.DEPTH_COMPONENT32F,
        D32FS8X24 = All.DEPTH32F_STENCIL8,

        // Stencil formats
        S1 = All.STENCIL_INDEX1,
        S4 = All.STENCIL_INDEX4,
        S8 = All.STENCIL_INDEX8,
        S16 = All.STENCIL_INDEX16,

        // Sized Compressed Formats
        // no matter how you format it it will stink!

        // DXT / s3tc.
        CRGB4_DXT1 = All.GL_COMPRESSED_RGB_S3TC_DXT1_EXT,
        CRGB4A1_DXT1 = All.GL_COMPRESSED_RGBA_S3TC_DXT1_EXT,
        CRGBA8_DXT3 = All.GL_COMPRESSED_RGBA_S3TC_DXT3_EXT,
        CRGBA8_DXT5 = All.GL_COMPRESSED_RGBA_S3TC_DXT5_EXT,

        CSRGB4_DXT1 = All.GL_COMPRESSED_SRGB_S3TC_DXT1_EXT,
        CSRGB4A1_DXT1 = All.GL_COMPRESSED_SRGBA_S3TC_DXT1_EXT,
        CSRGBA8_DXT3 = All.GL_COMPRESSED_SRGBA_S3TC_DXT3_EXT,
        CSRGBA8_DXT5 = All.GL_COMPRESSED_SRGBA_S3TC_DXT5_EXT,
        
        // RGTC
        CR8_RGTC_UNorm = All.COMPRESSED_RED_RGTC1,          //BC4
        CR8_RGTC_SNorm = All.COMPRESSED_SIGNED_RED_RGTC1,   //BC4
        CRG8_RGTC_UNorm = All.COMPRESSED_RG_RGTC2,          //BC5
        CRG8_RGTC_SNorm = All.COMPRESSED_SIGNED_RG_RGTC2,   //BC5

        // BPTC
        CRGBA_BPTC_UNorm = All.COMPRESSED_RGBA_BPTC_UNORM_ARB, //BC7
        CSRGBA_BPTC_UNorm = All.COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB, //BC7

        CRGB_BPTC_SignedFloat = All.COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB, //BC6H
        CRGB_BPTC_UnsignedFloat = All.COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB, //BC6H        

        // EAC 
        CR11_EAC_UNorm = All.COMPRESSED_R11_EAC,
        CR11_EAC_SNorm = All.COMPRESSED_SIGNED_R11_EAC,
        CRG11_EAC_UNorm = All.COMPRESSED_RG11_EAC,               
        CRG11_EAC_SNorm = All.COMPRESSED_SIGNED_RG11_EAC,         

        // ETC2
        CRGB8_ETC2 = All.COMPRESSED_RGB8_ETC2,
        CRGB8A1_ETC2 = All.COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2,
        CRGBA8_ETC2 = All.COMPRESSED_RGBA8_ETC2_EAC,
               
        CSRGB8_ETC2 = All.COMPRESSED_SRGB8_ETC2,
        CSRGB8A1_ETC2 = All.COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2,
        CSRGBA8_ETC2 = All.COMPRESSED_SRGB8_ALPHA8_ETC2_EAC,        
    }
}
