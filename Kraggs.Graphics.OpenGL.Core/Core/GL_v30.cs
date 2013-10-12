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
        #region Delegate Class

        partial class Delegates
        {

            #region Delegates

            //APPLE_flush_buffer_range/ARB_map_buffer_range
            public delegate void delFlushMappedBufferRange(BufferTarget target, IntPtr Offset, IntPtr Length);
            public delegate IntPtr delMapBufferRange(BufferTarget target, IntPtr Offset, IntPtr Length, MapBufferRangeAccessFlags access);

            //ARB_vertex_array_object
            public delegate void delGenVertexArrays(int number, ref uint Arrays);
            public delegate void delDeleteVertexArrays(int number, ref uint Arrays);
            public delegate void delBindVertexArray(uint Array);
            public delegate bool delIsVertexArray(uint Array);

            //ARB_color_buffer_float
            public delegate void delClampColor(ClampColorTarget target, ClampColorMode mode);

            //ARB_framebuffer_object
            // render buffers
            public delegate void delGenRenderbuffers(int number, ref uint Renderbuffers);
            public delegate void delDeleteRenderbuffers(int number, ref uint Renderbuffers);
            public delegate void delBindRenderbuffer(RenderbufferTarget target, uint Renderbuffer);
            public delegate bool delIsRenderbuffer(uint Renderbuffer);

            public delegate void delRenderbufferStorage(RenderbufferTarget target, RenderbufferStorageFormat iformat, int width, int height);

            public delegate void delBindFramebuffer(FramebufferTarget target, uint Framebuffer);
            public delegate void delGenFramebuffers(int number, ref uint Framebuffers);
            public delegate void delDeleteFramebuffers(int number, ref uint Framebuffers);
            public delegate bool delIsFramebuffer(uint Framebuffer);
            //framebuferparameteri

            public delegate void delFramebufferRenderbuffer(FramebufferTarget ftarget, FramebufferAttachmentType attachment, RenderbufferTarget rtarget, uint Renderbuffer);


            public delegate void delFramebufferTexture1D(FramebufferTarget target, FramebufferAttachmentType attachment, TextureTarget texTarget1D, uint TextureID, int Level);
            public delegate void delFramebufferTexture2D(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, TextureTarget texTarget2D, uint TextureID, int level);
            public delegate void delFramebufferTexture3D(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, TextureTarget texTarget3D, uint TextureID, int level, int layer);

            public delegate FramebufferStatus delCheckFramebufferStatus(FramebufferTarget fboTarget);

            public delegate void delGetFramebufferAttachmentParameteriv(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, AttachmentParameters pname, ref int @params);
            public delegate void delGetRenderbufferParameteriv(RenderbufferTarget rTarget, RenderbufferParameters pname, ref int @params);

            public delegate void delGenerateMipmap(TextureTarget target);


            //EXT_draw_buffers2
            public delegate void delColorMaski(DrawBufferTarget drawbuffer, bool red, bool green, bool blue, bool alpha);

            public delegate void delDisablei(EnableStateIndexed cap, uint index);
            public delegate void delEnablei(EnableStateIndexed cap, uint index);

            public delegate void delGetBooleani_v(GetParameters pname, uint index, ref bool data);
            public delegate void delGetIntegeri_v(GetParameters pname, uint index, ref int data);

            public delegate bool delIsEnabledi(EnableStateIndexed cap, uint index);

            //EXT_framebuffer_blit
            public delegate void delBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferFlags mask, BlitFramebufferFilter filter);

            //EXT_framebuffer_multisample
            public delegate void delRenderbufferStorageMultisample(RenderbufferTarget target, int samples, RenderbufferStorageFormat iformat, int width, int height);


            //EXT_gpu_shader4
            public delegate void delBindFragDataLocation(uint Program, DrawBufferTarget colorNumber, string Name);
            public delegate int delGetFragDataLocation(uint Program, string Name);

            public delegate void delGetUniformuiv(uint Program, int location, ref uint @params);

            public delegate void delVertexAttribIPointer(uint index, int size, VertexAttribIFormat iType, int stride, IntPtr ptr);

            public delegate void delGetVertexAttribIiv(uint index, VertexAttribParameters pname, ref int @params);
            public delegate void delGetVertexAttribIuiv(uint index, VertexAttribParameters pname, ref uint @params);

            public delegate void delUniform1ui(int location, uint v1);
            public delegate void delUniform2ui(int location, uint v1, uint v2);
            public delegate void delUniform3ui(int location, uint v1, uint v2, uint v3);
            public delegate void delUniform4ui(int location, uint v1, uint v2, uint v3, uint v4);

            public delegate void delUniform1uiv(int location, int count, ref uint v);
            public delegate void delUniform2uiv(int location, int count, ref uint v);
            public delegate void delUniform3uiv(int location, int count, ref uint v);
            public delegate void delUniform4uiv(int location, int count, ref uint v);

            /* 16 functions ignored.
            public delegate void delVertexAttribI1i(int index, int v1);
            public delegate void delVertexAttribI2i(int index, int v1, int v2);
            public delegate void delVertexAttribI3i(int index, int v1, int v2, int v3);
            public delegate void delVertexAttribI4i(int index, int v1, int v2, int v3, int v4);

            public delegate void delVertexAttribI1ui(int index, uint v1);
            public delegate void delVertexAttribI2ui(int index, uint v1, uint v2);
            public delegate void delVertexAttribI3ui(int index, uint v1, uint v2, uint v3);
            public delegate void delVertexAttribI4ui(int index, uint v1, uint v2, uint v3, uint v4);

            public delegate void delVertexAttribI1iv(int index, ref int v);
            public delegate void delVertexAttribI2iv(int index, ref int v);
            public delegate void delVertexAttribI3iv(int index, ref int v);
            public delegate void delVertexAttribI4iv(int index, ref int v);

            public delegate void delVertexAttribI1uiv(int index, ref uint v);
            public delegate void delVertexAttribI2uiv(int index, ref uint v);
            public delegate void delVertexAttribI3uiv(int index, ref uint v);
            public delegate void delVertexAttribI4uiv(int index, ref uint v);
            */

            //EXT_texture_integer
            public delegate void delGetTexParameterIiv(TextureTarget target, TextureParameters pname, ref int data);
            public delegate void delGetTexParameterIuiv(TextureTarget target, TextureParameters pname, ref uint data);

            public delegate void delTexParameterIiv(TextureTarget target, TextureParameters pname, ref int data);
            public delegate void delTexParameterIuiv(TextureTarget target, TextureParameters pname, ref uint data);


            //EXT_transform_feedback/NV_transform_feedback
            public delegate void delBindBufferRange(BufferProgramTarget target, uint bindingIndex, uint BufferId, IntPtr Offset, IntPtr Size);
            public delegate void delBindBufferBase(BufferProgramTarget target, uint bindingIndex, uint BufferId);

            public delegate void delBeginTransformFeedback(BeginMode primitiveMode);
            public delegate void delEndTransformFeedback();
            public delegate void delTransformFeedbackVaryings(uint Program, int count, string[] varyings, TransformFeedbackAttributeMode bufferMode);
            public delegate void delGetTransformFeedbackVarying(uint Program, uint index, int bufSize, out int length, out int size, out AttributeType type, StringBuilder name);

            //NV_conditional_render
            public delegate void delBeginConditionalRender(uint id, ConditionalRenderType mode);
            public delegate void delEndConditionalRender();


            #endregion

            #region GL Fields

            public static delFlushMappedBufferRange glFlushMappedBufferRange;
            public static delMapBufferRange glMapBufferRange;

            public static delGenVertexArrays glGenVertexArrays;
            public static delDeleteVertexArrays glDeleteVertexArrays;
            public static delBindVertexArray glBindVertexArray;
            public static delIsVertexArray glIsVertexArray;

            public static delClampColor glClampColor;

            // render buffers
            public static delGenRenderbuffers glGenRenderbuffers;
            public static delDeleteRenderbuffers glDeleteRenderbuffers;
            public static delBindRenderbuffer glBindRenderbuffer;
            public static delIsRenderbuffer glIsRenderbuffer;

            public static delRenderbufferStorage glRenderbufferStorage;

            public static delBindFramebuffer glBindFramebuffer;
            public static delGenFramebuffers glGenFramebuffers;
            public static delDeleteFramebuffers glDeleteFramebuffers;
            public static delIsFramebuffer glIsFramebuffer;
            //framebuferparameteri

            public static delFramebufferRenderbuffer glFramebufferRenderbuffer;
            //public static delFramebufferTexture(FramebufferTarget target, FramebufferAttachmentType attachment, uint TextureID, int level);

            public static delFramebufferTexture1D glFramebufferTexture1D;
            public static delFramebufferTexture2D glFramebufferTexture2D;
            public static delFramebufferTexture3D glFramebufferTexture3D;

            public static delCheckFramebufferStatus glCheckFramebufferStatus;

            public static delGetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;
            public static delGetRenderbufferParameteriv glGetRenderbufferParameteriv;

            public static delGenerateMipmap glGenerateMipmap;

            public static delColorMaski glColorMaski;

            public static delDisablei glDisablei;
            public static delEnablei glEnablei;

            public static delGetBooleani_v glGetBooleani_v;
            public static delGetIntegeri_v glGetIntegeri_v;

            public static delIsEnabledi glIsEnabledi;

            public static delBlitFramebuffer glBlitFramebuffer;

            public static delRenderbufferStorageMultisample glRenderbufferStorageMultisample;

            public static delBindFragDataLocation glBindFragDataLocation;
            public static delGetFragDataLocation glGetFragDataLocation;

            public static delGetUniformuiv glGetUniformuiv;

            public static delVertexAttribIPointer glVertexAttribIPointer;

            public static delGetVertexAttribIiv glGetVertexAttribIiv;
            public static delGetVertexAttribIuiv glGetVertexAttribIuiv;

            public static delUniform1ui glUniform1ui;
            public static delUniform2ui glUniform2ui;
            public static delUniform3ui glUniform3ui;
            public static delUniform4ui glUniform4ui;

            public static delUniform1uiv glUniform1uiv;
            public static delUniform2uiv glUniform2uiv;
            public static delUniform3uiv glUniform3uiv;
            public static delUniform4uiv glUniform4uiv;

            /* 16 functions ignored.
            public static delVertexAttribI1i glVertexAttribI1i;
            public static delVertexAttribI2i glVertexAttribI2i;
            public static delVertexAttribI3i glVertexAttribI3i;
            public static delVertexAttribI4i glVertexAttribI4i;

            public static delVertexAttribI1ui glVertexAttribI1ui;
            public static delVertexAttribI2ui glVertexAttribI2ui;
            public static delVertexAttribI3ui glVertexAttribI3ui;
            public static delVertexAttribI4ui glVertexAttribI4ui;

            public static delVertexAttribI1iv glVertexAttribI1iv;
            public static delVertexAttribI2iv glVertexAttribI2iv;
            public static delVertexAttribI3iv glVertexAttribI3iv;
            public static delVertexAttribI4iv glVertexAttribI4iv;

            public static delVertexAttribI1uiv glVertexAttribI1uiv;
            public static delVertexAttribI2uiv glVertexAttribI2uiv;
            public static delVertexAttribI3uiv glVertexAttribI3uiv;
            public static delVertexAttribI4uiv glVertexAttribI4uiv;
            */

            public static delGetTexParameterIiv glGetTexParameterIiv;
            public static delGetTexParameterIuiv glGetTexParameterIuiv;

            public static delTexParameterIiv glTexParameterIiv;
            public static delTexParameterIuiv glTexParameterIuiv;

            public static delBindBufferRange glBindBufferRange;
            public static delBindBufferBase glBindBufferBase;

            public static delBeginTransformFeedback glBeginTransformFeedback;
            public static delEndTransformFeedback glEndTransformFeedback;
            public static delTransformFeedbackVaryings glTransformFeedbackVaryings;
            public static delGetTransformFeedbackVarying glGetTransformFeedbackVarying;

            public static delBeginConditionalRender glBeginConditionalRender;
            public static delEndConditionalRender glEndConditionalRender;


            #endregion
        }

        #endregion

        #region Public functions.

        /// <summary>
        /// Flushes a sub region of a mapped buffer region.
        /// </summary>
        /// <param name="target">Buffertarget to flush.</param>
        /// <param name="Offset">Offset in bytes to flush</param>
        /// <param name="Length">Length in bytes from offset.</param>
        public static void FlushMappedBufferRange(BufferTarget target, long Offset, long Length)
        {
            Delegates.glFlushMappedBufferRange(target, (IntPtr)Offset, (IntPtr)Length);
        }
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
            return Delegates.glMapBufferRange(target, (IntPtr)Offset, (IntPtr)Length, access);
        }

        /// <summary>
        /// Generates an array of vertex array objects.
        /// </summary>
        /// <param name="Arrays">Precreated Array to fill with vertex array objects.</param>
        public static void GenVertexArrays(uint[] Arrays)
        {
            Delegates.glGenVertexArrays(Arrays.Length, ref Arrays[0]);
        }
        /// <summary>
        /// Generates a vertex array object id.
        /// </summary>
        /// <returns>a new vertex array object id or 0 if it failed.</returns>
        public static uint GenVertexArrays()
        {
            uint tmp = 0;
            Delegates.glGenVertexArrays(1, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Deletes an array of vertex array objects.
        /// </summary>
        /// <param name="Arrays"></param>
        public static void DeleteVertexArrays(uint[] Arrays)
        {
            Delegates.glDeleteVertexArrays(Arrays.Length, ref Arrays[0]);
        }
        /// <summary>
        /// Deletes a single vertex array object.
        /// </summary>
        /// <param name="Array"></param>
        public static void DeleteVertexArrays(uint Array)
        {
            Delegates.glDeleteVertexArrays(1, ref Array);
        }

        /// <summary>
        /// Binds this vertex array object as current.
        /// Or if called with Array=0, binds none as current.
        /// </summary>
        /// <param name="Array"></param>
        public static void BindVertexArray(uint Array)
        {
            Delegates.glBindVertexArray(Array);
        }
        /// <summary>
        /// Is this a vertex array object?
        /// </summary>
        /// <param name="Array"></param>
        /// <returns></returns>
        public static bool IsVertexArray(uint Array)
        {
            return Delegates.glIsVertexArray(Array);
        }

        public static void ClampColor(ClampColorTarget target, ClampColorMode mode)
        {
            Delegates.glClampColor(target, mode);
        }

        // render buffers
        /// <summary>
        /// Generates an array of renderbuffer ids.
        /// </summary>
        /// <param name="Renderbuffers">Preallocated array where new renderbuffer ids is written.</param>
        public static void GenRenderbuffers(uint[] Renderbuffers)
        {
            Delegates.glGenRenderbuffers(Renderbuffers.Length, ref Renderbuffers[0]);
        }
        /// <summary>
        /// Generates a single new renderbuffer id.
        /// </summary>
        /// <returns></returns>
        public static uint GenRenderbuffers()
        {
            uint tmp = 0;
            Delegates.glGenRenderbuffers(1, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Deletes an array of renderbuffers.
        /// </summary>
        /// <param name="Renderbuffers"></param>
        public static void DeleteRenderbuffers(uint[] Renderbuffers)
        {
            Delegates.glDeleteRenderbuffers(Renderbuffers.Length, ref Renderbuffers[0]);
        }
        /// <summary>
        /// Deletes a single renderbuffer.
        /// </summary>
        /// <param name="Renderbuffer"></param>
        public static void DeleteRenderbuffers(uint Renderbuffer)
        {
            Delegates.glDeleteRenderbuffers(1, ref Renderbuffer);
        }
        /// <summary>
        /// Binds the specified renderbuffer to the current framebuffer object.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="Renderbuffer"></param>
        public static void BindRenderbuffer(uint Renderbuffer, RenderbufferTarget target = RenderbufferTarget.Renderbuffer )
        {
            Delegates.glBindRenderbuffer(target, Renderbuffer);
        }
        /// <summary>
        /// Is this a renderbuffer?
        /// </summary>
        /// <param name="Renderbuffer"></param>
        /// <returns></returns>
        public static bool IsRenderbuffer(uint Renderbuffer)
        {
            return Delegates.glIsRenderbuffer(Renderbuffer);
        }

        /// <summary>
        /// Allocates renderbuffer storage format and dimension.
        /// </summary>
        /// <param name="target">RenderbufferTarget</param>
        /// <param name="iformat">Format of renderbuffer.</param>
        /// <param name="width">width of renderbuffer.</param>
        /// <param name="height">height of renderbuffer.</param>
        public static void RenderbufferStorage(RenderbufferStorageFormat iformat, int width, int height, RenderbufferTarget target = RenderbufferTarget.Renderbuffer)
        {
            Delegates.glRenderbufferStorage(target, iformat, width, height);
        }

        /// <summary>
        /// Binds the specified framebuffer id as current at framebuffertarget.
        /// </summary>
        /// <param name="target">The target to bind framebuffer id at.</param>
        /// <param name="Framebuffer">The id of the framebuffer to bind.</param>
        public static void BindFramebuffer(FramebufferTarget target, uint Framebuffer)
        {
            Delegates.glBindFramebuffer(target, Framebuffer);
        }

        /// <summary>
        /// Generates an array of frambuffer objects.
        /// </summary>
        /// <param name="Framebuffers">Preallocated array where framebuffer ids is written to.</param>
        public static void GenFramebuffers(uint[] Framebuffers)
        {
            Delegates.glGenFramebuffers(Framebuffers.Length, ref Framebuffers[0]);
        }
        /// <summary>
        /// Generates a single framebuffer object id.
        /// </summary>
        /// <returns></returns>
        public static uint GenFramebuffers()
        {
            uint tmp = 0;
            Delegates.glGenFramebuffers(1, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Deletes an array of framebuffers.
        /// </summary>
        /// <param name="Framebuffers">Array containing framebuffer ids to delete.</param>
        public static void DeleteFramebuffers(uint[] Framebuffers)
        {
            Delegates.glDeleteFramebuffers(Framebuffers.Length, ref Framebuffers[0]);
        }
        /// <summary>
        /// Deletes a single frambuffer id.
        /// </summary>
        /// <param name="Framebuffer"></param>
        public static void DeleteFramebuffers(uint Framebuffer)
        {
            Delegates.glDeleteFramebuffers(1, ref Framebuffer);
        }

        /// <summary>
        /// Is this a framebuffer?
        /// </summary>
        /// <param name="Framebuffer"></param>
        /// <returns></returns>
        public static bool IsFramebuffer(uint Framebuffer)
        {
            return Delegates.glIsFramebuffer(Framebuffer);
        }
        //framebuferparameteri

        /// <summary>
        /// Attaches a renderbuffer to the framebuffer bound at specified target.
        /// </summary>
        /// <param name="ftarget">Framebuffer target containg framebuffer to bind to.</param>
        /// <param name="attachment">Attachment point of framebuffer to bind as.</param>
        /// <param name="rtarget">Renderbuffer target.</param>
        /// <param name="Renderbuffer">Randerbuffer id to bind.</param>
        public static void FramebufferRenderbuffer(FramebufferTarget ftarget, FramebufferAttachmentType attachment, uint Renderbuffer, RenderbufferTarget rtarget = RenderbufferTarget.Renderbuffer )
        {
            Delegates.glFramebufferRenderbuffer(ftarget, attachment, rtarget, Renderbuffer);
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
        /// </remarks>
        public static void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachmentType attachment, TextureTarget texTarget1D, uint TextureID, int Level = 0)
        {
            Delegates.glFramebufferTexture1D(target, attachment, texTarget1D, TextureID, Level);
        }
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
        public static void FramebufferTexture2D(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, TextureTarget texTarget2D, uint TextureID, int level =0)
        {
            Delegates.glFramebufferTexture2D(fboTarget, attachment, texTarget2D, TextureID, level);
        }
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
        [Obsolete("Use glFramebufferTextureLayer​ instead, since it can do everything FramebufferTexture3D can and more.")]
        public static void FramebufferTexture3D(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, TextureTarget texTarget3D, uint TextureID, int level = 0, int layer = 0)
        {
            Delegates.glFramebufferTexture3D(fboTarget, attachment, texTarget3D, TextureID, level, layer);
        }

        /// <summary>
        /// Checks the framebuffer for completeness.
        /// </summary>
        /// <param name="fboTarget">Framebuffertarget with bound framebuffer to check for completeness.</param>
        /// <returns></returns>
        public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget fboTarget)
        {
            return Delegates.glCheckFramebufferStatus(fboTarget);
        }

        /// <summary>
        /// Retrives attachment parameters for specified attachment to currently bound framebuffer at framebuffertarget.
        /// </summary>
        /// <param name="fboTarget">Framebuffertarget with bound framebuffer to query.</param>
        /// <param name="attachment">Attachment to query.</param>
        /// <param name="pname">Paramenter name to retrive.</param>
        /// <param name="params">Result of query.</param>
        public static void GetFramebufferAttachmentParameteriv(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, AttachmentParameters pname, int[] @params)
        {
            Delegates.glGetFramebufferAttachmentParameteriv(fboTarget, attachment, pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives attachment parameters for specified attachment to currently bound framebuffer at framebuffertarget.
        /// </summary>
        /// <param name="fboTarget">Framebuffertarget with bound framebuffer to query.</param>
        /// <param name="attachment">Attachment to query.</param>
        /// <param name="pname">Paramenter name to retrive.</param>
        /// <returns>Result of query.</returns>
        public static int GetFramebufferAttachmentParameteriv(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, AttachmentParameters pname)
        {
            int tmp = 0;
            Delegates.glGetFramebufferAttachmentParameteriv(fboTarget, attachment, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Retrives renderbuffer parameters from current bound renderbuffer.
        /// </summary>
        /// <param name="pname">Paramenter name to retrive.</param>
        /// <param name="params">Result of query.</param>
        /// <param name="rTarget">Renderbuffer target with bound renderbuffer to query..</param>
        public static void GetRenderbufferParameteriv(RenderbufferParameters pname, int[] @params, RenderbufferTarget rTarget = RenderbufferTarget.Renderbuffer )
        {
            Delegates.glGetRenderbufferParameteriv(rTarget, pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives renderbuffer parameters from current bound renderbuffer.
        /// </summary>
        /// <param name="pname">Paramenter name to retrive.</param>
        /// <param name="rTarget">Renderbuffer target with bound renderbuffer to query..</param>
        /// <returns>Result of query.</returns>
        public static int GetRenderbufferParameteriv(RenderbufferParameters pname, RenderbufferTarget rTarget = RenderbufferTarget.Renderbuffer)
        {
            int tmp = 0;
            Delegates.glGetRenderbufferParameteriv(rTarget, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Generates new mipmaps for texture currently bound to specified texture target at active texture unit.
        /// </summary>
        /// <param name="target"></param>
        public static void GenerateMipmap(TextureTarget target)
        {
            Delegates.glGenerateMipmap(target);
        }

        /// <summary>
        /// Sets the color mask for a specified drawbuffer.
        /// </summary>
        /// <param name="drawbuffer">Drawbuffer to set mask for.</param>
        /// <param name="red">red mask</param>
        /// <param name="green">green mask</param>
        /// <param name="blue">blue mask</param>
        /// <param name="alpha">alpha mask.</param>
        public static void ColorMaski(DrawBufferTarget drawbuffer, bool red, bool green, bool blue, bool alpha)
        {
            Delegates.glColorMaski(drawbuffer, red, green, blue, alpha);
        }

        /// <summary>
        /// Disables an indexed state.
        /// Note that what index means is dependent on cap.
        /// </summary>
        /// <param name="cap">Cap describing what to disable and what index means.</param>
        /// <param name="index">zero based. What index means is dependent on cap.</param>
        public static void Disablei(EnableStateIndexed cap, uint index)
        {
            Delegates.glDisablei(cap, index);
        }
        /// <summary>
        /// Enables an indexed state.
        /// Note that what index means is dependent on cap.
        /// </summary>
        /// <param name="cap">Cap describing what to enable and what index means.</param>
        /// <param name="index">zero based. What index means is dependent on cap.</param>
        public static void Enablei(EnableStateIndexed cap, uint index)
        {
            //uint tmp = 0;
            //switch (cap)
            //{
            //    case EnableStateIndexed.Blend:
            //        // index measn zero based drawbuffers

            //        if (((int)All.DRAW_BUFFER0 - 1) < index)
            //            tmp = index - (int)All.DRAW_BUFFER0;
            //        else
            //            tmp = index;

            //        break;
            //    default:
            //        tmp = index;
            //        break;
            //}
            //Delegates.glEnablei(cap, tmp);

            Delegates.glEnablei(cap, index);
        }

        public static void GetBooleani_v(GetParameters pname, uint index, bool[] data)
        {
            Delegates.glGetBooleani_v(pname, index, ref data[0]);
        }
        public static void GetIntegeri_v(GetParameters pname, uint index, int[] data)
        {
            Delegates.glGetIntegeri_v(pname, index, ref data[0]);
        }

        /// <summary>
        /// Retrives the indexed state of cap.
        /// </summary>
        /// <param name="cap">The indexed cap state to retrive.</param>
        /// <param name="index">zero based. Index of cap type to query.</param>
        /// <returns>true if enabled, false otherwise.</returns>
        public static bool IsEnabledi(EnableStateIndexed cap, uint index)
        {
            return Delegates.glIsEnabledi(cap, index);
        }

        public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferFlags mask, BlitFramebufferFilter filter)
        {
            Delegates.glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }

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
            Delegates.glRenderbufferStorageMultisample(target, samples, iformat, width, height);
        }

        /// <summary>
        /// Binds a fragment output to a specified drawbuffer.
        /// </summary>
        /// <param name="Program">Program containg named fragment output.</param>
        /// <param name="colorNumber">The drawbuffer to write fragment output to.</param>
        /// <param name="Name">Name of fragment output to bind.</param>
        public static void BindFragDataLocation(uint Program, DrawBufferTarget colorNumber, string Name)
        {
            Delegates.glBindFragDataLocation(Program, colorNumber, Name);
        }
        /// <summary>
        /// Retrives the fragment output index of named fragment output.
        /// </summary>
        /// <param name="Program">Program containg named fragment output.</param>
        /// <param name="Name">Name of fragment output to query for indexed location.</param>
        /// <returns></returns>
        public static int GetFragDataLocation(uint Program, string Name)
        {
            return Delegates.glGetFragDataLocation(Program, Name);
        }

        /// <summary>
        /// Retrives uint[] value at location in program.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="location">Location of values to retrive.</param>
        /// <param name="params">Preallocated array big enough for retrived values.</param>
        public static void GetUniformuiv(uint Program, int location, uint[] @params)
        {
            Delegates.glGetUniformuiv(Program, location, ref @params[0]);
        }
        /// <summary>
        /// Retrives the uint value at location in program.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="location">Location of value to retrive.</param>
        /// <returns></returns>
        public static uint GetUniformuiv(uint Program, int location)
        {
            uint tmp = 0;
            Delegates.glGetUniformuiv(Program, location, ref tmp);
            return tmp;
        }
        /// <summary>
        /// Integer Vertex declaration for attribute index in current bound vertex array object.
        /// </summary>
        /// <param name="index">Attribute index to declare vertex source.</param>
        /// <param name="size">number of components in iType.</param>
        /// <param name="iType">Integer type of vertex declaration.</param>
        /// <param name="stride">Stride between individually vertices.</param>
        /// <param name="offset">Offset into currenly bound arraybuffer to source from.</param>        
        public static void VertexAttribIPointer(uint index, int size, VertexAttribIFormat iType, int stride, long offset)
        {
            Delegates.glVertexAttribIPointer(index, size, iType, stride, (IntPtr)offset);
        }

        public static void GetVertexAttribIiv(uint index, VertexAttribParameters pname, int[] @params)
        {
            Delegates.glGetVertexAttribIiv(index, pname, ref @params[0]);
        }
        public static int GetVertexAttribIiv(uint index, VertexAttribParameters pname)
        {
            int tmp = 0;
            Delegates.glGetVertexAttribIiv(index, pname, ref tmp);
            return tmp;
        }

        public static void GetVertexAttribIuiv(uint index, VertexAttribParameters pname, uint[] @params)
        {
            Delegates.glGetVertexAttribIuiv(index, pname, ref @params[0]);
        }
        public static uint GetVertexAttribIuiv(uint index, VertexAttribParameters pname)
        {
            uint tmp = 0;
            Delegates.glGetVertexAttribIuiv(index, pname, ref tmp);
            return tmp;
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
        public static void Uniform1uiv(int location, uint[] v)
        {
            Delegates.glUniform1uiv(location, v.Length, ref v[0]);
        }
        public static void Uniform2uiv(int location, ref uint v, int count = 1)
        {
            Delegates.glUniform2uiv(location, count, ref v);
        }
        public static void Uniform2uiv(int location, uint[] v)
        {
            Delegates.glUniform2uiv(location, v.Length / 2, ref v[0]);
        }
        public static void Uniform3uiv(int location, ref uint v, int count = 1)
        {
            Delegates.glUniform3uiv(location, count, ref v);
        }
        public static void Uniform3uiv(int location, uint[] v)
        {
            Delegates.glUniform3uiv(location, v.Length / 3, ref v[0]);
        }

        public static void Uniform4uiv(int location, ref uint v, int count = 1)
        {
            Delegates.glUniform4uiv(location, count, ref v);
        }
        public static void Uniform4uiv(int location, uint[] v)
        {
            Delegates.glUniform4uiv(location, v.Length / 4, ref v[0]);
        }

        /// <summary>
        /// Retrives a integer parameter from a interger texture.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        public static void GetTexParameterIiv(TextureTarget target, TextureParameters pname, int[] data)
        {
            Delegates.glGetTexParameterIiv(target, pname, ref data[0]);
        }
        /// <summary>
        /// Retrives a integer parameter from a integer texture.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <returns></returns>
        public static int GetTexParameterIiv(TextureTarget target, TextureParameters pname)
        {
            int tmp = 0;
            Delegates.glGetTexParameterIiv(target, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Gets a integer parameter from a integer texture.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        public static void GetTexParameterIuiv(TextureTarget target, TextureParameters pname, uint[] data)
        {
            Delegates.glGetTexParameterIuiv(target, pname, ref data[0]);
        }
        /// <summary>
        /// Gets a integer parameter from a integer texture.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <returns></returns>
        public static uint GetTexParameterIuiv(TextureTarget target, TextureParameters pname)
        {
            uint tmp = 0;
            Delegates.glGetTexParameterIuiv(target, pname, ref tmp);
            return tmp;
        }
        /// <summary>
        /// Sets a integer parameter.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        public static void TexParameterIiv(TextureTarget target, TextureParameters pname, int[] data)
        {
            Delegates.glTexParameterIiv(target, pname, ref data[0]);
        }
        /// <summary>
        /// Sets a integer parameter.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        public static void TexParameterIiv(TextureTarget target, TextureParameters pname, ref int data)
        {
            Delegates.glTexParameterIiv(target, pname, ref data);
        }

        /// <summary>
        /// Sets a integer parameter.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        public static void TexParameterIuiv(TextureTarget target, TextureParameters pname, uint[] data)
        {
            Delegates.glTexParameterIuiv(target, pname, ref data[0]);
        }
        /// <summary>
        /// Sets a integer parameter.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        public static void TexParameterIuiv(TextureTarget target, TextureParameters pname, ref uint data)
        {
            Delegates.glTexParameterIuiv(target, pname, ref data);
        }

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
            Delegates.glBindBufferRange(target, bindingIndex, BufferId, (IntPtr)Offset, (IntPtr)Size);
        }
        /// <summary>
        /// Binds a buffer to a bindingindex on current bound program.
        /// Note that there are separate ranges of bindingindexes dependent on which target you bind.
        /// Aka UniformBuffertarget and index 0 is not the same as ShaderStorageTarget and index 0.
        /// </summary>
        /// <param name="target">The target on current bound program to bind buffer at.</param>
        /// <param name="bindingIndex">The bindingindex of target type to bind to.</param>
        /// <param name="BufferId">The id of the buffer to bind.</param>
        public static void BindBufferBase(BufferProgramTarget target, uint bindingIndex, uint BufferId)
        {
            Delegates.glBindBufferBase(target, bindingIndex, BufferId);
        }

        /// <summary>
        /// Starts a transformfeedback rendering.
        /// </summary>
        /// <param name="primitiveMode">the type of primitives to render.</param>
        public static void BeginTransformFeedback(BeginMode primitiveMode)
        {
            Delegates.glBeginTransformFeedback(primitiveMode);
        }
        /// <summary>
        /// Ends a transformfeedback rendering.
        /// </summary>
        public static void EndTransformFeedback()
        {
            Delegates.glEndTransformFeedback();
        }

        /// <summary>
        /// Specifies a set of transformfeedback varyings/attributes buffermodes in one call.
        /// </summary>
        /// <param name="Program">Program to set buffermode on.</param>
        /// <param name="varyings">array of varying/attribute names to specify buffer mode for.</param>
        /// <param name="bufferMode">The buffermode to set.</param>
        public static void TransformFeedbackVaryings(uint Program, string[] varyings, TransformFeedbackAttributeMode bufferMode)
        {
            Delegates.glTransformFeedbackVaryings(Program, varyings.Length, varyings, bufferMode);
        }

        public static void GetTransformFeedbackVarying(uint Program, uint index, int bufSize, out int length, out int size, out AttributeType type, StringBuilder name)
        {
            Delegates.glGetTransformFeedbackVarying(Program, index, bufSize, out length, out size, out type, name);
        }
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
            var sb = new StringBuilder(MaxAttributeNameLength + 4);
            Delegates.glGetTransformFeedbackVarying(Program, index, sb.Capacity - 2, out MaxAttributeNameLength, out size, out type, sb);
            name = sb.ToString();
        }

        /// <summary>
        /// Starts a conditional render.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mode"></param>
        public static void BeginConditionalRender(uint id, ConditionalRenderType mode)
        {
            Delegates.glBeginConditionalRender(id, mode);
        }
        /// <summary>
        /// ends a condition render
        /// </summary>
        public static void EndConditionalRender()
        {
            Delegates.glEndConditionalRender();
        }

        #endregion
    }
}
