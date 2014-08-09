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
    
    partial class DSA
    {

        #region OpenGL DLLImports

        [EntryPointSlot(57)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int* data);
        [EntryPointSlot(58)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname, uint* data);

        [EntryPointSlot(59)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glTextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int* data);
        [EntryPointSlot(60)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glTextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname, uint* data);

        [EntryPointSlot(61)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform1uiEXT(uint ProgramID, int location, uint v1);
        [EntryPointSlot(62)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform2uiEXT(uint ProgramID, int location, uint v1, uint v2);
        [EntryPointSlot(63)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform3uiEXT(uint ProgramID, int location, uint v1, uint v2, uint v3);
        [EntryPointSlot(64)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform4uiEXT(uint ProgramID, int location, uint v1, uint v2, uint v3, uint v4);

        [EntryPointSlot(65)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform1uivEXT(uint ProgramID, int location, int count, uint* v);
        [EntryPointSlot(66)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform2uivEXT(uint ProgramID, int location, int count, uint* v);
        [EntryPointSlot(67)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform3uivEXT(uint ProgramID, int location, int count, uint* v);
        [EntryPointSlot(68)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform4uivEXT(uint ProgramID, int location, int count, uint* v);


        [EntryPointSlot(69)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedRenderbufferStorageEXT(uint RenderbufferID, RenderbufferStorageFormat iformat, int width, int height);
        [EntryPointSlot(70)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetNamedRenderbufferParameterivEXT(uint RenderbufferID, RenderbufferParameters pname, int* result);

        [EntryPointSlot(71)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedRenderbufferStorageMultisampleEXT(uint RenderbufferID, int samples, RenderbufferStorageFormat iformat, int width, int height);

        [EntryPointSlot(72)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedRenderbufferStorageMultisampleCoverageEXT(uint RenderbufferID, int CoverageSamples, int ColorSamples, int iformat, int Width, int Height);

        [EntryPointSlot(73)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern FramebufferStatus glCheckNamedFramebufferStatusEXT(uint FramebufferID, FramebufferTarget fboTarget);

        [EntryPointSlot(74)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedFramebufferTexture1DEXT(uint FramebufferID, FramebufferAttachmentType attachment, TextureTarget texTarget1D, uint TextureID, int Level);
        [EntryPointSlot(75)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedFramebufferTexture2DEXT(uint FramebufferID, FramebufferAttachmentType attachment, TextureTarget texTarget2D, uint TextureID, int level);
        [EntryPointSlot(76)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedFramebufferTexture3DEXT(uint FramebufferID, FramebufferAttachmentType attachment, TextureTarget texTarget3D, uint TextureID, int level, int layer);

        [EntryPointSlot(77)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedFramebufferRenderbufferEXT(uint FramebufferID, FramebufferAttachmentType attachment, RenderbufferTarget rtarget, uint Renderbuffer);

        [EntryPointSlot(78)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetNamedFramebufferAttachmentParameterivEXT(uint FramebufferID, FramebufferAttachmentType attachment, AttachmentParameters pname, int* result);

        [EntryPointSlot(79)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGenerateTextureMipmapEXT(uint TextureID, TextureTarget target);

        [EntryPointSlot(80)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferDrawBufferEXT(uint FramebufferID, DrawBufferTarget mode);
        [EntryPointSlot(81)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glFramebufferDrawBuffersEXT(uint FramebufferID, int number, DrawBufferTarget* bufs);
        [EntryPointSlot(82)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferReadBufferEXT(uint FramebufferID, ReadBufferMode mode);

        [EntryPointSlot(83)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetFramebufferParameterivEXT(uint FramebufferID, FramebufferTarget pname, int* result);

        [EntryPointSlot(84)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayVertexAttribOffsetEXT(uint vaobj, uint BufferID, uint index, int Size, VertexAttribFormat type, bool normalized, int stride, IntPtr ptr);
        [EntryPointSlot(85)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexArrayVertexAttribIOffsetEXT(uint vaobj, uint BufferID, uint index, int size, VertexAttribIFormat iType, int stride, IntPtr ptr);
        [EntryPointSlot(86)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glEnableVertexArrayAttribEXT(uint vaobj, uint index);
        [EntryPointSlot(87)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDisableVertexArrayAttribEXT(uint vaobj, uint index);

        [EntryPointSlot(88)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetVertexArrayIntegervEXT(uint vaobj, VertexAttribParameters pname, int* param);
        [EntryPointSlot(89)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetVertexArrayPointervEXT(uint vaobj, GetPointerName pname, out IntPtr ptr);

        [EntryPointSlot(90)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetVertexArrayIntegeri_vEXT(uint vaobj, uint index, VertexAttribParameters pname, int* result);
        [EntryPointSlot(91)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetVertexArrayPointeri_vEXT(uint vaobj, uint index, GetPointerName pname, out IntPtr ptr);

        [EntryPointSlot(92)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFlushMappedNamedBufferRangeEXT(uint BufferID, BufferTarget target, IntPtr Offset, IntPtr Length);
        [EntryPointSlot(93)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern IntPtr glMapNamedBufferRangeEXT(uint BufferID, BufferTarget target, IntPtr Offset, IntPtr Length, MapBufferRangeAccessFlags access);


        #endregion

        #region Public functions

        /// <summary>
        /// Gets an integer parameter from a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetTextureParameterIivEXT")]
        unsafe public static void GetTextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int* data){ throw new NotImplementedException(); }
        /// <summary>
        /// Gets an integer parameter from a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetTextureParameterIivEXT")]
        public static void GetTextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Gets an integer parameter from a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetTextureParameterIivEXT")]
        public static void GetTextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref int data) { throw new NotImplementedException(); }
        /// <summary>
        /// Gets an integer parameter from a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>        
        public static int GetTextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname)
        {
            int tmp = 0;
            GetTextureParameterIivEXT(TextureID, target, pname, ref tmp);
            return tmp;
        }
        /// <summary>
        /// Gets an integer parameter from a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetTextureParameterIuivEXT")]
        unsafe public static void GetTextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname, uint* data){ throw new NotImplementedException(); }
        /// <summary>
        /// Gets an integer parameter from a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetTextureParameterIuivEXT")]
        public static void GetTextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname, uint[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Gets an integer parameter from a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetTextureParameterIuivEXT")]
        public static void GetTextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref uint data) { throw new NotImplementedException(); }
        /// <summary>
        /// Gets an integer parameter from a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>        
        public static uint GetTextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname)
        {
            uint tmp = 0;
            GetTextureParameterIuivEXT(TextureID, target, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Sets an integer parameter on a integer texture.
        /// </summary>
        /// <param name="ProgramID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glTextureParameterIivEXT")]
        unsafe public static void TextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int* data){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets an integer parameter on a integer texture.
        /// </summary>
        /// <param name="ProgramID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glTextureParameterIivEXT")]
        public static void TextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets an integer parameter on a integer texture.
        /// </summary>
        /// <param name="ProgramID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glTextureParameterIivEXT")]
        public static void TextureParameterIivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref int data) { throw new NotImplementedException(); }

        /// <summary>
        /// Sets an integer parameter on a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glTextureParameterIuivEXT")]
        unsafe public static void TextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname, uint* data){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets an integer parameter on a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glTextureParameterIuivEXT")]
        public static void TextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname, uint[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets an integer parameter on a integer texture.
        /// </summary>
        /// <param name="TextureID">Id of texture</param>
        /// <param name="target">Target of texture id.</param>
        /// <param name="pname"></param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glTextureParameterIuivEXT")]
        public static void TextureParameterIuivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref uint data) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glProgramUniform1uiEXT")]
        public static void ProgramUniform1uiEXT(uint ProgramID, int location, uint v1){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform2uiEXT")]
        public static void ProgramUniform2uiEXT(uint ProgramID, int location, uint v1, uint v2){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform3uiEXT")]
        public static void ProgramUniform3uiEXT(uint ProgramID, int location, uint v1, uint v2, uint v3){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform4uiEXT")]
        public static void ProgramUniform4uiEXT(uint ProgramID, int location, uint v1, uint v2, uint v3, uint v4){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glProgramUniform1uivEXT")]
        unsafe public static void ProgramUniform1uivEXT(uint ProgramID, int location, int count, uint* v){ throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glProgramUniform1uivEXT")]
        //public static void ProgramUniform1uivEXT(uint ProgramID, int location, int count, uint[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1uivEXT")]
        public static void ProgramUniform1uivEXT(uint ProgramID, int location, int count, ref uint v) { throw new NotImplementedException(); }
                
        public static void ProgramUniform1uivEXT(uint ProgramID, int location, uint[] v, int count = 1, int vindex = 0)
        {
            ProgramUniform1uivEXT(ProgramID, location, count, ref v[vindex]);
        }

        [EntryPoint(FunctionName = "glProgramUniform2uivEXT")]
        unsafe public static void ProgramUniform2uivEXT(uint ProgramID, int location, int count, uint* v){ throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glProgramUniform2uivEXT")]
        //public static void ProgramUniform2uivEXT(uint ProgramID, int location, int count, uint[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2uivEXT")]
        public static void ProgramUniform2uivEXT(uint ProgramID, int location, int count, ref uint v) { throw new NotImplementedException(); }       
        public static void ProgramUniform2uivEXT(uint ProgramID, int location, uint[] v, int count = 1, int vindex = 0)
        {
            Debug.Assert(v.Length >= (count * 2), "v.length needs to be higher or equal to count * 2");
            ProgramUniform2uivEXT(ProgramID, location, count, ref v[vindex]);
        }

        [EntryPoint(FunctionName = "glProgramUniform3uivEXT")]
        unsafe public static void ProgramUniform3uivEXT(uint ProgramID, int location, int count, uint* v){ throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glProgramUniform3uivEXT")]
        //public static void ProgramUniform3uivEXT(uint ProgramID, int location, int count, uint[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3uivEXT")]
        public static void ProgramUniform3uivEXT(uint ProgramID, int location, int count, ref uint v) { throw new NotImplementedException(); }
        
        public static void ProgramUniform3uivEXT(uint ProgramID, int location, uint[] v, int count = 1, int vindex = 0)
        {
            Debug.Assert(v.Length >= (count * 3), "v.length needs to be higher or equal to count * 3");
            ProgramUniform3uivEXT(ProgramID, location, count, ref v[vindex]);
        }

        [EntryPoint(FunctionName = "glProgramUniform4uivEXT")]
        unsafe public static void ProgramUniform4uivEXT(uint ProgramID, int location, int count, uint* v){ throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glProgramUniform4uivEXT")]
        //public static void ProgramUniform4uivEXT(uint ProgramID, int location, int count, uint[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4uivEXT")]
        public static void ProgramUniform4uivEXT(uint ProgramID, int location, int count, ref uint v) { throw new NotImplementedException(); }
        
        public static void ProgramUniform4uivEXT(uint ProgramID, int location, uint[] v, int count = 1, int vindex = 0)
        {
            Debug.Assert(v.Length >= (count * 4), "v.length needs to be higher or equal to count * 4");
            ProgramUniform4uivEXT(ProgramID, location, count, ref v[vindex]);
        }

        /// <summary>
        /// Allocates renderbuffer storage on specified renderbufferid.
        /// </summary>
        /// <param name="RenderbufferID">id of renderbuffer to allocate storage for.</param>
        /// <param name="iformat">The format of storage.</param>
        /// <param name="width">Width of storage.</param>
        /// <param name="height">Height of storage.</param>
        [EntryPoint(FunctionName = "glNamedRenderbufferStorageEXT")]
        public static void NamedRenderbufferStorageEXT(uint RenderbufferID, RenderbufferStorageFormat iformat, int width, int height){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrives a renderbuffer parameter from named renderbuffer.
        /// </summary>
        /// <param name="RenderbufferID">id of renderbuffer to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">Result</param>
        [EntryPoint(FunctionName = "glGetNamedRenderbufferParameterivEXT")]
        unsafe public static void GetNamedRenderbufferParameterivEXT(uint RenderbufferID, RenderbufferParameters pname, int* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a renderbuffer parameter from named renderbuffer.
        /// </summary>
        /// <param name="RenderbufferID">id of renderbuffer to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">Result</param>
        [EntryPoint(FunctionName = "glGetNamedRenderbufferParameterivEXT")]
        public static void GetNamedRenderbufferParameterivEXT(uint RenderbufferID, RenderbufferParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a renderbuffer parameter from named renderbuffer.
        /// </summary>
        /// <param name="RenderbufferID">id of renderbuffer to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">Result</param>
        [EntryPoint(FunctionName = "glGetNamedRenderbufferParameterivEXT")]
        public static void GetNamedRenderbufferParameterivEXT(uint RenderbufferID, RenderbufferParameters pname, ref int result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a renderbuffer parameter from named renderbuffer.
        /// </summary>
        /// <param name="RenderbufferID">id of renderbuffer to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>        
        [EntryPoint(FunctionName = "glGetNamedRenderbufferParameterivEXT")]
        public static int GetNamedRenderbufferParameterivEXT(uint RenderbufferID, RenderbufferParameters pname) { throw new NotImplementedException(); }
        //public static int GetNamedRenderbufferParameterivEXT(uint RenderbufferID, RenderbufferParameters pname)
        //{
        //    int tmp = 0;
        //    GetNamedRenderbufferParameterivEXT(RenderbufferID, pname, ref tmp);
        //    return tmp;
        //}


        /// <summary>
        /// Allocates Multisampled  storage on named renderbuffer.
        /// </summary>
        /// <param name="RenderbufferID">id of renderbuffer to allocate multisample storage for.</param>
        /// <param name="samples">Number of samples in multisample storage.</param>
        /// <param name="iformat">Format of multisample storage.</param>
        /// <param name="width">Width of storage.</param>
        /// <param name="height">Height of storage.</param>
        [EntryPoint(FunctionName = "glNamedRenderbufferStorageMultisampleEXT")]
        public static void NamedRenderbufferStorageMultisampleEXT(uint RenderbufferID, int samples, RenderbufferStorageFormat iformat, int width, int height){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glNamedRenderbufferStorageMultisampleCoverageEXT")]
        public static void NamedRenderbufferStorageMultisampleCoverageEXT(uint RenderbufferID, int CoverageSamples, int ColorSamples, int iformat, int Width, int Height){ throw new NotImplementedException(); }

        /// <summary>
        /// Checks the completeness of a framebuffer setup.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to check.</param>
        /// <param name="fboTarget">Target to check for.</param>
        /// <returns>result</returns>
        [EntryPoint(FunctionName = "glCheckNamedFramebufferStatusEXT")]
        public static FramebufferStatus CheckNamedFramebufferStatusEXT(uint FramebufferID, FramebufferTarget fboTarget){ throw new NotImplementedException(); }


        /// <summary>
        /// Attaches a texture mipmap level to a named framebuffer at a specified attachment point.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to attach texture to.</param>
        /// <param name="attachment">Attachment point to attach texture to.</param>
        /// <param name="texTarget1D">Target type of texture to attach.</param>
        /// <param name="TextureID">Id of texture to attach.</param>
        /// <param name="Level">The mipmap level to attach.</param>
        [EntryPoint(FunctionName = "glNamedFramebufferTexture1DEXT")]
        public static void NamedFramebufferTexture1DEXT(uint FramebufferID, FramebufferAttachmentType attachment, TextureTarget texTarget1D, uint TextureID, int Level = 0){ throw new NotImplementedException(); }

        /// <summary>
        /// Attaches a texture mipmap level to a named framebuffer at a specified attachment point.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to attach texture to.</param>
        /// <param name="attachment">Attachment point to attach texture to.</param>
        /// <param name="texTarget2D">Target type of texture to attach.</param>
        /// <param name="TextureID">Id of texture to attach.</param>
        /// <param name="Level">The mipmap level to attach.</param>
        [EntryPoint(FunctionName = "glNamedFramebufferTexture2DEXT")]
        public static void NamedFramebufferTexture2DEXT(uint FramebufferID, FramebufferAttachmentType attachment, TextureTarget texTarget2D, uint TextureID, int level = 0){ throw new NotImplementedException(); }

        /// <summary>
        /// Attaches a texture mipmap level to a named framebuffer at a specified attachment point.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to attach texture to.</param>
        /// <param name="attachment">Attachment point to attach texture to.</param>
        /// <param name="texTarget3D">Target type of texture to attach.</param>
        /// <param name="TextureID">Id of texture to attach.</param>
        /// <param name="level">The mipmap level to attach.</param>
        /// <param name="layer">The texture layer/array to attach.</param>
        [EntryPoint(FunctionName = "glNamedFramebufferTexture3DEXT")]
        public static void NamedFramebufferTexture3DEXT(uint FramebufferID, FramebufferAttachmentType attachment, TextureTarget texTarget3D, uint TextureID, int level = 0, int layer = 0){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glNamedFramebufferRenderbufferEXT")]
        public static void NamedFramebufferRenderbufferEXT(uint FramebufferID, FramebufferAttachmentType attachment, RenderbufferTarget rtarget, uint Renderbuffer){ throw new NotImplementedException(); }

        /// <summary>
        /// Attaches a renderbuffer to a named framebuffer at a specified attachment point.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to attach renderbuffer to.</param>
        /// <param name="attachment">Attachment point to attach renderbuffer to.</param>
        /// <param name="Renderbuffer">ID of renderbuffer to attach.</param>
        /// <param name="rtarget">Renderbuffer target type.</param>
        public static void NamedFramebufferRenderbufferEXT(uint FramebufferID, FramebufferAttachmentType attachment, uint Renderbuffer, RenderbufferTarget rtarget = RenderbufferTarget.Renderbuffer)
        {
            NamedFramebufferRenderbufferEXT(FramebufferID, attachment, rtarget, Renderbuffer);
        }


        /// <summary>
        /// Retrives parameters from a attachment point on a named framebuffer.
        /// </summary>
        /// <param name="FramebufferID">ID of framebuffer to query.</param>
        /// <param name="attachment">Attachmount point on framebuffer to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">result</param>
        [EntryPoint(FunctionName = "glGetNamedFramebufferAttachmentParameterivEXT")]
        unsafe public static void GetNamedFramebufferAttachmentParameterivEXT(uint FramebufferID, FramebufferAttachmentType attachment, AttachmentParameters pname, int* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives parameters from a attachment point on a named framebuffer.
        /// </summary>
        /// <param name="FramebufferID">ID of framebuffer to query.</param>
        /// <param name="attachment">Attachmount point on framebuffer to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">result</param>
        [EntryPoint(FunctionName = "glGetNamedFramebufferAttachmentParameterivEXT")]
        public static void GetNamedFramebufferAttachmentParameterivEXT(uint FramebufferID, FramebufferAttachmentType attachment, AttachmentParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives parameters from a attachment point on a named framebuffer.
        /// </summary>
        /// <param name="FramebufferID">ID of framebuffer to query.</param>
        /// <param name="attachment">Attachmount point on framebuffer to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">result</param>
        [EntryPoint(FunctionName = "glGetNamedFramebufferAttachmentParameterivEXT")]
        public static void GetNamedFramebufferAttachmentParameterivEXT(uint FramebufferID, FramebufferAttachmentType attachment, AttachmentParameters pname, ref int result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a parameter from a attachment point on a named framebuffer.
        /// </summary>
        /// <param name="FramebufferID">ID of framebuffer to query.</param>
        /// <param name="attachment">Attachmount point on framebuffer to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <returns>result</returns>
        public static int GetNamedFramebufferAttachmentParameterivEXT(uint FramebufferID, FramebufferAttachmentType attachment, AttachmentParameters pname)
        {
            int tmp = 0;
            GetNamedFramebufferAttachmentParameterivEXT(FramebufferID, attachment, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Tells opengl to generate mipmaps for a named texture.
        /// </summary>
        /// <param name="TextureID">Id of texture to generate mipmaps for.</param>
        /// <param name="target">Target type of texture.</param>
        [EntryPoint(FunctionName = "glGenerateTextureMipmapEXT")]
        public static void GenerateTextureMipmapEXT(uint TextureID, TextureTarget target){ throw new NotImplementedException(); }

        /// <summary>
        /// Sets the drawbuffer a framebuffer should use (or not use).
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to set.</param>
        /// <param name="mode">Drawbuffer to use</param>
        [EntryPoint(FunctionName = "glFramebufferDrawBufferEXT")]
        public static void FramebufferDrawBufferEXT(uint FramebufferID, DrawBufferTarget mode){ throw new NotImplementedException(); }

        /// <summary>
        /// Sets a number of drawbuffers a framebuffer should use (or not use).
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to set for</param>
        /// <param name="bufs">Array of drawbuffers to specify in one call.</param>
        [EntryPoint(FunctionName = "glFramebufferDrawBuffersEXT")]
        unsafe public static void FramebufferDrawBuffersEXT(uint FramebufferID, int number, DrawBufferTarget* bufs){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets a number of drawbuffers a framebuffer should use (or not use).
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to set for</param>
        /// <param name="bufs">Array of drawbuffers to specify in one call.</param>
        [EntryPoint(FunctionName = "glFramebufferDrawBuffersEXT")]
        public static void FramebufferDrawBuffersEXT(uint FramebufferID, int number, DrawBufferTarget[] bufs) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets a number of drawbuffers a framebuffer should use (or not use).
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to set for</param>
        /// <param name="bufs">Array of drawbuffers to specify in one call.</param>
        [EntryPoint(FunctionName = "glFramebufferDrawBuffersEXT")]
        public static void FramebufferDrawBuffersEXT(uint FramebufferID, int number, ref DrawBufferTarget bufs) { throw new NotImplementedException(); }

        /// <summary>
        /// Sets the readbuffer for this framebuffer.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to set for.</param>
        /// <param name="mode">Readbuffer mode to set.</param>
        [EntryPoint(FunctionName = "glFramebufferReadBufferEXT")]
        public static void FramebufferReadBufferEXT(uint FramebufferID, ReadBufferMode mode){ throw new NotImplementedException(); }


        /// <summary>
        /// Retrives parameters from a named framebuffer.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to retrive from.</param>
        /// <param name="pname">name of parameter to retrive.</param>
        /// <param name="params">result</param>
        [EntryPoint(FunctionName = "glGetFramebufferParameterivEXT")]
        unsafe public static void GetFramebufferParameterivEXT(uint FramebufferID, FramebufferTarget pname, int* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives parameters from a named framebuffer.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to retrive from.</param>
        /// <param name="pname">name of parameter to retrive.</param>
        /// <param name="params">result</param>
        [EntryPoint(FunctionName = "glGetFramebufferParameterivEXT")]
        public static void GetFramebufferParameterivEXT(uint FramebufferID, FramebufferTarget pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives parameters from a named framebuffer.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to retrive from.</param>
        /// <param name="pname">name of parameter to retrive.</param>
        /// <param name="params">result</param>
        [EntryPoint(FunctionName = "glGetFramebufferParameterivEXT")]
        public static void GetFramebufferParameterivEXT(uint FramebufferID, FramebufferTarget pname, ref int result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a parameter from a named framebuffer.
        /// </summary>
        /// <param name="FramebufferID">id of framebuffer to retrive from.</param>
        /// <param name="pname">name of parameter to retrive</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetFramebufferParameterivEXT")]
        public static int GetFramebufferParameterivEXT(uint FramebufferID, FramebufferTarget pname) { throw new NotImplementedException(); }

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
        [EntryPoint(FunctionName = "glVertexArrayVertexAttribOffsetEXT")]
        public static void VertexArrayVertexAttribOffsetEXT(uint vaobj, uint BufferID, uint index, int Size, VertexAttribFormat type, bool normalized, int stride, IntPtr ptr){ throw new NotImplementedException(); }
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
        public static void VertexArrayVertexAttribOffsetEXT(uint vaobj, uint BufferID, uint index, int Size, VertexAttribFormat type, int stride, long offset, bool normalized = false)
        {
            VertexArrayVertexAttribOffsetEXT(vaobj, BufferID, index, Size, type, normalized, stride, (IntPtr)offset);
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
        [EntryPoint(FunctionName = "glVertexArrayVertexAttribIOffsetEXT")]
        public static void VertexArrayVertexAttribIOffsetEXT(uint vaobj, uint BufferID, uint index, int size, VertexAttribIFormat iType, int stride, IntPtr ptr){ throw new NotImplementedException(); }
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
        [EntryPoint(FunctionName = "glVertexArrayVertexAttribIOffsetEXT")]
        public static void VertexArrayVertexAttribIOffsetEXT(uint vaobj, uint BufferID, uint index, int size, VertexAttribIFormat iType, int stride, long offset)
        {
            VertexArrayVertexAttribIOffsetEXT(vaobj, BufferID, index, size, iType, stride, (IntPtr)offset);
        }

        /// <summary>
        /// Enables an Attribute Index on a named VertexArrayObject.
        /// </summary>
        /// <param name="vaobj">ID of VertexArrayObject to enable on.</param>
        /// <param name="index">Attribute Index to enable.</param>
        [EntryPoint(FunctionName = "glEnableVertexArrayAttribEXT")]
        public static void EnableVertexArrayAttribEXT(uint vaobj, uint index){ throw new NotImplementedException(); }

        /// <summary>
        /// Disables an Attribute Index in a VertexArrayObject
        /// </summary>
        /// <param name="vaobj">id of vertexarrayobject</param>
        /// <param name="index">Attribute index to disable.</param>
        [EntryPoint(FunctionName = "glDisableVertexArrayAttribEXT")]
        public static void DisableVertexArrayAttribEXT(uint vaobj, uint index){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrives parameters on a VAO?
        /// </summary>
        /// <param name="vaobj"></param>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        [EntryPoint(FunctionName = "glGetVertexArrayIntegervEXT")]
        unsafe public static void GetVertexArrayIntegervEXT(uint vaobj, VertexAttribParameters pname, int* param){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives parameters on a VAO?
        /// </summary>
        /// <param name="vaobj"></param>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        [EntryPoint(FunctionName = "glGetVertexArrayIntegervEXT")]
        public static void GetVertexArrayIntegervEXT(uint vaobj, VertexAttribParameters pname, int[] param) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives parameters on a VAO?
        /// </summary>
        /// <param name="vaobj"></param>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        [EntryPoint(FunctionName = "glGetVertexArrayIntegervEXT")]
        public static void GetVertexArrayIntegervEXT(uint vaobj, VertexAttribParameters pname, ref int param) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives parameters on a VAO?
        /// </summary>
        /// <param name="vaobj"></param>
        /// <param name="pname"></param>
        /// <param name="param"></param>
        [EntryPoint(FunctionName = "glGetVertexArrayIntegervEXT")]
        public static int GetVertexArrayIntegervEXT(uint vaobj, VertexAttribParameters pname) { throw new NotImplementedException(); }

        /// <summary>
        /// Retrives pointer info for a VAO?
        /// </summary>
        /// <param name="vaobj">id of VertexArrayObject to query</param>
        /// <param name="pname"></param>
        /// <param name="ptr"></param>
        [EntryPoint(FunctionName = "glGetVertexArrayPointervEXT")]
        public static void GetVertexArrayPointervEXT(uint vaobj, GetPointerName pname, out IntPtr ptr){ throw new NotImplementedException(); }


        /// <summary>
        /// Retrives Integer parameters from a Attribute Index on a named VAO.
        /// </summary>
        /// <param name="vaobj">id of VertexArrayObject to query</param>
        /// <param name="index">Attribute Index to query</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">result</param>
        [EntryPoint(FunctionName = "glGetVertexArrayIntegeri_vEXT")]
        unsafe public static void GetVertexArrayIntegeri_vEXT(uint vaobj, uint index, VertexAttribParameters pname, int* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives Integer parameters from a Attribute Index on a named VAO.
        /// </summary>
        /// <param name="vaobj">id of VertexArrayObject to query</param>
        /// <param name="index">Attribute Index to query</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">result</param>
        [EntryPoint(FunctionName = "glGetVertexArrayIntegeri_vEXT")]
        public static void GetVertexArrayIntegeri_vEXT(uint vaobj, uint index, VertexAttribParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives Integer parameters from a Attribute Index on a named VAO.
        /// </summary>
        /// <param name="vaobj">id of VertexArrayObject to query</param>
        /// <param name="index">Attribute Index to query</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">result</param>
        [EntryPoint(FunctionName = "glGetVertexArrayIntegeri_vEXT")]
        public static void GetVertexArrayIntegeri_vEXT(uint vaobj, uint index, VertexAttribParameters pname, ref int result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives an Integer parameter from a Attribute Index on a named VAO.
        /// </summary>
        /// <param name="vaobj">id of VertexArrayObject to query</param>
        /// <param name="index">Attribute Index to query</param>
        /// <param name="pname">Name of parameter to retrive.</param>        
        public static int GetVertexArrayIntegeri_vEXT(uint vaobj, uint index, VertexAttribParameters pname)
        {
            int tmp = 0;
            GetVertexArrayIntegeri_vEXT(vaobj, index, pname, ref tmp);
            return tmp;
        }

        [EntryPoint(FunctionName = "glGetVertexArrayPointeri_vEXT")]
        public static void GetVertexArrayPointeri_vEXT(uint vaobj, uint index, GetPointerName pname, out IntPtr ptr){ throw new NotImplementedException(); }

        /// <summary>
        /// Flushes sub range/region on a previously [Range] mapped buffer.
        /// </summary>
        /// <param name="BufferID">Id of buffer to flush</param>
        /// <param name="target">Target of buffer to flush</param>
        /// <param name="Offset">Offset in bytes from start of buffer to start of flush range.</param>
        /// <param name="Length">Length in bytes from start of flush range to end of flush range.</param>
        [EntryPoint(FunctionName = "glFlushMappedNamedBufferRangeEXT")]
        public static void FlushMappedNamedBufferRangeEXT(uint BufferID, BufferTarget target, IntPtr Offset, IntPtr Length){ throw new NotImplementedException(); }
        /// <summary>
        /// Flushes sub range/region on a previously [Range] mapped buffer.
        /// </summary>
        /// <param name="BufferID">Id of buffer to flush</param>
        /// <param name="target">Target of buffer to flush</param>
        /// <param name="Offset">Offset in bytes from start of buffer to start of flush range.</param>
        /// <param name="Length">Length in bytes from start of flush range to end of flush range.</param>
        public static void FlushMappedNamedBufferRangeEXT(uint BufferID, BufferTarget target, long Offset, long Length)
        {
            FlushMappedNamedBufferRangeEXT(BufferID, target, (IntPtr)Offset, (IntPtr)Length);
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
        [EntryPoint(FunctionName = "glMapNamedBufferRangeEXT")]
        public static IntPtr MapNamedBufferRangeEXT(uint BufferID, BufferTarget target, IntPtr Offset, IntPtr Length, MapBufferRangeAccessFlags access){ throw new NotImplementedException(); }


        #endregion

        #region Public Helper Functions

        #endregion

    }
}
