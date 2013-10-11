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
    [Flags]
    public enum MemoryBarrierFlags
    {
        VertexAttribArray = All.VERTEX_ATTRIB_ARRAY_BARRIER_BIT,
        ElementArray = All.ELEMENT_ARRAY_BARRIER_BIT,
        Uniform = All.UNIFORM_BARRIER_BIT,
        TextureFetch = All.TEXTURE_FETCH_BARRIER_BIT,
        ShaderImageAccess = All.SHADER_IMAGE_ACCESS_BARRIER_BIT,
        Command = All.COMMAND_BARRIER_BIT,
        PixelBuffer = All.PIXEL_BUFFER_BARRIER_BIT,
        TextureUpdate = All.TEXTURE_UPDATE_BARRIER_BIT,
        BufferUpdate = All.BUFFER_UPDATE_BARRIER_BIT,
        Framebuffer = All.FRAMEBUFFER_BARRIER_BIT,
        TransformFeedback = All.TRANSFORM_FEEDBACK_BARRIER_BIT,
        AtomicCounter = All.ATOMIC_COUNTER_BARRIER_BIT,
        ShaderStorage = All.SHADER_STORAGE_BARRIER_BIT,

        AllBarrierBits = All.ALL_BARRIER_BITS,

        IndicesBarrier = ElementArray,

        ClientMappedBuffer = All.CLIENT_MAPPED_BUFFER_BARRIER_BIT,
        QueryBufferBarrier = All.QUERY_BUFFER_BARRIER_BIT,
    }
}
