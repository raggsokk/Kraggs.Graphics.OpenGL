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
    /// Both glEnable and glDisable take a single argument, cap, which can assume one of the following values:
    /// </summary>
    public enum EnableState
    {       
        /// <summary>
        /// If enabled, blend the computed fragment color values with the values in the color buffers. See glBlendFunc.
        /// </summary>
        Blend = All.BLEND,
        /// <summary>
        /// If enabled, clip geometry against user-defined half space i.
        /// </summary>
        ClipDistance0 = All.CLIP_DISTANCE0,
        ClipDistance1 = All.CLIP_DISTANCE1,
        ClipDistance2 = All.CLIP_DISTANCE2,
        ClipDistance3 = All.CLIP_DISTANCE3,
        ClipDistance4 = All.CLIP_DISTANCE4,
        ClipDistance5 = All.CLIP_DISTANCE5,
        ClipDistance6 = All.CLIP_DISTANCE6,
        ClipDistance7 = All.CLIP_DISTANCE7,

        /// <summary>
        /// If enabled, apply the currently selected logical operation to the computed fragment color and color buffer values. See glLogicOp.
        /// </summary>
        ColorLogicOp = All.COLOR_LOGIC_OP,
        /// <summary>
        /// If enabled, cull polygons based on their winding in window coordinates. See glCullFace.
        /// </summary>
        CullFace = All.CULL_FACE,
        /// <summary>
        /// If enabled, debug messages are produced by a debug context. When disabled, the debug message log is silenced. Note that in a non-debug context, very few, if any messages might be produced, even when GL_DEBUG_OUTPUT is enabled.
        /// </summary>
        DebugOutput = All.DEBUG_OUTPUT,
        /// <summary>
        /// If enabled, debug messages are produced synchronously by a debug context. If disabled, debug messages may be produced asynchronously. In particular, they may be delayed relative to the execution of GL commands, and the debug callback function may be called from a thread other than that in which the commands are executed. See glDebugMessageCallback.
        /// </summary>
        DebugOutputSynchronous = All.DEBUG_OUTPUT_SYNCHRONOUS,
        /// <summary>
        /// If enabled, the -wc≤zc≤wc plane equation is ignored by view volume clipping (effectively, there is no near or far plane clipping). See glDepthRange.
        /// </summary>
        DepthClamp = All.DEPTH_CLAMP,
        /// <summary>
        /// If enabled, do depth comparisons and update the depth buffer. Note that even if the depth buffer exists and the depth mask is non-zero, the depth buffer is not updated if the depth test is disabled. See glDepthFunc and glDepthRange.
        /// </summary>
        DepthTest = All.DEPTH_TEST,
        /// <summary>
        /// If enabled, dither color components or indices before they are written to the color buffer.
        /// </summary>
        Dither = All.DITHER,
        /// <summary>
        /// If enabled and the value of GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING for the framebuffer attachment corresponding to the destination buffer is GL_SRGB, the R, G, and B destination color values (after conversion from fixed-point to floating-point) are considered to be encoded for the sRGB color space and hence are linearized prior to their use in blending.
        /// </summary>
        FramebufferSRGB = All.FRAMEBUFFER_SRGB,
        /// <summary>
        /// If enabled, draw lines with correct filtering. Otherwise, draw aliased lines. See glLineWidth.
        /// </summary>
        LineSmooth = All.LINE_SMOOTH,
        /// <summary>
        /// If enabled, use multiple fragment samples in computing the final color of a pixel. See glSampleCoverage.
        /// </summary>
        MultiSample = All.MULTISAMPLE,
        /// <summary>
        /// If enabled, and if the polygon is rendered in GL_FILL mode, an offset is added to depth values of a polygon's fragments before the depth comparison is performed. See glPolygonOffset.
        /// </summary>
        PolygonOffsetFill = All.POLYGON_OFFSET_FILL,
        /// <summary>
        /// If enabled, and if the polygon is rendered in GL_LINE mode, an offset is added to depth values of a polygon's fragments before the depth comparison is performed. See glPolygonOffset.
        /// </summary>
        PolygonOffsetLine = All.POLYGON_OFFSET_LINE,
        /// <summary>
        /// If enabled, an offset is added to depth values of a polygon's fragments before the depth comparison is performed, if the polygon is rendered in GL_POINT mode. See glPolygonOffset.
        /// </summary>
        PolygonOffsetPoint = All.POLYGON_OFFSET_POINT,
        /// <summary>
        /// If enabled, draw polygons with proper filtering. Otherwise, draw aliased polygons. For correct antialiased polygons, an alpha buffer is needed and the polygons must be sorted front to back.
        /// </summary>
        PolygonSmooth = All.POLYGON_SMOOTH,
        /// <summary>
        /// Enables primitive restarting. If enabled, any one of the draw commands which transfers a set of generic attribute array elements to the GL will restart the primitive when the index of the vertex is equal to the primitive restart index. See glPrimitiveRestartIndex.
        /// </summary>
        PrimitiveRestart = All.PRIMITIVE_RESTART,
        /// <summary>
        /// Enables primitive restarting with a fixed index. If enabled, any one of the draw commands which transfers a set of generic attribute array elements to the GL will restart the primitive when the index of the vertex is equal to the fixed primitive index for the specified index type. The fixed index is equal to 2n−1 where n is equal to 8 for GL_UNSIGNED_BYTE, 16 for GL_UNSIGNED_SHORT and 32 for GL_UNSIGNED_INT.
        /// </summary>
        PrimitiveRestartFixedIndex = All.PRIMITIVE_RESTART_FIXED_INDEX,
        /// <summary>
        /// If enabled, primitives are discarded after the optional transform feedback stage, but before rasterization. Furthermore, when enabled, glClear, glClearBufferData, glClearBufferSubData, glClearTexImage, and glClearTexSubImage are ignored.
        /// </summary>
        RasterizerDiscard = All.RASTERIZER_DISCARD,
        /// <summary>
        /// If enabled, compute a temporary coverage value where each bit is determined by the alpha value at the corresponding sample location. The temporary coverage value is then ANDed with the fragment coverage value.
        /// </summary>
        SamplaAlphaToCoverage = All.SAMPLE_ALPHA_TO_COVERAGE,
        /// <summary>
        /// If enabled, each sample alpha value is replaced by the maximum representable alpha value.
        /// </summary>
        SamplaAlphaToOne = All.SAMPLE_ALPHA_TO_ONE,
        /// <summary>
        /// If enabled, the fragment's coverage is ANDed with the temporary coverage value. If GL_SAMPLE_COVERAGE_INVERT is set to GL_TRUE, invert the coverage value. See glSampleCoverage.
        /// </summary>
        SampleCoverage = All.SAMPLE_COVERAGE,
        /// <summary>
        /// If enabled, the active fragment shader is run once for each covered sample, or at fraction of this rate as determined by the current value of GL_MIN_SAMPLE_SHADING_VALUE. See glMinSampleShading.
        /// </summary>
        SampleShading = All.SAMPLE_SHADING,
        /// <summary>
        /// If enabled, the sample coverage mask generated for a fragment during rasterization will be ANDed with the value of GL_SAMPLE_MASK_VALUE before shading occurs. See glSampleMaski.
        /// </summary>
        SampleMask = All.SAMPLE_MASK,
        /// <summary>
        /// If enabled, discard fragments that are outside the scissor rectangle. See glScissor.
        /// </summary>
        ScissorTest = All.SCISSOR_TEST,
        /// <summary>
        /// If enabled, do stencil testing and update the stencil buffer. See glStencilFunc and glStencilOp.
        /// </summary>
        StencilTest = All.STENCIL_TEST,
        /// <summary>
        /// If enabled, cubemap textures are sampled such that when linearly sampling from the border between two adjacent faces, texels from both faces are used to generate the final sample value. When disabled, texels from only a single face are used to construct the final sample value.
        /// </summary>
        TextureCubeMapSeamless = All.TEXTURE_CUBE_MAP_SEAMLESS,
        /// <summary>
        /// If enabled and a vertex or geometry shader is active, then the derived point size is taken from the (potentially clipped) shader builtin gl_PointSize and clamped to the implementation-dependent point size range.
        /// </summary>
        ProgramPointSize = All.PROGRAM_POINT_SIZE,

        VertexAttribArrayUnifiedNV = All.VERTEX_ATTRIB_ARRAY_UNIFIED_NV,
        ElementArrayUnifiedNV = All.ELEMENT_ARRAY_UNIFIED_NV,

        //KHR_blend_equation_advanced - part of ARB_ES3_2_compatibility
        /// <summary>
        /// The BLEND_ADVANCED_COHERENT_KHR enable is provided if and only if the KHR_blend_equation_advanced_coherent extension is supported.  On implementations supporting only KHR_blend_equation_advanced, this enable is considered not to exist.
        /// </summary>
        BlendAdvancedCoherent = All.BLEND_ADVANCED_COHERENT_KHR,
        //CoherentAdvancedBlend?

    }
}
