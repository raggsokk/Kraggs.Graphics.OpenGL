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
    /// Used by GetActiveAtomicCounterBufferiv to retrive atomic counter parameters.
    /// </summary>
    public enum AtomicCounterBufferParameters
    {
        Binding = All.ATOMIC_COUNTER_BUFFER_BINDING,
        DataSize = All.ATOMIC_COUNTER_BUFFER_DATA_SIZE,
        ActiveAtomicCounters = All.ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS,
        ActiveAtomicCounterIndices = All.ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES,

        ReferencedByVertexShader = All.ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER,
        ReferencedByFragmentShader = All.ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER,
        ReferencedByGeometryShader = All.ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER,
        ReferencedByTessControlShader = All.ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER,
        ReferencedByTessEvaluationShader = All.ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER,
        ReferencedByComputeShader = All.ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER,

    }
}
