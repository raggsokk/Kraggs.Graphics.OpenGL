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
    /// 
    /// </summary>
    public enum QueryTarget
    {
        /// <summary>
        /// If target is GL_SAMPLES_PASSED, id must be an unused name, or the name of an existing occlusion query object. When glBeginQueryIndexed is executed, the query object's samples-passed counter is reset to 0. Subsequent rendering will increment the counter for every sample that passes the depth test. If the value of GL_SAMPLE_BUFFERS is 0, then the samples-passed count is incremented by 1 for each fragment. If the value of GL_SAMPLE_BUFFERS is 1, then the samples-passed count is incremented by the number of samples whose coverage bit is set. However, implementations, at their discression may instead increase the samples-passed count by the value of GL_SAMPLES if any sample in the fragment is covered. When glEndQueryIndexed is executed, the samples-passed counter is assigned to the query object's result value. This value can be queried by calling glGetQueryObject with pname GL_QUERY_RESULT. When target is GL_SAMPLES_PASSED, index must be zero.
        /// </summary>
        SamplesPassed = All.SAMPLES_PASSED,
        /// <summary>
        /// If target is GL_ANY_SAMPLES_PASSED, id must be an unused name, or the name of an existing boolean occlusion query object. When glBeginQueryIndexed is executed, the query object's samples-passed flag is reset to GL_FALSE. Subsequent rendering causes the flag to be set to GL_TRUE if any sample passes the depth test. When glEndQueryIndexed is executed, the samples-passed flag is assigned to the query object's result value. This value can be queried by calling glGetQueryObject with pname GL_QUERY_RESULT. When target is GL_ANY_SAMPLES_PASSED, index must be zero.
        /// </summary>
        AnySamplesPassed = All.ANY_SAMPLES_PASSED,

        AnySamplesPassedConservative = All.ANY_SAMPLES_PASSED_CONSERVATIVE,
        /// <summary>
        /// If target is GL_PRIMITIVES_GENERATED, id must be an unused name, or the name of an existing primitive query object previously bound to the GL_PRIMITIVES_GENERATED query binding. When glBeginQueryIndexed is executed, the query object's primitives-generated counter is reset to 0. Subsequent rendering will increment the counter once for every vertex that is emitted from the geometry shader to the stream given by index, or from the vertex shader if index is zero and no geometry shader is present. When glEndQueryIndexed is executed, the primitives-generated counter for stream index is assigned to the query object's result value. This value can be queried by calling glGetQueryObject with pname GL_QUERY_RESULT. When target is GL_PRIMITIVES_GENERATED, index must be less than the value of GL_MAX_VERTEX_STREAMS.
        /// </summary>
        PrimitivesGenerated = All.PRIMITIVES_GENERATED,
        /// <summary>
        /// If target is GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, id must be an unused name, or the name of an existing primitive query object previously bound to the GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN query binding. When glBeginQueryIndexed is executed, the query object's primitives-written counter for the stream specified by index is reset to 0. Subsequent rendering will increment the counter once for every vertex that is written into the bound transform feedback buffer(s) for stream index. If transform feedback mode is not activated between the call to glBeginQueryIndexed and glEndQueryIndexed, the counter will not be incremented. When glEndQueryIndexed is executed, the primitives-written counter for stream index is assigned to the query object's result value. This value can be queried by calling glGetQueryObject with pname GL_QUERY_RESULT. When target is GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, index must be less than the value of GL_MAX_VERTEX_STREAMS.
        /// </summary>
        TransformFeedbackPrimitivesWritten = All.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN,
        /// <summary>
        /// If target is GL_TIME_ELAPSED, id must be an unused name, or the name of an existing timer query object previously bound to the GL_TIME_ELAPSED query binding. When glBeginQueryIndexed is executed, the query object's time counter is reset to 0. When glEndQueryIndexed is executed, the elapsed server time that has passed since the call to glBeginQueryIndexed is written into the query object's time counter. This value can be queried by calling glGetQueryObject with pname GL_QUERY_RESULT. When target is GL_TIME_ELAPSED, index must be zero.
        /// </summary>
        TimeElapsed = All.TIME_ELAPSED,

        //ARB_pipeline_statistics_query
        VerticesSubmitted = All.VERTICES_SUBMITTED_ARB,
        PrimitivesSubmitted = All.PRIMITIVES_SUBMITTED_ARB,
        VertexShaderInvocations = All.VERTEX_SHADER_INVOCATIONS_ARB,
        TessControlShaderPatches = All.TESS_CONTROL_SHADER_PATCHES_ARB,
        TessEvaluationShaderInvocations = All.TESS_EVALUATION_SHADER_INVOCATIONS_ARB,
        GeometryShaderInvocations = All.GEOMETRY_SHADER_INVOCATIONS,
        GeometryShaderPrimitivesEmitted = All.GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB,
        FragmentShaderInvocations = All.FRAGMENT_SHADER_INVOCATIONS_ARB,
        ComputeShaderInvocations = All.COMPUTE_SHADER_INVOCATIONS_ARB,
        ClippingInputPrimitives = All.CLIPPING_INPUT_PRIMITIVES_ARB,
        ClippingOutputPrimitives = All.CLIPPING_OUTPUT_PRIMITIVES_ARB,

    }
}
