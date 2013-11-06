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

    partial class GLES
    {
        #region Delegate Class

        partial class Delegates
        {

            #region Delegates

            // OpenGL 1.1/1.2
            public delegate void delCompressedTexImage3D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
            public delegate void delCompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelInternalFormat format, int imageSize, IntPtr data);

            public delegate void delReadBuffer(DrawBufferTarget buffer);
            public delegate void delDrawRangeElements(BeginMode mode, uint start, uint end, int count, IndicesType type, IntPtr indices);

            public delegate void delTexImage3D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels);
            public delegate void delTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels);
            public delegate void delCopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
            // EXT_draw_range_elements

            // OpenGL 1.5
            public delegate void delGenQueries(int number, ref uint QueryIDs);
            public delegate void delDeleteQueries(int number, ref uint QueryIDs);
            public delegate bool delIsQuery(uint QueryID);
            public delegate void delBeginQuery(QueryTarget target, uint QueryID);
            public delegate void delEndQuery(QueryTarget target);
            public delegate void delGetQueryiv(QueryTarget target, GetQueryParameters pname, ref int @params);
            //public delegate void delGetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname, ref int @params);
            public delegate void delGetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname, ref int param);
            public delegate void delGetQueryObjectuiv(uint QueryID, GetQueryObjectParameters pname, ref uint @params);

            public delegate void delUnmapBuffer(BufferTarget target);
            public delegate void delGetBufferPointerv(BufferTarget target, BufferPointerParameters pname, out IntPtr param);

            // opengl 2.0
            public delegate void delDrawBuffers(int number, ref DrawBufferTarget bufs);

            // opengl 2.1
            public delegate void delUniformMatrix2x3fv(int location, int count, bool transpose, ref float value);
            public delegate void delUniformMatrix2x4fv(int location, int count, bool transpose, ref float value);

            public delegate void delUniformMatrix3x2fv(int location, int count, bool transpose, ref float value);
            public delegate void delUniformMatrix3x4fv(int location, int count, bool transpose, ref float value);

            public delegate void delUniformMatrix4x2fv(int location, int count, bool transpose, ref float value);
            public delegate void delUniformMatrix4x3fv(int location, int count, bool transpose, ref float value);

            // opengl 3.0
            public delegate void delBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferFlags mask, BlitFramebufferFilter filter);
            public delegate void delRenderbufferStorageMultisample(RenderbufferTarget target, int samples, RenderbufferStorageFormat iformat, int width, int height);
            public delegate IntPtr delMapBufferRange(BufferTarget target, IntPtr Offset, IntPtr Length, MapBufferRangeAccessFlags access);
            public delegate void delFlushMappedBufferRange(BufferTarget target, IntPtr Offset, IntPtr Length);

            public delegate void delGenVertexArrays(int number, ref uint Arrays);
            public delegate void delDeleteVertexArrays(int number, ref uint Arrays);
            public delegate void delBindVertexArray(uint Array);
            public delegate bool delIsVertexArray(uint Array);

            public delegate void delGetIntegeri_v(GetParameters pname, uint index, ref int data);

            public delegate void delBeginTransformFeedback(BeginMode primitiveMode);
            public delegate void delEndTransformFeedback();
            public delegate void delTransformFeedbackVaryings(uint Program, int count, string[] varyings, TransformFeedbackAttributeMode bufferMode);
            public delegate void delGetTransformFeedbackVarying(uint Program, uint index, int bufSize, out int length, out int size, out AttributeType type, StringBuilder name);

            public delegate void delBindBufferRange(BufferProgramTarget target, uint bindingIndex, uint BufferId, IntPtr Offset, IntPtr Size);
            public delegate void delBindBufferBase(BufferProgramTarget target, uint bindingIndex, uint BufferId);

            public delegate void delVertexAttribIPointer(uint index, int size, VertexAttribIFormat iType, int stride, IntPtr ptr);

            public delegate void delGetVertexAttribIiv(uint index, VertexAttribParameters pname, ref int @params);
            public delegate void delGetVertexAttribIuiv(uint index, VertexAttribParameters pname, ref uint @params);           
            public delegate void delGetUniformuiv(uint Program, int location, ref uint @params);
            public delegate int delGetFragDataLocation(uint Program, string Name);

            public delegate void delUniform1ui(int location, uint v1);
            public delegate void delUniform2ui(int location, uint v1, uint v2);
            public delegate void delUniform3ui(int location, uint v1, uint v2, uint v3);
            public delegate void delUniform4ui(int location, uint v1, uint v2, uint v3, uint v4);

            public delegate void delUniform1uiv(int location, int count, ref uint v);
            public delegate void delUniform2uiv(int location, int count, ref uint v);
            public delegate void delUniform3uiv(int location, int count, ref uint v);
            public delegate void delUniform4uiv(int location, int count, ref uint v);

            public delegate IntPtr delGetStringi(StringName name, uint index);

            // opengl 3.1
            public delegate void delCopyBufferSubData(BufferTarget readTarget, BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr Size);

            public delegate void delGetUniformIndices(uint Program, int UniformCount, string[] UniformNames, uint[] UniformIndices);
            public delegate uint delGetUniformBlockIndex(uint Program, string UniformBlockName);
            public delegate void delGetActiveUniformBlockiv(uint Program, uint UniformBlockIndex, UniformBlockParameters pname, ref int @params);
            public delegate void delGetActiveUniformBlockName(uint Program, uint UniformBlockIndex, int bufSize, out int length, StringBuilder UniformBlockName);            
            public delegate void delUniformBlockBinding(uint Program, uint UniformBlockIndex, uint UniformBlockBinding);

            public delegate void delDrawArraysInstanced(BeginMode mode, int first, int count, int InstanceCount);
            public delegate void delDrawElementsInstanced(BeginMode mode, int count, IndicesType type, IntPtr Indices, int InstanceCount);


            // opengl 3.2
            public delegate void delFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachmentType attachment, uint TextureID, int level, int layer);

            public delegate void delDeleteSync(IntPtr Sync);
            public delegate IntPtr delFenceSync(SyncCondition condition, int flagsZero);
            public delegate bool delIsSync(IntPtr Sync);
            public delegate void delGetSynciv(IntPtr Sync, SyncParameters pname, int bufSize, out int Length, ref int values);
            public delegate ClientWaitSyncStatus delClientWaitSync(IntPtr Sync, SyncFlags flags, ulong timeout_ns);
            public delegate void delWaitSync(IntPtr Sync, SyncFlags flags, ulong timeout);
            public delegate void delGetInteger64v(GetParameters pname, ref long @params);
            public delegate void delGetInteger64i_v(GetParameters pname, uint index, ref long @params);
            public delegate void delGetBufferParameteri64v(GetParameters pname, ref long param);

            // opengl 3.3
            public delegate void delGenSamplers(int Count, ref uint Samplers);
            public delegate void delBindSampler(TextureUnit texUnit, uint Sampler);
            public delegate void delSamplerParameteri(uint Sampler, SamplerParameters pname, int param);
            public delegate void delSamplerParameterf(uint Sampler, SamplerParameters pname, float param);
            public delegate void delSamplerParameteriv(uint Sampler, SamplerParameters pname, ref int @params);
            public delegate void delSamplerParameterfv(uint Sampler, SamplerParameters pname, ref float @params);
            //public delegate void delSamplerParameterIiv(uint Sampler, SamplerParameters pname, ref int @params);
            //public delegate void delSamplerParameterIuiv(uint Sampler, SamplerParameters pname, ref uint @params);
            public delegate void delDeleteSamplers(int Count, ref uint Samplers);
            public delegate bool delIsSampler(uint Sampler);

            public delegate void delGetSamplerParameteriv(uint Sampler, SamplerParameters pname, ref int @params);
            public delegate void delGetSamplerParameterfv(uint Sampler, SamplerParameters pname, ref float @params);

            //public delegate void delGetSamplerParameterIiv(uint Sampler, SamplerParameters pname, ref int @params);
            //public delegate void delGetSamplerParameterIuiv(uint Sampler, SamplerParameters pname, ref uint @params);
            public delegate void delVertexAttribDivisor(uint index, uint Divisor);

            // opengl 4.0
            public delegate void delBindTransformFeedback(TransformFeedbackTarget target, uint TransformFeedbackId);
            public delegate void delDeleteTransformFeedbacks(int number, ref uint TransformFeedbackIds);
            public delegate void delDrawTransformFeedback(BeginMode mode, uint TransformFeedbackId);
            public delegate void delGenTransformFeedbacks(int number, ref uint TransformFeedbackIds);
            public delegate bool delIsTransformFeedback(uint TransformFeedbackId);
            public delegate void delPauseTransformFeedback();
            public delegate void delResumeTransformFeedback();

            // opengl 4.1
            public delegate void delGetProgramBinary(uint Program, int bufSize, out int Length, out int BinaryFormat, IntPtr binary);
            public delegate void delProgramBinary(uint Program, int BinaryFormat, IntPtr binary, int Length);
            public delegate void delProgramParameteri(uint Program, ProgramParameters pname, int value);

            // opengl 4.2
            public delegate void delTexStorage2D(TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height);
            public delegate void delTexStorage3D(TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height, int Depth);

            public delegate void delGetInternalformativ(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname, int bufSize, ref int @params);

            // opengl 4.3
            public delegate void delClearBufferfv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref float values);
            public delegate void delClearBufferiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref int values);
            public delegate void delClearBufferuiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref uint values);

            public delegate void delClearBufferfi(ClearBuffer buffer, DrawBufferTarget drawbuffer, float depth, int stencil);

            public delegate void delInvalidateFramebuffer(FramebufferTarget target, int numAttachments, ref FramebufferAttachmentType attachments);
            public delegate void delInvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, ref FramebufferAttachmentType attachments, int x, int y, int width, int height);



            /*
             * ReadBuffer
             * DrawRangeElements
             * TexImage3D
             * TeXSubImage3D
             * CopyTexSubImage3D
             * CompressedTexImage3D
             * CompressedTexSubImage3D
             * GenQueries
             * DeleteQueries
             * IsQuery
             * BeginQuery
             * EndEquery
             * GetQueryiv
             * GetQueryObjectuiv
             * UnmapBuffer
             * GetBufferPointerv
             * DrawBuffers
             * UniformMatrix2x3fv
             * UniformMatrix3x2fv
             * UniformMatrix2x4fv
             * UniformMatrix4x2fv
             * UniformMatrix3x4fv
             * UniformMatrix4x3fv
             * BlitFramebuffer
             * RenderbufferStorageMultisample
             * FramebufferTextureLayer
             * MapBufferRange
             * FlushMappedBufferRange
             * BindVertexArray
             * DeleteVertexArrays
             * GenVertexArrays
             * IsVertexArray
             * GetIntegeri_v
             * BeginTransformFeedback
             * BindBufferRange
             * BindBufferBase
             * TransformFeedbackVaryings
             * GetTransfromFeedbackVarying
             * VertexAttribIPointer
             * GetVertexAttribIiv
             * GetVertexAttribIuiv
             * VertexAttribI4i
             * VertexAttribI4ui
             * VertexAttribI4iv
             * VertexAttribI4uiv
             * GetUniformuiv
             * GetFragDataLocation
             * Uniform1ui
             * Uniform2ui
             * Uniform3ui
             * Uniform4ui
             * Uniform1uiv
             * Uniform2uiv
             * Uniform3uiv
             * Uniform4uiv
             * ClearBufferiv
             * ClearBufferuiv
             * ClearBufferfv
             * ClearBufferfi
             * GetStringi
             * CopyBufferSubData
             * GetUniformIndices
             * GetActiveUniformsiv
             * GetUniformBlockIndex
             * GetActiveUniformBlockiv
             * GetActiveUniformBlockName
             * UniformblockBinding
             * DrawArraysInstanced
             * DrawElementsInstanced
             * FenceSync
             * IsSync
             * DeleteSync
             * ClientWaitSync
             * WaitSync
             * GetInteger64v
             * GetSynciv
             * GetInteger64i_v
             * GetBufferParameteri64v
             * GenSamplers
             * DeleteSamplers
             * IsSampler
             * BindSampler
             * SamplerParameteri
             * SamplerParameteriv
             * SamplerParameterf
             * SamplerParameterfv
             * GetSamplerParameteriv
             * GetSamplerParameterfv
             * VertexAttribDivisor
             * BindTransformFeedback
             * DeleteTransformFeedbacks
             * GenTransformFeedbacks
             * IsTransformFeedback
             * PauseTransformFeedback
             * ResumeTransformFeedback
             * GetProgramBinary
             * ProgramBinary
             * ProgramParameteri
             * InvalidateFramebuffer
             * InvalidateSubFramebuffer
             * TexStorage2D
             * TexStorage3D
             * GetInternalformativ
             * 
             */

            #endregion

            #region GL Fields

            // OpenGL 1.1/1.2
            public static delCompressedTexImage3D glCompressedTexImage3D;
            public static delCompressedTexSubImage3D glCompressedTexSubImage3D;

            public static delReadBuffer glReadBuffer;
            public static delDrawRangeElements glDrawRangeElements;

            public static delTexImage3D glTexImage3D;
            public static delTexSubImage3D glTexSubImage3D;
            public static delCopyTexSubImage3D glCopyTexSubImage3D;
            // EXT_draw_range_elements

            // OpenGL 1.5
            public static delGenQueries glGenQueries;
            public static delDeleteQueries glDeleteQueries;
            public static delIsQuery glIsQuery;
            public static delBeginQuery glBeginQuery;
            public static delEndQuery glEndQuery;
            public static delGetQueryiv glGetQueryiv;
            //public static delGetQueryObjectiv glGetQueryObjectiv;
            public static delGetQueryObjectiv glGetQueryObjectiv;
            public static delGetQueryObjectuiv glGetQueryObjectuiv;

            public static delUnmapBuffer glUnmapBuffer;
            public static delGetBufferPointerv glGetBufferPointerv;

            // opengl 2.0
            public static delDrawBuffers glDrawBuffers;

            // opengl 2.1
            public static delUniformMatrix2x3fv glUniformMatrix2x3fv;
            public static delUniformMatrix2x4fv glUniformMatrix2x4fv;

            public static delUniformMatrix3x2fv glUniformMatrix3x2fv;
            public static delUniformMatrix3x4fv glUniformMatrix3x4fv;

            public static delUniformMatrix4x2fv glUniformMatrix4x2fv;
            public static delUniformMatrix4x3fv glUniformMatrix4x3fv;

            // opengl 3.0
            public static delBlitFramebuffer glBlitFramebuffer;
            public static delRenderbufferStorageMultisample glRenderbufferStorageMultisample;
            public static delMapBufferRange glMapBufferRange;
            public static delFlushMappedBufferRange glFlushMappedBufferRange;

            public static delGenVertexArrays glGenVertexArrays;
            public static delDeleteVertexArrays glDeleteVertexArrays;
            public static delBindVertexArray glBindVertexArray;
            public static delIsVertexArray glIsVertexArray;

            public static delGetIntegeri_v glGetIntegeri_v;

            public static delBeginTransformFeedback glBeginTransformFeedback;
            public static delEndTransformFeedback glEndTransformFeedback;
            public static delTransformFeedbackVaryings glTransformFeedbackVaryings;
            public static delGetTransformFeedbackVarying glGetTransformFeedbackVarying;

            public static delBindBufferRange glBindBufferRange;
            public static delBindBufferBase glBindBufferBase;

            public static delVertexAttribIPointer glVertexAttribIPointer;

            public static delGetVertexAttribIiv glGetVertexAttribIiv;
            public static delGetVertexAttribIuiv glGetVertexAttribIuiv;
            public static delGetUniformuiv glGetUniformuiv;
            public static delGetFragDataLocation glGetFragDataLocation;

            public static delUniform1ui glUniform1ui;
            public static delUniform2ui glUniform2ui;
            public static delUniform3ui glUniform3ui;
            public static delUniform4ui glUniform4ui;

            public static delUniform1uiv glUniform1uiv;
            public static delUniform2uiv glUniform2uiv;
            public static delUniform3uiv glUniform3uiv;
            public static delUniform4uiv glUniform4uiv;

            public static delGetStringi  glGetStringi;

            // opengl 3.1
            public static delCopyBufferSubData glCopyBufferSubData;

            public static delGetUniformIndices glGetUniformIndices;
            public static delGetUniformBlockIndex glGetUniformBlockIndex;
            public static delGetActiveUniformBlockiv glGetActiveUniformBlockiv;
            public static delGetActiveUniformBlockName glGetActiveUniformBlockName;
            public static delUniformBlockBinding glUniformBlockBinding;

            public static delDrawArraysInstanced glDrawArraysInstanced;
            public static delDrawElementsInstanced glDrawElementsInstanced;


            // opengl 3.2
            public static delFramebufferTextureLayer glFramebufferTextureLayer;

            public static delDeleteSync glDeleteSync;
            public static delFenceSync glFenceSync;
            public static delIsSync glIsSync;
            public static delGetSynciv glGetSynciv;
            public static delClientWaitSync glClientWaitSync;
            public static delWaitSync glWaitSync;
            public static delGetInteger64v glGetInteger64v;
            public static delGetInteger64i_v glGetInteger64i_v;
            public static delGetBufferParameteri64v glGetBufferParameteri64v;

            // opengl 3.3
            public static delGenSamplers glGenSamplers;
            public static delBindSampler glBindSampler;
            public static delSamplerParameteri glSamplerParameteri;
            public static delSamplerParameterf glSamplerParameterf;
            public static delSamplerParameteriv glSamplerParameteriv;
            public static delSamplerParameterfv glSamplerParameterfv;
            //public static delSamplerParameterIiv
            //public static delSamplerParameterIuiv
            public static delDeleteSamplers glDeleteSamplers;
            public static delIsSampler glIsSampler;

            public static delGetSamplerParameteriv glGetSamplerParameteriv;
            public static delGetSamplerParameterfv glGetSamplerParameterfv;

            //public static delGetSamplerParameterIiv
            //public static delGetSamplerParameterIuiv
            public static delVertexAttribDivisor glVertexAttribDivisor;

            // opengl 4.0
            public static delBindTransformFeedback glBindTransformFeedback;
            public static delDeleteTransformFeedbacks glDeleteTransformFeedbacks;
            public static delDrawTransformFeedback glDrawTransformFeedback;
            public static delGenTransformFeedbacks glGenTransformFeedbacks;
            public static delIsTransformFeedback glIsTransformFeedback;
            public static delPauseTransformFeedback glPauseTransformFeedback;
            public static delResumeTransformFeedback glResumeTransformFeedback;

            // opengl 4.1
            public static delGetProgramBinary glGetProgramBinary;
            public static delProgramBinary glProgramBinary;
            public static delProgramParameteri glProgramParameteri;

            // opengl 4.2
            public static delTexStorage2D glTexStorage2D;
            public static delTexStorage3D glTexStorage3D;

            public static delGetInternalformativ glGetInternalformativ;

            // opengl 4.3
            public static delClearBufferfv glClearBufferfv;
            public static delClearBufferiv glClearBufferiv;
            public static delClearBufferuiv glClearBufferuiv;

            public static delClearBufferfi glClearBufferfi;

            public static delInvalidateFramebuffer glInvalidateFramebuffer;
            public static delInvalidateSubFramebuffer glInvalidateSubFramebuffer;

            #endregion
        }

        #endregion

        #region Public functions.

        // OpenGL 1.1/1.2
        public static void CompressedTexImage3D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, int imageSize, IntPtr data, int border = 0)
        {
            Delegates.glCompressedTexImage3D(target, level, piformat, width, height, depth, border, imageSize, data);
        }
        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelInternalFormat format, int imageSize, IntPtr data)
        {
            Delegates.glCompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }
        public static void ReadBuffer(DrawBufferTarget buffer)
        {
            Delegates.glReadBuffer(buffer);
        }
        public static void DrawRangeElements(BeginMode mode, uint start, uint end, int count, IndicesType type, long Offset)
        {
            Delegates.glDrawRangeElements(mode, start, end, count, type, (IntPtr)Offset);
        }
        public static void TexImage3D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels, int border = 0)
        {
            Delegates.glTexImage3D(target, level, piformat, width, height, depth, border, format, type, pixels);
        }
        public static void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
        {
            Delegates.glTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }
        public static void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
        {
            Delegates.glCopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }
        // EXT_draw_range_elements

        // OpenGL 1.5
        public static void GenQueries(uint[] QueryIDs)
        {
            Delegates.glGenQueries(QueryIDs.Length, ref QueryIDs[0]);
        }
        public static uint GenQueries()
        {
            uint tmp = 0;
            Delegates.glGenQueries(1, ref tmp);
            return tmp;
        }
        public static void DeleteQueries(uint[] QueryIDs)
        {
            Delegates.glDeleteQueries(QueryIDs.Length, ref QueryIDs[0]);
        }
        public static void DeleteQueries(uint QueryID)
        {
            Delegates.glDeleteQueries(1, ref QueryID);
        }
        public static bool IsQuery(uint QueryID)
        {
            return Delegates.glIsQuery(QueryID);
        }
        public static void BeginQuery(QueryTarget target, uint QueryID)
        {
            Delegates.glBeginQuery(target, QueryID);
        }
        public static void EndQuery(QueryTarget target)
        {
            Delegates.glEndQuery(target);
        }
        public static void GetQueryiv(QueryTarget target, GetQueryParameters pname, ref int @params)
        {
            Delegates.glGetQueryiv(target, pname, ref @params);
        }
        //public static void GetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname, ref int @params)
        public static void GetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname, ref int param)
        {
            Delegates.glGetQueryObjectiv(QueryID, pname, ref param);
        }
        public static int GetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname)
        {
            int tmp = 0;
            Delegates.glGetQueryObjectiv(QueryID, pname, ref tmp);
            return tmp;
        }
        public static void GetQueryObjectuiv(uint QueryID, GetQueryObjectParameters pname, ref uint @params)
        {
            Delegates.glGetQueryObjectuiv(QueryID, pname, ref @params);
        }
        public static uint GetQueryObjectuiv(uint QueryID, GetQueryObjectParameters pname)
        {
            uint tmp = 0;
            Delegates.glGetQueryObjectuiv(QueryID, pname, ref tmp);
            return tmp;
        }
        public static void UnmapBuffer(BufferTarget target)
        {
            Delegates.glUnmapBuffer(target);
        }
        public static void GetBufferPointerv(BufferTarget target, BufferPointerParameters pname, out IntPtr param)
        {
            Delegates.glGetBufferPointerv(target, pname, out param);
        }
        public static IntPtr GetBufferPointerv(BufferTarget target, BufferPointerParameters pname)
        {
            IntPtr ptr;
            Delegates.glGetBufferPointerv(target, pname, out ptr);
            return ptr;
        }

        // opengl 2.0
        public static void DrawBuffers(int number, ref DrawBufferTarget bufs)
        {
            Delegates.glDrawBuffers(number, ref bufs);
        }
        public static void DrawBuffers(DrawBufferTarget[] bufs, int start = 0, int length = -1)
        {
            if (length == -1)
                length = bufs.Length;

            var maxlen = Math.Min(bufs.Length, start + length) - start;

            Delegates.glDrawBuffers(maxlen, ref bufs[start]);
        }
        // opengl 2.1
        public static void UniformMatrix2x3fv(int location, ref float value, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix2x3fv(location, count, transpose, ref value);
        }
        public static void UniformMatrix2x4fv(int location, ref float value, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix2x4fv(location, count, transpose, ref value);
        }
        public static void UniformMatrix3x2fv(int location, ref float value, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix3x2fv(location, count, transpose, ref value);
        }
        public static void UniformMatrix3x4fv(int location, ref float value, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix3x4fv(location, count, transpose, ref value);
        }

        public static void UniformMatrix4x2fv(int location, ref float value, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix4x2fv(location, count, transpose, ref value);
        }
        public static void UniformMatrix4x3fv(int location, ref float value, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix4x3fv(location, count, transpose, ref value);
        }
        // opengl 3.0
        public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferFlags mask, BlitFramebufferFilter filter)
        {
            Delegates.glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }
        public static void RenderbufferStorageMultisample(int samples, RenderbufferStorageFormat iformat, int width, int height, RenderbufferTarget target= RenderbufferTarget.Renderbuffer)
        {
            Delegates.glRenderbufferStorageMultisample(target, samples, iformat, width, height);
        }
        public static IntPtr MapBufferRange(BufferTarget target, long Offset, long Length, MapBufferRangeAccessFlags access)
        {
            return Delegates.glMapBufferRange(target, (IntPtr)Offset, (IntPtr)Length, access);
        }
        public static void FlushMappedBufferRange(BufferTarget target, long Offset, long Length)
        {
            Delegates.glFlushMappedBufferRange(target, (IntPtr)Offset, (IntPtr)Length);
        }

        public static void GenVertexArrays(uint[] Arrays)
        {
            Delegates.glGenVertexArrays(Arrays.Length, ref Arrays[0]);
        }
        public static uint GenVertexArrays()
        {
            uint tmp = 0;
            Delegates.glGenVertexArrays(1, ref tmp);
            return tmp;
        }

        public static void DeleteVertexArrays(uint[] Arrays)
        {
            Delegates.glDeleteVertexArrays(Arrays.Length, ref Arrays[0]);
        }
        public static void DeleteVertexArrays(uint VertexArrayID)
        {
            Delegates.glDeleteVertexArrays(1, ref VertexArrayID);
        }
        public static void BindVertexArray(uint Array)
        {
            Delegates.glBindVertexArray(Array);
        }
        public static bool IsVertexArray(uint Array)
        {
            return Delegates.glIsVertexArray(Array);
        }
        public static void GetIntegeri_v(GetParameters pname, uint index, ref int data)
        {
            Delegates.glGetIntegeri_v(pname, index, ref data);
        }
        public static int GetIntegeri_v(GetParameters pname, uint index)
        {
            int tmp = 0;
            Delegates.glGetIntegeri_v(pname, index, ref tmp);
            return tmp;
        }

        public static void BeginTransformFeedback(BeginMode primitiveMode)
        {
            Delegates.glBeginTransformFeedback(primitiveMode);
        }
        public static void EndTransformFeedback()
        {
            Delegates.glEndTransformFeedback();
        }
        public static void TransformFeedbackVaryings(uint Program, string[] varyings, TransformFeedbackAttributeMode bufferMode)
        {
            Delegates.glTransformFeedbackVaryings(Program, varyings.Length, varyings, bufferMode);
        }
        public static void GetTransformFeedbackVarying(uint Program, uint index, int bufSize, out int length, out int size, out AttributeType type, StringBuilder name)
        {
            Delegates.glGetTransformFeedbackVarying(Program, index, bufSize, out length, out size, out type, name);
        }
        public static void GetTransformFeedbackVarying(uint Program, uint index, out int size, out AttributeType type, out string name, int MaxAttributeNameLength = 64)
        {
            var sb = new StringBuilder(MaxAttributeNameLength + 4);
            Delegates.glGetTransformFeedbackVarying(Program, index, sb.Capacity - 2, out MaxAttributeNameLength, out size, out type, sb);
            name = sb.ToString();
        }

        public static void BindBufferRange(BufferProgramTarget target, uint bindingIndex, uint BufferId, long Offset, long Size)
        {
            Delegates.glBindBufferRange(target, bindingIndex, BufferId, (IntPtr)Offset, (IntPtr)Size);
        }
        public static void BindBufferBase(BufferProgramTarget target, uint bindingIndex, uint BufferId)
        {
            Delegates.glBindBufferBase(target, bindingIndex, BufferId);
        }

        public static void VertexAttribIPointer(uint index, int size, VertexAttribIFormat iType, int stride, long Offset)
        {
            Delegates.glVertexAttribIPointer(index, size, iType, stride, (IntPtr)Offset);
        }

        public static void GetVertexAttribIiv(uint index, VertexAttribParameters pname, ref int @params)
        {
            Delegates.glGetVertexAttribIiv(index, pname, ref @params);
        }
        public static int GetVertexAttribIiv(uint index, VertexAttribParameters pname)
        {
            int tmp = 0;
            Delegates.glGetVertexAttribIiv(index, pname, ref tmp);
            return tmp;
        }
        public static void GetVertexAttribIuiv(uint index, VertexAttribParameters pname, ref uint @params)
        {
            Delegates.glGetVertexAttribIuiv(index, pname, ref @params);
        }
        public static uint GetVertexAttribIuiv(uint index, VertexAttribParameters pname)
        {
            uint tmp = 0;
            Delegates.glGetVertexAttribIuiv(index, pname, ref tmp);
            return tmp;
        }
        public static void GetUniformuiv(uint Program, int location, ref uint @params)
        {
            Delegates.glGetUniformuiv(Program, location, ref @params);
        }
        public static uint GetUniformuiv(uint Program, int location)
        {
            uint tmp = 0;
            Delegates.glGetUniformuiv(Program, location, ref tmp);
            return tmp;
        }
        public static int GetFragDataLocation(uint Program, string Name)
        {
            return Delegates.glGetFragDataLocation(Program, Name);
        }
        public static void Uniform1ui(int location, uint v1)
        {
            Delegates.glUniform1ui(location, v1);
        }
        public static void Uniform2ui(int location, uint v1, uint v2)
        {
            Delegates.glUniform2ui(location, v1, v2);
        }
        public static void Uniform3ui(int location, uint v1, uint v2, uint v3)
        {
            Delegates.glUniform3ui(location, v1, v2, v3);
        }
        public static void Uniform4ui(int location, uint v1, uint v2, uint v3, uint v4)
        {
            Delegates.glUniform4ui(location, v1, v2, v3, v4);
        }

        public static void Uniform1uiv(int location, ref uint v, int count = 1)
        {
            Delegates.glUniform1uiv(location, count, ref v);
        }
        public static void Uniform2uiv(int location, ref uint v, int count = 1)
        {
            Delegates.glUniform2uiv(location, count, ref v);
        }
        public static void Uniform3uiv(int location, ref uint v, int count = 1)
        {
            Delegates.glUniform3uiv(location, count, ref v);
        }
        public static void Uniform4uiv(int location, ref uint v, int count = 1)
        {
            Delegates.glUniform4uiv(location, count, ref v);
        }

        public static string GetStringi(StringName name, uint index)
        {
            var ptr = Delegates.glGetStringi(name, index);
            if (ptr != IntPtr.Zero)
                return Marshal.PtrToStringAnsi(ptr);
            else
                return string.Empty;
        }

        // opengl 3.1
        public static void CopyBufferSubData(BufferTarget readTarget, BufferTarget writeTarget, long readOffset, long writeOffset, long Size)
        {
            Delegates.glCopyBufferSubData(readTarget, writeTarget, (IntPtr)readOffset, (IntPtr)writeOffset, (IntPtr)Size);
        }

        public static void GetUniformIndices(uint Program, string[] UniformNames, uint[] UniformIndices)
        {
            var len = Math.Min(UniformNames.Length, UniformIndices.Length);
            Delegates.glGetUniformIndices(Program, len, UniformNames, UniformIndices);
        }
        public static uint[] GetUniformIndices(uint Program, string[] UniformNames)
        {
            var tmp = new uint[UniformNames.Length];
            Delegates.glGetUniformIndices(Program, tmp.Length, UniformNames, tmp);
            return tmp;
        }
        public static uint GetUniformBlockIndex(uint Program, string UniformBlockName)
        {
            return Delegates.glGetUniformBlockIndex(Program, UniformBlockName);
        }
        public static void GetActiveUniformBlockiv(uint Program, uint UniformBlockIndex, UniformBlockParameters pname, ref int @params)
        {
            Delegates.glGetActiveUniformBlockiv(Program, UniformBlockIndex, pname, ref @params);
        }
        public static int GetActiveUniformBlockiv(uint Program, uint UniformBlockIndex, UniformBlockParameters pname)
        {
            int tmp = 0;
            Delegates.glGetActiveUniformBlockiv(Program, UniformBlockIndex, pname, ref tmp);
            return tmp;
        }
        public static void GetActiveUniformBlockName(uint Program, uint UniformBlockIndex, int bufSize, out int length, StringBuilder UniformBlockName)
        {
            Delegates.glGetActiveUniformBlockName(Program, UniformBlockIndex, bufSize, out length, UniformBlockName);
        }
        public static string GetActiveUniformBlockName(uint Program, uint UniformBlockIndex, int MaxUniformBlockNameLength = 64)
        {
            var sb = new StringBuilder(MaxUniformBlockNameLength + 4);
            Delegates.glGetActiveUniformBlockName(Program, UniformBlockIndex, sb.Capacity - 2, out MaxUniformBlockNameLength, sb);
            return sb.ToString();
            //Delegates.glGetActiveUniformBlockName(Program, UniformBlockIndex, bufSize, out length, UniformBlockName);
        }

        public static void UniformBlockBinding(uint Program, uint UniformBlockIndex, uint UniformBlockBinding)
        {
            Delegates.glUniformBlockBinding(Program, UniformBlockIndex, UniformBlockBinding);
        }

        public static void DrawArraysInstanced(BeginMode mode, int first, int count, int InstanceCount)
        {
            Delegates.glDrawArraysInstanced(mode, first, count, InstanceCount);
        }
        public static void DrawElementsInstanced(BeginMode mode, int count, IndicesType type, long Indices, int InstanceCount)
        {
            Delegates.glDrawElementsInstanced(mode, count, type, (IntPtr)Indices, InstanceCount);
        }


        // opengl 3.2
        public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachmentType attachment, uint TextureID, int level = 0, int layer = 0)
        {
            Delegates.glFramebufferTextureLayer(target, attachment, TextureID, level, layer);
        }
        public static void DeleteSync(IntPtr Sync)
        {
            Delegates.glDeleteSync(Sync);
        }
        public static IntPtr FenceSync(SyncCondition condition, int flagsZero = 0)
        {
            return Delegates.glFenceSync(condition, flagsZero);
        }
        public static bool IsSync(IntPtr Sync)
        {
            return Delegates.glIsSync(Sync);
        }
        public static void GetSynciv(IntPtr Sync, SyncParameters pname, int bufSize, out int Length, ref int values)
        {
            Delegates.glGetSynciv(Sync, pname, bufSize, out Length, ref values);
        }
        public static void GetSynciv(IntPtr Sync, SyncParameters pname, out int Length, int[] values)
        {
            Delegates.glGetSynciv(Sync, pname, values.Length, out Length, ref values[0]);
        }
        public static ClientWaitSyncStatus ClientWaitSync(IntPtr Sync, SyncFlags flags, ulong timeout_ns)
        {
            return Delegates.glClientWaitSync(Sync, flags, timeout_ns);
        }
        public static void WaitSync(IntPtr Sync, SyncFlags flags, ulong timeout)
        {
            Delegates.glWaitSync(Sync, flags, timeout);
        }
        public static void GetInteger64v(GetParameters pname, ref long @params)
        {
            Delegates.glGetInteger64v(pname, ref @params);
        }
        public static long GetInteger64v(GetParameters pname)
        {
            long tmp = 0;
            Delegates.glGetInteger64v(pname, ref tmp);
            return tmp;
        }
        public static void GetInteger64i_v(GetParameters pname, uint index, ref long @params)
        {
            Delegates.glGetInteger64i_v(pname, index, ref @params);
        }
        public static long GetInteger64i_v(GetParameters pname, uint index)
        {
            long tmp = 0;
            Delegates.glGetInteger64i_v(pname, index, ref tmp);
            return tmp;
        }
        public static void GetBufferParameteri64v(GetParameters pname, ref long param)
        {
            Delegates.glGetBufferParameteri64v(pname, ref param);
        }
        public static long GetBufferParameteri64v(GetParameters pname)
        {
            long tmp = 0;
            Delegates.glGetBufferParameteri64v(pname, ref tmp);
            return tmp;
        }

        // opengl 3.3
        public static void GenSamplers(uint[] Samplers)
        {
            Delegates.glGenSamplers(Samplers.Length, ref Samplers[0]);
        }
        public static uint GenSamplers()
        {
            uint tmp = 0;
            Delegates.glGenSamplers(1, ref tmp);
            return tmp;
        }
        public static void BindSampler(TextureUnit texUnit, uint Sampler)
        {
            Delegates.glBindSampler(texUnit, Sampler);
        }
        public static void SamplerParameteri(uint Sampler, SamplerParameters pname, int param)
        {
            Delegates.glSamplerParameteri(Sampler, pname, param);
        }
        public static void SamplerParameterf(uint Sampler, SamplerParameters pname, float param)
        {
            Delegates.glSamplerParameterf(Sampler, pname, param);
        }
        public static void SamplerParameteriv(uint Sampler, SamplerParameters pname, ref int @params)
        {
            Delegates.glSamplerParameteriv(Sampler, pname, ref @params);
        }
        public static void SamplerParameterfv(uint Sampler, SamplerParameters pname, ref float @params)
        {
            Delegates.glSamplerParameterfv(Sampler, pname, ref @params);
        }
        //public static void SamplerParameterIiv(uint Sampler, SamplerParameters pname, ref int @params)
        //public static void SamplerParameterIuiv(uint Sampler, SamplerParameters pname, ref uint @params)
        public static void DeleteSamplers(uint[] Samplers)
        {
            Delegates.glDeleteSamplers(Samplers.Length, ref Samplers[0]);
        }
        public static void DeleteSamplers(uint Sampler)
        {
            Delegates.glDeleteSamplers(1, ref Sampler);
        }
        public static bool IsSampler(uint Sampler)
        {
            return Delegates.glIsSampler(Sampler);
        }

        public static void GetSamplerParameteriv(uint Sampler, SamplerParameters pname, ref int @params)
        {
            Delegates.glGetSamplerParameteriv(Sampler, pname, ref @params);
        }
        public static int GetSamplerParameteriv(uint Sampler, SamplerParameters pname)
        {
            int tmp = 0;
            Delegates.glGetSamplerParameteriv(Sampler, pname, ref tmp);
            return tmp;
        }
        public static void GetSamplerParameterfv(uint Sampler, SamplerParameters pname, ref float @params)
        {
            Delegates.glGetSamplerParameterfv(Sampler, pname, ref @params);
        }
        public static float GetSamplerParameterfv(uint Sampler, SamplerParameters pname)
        {
            float tmp = 0.0f;
            Delegates.glGetSamplerParameterfv(Sampler, pname, ref tmp);
            return tmp;
        }
        //public static void GetSamplerParameterIiv(uint Sampler, SamplerParameters pname, ref int @params)
        //public static void GetSamplerParameterIuiv(uint Sampler, SamplerParameters pname, ref uint @params)
        public static void VertexAttribDivisor(uint index, uint Divisor)
        {
            Delegates.glVertexAttribDivisor(index, Divisor);
        }

        // opengl 4.0
        public static void BindTransformFeedback(uint TransformFeedbackId, TransformFeedbackTarget target = TransformFeedbackTarget.TransformFeedback)
        {
            Delegates.glBindTransformFeedback(target, TransformFeedbackId);
        }
        public static void DeleteTransformFeedbacks(uint[] TransformFeedbackIds)
        {
            Delegates.glDeleteTransformFeedbacks(TransformFeedbackIds.Length, ref TransformFeedbackIds[0]);
        }
        public static void DeleteTransformFeedbacks(uint TransformFeedbackId)
        {
            Delegates.glDeleteTransformFeedbacks(1, ref TransformFeedbackId);
        }
        public static void DrawTransformFeedback(BeginMode mode, uint TransformFeedbackId)
        {
            Delegates.glDrawTransformFeedback(mode, TransformFeedbackId);
        }
        public static void GenTransformFeedbacks(uint[] TransformFeedbackIds)
        {
            Delegates.glGenTransformFeedbacks(TransformFeedbackIds.Length, ref TransformFeedbackIds[0]);
        }
        public static uint GenTransformFeedbacks()
        {
            uint tmp = 0;
            Delegates.glGenTransformFeedbacks(1, ref tmp);
            return tmp;
        }
        public static bool IsTransformFeedback(uint TransformFeedbackId)
        {
            return Delegates.glIsTransformFeedback(TransformFeedbackId);
        }
        public static void PauseTransformFeedback()
        {
            Delegates.glPauseTransformFeedback();
        }
        public static void ResumeTransformFeedback()
        {
            Delegates.glResumeTransformFeedback();
        }

        // opengl 4.1
        public static void GetProgramBinary(uint Program, int bufSize, out int Length, out int BinaryFormat, IntPtr binary)
        {
            Delegates.glGetProgramBinary(Program, bufSize, out Length, out BinaryFormat, binary);
        }
        public static void ProgramBinary(uint Program, int BinaryFormat, IntPtr binary, int Length)
        {
            Delegates.glProgramBinary(Program, BinaryFormat, binary, Length);
        }
        public static void ProgramParameteri(uint Program, ProgramParameters pname, int value)
        {
            Delegates.glProgramParameteri(Program, pname, value);
        }
        
        // opengl 4.2
        public static void TexStorage2D(TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height)
        {
            Delegates.glTexStorage2D(target, levels, piformat, Width, Height);
        }
        public static void TexStorage3D(TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height, int Depth)
        {
            Delegates.glTexStorage3D(target, levels, piformat, Width, Height, Depth);
        }

        public static void GetInternalformativ(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname, int bufSize, ref int @params)
        {
            Delegates.glGetInternalformativ(target, internalformat, pname, bufSize, ref @params);
        }
        public static void GetInternalformativ(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname, int[] @params)
        {
            Delegates.glGetInternalformativ(target, internalformat, pname, @params.Length, ref @params[0]);
        }
        public static int GetInternalformativ(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname)
        {
            int tmp = 0;
            Delegates.glGetInternalformativ(target, internalformat, pname, 1, ref tmp);
            return tmp;
        }

        // opengl 4.3
        public static void ClearBufferfv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref float values)
        {
            Delegates.glClearBufferfv(buffer, drawbuffer, ref values);
        }
        public static void ClearBufferiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref int values)
        {
            Delegates.glClearBufferiv(buffer, drawbuffer, ref values);
        }
        public static void ClearBufferuiv(ClearBuffer buffer, DrawBufferTarget drawbuffer, ref uint values)
        {
            Delegates.glClearBufferuiv(buffer, drawbuffer, ref values);
        }
        public static void ClearBufferfi(ClearBuffer buffer, DrawBufferTarget drawbuffer, float depth, int stencil)
        {
            Delegates.glClearBufferfi(buffer, drawbuffer, depth, stencil);
        }

        public static void InvalidateFramebuffer(FramebufferTarget target, int numAttachments, ref FramebufferAttachmentType attachments)
        {
            Delegates.glInvalidateFramebuffer(target, numAttachments, ref attachments);
        }
        public static void InvalidateFramebuffer(FramebufferTarget target, FramebufferAttachmentType attachment)
        {
            Delegates.glInvalidateFramebuffer(target, 1, ref attachment);
        }
        public static void InvalidateFramebuffer(FramebufferTarget target, FramebufferAttachmentType[] attachments, int start = 0, int length = -1)
        {
            if (length == -1)
                length = attachments.Length;

            var num = Math.Min(attachments.Length, start + length) - start;
            if (num > 0)
            {
                Delegates.glInvalidateFramebuffer(target, num, ref attachments[start]);
            }
        }
        public static void InvalidateSubFramebuffer(FramebufferTarget target, int numAttachments, ref FramebufferAttachmentType attachments, int x, int y, int width, int height)
        {
            Delegates.glInvalidateSubFramebuffer(target, numAttachments, ref attachments, x, y, width, height);
        }
        public static void InvalidateSubFramebuffer(FramebufferTarget target, FramebufferAttachmentType attachment, int x, int y, int width, int height)
        {
            Delegates.glInvalidateSubFramebuffer(target, 1, ref attachment, x, y, width, height);
        }
        public static void InvalidateSubFramebuffer(FramebufferTarget target, FramebufferAttachmentType[] attachments, int x, int y, int width, int height, int start = 0, int length = -1)
        {
            if (length == -1)
                length = attachments.Length;

            var num = Math.Min(attachments.Length, start + length) - start;
            if (num > 0)
            {
                Delegates.glInvalidateSubFramebuffer(target, num, ref attachments[start], x, y, width, height);
            }

        }

        #endregion
    }
}
