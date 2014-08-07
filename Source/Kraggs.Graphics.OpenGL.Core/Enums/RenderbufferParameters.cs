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
    public enum RenderbufferParameters
    {
        Width = All.RENDERBUFFER_WIDTH,
        Height = All.RENDERBUFFER_HEIGHT,
        InternalFormat = All.RENDERBUFFER_INTERNAL_FORMAT,
        Samples = All.RENDERBUFFER_SAMPLES,
        RedSize = All.RENDERBUFFER_RED_SIZE,
        GreenSize = All.RENDERBUFFER_GREEN_SIZE,
        BlueSize = All.RENDERBUFFER_BLUE_SIZE,
        AlphaSize = All.RENDERBUFFER_ALPHA_SIZE,
        DepthSize = All.RENDERBUFFER_DEPTH_SIZE,
        StencilSize = All.RENDERBUFFER_STENCIL_SIZE,
        TessControlOutputVertices = All.TESS_CONTROL_OUTPUT_VERTICES,
        TessGenMode = All.TESS_GEN_MODE,
        TessGenSpacing = All.TESS_GEN_SPACING,
        TessGenVertexOrder = All.TESS_GEN_VERTEX_ORDER,
        TessGenPointMode = All.TESS_GEN_POINT_MODE,
        ProgramSeparable = All.PROGRAM_SEPARABLE,
        ProgramBinaryLength = All.PROGRAM_BINARY_LENGTH,
        ProgramBinaryRetrievable = All.PROGRAM_BINARY_RETRIEVABLE_HINT,
    }
}
