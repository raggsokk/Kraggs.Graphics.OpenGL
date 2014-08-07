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
    public enum BufferTarget
    {
        ArrayBuffer = All.ARRAY_BUFFER,
        AtomicCounterBuffer = All.ATOMIC_COUNTER_BUFFER,
        CopyReadBuffer = All.COPY_READ_BUFFER,
        CopyWriteBuffer = All.COPY_WRITE_BUFFER,
        DrawIndirectBuffer = All.DRAW_INDIRECT_BUFFER,
        DispatchIndirectBuffer = All.DISPATCH_INDIRECT_BUFFER,
        ElementArrayBuffer = All.ELEMENT_ARRAY_BUFFER,
        PixelPackBuffer = All.PIXEL_PACK_BUFFER,
        PixelUnpackBuffer = All.PIXEL_UNPACK_BUFFER,
        ShaderStorageBuffer = All.SHADER_STORAGE_BUFFER,
        TextureBuffer = All.TEXTURE_BUFFER,
        TransformFeedbackBuffer = All.TRANSFORM_FEEDBACK_BUFFER,
        UniformBuffer = All.UNIFORM_BUFFER,

        IndicesArrayBuffer = ElementArrayBuffer,

        QueryBuffer = All.QUERY_BUFFER,
    }
}
