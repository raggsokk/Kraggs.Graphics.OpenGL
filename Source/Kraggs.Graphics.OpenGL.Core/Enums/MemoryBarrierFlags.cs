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
    /// Used by MemoryBarrier
    /// </summary>
    [Flags]
    public enum MemoryBarrierFlags
    {
        /// <summary>
        /// If set, vertex data sourced from buffer objects after the barrier will reflect data written by shaders prior to the barrier. The set of buffer objects affected by this bit is derived from the buffer object bindings used for arrays of generic vertex attributes (VERTEX_-ATTRIB_ARRAY_BUFFER bindings).
        /// </summary>
        VertexAttribArray = All.VERTEX_ATTRIB_ARRAY_BARRIER_BIT,
        /// <summary>
        ///  If set, vertex array indices sourced from buffer objects after the barrier will reflect data written by shaders prior to the barrier. The buffer objects affected by this bit are derived from the ELEMENT_ARRAY_BUFFER binding.
        /// </summary>
        ElementArray = All.ELEMENT_ARRAY_BARRIER_BIT,
        /// <summary>
        /// Shader uniforms sourced from buffer objects after the barrier will reflect data written by shaders prior to the barrier.
        /// </summary>
        Uniform = All.UNIFORM_BARRIER_BIT,
        /// <summary>
        /// Texture fetches from shaders, including fetches from buffer object memory via buffer textures, after the barrier will reflect data written by shaders prior to the barrier.
        /// </summary>
        TextureFetch = All.TEXTURE_FETCH_BARRIER_BIT,
        /// <summary>
        /// Memory accesses using shader built-in image load, store, and atomic functions issued after the barrier will reflect data written by shaders prior to the barrier. Additionally, image stores and atomics issued after the barrier will not execute until all memory ac-cesses (e.g., loads, stores, texture fetches, vertex fetches) initiated prior to the barrier complete
        /// </summary>
        ShaderImageAccess = All.SHADER_IMAGE_ACCESS_BARRIER_BIT,
        /// <summary>
        /// Command data sourced from buffer objects by Draw*Indirect and DispatchComputeIndirect commands after the bar-rier will reflect data written by shaders prior to the barrier. The buffer ob-jects affected by this bit are derived from the DRAW_INDIRECT_BUFFER and DISPATCH_INDIRECT_BUFFER bindings
        /// </summary>
        Command = All.COMMAND_BARRIER_BIT,
        /// <summary>
        /// Reads/writes of buffer objects via the PIXEL_PACK_BUFFER and PIXEL_UNPACK_BUFFER bindings (ReadPix-els, TexSubImage, etc.) after the barrier will reflect data written by shaders prior to the barrier. Additionally, buffer object writes issued after the barrier will wait on the completion of all shader writes initiated prior to the barrier
        /// </summary>
        PixelBuffer = All.PIXEL_BUFFER_BARRIER_BIT,
        /// <summary>
        /// Writes to a texture via Tex(Sub)Image*, ClearTex*Image, CopyTex*, or CompressedTex*, and reads via GetTexImage after the barrier will reflect data written by shaders prior to the barrier. Additionally, texture writes from these commands issued after the barrier will not execute until all shader writes initiated prior to the barrier complete
        /// </summary>
        TextureUpdate = All.TEXTURE_UPDATE_BARRIER_BIT,
        /// <summary>
        /// Reads and writes to buffer object mem-ory after the barrier using the commands in sections 6.2, 6.2.1, 6.3, 6.6, and 6.5. will reflect data written by shaders prior to the barrier. Additionally, writes via these commands issued after the barrier will wait on the comple-tion of any shader writes to the same memory initiated prior to the barrier.
        /// </summary>
        BufferUpdate = All.BUFFER_UPDATE_BARRIER_BIT,
        /// <summary>
        /// Reads and writes via framebuffer object at-tachments after the barrier will reflect data written by shaders prior to the barrier. Additionally, framebuffer writes issued after the barrier will wait on the completion of all shader writes issued prior to the barrier.
        /// </summary>
        Framebuffer = All.FRAMEBUFFER_BARRIER_BIT,
        /// <summary>
        /// Writes via transform feedback bindings after the barrier will reflect data written by shaders prior to the barrier. Additionally, transform feedback writes issued after the barrier will wait on the completion of all shader writes issued prior to the barrier.
        /// </summary>
        TransformFeedback = All.TRANSFORM_FEEDBACK_BARRIER_BIT,
        /// <summary>
        /// Accesses to atomic counters after the barrier will reflect writes prior to the barrier
        /// </summary>
        AtomicCounter = All.ATOMIC_COUNTER_BARRIER_BIT,
        /// <summary>
        /// Memory accesses using shader buffer variables issued after the barrier will reflect data written by shaders prior to the barrier. Additionally, assignments to and atomic operations performed on shader buffer variables after the barrier will not execute until all memory accesses (e.g., loads, stores, texture fetches, vertex fetches) initiated prior to the barrier complete
        /// </summary>
        ShaderStorage = All.SHADER_STORAGE_BARRIER_BIT,

        /// <summary>
        /// Access by the client to persis-tent mapped regions of buffer objects will reflect data written by shaders prior to the barrier. Note that this may cause additional synchronization op-erations
        /// </summary>
        ClientMappedBuffer = All.CLIENT_MAPPED_BUFFER_BARRIER_BIT,
        /// <summary>
        /// Writes of buffer objects via the QUERY_-BUFFER binding (see section 4.2.1) after the barrier will reflect data written by shaders prior to the barrier. Additionally, buffer object writes issued after the barrier will wait on the completion of all shader writes initiated prior to the barrier
        /// </summary>
        QueryBufferBarrier = All.QUERY_BUFFER_BARRIER_BIT,

        /// <summary>
        /// NV_shader_buffer_store
        /// </summary>
        ShaderGlobalAccessBarrierNV = All.SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV,

        /// <summary>
        /// If barriers is ALL_BARRIER_BITS, shader memory accesses will be synchronized relative to all the operations described above.
        /// </summary>
        AllBarrierBits = All.ALL_BARRIER_BITS,







        /// <summary>
        /// If set, vertex array indices sourced from buffer objects after the barrier will reflect data written by shaders prior to the barrier. The buffer objects affected by this bit are derived from the ELEMENT_ARRAY_BUFFER binding.
        /// </summary>
        IndicesBarrier = ElementArray,

    }
}
