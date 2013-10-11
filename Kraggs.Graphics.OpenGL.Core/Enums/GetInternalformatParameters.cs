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
    public enum GetInternalformatParameters
    {
        NumSampleCounts = All.NUM_SAMPLE_COUNTS,
        Samples = All.SAMPLES,
        InternalFormatSupported = All.INTERNALFORMAT_SUPPORTED,
        InternalFormatPreferred = All.INTERNALFORMAT_PREFERRED,
        InternalFormatRedSize = All.INTERNALFORMAT_RED_SIZE,
        InternalFormatGreenSize = All.INTERNALFORMAT_GREEN_SIZE,
        InternalFormatBlueSize = All.INTERNALFORMAT_BLUE_SIZE,
        InternalFormatAlphaSize = All.INTERNALFORMAT_ALPHA_SIZE,
        InternalFormatDepthSize = All.INTERNALFORMAT_DEPTH_SIZE,
        InternalFormatStencilSize = All.INTERNALFORMAT_STENCIL_SIZE,
        InternalFormatSharedSize = All.INTERNALFORMAT_SHARED_SIZE,
        InternalFormatRedType = All.INTERNALFORMAT_RED_TYPE,
        InternalFormatGreenType = All.INTERNALFORMAT_GREEN_TYPE,
        InternalFormatBlueType = All.INTERNALFORMAT_BLUE_TYPE,
        InternalFormatAlphaType = All.INTERNALFORMAT_ALPHA_TYPE,
        InternalFormatDepthType = All.INTERNALFORMAT_DEPTH_TYPE,
        InternalFormatStencilType = All.INTERNALFORMAT_STENCIL_TYPE,
        MaxWidth = All.MAX_WIDTH,
        MaxHeight = All.MAX_HEIGHT,
        MaxDepth = All.MAX_DEPTH,
        MaxLayers = All.MAX_LAYERS,
        MaxCombinedDimensions = All.MAX_COMBINED_DIMENSIONS,
        FramebufferBlend = All.FRAMEBUFFER_BLEND,
        ColorComponents = All.COLOR_COMPONENTS,
        DepthComponents = All.DEPTH_COMPONENTS,
        StencilComponents = All.STENCIL_COMPONENTS,
        ColorRenderable = All.COLOR_RENDERABLE,
        DepthRenderable = All.DEPTH_RENDERABLE,
        StencilRenderable = All.STENCIL_RENDERABLE,
        FramebufferRenderable = All.FRAMEBUFFER_RENDERABLE,
        FramebufferRenderableLayered = All.FRAMEBUFFER_RENDERABLE_LAYERED,
        ReadPixelsFormat = All.READ_PIXELS_FORMAT,
        ReadPixelsType = All.READ_PIXELS_TYPE,
        Filter = All.FILTER,
        TextureImageFormat = All.TEXTURE_IMAGE_FORMAT,
        TextureImageType = All.TEXTURE_IMAGE_TYPE,
        GetTextureImageFormat = All.GET_TEXTURE_IMAGE_FORMAT,
        GetTextureImageType = All.GET_TEXTURE_IMAGE_TYPE,
        AutoGenerateMipmap = All.AUTO_GENERATE_MIPMAP,
        //GenerateMipmap = All.MANUAL_GENERATE_MIPMAP,
        ColorEncoding = All.COLOR_ENCODING,
        TextureShadow = All.TEXTURE_SHADOW,
        SRGB_Read = All.SRGB_READ,
        SRGB_Write = All.SRGB_WRITE,
        //SRGB_Decode = All.
        TessControlTexture = All.TESS_CONTROL_TEXTURE,
        TessEvaluationTexture = All.TESS_EVALUATION_TEXTURE,
        GeometryTexture = All.GEOMETRY_TEXTURE,
        FragmentTexture = All.FRAGMENT_TEXTURE,
        ComputeTexture = All.COMPUTE_TEXTURE,
        VertexTexture = All.VERTEX_TEXTURE,
        Clearbuffer = All.CLEAR_BUFFER,
        TextureGather = All.TEXTURE_GATHER,
        TextureGatherShadow = All.TEXTURE_GATHER_SHADOW,
        ImageTexelSize = All.IMAGE_TEXEL_SIZE,
        ShaderImageLoad = All.SHADER_IMAGE_LOAD,
        ShaderImageStore = All.SHADER_IMAGE_STORE,
        ShaderImageAtomic = All.SHADER_IMAGE_ATOMIC,
        ImageCompatibilityClass = All.IMAGE_COMPATIBILITY_CLASS,
        ViewCompatibilityClass = All.VIEW_COMPATIBILITY_CLASS,
        ImagePixelFormat = All.IMAGE_PIXEL_FORMAT,
        ImagePixelType = All.IMAGE_PIXEL_TYPE,
        ImageFormatCompatibilityType = All.IMAGE_FORMAT_COMPATIBILITY_TYPE,
        SimultaneousTextureAndDepthTest = All.SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST,
        SimultaneousTextureAndDepthWrite = All.SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE,
        SimultaneousTextureAndStencilTest = All.SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST,
        SimultaneousTextureAndStencilWrite = All.SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE,
        TextureCompressed = All.TEXTURE_COMPRESSED,
        TextureView = All.TEXTURE_VIEW,
        TextureCompressedBlockWidth = All.TEXTURE_COMPRESSED_BLOCK_WIDTH,
        TextureCompressedBlockHeight = All.TEXTURE_COMPRESSED_BLOCK_HEIGHT,
        TextureCompressedBlockSize = All.TEXTURE_COMPRESSED_BLOCK_SIZE,

        ClearTexure = All.CLEAR_TEXTURE,
    }
}
