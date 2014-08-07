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
    public enum ProgramInterface
    {
        Uniform = All.UNIFORM,
        UniformBlock = All.UNIFORM_BLOCK,
        ProgramInput = All.PROGRAM_INPUT,
        ProgramOutput = All.PROGRAM_OUTPUT,
        BufferVariable = All.BUFFER_VARIABLE,
        ShaderStorageBlock = All.SHADER_STORAGE_BLOCK,
        AtomicCounterBuffer = All.ATOMIC_COUNTER_BUFFER,
        VertexSubroutine = All.VERTEX_SUBROUTINE,
        TessControlSubroutine = All.TESS_CONTROL_SUBROUTINE,
        TessEvaluationSubroutine = All.TESS_EVALUATION_SUBROUTINE,
        GeometrySubroutine = All.GEOMETRY_SUBROUTINE,        
        FragmentSubroutine = All.FRAGMENT_SUBROUTINE,
        ComputeSubroutine = All.COMPUTE_SUBROUTINE,
        
        VertexSubroutineUniform = All.VERTEX_SUBROUTINE_UNIFORM,
        TessControlSubroutineUniform = All.TESS_CONTROL_SUBROUTINE_UNIFORM,
        TessEvaluationSubroutineUniform = All.TESS_EVALUATION_SUBROUTINE_UNIFORM,
        GeometrySubroutineUniform = All.GEOMETRY_SUBROUTINE_UNIFORM,
        FragmentSubroutineUniform = All.FRAGMENT_SUBROUTINE_UNIFORM,
        ComputeSubroutineUniform = All.COMPUTE_SUBROUTINE_UNIFORM,


        TransformFeedbackVarying = All.TRANSFORM_FEEDBACK_VARYING,
        TransformFeedbackBuffer = All.TRANSFORM_FEEDBACK_BUFFER,
    }
}
