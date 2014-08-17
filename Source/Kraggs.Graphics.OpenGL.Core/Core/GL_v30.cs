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
    
    partial class GL
    {
        #region OpenGL DLLImports

        //APPLE_flush_buffer_range/ARB_map_buffer_range
        [EntryPointSlot(166)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFlushMappedBufferRange(BufferTarget target, IntPtr Offset, IntPtr Length);
        [EntryPointSlot(167)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern IntPtr glMapBufferRange(BufferTarget target, IntPtr Offset, IntPtr Length, MapBufferRangeAccessFlags access);

        //ARB_vertex_array_object
        [EntryPointSlot(224)] // forgot this. 
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGenVertexArrays(int number, uint* Arrays);
        [EntryPointSlot(168)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glDeleteVertexArrays(int number, uint* Arrays);
        [EntryPointSlot(169)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindVertexArray(uint Array);
        [EntryPointSlot(170)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsVertexArray(uint Array);

        //ARB_color_buffer_float
        [EntryPointSlot(171)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glClampColor(ClampColorTarget target, ClampColorMode mode);

        //ARB_framebuffer_object
        // render buffers
        [EntryPointSlot(172)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGenRenderbuffers(int number, uint* Renderbuffers);
        [EntryPointSlot(173)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glDeleteRenderbuffers(int number, uint* Renderbuffers);
        [EntryPointSlot(174)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindRenderbuffer(RenderbufferTarget target, uint Renderbuffer);
        [EntryPointSlot(175)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsRenderbuffer(uint Renderbuffer);

        [EntryPointSlot(176)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glRenderbufferStorage(RenderbufferTarget target, RenderbufferStorageFormat iformat, int width, int height);

        [EntryPointSlot(177)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindFramebuffer(FramebufferTarget target, uint Framebuffer);
        [EntryPointSlot(178)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGenFramebuffers(int number, uint* Framebuffers);
        [EntryPointSlot(179)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glDeleteFramebuffers(int number, uint* Framebuffers);
        [EntryPointSlot(180)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsFramebuffer(uint Framebuffer);
        //framebuferparameteri

        [EntryPointSlot(181)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferRenderbuffer(FramebufferTarget ftarget, FramebufferAttachmentType attachment, RenderbufferTarget rtarget, uint Renderbuffer);


        [EntryPointSlot(182)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferTexture1D(FramebufferTarget target, FramebufferAttachmentType attachment, TextureTarget texTarget1D, uint TextureID, int Level);
        [EntryPointSlot(183)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferTexture2D(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, TextureTarget texTarget2D, uint TextureID, int level);
        [EntryPointSlot(184)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferTexture3D(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, TextureTarget texTarget3D, uint TextureID, int level, int layer);

        [EntryPointSlot(185)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern FramebufferStatus glCheckFramebufferStatus(FramebufferTarget fboTarget);

        [EntryPointSlot(186)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetFramebufferAttachmentParameteriv(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, AttachmentParameters pname, int* result);
        [EntryPointSlot(187)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetRenderbufferParameteriv(RenderbufferTarget rTarget, RenderbufferParameters pname, int* result);

        [EntryPointSlot(188)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGenerateMipmap(TextureTarget target);


        //EXT_draw_buffers2
        [EntryPointSlot(189)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glColorMaski(DrawBufferTarget drawbuffer, bool red, bool green, bool blue, bool alpha);

        [EntryPointSlot(190)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDisablei(EnableStateIndexed cap, uint index);
        [EntryPointSlot(191)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glEnablei(EnableStateIndexed cap, uint index);

        [EntryPointSlot(192)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetBooleani_v(GetParameters pname, uint index, bool* data);
        [EntryPointSlot(193)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetIntegeri_v(GetParameters pname, uint index, int* data);

        [EntryPointSlot(194)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsEnabledi(EnableStateIndexed cap, uint index);

        //EXT_framebuffer_blit
        [EntryPointSlot(195)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferFlags mask, BlitFramebufferFilter filter);

        //EXT_framebuffer_multisample
        [EntryPointSlot(196)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glRenderbufferStorageMultisample(RenderbufferTarget target, int samples, RenderbufferStorageFormat iformat, int width, int height);


        //EXT_gpu_shader4
        [EntryPointSlot(197)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindFragDataLocation(uint Program, DrawBufferTarget colorNumber, string Name);
        [EntryPointSlot(198)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern int glGetFragDataLocation(uint Program, string Name);

        [EntryPointSlot(199)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetUniformuiv(uint Program, int location, uint* result);

        [EntryPointSlot(200)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexAttribIPointer(uint index, int size, VertexAttribIFormat iType, int stride, IntPtr ptr);

        [EntryPointSlot(201)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetVertexAttribIiv(uint index, VertexAttribParameters pname, int* result);
        [EntryPointSlot(202)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetVertexAttribIuiv(uint index, VertexAttribParameters pname, uint* result);

        [EntryPointSlot(203)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform1ui(int location, uint v1);
        [EntryPointSlot(204)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform2ui(int location, uint v1, uint v2);
        [EntryPointSlot(205)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform3ui(int location, uint v1, uint v2, uint v3);
        [EntryPointSlot(206)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform4ui(int location, uint v1, uint v2, uint v3, uint v4);

        [EntryPointSlot(207)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform1uiv(int location, int count, uint* v);
        [EntryPointSlot(208)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform2uiv(int location, int count, uint* v);
        [EntryPointSlot(209)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform3uiv(int location, int count, uint* v);
        [EntryPointSlot(210)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform4uiv(int location, int count, uint* v);

        /* 16 functions ignored.
        private static extern void glVertexAttribI1i(int index, int v1);
        private static extern void glVertexAttribI2i(int index, int v1, int v2);
        private static extern void glVertexAttribI3i(int index, int v1, int v2, int v3);
        private static extern void glVertexAttribI4i(int index, int v1, int v2, int v3, int v4);

        private static extern void glVertexAttribI1ui(int index, uint v1);
        private static extern void glVertexAttribI2ui(int index, uint v1, uint v2);
        private static extern void glVertexAttribI3ui(int index, uint v1, uint v2, uint v3);
        private static extern void glVertexAttribI4ui(int index, uint v1, uint v2, uint v3, uint v4);

        private static extern void glVertexAttribI1iv(int index, ref int v);
        private static extern void glVertexAttribI2iv(int index, ref int v);
        private static extern void glVertexAttribI3iv(int index, ref int v);
        private static extern void glVertexAttribI4iv(int index, ref int v);

        private static extern void glVertexAttribI1uiv(int index, ref uint v);
        private static extern void glVertexAttribI2uiv(int index, ref uint v);
        private static extern void glVertexAttribI3uiv(int index, ref uint v);
        private static extern void glVertexAttribI4uiv(int index, ref uint v);
        */

        //EXT_texture_integer
        [EntryPointSlot(211)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTexParameterIiv(TextureTarget target, TextureParameters pname, int* data);
        [EntryPointSlot(212)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTexParameterIuiv(TextureTarget target, TextureParameters pname, uint* data);

        [EntryPointSlot(213)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glTexParameterIiv(TextureTarget target, TextureParameters pname, int* data);
        [EntryPointSlot(214)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glTexParameterIuiv(TextureTarget target, TextureParameters pname, uint* data);


        //EXT_transform_feedback/NV_transform_feedback
        [EntryPointSlot(215)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindBufferRange(BufferProgramTarget target, uint bindingIndex, uint BufferId, IntPtr Offset, IntPtr Size);
        [EntryPointSlot(216)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindBufferBase(BufferProgramTarget target, uint bindingIndex, uint BufferId);

        [EntryPointSlot(217)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBeginTransformFeedback(BeginMode primitiveMode);
        [EntryPointSlot(218)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glEndTransformFeedback();
        [EntryPointSlot(219)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTransformFeedbackVaryings(uint Program, int count, string[] varyings, TransformFeedbackAttributeMode bufferMode);
        [EntryPointSlot(220)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetTransformFeedbackVarying(uint Program, uint index, int bufSize, out int length, out int size, out AttributeType type, IntPtr name);

        //NV_conditional_render
        [EntryPointSlot(221)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBeginConditionalRender(uint id, ConditionalRenderType mode);
        [EntryPointSlot(222)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glEndConditionalRender();

        // glGetStringi ?? added here.
        [EntryPointSlot(223)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern IntPtr glGetStringi(StringName name, uint index);


        #endregion

        #region Public functions

        //APPLE_flush_buffer_range/ARB_map_buffer_range
        /// <summary>
        /// Flushes a sub region of a mapped buffer region.
        /// </summary>
        /// <param name="target">Buffertarget to flush.</param>
        /// <param name="Offset">Offset in bytes to flush</param>
        /// <param name="Length">Length in bytes from offset.</param>
        [EntryPoint(FunctionName = "glFlushMappedBufferRange")]
        public static void FlushMappedBufferRange(BufferTarget target, IntPtr Offset, IntPtr Length){ throw new NotImplementedException(); }
        /// <summary>
        /// Flushes a sub region of a mapped buffer region.
        /// </summary>
        /// <param name="target">Buffertarget to flush.</param>
        /// <param name="Offset">Offset in bytes to flush</param>
        /// <param name="Length">Length in bytes from offset.</param>
        public static void FlushMappedBufferRange(BufferTarget target, long Offset, long Length)
        {
            FlushMappedBufferRange(target, (IntPtr)Offset, (IntPtr)Length);
        }

        /// <summary>
        /// Maps a region/range of a buffer.
        /// </summary>
        /// <param name="target">Buffertarget containing buffer to map.</param>
        /// <param name="Offset">Offset in bytes from start of buffer to start of region/range to map.</param>
        /// <param name="Length">Length in bytes from start of region/range.</param>
        /// <param name="access">Desired access pattern of this mapping.</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glMapBufferRange")]
        public static IntPtr MapBufferRange(BufferTarget target, IntPtr Offset, IntPtr Length, MapBufferRangeAccessFlags access){ throw new NotImplementedException(); }

        /// <summary>
        /// Maps a region/range of a buffer.
        /// </summary>
        /// <param name="target">Buffertarget containing buffer to map.</param>
        /// <param name="Offset">Offset in bytes from start of buffer to start of region/range to map.</param>
        /// <param name="Length">Length in bytes from start of region/range.</param>
        /// <param name="access">Desired access pattern of this mapping.</param>
        /// <returns></returns>
        public static IntPtr MapBufferRange(BufferTarget target, long Offset, long Length, MapBufferRangeAccessFlags access)
        {
            return MapBufferRange(target, (IntPtr)Offset, (IntPtr)Length, access);
        }

        //ARB_vertex_array_object
        /// <summary>
        /// Generates a number of vertex array objects.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="Array">array to receive vao ids</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGenVertexArrays")]
        unsafe public static void GenVertexArrays(int number, uint* Arrays){ throw new NotImplementedException(); }
        /// <summary>
        /// Generates a number of vertex array objects.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="Array">array to receive vao ids</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGenVertexArrays")]
        public static void GenVertexArrays(int number, ref uint Array) { throw new NotImplementedException(); }

        /// <summary>
        /// Generates a number of vertex array objects.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static uint[] GenVertexArrays(int number)
        {
            var t = new uint[number];
            GenVertexArrays(t.Length, ref t[0]);
            return t;
        }
        /// <summary>
        /// Generates a vertex array object id.
        /// </summary>
        /// <returns>a new vertex array object id or 0 if it failed.</returns>        
        public static uint GenVertexArrays()
        {
            uint t = 0;
            GenVertexArrays(1, ref t);
            return t;
        }
        /// <summary>
        /// Generates an array of vertex array objects.
        /// </summary>
        /// <param name="Arrays">Precreated Array to fill with vertex array objects.</param>
        public static void GenVertexArrays(uint[] Arrays)
        {
            GenVertexArrays(Arrays.Length, ref Arrays[0]);
        }
        /// <summary>
        /// Deletes an array of vertex array objects.
        /// </summary>
        /// <param name="number">size of array.</param>
        /// <param name="Arrays"></param>
        [EntryPoint(FunctionName = "glDeleteVertexArrays")]
        unsafe public static void DeleteVertexArrays(int number, uint* Arrays){ throw new NotImplementedException(); }
        /// <summary>
        /// Deletes an array of vertex array objects.
        /// </summary>
        /// <param name="number">size of array.</param>
        /// <param name="Arrays"></param>
        [EntryPoint(FunctionName = "glDeleteVertexArrays")]
        public static void DeleteVertexArrays(int number, ref uint Arrays) { throw new NotImplementedException(); }
        /// <summary>
        /// Deletes an array of vertex array objects.
        /// </summary>
        /// <param name="Arrays"></param>
        public static void DeleteVertexArrays(uint[] Arrays)
        {
            DeleteVertexArrays(Arrays.Length, ref Arrays[0]);
        }
        /// <summary>
        /// Deletes a single vertex array object.
        /// </summary>
        /// <param name="Array"></param>
        public static void DeleteVertexArrays(uint Array)
        {
            DeleteVertexArrays(1, ref Array);
        }

        /// <summary>
        /// Binds this vertex array object as current.
        /// Or if called with Array=0, binds none as current.
        /// </summary>
        /// <param name="Array"></param>
        [EntryPoint(FunctionName = "glBindVertexArray")]
        public static void BindVertexArray(uint Array){ throw new NotImplementedException(); }
        /// <summary>
        /// Is this a vertex array object?
        /// </summary>
        /// <param name="Array"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glIsVertexArray")]
        public static bool IsVertexArray(uint Array){ throw new NotImplementedException(); }

        //ARB_color_buffer_float
        [EntryPoint(FunctionName = "glClampColor")]
        public static void ClampColor(ClampColorTarget target, ClampColorMode mode){ throw new NotImplementedException(); }

        //ARB_framebuffer_object
        // render buffers
        /// <summary>
        /// Generates a number of renderbuffers.
        /// </summary>
        /// <param name="number">size of array</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGenRenderbuffers")]
        unsafe public static void GenRenderbuffers(int number, uint* Renderbuffers){ throw new NotImplementedException(); }
        /// <summary>
        /// Generates a number of renderbuffers.
        /// </summary>
        /// <param name="number">size of array</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGenRenderbuffers")]
        public static void GenRenderbuffers(int number, ref uint Renderbuffers) { throw new NotImplementedException(); }

        /// <summary>
        /// Generates a number of renderbuffers.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static uint[] GenRenderbuffers(int number)
        {
            var t = new uint[number];
            GenRenderbuffers(t.Length, ref t[0]);
            return t;
        }
        /// <summary>
        /// Generates a single renderbuffer.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static uint GenRenderbuffers()
        {
            uint t = 0;
            GenRenderbuffers(1, ref t);
            return t;
        }
        
        /// <summary>
        /// Generates an array of renderbuffer ids.
        /// </summary>
        /// <param name="Renderbuffers">Preallocated array where new renderbuffer ids is written.</param>
        public static void GenRenderbuffers(uint[] Renderbuffers)
        {
            GenRenderbuffers(Renderbuffers.Length, ref Renderbuffers[0]);
        }

        /// <summary>
        /// Deletes an array of renderbuffers.
        /// </summary>
        /// <param name="Renderbuffers"></param>
        /// <param name="number">Array size</param>
        [EntryPoint(FunctionName = "glDeleteRenderbuffers")]
        unsafe public static void DeleteRenderbuffers(int number, uint* Renderbuffers){ throw new NotImplementedException(); }
        /// <summary>
        /// Deletes an array of renderbuffers.
        /// </summary>
        /// <param name="Renderbuffers"></param>
        /// <param name="number">Array size</param>
        [EntryPoint(FunctionName = "glDeleteRenderbuffers")]
        public static void DeleteRenderbuffers(int number, ref uint Renderbuffers) { throw new NotImplementedException(); }
        /// <summary>
        /// Deletes an array of renderbuffers.
        /// </summary>
        /// <param name="Renderbuffers"></param>
        public static void DeleteRenderbuffers(uint[] Renderbuffers)
        {
            DeleteRenderbuffers(Renderbuffers.Length, ref Renderbuffers[0]);
        }
        /// <summary>
        /// Deletes a single renderbuffer.
        /// </summary>
        /// <param name="Renderbuffer"></param>
        public static void DeleteRenderbuffers(uint Renderbuffer)
        {
            DeleteRenderbuffers(1, ref Renderbuffer);
        }


        /// <summary>
        /// Binds the specified renderbuffer to the current framebuffer object.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="Renderbuffer"></param>
        [EntryPoint(FunctionName = "glBindRenderbuffer")]
        private static void BindRenderbuffer(RenderbufferTarget target, uint Renderbuffer){ throw new NotImplementedException(); }
        /// <summary>
        /// Binds the specified renderbuffer to the current framebuffer object.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="Renderbuffer"></param>
        public static void BindRenderbuffer(uint Renderbuffer, RenderbufferTarget target = RenderbufferTarget.Renderbuffer)
        {
            BindRenderbuffer(target, Renderbuffer);
        }
        /// <summary>
        /// Is this a renderbuffer?
        /// </summary>
        /// <param name="Renderbuffer"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glIsRenderbuffer")]
        public static bool IsRenderbuffer(uint Renderbuffer){ throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glRenderbufferStorage")]
        private static void RenderbufferStorage(RenderbufferTarget target, RenderbufferStorageFormat iformat, int width, int height){ throw new NotImplementedException(); }
        /// <summary>
        /// Allocates renderbuffer storage format and dimension.
        /// </summary>
        /// <param name="target">RenderbufferTarget</param>
        /// <param name="iformat">Format of renderbuffer.</param>
        /// <param name="width">width of renderbuffer.</param>
        /// <param name="height">height of renderbuffer.</param>
        public static void RenderbufferStorage(RenderbufferStorageFormat iformat, int width, int height, RenderbufferTarget target = RenderbufferTarget.Renderbuffer)
        {
            RenderbufferStorage(target, iformat, width, height);
        }

        /// <summary>
        /// Binds the specified framebuffer id as current at framebuffertarget.
        /// </summary>
        /// <param name="target">The target to bind framebuffer id at.</param>
        /// <param name="Framebuffer">The id of the framebuffer to bind.</param>
        [EntryPoint(FunctionName = "glBindFramebuffer")]
        public static void BindFramebuffer(FramebufferTarget target, uint Framebuffer){ throw new NotImplementedException(); }

        /// <summary>
        /// Generates an array of frambuffer objects.
        /// </summary>
        /// <param name="Framebuffers">Preallocated array where framebuffer ids is written to.</param>
        /// <param name="number">Size of array.</param>
        [EntryPoint(FunctionName = "glGenFramebuffers")]
        unsafe public static void GenFramebuffers(int number, uint* Framebuffers){ throw new NotImplementedException(); }
        /// <summary>
        /// Generates an array of frambuffer objects.
        /// </summary>
        /// <param name="Framebuffers">Preallocated array where framebuffer ids is written to.</param>
        /// <param name="number">Size of array.</param>
        [EntryPoint(FunctionName = "glGenFramebuffers")]
        public static void GenFramebuffers(int number, ref uint Framebuffers) { throw new NotImplementedException(); }
        /// <summary>
        /// Generates a frambuffer object.
        /// </summary>
        /// <param name="Framebuffers">Preallocated array where framebuffer ids is written to.</param>        
        public static uint GenFramebuffers()
        {
            uint t = 0;
            GenFramebuffers(1, ref t);
            return t;
        }
        /// <summary>
        /// Generates an array of frambuffer objects.
        /// </summary>
        /// <param name="Framebuffers">Preallocated array where framebuffer ids is written to.</param>
        public static void GenFramebuffers(uint[] Framebuffers)
        {
            GenFramebuffers(Framebuffers.Length, ref Framebuffers[0]);
        }

        /// <summary>
        /// Generates an array of frambuffer objects.
        /// </summary>
        public static uint[] GenFramebuffers(int number)
        {
            var t = new uint[number];
            GenFramebuffers(t.Length, ref t[0]);
            return t;
        }

        /// <summary>
        /// Deletes an array of framebuffers.
        /// </summary>
        /// <param name="Framebuffers">Array containing framebuffer ids to delete.</param>
        /// <param name="number">Size of Array.</param>
        [EntryPoint(FunctionName = "glDeleteFramebuffers")]
        unsafe public static void DeleteFramebuffers(int number, uint* Framebuffers){ throw new NotImplementedException(); }
        /// <summary>
        /// Deletes an array of framebuffers.
        /// </summary>
        /// <param name="Framebuffers">Array containing framebuffer ids to delete.</param>
        /// <param name="number">Size of Array.</param>
        [EntryPoint(FunctionName = "glDeleteFramebuffers")]
        unsafe public static void DeleteFramebuffers(int number, ref uint Framebuffers) { throw new NotImplementedException(); }
        /// <summary>
        /// Deletes an array of framebuffers.
        /// </summary>
        /// <param name="Framebuffers">Array containing framebuffer ids to delete.</param>
        public static void DeleteFramebuffers(uint[] Framebuffers)
        {
            DeleteFramebuffers(Framebuffers.Length, ref Framebuffers[0]);
        }
        /// <summary>
        /// Deletes a single frambuffer id.
        /// </summary>
        /// <param name="Framebuffer"></param>
        public static void DeleteFramebuffers(uint Framebuffer)
        {
            DeleteFramebuffers(1, ref Framebuffer);
        }

        /// <summary>
        /// Is this a framebuffer?
        /// </summary>
        /// <param name="Framebuffer"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glIsFramebuffer")]
        public static bool IsFramebuffer(uint Framebuffer){ throw new NotImplementedException(); }
        //framebuferparameteri


        [EntryPoint(FunctionName = "glFramebufferRenderbuffer")]
        private static void FramebufferRenderbuffer(FramebufferTarget ftarget, FramebufferAttachmentType attachment, RenderbufferTarget rtarget, uint Renderbuffer){ throw new NotImplementedException(); }
        /// <summary>
        /// Attaches a renderbuffer to the framebuffer bound at specified target.
        /// </summary>
        /// <param name="ftarget">Framebuffer target containg framebuffer to bind to.</param>
        /// <param name="attachment">Attachment point of framebuffer to bind as.</param>
        /// <param name="rtarget">Renderbuffer target.</param>
        /// <param name="Renderbuffer">Randerbuffer id to bind.</param>
        public static void FramebufferRenderbuffer(FramebufferTarget ftarget, FramebufferAttachmentType attachment, uint Renderbuffer, RenderbufferTarget rtarget = RenderbufferTarget.Renderbuffer)
        {
            FramebufferRenderbuffer(ftarget, attachment, rtarget, Renderbuffer);
        }

        /// <summary>
        /// Attaches a texture mipmap level to framebuffer currently bound at specified framebuffertarget to specified attachment point.
        /// </summary>
        /// <param name="target">Framebuffertarget with bound framebuffer to attach to.</param>
        /// <param name="attachment">Attachment point to bind texture mipmap level to.</param>
        /// <param name="texTarget1D">Texturetarget to treat texture id as.</param>
        /// <param name="TextureID">texture id of texture mipmap level to attach.</param>
        /// <param name="Level">The texture mipmap level to attach.</param> 
        /// <remarks>
        /// glFramebufferTexture, glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture attach a selected mipmap level or image of a texture object as one of the logical buffers of the framebuffer object currently bound to target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER.
        /// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT. i in GL_COLOR_ATTACHMENTi may range from zero to the value of GL_MAX_COLOR_ATTACHMENTS - 1. Attaching a level of a texture to GL_DEPTH_STENCIL_ATTACHMENT is equivalent to attaching that level to both the GL_DEPTH_ATTACHMENT and the GL_STENCIL_ATTACHMENT attachment points simultaneously.
        /// textarget specifies what type of texture is named by texture, and for cube map textures, specifies the face that is to be attached. If texture is not zero, it must be the name of an existing texture with type textarget, unless it is a cube map texture, in which case textarget must be GL_TEXTURE_CUBE_MAP_POSITIVE_X GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// If texture is non-zero, the specified level of the texture object named texture is attached to the framebfufer attachment point named by attachment. For glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture3D, texture must be zero or the name of an existing texture with a target of textarget, or texture must be the name of an existing cube-map texture and textarget must be one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// If textarget is GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY, then level must be zero. If textarget is GL_TEXTURE_3D, then level must be greater than or equal to zero and less than or equal to log2 of the value of GL_MAX_3D_TEXTURE_SIZE. If textarget is one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, then level must be greater than or equal to zero and less than or equal to log2 of the value of GL_MAX_CUBE_MAP_TEXTURE_SIZE. For all other values of textarget, level must be greater than or equal to zero and no larger than log2 of the value of GL_MAX_TEXTURE_SIZE.
        /// layer specifies the layer of a 2-dimensional image within a 3-dimensional texture.
        /// For glFramebufferTexture1D, if texture is not zero, then textarget must be GL_TEXTURE_1D. For glFramebufferTexture2D, if texture is not zero, textarget must be one of GL_TEXTURE_2D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_2D_MULTISAMPLE. For glFramebufferTexture3D, if texture is not zero, then textarget must be GL_TEXTURE_3D.
        /// </remarks
        [EntryPoint(FunctionName = "glFramebufferTexture1D")]
        private static void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachmentType attachment, TextureTarget texTarget1D, uint TextureID, int Level = 0){ throw new NotImplementedException(); }

        //public static void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachmentType attachment, TextureTarget texTarget1D, uint TextureID, int Level = 0)
        //{
        //    FramebufferTexture1D(target, attachment, texTarget1D, TextureID, Level);
        //}
        /// <summary>
        /// Attaches a texture mipmap level to framebuffer currently bound at specified framebuffertarget to specified attachment point.
        /// </summary>
        /// <param name="fboTarget">Framebuffertarget with bound framebuffer to attach to.</param>
        /// <param name="attachment">Attachment point to bind texture mipmap level to.</param>
        /// <param name="texTarget2D">Texturetarget to treat texture id as. For Cubemap textures this need to be the cubemap face.</param>
        /// <param name="TextureID">texture id of texture mipmap level to attach.</param>
        /// <param name="level">The texture mipmap level to attach.</param>     
        /// <remarks>
        /// glFramebufferTexture, glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture attach a selected mipmap level or image of a texture object as one of the logical buffers of the framebuffer object currently bound to target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER.
        /// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT. i in GL_COLOR_ATTACHMENTi may range from zero to the value of GL_MAX_COLOR_ATTACHMENTS - 1. Attaching a level of a texture to GL_DEPTH_STENCIL_ATTACHMENT is equivalent to attaching that level to both the GL_DEPTH_ATTACHMENT and the GL_STENCIL_ATTACHMENT attachment points simultaneously.
        /// textarget specifies what type of texture is named by texture, and for cube map textures, specifies the face that is to be attached. If texture is not zero, it must be the name of an existing texture with type textarget, unless it is a cube map texture, in which case textarget must be GL_TEXTURE_CUBE_MAP_POSITIVE_X GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// If texture is non-zero, the specified level of the texture object named texture is attached to the framebfufer attachment point named by attachment. For glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture3D, texture must be zero or the name of an existing texture with a target of textarget, or texture must be the name of an existing cube-map texture and textarget must be one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// If textarget is GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY, then level must be zero. If textarget is GL_TEXTURE_3D, then level must be greater than or equal to zero and less than or equal to log2 of the value of GL_MAX_3D_TEXTURE_SIZE. If textarget is one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, then level must be greater than or equal to zero and less than or equal to log2 of the value of GL_MAX_CUBE_MAP_TEXTURE_SIZE. For all other values of textarget, level must be greater than or equal to zero and no larger than log2 of the value of GL_MAX_TEXTURE_SIZE.
        /// layer specifies the layer of a 2-dimensional image within a 3-dimensional texture.
        /// For glFramebufferTexture1D, if texture is not zero, then textarget must be GL_TEXTURE_1D. For glFramebufferTexture2D, if texture is not zero, textarget must be one of GL_TEXTURE_2D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_2D_MULTISAMPLE. For glFramebufferTexture3D, if texture is not zero, then textarget must be GL_TEXTURE_3D.
        /// </remarks>
        [EntryPoint(FunctionName = "glFramebufferTexture2D")]
        public static void FramebufferTexture2D(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, TextureTarget texTarget2D, uint TextureID, int level = 0){ throw new NotImplementedException(); }
        /// <summary>
        /// Attaches a texture mipmap level to framebuffer currently bound at specified framebuffertarget to specified attachment point.
        /// </summary>
        /// <param name="fboTarget">Framebuffertarget with bound framebuffer to attach to.</param>
        /// <param name="attachment">Attachment point to bind texture mipmap level to.</param>
        /// <param name="texTarget3D">Texturetarget to treat texture id as.</param>
        /// <param name="TextureID">texture id of texture mipmap level to attach.</param>
        /// <param name="level">The texture mipmap level to attach.</param>
        /// <param name="layer">layer specifies the layer of a 2-dimensional image within a 3-dimensional texture.</param>        
        /// <remarks>
        /// glFramebufferTexture, glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture attach a selected mipmap level or image of a texture object as one of the logical buffers of the framebuffer object currently bound to target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER.
        /// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT. i in GL_COLOR_ATTACHMENTi may range from zero to the value of GL_MAX_COLOR_ATTACHMENTS - 1. Attaching a level of a texture to GL_DEPTH_STENCIL_ATTACHMENT is equivalent to attaching that level to both the GL_DEPTH_ATTACHMENT and the GL_STENCIL_ATTACHMENT attachment points simultaneously.
        /// textarget specifies what type of texture is named by texture, and for cube map textures, specifies the face that is to be attached. If texture is not zero, it must be the name of an existing texture with type textarget, unless it is a cube map texture, in which case textarget must be GL_TEXTURE_CUBE_MAP_POSITIVE_X GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// If texture is non-zero, the specified level of the texture object named texture is attached to the framebfufer attachment point named by attachment. For glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture3D, texture must be zero or the name of an existing texture with a target of textarget, or texture must be the name of an existing cube-map texture and textarget must be one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// If textarget is GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY, then level must be zero. If textarget is GL_TEXTURE_3D, then level must be greater than or equal to zero and less than or equal to log2 of the value of GL_MAX_3D_TEXTURE_SIZE. If textarget is one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, then level must be greater than or equal to zero and less than or equal to log2 of the value of GL_MAX_CUBE_MAP_TEXTURE_SIZE. For all other values of textarget, level must be greater than or equal to zero and no larger than log2 of the value of GL_MAX_TEXTURE_SIZE.
        /// layer specifies the layer of a 2-dimensional image within a 3-dimensional texture.
        /// For glFramebufferTexture1D, if texture is not zero, then textarget must be GL_TEXTURE_1D. For glFramebufferTexture2D, if texture is not zero, textarget must be one of GL_TEXTURE_2D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_2D_MULTISAMPLE. For glFramebufferTexture3D, if texture is not zero, then textarget must be GL_TEXTURE_3D.
        /// </remarks>
        [EntryPoint(FunctionName = "glFramebufferTexture3D")]
        [Obsolete("Use glFramebufferTextureLayer​ instead, since it can do everything FramebufferTexture3D can and more.")]
        public static void FramebufferTexture3D(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, TextureTarget texTarget3D, uint TextureID, int level = 0, int layer = 0){ throw new NotImplementedException(); }

        ///// <summary>
        ///// Checks the framebuffer for completeness.
        ///// </summary>
        ///// <param name="fboTarget">Framebuffertarget with bound framebuffer to check for completeness.</param>
        ///// <returns></returns>
        [EntryPoint(FunctionName = "glCheckFramebufferStatus")]
        public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget fboTarget){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrives attachment parameters for specified attachment to currently bound framebuffer at framebuffertarget.
        /// </summary>
        /// <param name="fboTarget">Framebuffertarget with bound framebuffer to query.</param>
        /// <param name="attachment">Attachment to query.</param>
        /// <param name="pname">Paramenter name to retrive.</param>
        /// <param name="params">Result of query.</param>
        [EntryPoint(FunctionName = "glGetFramebufferAttachmentParameteriv")]
        unsafe public static void GetFramebufferAttachmentParameteriv(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, AttachmentParameters pname, int* result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives attachment parameters for specified attachment to currently bound framebuffer at framebuffertarget.
        /// </summary>
        /// <param name="fboTarget">Framebuffertarget with bound framebuffer to query.</param>
        /// <param name="attachment">Attachment to query.</param>
        /// <param name="pname">Paramenter name to retrive.</param>
        /// <param name="params">Result of query.</param>
        [EntryPoint(FunctionName = "glGetFramebufferAttachmentParameteriv")]
        public static void GetFramebufferAttachmentParameteriv(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, AttachmentParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives attachment parameters for specified attachment to currently bound framebuffer at framebuffertarget.
        /// </summary>
        /// <param name="fboTarget">Framebuffertarget with bound framebuffer to query.</param>
        /// <param name="attachment">Attachment to query.</param>
        /// <param name="pname">Paramenter name to retrive.</param>
        /// <param name="params">Result of query.</param>
        [EntryPoint(FunctionName = "glGetFramebufferAttachmentParameteriv")]
        public static void GetFramebufferAttachmentParameteriv(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, AttachmentParameters pname, out int result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives attachment parameters for specified attachment to currently bound framebuffer at framebuffertarget.
        /// </summary>
        /// <param name="fboTarget">Framebuffertarget with bound framebuffer to query.</param>
        /// <param name="attachment">Attachment to query.</param>
        /// <param name="pname">Paramenter name to retrive.</param>
        /// <remarks>Result of query.</remarks>
        //[EntryPoint(FunctionName = "glGetFramebufferAttachmentParameteriv")]
        public static int GetFramebufferAttachmentParameteriv(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, AttachmentParameters pname)
        {
            int tmp = 0;
            GetFramebufferAttachmentParameteriv(fboTarget, attachment, pname, out tmp);
            return tmp;
        }

        /// <summary>
        /// Retrives renderbuffer parameters from current bound renderbuffer.
        /// </summary>
        /// <param name="pname">Paramenter name to retrive.</param>
        /// <param name="params">Result of query.</param>
        /// <param name="rTarget">Renderbuffer target with bound renderbuffer to query..</param>
        [EntryPoint(FunctionName = "glGetRenderbufferParameteriv")]
        unsafe public static void GetRenderbufferParameteriv(RenderbufferTarget rTarget, RenderbufferParameters pname, int* result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives renderbuffer parameters from current bound renderbuffer.
        /// </summary>
        /// <param name="pname">Paramenter name to retrive.</param>
        /// <param name="params">Result of query.</param>
        /// <param name="rTarget">Renderbuffer target with bound renderbuffer to query..</param>
        [EntryPoint(FunctionName = "glGetRenderbufferParameteriv")]
        public static void GetRenderbufferParameteriv(RenderbufferTarget rTarget, RenderbufferParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives renderbuffer parameters from current bound renderbuffer.
        /// </summary>
        /// <param name="pname">Paramenter name to retrive.</param>
        /// <param name="params">Result of query.</param>
        /// <param name="rTarget">Renderbuffer target with bound renderbuffer to query..</param>
        [EntryPoint(FunctionName = "glGetRenderbufferParameteriv")]
        public static void GetRenderbufferParameteriv(RenderbufferTarget rTarget, RenderbufferParameters pname, ref int result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives renderbuffer parameters from current bound renderbuffer.
        /// </summary>
        /// <param name="rTarget">Renderbuffer target with bound renderbuffer to query..</param>
        /// <param name="pname">Paramenter name to retrive.</param>
        /// <returns>Result of query.</returns>
        [EntryPoint(FunctionName = "glGetRenderbufferParameteriv")]
        public static int GetRenderbufferParameteriv(RenderbufferTarget rTarget, RenderbufferParameters pname) { throw new NotImplementedException(); }

        public static int GetRenderbufferParameteriv(RenderbufferParameters pname, RenderbufferTarget rTarget = RenderbufferTarget.Renderbuffer)
        {
            return GetRenderbufferParameteriv(rTarget, pname);
        }
        /// <summary>
        /// Generates new mipmaps for texture currently bound to specified texture target at active texture unit.
        /// </summary>
        /// <param name="target"></param>
        [EntryPoint(FunctionName = "glGenerateMipmap")]
        public static void GenerateMipmap(TextureTarget target) { throw new NotImplementedException(); }


        //EXT_draw_buffers2
        /// <summary>
        /// Sets the color mask for a specified drawbuffer.
        /// </summary>
        /// <param name="drawbuffer">Drawbuffer to set mask for.</param>
        /// <param name="red">red mask</param>
        /// <param name="green">green mask</param>
        /// <param name="blue">blue mask</param>
        /// <param name="alpha">alpha mask.</param>
        [EntryPoint(FunctionName = "glColorMaski")]
        public static void ColorMaski(DrawBufferTarget drawbuffer, bool red, bool green, bool blue, bool alpha){ throw new NotImplementedException(); }

        /// <summary>
        /// Disables an indexed state.
        /// Note that what index means is dependent on cap.
        /// </summary>
        /// <param name="cap">Cap describing what to disable and what index means.</param>
        /// <param name="index">zero based. What index means is dependent on cap.</param>
        [EntryPoint(FunctionName = "glDisablei")]
        public static void Disablei(EnableStateIndexed cap, uint index){ throw new NotImplementedException(); }
        /// <summary>
        /// Enables an indexed state.
        /// Note that what index means is dependent on cap.
        /// </summary>
        /// <param name="cap">Cap describing what to enable and what index means.</param>
        /// <param name="index">zero based. What index means is dependent on cap.</param>
        [EntryPoint(FunctionName = "glEnablei")]
        public static void Enablei(EnableStateIndexed cap, uint index){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetBooleani_v")]
        unsafe public static void GetBooleani_v(GetParameters pname, uint index, bool* data){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetBooleani_v")]
        unsafe public static void GetBooleani_v(GetParameters pname, uint index, bool[] data) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetBooleani_v")]
        unsafe public static void GetBooleani_v(GetParameters pname, uint index, ref bool data) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetBooleani_v")]
        unsafe public static bool GetBooleani_v(GetParameters pname, uint index) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetIntegeri_v")]
        unsafe public static void GetIntegeri_v(GetParameters pname, uint index, int* data){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetIntegeri_v")]
        public static void GetIntegeri_v(GetParameters pname, uint index, int[] data) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetIntegeri_v")]
        public static void GetIntegeri_v(GetParameters pname, uint index, ref int data) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetIntegeri_v")]
        public static int GetIntegeri_v(GetParameters pname, uint index){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrives the indexed state of cap.
        /// </summary>
        /// <param name="cap">The indexed cap state to retrive.</param>
        /// <param name="index">zero based. Index of cap type to query.</param>
        /// <returns>true if enabled, false otherwise.</returns>
        [EntryPoint(FunctionName = "glIsEnabledi")]
        public static bool IsEnabledi(EnableStateIndexed cap, uint index){ throw new NotImplementedException(); }

        //EXT_framebuffer_blit
        [EntryPoint(FunctionName = "glBlitFramebuffer")]
        public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferFlags mask, BlitFramebufferFilter filter){ throw new NotImplementedException(); }

        //EXT_framebuffer_multisample
        /// <summary>
        /// Allocates a multisample renderbuffer storage with specific dimensions for currently bound renderbuffer.
        /// </summary>
        /// <param name="target">Renderbuffertarfet containg renderbuffer to create multisample storage for.</param>
        /// <param name="samples">Number of samples in multisample storage.</param>
        /// <param name="iformat">Format of renderbuffer.</param>
        /// <param name="width">Width of renderbuffer.</param>
        /// <param name="height">Height of renderbuffer.</param>
        [EntryPoint(FunctionName = "glRenderbufferStorageMultisample")]
        public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, RenderbufferStorageFormat iformat, int width, int height){ throw new NotImplementedException(); }
        /// <summary>
        /// Allocates a multisample renderbuffer storage with specific dimensions for currently bound renderbuffer.
        /// </summary>
        /// <param name="target">Renderbuffertarfet containg renderbuffer to create multisample storage for.</param>
        /// <param name="samples">Number of samples in multisample storage.</param>
        /// <param name="iformat">Format of renderbuffer.</param>
        /// <param name="width">Width of renderbuffer.</param>
        /// <param name="height">Height of renderbuffer.</param>
        public static void RenderbufferStorageMultisample(int samples, RenderbufferStorageFormat iformat, int width, int height, RenderbufferTarget target = RenderbufferTarget.Renderbuffer)
        {
            RenderbufferStorageMultisample(target, samples, iformat, width, height);
        }


        //EXT_gpu_shader4
        /// <summary>
        /// Binds a fragment output to a specified drawbuffer.
        /// </summary>
        /// <param name="Program">Program containg named fragment output.</param>
        /// <param name="colorNumber">The drawbuffer to write fragment output to.</param>
        /// <param name="Name">Name of fragment output to bind.</param>
        [EntryPoint(FunctionName = "glBindFragDataLocation")]
        public static void BindFragDataLocation(uint Program, DrawBufferTarget colorNumber, string Name){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives the fragment output index of named fragment output.
        /// </summary>
        /// <param name="Program">Program containg named fragment output.</param>
        /// <param name="Name">Name of fragment output to query for indexed location.</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetFragDataLocation")]
        public static int GetFragDataLocation(uint Program, string Name){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrives uint[] value at location in program.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="location">Location of values to retrive.</param>
        /// <param name="params">Preallocated array big enough for retrived values.</param>
        [EntryPoint(FunctionName = "glGetUniformuiv")]
        unsafe public static void GetUniformuiv(uint Program, int location, uint* result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives uint[] value at location in program.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="location">Location of values to retrive.</param>
        /// <param name="params">Preallocated array big enough for retrived values.</param>
        [EntryPoint(FunctionName = "glGetUniformuiv")]
        public static void GetUniformuiv(uint Program, int location, uint[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives uint[] value at location in program.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="location">Location of values to retrive.</param>
        /// <param name="params">Preallocated array big enough for retrived values.</param>
        [EntryPoint(FunctionName = "glGetUniformuiv")]
        public static void GetUniformuiv(uint Program, int location, ref uint result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives the uint value at location in program.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="location">Location of value to retrive.</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetUniformuiv")]
        public static uint GetUniformuiv(uint Program, int location) { throw new NotImplementedException(); }

        /// <summary>
        /// Integer Vertex declaration for attribute index in current bound vertex array object.
        /// </summary>
        /// <param name="index">Attribute index to declare vertex source.</param>
        /// <param name="size">number of components in iType.</param>
        /// <param name="iType">Integer type of vertex declaration.</param>
        /// <param name="stride">Stride between individually vertices.</param>
        /// <param name="offset">Offset into currenly bound arraybuffer to source from.</param>        
        [EntryPoint(FunctionName = "glVertexAttribIPointer")]
        public static void VertexAttribIPointer(uint index, int size, VertexAttribIFormat iType, int stride, IntPtr ptr){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetVertexAttribIiv")]
        unsafe public static void GetVertexAttribIiv(uint index, VertexAttribParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribIiv")]
        public static void GetVertexAttribIiv(uint index, VertexAttribParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribIiv")]
        public static void GetVertexAttribIiv(uint index, VertexAttribParameters pname, ref int result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribIiv")]
        public static int GetVertexAttribIiv(uint index, VertexAttribParameters pname) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetVertexAttribIuiv")]
        unsafe public static void GetVertexAttribIuiv(uint index, VertexAttribParameters pname, uint* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribIuiv")]
        public static void GetVertexAttribIuiv(uint index, VertexAttribParameters pname, uint[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribIuiv")]
        public static void GetVertexAttribIuiv(uint index, VertexAttribParameters pname, ref uint result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribIuiv")]
        public static uint GetVertexAttribIuiv(uint index, VertexAttribParameters pname) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform1ui")]
        public static void Uniform1ui(int location, uint v1){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform2ui")]
        public static void Uniform2ui(int location, uint v1, uint v2){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform3ui")]
        public static void Uniform3ui(int location, uint v1, uint v2, uint v3){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform4ui")]
        public static void Uniform4ui(int location, uint v1, uint v2, uint v3, uint v4){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform1uiv")]
        unsafe public static void Uniform1uiv(int location, int count, uint* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform1uiv")]
        public static void Uniform1uiv(int location, int count, uint[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform1uiv")]
        public static void Uniform1uiv(int location, int count, ref uint v) { throw new NotImplementedException(); }
        public static void Uniform1uiv(int location, uint[] v, int count = 1)
        {
            Uniform1uiv(location, count, v);
        }

        [EntryPoint(FunctionName = "glUniform2uiv")]
        unsafe public static void Uniform2uiv(int location, int count, uint* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform2uiv")]
        public static void Uniform2uiv(int location, int count, uint[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform2uiv")]
        public static void Uniform2uiv(int location, int count, ref uint v) { throw new NotImplementedException(); }
        public static void Uniform2uiv(int location, uint[] v, int count = 1)
        {
            Uniform2uiv(location, count, v);
        }

        [EntryPoint(FunctionName = "glUniform3uiv")]
        unsafe public static void Uniform3uiv(int location, int count, uint* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform3uiv")]
        public static void Uniform3uiv(int location, int count, uint[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform3uiv")]
        public static void Uniform3uiv(int location, int count, ref uint v) { throw new NotImplementedException(); }
        public static void Uniform3uiv(int location, uint[] v, int count = 1)
        {
            Uniform3uiv(location, count , v);
        }

        [EntryPoint(FunctionName = "glUniform4uiv")]
        unsafe public static void Uniform4uiv(int location, int count, uint* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform4uiv")]
        public static void Uniform4uiv(int location, int count, uint[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform4uiv")]
        public static void Uniform4uiv(int location, int count, ref uint v) { throw new NotImplementedException(); }
        public static void Uniform4uiv(int location, uint[] v, int count = 1)
        {
            Uniform4uiv(location, count, v);
        }

        /* 16 functions ignored.
        public static void VertexAttribI1i(int index, int v1){ throw new NotImplementedException(); }
        public static void VertexAttribI2i(int index, int v1, int v2){ throw new NotImplementedException(); }
        public static void VertexAttribI3i(int index, int v1, int v2, int v3){ throw new NotImplementedException(); }
        public static void VertexAttribI4i(int index, int v1, int v2, int v3, int v4){ throw new NotImplementedException(); }

        public static void VertexAttribI1ui(int index, uint v1){ throw new NotImplementedException(); }
        public static void VertexAttribI2ui(int index, uint v1, uint v2){ throw new NotImplementedException(); }
        public static void VertexAttribI3ui(int index, uint v1, uint v2, uint v3){ throw new NotImplementedException(); }
        public static void VertexAttribI4ui(int index, uint v1, uint v2, uint v3, uint v4){ throw new NotImplementedException(); }

        public static void VertexAttribI1iv(int index, ref int v){ throw new NotImplementedException(); }
        public static void VertexAttribI2iv(int index, ref int v){ throw new NotImplementedException(); }
        public static void VertexAttribI3iv(int index, ref int v){ throw new NotImplementedException(); }
        public static void VertexAttribI4iv(int index, ref int v){ throw new NotImplementedException(); }

        public static void VertexAttribI1uiv(int index, ref uint v){ throw new NotImplementedException(); }
        public static void VertexAttribI2uiv(int index, ref uint v){ throw new NotImplementedException(); }
        public static void VertexAttribI3uiv(int index, ref uint v){ throw new NotImplementedException(); }
        public static void VertexAttribI4uiv(int index, ref uint v){ throw new NotImplementedException(); }
        */

        //EXT_texture_integer
        /// <summary>
        /// Retrives a integer parameter from a interger texture.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetTexParameterIiv")]
        unsafe public static void GetTexParameterIiv(TextureTarget target, TextureParameters pname, int* data){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a integer parameter from a interger texture.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetTexParameterIiv")]
        public static void GetTexParameterIiv(TextureTarget target, TextureParameters pname, int[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a integer parameter from a interger texture.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetTexParameterIiv")]
        public static void GetTexParameterIiv(TextureTarget target, TextureParameters pname, ref int data) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a integer parameter from a interger texture.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetTexParameterIiv")]
        public static int GetTexParameterIiv(TextureTarget target, TextureParameters pname) { throw new NotImplementedException(); }

        /// <summary>
        /// Gets a integer parameter from a integer texture.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetTexParameterIuiv")]
        unsafe public static void GetTexParameterIuiv(TextureTarget target, TextureParameters pname, uint* data){ throw new NotImplementedException(); }
        /// <summary>
        /// Gets a integer parameter from a integer texture.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetTexParameterIuiv")]
        public static void GetTexParameterIuiv(TextureTarget target, TextureParameters pname, uint[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Gets a integer parameter from a integer texture.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetTexParameterIuiv")]
        public static void GetTexParameterIuiv(TextureTarget target, TextureParameters pname, ref uint data) { throw new NotImplementedException(); }
        /// <summary>
        /// Gets a integer parameter from a integer texture.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetTexParameterIuiv")]
        public static uint GetTexParameterIuiv(TextureTarget target, TextureParameters pname) { throw new NotImplementedException(); }

        /// <summary>
        /// Sets a integer parameter.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glTexParameterIiv")]
        unsafe public static void TexParameterIiv(TextureTarget target, TextureParameters pname, int* data){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets a integer parameter.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glTexParameterIiv")]
        public static void TexParameterIiv(TextureTarget target, TextureParameters pname, int[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets an integer parameter.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glTexParameterIiv")]
        public static void TexParameterIiv(TextureTarget target, TextureParameters pname, ref int data) { throw new NotImplementedException(); }

        /// <summary>
        /// Sets an unsigned integer parameter.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glTexParameterIuiv")]
        unsafe public static void TexParameterIuiv(TextureTarget target, TextureParameters pname, uint* data){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets an unsigned integer parameter.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glTexParameterIuiv")]
        unsafe public static void TexParameterIuiv(TextureTarget target, TextureParameters pname, uint[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets an unsigned integer parameter.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glTexParameterIuiv")]
        unsafe public static void TexParameterIuiv(TextureTarget target, TextureParameters pname, ref uint data) { throw new NotImplementedException(); }


        //EXT_transform_feedback/NV_transform_feedback
        /// <summary>
        /// Binds a range/region in a buffer to a bindingindex on current bound program.
        /// Note that there are separate ranges of bindingindexes dependent on which target you bind.
        /// Aka UniformBuffertarget and index 0 is not the same as ShaderStorageTarget and index 0.
        /// </summary>
        /// <param name="target">The target on current bound program to bind buffer at.</param>
        /// <param name="bindingIndex">The bindingindex of target type to bind to.</param>
        /// <param name="BufferId">The id of the buffer to bind.</param>
        /// <param name="Offset">Offset in bytes from start of buffer to start of range.</param>
        /// <param name="Size">Size in bytes from start of range to end of range.</param>
        [EntryPoint(FunctionName = "glBindBufferRange")]
        public static void BindBufferRange(BufferProgramTarget target, uint bindingIndex, uint BufferId, IntPtr Offset, IntPtr Size){ throw new NotImplementedException(); }
        /// <summary>
        /// Binds a range/region in a buffer to a bindingindex on current bound program.
        /// Note that there are separate ranges of bindingindexes dependent on which target you bind.
        /// Aka UniformBuffertarget and index 0 is not the same as ShaderStorageTarget and index 0.
        /// </summary>
        /// <param name="target">The target on current bound program to bind buffer at.</param>
        /// <param name="bindingIndex">The bindingindex of target type to bind to.</param>
        /// <param name="BufferId">The id of the buffer to bind.</param>
        /// <param name="Offset">Offset in bytes from start of buffer to start of range.</param>
        /// <param name="Size">Size in bytes from start of range to end of range.</param>        
        public static void BindBufferRange(BufferProgramTarget target, uint bindingIndex, uint BufferId, long Offset, long Size)
        {
            BindBufferRange(target, bindingIndex, BufferId, (IntPtr)Offset, (IntPtr)Size);
        }

        /// <summary>
        /// Binds a buffer to a bindingindex on current bound program.
        /// Note that there are separate ranges of bindingindexes dependent on which target you bind.
        /// Aka UniformBuffertarget and index 0 is not the same as ShaderStorageTarget and index 0.
        /// </summary>
        /// <param name="target">The target on current bound program to bind buffer at.</param>
        /// <param name="bindingIndex">The bindingindex of target type to bind to.</param>
        /// <param name="BufferId">The id of the buffer to bind.</param>
        [EntryPoint(FunctionName = "glBindBufferBase")]
        public static void BindBufferBase(BufferProgramTarget target, uint bindingIndex, uint BufferId){ throw new NotImplementedException(); }

        /// <summary>
        /// Starts a transformfeedback rendering.
        /// </summary>
        /// <param name="primitiveMode">the type of primitives to render.</param>
        [EntryPoint(FunctionName = "glBeginTransformFeedback")]
        public static void BeginTransformFeedback(BeginMode primitiveMode){ throw new NotImplementedException(); }
        /// <summary>
        /// Ends a transformfeedback rendering.
        /// </summary>
        [EntryPoint(FunctionName = "glEndTransformFeedback")]
        public static void EndTransformFeedback(){ throw new NotImplementedException(); }
        /// <summary>
        /// Specifies a set of transformfeedback varyings/attributes buffermodes in one call.
        /// </summary>
        /// <param name="Program">Program to set buffermode on.</param>
        /// <param name="varyings">array of varying/attribute names to specify buffer mode for.</param>
        /// <param name="bufferMode">The buffermode to set.</param>
        [EntryPoint(FunctionName = "glTransformFeedbackVaryings")]
        public static void TransformFeedbackVaryings(uint Program, int count, string[] varyings, TransformFeedbackAttributeMode bufferMode){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTransformFeedbackVarying")]
        public static void GetTransformFeedbackVarying(uint Program, uint index, int bufSize, out int length, out int size, out AttributeType type, StringBuilder name){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives the properties of one TransformFeedback Varying/attribute specified by index.
        /// Note: Allocates a stringbuilder with default size 64 bytes for each call.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="index">Index of varying/attribute to retrive properties for.</param>
        /// <param name="size">The retrived size.</param>
        /// <param name="type">The retrived type.</param>
        /// <param name="name">The retrived name.</param>
        /// <param name="MaxAttributeNameLength">The default size of the StringBuilder used to retrive name.</param>
        public static void GetTransformFeedbackVarying(uint Program, uint index, out int size, out AttributeType type, out string name, int MaxAttributeNameLength = 64)
        {
            //int bufSize, out int length
            var sb = new StringBuilder(MaxAttributeNameLength + 4);
            GetTransformFeedbackVarying(Program, index, sb.Capacity - 2, out MaxAttributeNameLength, out size, out type, sb);
            name = sb.ToString();
        }

        //NV_conditional_render
        /// <summary>
        /// Starts a conditional render.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mode"></param>
        [EntryPoint(FunctionName = "glBeginConditionalRender")]
        public static void BeginConditionalRender(uint id, ConditionalRenderType mode){ throw new NotImplementedException(); }
        /// <summary>
        /// ends a condition render
        /// </summary>
        [EntryPoint(FunctionName = "glEndConditionalRender")]
        public static void EndConditionalRender(){ throw new NotImplementedException(); }

        // glGetStringi ?? added here.
        [EntryPoint(FunctionName = "glGetStringi")]
        private static IntPtr GetStringiPtr(StringName name, uint index){ throw new NotImplementedException(); }
        /// <summary>
        /// Returns the indexed name string. For now only Extensions are supported so thats default value.
        /// </summary>
        /// <param name="index">index of extension to retrive. This index can change from driver version to driver version.</param>
        /// <param name="name">Only Extensions are supported here.</param>
        /// <returns></returns>
        public static string GetStringi(StringName name, uint index)
        {
            var ptr = GetStringiPtr(name, index);
            return Marshal.PtrToStringAnsi(ptr);
        }
        #endregion

        #region Public Helper Functions



        #endregion

    }
}
