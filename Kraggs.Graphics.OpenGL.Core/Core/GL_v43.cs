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
        //#region Delegate Class

        //partial class Delegates
        //{

        //    #region Delegates

        //    //ARB_clear_buffer_object
        //    public delegate void delClearBufferData(BufferTarget target, TextureBufferInternalFormat internalformat, ClearBufferDataFormat format, PixelType type, IntPtr data);
        //    public delegate void delClearBufferSubData(BufferTarget target, TextureBufferInternalFormat internalformat, IntPtr Offset, IntPtr Size, ClearBufferDataFormat format, PixelType type, IntPtr data);

        //    //ARB_compute_shader
        //    public delegate void delDispatchCompute(uint num_group_x, uint num_groups_y, uint num_groups_z);
        //    public delegate void delDispatchComputeIndirect(IntPtr Indirect);

        //    // ARB_copy_image
        //    public delegate void delCopyImageSubData(uint srcName, GetInternalformatTargets srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GetInternalformatTargets dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth);

        //    //ARB_internalformat_query2
        //    public delegate void delGetInternalformati64v(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname, int bufSize, ref long @params);

        //    //ARB_invalidate_subdata
        //    public delegate void delInvalidateBufferData(uint BufferId);
        //    public delegate void delInvalidateBufferSubData(uint BufferId, IntPtr Offset, IntPtr Length);
        //    public delegate void delInvalidateFramebuffer(FramebufferTarget target, int numAttachments, ref FramebufferAttachmentType attachments);
        //    public delegate void delInvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, ref FramebufferAttachmentType attachments, int x, int y, int width, int height);
        //    public delegate void delInvalidateTexImage(uint TextureID, int level);
        //    public delegate void delInvalidateTexSubImage(uint TextureID, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth);

        //    //ARB_multi_draw_indirect
        //    public delegate void delMultiDrawArraysIndirect(BeginMode mode, IntPtr Indirect, int drawCount, int Stride);
        //    public delegate void delMultiDrawElementsIndirect(BeginMode mode, IndicesType type, IntPtr Indirect, int drawCount, int Stride);

        //    //ARB_program_interface_query
        //    public delegate void delGetProgramInterfaceiv(uint Program, ProgramInterface programInterface, ProgramInterfaceParameters pname, ref int @params);
        //    public delegate uint delGetProgramResourceIndex(uint Program, ProgramInterface programInterface, string Name);
        //    public delegate int delGetProgramResourceLocation(uint Program, ProgramInterface programInterface, string Name);
        //    public delegate int delGetProgramResourceLocationIndex(uint Program, ProgramInterface programInterface, string Name);
        //    public delegate void delGetProgramResourceName(uint Program, ProgramInterface programInterface, uint index, int bufSize, out int Lenght, StringBuilder Name);
        //    public delegate void delGetProgramResourceiv(uint Program, ProgramInterface programInterface, uint Index, int propCount, ref ProgramResourceProperties props, int bufSize, out int Length, ref int @params);

        //    //ARB_shader_storage_buffer_object
        //    public delegate void delShaderStorageBlockBinding(uint Program, uint StorageBlockIndex, uint StorageBlockBinding);

        //    //ARB_texture_buffer_range
        //    public delegate void delTexBufferRange(BufferTextureTarget target, TextureBufferInternalFormat iformat, uint BufferId, IntPtr Offset, IntPtr Size);

        //    //ARB_texture_storage_multisample
        //    public delegate void delTexStorage2DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations);
        //    public delegate void delTexStorage3DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations);

        //    //ARB_texture_view
        //    public delegate void delTextureView(uint TextureID, TextureTarget target, uint OriginalTextureId, PixelInternalFormat internalFormat, uint minLevel, uint numLevels, uint minLayer, uint numLayers);

        //    //ARB_vertex_attrib_binding
        //    public delegate void delBindVertexBuffer(uint bindingsIndex, uint BufferID, IntPtr Offset, int Stride);
        //    public delegate void delVertexAttribBinding(uint attribIndex, uint bindingsIndex);
        //    public delegate void delVertexBindingDivisor(uint bindingsIndex, uint divisor);

        //    public delegate void delVertexAttribFormat(uint attribIndex, int Size, VertexAttribFormat type, bool normalized, uint relativeOffset);
        //    public delegate void delVertexAttribIFormat(uint attribIndex, int Size, VertexAttribIFormat itype, uint relativeOffset);
        //    public delegate void delVertexAttribLFormat(uint attribIndex, int Size, VertexAttribLFormat ltype, uint relativeOffset);

        //    //ARB_framebuffer_no_attachments
        //    public delegate void delFramebufferParameteri(FramebufferTarget target, FramebufferParameters pname, int param);
        //    public delegate void delGetFramebufferParameteriv(FramebufferTarget target, FramebufferParameters pname, ref int @params);

        //    //KHR_debug / ARB_debug_output

        //    //public delegate void delDebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int Count, ref uint ids, bool Enabled);
        //    public unsafe delegate void delDebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, int Count, uint* ids, bool Enabled);
        //    public delegate void delDebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf);
        //    public delegate void delDebugMessageCallback(DebugMessageDelegate callback, IntPtr userParam);
        //    public delegate uint delGetDebugMessageLog(uint count, int bufsize, ref DebugSource sources, ref DebugType types, ref uint ids, ref DebugSeverity severities, ref int lengths, StringBuilder messageLog);
        //    public delegate void delGetPointerv(GetPointerName pname, out IntPtr ptr);

        //    //KHR_debug / ARB_debug_label
        //    public delegate void delObjectLabel(DebugNamespace idNamespace, uint name, int LabelLength, string Label);
        //    public delegate void delGetObjectLabel(DebugNamespace idNamespace, uint name, int bufsize, out int LabelLength, StringBuilder label);
        //    public delegate void delObjectPtrLabel(IntPtr ptr, int length, string label);
        //    public delegate void delGetObjectPtrLabel(IntPtr ptr, int bufSize, out int length, StringBuilder label);

        //    //KHR_debug / ARB_debug_group
        //    public delegate void delPushDebugGroup(DebugSource source, uint id, int length, string message);
        //    public delegate void delPopDebugGroup();

        //    //ARB_ES3_compatibility
        //    // no functions

        //    // OpenGL 4.3 other functions
        //    public delegate void delClearBufferfv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref float values );
        //    public delegate void delClearBufferiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref int values);
        //    public delegate void delClearBufferuiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref uint values);

        //    public delegate void delClearBufferfi(ClearBuffer buffer, DrawBufferTarget drawbuffer, float depth, int stencil);

        //    #endregion

        //    #region GL Fields

        //    //ARB_clear_buffer_object
        //    public static delClearBufferData glClearBufferData;
        //    public static delClearBufferSubData glClearBufferSubData;

        //    //ARB_compute_shader
        //    public static delDispatchCompute glDispatchCompute;
        //    public static delDispatchComputeIndirect glDispatchComputeIndirect;

        //    //ARB_copy_image
        //    public static delCopyImageSubData glCopyImageSubData;

        //    //ARB_internalformat_query2
        //    public static delGetInternalformati64v glGetInternalformati64v;

        //    //ARB_invalidate_subdata
        //    public static delInvalidateBufferData glInvalidateBufferData;
        //    public static delInvalidateBufferSubData glInvalidateBufferSubData;
        //    public static delInvalidateFramebuffer glInvalidateFramebuffer;
        //    public static delInvalidateSubFramebuffer glInvalidateSubFramebuffer;
        //    public static delInvalidateTexImage glInvalidateTexImage;
        //    public static delInvalidateTexSubImage glInvalidateTexSubImage;

        //    //ARB_multi_draw_indirect
        //    public static delMultiDrawArraysIndirect glMultiDrawArraysIndirect;
        //    public static delMultiDrawElementsIndirect glMultiDrawElementsIndirect;

        //    //ARB_program_interface_query
        //    public static delGetProgramInterfaceiv glGetProgramInterfaceiv;
        //    public static delGetProgramResourceIndex glGetProgramResourceIndex;
        //    public static delGetProgramResourceLocation glGetProgramResourceLocation;
        //    public static delGetProgramResourceLocationIndex glGetProgramResourceLocationIndex;
        //    public static delGetProgramResourceName glGetProgramResourceName;
        //    public static delGetProgramResourceiv glGetProgramResourceiv;

        //    //ARB_shader_storage_buffer_object
        //    public static delShaderStorageBlockBinding glShaderStorageBlockBinding;

        //    //ARB_texture_buffer_range
        //    public static delTexBufferRange glTexBufferRange;

        //    //ARB_texture_storage_multisample
        //    public static delTexStorage2DMultisample glTexStorage2DMultisample;
        //    public static delTexStorage3DMultisample glTexStorage3DMultisample;

        //    //ARB_texture_view
        //    public static delTextureView glTextureView;

        //    //ARB_vertex_attrib_binding
        //    public static delBindVertexBuffer glBindVertexBuffer;
        //    public static delVertexAttribBinding glVertexAttribBinding;
        //    public static delVertexBindingDivisor glVertexBindingDivisor;
        //    public static delVertexAttribFormat glVertexAttribFormat;
        //    public static delVertexAttribIFormat glVertexAttribIFormat;
        //    public static delVertexAttribLFormat glVertexAttribLFormat;

        //    //ARB_framebuffer_no_attachment
        //    public static delFramebufferParameteri glFramebufferParameteri;
        //    public static delGetFramebufferParameteriv glGetFramebufferParameteriv;

        //    //KHR_debug 
        //    public static delDebugMessageControl glDebugMessageControl;
        //    public static delDebugMessageInsert glDebugMessageInsert;
        //    public static delDebugMessageCallback glDebugMessageCallback;
        //    public static delGetDebugMessageLog glGetDebugMessageLog;
        //    public static delGetPointerv glGetPointerv;

        //    public static delObjectLabel glObjectLabel;
        //    public static delGetObjectLabel glGetObjectLabel;
        //    public static delObjectPtrLabel glObjectPtrLabel;
        //    public static delGetObjectPtrLabel glGetObjectPtrLabel;

        //    public static delPushDebugGroup glPushDebugGroup;
        //    public static delPopDebugGroup glPopDebugGroup;

        //    // OpenGL 4.3 other functions
        //    public static delClearBufferfv glClearBufferfv;
        //    public static delClearBufferiv glClearBufferiv;
        //    public static delClearBufferuiv glClearBufferuiv;

        //    public static delClearBufferfi glClearBufferfi;


        //    #endregion
        //}

        //#endregion

        //#region Public functions.

        ////ARB_clear_buffer_object
        ///// <summary>
        ///// Clears the internal storage of a texture buffer.
        ///// </summary>
        ///// <param name="target"></param>
        ///// <param name="internalformat"></param>
        ///// <param name="format"></param>
        ///// <param name="type"></param>
        ///// <param name="data"></param>
        //public static void ClearBufferData(BufferTarget target, TextureBufferInternalFormat internalformat, ClearBufferDataFormat format, PixelType type, IntPtr data)
        //{
        //    Delegates.glClearBufferData(target, internalformat, format, type, data);
        //}
        ///// <summary>
        ///// Clears subparts of internal storage of a texture buffer.
        ///// </summary>
        ///// <param name="target"></param>
        ///// <param name="internalformat"></param>
        ///// <param name="Offset"></param>
        ///// <param name="Size"></param>
        ///// <param name="format"></param>
        ///// <param name="type"></param>
        ///// <param name="data"></param>
        //public static void ClearBufferSubData(BufferTarget target, TextureBufferInternalFormat internalformat, long Offset, long Size, ClearBufferDataFormat format, PixelType type, IntPtr data)
        //{
        //    Delegates.glClearBufferSubData(target, internalformat, (IntPtr)Offset, (IntPtr)Size, format, type, data);
        //}


        ////ARB_compute_shader
        ///// <summary>
        ///// Starts running a compute shader.
        ///// </summary>
        ///// <param name="num_group_x"></param>
        ///// <param name="num_groups_y"></param>
        ///// <param name="num_groups_z"></param>
        //public static void DispatchCompute(uint num_group_x, uint num_groups_y, uint num_groups_z)
        //{
        //    Delegates.glDispatchCompute(num_group_x, num_groups_y, num_groups_z);
        //}
        ///// <summary>
        ///// Starts running a compute shader.
        ///// </summary>
        ///// <param name="Indirect"></param>
        //public static void DispatchComputeIndirect(IntPtr Indirect)
        //{
        //    Delegates.glDispatchComputeIndirect(Indirect);
        //}

        ////ARB_copy_image
        ///// <summary>
        ///// Copies parts of an texture mipmap level to another textures mipmap level.
        ///// The Copy can not make the destination target larger to source target.
        ///// </summary>
        ///// <param name="srcName"></param>
        ///// <param name="srcTarget"></param>
        ///// <param name="srcLevel"></param>
        ///// <param name="srcX"></param>
        ///// <param name="srcY"></param>
        ///// <param name="srcZ"></param>
        ///// <param name="dstName"></param>
        ///// <param name="dstTarget"></param>
        ///// <param name="dstLevel"></param>
        ///// <param name="dstX"></param>
        ///// <param name="dstY"></param>
        ///// <param name="dstZ"></param>
        ///// <param name="srcWidth"></param>
        ///// <param name="srcHeight"></param>
        ///// <param name="srcDepth"></param>
        //public static void CopyImageSubData(uint srcName, GetInternalformatTargets srcTarget, int srcLevel, int srcX, int srcY, int srcZ, uint dstName, GetInternalformatTargets dstTarget, int dstLevel, int dstX, int dstY, int dstZ, int srcWidth, int srcHeight, int srcDepth)
        //{
        //    Delegates.glCopyImageSubData(srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);
        //}

        ////ARB_internalformat_query2
        ///// <summary>
        ///// Retrives an array of values for a combination of target and internal format query of parameter value.
        ///// aka check if render to RGBA32F is something we should do?
        /////     if(GetInternalformati64v(Renderbuffer, RGBA32F, InternalFormatSupported) == FULL_SUPPORT)
        /////     {
        /////         // render.
        /////     }
        ///// </summary>
        ///// <param name="target">Where should internalformat be used?</param>
        ///// <param name="internalformat">The internal format to query</param>
        ///// <param name="pname">Name of parameter to retrive data for above combo.</param>
        ///// <param name="params">Long array big enough to retrive expected result.</param>
        //public static void GetInternalformati64v(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname, long[] @params)
        //{
        //    Delegates.glGetInternalformati64v(target, internalformat, pname, @params.Length, ref @params[0]);
        //}
        ///// <summary>
        ///// Retrives a single long parameter value from a combination of target and paramenter name.
        ///// </summary>
        ///// <param name="target">Where should Internalformat be used.</param>
        ///// <param name="internalformat">The internal format to query.</param>
        ///// <param name="pname">Name of parameter to retrive for above combo.</param>
        ///// <returns></returns>
        //public static long GetInternalformati64v(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname)
        //{
        //    long tmp = 0;
        //    Delegates.glGetInternalformati64v(target, internalformat, pname, 1, ref tmp);
        //    return tmp;
        //}

        ////ARB_invalidate_subdata
        ///// <summary>
        ///// Invalidates the content of a buffer. aka detaches storage.
        ///// </summary>
        ///// <param name="BufferId"></param>
        //public static void InvalidateBufferData(uint BufferId)
        //{
        //    Delegates.glInvalidateBufferData(BufferId);
        //}
        ///// <summary>
        ///// Invalidates a subrange of a buffer.
        ///// </summary>
        ///// <param name="BufferId"></param>
        ///// <param name="Offset"></param>
        ///// <param name="Length"></param>
        //public static void InvalidateBufferSubData(uint BufferId, long Offset, long Length)
        //{
        //    Delegates.glInvalidateBufferSubData(BufferId, (IntPtr)Offset, (IntPtr)Length);
        //}
        ///// <summary>
        ///// Invalidates the content of a framebuffers attachments.
        ///// </summary>
        ///// <param name="target"></param>
        ///// <param name="attachments"></param>
        //public static void InvalidateFramebuffer(FramebufferTarget target, FramebufferAttachmentType[] attachments)
        //{
        //    Delegates.glInvalidateFramebuffer(target, attachments.Length, ref attachments[0]);
        //}
        ///// <summary>
        ///// Invalidates the contents of a single framebuffer attachement.
        ///// </summary>
        ///// <param name="target"></param>
        ///// <param name="attachment"></param>
        //public static void InvalidateFramebuffer(FramebufferTarget target, FramebufferAttachmentType attachment)
        //{
        //    Delegates.glInvalidateFramebuffer(target, 1, ref attachment);
        //}

        ///// <summary>
        ///// Invalidates subparts of several framebuffer attachments.
        ///// </summary>
        ///// <param name="target"></param>
        ///// <param name="attachments"></param>
        ///// <param name="x"></param>
        ///// <param name="y"></param>
        ///// <param name="width"></param>
        ///// <param name="height"></param>
        //public static void InvalidateSubFramebuffer(FramebufferTarget target, FramebufferAttachmentType[] attachments, int x, int y, int width, int height)
        //{
        //    Delegates.glInvalidateSubFramebuffer(target, attachments.Length, ref attachments[0], x, y, width, height);
        //}
        ///// <summary>
        ///// Invalidates a subpart of a single framebuffer attachment.
        ///// </summary>
        ///// <param name="target"></param>
        ///// <param name="attachment"></param>
        ///// <param name="x"></param>
        ///// <param name="y"></param>
        ///// <param name="width"></param>
        ///// <param name="height"></param>
        //public static void InvalidateSubFramebuffer(FramebufferTarget target, FramebufferAttachmentType attachment, int x, int y, int width, int height)
        //{
        //    Delegates.glInvalidateSubFramebuffer(target, 1, ref attachment, x, y, width, height);
        //}

        ///// <summary>
        ///// Invalidates the content of an mutable texture id and optionally a single mipmap level.
        ///// </summary>
        ///// <param name="TextureID"></param>
        ///// <param name="level"></param>
        //public static void InvalidateTexImage(uint TextureID, int level = 0)
        //{
        //    Delegates.glInvalidateTexImage(TextureID, level);
        //}
        ///// <summary>
        ///// Invalidates a subpart of a mutable texture, optinally only in one mipmap level.
        ///// </summary>
        ///// <param name="TextureID"></param>
        ///// <param name="level"></param>
        ///// <param name="xoffset"></param>
        ///// <param name="yoffset"></param>
        ///// <param name="zoffset"></param>
        ///// <param name="width"></param>
        ///// <param name="height"></param>
        ///// <param name="depth"></param>
        //public static void InvalidateTexSubImage(uint TextureID, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth)
        //{
        //    Delegates.glInvalidateTexSubImage(TextureID, level, xoffset, yoffset, zoffset, width, height, depth);
        //}
        ////ARB_multi_draw_indirect
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="mode"></param>
        ///// <param name="Indirect"></param>
        ///// <param name="drawCount"></param>
        ///// <param name="Stride"></param>
        //public static void MultiDrawArraysIndirect(BeginMode mode, IntPtr Indirect, int drawCount, int Stride)
        //{
        //    Delegates.glMultiDrawArraysIndirect(mode, Indirect, drawCount, Stride);
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="mode"></param>
        ///// <param name="type"></param>
        ///// <param name="IndirectOffset"></param>
        ///// <param name="drawCount"></param>
        ///// <param name="Stride"></param>
        //public static void MultiDrawElementsIndirect(BeginMode mode, IndicesType type, long IndirectOffset, int drawCount, int Stride)
        //{
        //    Delegates.glMultiDrawElementsIndirect(mode, type, (IntPtr)IndirectOffset, drawCount, Stride);
        //}
        ////ARB_program_interface_query
        ///// <summary>
        ///// Returns from a program parameters defined by program interface.
        ///// </summary>
        ///// <param name="Program">Program to query.</param>
        ///// <param name="programInterface">Which interface to get common properties for</param>
        ///// <param name="pname">Name of parameter to retrive.</param>
        ///// <param name="params"></param>
        //public static void GetProgramInterfaceiv(uint Program, ProgramInterface programInterface, ProgramInterfaceParameters pname, int[] @params)
        //{
        //    Delegates.glGetProgramInterfaceiv(Program, programInterface, pname, ref @params[0]);
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="Program"></param>
        ///// <param name="programInterface"></param>
        ///// <param name="pname"></param>
        ///// <param name="params"></param>
        ///// <returns></returns>
        //public static int GetProgramInterfaceiv(uint Program, ProgramInterface programInterface, ProgramInterfaceParameters pname)
        //{
        //    int tmp = 0;
        //    Delegates.glGetProgramInterfaceiv(Program, programInterface, pname, ref tmp);
        //    return tmp;
        //}
        ///// <summary>
        ///// Returns for a program and interface am index for a resource.
        ///// </summary>
        ///// <param name="Program">Program containg resource.</param>
        ///// <param name="programInterface">The program interface containing resource.</param>
        ///// <param name="Name">Name of resource to get index for.</param>
        ///// <returns></returns>
        //public static uint GetProgramResourceIndex(uint Program, ProgramInterface programInterface, string Name)
        //{
        //    return Delegates.glGetProgramResourceIndex(Program, programInterface, Name);
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="Program"></param>
        ///// <param name="programInterface"></param>
        ///// <param name="Name"></param>
        ///// <returns></returns>
        //public static int GetProgramResourceLocation(uint Program, ProgramInterface programInterface, string Name)
        //{
        //    return Delegates.glGetProgramResourceLocation(Program, programInterface, Name);
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="Program"></param>
        ///// <param name="programInterface"></param>
        ///// <param name="Name"></param>
        ///// <returns></returns>
        //public static int GetProgramResourceLocationIndex(uint Program, ProgramInterface programInterface, string Name)
        //{
        //    return Delegates.glGetProgramResourceLocationIndex(Program, programInterface, Name);
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="Program"></param>
        ///// <param name="programInterface"></param>
        ///// <param name="index"></param>
        ///// <param name="bufSize"></param>
        ///// <param name="Lenght"></param>
        ///// <param name="Name"></param>
        //public static void GetProgramResourceName(uint Program, ProgramInterface programInterface, uint index, int bufSize, out int Lenght, StringBuilder Name)
        //{
        //    Delegates.glGetProgramResourceName(Program, programInterface, index, bufSize, out Lenght, Name);
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="Program"></param>
        ///// <param name="programInterface"></param>
        ///// <param name="index"></param>
        ///// <param name="Name"></param>
        ///// <param name="DefaultStringBuilderSize"></param>
        ///// <returns></returns>
        //public static string GetProgramResourceName(uint Program, ProgramInterface programInterface, uint index, string Name, int DefaultStringBuilderSize = 64)
        //{
        //    var sb = new StringBuilder(DefaultStringBuilderSize + 4);
        //    Delegates.glGetProgramResourceName(Program, programInterface, index, sb.Capacity - 2, out DefaultStringBuilderSize, sb);
        //    return sb.ToString();
        //}

        //public static void GetProgramResourceiv(uint Program, ProgramInterface programInterface, uint Index, ProgramResourceProperties[] props, out int Length, int[] @params)
        //{
        //    Delegates.glGetProgramResourceiv(Program, programInterface, Index, props.Length, ref props[0], @params.Length, out Length, ref @params[0]);
        //}
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="Program"></param>
        ///// <param name="programInterface"></param>
        ///// <param name="Index"></param>
        ///// <param name="property"></param>
        ///// <returns></returns>
        //public static int[] GetProgramResourceiv(uint Program, ProgramInterface programInterface, uint Index, ProgramResourceProperties property, int ResultSize = 1)
        //{
        //    int tmp = 1;
        //    var result = new int[ResultSize];
        //    Delegates.glGetProgramResourceiv(Program, programInterface, Index, 1, ref property, 1, out tmp, ref result[0]);
        //    if (tmp < result.Length)
        //    {
        //        var test = new int[tmp];
        //        Array.Copy(result, test, tmp);
        //        return test;
        //    }
        //    else
        //        return result;
        //}

        ////ARB_shader_storage_buffer_object
        ///// <summary>
        ///// Sets up mapping between a ShaderStorageBlockBinding and a StorageBlockIndex inside a program.
        ///// </summary>
        ///// <param name="Program">Program containg StorageBlockIndex.</param>
        ///// <param name="StorageBlockIndex">The StorageblockIndex to setup source data mapping.</param>
        ///// <param name="StorageBlockBinding">The StorageBlockBinding where a Buffer id can be bound with BindBuffer[Base,Range] commands.</param>
        //public static void ShaderStorageBlockBinding(uint Program, uint StorageBlockIndex, uint StorageBlockBinding)
        //{
        //    Delegates.glShaderStorageBlockBinding(Program, StorageBlockIndex, StorageBlockBinding);
        //}
        ////ARB_texture_buffer_range
        ///// <summary>
        ///// Attaches the range of the storage for the buffer object named buffer for size basic machine units, starting at offset (also in basic machine units) to the active buffer texture, and specifies an internal format for the texel array found in the range of the attached buffer object.
        ///// </summary>
        ///// <param name="iformat">internalformat specifies the storage format and must be one of the sized internal formats found in table 8.15.</param>
        ///// <param name="BufferId">If buffer is zero, then any buffer object attached to the buffer texture is detached.</param>
        ///// <param name="Offset">Size In bytes from start of bound buffer to where start of texel data.</param>
        ///// <param name="Size">Size in bytes of texel data from offset.</param>
        ///// <param name="target">target must be TEXTURE_BUFFER.</param>
        ///// <remarks>
        ///// If buffer is zero, then any buffer object attached to the buffer texture is detached, the values offset and size are ignored and the state for offset and size for the buffer texture are reset to zero.
        ///// A buffer texture is similar to a one-dimensional texture. However, unlike other texture types, the texel array is not stored as part of the texture. Instead, a buffer object is attached to a buffer texture and the texel array is taken from that buffer object’s data store. When the contents of a buffer object’s data store are modified, those changes are reflected in the contents of any buffer texture to which the buffer object is attached.
        ///// </remarks>
        //public static void TexBufferRange(TextureBufferInternalFormat iformat, uint BufferId, long Offset, long Size, BufferTextureTarget target = BufferTextureTarget.TextureBuffer)
        //{
        //    Delegates.glTexBufferRange(target, iformat, BufferId, (IntPtr)Offset, (IntPtr)Size);
        //}
        ////ARB_texture_storage_multisample
        ///// <summary>
        ///// Allocates an immutable multisample texture. Multisample texture can't have mipmaps.
        ///// </summary>
        ///// <param name="target">Texture target with currently bound texture id to create immutable multisample storage for.</param>
        ///// <param name="samples">Number of samples to use.</param>
        ///// <param name="piformat">Format of multisample texture.</param>
        ///// <param name="width">Width</param>
        ///// <param name="height">Height</param>
        ///// <param name="fixedSampleLocations">Use fixed sample locations?</param>
        //public static void TexStorage2DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations)
        //{
        //    Delegates.glTexStorage2DMultisample(target, samples, piformat, width, height, fixedSampleLocations);
        //}
        ///// <summary>
        ///// Allocates an immutable multisample texture. Multisample texture can't have mipmaps.
        ///// </summary>
        ///// <param name="target">Texture target with currently bound texture id to create immutable multisample storage for.</param>
        ///// <param name="samples">Number of samples to use.</param>
        ///// <param name="piformat">Format of multisample texture.</param>
        ///// <param name="width"></param>
        ///// <param name="height"></param>
        ///// <param name="depth"></param>
        ///// <param name="fixedSampleLocations">Use fixed sample locations?</param>
        //public static void TexStorage3DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations)
        //{
        //    Delegates.glTexStorage3DMultisample(target, samples, piformat, width, height, depth, fixedSampleLocations);
        //}
        ////ARB_texture_view
        ///// <summary>
        ///// Creates a view of an already existing Immutable texture, using its data as our texture data, possible changing how data should be viewed.
        ///// </summary>
        ///// <param name="TextureID">Existing nonallocated texture id to create texture view on.</param>
        ///// <param name="target">The target this texture should be viewed as.</param>
        ///// <param name="OriginalTextureId">The id of the original texture to use as texture storage. Must be immutable.</param>
        ///// <param name="internalFormat">An internalformat compatible with format of OriginalTextureId</param>
        ///// <param name="minLevel">min mipmap level aka base level</param>
        ///// <param name="numLevels">number of mipmap levels (cant be more than OriginalTextureId)</param>
        ///// <param name="minLayer">Minimum layer</param>
        ///// <param name="numLayers">Maximum layer (cant be larger than OriginalTextureId)</param>
        //public static void TextureView(uint TextureID, TextureTarget target, uint OriginalTextureId, PixelInternalFormat internalFormat, uint minLevel, uint numLevels, uint minLayer = 0, uint numLayers = 0)
        //{
        //    Delegates.glTextureView(TextureID, target, OriginalTextureId, internalFormat, minLevel, numLevels, minLayer, numLayers);
        //}

        ////ARB_vertex_attrib_binding
        ///// <summary>
        ///// Binds a Buffer Object to a binding index.
        ///// NOTE: Binding Index 0 is used by non-bindingindex aware functions. So Avoid it!
        ///// </summary>
        ///// <param name="bindingsIndex">Binding index to bind to. NOTE: Binding Index 0 is used by non-bindingindex aware functions. So Avoid it!</param>
        ///// <param name="BufferID">ID if buffer to bind.</param>
        ///// <param name="Offset">Offset in bytes to where binding index should use as source.</param>
        ///// <param name="Stride">Cant be ZERO even for not inverleaved data, size between vertices.</param>
        //public static void BindVertexBuffer(uint bindingsIndex, uint BufferID, long Offset, int Stride)
        //{
        //    Debug.Assert(Stride != 0, "OpenGL Vertex Binding Api doesnt support stride=0 anymore!");
        //    Delegates.glBindVertexBuffer(bindingsIndex, BufferID, (IntPtr)Offset, Stride);
        //}
        ///// <summary>
        ///// Sets up a mapping between a AttributeIndex with a Vertex Declaration and a binding index to bind buffer source to.
        ///// NOTE: Binding Index 0 is used by non-bindingindex aware functions. So Avoid it!
        ///// </summary>
        ///// <param name="attribIndex">Attribute Index.</param>
        ///// <param name="bindingsIndex">Binding Index.NOTE: Binding Index 0 is used by non-bindingindex aware functions. So Avoid it!</param>
        //public static void VertexAttribBinding(uint attribIndex, uint bindingsIndex)
        //{
        //    Delegates.glVertexAttribBinding(attribIndex, bindingsIndex);
        //}
        ///// <summary>
        ///// Sets the Vertex Divisor for a BindingIndex.
        ///// </summary>
        ///// <param name="bindingsIndex">NOTE: Binding Index 0 is used by non-bindingindex aware functions. So Avoid it!</param>
        ///// <param name="divisor"></param>
        //public static void VertexBindingDivisor(uint bindingsIndex, uint divisor)
        //{
        //    Delegates.glVertexBindingDivisor(bindingsIndex, divisor);
        //}

        ///// <summary>
        ///// Sets up the Vertex Declaration for a AttributeIndex without specifind source buffer.
        ///// Source buffer are specified by bind to bindingindex and map bindingindex and attribute index afterwards.
        ///// </summary>
        ///// <param name="attribIndex">Attribute Index to specify vertex declaration for.</param>
        ///// <param name="Size">Number of components in vertices. aka vec2f = 2, vec3f = 3 osv. or BGRA</param>
        ///// <param name="type"></param>
        ///// <param name="relativeOffset">offset in bytes from start of eventually bound buffer?</param>
        ///// <param name="normalized">Is data normalized?</param>
        //public static void VertexAttribFormat(uint attribIndex, int Size, VertexAttribFormat type, int relativeOffset, bool normalized = false)
        //{
        //    Delegates.glVertexAttribFormat(attribIndex, Size, type, normalized, (uint)relativeOffset);
        //}
        ///// <summary>
        ///// Sets up the Vertex Declaration for a AttributeIndex without specifind source buffer.
        ///// Source buffer are specified by bind to bindingindex and map bindingindex and attribute index afterwards.
        ///// </summary>
        ///// <param name="attribIndex">Attribute Index to specify vertex declaration for.</param>
        ///// <param name="Size">Number of components in vertices. aka vec2i = 2, vec3i = 3 osv.</param>
        ///// <param name="itype">Integer type.</param>
        ///// <param name="relativeOffset">offset in bytes from start of eventually bound buffer?</param>
        //public static void VertexAttribIFormat(uint attribIndex, int Size, VertexAttribIFormat itype, int relativeOffset)
        //{
        //    Delegates.glVertexAttribIFormat(attribIndex, Size, itype, (uint)relativeOffset);
        //}
        ///// <summary>
        ///// Sets up the Vertex Declaration for a AttributeIndex without specifind source buffer.
        ///// Source buffer are specified by bind to bindingindex and map bindingindex and attribute index afterwards.
        ///// </summary>
        ///// <param name="attribIndex">Attribute Index to specify vertex declaration for.</param>
        ///// <param name="Size">Number of components in vertices. aka vec2d = 2, vec3d = 3 osv.</param>
        ///// <param name="ltype">Must be DOUBLE</param>
        ///// <param name="relativeOffset">offset in bytes from start of eventually bound buffer?</param>
        //public static void VertexAttribLFormat(uint attribIndex, int Size, VertexAttribLFormat ltype, int relativeOffset)
        //{
        //    Delegates.glVertexAttribLFormat(attribIndex, Size, ltype, (uint)relativeOffset);
        //}
        ////ARB_framebuffer_no_attachment
        ///// <summary>
        ///// Sets a framebuffer parameter.
        ///// </summary>
        ///// <param name="target">id of framebuffer to set</param>
        ///// <param name="pname">Name of parameter to change.</param>
        ///// <param name="param">new value of parameter.</param>
        //public static void FramebufferParameteri(FramebufferTarget target, FramebufferParameters pname, int param)
        //{
        //    Delegates.glFramebufferParameteri(target, pname, param);
        //}

        ///// <summary>
        ///// Retrives a parameter value from a framebuffer.
        ///// </summary>
        ///// <param name="target">id of framebuffer to query.</param>
        ///// <param name="pname">Name of parameter to retive.</param>
        ///// <param name="params">value of parameter</param>
        //public static void GetFramebufferParameteriv(FramebufferTarget target, FramebufferParameters pname, int[] @params)
        //{
        //    Delegates.glGetFramebufferParameteriv(target, pname, ref @params[0]);
        //}
        ///// <summary>
        ///// Retrives a parameter value from a framebuffer.
        ///// </summary>
        ///// <param name="target">id of framebuffer to query.</param>
        ///// <param name="pname">Name of parameter to retive.</param>
        ///// <returns>value of parameter</returns>
        //public static int GetFramebufferParameteriv(FramebufferTarget target, FramebufferParameters pname)
        //{
        //    int tmp = 0;
        //    Delegates.glGetFramebufferParameteriv(target, pname, ref tmp);
        //    return tmp;
        //}

        ////KHR_debug 
        ///// <summary>
        ///// Changes the properties of an array of debug message ids.
        ///// This might be source, type, severity or just enable/disable them.
        ///// Enables or Disables an array of Debug Messages ids
        ///// </summary>
        ///// <param name="source">Source of ids.</param>
        ///// <param name="type">Type of ids</param>
        ///// <param name="severity">Severity of ids.</param>
        ///// <param name="ids">array of ids to change.</param>
        ///// <param name="Enabled">Enables or disables the ids.</param>
        //public unsafe static void DebugMessageControl(DebugSource source, DebugType type, DebugSeverity severity, uint[] ids, bool Enabled)
        //{
        //    if (ids == null)
        //        Delegates.glDebugMessageControl(source, type, severity, 0, null, Enabled);
        //    else
        //    {
        //        fixed (uint* ptr = &ids[0])
        //            Delegates.glDebugMessageControl(source, type, severity, ids.Length, ptr, Enabled);
        //    }
        //}
        ///// <summary>
        ///// Insert a new debug message in the debug message log array.
        ///// </summary>
        ///// <param name="source">Source of inserted message.</param>
        ///// <param name="type">type of inserted message.</param>
        ///// <param name="id">id of inserted message. Userid has own range of ids.</param>
        ///// <param name="severity">Severity of inserted message.</param>
        ///// <param name="Text">The text of inserted message.</param>
        //public static void DebugMessageInsert(DebugSource source, DebugType type, uint id, DebugSeverity severity, string Text)
        //{
        //    Delegates.glDebugMessageInsert(source, type, id, severity, Text.Length, Text);
        //}

        ///// <summary>
        ///// Defines the Debug MessageCallback Delegate and its optionally userParam.
        ///// </summary>
        ///// <param name="callback">Delegate to a function which will be called by opengl with debug messages.</param>
        ///// <param name="userParam">Optionally userParam which will be one of the arguments opengl calls the delegate with.</param>
        //public static void DebugMessageCallback(DebugMessageDelegate callback, IntPtr userParam)
        //{
        //    Delegates.glDebugMessageCallback(callback, userParam);
        //}
        ///// <summary>
        ///// Defines the Debug MessageCallback Delegate and its optionally userParam.
        ///// </summary>
        ///// <param name="callback">Delegate to a function which will be called by opengl with debug messages.</param>
        //public static void DebugMessageCallback(DebugMessageDelegate callback)
        //{
        //    Delegates.glDebugMessageCallback(callback, IntPtr.Zero);
        //}

        ///// <summary>
        ///// Retrives a number of messages from message log.
        ///// How many retrives is determined by Math.Min([all arrays]) and availible messages.
        ///// </summary>
        ///// <param name="sources"></param>
        ///// <param name="types"></param>
        ///// <param name="ids"></param>
        ///// <param name="severities"></param>
        ///// <param name="lengths"></param>
        ///// <param name="messageLog">A single preallocated stringbuilder with enough capacity to contain all the messages?</param>
        ///// <returns></returns>
        //public static uint GetDebugMessageLog(DebugSource[] sources, DebugType[] types, uint[] ids, DebugSeverity[] severities, int[] lengths, StringBuilder messageLog)
        //{
        //    var count = Math.Min(sources.Length, Math.Min(types.Length, Math.Min(ids.Length, Math.Min(severities.Length, lengths.Length))));

        //    return Delegates.glGetDebugMessageLog((uint)count, messageLog.Capacity, ref sources[0], ref types[0], ref ids[0], ref severities[0], ref lengths[0], messageLog);
        //}
        ///// <summary>
        ///// Retrives a number of messages from message log and return the messages in array.
        ///// </summary>
        ///// <param name="sources"></param>
        ///// <param name="types"></param>
        ///// <param name="ids"></param>
        ///// <param name="severities"></param>
        ///// <param name="count"></param>
        ///// <returns></returns>
        //public static string[] GetDebugMessageLog(DebugSource[] sources, DebugType[] types, uint[] ids, DebugSeverity[] severities, int count = -1)
        //{
        //    if (count == -1)
        //    {
        //        count = GetIntegerv(GetParameters.DebugLoggedMessages);
        //    }
        //    else
        //        count = Math.Min(sources.Length, Math.Min(types.Length, Math.Min(ids.Length, severities.Length))); // , MessageLogs.Length))));

        //    var maxmessagelength = GetIntegerv(GetParameters.MaxDebugMessageLength);
        //    var sb = new StringBuilder(count * maxmessagelength + 4);

        //    var lengths = new int[count];

        //    var result = (int)Delegates.glGetDebugMessageLog((uint)count, sb.Capacity - 2, ref sources[0], ref types[0], ref ids[0], ref severities[0], ref lengths[0], sb);

        //    if (result > 0)
        //    {
        //        var messages = new string[Math.Min(result, lengths.Length)];
        //        int lastpos = 0;
        //        for (int i = 0; i < messages.Length; i++)
        //        {
        //            messages[i] = sb.ToString(lastpos, lengths[i] - 1);
        //            lastpos = lengths[i];
        //        }

        //        return messages;
        //    }
        //    else
        //        return new string[0];
        //}

        ///// <summary>
        ///// Returns a pointer.
        ///// </summary>
        ///// <param name="pname">The Pointer name to retrive.</param>
        ///// <param name="ptr"></param>
        //public static void GetPointerv(GetPointerName pname, out IntPtr ptr)
        //{
        //    //IntPtr tmpptr = IntPtr.Zero;
        //    //Delegates.glGetPointerv(pname, out tmpptr);
        //    //ptr = tmpptr;
        //    Delegates.glGetPointerv(pname, out ptr);
        //}

        ///// <summary>
        ///// Sets the label for an object specified by name. 
        ///// </summary>
        ///// <param name="idNamespace">Namespace where name belongs.</param>
        ///// <param name="name">ID or name of object.</param>
        ///// <param name="Label">Label to attach to object.</param>
        //public static void ObjectLabel(DebugNamespace idNamespace, uint name, string Label)
        //{
        //    Delegates.glObjectLabel(idNamespace, name, Label.Length, Label);
        //}
        ///// <summary>
        ///// Retrives the label from a labeled object.
        ///// </summary>
        ///// <param name="idNamespace">Namespace where name belongs.</param>
        ///// <param name="name">ID or name of object.</param>
        ///// <param name="label">PreAllocated StringBuilder with enough capacity to store retrived label.</param>
        ///// <returns>number of characters written to StringBuilder label.</returns>
        //public static int GetObjectLabel(DebugNamespace idNamespace, uint name, StringBuilder label)
        //{
        //    var LabelLength = 0;
        //    Delegates.glGetObjectLabel(idNamespace, name, label.Capacity, out LabelLength, label);
        //    return LabelLength;
        //}
        ///// <summary>
        ///// Retrives the label from a labeled object.
        ///// </summary>
        ///// <param name="idNamespace">Namespace where name belongs.</param>
        ///// <param name="name">ID or name of object.</param>
        ///// <param name="DefaultStringBuilderCapacity">The capacity of created stringbuilder used to retrive label.</param>
        ///// <returns>Label</returns>
        //public static string GetObjectLabel(DebugNamespace idNamespace, uint name, int DefaultStringBuilderCapacity = 64)
        //{
        //    var LabelLength = 0;
        //    var sb = new StringBuilder(DefaultStringBuilderCapacity + 4);
        //    Delegates.glGetObjectLabel(idNamespace, name, sb.Capacity - 2, out LabelLength, sb);
        //    return sb.ToString();
        //}

        ///// <summary>
        ///// Sets the label for an object identified by ptr.
        ///// </summary>
        ///// <param name="ptr">ptr/id/name of object.</param>
        ///// <param name="label">Text Label to attach.</param>
        //public static void ObjectPtrLabel(IntPtr ptr, string label)
        //{
        //    Delegates.glObjectPtrLabel(ptr, label.Length, label);
        //}

        ///// <summary>
        ///// Retrives the label from a labeled object.
        ///// </summary>
        ///// <param name="ptr">ptr/id/name of object.</param>
        ///// <param name="label">PreAllocated StringBuilder with enough capacity to store retrived label.</param>
        ///// <returns>Number of characters written to label.</returns>
        //public static int GetObjectPtrLabel(IntPtr ptr, StringBuilder label)
        //{
        //    int len = 0;
        //    Delegates.glGetObjectPtrLabel(ptr, label.Capacity, out len, label);
        //    return len;
        //}
        ///// <summary>
        ///// Retrives the label from a labeled object.
        ///// </summary>
        ///// <param name="ptr">ptr/id/name of object.</param>
        ///// <param name="DefaultStringBuilderCapacity">The capacity of created stringbuilder used to retrive label.</param>
        ///// <returns>Label</returns>
        //public static string GetObjectPtrLabel(IntPtr ptr, int DefaultStringBuilderCapacity = 64)
        //{
        //    var sb = new StringBuilder(DefaultStringBuilderCapacity + 4);
        //    var len = 0;
        //    Delegates.glGetObjectPtrLabel(ptr, sb.Capacity - 2, out len, sb);
        //    return sb.ToString();
        //}

        ///// <summary>
        ///// Pushes a debug group onto debug push stack.
        ///// Usefull to during debug track a small part of a program.
        ///// example.
        /////     //at start
        /////     DebugMessageControl([disable all logging])
        /////     
        /////     //inside problematic part of ap.
        /////     PushDebugGroup("Enter Shader Compiler subpart of app1");
        /////     {
        /////             DebugMessageControl([LogEverything!]) // changes the control of the ACTIVE debug group.
        /////             ...
        /////     }
        /////     // will reset DebugMessageControl back to disable.
        /////     PopDebugGroup() 
        /////     
        /////     // other, uninteresting part of program.
        /////     ...
        ///// </summary>
        ///// <param name="source"></param>
        ///// <param name="id">User Specified id</param>
        ///// <param name="message">Message to </param>
        //public static void PushDebugGroup(DebugSource source, uint id, string message)
        //{
        //    Delegates.glPushDebugGroup(source, id, message.Length, message);
        //}

        ///// <summary>
        ///// Pops a previusly pushed debug group, which also resets any DebugMessageControl properties back as it where before PushDebugGroup.
        ///// </summary>
        //public static void PopDebugGroup()
        //{
        //    Delegates.glPopDebugGroup();
        //}

        //// OpenGL 4.3 other functions
        ///// <summary>
        ///// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        ///// ClearBufferfv should be used to clear fixed- and floating-point buffers.
        ///// </summary>
        ///// <param name="buffer"></param>
        ///// <param name="drawbuffer">If buffer is color, a colorAttachment to clear, otherwise 0/none</param>
        ///// <param name="values">Dependent on buffer, se ClearBuffer Enum text for usage.</param>
        ///// <remarks>
        ///// If buffer is COLOR, a particular draw buffer DRAW_BUFFERi is specified by passing i as the parameter drawbuffer, and value points to a four-element vector specifying the R, G, B, and A color to clear that draw buffer to. 
        ///// If buffer is DEPTH, drawbuffer must be zero, and value points to the single depth value to clear the depth buffer to.
        ///// Only ClearBufferfv should be used to clear depth buffers.
        ///// If buffer is STENCIL, drawbuffer must be zero, and value points to the single stencil value to clear the stencil buffer to.
        ///// Only ClearBufferiv should be used to clear stencil buffers.
        ///// Only ClearBufferfi accepts buffer = DEPTH_STENCIL
        ///// </remarks>
        //public static void ClearBufferfv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref float values)
        //{
        //    Delegates.glClearBufferfv(buffer, drawbuffer, ref values);
        //}
        ///// <summary>
        ///// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        ///// ClearBufferiv should be used to clear signed integer buffers.
        ///// </summary>
        ///// <param name="buffer"></param>
        ///// <param name="drawbuffer">If buffer is color, a colorAttachment to clear, otherwise 0/none</param>
        ///// <param name="values">Dependent on buffer, se ClearBuffer Enum text for usage.</param>
        ///// <remarks>
        ///// If buffer is COLOR, a particular draw buffer DRAW_BUFFERi is specified by passing i as the parameter drawbuffer, and value points to a four-element vector specifying the R, G, B, and A color to clear that draw buffer to. 
        ///// If buffer is DEPTH, drawbuffer must be zero, and value points to the single depth value to clear the depth buffer to.
        ///// Only ClearBufferfv should be used to clear depth buffers.
        ///// If buffer is STENCIL, drawbuffer must be zero, and value points to the single stencil value to clear the stencil buffer to.
        ///// Only ClearBufferiv should be used to clear stencil buffers.
        ///// Only ClearBufferfi accepts buffer = DEPTH_STENCIL
        ///// </remarks>
        //public static void ClearBufferiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref int values)
        //{
        //    Delegates.glClearBufferiv(buffer, drawbuffer, ref values);
        //}
        ///// <summary>
        ///// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        ///// ClearBufferuiv should be used to clear unsigned integer buffers.
        ///// </summary>
        ///// <param name="buffer"></param>
        ///// <param name="drawbuffer">If buffer is color, a colorAttachment to clear, otherwise 0/none</param>
        ///// <param name="values">Dependent on buffer, se ClearBuffer Enum text for usage.</param>
        ///// <remarks>
        ///// If buffer is COLOR, a particular draw buffer DRAW_BUFFERi is specified by passing i as the parameter drawbuffer, and value points to a four-element vector specifying the R, G, B, and A color to clear that draw buffer to. 
        ///// If buffer is DEPTH, drawbuffer must be zero, and value points to the single depth value to clear the depth buffer to.
        ///// Only ClearBufferfv should be used to clear depth buffers.
        ///// If buffer is STENCIL, drawbuffer must be zero, and value points to the single stencil value to clear the stencil buffer to.
        ///// Only ClearBufferiv should be used to clear stencil buffers.
        ///// Only ClearBufferfi accepts buffer = DEPTH_STENCIL
        ///// </remarks>
        //public static void ClearBufferuiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref uint values)
        //{
        //    Delegates.glClearBufferuiv(buffer, drawbuffer, ref values);
        //}       

        ///// <summary>
        ///// Individual buffers of the currently bound draw framebuffer may be cleared with the command
        ///// ClearBufferfi is equivalent to clearing the depth and stencil buffers separately, but may be faster when a buffer of internal format DEPTH_STENCIL is being cleared. 
        ///// </summary>
        ///// <param name="depth">depth and sten-cil are the values to clear the depth and stencil buffers to, respectively</param>
        ///// <param name="stencil">depth and sten-cil are the values to clear the depth and stencil buffers to, respectively</param>
        ///// <param name="buffer">buffer must be DEPTH_STENCIL</param>
        ///// <param name="drawbuffer">drawbuffer must be zero/NONE.</param>
        //public static void ClearBufferfi(float depth, int stencil, ClearBuffer buffer = ClearBuffer.DepthStencil, DrawBufferTarget drawbuffer = DrawBufferTarget.None)
        //{
        //    Delegates.glClearBufferfi(buffer, drawbuffer, depth, stencil);
        //}

        ///// <summary>
        ///// Clears the depth buffer. Overload of glClearBufferfv with correct settings.
        ///// </summary>
        ///// <param name="depth"></param>
        //public static void ClearBufferDepth(float depth)
        //{
        //    Delegates.glClearBufferfv(ClearBuffer.Depth, (DrawBufferTarget)0, ref depth);
        //}
        ///// <summary>
        ///// Clears the stencil buffer. Overload of glClearBufferiv with correct settings.
        ///// </summary>
        ///// <param name="stencil"></param>
        //public static void ClearBufferStencil(int stencil)
        //{
        //    Delegates.glClearBufferiv(ClearBuffer.Stencil, (DrawBufferTarget)0, ref stencil);
        //}


        //#endregion
    }
}
