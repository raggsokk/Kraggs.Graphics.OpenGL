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

        //[EntryPointSlot(104)]
        //[DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //private static extern void glBindTexture(TextureTarget target, uint textureid);

        [EntryPointSlot(104)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBlendEquationSeparate(BlendEquationSeparateRGB modeRGB, BlendEquationSeparateAlpha modeAlpha);
        [EntryPointSlot(105)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glDrawBuffers(int number, int* bufs);

        [EntryPointSlot(106)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern uint glCreateShader(ShaderType type);
        [EntryPointSlot(107)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDeleteShader(uint Shader);
        [EntryPointSlot(108)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsShader(uint Shader);

        //private static extern void glShaderSource(uint Shader, int Count, string[] source, int[] Lengths);
        [EntryPointSlot(109)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //private static extern void glShaderSource(uint Shader, int Count, ref string source, ref int Lengths);
        //unsafe private static extern void glShaderSource(uint Shader, int Count, string source, int* Lengths);
        unsafe private static extern void glShaderSource(uint Shader, int Count, IntPtr source, int* Lengths);
        [EntryPointSlot(110)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCompileShader(uint Shader);
        [EntryPointSlot(111)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetShaderiv(uint Shader, ShaderParameters pname, int* result);
        [EntryPointSlot(112)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //private static extern void glGetShaderSource(uint Shader, int BufSize, out int Length, StringBuilder source);
        unsafe private static extern void glGetShaderSource(uint Shader, int BufSize, int* Length, IntPtr source);
        [EntryPointSlot(113)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetShaderInfoLog(uint Shader, int BufSize, int* Length, IntPtr infoLog);
        //private static extern void glGetShaderInfoLog(uint Shader, int BufSize, out int Length, StringBuilder infoLog);

        [EntryPointSlot(114)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern uint glCreateProgram();
        [EntryPointSlot(115)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDeleteProgram(uint Program);
        [EntryPointSlot(116)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsProgram(uint Program);
        [EntryPointSlot(117)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glAttachShader(uint Program, uint Shader);
        [EntryPointSlot(118)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDetachShader(uint Program, uint Shader);
        [EntryPointSlot(119)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glLinkProgram(uint Program);
        [EntryPointSlot(120)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glValidateProgram(uint Program);
        [EntryPointSlot(121)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUseProgram(uint Program);

        [EntryPointSlot(122)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetProgramiv(uint Program, GetProgramParameters pname, int* result);
        [EntryPointSlot(123)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //private static extern void glGetProgramInfoLog(uint Program, int BufSize, out int Length, StringBuilder infoLog);
        unsafe private static extern void glGetProgramInfoLog(uint Program, int BufSize, int* Length, IntPtr infoLog);
        [EntryPointSlot(124)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetAttachedShaders(uint Program, int MaxCount, int* Count, uint* Shaders);
        [EntryPointSlot(125)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //private static extern void glGetActiveUniform(uint Program, uint index, int bufSize, out int length, out int size, out UniformType UniformType, StringBuilder Name);
        unsafe private static extern void glGetActiveUniform(uint Program, uint index, int bufSize, int* length, int* size, int* UniformType, IntPtr Name);
        [EntryPointSlot(126)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //private static extern void glGetActiveUniformName(uint Program, uint UniformIndex, int BufSize, out int length, StringBuilder UniformName);
        unsafe private static extern void glGetActiveUniformName(uint Program, uint UniformIndex, int BufSize, int* length, IntPtr UniformName);
        [EntryPointSlot(127)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //private static extern void glGetActiveUniformsiv(uint Program, int UniformCount, ref int UniformIndices, UniformParameters pname, ref int @params);
        unsafe private static extern void glGetActiveUniformsiv(uint Program, int UniformCount, int* UniformIndices, UniformParameters pname, int* result);
        [EntryPointSlot(128)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern int glGetUniformLocation(uint Program, IntPtr Name);
        [EntryPointSlot(129)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetUniformfv(uint Program, int Location, float* result);
        [EntryPointSlot(130)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetUniformiv(uint Program, int Location, int* result);

        [EntryPointSlot(131)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform1f(int location, float v1);
        [EntryPointSlot(132)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform1i(int location, int v1);

        [EntryPointSlot(133)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform2f(int location, float v1, float v2);
        [EntryPointSlot(134)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform2i(int location, int v1, int v2);

        [EntryPointSlot(135)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform3f(int location, float v1, float v2, float v3);
        [EntryPointSlot(136)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform3i(int location, int v1, int v2, int v3);

        [EntryPointSlot(137)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform4f(int location, float v1, float v2, float v3, float v4);
        [EntryPointSlot(138)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform4i(int location, int v1, int v2, int v3, int v4);

        [EntryPointSlot(139)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform1fv(int location, int count, float* v);
        [EntryPointSlot(140)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform1iv(int location, int count, int* v);

        [EntryPointSlot(141)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform2fv(int location, int count, float* v);
        [EntryPointSlot(142)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform2iv(int location, int count, int* v);

        [EntryPointSlot(143)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform3fv(int location, int count, float* v);
        [EntryPointSlot(144)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform3iv(int location, int count, int* v);

        [EntryPointSlot(145)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform4fv(int location, int count, float* v);
        [EntryPointSlot(146)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform4iv(int location, int count, int* v);

        [EntryPointSlot(147)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformMatrix2fv(int location, int count, bool transpose, float* matrix);
        [EntryPointSlot(148)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformMatrix3fv(int location, int count, bool transpose, float* matrix);
        [EntryPointSlot(149)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformMatrix4fv(int location, int count, bool transpose, float* matrix);

        [EntryPointSlot(150)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glEnableVertexAttribArray(uint index);
        [EntryPointSlot(151)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDisableVertexAttribArray(uint index);

        [EntryPointSlot(152)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexAttribPointer(uint index, int Size, VertexAttribFormat type, bool normalized, int stride, IntPtr ptr);
        [EntryPointSlot(153)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetVertexAttribPointerv(uint index, VertexAttribPointerParameters pname, out IntPtr ptr);

        [EntryPointSlot(154)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindAttribLocation(uint Program, uint aIndex, IntPtr Name);
        [EntryPointSlot(155)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern int glGetAttribLocation(uint Program, IntPtr Name);

        [EntryPointSlot(156)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetActiveAttrib(uint Program, uint index, int bufSize, out int Length, out int Size, out AttributeType type, IntPtr name);

        [EntryPointSlot(157)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetVertexAttribdv(uint index, VertexAttribParameters pname, double* result);
        [EntryPointSlot(158)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetVertexAttribfv(uint index, VertexAttribParameters pname, float* result);
        [EntryPointSlot(159)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetVertexAttribiv(uint index, VertexAttribParameters pname, int* result);

        /* 36 functions ignored.
        public delegate void delVertexAttrib1f(uint index, float v1);
        public delegate void delVertexAttrib1d(uint index, double v1);
        public delegate void delVertexAttrib1s(uint index, short v1);

        public delegate void delVertexAttrib2f(uint index, float v1, float v2);
        public delegate void delVertexAttrib2d(uint index, double v1, double v2);
        public delegate void delVertexAttrib2s(uint index, short v1, short v2);

        public delegate void delVertexAttrib3f(uint index, float v1, float v2, float v3);
        public delegate void delVertexAttrib3d(uint index, double v1, double v2, double v3);
        public delegate void delVertexAttrib3s(uint index, short v1, short v2, short v3);

        public delegate void delVertexAttrib4f(uint index, float v1, float v2, float v3, float v4);
        public delegate void delVertexAttrib4d(uint index, double v1, double v2, double v3, double v4);
        public delegate void delVertexAttrib4s(uint index, short v1, short v2, short v3, short v4);

        public delegate void delVertexAttrib4Nub(uint index, byte v1, byte v2, byte v3, byte v4);

        public delegate void delVertexAttrib1fv(uint index, float[] v);
        public delegate void delVertexAttrib1dv(uint index, double[] v);
        public delegate void delVertexAttrib1sv(uint index, short[] v);

        public delegate void delVertexAttrib2fv(uint index, float[] v);
        public delegate void delVertexAttrib2dv(uint index, double[] v);
        public delegate void delVertexAttrib2sv(uint index, short[] v);

        public delegate void delVertexAttrib3fv(uint index, float[] v);
        public delegate void delVertexAttrib3dv(uint index, double[] v);
        public delegate void delVertexAttrib3sv(uint index, short[] v);

        public delegate void delVertexAttrib4fv(uint index, float[] v);
        public delegate void delVertexAttrib4dv(uint index, double[] v);
        public delegate void delVertexAttrib4sv(uint index, short[] v);

        public delegate void delVertexAttrib4iv(uint index, int[] v);
        public delegate void delVertexAttrib4bv(uint index, sbyte[] v);
        public delegate void delVertexAttrib4ubv(uint index, byte[] v);
        public delegate void delVertexAttrib4usv(uint index, ushort[] v);
        public delegate void delVertexAttrib4uiv(uint index, uint[] v);

        public delegate void delVertexAttrib4Nbv(uint index, sbyte[] v);
        public delegate void delVertexAttrib4Nsv(uint index, short[] v);
        public delegate void delVertexAttrib4Niv(uint index, int[] v);
        public delegate void delVertexAttrib4Nubv(uint index, byte[] v);
        public delegate void delVertexAttrib4Nusv(uint index, ushort[] v);
        public delegate void delVertexAttrib4Nuiv(uint index, uint[] v);
        */

        #endregion

        #region Public functions

        /// <summary>
        /// Sets up separate blend equation.
        /// </summary>
        /// <param name="modeRGB"></param>
        /// <param name="modeAlpha"></param>
        [EntryPoint(FunctionName = "glBlendEquationSeparate")]
        public static void BlendEquationSeparate(BlendEquationSeparateRGB modeRGB, BlendEquationSeparateAlpha modeAlpha){ throw new NotImplementedException(); }

        /// <summary>
        /// Sets the drawbuffers to be used.
        /// </summary>
        /// <param name="bufs">An array of drawbuffer targets to use.</param>
        [EntryPoint(FunctionName = "glDrawBuffers")]
        public static void DrawBuffers(int number, DrawBufferTarget[] bufs){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets the drawbuffers to be used.
        /// </summary>
        /// <param name="bufs">An array of drawbuffer targets to use.</param>
        [EntryPoint(FunctionName = "glDrawBuffers")]
        public static void DrawBuffers(int number, ref DrawBufferTarget bufs) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the drawbuffers to be used.
        /// </summary>
        /// <param name="bufs">An array of drawbuffer targets to use.</param>        
        public static void DrawBuffers(DrawBufferTarget bufs)
        {
            DrawBuffers(1, ref bufs);
        }

        /// <summary>
        /// Creates a new shader id with specified ShaderType.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glCreateShader")]
        public static uint CreateShader(ShaderType type){ throw new NotImplementedException(); }

        /// Marks a shader id for deletion.
        /// if no shader program has this id attached, its delete immidiatly, otherwise it will be deleted at a later time.
        /// </summary>
        /// <param name="Shader"></param>
        [EntryPoint(FunctionName = "glDeleteShader")]
        public static void DeleteShader(uint Shader){ throw new NotImplementedException(); }

        /// <summary>
        /// Returns true if this id is a valid shader id.
        /// </summary>
        /// <param name="Shader"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glIsShader")]
        public static bool IsShader(uint Shader){ throw new NotImplementedException(); }

        //public static void ShaderSource(uint Shader, int Count, string[] source, int[] Lengths){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glShaderSource")]
        public static void ShaderSource(uint Shader, int Count, ref string source, ref int Lengths){ throw new NotImplementedException(); }
        //unsafe public static void ShaderSource(uint Shader, int Count, string source, int* Lengths){ throw new NotImplementedException(); }
        /// <summary>
        /// Uploads the shader source to specified shader.
        /// </summary>
        /// <param name="Shader">Shader id to upload code to.</param>
        /// <param name="Count">The size of the arrays with source code and source code lengths.</param>
        /// <param name="source">array of string with the source code to upload.</param>
        /// <param name="Lengths">array of ints with lengths of the strings of source code.</param>
        [EntryPoint(FunctionName = "glShaderSource")]
        public static void ShaderSource(uint Shader, int Count, string[] source, int[] Lengths) { throw new NotImplementedException(); }

        /// <summary>
        /// Uploads the shader source to the specified shader.
        /// </summary>
        /// <param name="Shader">Shader to upload to.</param>
        /// <param name="source">the source code to upload.</param>
        public static void ShaderSource(uint shaderID, string source)
        {
            var src = new string[] { source };
            var len = new int[] { source.Length };

            ShaderSource(shaderID, 1, src, len);
        }


        /// <summary>
        /// Compiles the shader.
        /// Note: Most OpenGL implementations asynchronosly compiles shaders.
        /// To prevent stalling running thread waiting for compile result, dont query the shader for a while.
        /// </summary>
        /// <param name="Shader"></param>
        [EntryPoint(FunctionName = "glCompileShader")]
        public static void CompileShader(uint Shader){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrive shader parameters.
        /// </summary>
        /// <param name="Shader"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetShaderiv")]
        unsafe public static void GetShaderiv(uint Shader, ShaderParameters pname, int* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrive shader parameters.
        /// </summary>
        /// <param name="Shader"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetShaderiv")]
        public static void GetShaderiv(uint Shader, ShaderParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrive shader parameters.
        /// </summary>
        /// <param name="Shader"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetShaderiv")]
        public static void GetShaderiv(uint Shader, ShaderParameters pname, out int result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrive shader parameters.
        /// </summary>
        /// <param name="Shader"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetShaderiv")]
        public static int GetShaderiv(uint Shader, ShaderParameters pname) { throw new NotImplementedException(); }


        /// <summary>
        /// Retrives the shader code of a shader object.
        /// </summary>
        /// <param name="Shader"></param>
        /// <param name="BufSize"></param>
        /// <param name="Length"></param>
        /// <param name="source"></param>
        [EntryPoint(FunctionName = "glGetShaderSource")]        
        public static void GetShaderSource(uint Shader, int BufSize, out int Length, StringBuilder source) { throw new NotImplementedException(); }

        /// <summary>
        /// Retrives the shader code from a shader id.
        /// </summary>
        /// <param name="Shader">Shader id to get shader code from.</param>
        /// <returns>The shader code.</returns>
        public static string GetShaderSource(uint Shader)
        {
            var len = GetShaderiv(Shader, ShaderParameters.ShaderSourceLength);

            var sb = new StringBuilder(len + 4);

            GetShaderSource(Shader, len, out len, sb);

            return sb.ToString();
        }

        /// <summary>
        /// Retrives the shader info log.
        /// </summary>
        /// <param name="Shader"></param>
        /// <param name="BufSize"></param>
        /// <param name="Length"></param>
        /// <param name="infoLog"></param>
        [EntryPoint(FunctionName = "glGetShaderInfoLog")]
        public static void GetShaderInfoLog(uint Shader, int BufSize, out int Length, StringBuilder infoLog) { throw new NotImplementedException(); }

        ///// <summary>
        ///// Retrives the shader info log.
        ///// </summary>
        ///// <param name="Shader"></param>
        ///// <returns>Retrives shader info log.</returns>
        public static string GetShaderInfoLog(uint Shader)
        {
            var len = GetShaderiv(Shader, ShaderParameters.InfoLogLength);

            var sb = new StringBuilder(len + 4);

            GetShaderInfoLog(Shader, len, out len, sb);

            return sb.ToString();
        }

        /// <summary>
        /// Creates a shader program.
        /// </summary>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glCreateProgram")]
        public static uint CreateProgram(){ throw new NotImplementedException(); }

        /// <summary>
        /// Deletes a shader program.
        /// </summary>
        /// <param name="Program"></param>
        [EntryPoint(FunctionName = "glDeleteProgram")]
        public static void DeleteProgram(uint Program){ throw new NotImplementedException(); }

        /// <summary>
        /// Is this a valid shader program?
        /// </summary>
        /// <param name="Program"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glIsProgram")]
        public static bool IsProgram(uint Program){ throw new NotImplementedException(); }

        /// <summary>
        /// Attaches a shader to a program.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="Shader"></param>
        [EntryPoint(FunctionName = "glAttachShader")]
        public static void AttachShader(uint Program, uint Shader){ throw new NotImplementedException(); }

        /// <summary>
        /// Detaches a shader from a program.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="Shader"></param>
        [EntryPoint(FunctionName = "glDetachShader")]
        public static void DetachShader(uint Program, uint Shader){ throw new NotImplementedException(); }

        /// <summary>
        /// Links the shaders in a program together.
        /// </summary>
        /// <param name="Program"></param>
        [EntryPoint(FunctionName = "glLinkProgram")]
        public static void LinkProgram(uint Program){ throw new NotImplementedException(); }

        /// <summary>
        /// Validates a program.
        /// </summary>
        /// <param name="Program"></param>
        [EntryPoint(FunctionName = "glValidateProgram")]
        public static void ValidateProgram(uint Program){ throw new NotImplementedException(); }

        /// <summary>
        /// Binds the specified program id as current program.
        /// Call with program=0 to unbind any program.
        /// </summary>
        /// <param name="Program"></param>
        [EntryPoint(FunctionName = "glUseProgram")]
        public static void UseProgram(uint Program){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrives a program parameter.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetProgramiv")]
        unsafe public static void GetProgramiv(uint Program, GetProgramParameters pname, int* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a program parameter.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetProgramiv")]
        public static void GetProgramiv(uint Program, GetProgramParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a program parameter.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetProgramiv")]
        public static void GetProgramiv(uint Program, GetProgramParameters pname, out int result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a program parameter.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetProgramiv")]
        public static int GetProgramiv(uint Program, GetProgramParameters pname) { throw new NotImplementedException(); }

        /// <summary>
        /// Retrives the program info log.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="BufSize"></param>
        /// <param name="Length"></param>
        /// <param name="infoLog"></param>
        [EntryPoint(FunctionName = "glGetProgramInfoLog")]
        unsafe private static void GetProgramInfoLog(uint Program, int BufSize, out int Length, StringBuilder infoLog) { throw new NotImplementedException(); }

        /// <summary>
        /// Retrives the program info log.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="Length"></param>
        /// <param name="infoLog"></param>
        public static void GetProgramInfoLog(uint Program, out int Length, StringBuilder infoLog)
        {
            var len = GL.GetProgramiv(Program, GetProgramParameters.InfoLogLength);

            //var sb = new StringBuilder(len + 4);
            infoLog.EnsureCapacity(len + 4);

            GL.GetProgramInfoLog(Program, len, out Length, infoLog);
        }
        /// <summary>
        /// Retrives the program info log.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="InfoLogLength"></param>
        /// <returns></returns>
        public static string GetProgramInfoLog(uint Program, int InfoLogLength = -1)
        {
            if (InfoLogLength == -1)
                InfoLogLength = GL.GetProgramiv(Program, GetProgramParameters.InfoLogLength);
            //var len = GL.GetProgramiv(Program, GetProgramParameters.InfoLogLength);

            // for some reason many gl implementation always return 1 here, instead of 0
            if (InfoLogLength > 1)
            {
                var sb = new StringBuilder(InfoLogLength + 4);
                //infoLog.EnsureCapacity(len + 4);

                GL.GetProgramInfoLog(Program, InfoLogLength, out InfoLogLength, sb);

                return sb.ToString();
            }
            else
                return string.Empty;
        }

        /// <summary>
        /// Retrives a preallocated buffer of shader ids attached to program.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="Shaders">a preallocated array of uint to write shader ids to.</param>
        /// <returns>the number of shader ids written to shaders array.</returns>
        [EntryPoint(FunctionName = "glGetAttachedShaders")]
        private static void GetAttachedShaders(uint Program, int MaxCount, out int Count, uint[] Shaders) { throw new NotImplementedException(); }

        /// <summary>
        /// Retrives a preallocated buffer of shader ids attached to program.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="Shaders">a preallocated array of uint to write shader ids to.</param>
        /// <returns>the number of shader ids written to shaders array.</returns>        
        private static int GetAttachedShaders(uint Program, uint[] Shaders)
        {
            int len = 0;
            GetAttachedShaders(Program, Shaders.Length, out len, Shaders);
            return len;
        }
        /// <summary>
        /// Retrives an array of attached shaders id.
        /// Will Query the Program for number of AttachedShaders before retriving them.
        /// </summary>
        /// <param name="Program"></param>
        /// <returns></returns>
        private static uint[] GetAttachedShaders(uint Program)
        {
            var shadercount = GetProgramiv(Program, GetProgramParameters.AttachedShaders);
            var buf = new uint[shadercount];

            GetAttachedShaders(Program, buf.Length, out shadercount, buf);

            return buf;
        }

        /// <summary>
        /// Retrives info about an active uniform.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="index">uniform index.</param>
        /// <param name="bufSize">Size of stringbuilder.</param>
        /// <param name="length">length of name.</param>
        /// <param name="size">number of components. aka vec3 is 3.</param>
        /// <param name="UniformType">Type of uniform.</param>
        /// <param name="Name">Preallocated StringBuilder to receive name.</param>
        [EntryPoint(FunctionName = "glGetActiveUniform")]
        public static void GetActiveUniform(uint Program, uint index, int bufSize, out int length, out int size, out UniformType UniformType, StringBuilder Name){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrives info about an active uniform.
        /// </summary>
        /// <param name="Program">Program to query.</param>
        /// <param name="index">uniform index.</param>
        /// <param name="size">number of components. aka vec3 is 3.</param>
        /// <param name="UniformType">Type of uniform.</param>
        /// <param name="Name">Name.</param>
        /// <param name="MaxUniformNameLength">Size of temp StringBuilder used to retrive name. Default is 64</param>
        public static void GetActiveUniform(uint Program, uint index, out int size, out UniformType UniformType, out string Name, int MaxUniformNameLength = 64)
        {
            //int bufSize, out int length,
            var sb = new StringBuilder(MaxUniformNameLength + 4);
            int len = 0;
            GetActiveUniform(Program, index, sb.Capacity - 4, out len, out size, out UniformType, sb);
            Name = sb.ToString();
        }

        /// <summary>
        /// Returns the name of an active uniform.
        /// </summary>
        /// <param name="Program">Program to query</param>
        /// <param name="UniformIndex">index of uniform.</param>
        /// <param name="bufSize">Size of stringbuilder.</param>
        /// <param name="length">length of name.</param>
        /// <param name="UniformName">Preallocated StringBuilder to receive name.</param>
        [EntryPoint(FunctionName = "glGetActiveUniformName")]
        public static void GetActiveUniformName(uint Program, uint UniformIndex, int BufSize, out int length, StringBuilder UniformName){ throw new NotImplementedException(); }

        /// <summary>
        /// Returns the name of an active uniform.
        /// </summary>
        /// <param name="Program">Program to query</param>
        /// <param name="UniformIndex">index of uniform.</param>
        /// <param name="MaxUniformNameLength">Size of temp StringBuilder used to retrive name. Default is 64</param>
        /// <returns></returns>
        public static string GetActiveUniformName(uint Program, uint UniformIndex, int MaxUniformNameLength = 64)
        {
            //, int BufSize, out int length, StringBuilder UniformName)
            var sb = new StringBuilder(MaxUniformNameLength + 4);
            var len = 0;
            GetActiveUniformName(Program, UniformIndex, MaxUniformNameLength, out len, sb);
            return sb.ToString();
        }


        [EntryPoint(FunctionName = "glGetActiveUniformsiv")]        
        unsafe public static void GetActiveUniformsiv(uint Program, int UniformCount, int* UniformIndices, UniformParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetActiveUniformsiv")]        
        public static void GetActiveUniformsiv(uint Program, int UniformCount, int[] UniformIndices, UniformParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetActiveUniformsiv")]
        public static void GetActiveUniformsiv(uint Program, int UniformCount, ref int UniformIndices, UniformParameters pname, ref int result) { throw new NotImplementedException(); }

        /// <summary>
        /// Queries a bunch of UniformIndices for one parameter name at a time.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="UniformIndices"></param>
        /// <param name="pname"></param>
        /// <param name="result"></param>
        public static void GetActiveUniformsiv(uint Program, int[] UniformIndices, UniformParameters pname, int[] result)
        {
            int UniformCount = Math.Min(UniformIndices.Length, result.Length);
            GetActiveUniformsiv(Program, UniformCount, UniformIndices, pname, result);
        }

        /// <summary>
        /// Retrives the Uniform Index of a named uniform. (must be active).
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetUniformLocation")]
        public static int GetUniformLocation(uint Program, string Name){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetUniformfv")]
        unsafe public static void GetUniformfv(uint Program, int Location, float* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetUniformfv")]
        public static void GetUniformfv(uint Program, int Location, float[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetUniformfv")]
        public static void GetUniformfv(uint Program, int Location, out float result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetUniformfv")]
        public static float GetUniformfv(uint Program, int Location) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetUniformiv")]
        unsafe public static void GetUniformiv(uint Program, int Location, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetUniformiv")]
        public static void GetUniformiv(uint Program, int Location, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetUniformiv")]
        public static void GetUniformiv(uint Program, int Location, out int result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetUniformiv")]
        public static int GetUniformiv(uint Program, int Location) { throw new NotImplementedException(); }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object
        /// glUniform1i and glUniform1iv are the only two functions that may be used to load uniform variables defined as sampler types. Loading samplers with any other function will result in a GL_INVALID_OPERATION error.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="v1"></param>
        [EntryPoint(FunctionName = "glUniform1f")]
        public static void Uniform1f(int location, float v1){ throw new NotImplementedException(); }
        /// <summary>
        /// Specify the value of a uniform variable for the current program object
        /// glUniform1i and glUniform1iv are the only two functions that may be used to load uniform variables defined as sampler types. Loading samplers with any other function will result in a GL_INVALID_OPERATION error.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="v1"></param>
        /// <remarks>
        /// If location is a value other than -1 and it does not represent a valid uniform variable location in the current program object, an error will be generated, and no changes will be made to the uniform variable storage of the current program object. If location is equal to -1, the data passed in will be silently ignored and the specified uniform variable will not be changed.
        /// </remarks>
        [EntryPoint(FunctionName = "glUniform1i")]
        public static void Uniform1i(int location, int v1){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glUniform2f")]
        public static void Uniform2f(int location, float v1, float v2){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glUniform2i")]
        public static void Uniform2i(int location, int v1, int v2){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glUniform3f")]
        public static void Uniform3f(int location, float v1, float v2, float v3){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glUniform3i")]
        public static void Uniform3i(int location, int v1, int v2, int v3){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glUniform4f")]
        public static void Uniform4f(int location, float v1, float v2, float v3, float v4){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glUniform4i")]
        public static void Uniform4i(int location, int v1, int v2, int v3, int v4){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glUniform1fv")]
        unsafe public static void Uniform1fv(int location, int count, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform1fv")]
        public static void Uniform1fv(int location, int count, ref float v) { throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glUniform1fv")]
        //public static void Uniform1fv(int location, int count, float[] v) { throw new NotImplementedException(); }
        public static void Uniform1fv(int location, float[] v, int count = 1, int vindex = 0)
        {
            Uniform1fv(location, count, ref v[vindex]);
        }
        public static void Uniform1fv(int location, ref float v, int count = 1)
        {
            Uniform1fv(location, count, ref v);
        }

        ///// <summary>
        ///// Specify the value of a uniform variable for the current program object
        ///// glUniform1i and glUniform1iv are the only two functions that may be used to load uniform variables defined as sampler types. Loading samplers with any other function will result in a GL_INVALID_OPERATION error.
        ///// </summary>
        ///// <param name="location"></param>
        ///// <param name="v"></param>
        [EntryPoint(FunctionName = "glUniform1iv")]
        unsafe public static void Uniform1iv(int location, int count, int* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform1iv")]
        public static void Uniform1iv(int location, int count, ref int v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform1iv")]
        public static void Uniform1iv(int location, int count, int[] v) { throw new NotImplementedException(); }
        public static void Uniform1iv(int location, int[] v, int count = 1, int vindex = 0)
        {
            Uniform1iv(location, count, ref v[vindex]);
        }
        public static void Uniform1iv(int location, ref int v, int count = 1)
        {
            Uniform1iv(location, count, ref v);
        }


        [EntryPoint(FunctionName = "glUniform2fv")]
        unsafe public static void Uniform2fv(int location, int count, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform2fv")]
        public static void Uniform2fv(int location, int count, ref float v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform2fv")]
        public static void Uniform2fv(int location, int count, float[] v) { throw new NotImplementedException(); }
        public static void Uniform2fv(int location, float[] v, int count = 1, int vindex = 0)
        {
            Uniform2fv(location, count, ref v[vindex]);
        }
        public static void Uniform2fv(int location, ref float v, int count = 1)
        {
            Uniform2fv(location, count, ref v);
        }


        [EntryPoint(FunctionName = "glUniform2iv")]
        unsafe public static void Uniform2iv(int location, int count, int* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform2iv")]
        public static void Uniform2iv(int location, int count, ref int v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform2iv")]
        public static void Uniform2iv(int location, int count, int[] v) { throw new NotImplementedException(); }
        public static void Uniform2iv(int location, int[] v, int count = 1, int vindex = 0)
        {
            Uniform2iv(location, count, ref v[vindex]);
        }
        public static void Uniform2iv(int location, ref int v, int count = 1)
        {
            Uniform2iv(location, count, ref v);
        }


        [EntryPoint(FunctionName = "glUniform3fv")]
        unsafe public static void Uniform3fv(int location, int count, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform3fv")]
        public static void Uniform3fv(int location, int count, ref float v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform3fv")]
        public static void Uniform3fv(int location, int count, float[] v) { throw new NotImplementedException(); }
        public static void Uniform3fv(int location, float[] v, int count = 1, int vindex = 0)
        {
            Uniform3fv(location, count, ref v[vindex]);
        }
        public static void Uniform3fv(int location, ref float v, int count = 1)
        {
            Uniform3fv(location, count, ref v);
        }

        [EntryPoint(FunctionName = "glUniform3iv")]
        unsafe public static void Uniform3iv(int location, int count, int* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform3iv")]
        public static void Uniform3iv(int location, int count, ref int v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform3iv")]
        public static void Uniform3iv(int location, int count, int[] v) { throw new NotImplementedException(); }
        public static void Uniform3iv(int location, int[] v, int count = 1, int vindex = 0)
        {
            Uniform3iv(location, count, ref v[vindex]);
        }
        public static void Uniform3iv(int location, ref int v, int count = 1)
        {
            Uniform3iv(location, count, ref v);
        }


        [EntryPoint(FunctionName = "glUniform4fv")]
        unsafe public static void Uniform4fv(int location, int count, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform4fv")]
        public static void Uniform4fv(int location, int count, ref float v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform4fv")]
        public static void Uniform4fv(int location, int count, float[] v) { throw new NotImplementedException(); }
        public static void Uniform4fv(int location, float[] v, int count = 1, int vindex = 0)
        {
            Uniform4fv(location, count, ref v[vindex]);
        }
        public static void Uniform4fv(int location, ref float v, int count = 1)
        {
            Uniform4fv(location, count, ref v);
        }


        [EntryPoint(FunctionName = "glUniform4iv")]
        unsafe public static void Uniform4iv(int location, int count, int* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform4iv")]
        public static void Uniform4iv(int location, int count, ref int v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform4iv")]
        public static void Uniform4iv(int location, int count, int[] v) { throw new NotImplementedException(); }
        public static void Uniform4iv(int location, int[] v, int count = 1, int vindex = 0)
        {
            Uniform4iv(location, count, ref v[vindex]);
        }
        public static void Uniform4iv(int location, ref int v, int count = 1)
        {
            Uniform4iv(location, count, ref v);
        }


        [EntryPoint(FunctionName = "glUniformMatrix2fv")]
        unsafe public static void UniformMatrix2fv(int location, int count, bool transpose, float* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix2fv")]
        public static void UniformMatrix2fv(int location, int count, bool transpose, ref float matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix2fv")]
        public static void UniformMatrix2fv(int location, int count, bool transpose, float[] matrix) { throw new NotImplementedException(); }
        public static void UniformMatrix2fv(int location, float[] matrix, int count = 1, bool transpose = false, int mindex = 0)
        {
            UniformMatrix2fv(location, count, transpose, ref matrix[mindex]);
        }
        public static void UniformMatrix2fv(int location, ref float matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix2fv(location, count, transpose, ref matrix);
        }


        [EntryPoint(FunctionName = "glUniformMatrix3fv")]
        unsafe public static void UniformMatrix3fv(int location, int count, bool transpose, float* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix3fv")]
        public static void UniformMatrix3fv(int location, int count, bool transpose, ref float matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix3fv")]
        public static void UniformMatrix3fv(int location, int count, bool transpose, float[] matrix) { throw new NotImplementedException(); }
        public static void UniformMatrix3fv(int location, float[] matrix, int count = 1, bool transpose = false, int mindex = 0)
        {
            UniformMatrix3fv(location, count, transpose, ref matrix[mindex]);
        }
        public static void UniformMatrix3fv(int location, ref float matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix3fv(location, count, transpose, ref matrix);
        }

        [EntryPoint(FunctionName = "glUniformMatrix4fv")]
        unsafe public static void UniformMatrix4fv(int location, int count, bool transpose, float* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix4fv")]
        public static void UniformMatrix4fv(int location, int count, bool transpose, ref float matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix4fv")]
        public static void UniformMatrix4fv(int location, int count, bool transpose, float[] matrix) { throw new NotImplementedException(); }
        public static void UniformMatrix4fv(int location, float[] matrix, int count = 1, bool transpose = false, int mindex = 0)
        {
            UniformMatrix4fv(location, count, transpose, ref matrix[mindex]);
        }
        public static void UniformMatrix4fv(int location, ref float matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix4fv(location, count, transpose, ref matrix);
        }


        [EntryPoint(FunctionName = "glEnableVertexAttribArray")]
        public static void EnableVertexAttribArray(uint index){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glDisableVertexAttribArray")]
        public static void DisableVertexAttribArray(uint index){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glVertexAttribPointer")]
        public static void VertexAttribPointer(uint index, int Size, VertexAttribFormat type, bool normalized, int stride, IntPtr ptr){ throw new NotImplementedException(); }
        public static void VertexAttribPointer(uint index, int Size, VertexAttribFormat type, int stride, IntPtr ptr, bool normalized = false)
        {
            VertexAttribPointer(index, Size, type, normalized, stride, ptr);
        }
        public static void VertexAttribPointer(uint index, int Size, VertexAttribFormat type, int stride, long offset, bool normalized = false)
        {
            VertexAttribPointer(index, Size, type, normalized, stride, (IntPtr)offset);
        }

        [EntryPoint(FunctionName = "glGetVertexAttribPointerv")]
        public static void GetVertexAttribPointerv(uint index, VertexAttribPointerParameters pname, out IntPtr ptr){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glBindAttribLocation")]
        public static void BindAttribLocation(uint Program, uint aIndex, string Name){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetAttribLocation")]
        public static int GetAttribLocation(uint Program, string Name){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glGetActiveAttrib")]
        public static void GetActiveAttrib(uint Program, uint index, int bufSize, out int Length, out int Size, out AttributeType type, StringBuilder name){ throw new NotImplementedException(); }

        /// <summary>
        /// Queries a program for attribute info.
        /// </summary>
        /// <param name="Program">Program to query</param>
        /// <param name="index">attribute index.</param>
        /// <param name="Size">number of components in attribyte aka vec3 = 3</param>
        /// <param name="type">Attribute type.</param>
        /// <param name="name">Name of attribute</param>
        /// <param name="MaxAttributeNameLength">Size of temp Stringbuilder used to retrive name.</param>
        public static void GetActiveAttrib(uint Program, uint index, out int Size, out AttributeType type, out string name, int MaxAttributeNameLength = 64)
        {           
            var sb = new StringBuilder(MaxAttributeNameLength + 4);
            int len = 0;
            GetActiveAttrib(Program, index, MaxAttributeNameLength, out len, out Size, out type, sb);
            name = sb.ToString();
        }

        [EntryPoint(FunctionName = "glGetVertexAttribdv")]
        unsafe public static void GetVertexAttribdv(uint index, VertexAttribParameters pname, double* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribdv")]
        public static void GetVertexAttribdv(uint index, VertexAttribParameters pname, double[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribdv")]
        public static void GetVertexAttribdv(uint index, VertexAttribParameters pname, out double result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribdv")]
        public static double GetVertexAttribdv(uint index, VertexAttribParameters pname) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetVertexAttribfv")]
        unsafe public static void GetVertexAttribfv(uint index, VertexAttribParameters pname, float* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribfv")]
        public static void GetVertexAttribfv(uint index, VertexAttribParameters pname, float[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribfv")]
        public static void GetVertexAttribfv(uint index, VertexAttribParameters pname, ref float result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribfv")]
        public static float GetVertexAttribfv(uint index, VertexAttribParameters pname) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetVertexAttribiv")]
        unsafe public static void GetVertexAttribiv(uint index, VertexAttribParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribiv")]
        public static void GetVertexAttribiv(uint index, VertexAttribParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribiv")]
        public static void GetVertexAttribiv(uint index, VertexAttribParameters pname, ref int result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribiv")]
        public static int GetVertexAttribiv(uint index, VertexAttribParameters pname) { throw new NotImplementedException(); }

        /* 36 functions ignored.
        public delegate void delVertexAttrib1f(uint index, float v1);
        public delegate void delVertexAttrib1d(uint index, double v1);
        public delegate void delVertexAttrib1s(uint index, short v1);

        public delegate void delVertexAttrib2f(uint index, float v1, float v2);
        public delegate void delVertexAttrib2d(uint index, double v1, double v2);
        public delegate void delVertexAttrib2s(uint index, short v1, short v2);

        public delegate void delVertexAttrib3f(uint index, float v1, float v2, float v3);
        public delegate void delVertexAttrib3d(uint index, double v1, double v2, double v3);
        public delegate void delVertexAttrib3s(uint index, short v1, short v2, short v3);

        public delegate void delVertexAttrib4f(uint index, float v1, float v2, float v3, float v4);
        public delegate void delVertexAttrib4d(uint index, double v1, double v2, double v3, double v4);
        public delegate void delVertexAttrib4s(uint index, short v1, short v2, short v3, short v4);

        public delegate void delVertexAttrib4Nub(uint index, byte v1, byte v2, byte v3, byte v4);

        public delegate void delVertexAttrib1fv(uint index, float[] v);
        public delegate void delVertexAttrib1dv(uint index, double[] v);
        public delegate void delVertexAttrib1sv(uint index, short[] v);

        public delegate void delVertexAttrib2fv(uint index, float[] v);
        public delegate void delVertexAttrib2dv(uint index, double[] v);
        public delegate void delVertexAttrib2sv(uint index, short[] v);

        public delegate void delVertexAttrib3fv(uint index, float[] v);
        public delegate void delVertexAttrib3dv(uint index, double[] v);
        public delegate void delVertexAttrib3sv(uint index, short[] v);

        public delegate void delVertexAttrib4fv(uint index, float[] v);
        public delegate void delVertexAttrib4dv(uint index, double[] v);
        public delegate void delVertexAttrib4sv(uint index, short[] v);

        public delegate void delVertexAttrib4iv(uint index, int[] v);
        public delegate void delVertexAttrib4bv(uint index, sbyte[] v);
        public delegate void delVertexAttrib4ubv(uint index, byte[] v);
        public delegate void delVertexAttrib4usv(uint index, ushort[] v);
        public delegate void delVertexAttrib4uiv(uint index, uint[] v);

        public delegate void delVertexAttrib4Nbv(uint index, sbyte[] v);
        public delegate void delVertexAttrib4Nsv(uint index, short[] v);
        public delegate void delVertexAttrib4Niv(uint index, int[] v);
        public delegate void delVertexAttrib4Nubv(uint index, byte[] v);
        public delegate void delVertexAttrib4Nusv(uint index, ushort[] v);
        public delegate void delVertexAttrib4Nuiv(uint index, uint[] v);
        */


        #endregion

        #region Public Helper Functions

        #endregion

    }
}
