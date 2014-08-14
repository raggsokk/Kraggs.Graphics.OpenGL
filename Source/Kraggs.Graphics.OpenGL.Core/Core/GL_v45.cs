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
        #region OpenGL DLLImports

        //[EntryPointSlot(1)]
        //[DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //private static extern void glBindTexture(TextureTarget target, uint textureid);

        #region ARB_clip_control

        [EntryPointSlot(470)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glClipControl(ClipControlOrigin origin, ClipControlDepth depth);

        #endregion

        #region ARB_ES3_1_compatibility

        [EntryPointSlot(471)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMemoryBarrierByRegion(MemoryBarrierByRegionFlags barriers);

        #endregion

        #region ARB_get_texture_sub_image

        [EntryPointSlot(472)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int BufSize, IntPtr pixels);

        [EntryPointSlot(473)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int BufSize, IntPtr pixels);

        #endregion

        #region ARB_texture_barrier

        [EntryPointSlot(474)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureBarrier();

        #endregion

        #region ARB_direct_state_access

        /* Transform Feedback object functions */
        [EntryPointSlot(475)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glCreateTransformFeedbacks(int n, uint* ids);
        [EntryPointSlot(476)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer);
        [EntryPointSlot(477)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTransformFeedbackBufferRange(uint xfb, uint index, uint buffer, IntPtr offset, IntPtr size);
        [EntryPointSlot(478)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTransformFeedbackiv(uint xfb, TransformFeedbackParameters pname, int* param);
        [EntryPointSlot(479)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTransformFeedbacki_v(uint xfb, TransformFeedbackParameters pname, uint index, int* param);
        [EntryPointSlot(480)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTransformFeedbacki64_v(uint xfb, TransformFeedbackParameters pname, uint index, long* param);

        /* Buffer object functions */
        [EntryPointSlot(481)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glCreateBuffers(int n, uint* buffers);
        [EntryPointSlot(482)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedBufferStorage(uint buffer, IntPtr size, IntPtr data, BufferStorageFlags flags);
        [EntryPointSlot(483)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedBufferData(uint buffer, IntPtr size, IntPtr data, BufferUsage usage);
        [EntryPointSlot(484)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, IntPtr data);
        [EntryPointSlot(485)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCopyNamedBufferSubData(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
        [EntryPointSlot(486)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glClearNamedBufferData(uint buffer, ClearBufferDataFormat internalformat, PixelFormat format, PixelType type, IntPtr data);
        [EntryPointSlot(487)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glClearNamedBufferSubData(uint buffer, ClearBufferDataFormat internalformat, IntPtr offset, IntPtr size, PixelFormat format, PixelType type, IntPtr data);
        [EntryPointSlot(488)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern IntPtr glMapNamedBuffer(uint buffer, MapBufferAccess access);
        [EntryPointSlot(489)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern IntPtr glMapNamedBufferRange(uint buffer, IntPtr offset, IntPtr length, MapBufferRangeAccessFlags access);
        [EntryPointSlot(490)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glUnmapNamedBuffer(uint buffer);
        [EntryPointSlot(491)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFlushMappedNamedBufferRange(uint buffer, IntPtr offset, IntPtr length);
        [EntryPointSlot(492)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetNamedBufferParameteriv(uint buffer, BufferParameters pname, int* result);
        [EntryPointSlot(493)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetNamedBufferParameteri64v(uint buffer, BufferParameters pname, long* result);
        [EntryPointSlot(494)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetNamedBufferPointerv(uint buffer, BufferPointerParameters pname, IntPtr* result);
        [EntryPointSlot(495)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetNamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, IntPtr data);

        /* Framebuffer object functions */
        [EntryPointSlot(496)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glCreateFramebuffers(int n, uint* framebuffers);
        [EntryPointSlot(497)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedFramebufferRenderbuffer(uint framebuffer, FramebufferAttachmentType attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);
        [EntryPointSlot(498)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedFramebufferParameteri(uint framebuffer, FramebufferParameters pname, int param);
        [EntryPointSlot(499)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedFramebufferTexture(uint framebuffer, FramebufferAttachmentType attachment, uint texture, int level);
        [EntryPointSlot(500)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedFramebufferTextureLayer(uint framebuffer, FramebufferAttachmentType attachment, uint texture, int level, int layer);
        [EntryPointSlot(501)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedFramebufferDrawBuffer(uint framebuffer, FramebufferTarget mode);
        [EntryPointSlot(502)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glNamedFramebufferDrawBuffers(uint framebuffer, int n, DrawBufferTarget* bufs);
        [EntryPointSlot(503)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedFramebufferReadBuffer(uint framebuffer, FramebufferTarget mode);
        [EntryPointSlot(504)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, FramebufferAttachmentType* attachments);
        [EntryPointSlot(505)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, FramebufferAttachmentType* attachments, int x, int y, int width, int height);
        [EntryPointSlot(506)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glClearNamedFramebufferiv(uint framebuffer, ClearBuffer buffer, int drawbuffer, int* value);
        [EntryPointSlot(507)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glClearNamedFramebufferuiv(uint framebuffer, ClearBuffer buffer, int drawbuffer, uint* value);
        [EntryPointSlot(508)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glClearNamedFramebufferfv(uint framebuffer, ClearBuffer buffer, int drawbuffer, float* value);
        [EntryPointSlot(509)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glClearNamedFramebufferfi(uint framebuffer, ClearBuffer buffer, DrawBufferTarget drawbuffer, float depth, int stencil);
        [EntryPointSlot(510)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferFlags mask, BlitFramebufferFilter filter);
        [EntryPointSlot(511)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern FramebufferStatus glCheckNamedFramebufferStatus(uint framebuffer, FramebufferTarget target);
        [EntryPointSlot(512)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetNamedFramebufferParameteriv(uint framebuffer, FramebufferParameters pname, int* param);
        [EntryPointSlot(513)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, FramebufferAttachmentType attachment, AttachmentParameters pname, int* result);


        /* Renderbuffer object functions */
        [EntryPointSlot(514)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glCreateRenderbuffers(int n, uint* renderbuffers);
        [EntryPointSlot(515)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedRenderbufferStorage(uint renderbuffer, RenderbufferStorageFormat internalformat, int width, int height);
        [EntryPointSlot(516)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, RenderbufferStorageFormat internalformat, int width, int height);
        [EntryPointSlot(517)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetNamedRenderbufferParameteriv(uint renderbuffer, RenderbufferParameters pname, int* result);


        /* Texture object functions */
        [EntryPointSlot(518)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glCreateTextures(TextureTarget target, int n, uint* textures);
        [EntryPointSlot(519)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureBuffer(uint texture, TextureBufferInternalFormat internalformat, uint buffer);
        [EntryPointSlot(520)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureBufferRange(uint texture, TextureBufferInternalFormat internalformat, uint buffer, IntPtr offset, IntPtr size);
        [EntryPointSlot(521)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureStorage1D(uint texture, int levels, PixelInternalFormat internalformat, int width);
        [EntryPointSlot(522)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureStorage2D(uint texture, int levels, PixelInternalFormat internalformat, int width, int height);
        [EntryPointSlot(523)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureStorage3D(uint texture, int levels, PixelInternalFormat internalformat, int width, int height, int depth);
        [EntryPointSlot(524)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureStorage2DMultisample(uint texture, int samples, PixelInternalFormat internalformat, int width, int height, bool fixedsamplelocations);
        [EntryPointSlot(525)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureStorage3DMultisample(uint texture, int samples, PixelInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations);
        [EntryPointSlot(526)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureSubImage1D(uint texture, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels);
        [EntryPointSlot(527)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels);
        [EntryPointSlot(528)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels);
        [EntryPointSlot(529)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, CompressedInternalFormat format, int imageSize, IntPtr data);
        [EntryPointSlot(530)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, CompressedInternalFormat format, int imageSize, IntPtr data);
        [EntryPointSlot(531)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, CompressedInternalFormat format, int imageSize, IntPtr data);
        [EntryPointSlot(532)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width);
        [EntryPointSlot(533)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        [EntryPointSlot(534)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        [EntryPointSlot(535)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureParameterf(uint texture, TextureParameters pname, float param);
        [EntryPointSlot(536)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glTextureParameterfv(uint texture, TextureParameters pname, float* param);
        [EntryPointSlot(537)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureParameteri(uint texture, TextureParameters pname, int param);
        [EntryPointSlot(538)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glTextureParameterIiv(uint texture, TextureParameters pname, int* result);
        [EntryPointSlot(539)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glTextureParameterIuiv(uint texture, TextureParameters pname, uint* result);
        [EntryPointSlot(540)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glTextureParameteriv(uint texture, TextureParameters pname, int* param);
        [EntryPointSlot(541)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGenerateTextureMipmap(uint texture);
        [EntryPointSlot(542)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindTextureUnit(uint unit, uint texture);
        [EntryPointSlot(543)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetTextureImage(uint texture, int level, PixelFormat format, PixelType type, int bufSize, IntPtr pixels);
        [EntryPointSlot(544)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels);
        [EntryPointSlot(545)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureLevelParameterfv(uint texture, int level, TextureLevelParameters pname, float* result);
        [EntryPointSlot(546)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureLevelParameteriv(uint texture, int level, TextureLevelParameters pname, int* result);
        [EntryPointSlot(547)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureParameterfv(uint texture, TextureParameters pname, float* result);
        [EntryPointSlot(548)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureParameterIiv(uint texture, TextureParameters pname, int* result);
        [EntryPointSlot(549)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureParameterIuiv(uint texture, TextureParameters pname, uint* result);
        [EntryPointSlot(550)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureParameteriv(uint texture, TextureParameters pname, int* result);


        /* Vertex Array object functions */
        [EntryPointSlot(551)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glCreateVertexArrays(int n, uint* arrays);
        [EntryPointSlot(552)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDisableVertexArrayAttrib(uint vaobj, uint index);
        [EntryPointSlot(553)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glEnableVertexArrayAttrib(uint vaobj, uint index);
        [EntryPointSlot(554)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayElementBuffer(uint vaobj, uint buffer);
        [EntryPointSlot(555)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, int stride);
        [EntryPointSlot(556)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glVertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, IntPtr* offsets, int* strides);
        [EntryPointSlot(557)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, VertexAttribFormat type, bool normalized, uint relativeoffset);
        [EntryPointSlot(558)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, VertexAttribIFormat type, uint relativeoffset);
        [EntryPointSlot(559)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, VertexAttribLFormat type, uint relativeoffset);
        [EntryPointSlot(560)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex);
        [EntryPointSlot(561)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor);
        [EntryPointSlot(562)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetVertexArrayiv(uint vaobj, VertexArrayParameters pname, int* param);
        [EntryPointSlot(563)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetVertexArrayIndexediv(uint vaobj, uint index, VertexAttribParameters pname, int* param);
        [EntryPointSlot(564)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetVertexArrayIndexed64iv(uint vaobj, uint index, VertexAttribParameters pname, long* param);

        /* Sampler object functions */
        [EntryPointSlot(565)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glCreateSamplers(int n, uint* samplers);


        /* Program Pipeline object functions */
        [EntryPointSlot(566)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glCreateProgramPipelines(int n, uint* pipelines);


        /* Query object functions */
        [EntryPointSlot(567)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glCreateQueries(QueryTarget target, int n, uint* ids);


        #endregion

        #endregion

        #region Public functions

        #region ARB_clip_control

        [EntryPoint(FunctionName = "glClipControl")]
        public static void ClipControl(ClipControlOrigin origin, ClipControlDepth depth) { throw new NotImplementedException(); }

        #endregion

        #region  ARB_ES3_1_compatibility

        [EntryPoint(FunctionName = "glMemoryBarrierByRegion")]
        public static void MemoryBarrierByRegion(MemoryBarrierByRegionFlags barriers) { throw new NotImplementedException(); }


        #endregion

        #region ARB_get_texture_sub_image

        [EntryPoint(FunctionName = "glGetTextureSubImage")]
        public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int BufSize, IntPtr pixels) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureSubImage")]
        public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, int BufSize, ref byte pixels) { throw new NotImplementedException(); }

        unsafe public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, byte[] pixels, int index = 0, int count = -1)
        {
            if (count == -1)
                count = pixels.Length;

            var len = Math.Min(pixels.Length - index, index + count);

            fixed(byte* ptr = &pixels[index])
            {
                GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, len, (IntPtr)ptr);
            }
        }
        
        public static void GetTextureSubImage<TValueType>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, TValueType[] pixels, int index = 0, int count = -1) where TValueType : struct
        {
            if (count == -1)
                count = pixels.Length;

            var len = Math.Min(pixels.Length - index, index + count) * Marshal.SizeOf(typeof(TValueType));

            var handle = GCHandle.Alloc(pixels, GCHandleType.Pinned);

            var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(pixels, index);

            GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, len, (IntPtr)ptr);

            handle.Free();
        }

        [EntryPoint(FunctionName = "glGetCompressedTextureSubImage")]
        public static void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int BufSize, IntPtr pixels) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetCompressedTextureSubImage")]
        public static void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int BufSize, ref byte pixels) { throw new NotImplementedException(); }
        
        unsafe public static void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, byte[] pixels, int index = 0, int count = -1)
        {
            if (count == -1)
                count = pixels.Length;

            var len = Math.Min(pixels.Length - index, index + count);

            fixed (byte* ptr = &pixels[index])
            {
                GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, len, (IntPtr)ptr);
            }
        }

        public static void GetCompressedTextureSubImage<TValueType>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, TValueType[] pixels, int index = 0, int count = -1) where TValueType : struct
        {
            if (count == -1)
                count = pixels.Length;

            var len = Math.Min(pixels.Length - index, index + count) * Marshal.SizeOf(typeof(TValueType));

            var handle = GCHandle.Alloc(pixels, GCHandleType.Pinned);

            var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(pixels, index);

            GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, len, (IntPtr)ptr);

            handle.Free();

        }

        #endregion

        #region ARB_texture_barrier

        /// <summary>
        /// TextureBarrier() will guarantee that writes have completed and caches have been invalidated before subsequent Draws are executed."
        /// </summary>
        [EntryPoint(FunctionName = "glTextureBarrier")]
        public static void TextureBarrier() { throw new NotImplementedException(); }

        #endregion

        #region ARB_direct_state_access

        /* Transform Feedback object functions */
        
        [EntryPoint(FunctionName = "glCreateTransformFeedbacks")]
        unsafe public static void CreateTransformFeedbacks(int n, uint* ids){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateTransformFeedbacks")]
        unsafe public static void CreateTransformFeedbacks(int n, ref uint ids) { throw new NotImplementedException(); }
        
        public static void CreateTransformFeedbacks(uint[] ids)
        {
            CreateTransformFeedbacks(ids.Length, ref ids[0]);
        }
        
        public static uint CreateTransformFeedbacks()
        {
            uint id = 0;
            CreateTransformFeedbacks(1, ref id);
            return id;
        }

        [EntryPoint(FunctionName = "glTransformFeedbackBufferBase")]
        public static void TransformFeedbackBufferBase(uint xfb, uint index, uint buffer){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTransformFeedbackBufferRange")]
        public static void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, IntPtr offset, IntPtr size){ throw new NotImplementedException(); }
        
        public static void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, long offset, long size)
        {
            TransformFeedbackBufferRange(xfb, index, buffer, (IntPtr)offset, (IntPtr)size);
        }

        [EntryPoint(FunctionName = "glGetTransformFeedbackiv")]
        unsafe public static void GetTransformFeedbackiv(uint xfb, TransformFeedbackParameters pname, int* param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTransformFeedbackiv")]
        public static void GetTransformFeedbackiv(uint xfb, TransformFeedbackParameters pname, int[] param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTransformFeedbackiv")]
        public static void GetTransformFeedbackiv(uint xfb, TransformFeedbackParameters pname, ref int param) { throw new NotImplementedException(); }
        
        public static int[] GetTransformFeedbackiv(uint xfb, TransformFeedbackParameters pname, int ResultArraySize = 1)
        {                            
            var result = new int[ResultArraySize];
            if (ResultArraySize != 0)
                GetTransformFeedbackiv(xfb, pname, ref result[0]);
            return result;
        }

        [EntryPoint(FunctionName = "glGetTransformFeedbacki_v")]
        unsafe public static void GetTransformFeedbacki_v(uint xfb, TransformFeedbackParameters pname, uint index, int* param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTransformFeedbacki_v")]
        public static void GetTransformFeedbacki_v(uint xfb, TransformFeedbackParameters pname, uint index, int[] param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTransformFeedbacki_v")]
        public static void GetTransformFeedbacki_v(uint xfb, TransformFeedbackParameters pname, uint index, ref int param) { throw new NotImplementedException(); }
        
        public static int[] GetTransformFeedbacki_v(uint xfb, TransformFeedbackParameters pname, uint index, int ResultArraySize = 1)
        {
            var result = new int[ResultArraySize];
            if(ResultArraySize != 0)
                GetTransformFeedbacki_v(xfb, pname, index, ref result[0]);
            return result;
        }

        [EntryPoint(FunctionName = "glGetTransformFeedbacki64_v")]
        unsafe public static void GetTransformFeedbacki64_v(uint xfb, TransformFeedbackParameters pname, uint index, long* param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTransformFeedbacki64_v")]
        public static void GetTransformFeedbacki64_v(uint xfb, TransformFeedbackParameters pname, uint index, long[] param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTransformFeedbacki64_v")]
        public static void GetTransformFeedbacki64_v(uint xfb, TransformFeedbackParameters pname, uint index, ref long param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTransformFeedbacki64_v")]
        public static long[] GetTransformFeedbacki64_v(uint xfb, TransformFeedbackParameters pname, uint index, int ResultArraySize = 1)
        {
            var result = new long[ResultArraySize];
            //if (ResultArraySize != 0)
                GetTransformFeedbacki64_v(xfb, pname, index, result);
            return result;
        }

        /* Buffer object functions */

        [EntryPoint(FunctionName = "glCreateBuffers")]
        unsafe public static void CreateBuffers(int n, uint* buffers){ throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glCreateBuffers")]
        //public static void CreateBuffers(int n, uint[] buffers) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateBuffers")]
        public static void CreateBuffers(int n, ref uint buffers) { throw new NotImplementedException(); }
        
        unsafe public static void CreateBuffers(uint[] buffers)
        {
            CreateBuffers(buffers.Length, ref buffers[0]);
        }
        
        public static uint CreateBuffers()
        {
            uint id = 0;
            CreateBuffers(1, ref id);
            return id;
        }

        [EntryPoint(FunctionName = "glNamedBufferStorage")]
        public static void NamedBufferStorage(uint buffer, IntPtr size, IntPtr data, BufferStorageFlags flags){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glNamedBufferStorage")]
        public static void NamedBufferStorage(uint buffer, long size, IntPtr data, BufferStorageFlags flags) { throw new NotImplementedException(); }
        
        unsafe public static void NamedBufferStorage(uint buffer, BufferStorageFlags flags, byte[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count);

            fixed(byte* ptr = &data[index])
            {
                NamedBufferStorage(buffer, (IntPtr)len, (IntPtr)ptr, flags);
            }
        }
        unsafe public static void NamedBufferStorage(uint buffer, BufferStorageFlags flags, ushort[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count) * sizeof(ushort);

            fixed (ushort* ptr = &data[index])
            {
                NamedBufferStorage(buffer, (IntPtr)len, (IntPtr)ptr, flags);
            }
        }
        unsafe public static void NamedBufferStorage(uint buffer, BufferStorageFlags flags, uint[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count) * sizeof(uint);

            fixed (uint* ptr = &data[index])
            {
                NamedBufferStorage(buffer, (IntPtr)len, (IntPtr)ptr, flags);
            }
        }
        unsafe public static void NamedBufferStorage(uint buffer, BufferStorageFlags flags, float[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count) * sizeof(float);

            fixed (float* ptr = &data[index])
            {
                NamedBufferStorage(buffer, (IntPtr)len, (IntPtr)ptr, flags);
            }
        }
        public static void NamedBufferStorage<TValueType>(uint buffer, BufferStorageFlags flags, TValueType[] data, int index = 0, int count = -1) where TValueType : struct
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count) * Marshal.SizeOf(typeof(TValueType));

            var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

            var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(data, index);

            NamedBufferStorage(buffer, (IntPtr)len, ptr, flags);

            handle.Free();
        }

        [EntryPoint(FunctionName = "glNamedBufferData")]
        public static void NamedBufferData(uint buffer, IntPtr size, IntPtr data, BufferUsage usage){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glNamedBufferData")]
        public static void NamedBufferData(uint buffer, long size, IntPtr data, BufferUsage usage) { throw new NotImplementedException(); }
        
        unsafe public static void NamedBufferData(uint buffer, BufferUsage usage, byte[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count);
            
            fixed(byte* ptr = &data[index])
            {
                NamedBufferData(buffer, (IntPtr)len, (IntPtr)ptr, usage);
            }
        }
        unsafe public static void NamedBufferData(uint buffer, BufferUsage usage, ushort[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count) * sizeof(ushort);

            fixed (ushort* ptr = &data[index])
            {
                NamedBufferData(buffer, (IntPtr)len, (IntPtr)ptr, usage);
            }
        }
        unsafe public static void NamedBufferData(uint buffer, BufferUsage usage, uint[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count) * sizeof(uint);

            fixed (uint* ptr = &data[index])
            {
                NamedBufferData(buffer, (IntPtr)len, (IntPtr)ptr, usage);
            }
        }
        unsafe public static void NamedBufferData(uint buffer, BufferUsage usage, float[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count) * sizeof(float);

            fixed (float* ptr = &data[index])
            {
                NamedBufferData(buffer, (IntPtr)len, (IntPtr)ptr, usage);
            }
        }
        public static void NamedBufferData<TValueType>(uint buffer, BufferUsage usage, TValueType[] data, int index = 0, int count = -1) where TValueType : struct
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count) * Marshal.SizeOf(typeof(TValueType));

            var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

            var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(data, index);

            NamedBufferData(buffer, (IntPtr)len, (IntPtr)ptr, usage);

            handle.Free();
        }


        [EntryPoint(FunctionName = "glNamedBufferSubData")]
        public static void NamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, IntPtr data){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glNamedBufferSubData")]
        public static void NamedBufferSubData(uint buffer, long offset, IntPtr size, IntPtr data) { throw new NotImplementedException(); }
        
        unsafe public static void NamedBufferSubData(uint buffer, long offset,  byte[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count);

            fixed(byte* ptr = &data[index])
            {
                NamedBufferSubData(buffer, (IntPtr)offset, (IntPtr)len, (IntPtr)ptr);
            }
        }
        unsafe public static void NamedBufferSubData(uint buffer, long offset, ushort[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count) * sizeof(ushort);

            fixed (ushort* ptr = &data[index])
            {
                NamedBufferSubData(buffer, (IntPtr)offset, (IntPtr)len, (IntPtr)ptr);
            }
        }
        unsafe public static void NamedBufferSubData(uint buffer, long offset, uint[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count) * sizeof(uint);

            fixed (uint* ptr = &data[index])
            {
                NamedBufferSubData(buffer, (IntPtr)offset, (IntPtr)len, (IntPtr)ptr);
            }
        }
        unsafe public static void NamedBufferSubData(uint buffer, long offset, float[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count) * sizeof(float);

            fixed (float* ptr = &data[index])
            {
                NamedBufferSubData(buffer, (IntPtr)offset, (IntPtr)len, (IntPtr)ptr);
            }
        }
        unsafe public static void NamedBufferSubData<TValueType>(uint buffer, long offset, TValueType[] data, int index = 0, int count = -1) where TValueType : struct
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count) * Marshal.SizeOf(typeof(TValueType));

            var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

            var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(data, index);

            NamedBufferSubData(buffer, (IntPtr)offset, (IntPtr)len, ptr);

            handle.Free();
        }


        [EntryPoint(FunctionName = "glCopyNamedBufferSubData")]
        public static void CopyNamedBufferSubData(uint readBuffer, uint writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCopyNamedBufferSubData")]
        public static void CopyNamedBufferSubData(uint readBuffer, uint writeBuffer, long readOffset, long writeOffset, long size) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glClearNamedBufferData")]
        public static void ClearNamedBufferData(uint buffer, ClearBufferDataFormat internalformat, PixelFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glClearNamedBufferSubData")]
        public static void ClearNamedBufferSubData(uint buffer, ClearBufferDataFormat internalformat, IntPtr offset, IntPtr size, PixelFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }
        
        public static void ClearNamedBufferSubData(uint buffer, ClearBufferDataFormat internalformat, long offset, long size, PixelFormat format, PixelType type, IntPtr data)
        {
            ClearNamedBufferSubData(buffer, internalformat, (IntPtr)offset, (IntPtr)size, format, type, data);
        }

        [EntryPoint(FunctionName = "glMapNamedBuffer")]
        public static IntPtr MapNamedBuffer(uint buffer, MapBufferAccess access){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glMapNamedBufferRange")]
        public static IntPtr MapNamedBufferRange(uint buffer, IntPtr offset, IntPtr length, MapBufferRangeAccessFlags access){ throw new NotImplementedException(); }
        
        public static IntPtr MapNamedBufferRange(uint buffer, long offset, long length, MapBufferRangeAccessFlags access)
        {
            return MapNamedBufferRange(buffer, (IntPtr)offset, (IntPtr)length, access);
        }

        [EntryPoint(FunctionName = "glUnmapNamedBuffer")]
        public static bool UnmapNamedBuffer(uint buffer){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glFlushMappedNamedBufferRange")]
        public static void FlushMappedNamedBufferRange(uint buffer, IntPtr offset, IntPtr length){ throw new NotImplementedException(); }
        
        public static void FlushMappedNamedBufferRange(uint buffer, long offset, long length)
        {
            FlushMappedNamedBufferRange(buffer, (IntPtr)offset, (IntPtr)length);
        }

        [EntryPoint(FunctionName = "glGetNamedBufferParameteriv")]
        unsafe public static void GetNamedBufferParameteriv(uint buffer, BufferParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedBufferParameteriv")]
        public static void GetNamedBufferParameteriv(uint buffer, BufferParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedBufferParameteriv")]
        public static void GetNamedBufferParameteriv(uint buffer, BufferParameters pname, ref int result) { throw new NotImplementedException(); }
        
        public static int[] GetNamedBufferParameteriv(uint buffer, BufferParameters pname, int ResultArraySize = 1)
        {
            var result = new int[ResultArraySize];
            if(ResultArraySize > 0)
            GetNamedBufferParameteriv(buffer, pname, result);
            return result;
        }
        public static int GetNamedBufferParameteriv(uint buffer, BufferParameters pname)
        {
            var result = 0;            
            GetNamedBufferParameteriv(buffer, pname, ref result);
            return result;
        }

        //public static TEnum GetNamedBufferParameteriv<TEnum>(uint buffer, BufferParameters pname) where TEnum : struct, IConvertible
        //{
        //    int result = 0;
        //    GetNamedBufferParameteriv(buffer, pname, ref result);
        //    return (TEnum)(object)result;
        //}


        [EntryPoint(FunctionName = "glGetNamedBufferParameteri64v")]
        unsafe public static void GetNamedBufferParameteri64v(uint buffer, BufferParameters pname, long* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedBufferParameteri64v")]
        public static void GetNamedBufferParameteri64v(uint buffer, BufferParameters pname, long[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedBufferParameteri64v")]
        public static void GetNamedBufferParameteri64v(uint buffer, BufferParameters pname, ref long result) { throw new NotImplementedException(); }
        
        public static long[] GetNamedBufferParameteri64v(uint buffer, BufferParameters pname, int ResultArraySize = 1)
        {
            var result = new long[ResultArraySize];
            if(ResultArraySize > 0)
                GetNamedBufferParameteri64v(buffer, pname, result);
            return result;
        }
        public static long GetNamedBufferParameteri64v(uint buffer, BufferParameters pname)
        {
            long result = 0;            
            GetNamedBufferParameteri64v(buffer, pname, ref result);
            return result;
        }

        [EntryPoint(FunctionName = "glGetNamedBufferPointerv")]
        unsafe public static void GetNamedBufferPointerv(uint buffer, BufferPointerParameters pname, IntPtr* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedBufferPointerv")]
        public static void GetNamedBufferPointerv(uint buffer, BufferPointerParameters pname, out IntPtr result) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetNamedBufferSubData")]
        public static void GetNamedBufferSubData(uint buffer, IntPtr offset, IntPtr size, IntPtr data){ throw new NotImplementedException(); }
        
        public static void GetNamedBufferSubData(uint buffer, long offset, long size, IntPtr data)
        {
            GetNamedBufferSubData(buffer, (IntPtr)offset, (IntPtr)size, data);
        }

        unsafe public static void GetNamedBufferSubData(uint buffer, long offset, byte[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count);

            fixed(byte* ptr = &data[index])
            {
                GetNamedBufferSubData(buffer, (IntPtr)offset, (IntPtr)len, (IntPtr)ptr);
            }
        }
        public static void GetNamedBufferSubData<TValueType>(uint buffer, long offset, TValueType[] data, int index = 0, int count = -1) where TValueType : struct
        {
            if (count == -1)
                count = data.Length;

            var len = Math.Min(data.Length - index, index + count) * Marshal.SizeOf(typeof(TValueType));

            var handle = GCHandle.Alloc(data, GCHandleType.Pinned);
            {
                var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(data, index);
                GetNamedBufferSubData(buffer, (IntPtr)offset, (IntPtr)len, (IntPtr)ptr);
                
            }
            handle.Free();
        }

        /* Framebuffer object functions */

        [EntryPoint(FunctionName = "glCreateFramebuffers")]
        unsafe public static void CreateFramebuffers(int n, uint* framebuffers){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateFramebuffers")]
        public static void CreateFramebuffers(int n, uint[] framebuffers) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateFramebuffers")]
        public static void CreateFramebuffers(int n, ref uint framebuffers) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateFramebuffers")]
        public static uint CreateFramebuffers() { throw new NotImplementedException(); }

        public static void CreateFramebuffers(uint[] framebuffers)
        {
            CreateFramebuffers(framebuffers.Length, framebuffers);
        }
        
        public static uint[] CreateFramebuffers(int count)
        {
            var result = new uint[count];
            CreateFramebuffers(result.Length, ref result[0]);
            return result;
        }

        //public static uint CreateFramebuffers()
        //{
        //    int fb = 0;
        //    CreateFramebuffers(1, ref fb);
        //    return fb;
        //}

        [EntryPoint(FunctionName = "glNamedFramebufferRenderbuffer")]
        public static void NamedFramebufferRenderbuffer(uint framebuffer, FramebufferAttachmentType attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glNamedFramebufferRenderbuffer")]
        public static void NamedFramebufferRenderbuffer(uint framebuffer, FramebufferAttachmentType attachment, uint renderbuffer, RenderbufferTarget renderbuffertarget = RenderbufferTarget.Renderbuffer) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glNamedFramebufferParameteri")]
        public static void NamedFramebufferParameteri(uint framebuffer, FramebufferParameters pname, int param){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glNamedFramebufferTexture")]
        public static void NamedFramebufferTexture(uint framebuffer, FramebufferAttachmentType attachment, uint texture, int level){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glNamedFramebufferTextureLayer")]
        public static void NamedFramebufferTextureLayer(uint framebuffer, FramebufferAttachmentType attachment, uint texture, int level = 0, int layer = 0){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glNamedFramebufferDrawBuffer")]
        public static void NamedFramebufferDrawBuffer(uint framebuffer, FramebufferTarget mode){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glNamedFramebufferDrawBuffers")]
        unsafe public static void NamedFramebufferDrawBuffers(uint framebuffer, int n, DrawBufferTarget* bufs){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glNamedFramebufferDrawBuffers")]
        public static void NamedFramebufferDrawBuffers(uint framebuffer, int n, ref DrawBufferTarget bufs) { throw new NotImplementedException(); }

        public static void NamedFramebufferDrawBuffers(uint framebuffer, DrawBufferTarget[] bufs, int index = 0, int count = -1)
        {
            if (count == -1)
                count = bufs.Length;

            var len = Math.Min(bufs.Length - index, index + count);

            NamedFramebufferDrawBuffers(framebuffer, len, ref bufs[index]);
        }

        [EntryPoint(FunctionName = "glNamedFramebufferReadBuffer")]
        public static void NamedFramebufferReadBuffer(uint framebuffer, FramebufferTarget mode){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glInvalidateNamedFramebufferData")]
        unsafe public static void InvalidateNamedFramebufferData(uint framebuffer, int numAttachments, FramebufferAttachmentType* attachments){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glInvalidateNamedFramebufferData")]
        public static void InvalidateNamedFramebufferData(uint framebuffer, int numAttachments, ref FramebufferAttachmentType attachments) { throw new NotImplementedException(); }
        public static void InvalidateNamedFramebufferData(uint framebuffer, FramebufferAttachmentType[] attachments, int index = 0, int numAttachments = -1)
        {
            if (numAttachments == -1)
                numAttachments = attachments.Length;

            var len = Math.Min(attachments.Length - index, index + numAttachments);

            InvalidateNamedFramebufferData(framebuffer, len, ref attachments[0]);
        }

        [EntryPoint(FunctionName = "glInvalidateNamedFramebufferSubData")]
        unsafe public static void InvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, FramebufferAttachmentType* attachments, int x, int y, int width, int height){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glInvalidateNamedFramebufferSubData")]
        public static void InvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, ref FramebufferAttachmentType attachments, int x, int y, int width, int height) { throw new NotImplementedException(); }

        public static void InvalidateNamedFramebufferSubData(uint framebuffer, int x, int y, int width, int height, FramebufferAttachmentType[] attachments, int index = 0, int numAttachments = -1)
        {
            if (numAttachments == -1)
                numAttachments = attachments.Length;

            var len = Math.Min(attachments.Length - index, index + numAttachments);

            InvalidateNamedFramebufferSubData(framebuffer, len, ref attachments[0], x, y, width, height);

        }

        [EntryPoint(FunctionName = "glClearNamedFramebufferiv")]
        unsafe public static void ClearNamedFramebufferiv(uint framebuffer, ClearBuffer buffer, DrawBufferTarget drawbuffer, int* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glClearNamedFramebufferiv")]
        public static void ClearNamedFramebufferiv(uint framebuffer, ClearBuffer buffer, DrawBufferTarget drawbuffer, ref int value) { throw new NotImplementedException(); }
        /// <summary>
        /// Clears the stencil buffer to a signed value.
        /// </summary>
        /// <param name="framebuffer"></param>
        /// <param name="value"></param>
        /// <param name="buffer"></param>
        /// <param name="drawbuffer"></param>
        public static void ClearNamedFramebufferiv(uint framebuffer, ref int value, ClearBuffer buffer = ClearBuffer.Stencil, DrawBufferTarget drawbuffer = DrawBufferTarget.None)
        {
            ClearNamedFramebufferiv(framebuffer, buffer, drawbuffer, ref value);
        }

        [EntryPoint(FunctionName = "glClearNamedFramebufferuiv")]
        unsafe public static void ClearNamedFramebufferuiv(uint framebuffer, ClearBuffer buffer, DrawBufferTarget drawbuffer, uint* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glClearNamedFramebufferuiv")]
        public static void ClearNamedFramebufferuiv(uint framebuffer, ClearBuffer buffer, DrawBufferTarget drawbuffer, ref uint value) { throw new NotImplementedException(); }
        /// <summary>
        /// Clears the stencil buffer to an unsigned value.
        /// </summary>
        /// <param name="framebuffer"></param>
        /// <param name="value"></param>
        /// <param name="buffer"></param>
        /// <param name="drawbuffer"></param>
        public static void ClearNamedFramebufferuiv(uint framebuffer, ref uint value, ClearBuffer buffer = ClearBuffer.Stencil, DrawBufferTarget drawbuffer = DrawBufferTarget.None)
        {
            ClearNamedFramebufferuiv(framebuffer, buffer, drawbuffer, ref value);
        }

        [EntryPoint(FunctionName = "glClearNamedFramebufferfv")]
        unsafe public static void ClearNamedFramebufferfv(uint framebuffer, ClearBuffer buffer, DrawBufferTarget drawbuffer, float* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glClearNamedFramebufferfv")]
        public static void ClearNamedFramebufferfv(uint framebuffer, ClearBuffer buffer, DrawBufferTarget drawbuffer, ref float value) { throw new NotImplementedException(); }

        /// <summary>
        /// Clears the depth buffer.
        /// </summary>
        /// <param name="framebuffer"></param>
        /// <param name="value"></param>
        /// <param name="buffer"></param>
        /// <param name="drawbuffer"></param>
        public static void ClearNamedFramebufferfv(uint framebuffer, ref float value, ClearBuffer buffer = ClearBuffer.Depth, DrawBufferTarget drawbuffer = DrawBufferTarget.None)
        {
            ClearNamedFramebufferfv(framebuffer, buffer, drawbuffer, ref value);
        }

        [EntryPoint(FunctionName = "glClearNamedFramebufferfi")]
        public static void ClearNamedFramebufferfi(uint framebuffer, ClearBuffer buffer, DrawBufferTarget drawbuffer, float depth, int stencil){ throw new NotImplementedException(); }
        
        public static void ClearNamedFramebufferfi(uint framebuffer, float depth, int stencil, ClearBuffer buffer = ClearBuffer.DepthStencil, DrawBufferTarget drawbuffer = DrawBufferTarget.None)
        {
            ClearNamedFramebufferfi(framebuffer, buffer, drawbuffer, depth, stencil);
        }

        [EntryPoint(FunctionName = "glBlitNamedFramebuffer")]
        public static void BlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferFlags mask, BlitFramebufferFilter filter){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glCheckNamedFramebufferStatus")]
        public static FramebufferStatus CheckNamedFramebufferStatus(uint framebuffer, FramebufferTarget target){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetNamedFramebufferParameteriv")]
        unsafe public static void GetNamedFramebufferParameteriv(uint framebuffer, FramebufferParameters pname, int* param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedFramebufferParameteriv")]
        public static void GetNamedFramebufferParameteriv(uint framebuffer, FramebufferParameters pname, int[] param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedFramebufferParameteriv")]
        public static void GetNamedFramebufferParameteriv(uint framebuffer, FramebufferParameters pname, ref int param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedFramebufferParameteriv")]
        public static int GetNamedFramebufferParameteriv(uint framebuffer, FramebufferParameters pname) { throw new NotImplementedException(); }
        public static int[] GetNamedFramebufferParameteriv(uint framebuffer, FramebufferParameters pname, int ResultArraySize = 1)
        {
            var result = new int[ResultArraySize];
            GetNamedFramebufferParameteriv(framebuffer, pname, ref result[0]);
            return result;
        }

        [EntryPoint(FunctionName = "glGetNamedFramebufferAttachmentParameteriv")]
        unsafe public static void GetNamedFramebufferAttachmentParameteriv(uint framebuffer, FramebufferAttachmentType attachment, AttachmentParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedFramebufferAttachmentParameteriv")]
        public static void GetNamedFramebufferAttachmentParameteriv(uint framebuffer, FramebufferAttachmentType attachment, AttachmentParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedFramebufferAttachmentParameteriv")]
        public static void GetNamedFramebufferAttachmentParameteriv(uint framebuffer, FramebufferAttachmentType attachment, AttachmentParameters pname, ref int result) { throw new NotImplementedException(); }
        
        public static int[] GetNamedFramebufferAttachmentParameteriv(uint framebuffer, FramebufferAttachmentType attachment, AttachmentParameters pname, int ResultArraySize = 1)
        {
            var result = new int[ResultArraySize];
            GetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, ref result[0]);
            return result;
        }
        
        public static int GetNamedFramebufferAttachmentParameteriv(uint framebuffer, FramebufferAttachmentType attachment, AttachmentParameters pname)
        {
            int result = 0;
            GetNamedFramebufferAttachmentParameteriv(framebuffer, attachment, pname, ref result);
            return result;
        }


        /* Renderbuffer object functions */

        [EntryPoint(FunctionName = "glCreateRenderbuffers")]
        unsafe public static void CreateRenderbuffers(int n, uint* renderbuffers){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateRenderbuffers")]
        public static void CreateRenderbuffers(int n, uint[] renderbuffers) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateRenderbuffers")]
        public static void CreateRenderbuffers(int n, ref uint renderbuffers) { throw new NotImplementedException(); }
        
        public static void CreateRenderbuffers(uint[] renderbuffers)
        {
            CreateRenderbuffers(renderbuffers.Length, ref renderbuffers[0]);
        }
        
        public static uint[] CreateRenderbuffers(int number)
        {
            var result = new uint[number];
            CreateRenderbuffers(result.Length, ref result[0]);
            return result;
        }
        [EntryPoint(FunctionName = "glCreateRenderbuffers")]
        public static uint CreateRenderbuffers() { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glNamedRenderbufferStorage")]
        public static void NamedRenderbufferStorage(uint renderbuffer, RenderbufferStorageFormat internalformat, int width, int height){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glNamedRenderbufferStorageMultisample")]
        public static void NamedRenderbufferStorageMultisample(uint renderbuffer, int samples, RenderbufferStorageFormat internalformat, int width, int height){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetNamedRenderbufferParameteriv")]
        unsafe public static void GetNamedRenderbufferParameteriv(uint renderbuffer, RenderbufferParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedRenderbufferParameteriv")]
        unsafe public static void GetNamedRenderbufferParameteriv(uint renderbuffer, RenderbufferParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedRenderbufferParameteriv")]
        unsafe public static void GetNamedRenderbufferParameteriv(uint renderbuffer, RenderbufferParameters pname, ref int result) { throw new NotImplementedException(); }
        
        unsafe public static int[] GetNamedRenderbufferParameteriv(uint renderbuffer, RenderbufferParameters pname, int ResultArraySize = 1)
        {
            var result = new int[ResultArraySize];
            GetNamedRenderbufferParameteriv(renderbuffer, pname, ref result[0]);
            return result;
        }
        [EntryPoint(FunctionName = "glGetNamedRenderbufferParameteriv")]
        unsafe public static int GetNamedRenderbufferParameteriv(uint renderbuffer, RenderbufferParameters pname) { throw new NotImplementedException(); }


        /* Texture object functions */

        [EntryPoint(FunctionName = "glCreateTextures")]
        unsafe public static void CreateTextures(TextureTarget target, int n, uint* textures){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateTextures")]
        public static void CreateTextures(TextureTarget target, int n, uint[] textures) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateTextures")]
        public static void CreateTextures(TextureTarget target, int n, ref uint textures) { throw new NotImplementedException(); }
        
        public static uint CreateTextures(TextureTarget target)
        {
            uint result = 0;
            CreateTextures(target, 1, ref result);
            return result;
        }
        
        public static uint[] CreateTextures(TextureTarget target, int count)
        {
            var result = new uint[count];
            CreateTextures(target, result.Length, ref result[0]);
            return result;
        }

        [EntryPoint(FunctionName = "glTextureBuffer")]
        public static void TextureBuffer(uint texture, TextureBufferInternalFormat internalformat, uint buffer){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureBufferRange")]
        public static void TextureBufferRange(uint texture, TextureBufferInternalFormat internalformat, uint buffer, IntPtr offset, IntPtr size){ throw new NotImplementedException(); }
        
        public static void TextureBufferRange(uint texture, TextureBufferInternalFormat internalformat, uint buffer, long offset, long size)
        {
            TextureBufferRange(texture, internalformat, buffer, (long)offset, (long)size);
        }
        
        [EntryPoint(FunctionName = "glTextureStorage1D")]
        public static void TextureStorage1D(uint texture, int levels, PixelInternalFormat internalformat, int width){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureStorage2D")]
        public static void TextureStorage2D(uint texture, int levels, PixelInternalFormat internalformat, int width, int height){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureStorage3D")]
        public static void TextureStorage3D(uint texture, int levels, PixelInternalFormat internalformat, int width, int height, int depth){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureStorage2DMultisample")]
        public static void TextureStorage2DMultisample(uint texture, int samples, PixelInternalFormat internalformat, int width, int height, bool fixedsamplelocations){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureStorage3DMultisample")]
        public static void TextureStorage3DMultisample(uint texture, int samples, PixelInternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureSubImage1D")]
        public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels){ throw new NotImplementedException(); }
        
        unsafe public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, PixelFormat format, PixelType type, byte[] pixels, int index = 0)
        {
            fixed (byte* ptr = &pixels[index])
            {
                TextureSubImage1D(texture, level, xoffset, width, format, type, (IntPtr)ptr);
            }
        }
        public static void TextureSubImage1D<TPixelType>(uint texture, int level, int xoffset, int width, PixelFormat format, PixelType type, TPixelType[] pixels, int index = 0) where TPixelType : struct
        {
            var handle = GCHandle.Alloc(pixels, GCHandleType.Pinned);

            var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(pixels, index);
            TextureSubImage1D(texture, level, xoffset, width, format, type, ptr);

            handle.Free();
        }

        [EntryPoint(FunctionName = "glTextureSubImage2D")]
        public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels){ throw new NotImplementedException(); }
        unsafe public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, byte[] pixels, int index = 0)
        {
            fixed (byte* ptr = &pixels[index])
            {
                TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, (IntPtr)ptr);
            }
        }
        public static void TextureSubImage2D<TPixelType>(uint texture, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, TPixelType[] pixels, int index = 0) where TPixelType : struct
        {
            var handle = GCHandle.Alloc(pixels, GCHandleType.Pinned);

            var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(pixels, index);
            TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, ptr);

            handle.Free();
        }

        [EntryPoint(FunctionName = "glTextureSubImage3D")]
        public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels){ throw new NotImplementedException(); }
        unsafe public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, byte[] pixels, int index = 0)
        {
            fixed (byte* ptr = &pixels[index])
            {
                TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (IntPtr)ptr);
            }
        }
        public static void TextureSubImage3D<TPixelType>(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, TPixelType[] pixels, int index = 0) where TPixelType : struct
        {
            var handle = GCHandle.Alloc(pixels, GCHandleType.Pinned);

            var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(pixels, index);
            TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, ptr);

            handle.Free();
        }

        [EntryPoint(FunctionName = "glCompressedTextureSubImage1D")]
        public static void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, CompressedInternalFormat format, int imageSize, IntPtr data){ throw new NotImplementedException(); }
        unsafe public static void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, CompressedInternalFormat format, byte[] data, int index = 0, int imageSize = -1)
        {
            if (imageSize == -1)
                imageSize = data.Length;

            var len = Math.Min(data.Length - index, index + imageSize);

            fixed(byte* ptr = &data[index])
            {
                CompressedTextureSubImage1D(texture, level, xoffset, width, format, len, (IntPtr)ptr);
            }
        }        
        
        [EntryPoint(FunctionName = "glCompressedTextureSubImage2D")]
        public static void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, CompressedInternalFormat format, int imageSize, IntPtr data){ throw new NotImplementedException(); }
        unsafe public static void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, CompressedInternalFormat format, byte[] data, int index = 0, int imageSize = -1)
        {
            if (imageSize == -1)
                imageSize = data.Length;

            var len = Math.Min(data.Length - index, index + imageSize);

            fixed (byte* ptr = &data[index])
            {
                CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, len, (IntPtr)ptr);
            }
        }

        [EntryPoint(FunctionName = "glCompressedTextureSubImage3D")]
        public static void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, CompressedInternalFormat format, int imageSize, IntPtr data){ throw new NotImplementedException(); }
        unsafe public static void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, CompressedInternalFormat format, byte[] data, int index = 0, int imageSize = -1)
        {
            if (imageSize == -1)
                imageSize = data.Length;

            var len = Math.Min(data.Length - index, index + imageSize);

            fixed (byte* ptr = &data[index])
            {
                CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, len, (IntPtr)ptr);
            }
        }

        [EntryPoint(FunctionName = "glCopyTextureSubImage1D")]
        public static void CopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glCopyTextureSubImage2D")]
        public static void CopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glCopyTextureSubImage3D")]
        public static void CopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureParameterf")]
        public static void TextureParameterf(uint texture, TextureParameters pname, float param){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureParameterfv")]
        unsafe public static void TextureParameterfv(uint texture, TextureParameters pname, float* param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterfv")]
        public static void TextureParameterfv(uint texture, TextureParameters pname, float[] param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterfv")]
        public static void TextureParameterfv(uint texture, TextureParameters pname, ref float param) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glTextureParameteri")]
        public static void TextureParameteri(uint texture, TextureParameters pname, int param){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureParameterIiv")]
        unsafe public static void TextureParameterIiv(uint texture, TextureParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterIiv")]
        public static void TextureParameterIiv(uint texture, TextureParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterIiv")]
        public static void TextureParameterIiv(uint texture, TextureParameters pname, ref int result) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glTextureParameterIuiv")]
        unsafe public static void TextureParameterIuiv(uint texture, TextureParameters pname, uint* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterIuiv")]
        public static void TextureParameterIuiv(uint texture, TextureParameters pname, uint[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterIuiv")]
        public static void TextureParameterIuiv(uint texture, TextureParameters pname, ref uint result) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glTextureParameteriv")]
        unsafe public static void TextureParameteriv(uint texture, TextureParameters pname, int* param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameteriv")]
        public static void TextureParameteriv(uint texture, TextureParameters pname, int[] param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameteriv")]
        public static void TextureParameteriv(uint texture, TextureParameters pname, ref int param) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGenerateTextureMipmap")]
        public static void GenerateTextureMipmap(uint texture){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glBindTextureUnit")]
        public static void BindTextureUnit(TextureUnit unit, uint texture){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetTextureImage")]
        public static void GetTextureImage(uint texture, int level, PixelFormat format, PixelType type, int bufSize, IntPtr pixels){ throw new NotImplementedException(); }
        
        unsafe public static void GetTextureImage(uint texture, int level, PixelFormat format, PixelType type, byte[] pixels, int index = 0, int count = -1)
        {
            if (count == -1)
                count = pixels.Length;

            var len = Math.Min(pixels.Length - index, index + count);

            fixed(byte* ptr = &pixels[index])
            {
                GetTextureImage(texture, level, format, type, len, (IntPtr)ptr);
            }
        }
        public static void GetTextureImage<TPixelType>(uint texture, int level, PixelFormat format, PixelType type, TPixelType[] pixels, int index = 0, int count = -1) where TPixelType : struct
        {
            if (count == -1)
                count = pixels.Length;

            var len = Math.Min(pixels.Length - index, index + count) * Marshal.SizeOf(typeof(TPixelType));

            var handle = GCHandle.Alloc(pixels, GCHandleType.Pinned);

            var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(pixels, index);

            GetTextureImage(texture, level, format, type, len, ptr);

            handle.Free();            
        }
        [EntryPoint(FunctionName = "glGetCompressedTextureImage")]
        public static void GetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels){ throw new NotImplementedException(); }
        
        unsafe public static void GetCompressedTextureImage(uint texture, int level, byte[] data, int index = 0, int bufSize = -1)
        {
            if (bufSize == -1)
                bufSize = data.Length;

            var len = Math.Min(data.Length - index, index + bufSize);

            fixed(byte* ptr = &data[index])
            {
                GetCompressedTextureImage(texture, level, len, (IntPtr)ptr);
            }
        }

        [EntryPoint(FunctionName = "glGetTextureLevelParameterfv")]
        unsafe public static void GetTextureLevelParameterfv(uint texture, int level, TextureLevelParameters pname, float* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureLevelParameterfv")]
        public static void GetTextureLevelParameterfv(uint texture, int level, TextureLevelParameters pname, float[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureLevelParameterfv")]
        public static void GetTextureLevelParameterfv(uint texture, int level, TextureLevelParameters pname, ref float result) { throw new NotImplementedException(); }
        
        public static float GetTextureLevelParameterfv(uint texture, int level, TextureLevelParameters pname)
        {
            float f = 0.0f;
            GetTextureLevelParameterfv(texture, level, pname, ref f);
            return f;
        }

        [EntryPoint(FunctionName = "glGetTextureLevelParameteriv")]
        unsafe public static void GetTextureLevelParameteriv(uint texture, int level, TextureLevelParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureLevelParameteriv")]
        public static void GetTextureLevelParameteriv(uint texture, int level, TextureLevelParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureLevelParameteriv")]
        public static void GetTextureLevelParameteriv(uint texture, int level, TextureLevelParameters pname, ref int result) { throw new NotImplementedException(); }
        
        public static int GetTextureLevelParameteriv(uint texture, int level, TextureLevelParameters pname)
        {
            int i = 0;
            GetTextureLevelParameteriv(texture, level, pname, ref i);
            return i;
        }

        [EntryPoint(FunctionName = "glGetTextureParameterfv")]
        unsafe public static void GetTextureParameterfv(uint texture, TextureParameters pname, float* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterfv")]
        public static void GetTextureParameterfv(uint texture, TextureParameters pname, float[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterfv")]
        public static void GetTextureParameterfv(uint texture, TextureParameters pname, ref float result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterfv")]
        public static float GetTextureParameterfv(uint texture, TextureParameters pname) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetTextureParameterIiv")]
        unsafe public static void GetTextureParameterIiv(uint texture, TextureParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterIiv")]
        public static void GetTextureParameterIiv(uint texture, TextureParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterIiv")]
        public static void GetTextureParameterIiv(uint texture, TextureParameters pname, ref int result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterIiv")]
        public static int GetTextureParameterIiv(uint texture, TextureParameters pname) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetTextureParameterIuiv")]
        unsafe public static void GetTextureParameterIuiv(uint texture, TextureParameters pname, uint* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterIuiv")]
        public static void GetTextureParameterIuiv(uint texture, TextureParameters pname, uint[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterIuiv")]
        public static void GetTextureParameterIuiv(uint texture, TextureParameters pname, ref uint result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterIuiv")]
        public static uint GetTextureParameterIuiv(uint texture, TextureParameters pname) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetTextureParameteriv")]
        unsafe public static void GetTextureParameteriv(uint texture, TextureParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameteriv")]
        public static void GetTextureParameteriv(uint texture, TextureParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameteriv")]
        public static void GetTextureParameteriv(uint texture, TextureParameters pname, ref int result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameteriv")]
        public static int GetTextureParameteriv(uint texture, TextureParameters pname) { throw new NotImplementedException(); }


        /* Vertex Array object functions */

        [EntryPoint(FunctionName = "glCreateVertexArrays")]
        unsafe public static void CreateVertexArrays(int n, uint* arrays){ throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glCreateVertexArrays")]
        //public static void CreateVertexArrays(int n, uint[] arrays) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateVertexArrays")]
        public static void CreateVertexArrays(int n, ref uint arrays) { throw new NotImplementedException(); }
        
        public static uint[] CreateVertexArrays(int number)
        {
            var result = new uint[number];
            CreateVertexArrays(result.Length, ref result[0]);
            return result;
        }
        [EntryPoint(FunctionName = "glCreateVertexArrays")]
        public static uint CreateVertexArrays() { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glDisableVertexArrayAttrib")]
        public static void DisableVertexArrayAttrib(uint vaobj, uint index){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glEnableVertexArrayAttrib")]
        public static void EnableVertexArrayAttrib(uint vaobj, uint index){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glVertexArrayElementBuffer")]
        public static void VertexArrayElementBuffer(uint vaobj, uint buffer){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glVertexArrayVertexBuffer")]
        public static void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, IntPtr offset, int stride){ throw new NotImplementedException(); }
        
        public static void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, long offset, int stride)
        {
            VertexArrayVertexBuffer(vaobj, bindingindex, buffer, (IntPtr)offset, stride);
        }

        [EntryPoint(FunctionName = "glVertexArrayVertexBuffers")]
        unsafe public static void VertexArrayVertexBuffers(uint vaobj, uint first, int count, uint* buffers, IntPtr* offsets, int* strides){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glVertexArrayVertexBuffers")]
        public static void VertexArrayVertexBuffers(uint vaobj, uint first, int count, uint[] buffers, IntPtr[] offsets, int[] strides) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glVertexArrayVertexBuffers")]
        public static void VertexArrayVertexBuffers(uint vaobj, uint first, int count, ref uint buffers, ref IntPtr offsets, ref int strides) { throw new NotImplementedException(); }

        public static void VertexArrayVertexBuffers(uint vaobj, uint first, uint[] buffers, IntPtr[] offsets, int[] strides)
        {
            var count = Math.Min(buffers.Length, Math.Min(offsets.Length, strides.Length));

            VertexArrayVertexBuffers(vaobj, first, count, buffers, offsets, strides);
        }

        [EntryPoint(FunctionName = "glVertexArrayAttribFormat")]
        public static void VertexArrayAttribFormat(uint vaobj, uint attribindex, int size, VertexAttribFormat type, bool normalized, uint relativeoffset){ throw new NotImplementedException(); }
        
        public static void VertexArrayAttribFormat(uint vaobj, uint attribindex, int size, VertexAttribFormat type, uint relativeoffset, bool normalized = false)
        {
            VertexArrayAttribFormat(vaobj, attribindex, size, type, normalized, relativeoffset);
        }

        [EntryPoint(FunctionName = "glVertexArrayAttribIFormat")]
        public static void VertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, VertexAttribIFormat type, uint relativeoffset){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glVertexArrayAttribLFormat")]
        public static void VertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, VertexAttribLFormat type, uint relativeoffset){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glVertexArrayAttribBinding")]
        public static void VertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glVertexArrayBindingDivisor")]
        public static void VertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetVertexArrayiv")]
        unsafe public static void GetVertexArrayiv(uint vaobj, VertexArrayParameters pname, int* param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexArrayiv")]
        public static void GetVertexArrayiv(uint vaobj, VertexArrayParameters pname, int[] param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexArrayiv")]
        public static void GetVertexArrayiv(uint vaobj, VertexArrayParameters pname, ref int param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexArrayiv")]
        public static int GetVertexArrayiv(uint vaobj, VertexArrayParameters pname) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetVertexArrayIndexediv")]
        unsafe public static void GetVertexArrayIndexediv(uint vaobj, uint index, VertexAttribParameters pname, int* param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexArrayIndexediv")]
        public static void GetVertexArrayIndexediv(uint vaobj, uint index, VertexAttribParameters pname, int[] param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexArrayIndexediv")]
        public static void GetVertexArrayIndexediv(uint vaobj, uint index, VertexAttribParameters pname, ref int param) { throw new NotImplementedException(); }
        
        public static int GetVertexArrayIndexediv(uint vaobj, uint index, VertexAttribParameters pname)
        {
            int result = 0;
            GetVertexArrayIndexediv(vaobj, index, pname, ref result);
            return result;
        }

        [EntryPoint(FunctionName = "glGetVertexArrayIndexed64iv")]
        unsafe public static void GetVertexArrayIndexed64iv(uint vaobj, uint index, VertexAttribParameters pname, long* param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexArrayIndexed64iv")]
        public static void GetVertexArrayIndexed64iv(uint vaobj, uint index, VertexAttribParameters pname, long[] param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexArrayIndexed64iv")]
        public static void GetVertexArrayIndexed64iv(uint vaobj, uint index, VertexAttribParameters pname, ref long param) { throw new NotImplementedException(); }
        
        public static long GetVertexArrayIndexed64iv(uint vaobj, uint index, VertexAttribParameters pname)
        {
            long result = 0;
            GetVertexArrayIndexed64iv(vaobj, index, pname, ref result);
            return result;
        }

        /* Sampler object functions */

        [EntryPoint(FunctionName = "glCreateSamplers")]
        unsafe public static void CreateSamplers(int n, uint* samplers){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateSamplers")]
        public static void CreateSamplers(int n, uint[] samplers) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateSamplers")]
        public static void CreateSamplers(int n, ref uint samplers) { throw new NotImplementedException(); }
        
        public static uint[] CreateSamplers(int number)
        {
            var result = new uint[number];
            CreateSamplers(result.Length, ref result[0]);
            return result;
        }
        [EntryPoint(FunctionName = "glCreateSamplers")]
        public static uint CreateSamplers() { throw new NotImplementedException(); }


        /* Program Pipeline object functions */

        [EntryPoint(FunctionName = "glCreateProgramPipelines")]
        unsafe public static void CreateProgramPipelines(int n, uint* pipelines){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateProgramPipelines")]
        public static void CreateProgramPipelines(int n, uint[] pipelines) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateProgramPipelines")]
        public static void CreateProgramPipelines(int n, ref uint pipelines) { throw new NotImplementedException(); }
        
        public static uint[] CreateProgramPipelines(int number)
        {
            var result = new uint[number];
            CreateProgramPipelines(result.Length, ref result[0]);
            return result;
        }
        [EntryPoint(FunctionName = "glCreateProgramPipelines")]
        public static uint CreateProgramPipelines() { throw new NotImplementedException(); }


        /* Query object functions */
        [EntryPoint(FunctionName = "glCreateQueries")]
        unsafe public static void CreateQueries(QueryTarget target, int n, uint* ids){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateQueries")]
        public static void CreateQueries(QueryTarget target, int n, uint[] ids) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glCreateQueries")]
        public static void CreateQueries(QueryTarget target, int n, ref uint ids) { throw new NotImplementedException(); }
        
        public static uint[] CreateQueries(QueryTarget target, int number)
        {
            var result = new uint[number];
            CreateQueries(target, result.Length, ref result[0]);
            return result;
        }
        [EntryPoint(FunctionName = "glCreateQueries")]
        public static uint CreateQueries(QueryTarget target) { throw new NotImplementedException(); }


        #endregion

        #endregion

    }
}
