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
    
    partial class DSA
    {
        #region Delegate Class

        partial class Delegates
        {

            #region Delegates

            public delegate void delGetTextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref int data);
            public delegate void delGetTextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref uint data);

            public delegate void delTextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref int data);
            public delegate void delTextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref uint data);

            public delegate void delProgramUniform1uiEXT(uint ProgramID, int location, uint v1);
            public delegate void delProgramUniform2uiEXT(uint ProgramID, int location, uint v1, uint v2);
            public delegate void delProgramUniform3uiEXT(uint ProgramID, int location, uint v1, uint v2, uint v3);
            public delegate void delProgramUniform4uiEXT(uint ProgramID, int location, uint v1, uint v2, uint v3, uint v4);

            public delegate void delProgramUniform1uivEXT(uint ProgramID, int location, int count, ref uint v);
            public delegate void delProgramUniform2uivEXT(uint ProgramID, int location, int count, ref uint v);
            public delegate void delProgramUniform3uivEXT(uint ProgramID, int location, int count, ref uint v);
            public delegate void delProgramUniform4uivEXT(uint ProgramID, int location, int count, ref uint v);


            public delegate void delNamedRenderbufferStorageEXT(uint RenderbufferID, RenderbufferStorageFormat iformat, int width, int height);
            public delegate void delGetNamedRenderbufferParameterivEXT(uint RenderbufferID, RenderbufferParameters pname, ref int @params);

            public delegate void delNamedRenderbufferStorageMultisampleEXT(uint RenderbufferID, int samples, RenderbufferStorageFormat iformat, int width, int height);

            public delegate void delNamedRenderbufferStorageMultisampleCoverageEXT(uint RenderbufferID, int CoverageSamples, int ColorSamples, int iformat, int Width, int Height);

            public delegate FramebufferStatus delCheckNamedFramebufferStatusEXT(uint FramebufferID, FramebufferTarget fboTarget);

            public delegate void delNamedFramebufferTexture1DEXT(uint FramebufferID, FramebufferAttachmentType attachment, TextureTarget texTarget1D, uint TextureID, int Level);
            public delegate void delNamedFramebufferTexture2DEXT(uint FramebufferID, FramebufferAttachmentType attachment, TextureTarget texTarget2D, uint TextureID, int level);
            public delegate void delNamedFramebufferTexture3DEXT(uint FramebufferID, FramebufferAttachmentType attachment, TextureTarget texTarget3D, uint TextureID, int level, int layer);

            public delegate void delNamedFramebufferRenderbufferEXT(uint FramebufferID, FramebufferAttachmentType attachment, RenderbufferTarget rtarget, uint Renderbuffer);

            public delegate void delGetNamedFramebufferAttachmentParameterivEXT(uint FramebufferID, FramebufferAttachmentType attachment, AttachmentParameters pname, ref int @params);

            public delegate void delGenerateTextureMipmapEXT(uint TextureID, TextureTarget target);

            public delegate void delFramebufferDrawBufferEXT(uint FramebufferID, DrawBufferTarget mode);
            public delegate void delFramebufferDrawBuffersEXT(uint FramebufferID, int number, ref DrawBufferTarget bufs);
            public delegate void delFramebufferReadBufferEXT(uint FramebufferID, ReadBufferMode mode);

            public delegate void delGetFramebufferParameterivEXT(uint FramebufferID, FramebufferTarget pname, ref int @params);

            public delegate void delVertexArrayVertexAttribOffsetEXT(uint vaobj, uint BufferID, uint index, int Size, VertexAttribFormat type, bool normalized, int stride, IntPtr ptr);
            public delegate void delVertexArrayVertexAttribIOffsetEXT(uint vaobj, uint BufferID, uint index, int size, VertexAttribIFormat iType, int stride, IntPtr ptr);
            public delegate void delEnableVertexArrayAttribEXT(uint vaobj, uint index);
            public delegate void delDisableVertexArrayAttribEXT(uint vaobj, uint index);

            public delegate void delGetVertexArrayIntegervEXT(uint vaobj, VertexAttribParameters pname, ref int param);
            public delegate void delGetVertexArrayPointervEXT(uint vaobj, GetPointerName pname, ref IntPtr ptr);

            public delegate void delGetVertexArrayIntegeri_vEXT(uint vaobj, uint index, VertexAttribParameters pname, ref int @params);
            public delegate void delGetVertexArrayPointeri_vEXT(uint vaobj, uint index, GetPointerName pname, out IntPtr ptr);

            public delegate void delFlushMappedNamedBufferRangeEXT(uint BufferID, BufferTarget target, IntPtr Offset, IntPtr Length);
            public delegate IntPtr delMapNamedBufferRangeEXT(uint BufferID, BufferTarget target, IntPtr Offset, IntPtr Length, MapBufferRangeAccessFlags access);


            

            #endregion

            #region GL Fields

            public static delGetTextureParameterIivEXT glGetTextureParameterIivEXT;
            public static delGetTextureParameterIuivEXT glGetTextureParameterIuivEXT;

            public static delTextureParameterIivEXT glTextureParameterIivEXT;
            public static delTextureParameterIuivEXT glTextureParameterIuivEXT;

            public static delProgramUniform1uiEXT glProgramUniform1uiEXT;
            public static delProgramUniform2uiEXT glProgramUniform2uiEXT;
            public static delProgramUniform3uiEXT glProgramUniform3uiEXT;
            public static delProgramUniform4uiEXT glProgramUniform4uiEXT;

            public static delProgramUniform1uivEXT glProgramUniform1uivEXT;
            public static delProgramUniform2uivEXT glProgramUniform2uivEXT;
            public static delProgramUniform3uivEXT glProgramUniform3uivEXT;
            public static delProgramUniform4uivEXT glProgramUniform4uivEXT;

            public static delNamedRenderbufferStorageEXT glNamedRenderbufferStorageEXT;
            public static delGetNamedRenderbufferParameterivEXT glGetNamedRenderbufferParameterivEXT;

            public static delNamedRenderbufferStorageMultisampleEXT glNamedRenderbufferStorageMultisampleEXT;

            public static delNamedRenderbufferStorageMultisampleCoverageEXT glNamedRenderbufferStorageMultisampleCoverageEXT;

            public static delCheckNamedFramebufferStatusEXT glCheckNamedFramebufferStatusEXT;

            public static delNamedFramebufferTexture1DEXT glNamedFramebufferTexture1DEXT;
            public static delNamedFramebufferTexture2DEXT glNamedFramebufferTexture2DEXT;
            public static delNamedFramebufferTexture3DEXT glNamedFramebufferTexture3DEXT;

            public static delNamedFramebufferRenderbufferEXT glNamedFramebufferRenderbufferEXT;

            public static delGetNamedFramebufferAttachmentParameterivEXT glGetNamedFramebufferAttachmentParameterivEXT;

            public static delGenerateTextureMipmapEXT glGenerateTextureMipmapEXT;

            public static delFramebufferDrawBufferEXT glFramebufferDrawBufferEXT;
            public static delFramebufferDrawBuffersEXT glFramebufferDrawBuffersEXT;
            public static delFramebufferReadBufferEXT glFramebufferReadBufferEXT;

            public static delGetFramebufferParameterivEXT glGetFramebufferParameterivEXT;

            public static delVertexArrayVertexAttribOffsetEXT glVertexArrayVertexAttribOffsetEXT;
            public static delVertexArrayVertexAttribIOffsetEXT glVertexArrayVertexAttribIOffsetEXT;
            public static delEnableVertexArrayAttribEXT glEnableVertexArrayAttribEXT;
            public static delDisableVertexArrayAttribEXT glDisableVertexArrayAttribEXT;

            public static delGetVertexArrayIntegervEXT glGetVertexArrayIntegervEXT;
            public static delGetVertexArrayPointervEXT glGetVertexArrayPointervEXT;

            public static delGetVertexArrayIntegeri_vEXT glGetVertexArrayIntegeri_vEXT;
            public static delGetVertexArrayPointeri_vEXT glGetVertexArrayPointeri_vEXT;

            public static delFlushMappedNamedBufferRangeEXT glFlushMappedNamedBufferRangeEXT;
            public static delMapNamedBufferRangeEXT glMapNamedBufferRangeEXT;


            #endregion
        }

        #endregion

        #region Public functions.

        /// <summary>
        /// Gets an integer parameter from a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        public static void GetTextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int[] data)
        {
            Delegates.glGetTextureParameterIivEXT(TextureID, target, pname, ref data[0]);
        }
        /// <summary>
        /// Gets an integer parameter from a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int GetTextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname)
        {
            int tmp = 0;
            Delegates.glGetTextureParameterIivEXT(TextureID, target, pname, ref tmp);
            return tmp;
        }
        /// <summary>
        /// Gets an integer parameter from a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        public static void GetTextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname, uint[] data)
        {
            Delegates.glGetTextureParameterIuivEXT(TextureID, target, pname, ref data[0]);
        }
        /// <summary>
        /// Gets an integer parameter from a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static uint GetTextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname)
        {
            uint tmp = 0;
            Delegates.glGetTextureParameterIuivEXT(TextureID, target, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Sets an integer parameter on a integer texture.
        /// </summary>
        /// <param name="ProgramID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        public static void TextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int[] data)
        {
            Delegates.glTextureParameterIivEXT(TextureID, target, pname, ref data[0]);
            
        }
        /// <summary>
        /// Sets an integer parameter on a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        public static void TextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref int data)
        {
            Delegates.glTextureParameterIivEXT(TextureID, target, pname, ref data);
        }
        /// <summary>
        /// Sets an integer parameter on a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        public static void TextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname, uint[] data)
        {
            Delegates.glTextureParameterIuivEXT(TextureID, target, pname, ref data[0]);
        }
        /// <summary>
        /// Sets an integer parameter on a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        public static void TextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname, uint data)
        {
            Delegates.glTextureParameterIuivEXT(TextureID, target, pname, ref data);
        }


        public static void ProgramUniform1uiEXT(uint ProgramID, int location, uint v1)
        {
            Delegates.glProgramUniform1uiEXT(ProgramID, location, v1);
        }
        public static void ProgramUniform2uiEXT(uint ProgramID, int location, uint v1, uint v2)
        {
            Delegates.glProgramUniform2uiEXT(ProgramID, location, v1, v2);
        }
        public static void ProgramUniform3uiEXT(uint ProgramID, int location, uint v1, uint v2, uint v3)
        {
            Delegates.glProgramUniform3uiEXT(ProgramID, location, v1, v2, v3);
        }
        public static void ProgramUniform4uiEXT(uint ProgramID, int location, uint v1, uint v2, uint v3, uint v4)
        {
            Delegates.glProgramUniform4uiEXT(ProgramID, location, v1, v2, v3, v4);
        }

        public static void ProgramUniform1uivEXT(uint ProgramID, int location, ref uint v, int count = 1)
        {
            Delegates.glProgramUniform1uivEXT(ProgramID, location, count, ref v);
        }
        public static void ProgramUniform1uivEXT(uint ProgramID, int location, uint[] v)
        {
            Delegates.glProgramUniform1uivEXT(ProgramID, location, v.Length, ref v[0]);
        }

        public static void ProgramUniform2uivEXT(uint ProgramID, int location, ref uint v, int count = 1)
        {
            Delegates.glProgramUniform2uivEXT(ProgramID, location, count, ref v);
        }
        public static void ProgramUniform2uivEXT(uint ProgramID, int location, uint[] v)
        {
            Delegates.glProgramUniform2uivEXT(ProgramID, location, v.Length / 2, ref v[0]);
        }

        public static void ProgramUniform3uivEXT(uint ProgramID, int location, ref uint v, int count = 1)
        {
            Delegates.glProgramUniform3uivEXT(ProgramID, location, count, ref v);
        }
        public static void ProgramUniform3uivEXT(uint ProgramID, int location, uint[] v)
        {
            Delegates.glProgramUniform3uivEXT(ProgramID, location, v.Length / 3, ref v[0]);
        }

        public static void ProgramUniform4uivEXT(uint ProgramID, int location, ref uint v, int count = 1)
        {
            Delegates.glProgramUniform4uivEXT(ProgramID, location, count, ref v);
        }
        public static void ProgramUniform4uivEXT(uint ProgramID, int location, uint[] v)
        {
            Delegates.glProgramUniform4uivEXT(ProgramID, location, v.Length / 4, ref v[0]);
        }

        /// <summary>
        /// Allocates renderbuffer storage on specified renderbufferid.
        /// </summary>
        /// <param name="RenderbufferID">id of renderbuffer to allocate storage for.</param>
        /// <param name="iformat">The format of storage.</param>
        /// <param name="width">Width of storage.</param>
        /// <param name="height">Height of storage.</param>
        public static void NamedRenderbufferStorageEXT(uint RenderbufferID, RenderbufferStorageFormat iformat, int width, int height)
        {
            Delegates.glNamedRenderbufferStorageEXT(RenderbufferID, iformat, width, height);
        }
        /// <summary>
        /// Retrives a renderbuffer parameter from named renderbuffer.
        /// </summary>
        /// <param name="RenderbufferID">id of renderbuffer to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">Result</param>
        public static void GetNamedRenderbufferParameterivEXT(uint RenderbufferID, RenderbufferParameters pname, int[] @params)
        {
            Delegates.glGetNamedRenderbufferParameterivEXT(RenderbufferID, pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives a renderbuffer parameter from named renderbuffer.
        /// </summary>
        /// <param name="RenderbufferID">id of renderbuffer to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <returns>Result</returns>
        public static int GetNamedRenderbufferParameterivEXT(uint RenderbufferID, RenderbufferParameters pname)
        {
            int tmp = 0;
            Delegates.glGetNamedRenderbufferParameterivEXT(RenderbufferID, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Allocates Multisampled  storage on named renderbuffer.
        /// </summary>
        /// <param name="RenderbufferID">id of renderbuffer to allocate multisample storage for.</param>
        /// <param name="samples">Number of samples in multisample storage.</param>
        /// <param name="iformat">Format of multisample storage.</param>
        /// <param name="width">Width of storage.</param>
        /// <param name="height">Height of storage.</param>
        public static void NamedRenderbufferStorageMultisampleEXT(uint RenderbufferID, int samples, RenderbufferStorageFormat iformat, int width, int height)
        {
            Delegates.glNamedRenderbufferStorageMultisampleEXT(RenderbufferID, samples, iformat, width, height);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="RenderbufferID"></param>
        /// <param name="CoverageSamples"></param>
        /// <param name="ColorSamples"></param>
        /// <param name="iformat"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        public static void NamedRenderbufferStorageMultisampleCoverageEXT(uint RenderbufferID, int CoverageSamples, int ColorSamples, int iformat, int Width, int Height)
        {
            Delegates.glNamedRenderbufferStorageMultisampleCoverageEXT(RenderbufferID, CoverageSamples, ColorSamples, iformat, Width, Height);
        }

        /// <summary>
        /// Checks the completeness of a framebuffer setup.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to check.</param>
        /// <param name="fboTarget">Target to check for.</param>
        /// <returns>result</returns>
        public static FramebufferStatus CheckNamedFramebufferStatusEXT(uint FramebufferID, FramebufferTarget fboTarget)
        {
            return Delegates.glCheckNamedFramebufferStatusEXT(FramebufferID, fboTarget);
        }

        /// <summary>
        /// Attaches a texture mipmap level to a named framebuffer at a specified attachment point.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to attach texture to.</param>
        /// <param name="attachment">Attachment point to attach texture to.</param>
        /// <param name="texTarget1D">Target type of texture to attach.</param>
        /// <param name="TextureID">Id of texture to attach.</param>
        /// <param name="Level">The mipmap level to attach.</param>
        public static void NamedFramebufferTexture1DEXT(uint FramebufferID, FramebufferAttachmentType attachment, TextureTarget texTarget1D, uint TextureID, int Level = 0)
        {
            Delegates.glNamedFramebufferTexture1DEXT(FramebufferID, attachment, texTarget1D, TextureID, Level);
        }
        /// <summary>
        /// Attaches a texture mipmap level to a named framebuffer at a specified attachment point.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to attach texture to.</param>
        /// <param name="attachment">Attachment point to attach texture to.</param>
        /// <param name="texTarget2D">Target type of texture to attach.</param>
        /// <param name="TextureID">Id of texture to attach.</param>
        /// <param name="Level">The mipmap level to attach.</param>
        public static void NamedFramebufferTexture2DEXT(uint FramebufferID, FramebufferAttachmentType attachment, TextureTarget texTarget2D, uint TextureID, int Level = 0)
        {
            Delegates.glNamedFramebufferTexture2DEXT(FramebufferID, attachment, texTarget2D, TextureID, Level);
        }
        /// <summary>
        /// Attaches a texture mipmap level to a named framebuffer at a specified attachment point.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to attach texture to.</param>
        /// <param name="attachment">Attachment point to attach texture to.</param>
        /// <param name="texTarget3D">Target type of texture to attach.</param>
        /// <param name="TextureID">Id of texture to attach.</param>
        /// <param name="level">The mipmap level to attach.</param>
        /// <param name="layer">The texture layer/array to attach.</param>
        public static void NamedFramebufferTexture3DEXT(uint FramebufferID, FramebufferAttachmentType attachment, TextureTarget texTarget3D, uint TextureID, int level = 0, int layer= 0)
        {
            Delegates.glNamedFramebufferTexture3DEXT(FramebufferID, attachment, texTarget3D, TextureID, level, layer);
        }

        /// <summary>
        /// Attaches a renderbuffer to a named framebuffer at a specified attachment point.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to attach renderbuffer to.</param>
        /// <param name="attachment">Attachment point to attach renderbuffer to.</param>
        /// <param name="Renderbuffer">ID of renderbuffer to attach.</param>
        /// <param name="rtarget">Renderbuffer target type.</param>
        public static void NamedFramebufferRenderbufferEXT(uint FramebufferID, FramebufferAttachmentType attachment, uint Renderbuffer, RenderbufferTarget rtarget = RenderbufferTarget.Renderbuffer)
        {
            Delegates.glNamedFramebufferRenderbufferEXT(FramebufferID, attachment, rtarget, Renderbuffer);
        }

        /// <summary>
        /// Retrives parameters from a attachment point on a named framebuffer.
        /// </summary>
        /// <param name="FramebufferID">ID of framebuffer to query.</param>
        /// <param name="attachment">Attachmount point on framebuffer to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">result</param>
        public static void GetNamedFramebufferAttachmentParameterivEXT(uint FramebufferID, FramebufferAttachmentType attachment, AttachmentParameters pname, int[] @params)
        {
            Delegates.glGetNamedFramebufferAttachmentParameterivEXT(FramebufferID, attachment, pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives parameters from a attachment point on a named framebuffer.
        /// </summary>
        /// <param name="FramebufferID">ID of framebuffer to query.</param>
        /// <param name="attachment">Attachmount point on framebuffer to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <returns>result</returns>
        public static int GetNamedFramebufferAttachmentParameterivEXT(uint FramebufferID, FramebufferAttachmentType attachment, AttachmentParameters pname)
        {
            int tmp = 0;
            Delegates.glGetNamedFramebufferAttachmentParameterivEXT(FramebufferID, attachment, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Tells opengl to generate mipmaps for a named texture.
        /// </summary>
        /// <param name="TextureID">Id of texture to generate mipmaps for.</param>
        /// <param name="target">Target type of texture.</param>
        public static void GenerateTextureMipmapEXT(uint TextureID, TextureTarget target)
        {
            Delegates.glGenerateTextureMipmapEXT(TextureID, target);
        }

        /// <summary>
        /// Sets the drawbuffer a framebuffer should use (or not use).
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to set.</param>
        /// <param name="mode">Drawbuffer to use</param>
        public static void FramebufferDrawBufferEXT(uint FramebufferID, DrawBufferTarget mode)
        {
            Delegates.glFramebufferDrawBufferEXT(FramebufferID, mode);
        }
        /// <summary>
        /// Sets a number of drawbuffers a framebuffer should use (or not use).
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to set for</param>
        /// <param name="bufs">Array of drawbuffers to specify in one call.</param>
        public static void FramebufferDrawBuffersEXT(uint FramebufferID, DrawBufferTarget[] bufs)
        {
            Delegates.glFramebufferDrawBuffersEXT(FramebufferID, bufs.Length, ref bufs[0]);
        }
        /// <summary>
        /// Sets the readbuffer for this framebuffer.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to set for.</param>
        /// <param name="mode">Readbuffer mode to set.</param>
        public static void FramebufferReadBufferEXT(uint FramebufferID, ReadBufferMode mode)
        {
            Delegates.glFramebufferReadBufferEXT(FramebufferID, mode);
        }

        /// <summary>
        /// Retrives parameters from a named framebuffer.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to retrive from.</param>
        /// <param name="pname">name of parameter to retrive.</param>
        /// <param name="params">result</param>
        public static void GetFramebufferParameterivEXT(uint FramebufferID, FramebufferTarget pname, int[] @params)
        {
            Delegates.glGetFramebufferParameterivEXT(FramebufferID, pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives parameters from a named framebuffer.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to retrive from.</param>
        /// <param name="pname">name of parameter to retrive</param>
        /// <returns></returns>
        public static int GetFramebufferParameterivEXT(uint FramebufferID, FramebufferTarget pname)
        {
            int tmp = 0;
            Delegates.glGetFramebufferParameterivEXT(FramebufferID, pname, ref tmp);
            return tmp;
        }


        /// <summary>
        /// Binds a named buffer to an AttributeIndex on a named vertexarray and specifies its vertex declaration.
        /// </summary>
        /// <param name="vaobj">VertexArrayObject to bind to.</param>
        /// <param name="BufferID">ID of buffer to bind to vao.</param>
        /// <param name="index">Attribute Index on Vao to bind to.</param>
        /// <param name="Size">Number of components in vertex declaration.</param>
        /// <param name="type">Type of component in vertex declaration.</param>
        /// <param name="normalized">Is data normalized.</param>
        /// <param name="stride">Stride between two vertices.</param>
        /// <param name="Offset">Offset in bytes from start of buffer to start of vertices.</param>
        public static void VertexArrayVertexAttribOffsetEXT(uint vaobj, uint BufferID, uint index, int Size, VertexAttribFormat type, int stride, long Offset, bool normalized = false)
        {
            Delegates.glVertexArrayVertexAttribOffsetEXT(vaobj, BufferID, index, Size, type, normalized, stride, (IntPtr)Offset);
        }
        /// <summary>
        /// Binds a named buffer to an AttributeIndex on a named vertexarray and specifies its vertex declaration.
        /// </summary>
        /// <param name="vaobj">VertexArrayObject to bind to.</param>
        /// <param name="BufferID">ID of buffer to bind to vao.</param>
        /// <param name="index">Attribute Index on Vao to bind to.</param>
        /// <param name="size">Number of components in vertex declaration.</param>
        /// <param name="iType">Integer Type of component in vertex declaration.</param>
        /// <param name="stride">Stride between two vertices.</param>
        /// <param name="Offset">Offset in bytes from start of buffer to start of vertices.</param>
        public static void VertexArrayVertexAttribIOffsetEXT(uint vaobj, uint BufferID, uint index, int size, VertexAttribIFormat iType, int stride, long Offset)
        {
            Delegates.glVertexArrayVertexAttribIOffsetEXT(vaobj, BufferID, index, size, iType, stride, (IntPtr)Offset);
        }
        /// <summary>
        /// Enables an Attribute Index on a named VertexArrayObject.
        /// </summary>
        /// <param name="vaobj">ID of VertexArrayObject to enable on.</param>
        /// <param name="index">Attribute Index to enable.</param>
        public static void EnableVertexArrayAttribEXT(uint vaobj, uint index)
        {
            Delegates.glEnableVertexArrayAttribEXT(vaobj, index);
        }
        /// <summary>
        /// Disables an Attribute Index in a VertexArrayObject
        /// </summary>
        /// <param name="vaobj">id of vertexarrayobject</param>
        /// <param name="index">Attribute index to disable.</param>
        public static void DisableVertexArrayAttribEXT(uint vaobj, uint index)
        {
            Delegates.glDisableVertexArrayAttribEXT(vaobj, index);
        }

        /// <summary>
        /// Retrives parameters on a VAO?
        /// </summary>
        /// <param name="vaobj"></param>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        public static void GetVertexArrayIntegervEXT(uint vaobj, VertexAttribParameters pname, int[] param)
        {
            Delegates.glGetVertexArrayIntegervEXT(vaobj, pname, ref param[0]);
        }
        /// <summary>
        /// Retrives parameters on a VAO?
        /// </summary>
        /// <param name="vaobj"></param>
        /// <param name="pname"></param>
        /// <returns></returns>
        public static int GetVertexArrayIntegervEXT(uint vaobj, VertexAttribParameters pname)
        {
            int tmp = 0;
            Delegates.glGetVertexArrayIntegervEXT(vaobj, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Retrives pointer info for a VAO?
        /// </summary>
        /// <param name="vaobj">id of VertexArrayObject to query</param>
        /// <param name="pname"></param>
        /// <param name="ptr"></param>
        public static void GetVertexArrayPointervEXT(uint vaobj, GetPointerName pname, ref IntPtr ptr)
        {
            Delegates.glGetVertexArrayPointervEXT(vaobj, pname, ref ptr);
        }
        /// <summary>
        /// Retrives pointer info for a VAO?
        /// </summary>
        /// <param name="vaobj">id of VertexArrayObject to query</param>
        /// <param name="pname"></param>
        /// <returns></returns>
        public static IntPtr GetVertexArrayPointervEXT(uint vaobj, GetPointerName pname)
        {
            IntPtr ptr = IntPtr.Zero;
            Delegates.glGetVertexArrayPointervEXT(vaobj, pname, ref ptr);
            return ptr;
        }
        /// <summary>
        /// Retrives Integer parameters from a Attribute Index on a named VAO.
        /// </summary>
        /// <param name="vaobj">id of VertexArrayObject to query</param>
        /// <param name="index">Attribute Index to query</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">result</param>
        public static void GetVertexArrayIntegeri_vEXT(uint vaobj, uint index, VertexAttribParameters pname, int[] @params)
        {
            Delegates.glGetVertexArrayIntegeri_vEXT(vaobj, index, pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives Integer parameters from a Attribute Index on a named VAO.
        /// </summary>
        /// <param name="vaobj">id of VertexArrayObject to query</param>
        /// <param name="index">Attribute Index to query</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <returns></returns>
        public static int GetVertexArrayIntegeri_vEXT(uint vaobj, uint index, VertexAttribParameters pname)
        {
            int tmp = 0;
            Delegates.glGetVertexArrayIntegeri_vEXT(vaobj, index, pname, ref tmp);
            return tmp;
        }

        public static void GetVertexArrayPointeri_vEXT(uint vaobj, uint index, GetPointerName pname, out IntPtr ptr)
        {
            Delegates.glGetVertexArrayPointeri_vEXT(vaobj, index, pname, out ptr);
        }

        /// <summary>
        /// Flushes sub range/region on a previously [Range] mapped buffer.
        /// </summary>
        /// <param name="BufferID">Id of buffer to flush</param>
        /// <param name="target">Target of buffer to flush</param>
        /// <param name="Offset">Offset in bytes from start of buffer to start of flush range.</param>
        /// <param name="Length">Length in bytes from start of flush range to end of flush range.</param>
        public static void FlushMappedNamedBufferRangeEXT(uint BufferID, BufferTarget target, long Offset, long Length)
        {
            Delegates.glFlushMappedNamedBufferRangeEXT(BufferID, target, (IntPtr)Offset, (IntPtr)Length);
        }

        /// <summary>
        /// Maps a region/range on a named buffer.
        /// </summary>
        /// <param name="BufferID">id of buffer to map.</param>
        /// <param name="target">Target of buffer to map.</param>
        /// <param name="Offset">Offset in bytes from start of buffer to start of range.</param>
        /// <param name="Length">Length in bytes from start of range to end of range.</param>
        /// <param name="access">Desired access for mapping.</param>
        /// <returns></returns>
        public static IntPtr MapNamedBufferRangeEXT(uint BufferID, BufferTarget target, long Offset, long Length, MapBufferRangeAccessFlags access)
        {
            return Delegates.glMapNamedBufferRangeEXT(BufferID, target, (IntPtr)Offset, (IntPtr)Length, access);
        }


        #endregion
    }
}
