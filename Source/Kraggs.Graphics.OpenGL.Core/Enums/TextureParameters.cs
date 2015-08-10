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
    public enum TextureParameters
    {
        DepthStencilTextureMode = All.DEPTH_STENCIL_TEXTURE_MODE,
        BaseLevel = All.TEXTURE_BASE_LEVEL,
        BorderColor = All.TEXTURE_BORDER_COLOR,
        CompareFunc = All.TEXTURE_COMPARE_FUNC,
        CompareMode = All.TEXTURE_COMPARE_MODE,
        ImmutableFormat = All.TEXTURE_IMMUTABLE_FORMAT,
        ImmutableLevels = All.TEXTURE_IMMUTABLE_LEVELS,

        LodBias = All.TEXTURE_LOD_BIAS,
        MinFilter = All.TEXTURE_MIN_FILTER,
        MagFilter = All.TEXTURE_MAG_FILTER,
        MinLod = All.TEXTURE_MIN_LOD,
        MaxLod = All.TEXTURE_MAX_LOD,
        MaxLevel = All.TEXTURE_MAX_LEVEL,
        SwizzleR = All.TEXTURE_SWIZZLE_R,
        SwizzleG = All.TEXTURE_SWIZZLE_G,
        SwizzleB = All.TEXTURE_SWIZZLE_B,
        SwizzleA = All.TEXTURE_SWIZZLE_A,
        SwizzleRGBA = All.TEXTURE_SWIZZLE_RGBA,
        WrapS = All.TEXTURE_WRAP_S,
        WrapT = All.TEXTURE_WRAP_T,
        WrapR = All.TEXTURE_WRAP_R,

        ViewMinLayer = All.TEXTURE_VIEW_MIN_LAYER,
        ViewMinLevel = All.TEXTURE_VIEW_MIN_LEVEL,
        ViewNumLayers = All.TEXTURE_VIEW_NUM_LAYERS,
        ViewNumLevels = All.TEXTURE_VIEW_NUM_LEVELS,

        // image_load_Store
        /// <summary>
        /// Returned in the <data> parameter of GetTexParameteriv, GetTexParameterfv, GetTexParameterIiv, and GetTexParameterIuiv when <value> is IMAGE_FORMAT_COMPATIBILITY_TYPE:
        /// IMAGE_FORMAT_COMPATIBILITY_BY_SIZE, IMAGE_FORMAT_COMPATIBILITY_BY_CLASS
        /// </summary>
        ImageFormatCompatibility = All.IMAGE_FORMAT_COMPATIBILITY_TYPE,

        //ARB_sparse_texture
        SparseARB = All.TEXTURE_SPARSE_ARB,
        VirtualPageSizeIndexARB = All.VIRTUAL_PAGE_SIZE_INDEX_ARB,

        NumSparseLevelsARB = All.NUM_SPARSE_LEVELS_ARB,

        //EXT_texture_filter_anisotropic
        /// <summary>
        /// TEXTURE_MAX_ANISOTROPY_EXT
        /// </summary>
        AnisotropyEXT = All.TEXTURE_MAX_ANISOTROPY_EXT,

        //AMD_seamless_cubemap_per_texture
        /// <summary>
        /// AMD_seamless_cubemap_per_texture
        /// </summary>
        SeamlessCubemap = All.TEXTURE_CUBE_MAP_SEAMLESS,

        //ARB_texture_filter_minmax
        /// <summary>
        /// ARB_texture_filter_minmax
        /// Gets or sets TextureReductionMode
        /// </summary>
        ReductionMode =  All.TEXTURE_REDUCTION_MODE_ARB,
    }
}
