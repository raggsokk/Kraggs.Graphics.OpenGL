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
    /// Contains the corresponding binding parameter name to BufferTarget.
    /// Basically all buffertargets has a binding parameter name except TextureBuffer.
    /// </summary>
    public enum BufferTargetBinding
    {
        ArrayBinding = All.ARRAY_BUFFER_BINDING,
        AtomicCounterBinding = All.ATOMIC_COUNTER_BUFFER_BINDING,
        CopyReadBinding = All.COPY_READ_BUFFER_BINDING,
        CopyWriteBinding = All.COPY_WRITE_BUFFER_BINDING,
        DrawIndirectBinding = All.DRAW_INDIRECT_BUFFER_BINDING,
        DispatchIndirectBinding = All.DISPATCH_INDIRECT_BUFFER_BINDING,
        ElementArrayBinding = All.ELEMENT_ARRAY_BUFFER_BINDING,
        PixelPackBinding = All.PIXEL_PACK_BUFFER_BINDING,
        PixelUnpackBinding = All.PIXEL_UNPACK_BUFFER_BINDING,
        QueryBinding = All.QUERY_BUFFER_BINDING,
        ShaderStorageBinding = All.SHADER_STORAGE_BUFFER_BINDING,
        //TextureBinding
        UniformBinding = All.UNIFORM_BUFFER_BINDING,

        IndicesArrayBinding = ElementArrayBinding,
    }
}
