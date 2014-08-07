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
    public enum GetProgramParameters
    {
        DeleteStatus = All.DELETE_STATUS,
        LinkStatus = All.LINK_STATUS,
        Validate = All.VALIDATE_STATUS,
        InfoLogLength = All.INFO_LOG_LENGTH,
        AttachedShaders = All.ATTACHED_SHADERS,
        ActiveUniforms = All.ACTIVE_UNIFORMS,
        ActiveAttributes = All.ACTIVE_ATTRIBUTES,
        ActiveAttributesMaxLength = All.ACTIVE_ATTRIBUTE_MAX_LENGTH,
        ActiveUniformBlocks = All.ACTIVE_UNIFORM_BLOCKS,
        ActiveUniformMaxLength = All.ACTIVE_UNIFORM_MAX_LENGTH,
        ActiveUniformBlockMaxNameLength = All.ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH,
        ActiveAtomicCounterBuffers = All.ACTIVE_ATOMIC_COUNTER_BUFFERS,
        TransformFeedbackBufferMode = All.TRANSFORM_FEEDBACK_BUFFER_MODE,
        TransformFeedbackVaryings = All.TRANSFORM_FEEDBACK_VARYINGS,
        TransformFeedbackVaryingMaxLength = All.TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH,
        GeometryInputType = All.GEOMETRY_INPUT_TYPE,
        GeometryOutputType = All.GEOMETRY_OUTPUT_TYPE,
        //ComputeWorkGroupSize = All.COMPUTE_WORK_GROUP_SIZE
        GeometryShaderInvocations = All.GEOMETRY_SHADER_INVOCATIONS,
        GeometryVerticesOut = All.GEOMETRY_VERTICES_OUT,

        TessControlOutputVertices = All.TESS_CONTROL_OUTPUT_VERTICES,
        /// <summary>
        /// Returned by GetProgramiv when <pname> is TESS_GEN_MODE: TRIANGLES, QUADS, ISOLINES
        /// </summary>
        TessGenMode = All.TESS_GEN_MODE,

        /// <summary>
        /// Returned by GetProgramiv when <pname> is TESS_GEN_SPACING: EQUAL, FRACTIONAL_ODD, FRACTIONAL_EVEN
        /// </summary>
        TessGenSpacing = All.TESS_GEN_SPACING,

        /// <summary>
        /// Returned by GetProgramiv when <pname> is TESS_GEN_VERTEX_ORDER: CCW, CW
        /// </summary>
        TessGenVertexOrder = All.TESS_GEN_VERTEX_ORDER,

        /// <summary>
        /// Returned by GetProgramiv when <pname> is TESS_GEN_POINT_MODE: FALSE, TRUE
        /// </summary>
        TessGenPointMode = All.TESS_GEN_POINT_MODE,

        ProgramBinaryLength = All.PROGRAM_BINARY_LENGTH,
        ProgramSeparable = All.PROGRAM_SEPARABLE,

        ComputeWorkGroupSize = All.COMPUTE_WORK_GROUP_SIZE,

    }
}
