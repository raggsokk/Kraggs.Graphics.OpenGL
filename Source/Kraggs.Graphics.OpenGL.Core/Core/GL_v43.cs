#region License

// Kraggs.Graphics.OpenGL (github.com/raggsokk)
//
// Copyright (c) 2014 Jarle Hansen (github.com/raggsokk)
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
        #region DllImports

        //ARB_clear_buffer_object
        [EntryPointSlot(413)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glClearBufferData(BufferTarget target, TextureBufferInternalFormat internalformat, ClearBufferDataFormat format, PixelType type, IntPtr data);
        [EntryPointSlot(414)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glClearBufferSubData(BufferTarget target, TextureBufferInternalFormat internalformat, IntPtr Offset, IntPtr Size, ClearBufferDataFormat format, PixelType type, IntPtr data);

        //ARB_compute_shader
        [EntryPointSlot(415)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glDispatchCompute(uint num_group_x, uint num_groups_y, uint num_groups_z);
        [EntryPointSlot(416)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glDispatchComputeIndirect(IntPtr Indirect);

        // ARB_copy_image
        [EntryPointSlot(417)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glCopyImageSubData(uint srcName, GetInternalformatTargets srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GetInternalformatTargets dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);

        //ARB_internalformat_query2
        [EntryPointSlot(418)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe public static extern void glGetInternalformati64v(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname, int bufSize, long* result);

        //ARB_invalidate_subdata
        [EntryPointSlot(419)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glInvalidateBufferData(uint BufferId);
        [EntryPointSlot(420)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glInvalidateBufferSubData(uint BufferId, IntPtr Offset, IntPtr Length);
        [EntryPointSlot(421)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glInvalidateFramebuffer(FramebufferTarget target, int numAttachments, ref FramebufferAttachmentType attachments);
        [EntryPointSlot(422)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glInvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, ref FramebufferAttachmentType attachments, int x, int y, int width, int height);
        [EntryPointSlot(423)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glInvalidateTexImage(uint TextureID, int level);
        [EntryPointSlot(424)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glInvalidateTexSubImage(uint TextureID, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);

        //ARB_multi_draw_indirect
        [EntryPointSlot(425)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glMultiDrawArraysIndirect(BeginMode mode, IntPtr Indirect, int drawCount, int Stride);
        [EntryPointSlot(426)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glMultiDrawElementsIndirect(BeginMode mode, IndicesType type, IntPtr Indirect, int drawCount, int Stride);

        //ARB_program_interface_query
        [EntryPointSlot(427)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe public static extern void glGetProgramInterfaceiv(uint Program, ProgramInterface programInterface, ProgramInterfaceParameters pname, int* result);
        [EntryPointSlot(428)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern uint glGetProgramResourceIndex(uint Program, ProgramInterface programInterface, string Name);
        [EntryPointSlot(429)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern int glGetProgramResourceLocation(uint Program, ProgramInterface programInterface, string Name);
        [EntryPointSlot(430)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern int glGetProgramResourceLocationIndex(uint Program, ProgramInterface programInterface, string Name);
        [EntryPointSlot(431)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glGetProgramResourceName(uint Program, ProgramInterface programInterface, uint index, int bufSize, out int Lenght, IntPtr Name);
        [EntryPointSlot(432)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe public static extern void glGetProgramResourceiv(uint Program, ProgramInterface programInterface, uint Index, int propCount, ProgramResourceProperties* props, int bufSize, out int Length, int* result);

        //ARB_shader_storage_buffer_object
        [EntryPointSlot(433)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glShaderStorageBlockBinding(uint Program, uint StorageBlockIndex, uint StorageBlockBinding);

        //ARB_texture_buffer_range
        [EntryPointSlot(434)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glTexBufferRange(BufferTextureTarget target, TextureBufferInternalFormat iformat, uint BufferId, IntPtr Offset, IntPtr Size);

        //ARB_texture_storage_multisample
        [EntryPointSlot(435)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glTexStorage2DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations);
        [EntryPointSlot(436)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glTexStorage3DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations);

        //ARB_texture_view
        [EntryPointSlot(437)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glTextureView(uint TextureID, TextureTarget target, uint OriginalTextureId, PixelInternalFormat internalFormat, uint minLevel, uint numLevels, uint minLayer, uint numLayers);

        //ARB_vertex_attrib_binding
        [EntryPointSlot(438)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glBindVertexBuffer(uint bindingsIndex, uint BufferID, IntPtr Offset, int Stride);
        [EntryPointSlot(439)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glVertexAttribBinding(uint attribIndex, uint bindingsIndex);
        [EntryPointSlot(440)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glVertexBindingDivisor(uint bindingsIndex, uint divisor);

        [EntryPointSlot(441)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glVertexAttribFormat(uint attribIndex, int Size, VertexAttribFormat type, bool normalized, uint relativeOffset);
        [EntryPointSlot(442)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glVertexAttribIFormat(uint attribIndex, int Size, VertexAttribIFormat itype, uint relativeOffset);
        [EntryPointSlot(443)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glVertexAttribLFormat(uint attribIndex, int Size, VertexAttribLFormat ltype, uint relativeOffset);

        //ARB_framebuffer_no_attachments
        [EntryPointSlot(444)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glFramebufferParameteri(FramebufferTarget target, FramebufferParameters pname, int param);
        [EntryPointSlot(445)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe public static extern void glGetFramebufferParameteriv(FramebufferTarget target, FramebufferParameters pname, int* result);

        //KHR_debug / ARB_debug_output

        //public static extern void glDebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int Count, uint* ids, bool Enabled);
        [EntryPointSlot(446)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public unsafe static extern void glDebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int Count, uint* ids, bool Enabled);
        [EntryPointSlot(447)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glDebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf);
        [EntryPointSlot(448)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glDebugMessageCallback(DebugMessageDelegate callback, IntPtr userParam);
        [EntryPointSlot(449)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe public static extern uint glGetDebugMessageLog(uint count, int bufsize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, IntPtr messageLog);
        [EntryPointSlot(450)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glGetPointerv(GetPointerName pname, out IntPtr ptr);

        //KHR_debug / ARB_debug_label
        [EntryPointSlot(451)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glObjectLabel(DebugNamespace idNamespace, uint name, int LabelLength, string Label);
        [EntryPointSlot(452)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glGetObjectLabel(DebugNamespace idNamespace, uint name, int bufsize, out int LabelLength, IntPtr label);
        [EntryPointSlot(453)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glObjectPtrLabel(IntPtr ptr, int length, string label);
        [EntryPointSlot(454)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glGetObjectPtrLabel(IntPtr ptr, int bufSize, out int length, IntPtr label);

        //KHR_debug / ARB_debug_group
        [EntryPointSlot(455)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glPushDebugGroup(DebugSource source, uint id, int length, string message);
        [EntryPointSlot(456)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glPopDebugGroup();

        //ARB_ES3_compatibility
        // no functions

        // OpenGL 4.3 other functions
        [EntryPointSlot(457)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe public static extern void glClearBufferfv(ClearBuffer buffer, DrawBufferTarget drawbuffer, float* values);
        [EntryPointSlot(458)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe public static extern void glClearBufferiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, int* values);
        [EntryPointSlot(459)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe public static extern void glClearBufferuiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, uint* values);
        [EntryPointSlot(460)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glClearBufferfi(ClearBuffer buffer, DrawBufferTarget drawbuffer, float depth, int stencil);


        #endregion

        #region Public functions

        //[EntryPoint(FunctionName = "gl")]
        //public static void BindTexture(TextureTarget target, uint textureid) { throw new NotImplementedException(); }

        //ARB_clear_buffer_object
        /// <summary>
        /// Clears the internal storage of a texture buffer.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="internalformat"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glClearBufferData")]
        public static void ClearBufferData(BufferTarget target, TextureBufferInternalFormat internalformat, ClearBufferDataFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glClearBufferSubData")]
        private static void ClearBufferSubData(BufferTarget target, TextureBufferInternalFormat internalformat, IntPtr Offset, IntPtr Size, ClearBufferDataFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }
        /// <summary>
        /// Clears subparts of internal storage of a texture buffer.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="internalformat"></param>
        /// <param name="Offset"></param>
        /// <param name="Size"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="data"></param>
        public static void ClearBufferSubData(BufferTarget target, TextureBufferInternalFormat internalformat, long Offset, long Size, ClearBufferDataFormat format, PixelType type, IntPtr data)
        {
            ClearBufferSubData(target, internalformat, (IntPtr)Offset, (IntPtr)Size, format, type, data);
        }
        //ARB_compute_shader
        /// <summary>
        /// Starts running a compute shader.
        /// </summary>
        /// <param name="num_group_x"></param>
        /// <param name="num_groups_y"></param>
        /// <param name="num_groups_z"></param>
        [EntryPoint(FunctionName = "glDispatchCompute")]
        public static void DispatchCompute(uint num_group_x, uint num_groups_y, uint num_groups_z){ throw new NotImplementedException(); }

        /// <summary>
        /// Starts running a compute shader.
        /// </summary>
        /// <param name="Indirect"></param>
        [EntryPoint(FunctionName = "glDispatchComputeIndirect")]
        public static void DispatchComputeIndirect(IntPtr Indirect){ throw new NotImplementedException(); }

        // ARB_copy_image
        /// <summary>
        /// Copies parts of an texture mipmap level to another textures mipmap level.
        /// The Copy can not make the destination target larger to source target.
        /// </summary>
        /// <param name="srcName"></param>
        /// <param name="srcTarget"></param>
        /// <param name="srcLevel"></param>
        /// <param name="srcX"></param>
        /// <param name="srcY"></param>
        /// <param name="srcZ"></param>
        /// <param name="dstName"></param>
        /// <param name="dstTarget"></param>
        /// <param name="dstLevel"></param>
        /// <param name="dstX"></param>
        /// <param name="dstY"></param>
        /// <param name="dstZ"></param>
        /// <param name="srcWidth"></param>
        /// <param name="srcHeight"></param>
        /// <param name="srcDepth"></param>
        [EntryPoint(FunctionName = "glCopyImageSubData")]
        public static void CopyImageSubData(uint srcName, GetInternalformatTargets srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GetInternalformatTargets dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth){ throw new NotImplementedException(); }

        //ARB_internalformat_query2
        /// <summary>
        /// Retrives an array of values for a combination of target and internal format query of parameter value.
        /// aka check if render to RGBA32F is something we should do?
        ///     if(GetInternalformati64v(Renderbuffer, RGBA32F, InternalFormatSupported) == FULL_SUPPORT)
        ///     {
        ///         // render.
        ///     }
        /// </summary>
        /// <param name="target">Where should internalformat be used?</param>
        /// <param name="internalformat">The internal format to query</param>
        /// <param name="pname">Name of parameter to retrive data for above combo.</param>
        /// <param name="params">Long array big enough to retrive expected result.</param>
        [EntryPoint(FunctionName = "glGetInternalformati64v")]
        unsafe public static void GetInternalformati64v(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname, int bufSize, long* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives an array of values for a combination of target and internal format query of parameter value.
        /// aka check if render to RGBA32F is something we should do?
        ///     if(GetInternalformati64v(Renderbuffer, RGBA32F, InternalFormatSupported) == FULL_SUPPORT)
        ///     {
        ///         // render.
        ///     }
        /// </summary>
        /// <param name="target">Where should internalformat be used?</param>
        /// <param name="internalformat">The internal format to query</param>
        /// <param name="pname">Name of parameter to retrive data for above combo.</param>
        /// <param name="params">Long array big enough to retrive expected result.</param>
        [EntryPoint(FunctionName = "glGetInternalformati64v")]
        public static void GetInternalformati64v(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname, int bufSize, long[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives an array of values for a combination of target and internal format query of parameter value.
        /// aka check if render to RGBA32F is something we should do?
        ///     if(GetInternalformati64v(Renderbuffer, RGBA32F, InternalFormatSupported) == FULL_SUPPORT)
        ///     {
        ///         // render.
        ///     }
        /// </summary>
        /// <param name="target">Where should internalformat be used?</param>
        /// <param name="internalformat">The internal format to query</param>
        /// <param name="pname">Name of parameter to retrive data for above combo.</param>
        /// <param name="params">Long array big enough to retrive expected result.</param>
        [EntryPoint(FunctionName = "glGetInternalformati64v")]
        public static void GetInternalformati64v(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname, int bufSize, ref long result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives an array of values for a combination of target and internal format query of parameter value.
        /// aka check if render to RGBA32F is something we should do?
        ///     if(GetInternalformati64v(Renderbuffer, RGBA32F, InternalFormatSupported) == FULL_SUPPORT)
        ///     {
        ///         // render.
        ///     }
        /// </summary>
        /// <param name="target">Where should internalformat be used?</param>
        /// <param name="internalformat">The internal format to query</param>
        /// <param name="pname">Name of parameter to retrive data for above combo.</param>
        /// <param name="params">Long array big enough to retrive expected result.</param>        
        public static void GetInternalformati64v(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname, long[] result)
        {
            GetInternalformati64v(target, internalformat, pname, result.Length, ref result[0]);
        }
        /// <summary>
        /// Retrives a single long parameter value from a combination of target and paramenter name.
        /// </summary>
        /// <param name="target">Where should Internalformat be used.</param>
        /// <param name="internalformat">The internal format to query.</param>
        /// <param name="pname">Name of parameter to retrive for above combo.</param>
        /// <returns></returns>
        public static long GetInternalformati64v(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname)
        {
            long l = 0;
            GetInternalformati64v(target, internalformat, pname, 1, ref l);
            return l;
        }

        //ARB_invalidate_subdata
        /// <summary>
        /// Invalidates the content of a buffer. aka detaches storage.
        /// </summary>
        /// <param name="BufferId"></param>
        [EntryPoint(FunctionName = "glInvalidateBufferData")]
        public static void InvalidateBufferData(uint BufferId){ throw new NotImplementedException(); }
        /// <summary>
        /// Invalidates a subrange of a buffer.
        /// </summary>
        /// <param name="BufferId"></param>
        /// <param name="Offset"></param>
        /// <param name="Length"></param>
        [EntryPoint(FunctionName = "glInvalidateBufferSubData")]
        public static void InvalidateBufferSubData(uint BufferId, IntPtr Offset, IntPtr Length){ throw new NotImplementedException(); }

        /// <summary>
        /// Invalidates the content of a framebuffers attachments.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="attachments"></param>
        [EntryPoint(FunctionName = "glInvalidateFramebuffer")]
        public static void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, ref FramebufferAttachmentType attachments){ throw new NotImplementedException(); }
        /// <summary>
        /// Invalidates the content of a framebuffers attachments.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="attachments"></param>
        public static void InvalidateFramebuffer(FramebufferTarget target, FramebufferAttachmentType[] attachments)
        {
            InvalidateFramebuffer(target, attachments.Length, ref attachments[0]);
        }
        /// <summary>
        /// Invalidates the contents of a single framebuffer attachement.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="attachment"></param>
        public static void InvalidateFramebuffer(FramebufferTarget target, FramebufferAttachmentType attachment)
        {
            InvalidateFramebuffer(target, 1, ref attachment);
        }

        /// <summary>
        /// Invalidates subparts of several framebuffer attachments.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="attachments"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        [EntryPoint(FunctionName = "glInvalidateSubFramebuffer")]
        public static void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, ref FramebufferAttachmentType attachments, int x, int y, int width, int height){ throw new NotImplementedException(); }
        /// <summary>
        /// Invalidates subparts of several framebuffer attachments.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="attachments"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static void InvalidateSubFramebuffer(FramebufferTarget target, FramebufferAttachmentType[] attachments, int x, int y, int width, int height)
        {
            InvalidateSubFramebuffer(target, attachments.Length, ref attachments[0], x, y, width, height);
        }
        /// <summary>
        /// Invalidates a subpart of a single framebuffer attachment.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="attachment"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static void InvalidateSubFramebuffer(FramebufferTarget target, FramebufferAttachmentType attachment, int x, int y, int width, int height)
        {
            InvalidateSubFramebuffer(target, 1, ref attachment, x, y, width, height);
        }

        /// <summary>
        /// Invalidates the content of an mutable texture id and optionally a single mipmap level.
        /// </summary>
        /// <param name="TextureID"></param>
        /// <param name="level"></param>
        [EntryPoint(FunctionName = "glInvalidateTexImage")]
        public static void InvalidateTexImage(uint TextureID, int level = 0){ throw new NotImplementedException(); }

        /// <summary>
        /// Invalidates a subpart of a mutable texture, optinally only in one mipmap level.
        /// </summary>
        /// <param name="TextureID"></param>
        /// <param name="level"></param>
        /// <param name="xoffset"></param>
        /// <param name="yoffset"></param>
        /// <param name="zoffset"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="depth"></param>
        [EntryPoint(FunctionName = "glInvalidateTexSubImage")]
        public static void InvalidateTexSubImage(uint TextureID, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth){ throw new NotImplementedException(); }

        //ARB_multi_draw_indirect        
        
        [EntryPoint(FunctionName = "glMultiDrawArraysIndirect")]
        public static void MultiDrawArraysIndirect(BeginMode mode, IntPtr Indirect, int drawCount, int Stride){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glMultiDrawElementsIndirect")]
        public static void MultiDrawElementsIndirect(BeginMode mode, IndicesType type, IntPtr Indirect, int drawCount, int Stride){ throw new NotImplementedException(); }

        //ARB_program_interface_query
        /// <summary>
        /// Returns from a program parameters defined by program interface.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="programInterface">Which interface to get common properties for</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetProgramInterfaceiv")]
        unsafe public static void GetProgramInterfaceiv(uint Program, ProgramInterface programInterface, ProgramInterfaceParameters pname, int* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Returns from a program parameters defined by program interface.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="programInterface">Which interface to get common properties for</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetProgramInterfaceiv")]
        public static void GetProgramInterfaceiv(uint Program, ProgramInterface programInterface, ProgramInterfaceParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Returns from a program parameters defined by program interface.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="programInterface">Which interface to get common properties for</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetProgramInterfaceiv")]
        public static void GetProgramInterfaceiv(uint Program, ProgramInterface programInterface, ProgramInterfaceParameters pname, ref int result) { throw new NotImplementedException(); }
        /// <summary>
        /// Returns from a program parameters defined by program interface.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="programInterface">Which interface to get common properties for</param>
        /// <param name="pname">Name of parameter to retrive.</param>        
        public static int GetProgramInterfaceiv(uint Program, ProgramInterface programInterface, ProgramInterfaceParameters pname)
        {
            int tmp = 0;
            GetProgramInterfaceiv(Program, programInterface, pname, ref tmp);
            return tmp;
        }
        /// <summary>
        /// Returns for a program and interface am index for a resource.
        /// </summary>
        /// <param name="Program">Program containg resource.</param>
        /// <param name="programInterface">The program interface containing resource.</param>
        /// <param name="Name">Name of resource to get index for.</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetProgramResourceIndex")]
        public static uint GetProgramResourceIndex(uint Program, ProgramInterface programInterface, string Name){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetProgramResourceLocation")]
        public static int GetProgramResourceLocation(uint Program, ProgramInterface programInterface, string Name){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetProgramResourceLocationIndex")]
        public static int GetProgramResourceLocationIndex(uint Program, ProgramInterface programInterface, string Name){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetProgramResourceName")]
        public static void GetProgramResourceName(uint Program, ProgramInterface programInterface, uint index, int bufSize, out int Lenght, StringBuilder Name){ throw new NotImplementedException(); }
        public static string GetProgramResourceName(uint Program, ProgramInterface programInterface, uint index, int MaxProgramResourceName = 64)
        {
            //int bufSize, out int Lenght,
            var sb = new StringBuilder(MaxProgramResourceName + 4);
            GetProgramResourceName(Program, programInterface, index, sb.Capacity - 2, out MaxProgramResourceName, sb);
            return sb.ToString();
        }
        [EntryPoint(FunctionName = "glGetProgramResourceiv")]
        unsafe public static void GetProgramResourceiv(uint Program, ProgramInterface programInterface, uint Index, int propCount, ProgramResourceProperties* props, int bufSize, out int Length, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetProgramResourceiv")]
        public static void GetProgramResourceiv(uint Program, ProgramInterface programInterface, uint Index, int propCount, ProgramResourceProperties[] props, int bufSize, out int Length, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetProgramResourceiv")]
        public static void GetProgramResourceiv(uint Program, ProgramInterface programInterface, uint Index, int propCount, ref ProgramResourceProperties props, int bufSize, out int Length, ref int result) { throw new NotImplementedException(); }

        public static int GetProgramResourceiv(uint Program, ProgramInterface programInterface, uint Index, ProgramResourceProperties[] props, int[] result)
        {
            int len = 0;
            GetProgramResourceiv(Program, programInterface, Index, props.Length, ref props[0], result.Length, out len, ref result[0]);
            return len;
        }

        public static int[] GetProgramResourceiv(uint Program, ProgramInterface programInterface, uint Index, ProgramResourceProperties property, int ResultSize = 1)
        {
            int tmp = 1;
            var result = new int[ResultSize];
            GetProgramResourceiv(Program, programInterface, Index, 1, ref property, 1, out tmp, ref result[0]);
            if (tmp < result.Length)
            {
                var test = new int[tmp];
                Array.Copy(result, test, tmp);
                return test;
            }
            else
                return result;
        }
        //ARB_shader_storage_buffer_object
        /// <summary>
        /// Sets up mapping between a ShaderStorageBlockBinding and a StorageBlockIndex inside a program.
        /// </summary>
        /// <param name="Program">Program containg StorageBlockIndex.</param>
        /// <param name="StorageBlockIndex">The StorageblockIndex to setup source data mapping.</param>
        /// <param name="StorageBlockBinding">The StorageBlockBinding where a Buffer id can be bound with BindBuffer[Base,Range] commands.</param>
        [EntryPoint(FunctionName = "glShaderStorageBlockBinding")]
        public static void ShaderStorageBlockBinding(uint Program, uint StorageBlockIndex, uint StorageBlockBinding){ throw new NotImplementedException(); }

        //ARB_texture_buffer_range
        
        [EntryPoint(FunctionName = "glTexBufferRange")]
        public static void TexBufferRange(BufferTextureTarget target, TextureBufferInternalFormat iformat, uint BufferId, IntPtr Offset, IntPtr Size){ throw new NotImplementedException(); }
        /// <summary>
        /// Attaches the range of the storage for the buffer object named buffer for size basic machine units, starting at offset (also in basic machine units) to the active buffer texture, and specifies an internal format for the texel array found in the range of the attached buffer object.
        /// </summary>
        /// <param name="iformat">internalformat specifies the storage format and must be one of the sized internal formats found in table 8.15.</param>
        /// <param name="BufferId">If buffer is zero, then any buffer object attached to the buffer texture is detached.</param>
        /// <param name="Offset">Size In bytes from start of bound buffer to where start of texel data.</param>
        /// <param name="Size">Size in bytes of texel data from offset.</param>
        /// <param name="target">target must be TEXTURE_BUFFER.</param>
        /// <remarks>
        /// If buffer is zero, then any buffer object attached to the buffer texture is detached, the values offset and size are ignored and the state for offset and size for the buffer texture are reset to zero.
        /// A buffer texture is similar to a one-dimensional texture. However, unlike other texture types, the texel array is not stored as part of the texture. Instead, a buffer object is attached to a buffer texture and the texel array is taken from that buffer object’s data store. When the contents of a buffer object’s data store are modified, those changes are reflected in the contents of any buffer texture to which the buffer object is attached.
        /// </remarks>
        public static void TexBufferRange(TextureBufferInternalFormat iformat, uint BufferId, long Offset, long Size, BufferTextureTarget target = BufferTextureTarget.TextureBuffer)
        {
            TexBufferRange(target, iformat, BufferId, (IntPtr)Offset, (IntPtr)Size);
        }

        //ARB_texture_storage_multisample

        /// <summary>
        /// Allocates an immutable multisample texture. Multisample texture can't have mipmaps.
        /// </summary>
        /// <param name="target">Texture target with currently bound texture id to create immutable multisample storage for.</param>
        /// <param name="samples">Number of samples to use.</param>
        /// <param name="piformat">Format of multisample texture.</param>
        /// <param name="width">Width</param>
        /// <param name="height">Height</param>
        /// <param name="fixedSampleLocations">Use fixed sample locations?</param>
        [EntryPoint(FunctionName = "glTexStorage2DMultisample")]
        public static void TexStorage2DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations){ throw new NotImplementedException(); }

        /// <summary>
        /// Allocates an immutable multisample texture. Multisample texture can't have mipmaps.
        /// </summary>
        /// <param name="target">Texture target with currently bound texture id to create immutable multisample storage for.</param>
        /// <param name="samples">Number of samples to use.</param>
        /// <param name="piformat">Format of multisample texture.</param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="depth"></param>
        /// <param name="fixedSampleLocations">Use fixed sample locations?</param>
        [EntryPoint(FunctionName = "glTexStorage3DMultisample")]
        public static void TexStorage3DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations){ throw new NotImplementedException(); }

        //ARB_texture_view
        /// <summary>
        /// Creates a view of an already existing Immutable texture, using its data as our texture data, possible changing how data should be viewed.
        /// </summary>
        /// <param name="TextureID">Existing nonallocated texture id to create texture view on.</param>
        /// <param name="target">The target this texture should be viewed as.</param>
        /// <param name="OriginalTextureId">The id of the original texture to use as texture storage. Must be immutable.</param>
        /// <param name="internalFormat">An internalformat compatible with format of OriginalTextureId</param>
        /// <param name="minLevel">min mipmap level aka base level</param>
        /// <param name="numLevels">number of mipmap levels (cant be more than OriginalTextureId)</param>
        /// <param name="minLayer">Minimum layer</param>
        /// <param name="numLayers">Maximum layer (cant be larger than OriginalTextureId)</param>
        [EntryPoint(FunctionName = "glTextureView")]
        public static void TextureView(uint TextureID, TextureTarget target, uint OriginalTextureId, PixelInternalFormat internalFormat, uint minLevel, uint numLevels, uint minLayer  = 0, uint numLayers = 0){ throw new NotImplementedException(); }

        //ARB_vertex_attrib_binding

        /// <summary>
        /// Binds a Buffer Object to a binding index.
        /// NOTE: Binding Index 0 is used by non-bindingindex aware functions. So Avoid it!
        /// </summary>
        /// <param name="bindingsIndex">Binding index to bind to. NOTE: Binding Index 0 is used by non-bindingindex aware functions. So Avoid it!</param>
        /// <param name="BufferID">ID if buffer to bind.</param>
        /// <param name="Offset">Offset in bytes to where binding index should use as source.</param>
        /// <param name="Stride">Cant be ZERO even for not inverleaved data, size between vertices.</param>
        [EntryPoint(FunctionName = "glBindVertexBuffer")]
        public static void BindVertexBuffer(uint bindingsIndex, uint BufferID, IntPtr Offset, int Stride){ throw new NotImplementedException(); }
        /// <summary>
        /// Binds a Buffer Object to a binding index.
        /// NOTE: Binding Index 0 is used by non-bindingindex aware functions. So Avoid it!
        /// </summary>
        /// <param name="bindingsIndex">Binding index to bind to. NOTE: Binding Index 0 is used by non-bindingindex aware functions. So Avoid it!</param>
        /// <param name="BufferID">ID if buffer to bind.</param>
        /// <param name="Offset">Offset in bytes to where binding index should use as source.</param>
        /// <param name="Stride">Cant be ZERO even for not inverleaved data, size between vertices.</param>
        public static void BindVertexBuffer(uint bindingsIndex, uint BufferID, long Offset, int Stride)
        {
            Debug.Assert(Stride != 0, "OpenGL Vertex Binding Api doesnt support stride=0 anymore!");
            BindVertexBuffer(bindingsIndex, BufferID, (IntPtr)Offset, Stride);
        }

        /// <summary>
        /// Sets up a mapping between a AttributeIndex with a Vertex Declaration and a binding index to bind buffer source to.
        /// NOTE: Binding Index 0 is used by non-bindingindex aware functions. So Avoid it!
        /// </summary>
        /// <param name="attribIndex">Attribute Index.</param>
        /// <param name="bindingsIndex">Binding Index.NOTE: Binding Index 0 is used by non-bindingindex aware functions. So Avoid it!</param>
        [EntryPoint(FunctionName = "glVertexAttribBinding")]
        public static void VertexAttribBinding(uint attribIndex, uint bindingsIndex){ throw new NotImplementedException(); }

        /// <summary>
        /// Sets the Vertex Divisor for a BindingIndex.
        /// </summary>
        /// <param name="bindingsIndex">NOTE: Binding Index 0 is used by non-bindingindex aware functions. So Avoid it!</param>
        /// <param name="divisor"></param>
        [EntryPoint(FunctionName = "glVertexBindingDivisor")]
        public static void VertexBindingDivisor(uint bindingsIndex, uint divisor){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glVertexAttribFormat")]
        public static void VertexAttribFormat(uint attribIndex, int Size, VertexAttribFormat type, bool normalized, uint relativeOffset){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets up the Vertex Declaration for a AttributeIndex without specifind source buffer.
        /// Source buffer are specified by bind to bindingindex and map bindingindex and attribute index afterwards.
        /// </summary>
        /// <param name="attribIndex">Attribute Index to specify vertex declaration for.</param>
        /// <param name="Size">Number of components in vertices. aka vec2f = 2, vec3f = 3 osv. or BGRA</param>
        /// <param name="type"></param>
        /// <param name="relativeOffset">offset in bytes from start of eventually bound buffer?</param>
        /// <param name="normalized">Is data normalized?</param>
        public static void VertexAttribFormat(uint attribIndex, int Size, VertexAttribFormat type, uint relativeOffset, bool normalized = false)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Sets up the Vertex Declaration for a AttributeIndex without specifind source buffer.
        /// Source buffer are specified by bind to bindingindex and map bindingindex and attribute index afterwards.
        /// </summary>
        /// <param name="attribIndex">Attribute Index to specify vertex declaration for.</param>
        /// <param name="Size">Number of components in vertices. aka vec2i = 2, vec3i = 3 osv.</param>
        /// <param name="itype">Integer type.</param>
        /// <param name="relativeOffset">offset in bytes from start of eventually bound buffer?</param>
        [EntryPoint(FunctionName = "glVertexAttribIFormat")]
        public static void VertexAttribIFormat(uint attribIndex, int Size, VertexAttribIFormat itype, uint relativeOffset){ throw new NotImplementedException(); }

        /// <summary>
        /// Sets up the Vertex Declaration for a AttributeIndex without specifind source buffer.
        /// Source buffer are specified by bind to bindingindex and map bindingindex and attribute index afterwards.
        /// </summary>
        /// <param name="attribIndex">Attribute Index to specify vertex declaration for.</param>
        /// <param name="Size">Number of components in vertices. aka vec2d = 2, vec3d = 3 osv.</param>
        /// <param name="ltype">Must be DOUBLE</param>
        /// <param name="relativeOffset">offset in bytes from start of eventually bound buffer?</param>
        [EntryPoint(FunctionName = "glVertexAttribLFormat")]
        public static void VertexAttribLFormat(uint attribIndex, int Size, VertexAttribLFormat ltype, uint relativeOffset){ throw new NotImplementedException(); }

        //ARB_framebuffer_no_attachments

        /// <summary>
        /// Sets a framebuffer parameter.
        /// </summary>
        /// <param name="target">id of framebuffer to set</param>
        /// <param name="pname">Name of parameter to change.</param>
        /// <param name="param">new value of parameter.</param>
        [EntryPoint(FunctionName = "glFramebufferParameteri")]
        public static void FramebufferParameteri(FramebufferTarget target, FramebufferParameters pname, int param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glFramebufferParameteri")]
        public static int FramebufferParameteri(FramebufferTarget target, FramebufferParameters pname) { throw new NotImplementedException(); }

        /// <summary>
        /// Retrives a parameter value from a framebuffer.
        /// </summary>
        /// <param name="target">id of framebuffer to query.</param>
        /// <param name="pname">Name of parameter to retive.</param>
        /// <param name="params">value of parameter</param>
        [EntryPoint(FunctionName = "glGetFramebufferParameteriv")]
        unsafe public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferParameters pname, int* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a parameter value from a framebuffer.
        /// </summary>
        /// <param name="target">id of framebuffer to query.</param>
        /// <param name="pname">Name of parameter to retive.</param>
        /// <param name="params">value of parameter</param>
        [EntryPoint(FunctionName = "glGetFramebufferParameteriv")]
        public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a parameter value from a framebuffer.
        /// </summary>
        /// <param name="target">id of framebuffer to query.</param>
        /// <param name="pname">Name of parameter to retive.</param>
        /// <param name="params">value of parameter</param>
        [EntryPoint(FunctionName = "glGetFramebufferParameteriv")]
        public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferParameters pname, ref int result) { throw new NotImplementedException(); }

        //KHR_debug / ARB_debug_output

        //public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int Count, uint* ids, bool Enabled){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glDebugMessageControl")]
        unsafe public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int Count, uint* ids, bool Enabled){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glDebugMessageControl")]
        public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int Count, uint[] ids, bool Enabled) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glDebugMessageControl")]
        public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int Count, ref uint ids, bool Enabled) { throw new NotImplementedException(); }
        /// <summary>
        /// Changes the properties of an array of debug message ids.
        /// This might be source, type, severity or just enable/disable them.
        /// Enables or Disables an array of Debug Messages ids
        /// </summary>
        /// <param name="source">Source of ids.</param>
        /// <param name="type">Type of ids</param>
        /// <param name="severity">Severity of ids.</param>
        /// <param name="ids">array of ids to change.</param>
        /// <param name="Enabled">Enables or disables the ids.</param>
        public static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, uint[] ids, bool Enabled)
        {
            DebugMessageControl(source, type, severity, ids != null ? ids.Length : 0, ids, Enabled);
        }
        /// <summary>
        /// Insert a new debug message in the debug message log array.
        /// </summary>
        /// <param name="source">Source of inserted message.</param>
        /// <param name="type">type of inserted message.</param>
        /// <param name="id">id of inserted message. Userid has own range of ids.</param>
        /// <param name="severity">Severity of inserted message.</param>
        /// <param name="Text">The text of inserted message.</param>
        [EntryPoint(FunctionName = "glDebugMessageInsert")]
        public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf){ throw new NotImplementedException(); }

        /// <summary>
        /// Defines the Debug MessageCallback Delegate and its optionally userParam.
        /// </summary>
        /// <param name="callback">Delegate to a function which will be called by opengl with debug messages.</param>
        /// <param name="userParam">Optionally userParam which will be one of the arguments opengl calls the delegate with.</param>
        [EntryPoint(FunctionName = "glDebugMessageCallback")]
        public static void DebugMessageCallback(DebugMessageDelegate callback, IntPtr userParam){ throw new NotImplementedException(); }
        /// <summary>
        /// Defines the Debug MessageCallback Delegate and its optionally userParam.
        /// </summary>
        /// <param name="callback">Delegate to a function which will be called by opengl with debug messages.</param>
        public static void DebugMessageCallback(DebugMessageDelegate callback)
        {
            DebugMessageCallback(callback, IntPtr.Zero);
        }

        [EntryPoint(FunctionName = "glGetDebugMessageLog")]
        unsafe public static uint GetDebugMessageLog(uint count, int bufsize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, StringBuilder messageLog){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetDebugMessageLog")]
        public static uint GetDebugMessageLog(uint count, int bufsize, DebugSource[] sources, DebugType[] types, uint[] ids, DebugSeverity[] severities, int[] lengths, StringBuilder messageLog) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetDebugMessageLog")]
        public static uint GetDebugMessageLog(uint count, int bufsize, ref DebugSource sources, ref DebugType types, ref uint ids, ref DebugSeverity severities, ref int lengths, StringBuilder messageLog) { throw new NotImplementedException(); }

        /// <summary>
        /// Retrives a number of messages from message log.
        /// How many retrives is determined by Math.Min([all arrays]) and availible messages.
        /// </summary>
        /// <param name="sources"></param>
        /// <param name="types"></param>
        /// <param name="ids"></param>
        /// <param name="severities"></param>
        /// <param name="messageLog">A single preallocated stringbuilder with enough capacity to contain all the messages?</param>
        /// <returns></returns>
        public static uint GetDebugMessageLog(DebugSource[] sources, DebugType[] types, uint[] ids, DebugSeverity[] severities, StringBuilder messageLog)
        {
            var count = Math.Min(sources.Length, Math.Min(types.Length, Math.Min(ids.Length, severities.Length)));
            var lengths = new int[count];

            var ret = GetDebugMessageLog((uint)count, messageLog.Capacity, sources, types, ids, severities, lengths, messageLog);

            return ret;
        }

        /// <summary>
        /// Returns a pointer.
        /// </summary>
        /// <param name="pname">The Pointer name to retrive.</param>
        /// <param name="ptr"></param>
        [EntryPoint(FunctionName = "glGetPointerv")]
        public static void GetPointerv(GetPointerName pname, out IntPtr ptr){ throw new NotImplementedException(); }

        //KHR_debug / ARB_debug_label
        /// <summary>
        /// Sets the label for an object specified by name. 
        /// </summary>
        /// <param name="idNamespace">Namespace where name belongs.</param>
        /// <param name="name">ID or name of object.</param>
        /// <param name="Label">Label to attach to object.</param>
        [EntryPoint(FunctionName = "glObjectLabel")]
        private static void ObjectLabel(DebugNamespace idNamespace, uint name, int LabelLength, string Label){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets the label for an object specified by name. 
        /// </summary>
        /// <param name="idNamespace">Namespace where name belongs.</param>
        /// <param name="name">ID or name of object.</param>
        /// <param name="Label">Label to attach to object.</param>        
        private static void ObjectLabel(DebugNamespace idNamespace, uint name, string Label)
        {
            ObjectLabel(idNamespace, name, Label.Length, Label);
        }

        [EntryPoint(FunctionName = "glGetObjectLabel")]
        private static void GetObjectLabel(DebugNamespace idNamespace, uint name, int bufsize, out int LabelLength, StringBuilder label){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives the label from a labeled object.
        /// </summary>
        /// <param name="idNamespace">Namespace where name belongs.</param>
        /// <param name="name">ID or name of object.</param>
        /// <param name="MaxObjectLabelLength">The capacity of created stringbuilder used to retrive label.</param>
        /// <returns>Label</returns>
        private static string GetObjectLabel(DebugNamespace idNamespace, uint name, int MaxObjectLabelLength = 64)
        {
            var sb = new StringBuilder(MaxObjectLabelLength + 4);
            GetObjectLabel(idNamespace, name, sb.Capacity - 2, out MaxObjectLabelLength, sb);
            return sb.ToString();
        }

        [EntryPoint(FunctionName = "glObjectPtrLabel")]
        private static void ObjectPtrLabel(IntPtr ptr, int length, string label){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets the label for an object identified by ptr.
        /// </summary>
        /// <param name="ptr">ptr/id/name of object.</param>
        /// <param name="label">Text Label to attach.</param>
        public static void ObjectPtrLabel(IntPtr ptr, string label)
        {
            ObjectPtrLabel(ptr, label.Length, label);
        }

        [EntryPoint(FunctionName = "glGetObjectPtrLabel")]
        private static void GetObjectPtrLabel(IntPtr ptr, int bufSize, out int length, StringBuilder label){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrives the label from a labeled object.
        /// </summary>
        /// <param name="ptr">ptr/id/name of object.</param>
        /// <param name="MaxObjectPtrLabelLength">The capacity of the temporarily created stringbuilder used to retrive label.</param>
        /// <returns></returns>
        private static string GetObjectPtrLabel(IntPtr ptr, int MaxObjectPtrLabelLength = 64)
        {
            var sb = new StringBuilder(MaxObjectPtrLabelLength + 4);
            GetObjectPtrLabel(ptr, sb.Capacity - 2, out MaxObjectPtrLabelLength, sb);
            return sb.ToString();
        }
        //KHR_debug / ARB_debug_group

        [EntryPoint(FunctionName = "glPushDebugGroup")]
        private static void PushDebugGroup(DebugSource source, uint id, int length, string message){ throw new NotImplementedException(); }

        /// <summary>
        /// Pushes a debug group onto debug push stack.
        /// Usefull to during debug track a small part of a program.
        /// example.
        ///     //at start
        ///     DebugMessageControl([disable all logging])
        ///     
        ///     //inside problematic part of ap.
        ///     PushDebugGroup("Enter Shader Compiler subpart of app1");
        ///     {
        ///             DebugMessageControl([LogEverything!]) // changes the control of the ACTIVE debug group.
        ///             ...
        ///     }
        ///     // will reset DebugMessageControl back to disable.
        ///     PopDebugGroup() 
        ///     
        ///     // other, uninteresting part of program.
        ///     ...
        /// </summary>
        /// <param name="source"></param>
        /// <param name="id">User Specified id</param>
        /// <param name="message">Message to </param>
        private static void PushDebugGroup(DebugSource source, uint id, string message)
        {
            PushDebugGroup(source, id, message.Length, message);
        }

        /// <summary>
        /// Pops a previusly pushed debug group, which also resets any DebugMessageControl properties back as it where before PushDebugGroup.
        /// </summary>
        [EntryPoint(FunctionName = "glPopDebugGroup")]
        public static void PopDebugGroup(){ throw new NotImplementedException(); }

        //ARB_ES3_compatibility
        // no functions

        // OpenGL 4.3 other functions
        /// <summary>
        /// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        /// ClearBufferfv should be used to clear fixed- and floating-point buffers.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="drawbuffer">If buffer is color, a colorAttachment to clear, otherwise 0/none</param>
        /// <param name="values">Dependent on buffer, se ClearBuffer Enum text for usage.</param>
        /// <remarks>
        /// If buffer is COLOR, a particular draw buffer DRAW_BUFFERi is specified by passing i as the parameter drawbuffer, and value points to a four-element vector specifying the R, G, B, and A color to clear that draw buffer to. 
        /// If buffer is DEPTH, drawbuffer must be zero, and value points to the single depth value to clear the depth buffer to.
        /// Only ClearBufferfv should be used to clear depth buffers.
        /// If buffer is STENCIL, drawbuffer must be zero, and value points to the single stencil value to clear the stencil buffer to.
        /// Only ClearBufferiv should be used to clear stencil buffers.
        /// Only ClearBufferfi accepts buffer = DEPTH_STENCIL
        /// </remarks>
        [EntryPoint(FunctionName = "glClearBufferfv")]
        unsafe public static void ClearBufferfv(ClearBuffer buffer, DrawBufferTarget drawbuffer, float* values){ throw new NotImplementedException(); }
        /// <summary>
        /// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        /// ClearBufferfv should be used to clear fixed- and floating-point buffers.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="drawbuffer">If buffer is color, a colorAttachment to clear, otherwise 0/none</param>
        /// <param name="values">Dependent on buffer, se ClearBuffer Enum text for usage.</param>
        /// <remarks>
        /// If buffer is COLOR, a particular draw buffer DRAW_BUFFERi is specified by passing i as the parameter drawbuffer, and value points to a four-element vector specifying the R, G, B, and A color to clear that draw buffer to. 
        /// If buffer is DEPTH, drawbuffer must be zero, and value points to the single depth value to clear the depth buffer to.
        /// Only ClearBufferfv should be used to clear depth buffers.
        /// If buffer is STENCIL, drawbuffer must be zero, and value points to the single stencil value to clear the stencil buffer to.
        /// Only ClearBufferiv should be used to clear stencil buffers.
        /// Only ClearBufferfi accepts buffer = DEPTH_STENCIL
        /// </remarks>
        [EntryPoint(FunctionName = "glClearBufferfv")]
        public static void ClearBufferfv(ClearBuffer buffer, DrawBufferTarget drawbuffer, float[] values) { throw new NotImplementedException(); }
        /// <summary>
        /// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        /// ClearBufferfv should be used to clear fixed- and floating-point buffers.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="drawbuffer">If buffer is color, a colorAttachment to clear, otherwise 0/none</param>
        /// <param name="values">Dependent on buffer, se ClearBuffer Enum text for usage.</param>
        /// <remarks>
        /// If buffer is COLOR, a particular draw buffer DRAW_BUFFERi is specified by passing i as the parameter drawbuffer, and value points to a four-element vector specifying the R, G, B, and A color to clear that draw buffer to. 
        /// If buffer is DEPTH, drawbuffer must be zero, and value points to the single depth value to clear the depth buffer to.
        /// Only ClearBufferfv should be used to clear depth buffers.
        /// If buffer is STENCIL, drawbuffer must be zero, and value points to the single stencil value to clear the stencil buffer to.
        /// Only ClearBufferiv should be used to clear stencil buffers.
        /// Only ClearBufferfi accepts buffer = DEPTH_STENCIL
        /// </remarks>
        [EntryPoint(FunctionName = "glClearBufferfv")]
        public static void ClearBufferfv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref float values) { throw new NotImplementedException(); }

        /// <summary>
        /// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        /// ClearBufferiv should be used to clear signed integer buffers.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="drawbuffer">If buffer is color, a colorAttachment to clear, otherwise 0/none</param>
        /// <param name="values">Dependent on buffer, se ClearBuffer Enum text for usage.</param>
        /// <remarks>
        /// If buffer is COLOR, a particular draw buffer DRAW_BUFFERi is specified by passing i as the parameter drawbuffer, and value points to a four-element vector specifying the R, G, B, and A color to clear that draw buffer to. 
        /// If buffer is DEPTH, drawbuffer must be zero, and value points to the single depth value to clear the depth buffer to.
        /// Only ClearBufferfv should be used to clear depth buffers.
        /// If buffer is STENCIL, drawbuffer must be zero, and value points to the single stencil value to clear the stencil buffer to.
        /// Only ClearBufferiv should be used to clear stencil buffers.
        /// Only ClearBufferfi accepts buffer = DEPTH_STENCIL
        /// </remarks>
        [EntryPoint(FunctionName = "glClearBufferiv")]
        unsafe public static void ClearBufferiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, int* values){ throw new NotImplementedException(); }
        /// <summary>
        /// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        /// ClearBufferiv should be used to clear signed integer buffers.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="drawbuffer">If buffer is color, a colorAttachment to clear, otherwise 0/none</param>
        /// <param name="values">Dependent on buffer, se ClearBuffer Enum text for usage.</param>
        /// <remarks>
        /// If buffer is COLOR, a particular draw buffer DRAW_BUFFERi is specified by passing i as the parameter drawbuffer, and value points to a four-element vector specifying the R, G, B, and A color to clear that draw buffer to. 
        /// If buffer is DEPTH, drawbuffer must be zero, and value points to the single depth value to clear the depth buffer to.
        /// Only ClearBufferfv should be used to clear depth buffers.
        /// If buffer is STENCIL, drawbuffer must be zero, and value points to the single stencil value to clear the stencil buffer to.
        /// Only ClearBufferiv should be used to clear stencil buffers.
        /// Only ClearBufferfi accepts buffer = DEPTH_STENCIL
        /// </remarks>
        [EntryPoint(FunctionName = "glClearBufferiv")]
        public static void ClearBufferiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, int[] values) { throw new NotImplementedException(); }
        /// <summary>
        /// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        /// ClearBufferiv should be used to clear signed integer buffers.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="drawbuffer">If buffer is color, a colorAttachment to clear, otherwise 0/none</param>
        /// <param name="values">Dependent on buffer, se ClearBuffer Enum text for usage.</param>
        /// <remarks>
        /// If buffer is COLOR, a particular draw buffer DRAW_BUFFERi is specified by passing i as the parameter drawbuffer, and value points to a four-element vector specifying the R, G, B, and A color to clear that draw buffer to. 
        /// If buffer is DEPTH, drawbuffer must be zero, and value points to the single depth value to clear the depth buffer to.
        /// Only ClearBufferfv should be used to clear depth buffers.
        /// If buffer is STENCIL, drawbuffer must be zero, and value points to the single stencil value to clear the stencil buffer to.
        /// Only ClearBufferiv should be used to clear stencil buffers.
        /// Only ClearBufferfi accepts buffer = DEPTH_STENCIL
        /// </remarks>
        [EntryPoint(FunctionName = "glClearBufferiv")]
        public static void ClearBufferiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref int values) { throw new NotImplementedException(); }

        /// <summary>
        /// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        /// ClearBufferuiv should be used to clear unsigned integer buffers.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="drawbuffer">If buffer is color, a colorAttachment to clear, otherwise 0/none</param>
        /// <param name="values">Dependent on buffer, se ClearBuffer Enum text for usage.</param>
        /// <remarks>
        /// If buffer is COLOR, a particular draw buffer DRAW_BUFFERi is specified by passing i as the parameter drawbuffer, and value points to a four-element vector specifying the R, G, B, and A color to clear that draw buffer to. 
        /// If buffer is DEPTH, drawbuffer must be zero, and value points to the single depth value to clear the depth buffer to.
        /// Only ClearBufferfv should be used to clear depth buffers.
        /// If buffer is STENCIL, drawbuffer must be zero, and value points to the single stencil value to clear the stencil buffer to.
        /// Only ClearBufferiv should be used to clear stencil buffers.
        /// Only ClearBufferfi accepts buffer = DEPTH_STENCIL
        /// </remarks>
        [EntryPoint(FunctionName = "glClearBufferuiv")]
        unsafe public static void ClearBufferuiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, uint* values){ throw new NotImplementedException(); }
        /// <summary>
        /// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        /// ClearBufferuiv should be used to clear unsigned integer buffers.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="drawbuffer">If buffer is color, a colorAttachment to clear, otherwise 0/none</param>
        /// <param name="values">Dependent on buffer, se ClearBuffer Enum text for usage.</param>
        /// <remarks>
        /// If buffer is COLOR, a particular draw buffer DRAW_BUFFERi is specified by passing i as the parameter drawbuffer, and value points to a four-element vector specifying the R, G, B, and A color to clear that draw buffer to. 
        /// If buffer is DEPTH, drawbuffer must be zero, and value points to the single depth value to clear the depth buffer to.
        /// Only ClearBufferfv should be used to clear depth buffers.
        /// If buffer is STENCIL, drawbuffer must be zero, and value points to the single stencil value to clear the stencil buffer to.
        /// Only ClearBufferiv should be used to clear stencil buffers.
        /// Only ClearBufferfi accepts buffer = DEPTH_STENCIL
        /// </remarks>
        [EntryPoint(FunctionName = "glClearBufferuiv")]
        public static void ClearBufferuiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, uint[] values) { throw new NotImplementedException(); }
        /// <summary>
        /// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        /// ClearBufferuiv should be used to clear unsigned integer buffers.
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="drawbuffer">If buffer is color, a colorAttachment to clear, otherwise 0/none</param>
        /// <param name="values">Dependent on buffer, se ClearBuffer Enum text for usage.</param>
        /// <remarks>
        /// If buffer is COLOR, a particular draw buffer DRAW_BUFFERi is specified by passing i as the parameter drawbuffer, and value points to a four-element vector specifying the R, G, B, and A color to clear that draw buffer to. 
        /// If buffer is DEPTH, drawbuffer must be zero, and value points to the single depth value to clear the depth buffer to.
        /// Only ClearBufferfv should be used to clear depth buffers.
        /// If buffer is STENCIL, drawbuffer must be zero, and value points to the single stencil value to clear the stencil buffer to.
        /// Only ClearBufferiv should be used to clear stencil buffers.
        /// Only ClearBufferfi accepts buffer = DEPTH_STENCIL
        /// </remarks>
        [EntryPoint(FunctionName = "glClearBufferuiv")]
        public static void ClearBufferuiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref uint values) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glClearBufferfi")]
        public static void ClearBufferfi(ClearBuffer buffer, DrawBufferTarget drawbuffer, float depth, int stencil){ throw new NotImplementedException(); }

        /// <summary>
        /// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        /// ClearBufferfi is equivalent to clearing the depth and stencil buffers separately, but may be faster when a buffer of internal format DEPTH_STENCIL is being cleared. 
        /// </summary>
        /// <param name="depth">depth and sten-cil are the values to clear the depth and stencil buffers to, respectively</param>
        /// <param name="stencil">depth and sten-cil are the values to clear the depth and stencil buffers to, respectively</param>
        /// <param name="buffer">buffer must be DEPTH_STENCIL</param>
        /// <param name="drawbuffer">drawbuffer must be zero/NONE.</param>
        public static void ClearBufferfi(float depth, int stencil, ClearBuffer buffer = ClearBuffer.DepthStencil, DrawBufferTarget drawbuffer = DrawBufferTarget.None)
        {
            ClearBufferfi(buffer, drawbuffer, depth, stencil);
        }

        /// <summary>
        /// Clears the depth buffer. Overload of glClearBufferfv with correct settings.
        /// </summary>
        /// <param name="depth"></param>
        public static void ClearBufferDepth(float depth)
        {
            ClearBufferfv(ClearBuffer.Depth, (DrawBufferTarget)0, ref depth);
        }
        /// <summary>
        /// Clears the stencil buffer. Overload of glClearBufferiv with correct settings.
        /// </summary>
        /// <param name="stencil"></param>
        public static void ClearBufferStencil(int stencil)
        {
            ClearBufferiv(ClearBuffer.Stencil, (DrawBufferTarget)0, ref stencil);
        }

        #endregion

        #region Public Helper Functions

        #endregion

    }
}
