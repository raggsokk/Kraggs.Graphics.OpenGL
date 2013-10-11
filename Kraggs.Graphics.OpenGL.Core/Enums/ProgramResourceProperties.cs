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
    public enum ProgramResourceProperties
    {
        NameLength = All.NAME_LENGTH,
        Type = All.TYPE,
        ArraySize = All.ARRAY_SIZE,
        Offset = All.OFFSET,
        BlockIndex = All.BLOCK_INDEX,
        ArrayStride = All.ARRAY_STRIDE,
        MatrixStride = All.MATRIX_STRIDE,
        IsRowMajor = All.IS_ROW_MAJOR,
        AtomicCounterBufferIndex = All.ATOMIC_COUNTER_BUFFER_INDEX,
        BufferBinding = All.BUFFER_BINDING,
        BufferDataSize = All.BUFFER_DATA_SIZE,
        NumActiveVariables = All.NUM_ACTIVE_VARIABLES,
        ActiveVariables = All.ACTIVE_VARIABLES,

        ReferencedByVertexShader = All.REFERENCED_BY_VERTEX_SHADER,
        ReferencedByFragmentShader = All.REFERENCED_BY_FRAGMENT_SHADER,
        ReferencedByGeometryShader = All.REFERENCED_BY_GEOMETRY_SHADER,
        ReferencedByTessControlShader = All.REFERENCED_BY_TESS_CONTROL_SHADER,
        ReferencedByTessEvaluationShader = All.REFERENCED_BY_TESS_EVALUATION_SHADER,
        ReferencedByComputeShader = All.REFERENCED_BY_COMPUTE_SHADER,

        NumCompatibleSubroutines = All.NUM_COMPATIBLE_SUBROUTINES,
        CompatibleSubroutines = All.COMPATIBLE_SUBROUTINES,
        TopLevelArraySize = All.TOP_LEVEL_ARRAY_SIZE,
        TopLevelArrayStride = All.TOP_LEVEL_ARRAY_STRIDE,

        Location = All.LOCATION,
        LocationIndex = All.LOCATION_INDEX,
        IsPerPatch = All.IS_PER_PATCH,

        LocationComponent = All.LOCATION_COMPONENT,
        TransformFeedbackBufferIndex = All.TRANSFORM_FEEDBACK_BUFFER_INDEX,
        TransformFeedbackBufferStride = All.TRANSFORM_FEEDBACK_BUFFER_STRIDE,
    }
}
