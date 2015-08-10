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
    public enum UniformType
    {
        @float = All.FLOAT,
        vec2 = All.FLOAT_VEC2,
        vec3 = All.FLOAT_VEC3,
        vec4 = All.FLOAT_VEC4,
        @double = All.DOUBLE,
        dvec2 = All.DOUBLE_VEC2,
        dvec3 = All.DOUBLE_VEC3,
        dvec4 = All.DOUBLE_VEC4,
        @int = All.INT,
        ivec2 = All.INT_VEC2,
        ivec3 = All.INT_VEC3,
        ivec4 = All.INT_VEC4,
        @uint = All.UNSIGNED_INT,
        uvec2 = All.UNSIGNED_INT_VEC2,
        uvec3 = All.UNSIGNED_INT_VEC3,
        uvec4 = All.UNSIGNED_INT_VEC4,
        @bool = All.BOOL,
        bvec2 = All.BOOL_VEC2,
        bvec3 = All.BOOL_VEC3,
        bvec4 = All.BOOL_VEC4,

        mat2 = All.FLOAT_MAT2,
        mat3 = All.FLOAT_MAT3,
        mat4 = All.FLOAT_MAT4,

        mat2x3 = All.FLOAT_MAT2x3,
        mat2x4 = All.FLOAT_MAT2x4,
        mat3x2 = All.FLOAT_MAT3x2,
        mat3x4 = All.FLOAT_MAT3x4,
        mat4x2 = All.FLOAT_MAT4x2,
        mat4x3 = All.FLOAT_MAT4x3,

        dmat2 = All.DOUBLE_MAT2,
        dmat3 = All.DOUBLE_MAT3,
        dmat4 = All.DOUBLE_MAT4,

        dmat2x3 = All.DOUBLE_MAT2x3,
        dmat2x4 = All.DOUBLE_MAT2x4,
        dmat3x2 = All.DOUBLE_MAT3x2,
        dmat3x4 = All.DOUBLE_MAT3x4,
        dmat4x2 = All.DOUBLE_MAT4x2,
        dmat4x3 = All.DOUBLE_MAT4x3,

        sampler1D = All.SAMPLER_1D,
        sampler2D = All.SAMPLER_2D,
        sampler3d = All.SAMPLER_3D,

        samplerCube = All.SAMPLER_CUBE,

        sampler1DShadow = All.SAMPLER_1D_SHADOW,
        sampler2DShadow = All.SAMPLER_2D_SHADOW,

        sampler1DArray = All.SAMPLER_1D_ARRAY,
        sampler2DArray = All.SAMPLER_2D_ARRAY,

        samplerCubeArray = All.SAMPLER_CUBE_MAP_ARRAY,

        sampler1DArrayShadow = All.SAMPLER_1D_ARRAY_SHADOW,
        sampler2DArrayShadow = All.SAMPLER_2D_ARRAY_SHADOW,
        sampler2DMS = All.SAMPLER_2D_MULTISAMPLE,
        sampler2DMSArray = All.SAMPLER_2D_MULTISAMPLE_ARRAY,

        samplerCubeShadow = All.SAMPLER_CUBE_SHADOW,
        samplerCubeArrayShadow = All.SAMPLER_CUBE_MAP_ARRAY_SHADOW,

        samplerBuffer = All.SAMPLER_BUFFER,
        sampler2DRect = All.SAMPLER_2D_RECT,
        sampler2DRectShadow = All.SAMPLER_2D_RECT_SHADOW,

        isampler1D = All.INT_SAMPLER_1D,
        isampler2D = All.INT_SAMPLER_2D,
        isampler3D = All.INT_SAMPLER_3D,

        isamplerCube = All.INT_SAMPLER_CUBE,

        isampler1DArray = All.INT_SAMPLER_1D_ARRAY,
        isampler2DArray = All.INT_SAMPLER_2D_ARRAY,
        isamplerCubeArray = All.INT_SAMPLER_CUBE_MAP_ARRAY,
        isampler2DMS = All.INT_SAMPLER_2D_MULTISAMPLE,
        isampler2DMSArray = All.INT_SAMPLER_2D_MULTISAMPLE_ARRAY,

        isamplerBuffer = All.INT_SAMPLER_BUFFER,
        isampler2DRect = All.INT_SAMPLER_2D_RECT,

        usampler1D = All.UNSIGNED_INT_SAMPLER_1D,
        usampler2D = All.UNSIGNED_INT_SAMPLER_2D,
        usampler3D = All.UNSIGNED_INT_SAMPLER_3D,
        usamplerCube = All.UNSIGNED_INT_SAMPLER_CUBE,

        usampler1DArray = All.UNSIGNED_INT_SAMPLER_1D_ARRAY,
        usampler2DArray = All.UNSIGNED_INT_SAMPLER_2D_ARRAY,
        usamplerCubeArray = All.UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY,

        usampler2DMS = All.UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE,
        usampler2DMSArray = All.UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY,

        usamplerBuffer = All.UNSIGNED_INT_SAMPLER_BUFFER,
        usampler2DRect = All.UNSIGNED_INT_SAMPLER_2D_RECT,

        image1D = All.IMAGE_1D,
        image2D = All.IMAGE_2D,
        image3D = All.IMAGE_3D,
        image2DRect = All.IMAGE_2D_RECT,
        imageCube = All.IMAGE_CUBE,
        imageBuffer = All.IMAGE_BUFFER,
        image1DArray = All.IMAGE_1D_ARRAY,
        image2DArray = All.IMAGE_2D_ARRAY,
        imageCubeArray = All.IMAGE_CUBE_MAP_ARRAY,
        image2DMS = All.IMAGE_2D_MULTISAMPLE,
        image2DMSArray = All.IMAGE_2D_MULTISAMPLE_ARRAY,

        iimage1D = All.INT_IMAGE_1D,
        iimage2D = All.INT_IMAGE_2D,
        iimage3D = All.INT_IMAGE_3D,
        iimage2DRect = All.INT_IMAGE_2D_RECT,
        iimageCube = All.INT_IMAGE_CUBE,
        iimageBuffer = All.INT_IMAGE_BUFFER,
        iimage1DArray = All.INT_IMAGE_1D_ARRAY,
        iimage2DArray = All.INT_IMAGE_2D_ARRAY,
        iimageCubeArray = All.INT_IMAGE_CUBE_MAP_ARRAY,
        iimage2DMS = All.INT_IMAGE_2D_MULTISAMPLE,
        iimage2DMSArray = All.INT_IMAGE_2D_MULTISAMPLE_ARRAY,

        uimage1D = All.UNSIGNED_INT_IMAGE_1D,
        uimage2D = All.UNSIGNED_INT_IMAGE_2D,
        uimage3D = All.UNSIGNED_INT_IMAGE_3D,
        uimage2DRect = All.UNSIGNED_INT_IMAGE_2D_RECT,
        uimageCube = All.UNSIGNED_INT_IMAGE_CUBE,
        uimageBuffer = All.UNSIGNED_INT_IMAGE_BUFFER,
        uimage1DArray = All.UNSIGNED_INT_IMAGE_1D_ARRAY,
        uimage2DArray = All.UNSIGNED_INT_IMAGE_2D_ARRAY,
        uimageCubeArray = All.UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY,
        uimage2DMS = All.UNSIGNED_INT_IMAGE_2D_MULTISAMPLE,
        uimage2DMSArray = All.UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY,

        atomic_uint = All.UNSIGNED_INT_ATOMIC_COUNTER,

        //ARB_gpu_shader_int64
        //Int64 = All.INT64_ARB,

        Long = All.INT64_ARB,
        ULong = All.UNSIGNED_INT64_ARB,

        Vec2l = All.INT64_VEC2_ARB,
        Vec3l = All.INT64_VEC3_ARB,
        Vec4l = All.INT64_VEC4_ARB,

        Vec2ul = All.UNSIGNED_INT64_VEC2_ARB,
        Vec3ul = All.UNSIGNED_INT64_VEC3_ARB,
        Vec4ul = All.UNSIGNED_INT64_VEC4_ARB,
    }
}
