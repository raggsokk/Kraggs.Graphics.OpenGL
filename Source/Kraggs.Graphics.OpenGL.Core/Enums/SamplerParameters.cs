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
    public enum SamplerParameters
    {
        WrapS = All.TEXTURE_WRAP_S,
        WrapT = All.TEXTURE_WRAP_T,
        WrapR = All.TEXTURE_WRAP_R,
        MinFilter = All.TEXTURE_MIN_FILTER,
        MagFilter = All.TEXTURE_MAG_FILTER,
        MinLod = All.TEXTURE_MIN_LOD,
        MaxLod = All.TEXTURE_MAX_LOD,
        BorderColor = All.TEXTURE_BORDER_COLOR,
        LodBias = All.TEXTURE_LOD_BIAS,
        CompareMode = All.TEXTURE_COMPARE_MODE,
        CompareFunc = All.TEXTURE_COMPARE_FUNC,

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
    }
}
