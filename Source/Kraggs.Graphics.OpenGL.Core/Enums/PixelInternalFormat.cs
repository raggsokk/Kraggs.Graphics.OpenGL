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
    /// OpenGL Pixel Format Enumeration.
    /// Note that some functions only support a subset of these enum values.
    /// BASE Prefixed is unsized pixel format.
    /// INTERNAL is a sized internal only format.
    /// COMPRESSED_GENERIC is a unsized generic compressed format which opengl itself can choose what to use.
    /// COMPRESSED is a sized specific format. Internal External dont apply here.
    /// </summary>
    public enum PixelInternalFormat
    {
        // invalid
        NONE = 0,					//GL_NONE 

        //// base internal format
        //// opengl 4.3 core, table 8.11
        BASE_RED = All.RED,
        BASE_RG = All.RG,
        BASE_RGB = All.RGB,
        BASE_RGBA = All.RGBA,
        BASE_DEPTH = All.DEPTH_COMPONENT,
        BASE_DEPTH_STENCIL = All.DEPTH_STENCIL,
        BASE_STENCIL = All.STENCIL,
        BASE_sRGB = All.SRGB,
        BASE_sRGBA = All.SRGB_ALPHA,

        // Generic Compressed Formats
        COMPRESSED_GENERIC_RED = All.COMPRESSED_RED,
        COMPRESSED_GENERIC_RG = All.COMPRESSED_RG,
        COMPRESSED_GENERIC_RGB = All.COMPRESSED_RGB,
        COMPRESSED_GENERIC_RGBA = All.COMPRESSED_RGBA,
        COMPRESSED_GENERIC_sRGB = All.COMPRESSED_SRGB,
        COMPRESSED_GENERIC_sRGBA = All.COMPRESSED_SRGB_ALPHA,

        // unorm formats
        INTERNAL_R8_UNORM = 0x8229,			//GL_R8
        INTERNAL_RG8_UNORM = 0x822B,		//GL_RG8
        INTERNAL_RGB8_UNORM = 0x8051,		//GL_RGB8
        INTERNAL_RGBA8_UNORM = 0x8058,		//GL_RGBA8

        INTERNAL_R16_UNORM = 0x822A,		//GL_R16
        INTERNAL_RG16_UNORM = 0x822C,		//GL_RG16
        INTERNAL_RGB16_UNORM = 0x8054,		//GL_RGB16
        INTERNAL_RGBA16_UNORM = 0x805B,		//GL_RGBA16

        // snorm formats
        INTERNAL_R8_SNORM = 0x8F94,			//GL_R8_SNORM
        INTERNAL_RG8_SNORM = 0x8F95,		//GL_RG8_SNORM
        INTERNAL_RGB8_SNORM = 0x8F96,		//GL_RGB8_SNORM
        INTERNAL_RGBA8_SNORM = 0x8F97,		//GL_RGBA8_SNORM

        INTERNAL_R16_SNORM = 0x8F98,		//GL_R16_SNORM
        INTERNAL_RG16_SNORM = 0x8F99,		//GL_RG16_SNORM
        INTERNAL_RGB16_SNORM = 0x8F9A,		//GL_RGB16_SNORM
        INTERNAL_RGBA16_SNORM = 0x8F9B,		//GL_RGBA16_SNORM

        // Unsigned integer formats
        INTERNAL_R8U = 0x8232,				//GL_R8UI
        INTERNAL_RG8U = 0x8238,				//GL_RG8UI
        INTERNAL_RGB8U = 0x8D7D,			//GL_RGB8UI
        INTERNAL_RGBA8U = 0x8D7C,			//GL_RGBA8UI

        INTERNAL_R16U = 0x8234,				//GL_R16UI
        INTERNAL_RG16U = 0x823A,			//GL_RG16UI
        INTERNAL_RGB16U = 0x8D77,			//GL_RGB16UI
        INTERNAL_RGBA16U = 0x8D76,			//GL_RGBA16UI

        INTERNAL_R32U = 0x8236,				//GL_R32UI
        INTERNAL_RG32U = 0x823C,			//GL_RG32UI
        INTERNAL_RGB32U = 0x8D71,			//GL_RGB32UI
        INTERNAL_RGBA32U = 0x8D70,			//GL_RGBA32UI

        // Signed integer formats
        INTERNAL_R8I = 0x8231,				//GL_R8I
        INTERNAL_RG8I = 0x8237,				//GL_RG8I
        INTERNAL_RGB8I = 0x8D8F,			//GL_RGB8I
        INTERNAL_RGBA8I = 0x8D8E,			//GL_RGBA8I

        INTERNAL_R16I = 0x8233,				//GL_R16I
        INTERNAL_RG16I = 0x8239,			//GL_RG16I
        INTERNAL_RGB16I = 0x8D89,			//GL_RGB16I
        INTERNAL_RGBA16I = 0x8D88,			//GL_RGBA16I

        INTERNAL_R32I = 0x8235,				//GL_R32I
        INTERNAL_RG32I = 0x823B,			//GL_RG32I
        INTERNAL_RGB32I = 0x8D83,			//GL_RGB32I
        INTERNAL_RGBA32I = 0x8D82,			//GL_RGBA32I

        // Floating formats
        INTERNAL_R16F = 0x822D,				//GL_R16F
        INTERNAL_RG16F = 0x822F,			//GL_RG16F
        INTERNAL_RGB16F = 0x881B,			//GL_RGB16F
        INTERNAL_RGBA16F = 0x881A,			//GL_RGBA16F

        INTERNAL_R32F = 0x822E,				//GL_R32F
        INTERNAL_RG32F = 0x8230,			//GL_RG32F
        INTERNAL_RGB32F = 0x8815,			//GL_RGB32F
        INTERNAL_RGBA32F = 0x8814,			//GL_RGBA32F

        // Packed formats
        INTERNAL_RGB9E5 = 0x8C3D,			//GL_RGB9_E5
        INTERNAL_RG11B10F = 0x8C3A,			//GL_R11F_G11F_B10F
        INTERNAL_RG3B2 = 0x2A10,			//GL_R3_G3_B2
        INTERNAL_R5G6B5 = 0x8D62,			//GL_RGB565
        INTERNAL_RGB5A1 = 0x8057,			//GL_RGB5_A1
        INTERNAL_RGBA4 = 0x8056,			//GL_RGBA4
        INTERNAL_RGB10A2 = 0x8059,			//GL_RGB10_A2UI

        // Depth formats
        INTERNAL_D16 = 0x81A5,				//GL_DEPTH_COMPONENT16
        INTERNAL_D24 = 0x81A6,				//GL_DEPTH_COMPONENT24
        INTERNAL_D24S8 = 0x88F0,			//GL_DEPTH24_STENCIL8
        INTERNAL_D32 = 0x81A7,				//GL_DEPTH_COMPONENT32
        INTERNAL_D32F = 0x8CAC,				//GL_DEPTH_COMPONENT32F
        INTERNAL_D32FS8X24 = 0x8CAD,		//GL_DEPTH32F_STENCIL8
        INTERNAL_S8 = 0x8D48,               //GL_STENCIL_INDEX8

        // sRGB
        INTERNAL_SRGB8 = All.SRGB8,
        INTERNAL_SRGBA8 = All.SRGB8_ALPHA8,

        // Compressed formats have no understanding of internal and external format.
        // A compressed format is what it is.

        COMPRESSED_RGB_DXT1 = 0x83F0,					//GL_COMPRESSED_RGB_S3TC_DXT1_EXT
        COMPRESSED_RGBA_DXT1 = 0x83F1,				//GL_COMPRESSED_RGB_S3TC_DXT1_EXT
        COMPRESSED_RGBA_DXT3 = 0x83F2,				//GL_COMPRESSED_RGBA_S3TC_DXT3_EXT
        COMPRESSED_RGBA_DXT5 = 0x83F3,				//GL_COMPRESSED_RGBA_S3TC_DXT5_EXT
        COMPRESSED_R_ATI1N_UNORM = 0x8DBB,			//GL_COMPRESSED_RED_RGTC1
        COMPRESSED_R_ATI1N_SNORM = 0x8DBC,			//GL_COMPRESSED_SIGNED_RED_RGTC1
        COMPRESSED_RG_ATI2N_UNORM = 0x8DBD,			//GL_COMPRESSED_RG_RGTC2
        COMPRESSED_RG_ATI2N_SNORM = 0x8DBE,			//GL_COMPRESSED_SIGNED_RG_RGTC2
        COMPRESSED_RGB_BP_UNSIGNED_FLOAT = 0x8E8F,	//GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT
        COMPRESSED_RGB_BP_SIGNED_FLOAT = 0x8E8E,		//GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT
        COMPRESSED_RGB_BP_UNORM = 0x8E8C,				//GL_COMPRESSED_RGBA_BPTC_UNORM

        // sRGB formats
        //BASE INTERNAL_SRGB8 = 0x8C41,					//GL_SRGB8
        //BASE INTERNAL_SRGB8_ALPHA8 = 0x8C43,				//GL_SRGB8_ALPHA8
        COMPRESSED_SRGB_DXT1 = 0x8C4C,				//GL_COMPRESSED_SRGB_S3TC_DXT1_EXT
        COMPRESSED_SRGB_ALPHA_DXT1 = 0x8C4C,			//GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT
        COMPRESSED_SRGB_ALPHA_DXT3 = 0x8C4E,			//GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT
        COMPRESSED_SRGB_ALPHA_DXT5 = 0x8C4F,			//GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT
        COMPRESSED_SRGB_BP_UNORM = 0x8E8D,			//GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM

        // Compressed EAC/ETC2 Formats
        COMPRESSED_R11_EAC = 0x9270,                  //GL_COMPRESSED_R11_EAC
        COMPRESSED_R11_EAC_SIGNED = 0x9271,           //GL_COMPRESSED_SIGNED_R11_EAC
        COMPRESSED_RG11_EAC = 0x9272,                 //GL_COMPRESSED_RG11_EAC
        COMPRESSED_RG11_EAC_SIGNED = 0x9273,          //GL_COMPRESSED_SIGNED_RG11_EAC
        COMPRESSED_RGB8_ETC2 = 0x9274,                 //GL_COMPRESSED_RGB8_ETC2
        COMPRESSED_SRGB8_ETC2 = 0x9275,                //GL_COMPRESSED_SRGB8_ETC2
        COMPRESSED_RGB8A1_ETC2 = 0x9276, //GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2
        COMPRESSED_SRGB8_ALPHA1__ETC2 = 0x9277, //GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2
        COMPRESSED_RGBA8_ETC2_EAC = 0x9278,           //GL_COMPRESSED_RGBA8_ETC2_EAC
        COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279,    //GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC

        COMPRESSED_RGB8_ETC1 = 0x8D64,                //GL_ETC1_RGB8_OES


        //// base internal format
        //// opengl 4.3 core, table 8.11
        //DepthComponent = All.DEPTH_COMPONENT,
        //DepthStencil = All.DEPTH_STENCIL,
        //Red = All.RED,
        //RG = All.RG,
        //RGB = All.RGB,
        //RGBA = All.RGBA,

        //// sized internal format
        //// opengl 4.3 core, table 8.12 & 8.13
        ////Base : Red
        //R8 = All.R8,
        //R8_SNorm = All.R8_SNORM,
        //R16 = All.R16,
        //R16_SNorm = All.R16_SNORM,

        ////Base : RG
        //RG8 = All.RG8,
        //RG8_SNorm = All.RG8_SNORM,
        //RG16 = All.RG16,
        //RG16_SNorm = All.RG16_SNORM,

        //// Base : RGB
        //R3_G3_B2 = All.R3_G3_B2,

        //RGB4 = All.RGB4,
        //RGB5 = All.RGB5,
        //RGB565 = All.RGB565,
        //RGB8 = All.RGB8,
        //RGB8_SNorm = All.RGB8_SNORM,
        //RGB10 = All.RGB10,
        //RGB12 = All.RGB12,
        //RGB16 = All.RGB16,
        //RGB16_SNorm = All.RGB16_SNORM,

        //// Base : RGBA
        //RGBA2 = All.RGBA2,
        //RGBA4 = All.RGBA4,
        //RGB5_A1 = All.RGB5_A1,
        //RGBA8 = All.RGBA8,
        //RGBA8_SNorm = All.RGBA8_SNORM,
        //RGB10_A2 = All.RGB10_A2,
        //RGB10_A2UI = All.RGB10_A2UI,
        //RGBA12 = All.RGBA12,
        //RGBA16 = All.RGBA16,
        //RGBA16_SNorm = All.RGBA16_SNORM,

        //SRGB8 = All.SRGB8, // Base : RGB
        //SRGB8_Alpha8 = All.SRGB8_ALPHA8, // Base : RGBA

        //R16F = All.R16F, // Base: RED
        //RG16F = All.RG16F,
        //RGB16F = All.RGB16F,
        //RGBA16F = All.RGBA16F,

        //R32F = All.R32F,
        //RG32F = All.RG32F,
        //RGB32F = All.RGB32F,
        //RGBA32F = All.RGBA32F,

        //R11F_G11F_B10F = All.R11F_G11F_B10F,
        //RGB9_E5 = All.RGB9_E5,

        //R8I = All.R8I,
        //R8UI = All.R8UI,
        //R16I = All.R16I,
        //R16UI = All.R16UI,
        //R32I = All.R32I,
        //R32UI = All.R32UI,

        //RG8I = All.RG8I,
        //RG8UI = All.RG8UI,
        //RG16I = All.RG16I,
        //RG16UI = All.RG16UI,
        //RG32I = All.RG32I,
        //RG32UI = All.RG32UI,

        //RGB8I = All.RGB8I,
        //RGB8UI = All.RGB8UI,
        //RGB16I = All.RGB16I,
        //RGB16UI = All.RGB16UI,
        //RGB32I = All.RGB32I,
        //RGB32UI = All.RGB32UI,

        //RGBA8I = All.RGBA8I,
        //RGBA8UI = All.RGBA8UI,
        //RGBA16I = All.RGBA16I,
        //RGBA16UI = All.RGBA16UI,
        //RGBA32I = All.RGBA32I,
        //RGBA32UI = All.RGBA32UI,

        //// sized depth/stencil formats, aka table 8.13
        //DepthComponent16 = All.DEPTH_COMPONENT16,
        //DepthComponent24 = All.DEPTH_COMPONENT24,
        //DepthComponent32 = All.DEPTH_COMPONENT32,
        //DepthComponent32F = All.DEPTH_COMPONENT32F,
        //Depth24Stencil8 = All.DEPTH24_STENCIL8,
        //Depth32FStencil8 = All.DEPTH32F_STENCIL8,

        //// generic compressed format
        //// opengl 4.3 core, table 8.14
        //Compressed_Red = All.COMPRESSED_RED,
        //Compressed_RG = All.COMPRESSED_RG,
        //Compressed_RGB = All.COMPRESSED_RGB,
        //Compressed_RGBA = All.COMPRESSED_RGBA,
        //Compressed_SRGB = All.COMPRESSED_SRGB,
        //Compressed_SRGBAlpha = All.COMPRESSED_SRGB_ALPHA,

        //// specific compressed format
        //// opengl 4.3 core, table 8.14
        //Compressed_Red_RGTC1 = All.COMPRESSED_RED_RGTC1,
        //Compressed_Signed_Red_RGTC1 = All.COMPRESSED_SIGNED_RED_RGTC1,
        //Compressed_RG_RGTC2 = All.COMPRESSED_RG_RGTC2,
        //Compressed_Signed_RG_RGTC2 = All.COMPRESSED_SIGNED_RG_RGTC2,

        //Compressed_RGBA_BPTC_UNorm = All.COMPRESSED_RGBA_BPTC_UNORM_ARB,
        //Compressed_SRGBAlpha_BPTC_UNorm = All.COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB,
        //Compressed_Signed_RGB_BPTC_Float = All.COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB,
        //Compressed_Unsigned_RGB_BPTC_Float = All.COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB,
        ////Compressed_SRGB_Alpha_BPTC_UNorm = All.
        ////Compressed_RGB_BPTC_Signed_Float = All.
        ////Compressed_RGB_BTTC_Unsigned_Float = All.
        //Compressed_RGB8_ETC2 = All.COMPRESSED_RGB8_ETC2,
        //Compressed_SRGB8_ETC2 = All.COMPRESSED_SRGB8_ETC2,
        //Compressed_RGB8_PunchThrough_Alpha1_ETC2 = All.COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2,
        //Compressed_SRGB8_PunchThrough_Alpha1_ETC2 = All.COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2,
        //Compressed_RGBA8_ETC2_EAC = All.COMPRESSED_RGBA8_ETC2_EAC,
        //Compressed_SRGB8_Alpha9_ETC2_EAC = All.COMPRESSED_SRGB8_ALPHA8_ETC2_EAC,
        //Compressed_R11_EAC = All.COMPRESSED_RG11_EAC,
        //Compressed_Signed_R11_EAC = All.COMPRESSED_SIGNED_R11_EAC,
        //Compressed_RG11_EAC = All.COMPRESSED_RG11_EAC,
        //Compressed_Signed_RG11_EAC = All.COMPRESSED_SIGNED_RG11_EAC,

        //StencilIndex8 = All.STENCIL_INDEX8,
    }
}
