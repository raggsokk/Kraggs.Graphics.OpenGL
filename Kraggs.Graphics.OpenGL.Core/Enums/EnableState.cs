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
    public enum EnableState
    {
        //TODO: Validate these enums.

        Blend = All.BLEND,
        ClipDistance0 = All.CLIP_DISTANCE0,
        ClipDistance1 = All.CLIP_DISTANCE1,
        ClipDistance2 = All.CLIP_DISTANCE2,
        ClipDistance3 = All.CLIP_DISTANCE3,
        ClipDistance4 = All.CLIP_DISTANCE4,
        ClipDistance5 = All.CLIP_DISTANCE5,
        ClipDistance6 = All.CLIP_DISTANCE6,
        ClipDistance7 = All.CLIP_DISTANCE7,

        ColorLogicOp = All.COLOR_LOGIC_OP,
        CullFace = All.CULL_FACE,
        DebugOutput = All.DEBUG_OUTPUT,
        DebugOutputSynchronous = All.DEBUG_OUTPUT_SYNCHRONOUS,
        DepthClamp = All.DEPTH_CLAMP,
        DepthTest = All.DEPTH_TEST,
        Dither = All.DITHER,
        FramebufferSRGB = All.FRAMEBUFFER_SRGB,
        LineSmooth = All.LINE_SMOOTH,
        MultiSample = All.MULTISAMPLE,
        PolygonOffsetFill = All.POLYGON_OFFSET_FILL,
        PolygonOffsetLine = All.POLYGON_OFFSET_LINE,
        PolygonOffsetPoint = All.POLYGON_OFFSET_POINT,
        PolygonSmooth = All.POLYGON_SMOOTH,
        PrimitiveRestart = All.PRIMITIVE_RESTART,
        PrimitiveRestartFixedIndex = All.PRIMITIVE_RESTART_FIXED_INDEX,
        SamplaAlphaToCoverage = All.SAMPLE_ALPHA_TO_COVERAGE,
        SamplaAlphaToOne = All.SAMPLE_ALPHA_TO_ONE,
        SampleCoverage = All.SAMPLE_COVERAGE,
        SampleShading = All.SAMPLE_SHADING,
        SampleMask = All.SAMPLE_MASK,
        ScissorTest = All.SCISSOR_TEST,
        StencilTest = All.STENCIL_TEST,
        TextureCubeMapSeamless = All.TEXTURE_CUBE_MAP_SEAMLESS,
        ProgramPointSize = All.PROGRAM_POINT_SIZE,
    }
}
