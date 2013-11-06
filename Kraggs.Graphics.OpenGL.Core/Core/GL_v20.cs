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

            public delegate void delBlendEquationSeparate(BlendEquationSeparateRGB modeRGB, BlendEquationSeparateAlpha modeAlpha);
            public delegate void delDrawBuffers(int number, ref DrawBufferTarget bufs);

            public delegate uint delCreateShader(ShaderType type);
            public delegate void delDeleteShader(uint Shader);
            public delegate bool delIsShader(uint Shader);
            //public delegate void delShaderSource(uint Shader, int Count, string[] source, int[] Lengths);
            public delegate void delShaderSource(uint Shader, int Count, ref string source, ref int Lengths);
            public delegate void delCompileShader(uint Shader);
            public delegate void delGetShaderiv(uint Shader, ShaderParameters pname, ref int @params);
            public delegate void delGetShaderSource(uint Shader, int BufSize, out int Length, StringBuilder source);
            public delegate void delGetShaderInfoLog(uint Shader, int BufSize, out int Length, StringBuilder infoLog);

            public delegate uint delCreateProgram();
            public delegate void delDeleteProgram(uint Program);
            public delegate bool delIsProgram(uint Program);
            public delegate void delAttachShader(uint Program, uint Shader);
            public delegate void delDetachShader(uint Program, uint Shader);
            public delegate void delLinkProgram(uint Program);
            public delegate void delValidateProgram(uint Program);
            public delegate void delUseProgram(uint Program);

            public delegate void delGetProgramiv(uint Program, GetProgramParameters pname, ref int @params);
            public delegate void delGetProgramInfoLog(uint Program, int BufSize, out int Length, StringBuilder infoLog);
            public delegate void delGetAttachedShaders(uint Program, int MaxCount, out int Count, ref uint Shaders);
            public delegate void delGetActiveUniform(uint Program, uint index, int bufSize, out int length, out int size, out UniformType UniformType, StringBuilder Name);
            public delegate void delGetActiveUniformName(uint Program, uint UniformIndex, int BufSize, out int length, StringBuilder UniformName);
            public delegate void delGetActiveUniformsiv(uint Program, int UniformCount, ref int UniformIndices, UniformParameters pname, ref int @params);
            public delegate int delGetUniformLocation(uint Program, string Name);
            public delegate void delGetUniformfv(uint Program, int Location, ref float @params);
            public delegate void delGetUniformiv(uint Program, int Location, ref int @params);

            public delegate void delUniform1f(int location, float v1);
            public delegate void delUniform1i(int location, int v1);

            public delegate void delUniform2f(int location, float v1, float v2);
            public delegate void delUniform2i(int location, int v1, int v2);

            public delegate void delUniform3f(int location, float v1, float v2, float v3);
            public delegate void delUniform3i(int location, int v1, int v2, int v3);

            public delegate void delUniform4f(int location, float v1, float v2, float v3, float v4);
            public delegate void delUniform4i(int location, int v1, int v2, int v3, int v4);

            public delegate void delUniform1fv(int location, int count, ref float v);
            public delegate void delUniform1iv(int location, int count, ref int v);

            public delegate void delUniform2fv(int location, int count, ref float v);
            public delegate void delUniform2iv(int location, int count, ref int v);

            public delegate void delUniform3fv(int location, int count, ref float v);
            public delegate void delUniform3iv(int location, int count, ref int v);

            public delegate void delUniform4fv(int location, int count, ref float v);
            public delegate void delUniform4iv(int location, int count, ref int v);

            public delegate void delUniformMatrix2fv(int location, int count, bool transpose, ref float matrix);
            public delegate void delUniformMatrix3fv(int location, int count, bool transpose, ref float matrix);
            public delegate void delUniformMatrix4fv(int location, int count, bool transpose, ref float matrix);

            public delegate void delEnableVertexAttribArray(uint index);
            public delegate void delDisableVertexAttribArray(uint index);

            public delegate void delVertexAttribPointer(uint index, int Size, VertexAttribFormat type, bool normalized, int stride, IntPtr ptr);
            public delegate void delGetVertexAttribPointerv(uint index, VertexAttribPointerParameters pname, out IntPtr ptr);

            public delegate void delBindAttribLocation(uint Program, uint aIndex, string Name);
            public delegate int delGetAttribLocation(uint Program, string Name);

            public delegate void delGetActiveAttrib(uint Program, uint index, int bufSize, out int Length, out int Size, out AttributeType type, StringBuilder name);
            

            public delegate void delGetVertexAttribdv(uint index, VertexAttribParameters pname, ref double @params);
            public delegate void delGetVertexAttribfv(uint index, VertexAttribParameters pname, ref float @params);
            public delegate void delGetVertexAttribiv(uint index, VertexAttribParameters pname, ref int @params);

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

            #region GL Fields

            public static delBlendEquationSeparate glBlendEquationSeparate;
            public static delDrawBuffers glDrawBuffers;

            public static delCreateShader glCreateShader;
            public static delDeleteShader glDeleteShader;
            public static delIsShader glIsShader;
            public static delShaderSource glShaderSource;
            public static delCompileShader glCompileShader;
            public static delGetShaderiv glGetShaderiv;
            public static delGetShaderSource glGetShaderSource;
            public static delGetShaderInfoLog glGetShaderInfoLog;

            public static delCreateProgram glCreateProgram;
            public static delDeleteProgram glDeleteProgram;
            public static delIsProgram glIsProgram;
            public static delAttachShader glAttachShader;
            public static delDetachShader glDetachShader;
            public static delLinkProgram glLinkProgram;
            public static delValidateProgram glValidateProgram;
            public static delUseProgram glUseProgram;

            public static delGetProgramiv glGetProgramiv;
            public static delGetProgramInfoLog glGetProgramInfoLog;
            public static delGetAttachedShaders glGetAttachedShaders;
            public static delGetActiveUniformsiv glGetActiveUniformsiv;
            public static delGetActiveUniformName glGetActiveUniformName;
            public static delGetActiveUniform glGetActiveUniform;
            public static delGetUniformLocation glGetUniformLocation;
            public static delGetUniformfv glGetUniformfv;
            public static delGetUniformiv glGetUniformiv;

            public static delUniform1f glUniform1f;
            public static delUniform1i glUniform1i;

            public static delUniform2f glUniform2f;
            public static delUniform2i glUniform2i;

            public static delUniform3f glUniform3f;
            public static delUniform3i glUniform3i;

            public static delUniform4f glUniform4f;
            public static delUniform4i glUniform4i;

            public static delUniform1fv glUniform1fv;
            public static delUniform1iv glUniform1iv;

            public static delUniform2fv glUniform2fv;
            public static delUniform2iv glUniform2iv;

            public static delUniform3fv glUniform3fv;
            public static delUniform3iv glUniform3iv;

            public static delUniform4fv glUniform4fv;
            public static delUniform4iv glUniform4iv;

            public static delUniformMatrix2fv glUniformMatrix2fv;
            public static delUniformMatrix3fv glUniformMatrix3fv;
            public static delUniformMatrix4fv glUniformMatrix4fv;


            public static delEnableVertexAttribArray glEnableVertexAttribArray;
            public static delDisableVertexAttribArray glDisableVertexAttribArray;

            public static delBindAttribLocation glBindAttribLocation;
            public static delGetAttribLocation glGetAttribLocation;

            public static delGetActiveAttrib glGetActiveAttrib;

            public static delVertexAttribPointer glVertexAttribPointer;
            public static delGetVertexAttribPointerv glGetVertexAttribPointerv;            
            
            public static delGetVertexAttribdv glGetVertexAttribdv;
            public static delGetVertexAttribfv glGetVertexAttribfv;
            public static delGetVertexAttribiv glGetVertexAttribiv;           

            
            /* 36 functions ignored.
            public static delVertexAttrib1f glVertexAttrib1f;
            public static delVertexAttrib1d glVertexAttrib1d;
            public static delVertexAttrib1s glVertexAttrib1s;

            public static delVertexAttrib2f glVertexAttrib2f;
            public static delVertexAttrib2d glVertexAttrib2d;
            public static delVertexAttrib2s glVertexAttrib2s;

            public static delVertexAttrib3f glVertexAttrib3f;
            public static delVertexAttrib3d glVertexAttrib3d;
            public static delVertexAttrib3s glVertexAttrib3s;

            public static delVertexAttrib4f glVertexAttrib4f;
            public static delVertexAttrib4d glVertexAttrib4d;
            public static delVertexAttrib4s glVertexAttrib4s;

            public static delVertexAttrib4Nub glVertexAttrib4Nub;

            public static delVertexAttrib1fv glVertexAttrib1fv;
            public static delVertexAttrib1dv glVertexAttrib1dv;
            public static delVertexAttrib1sv glVertexAttrib1sv;

            public static delVertexAttrib2fv glVertexAttrib2fv;
            public static delVertexAttrib2dv glVertexAttrib2dv;
            public static delVertexAttrib2sv glVertexAttrib2sv;

            public static delVertexAttrib3fv glVertexAttrib3fv;
            public static delVertexAttrib3dv glVertexAttrib3dv;
            public static delVertexAttrib3sv glVertexAttrib3sv;

            public static delVertexAttrib4fv glVertexAttrib4fv;
            public static delVertexAttrib4dv glVertexAttrib4dv;
            public static delVertexAttrib4sv glVertexAttrib4sv;

            public static delVertexAttrib4iv glVertexAttrib4iv;
            public static delVertexAttrib4bv glVertexAttrib4bv;
            public static delVertexAttrib4ubv glVertexAttrib4ubv;
            public static delVertexAttrib4usv glVertexAttrib4usv;
            public static delVertexAttrib4uiv glVertexAttrib4uiv;

            public static delVertexAttrib4Nbv glVertexAttrib4Nbv;
            public static delVertexAttrib4Nsv glVertexAttrib4Nsv;
            public static delVertexAttrib4Niv glVertexAttrib4Niv;
            public static delVertexAttrib4Nubv glVertexAttrib4Nubv;
            public static delVertexAttrib4Nusv glVertexAttrib4Nusv;
            public static delVertexAttrib4Nuiv glVertexAttrib4Nuiv;
            */           

            #endregion
        }

        #endregion

        #region Public functions.

        /// <summary>
        /// Sets up separate blend equation.
        /// </summary>
        /// <param name="modeRGB"></param>
        /// <param name="modeAlpha"></param>
        public static void BlendEquationSeparate(BlendEquationSeparateRGB modeRGB, BlendEquationSeparateAlpha modeAlpha)
        {
            Delegates.glBlendEquationSeparate(modeRGB, modeAlpha);
        }

        /// <summary>
        /// Sets the drawbuffers to be used.
        /// </summary>
        /// <param name="bufs">An array of drawbuffer targets to use.</param>
        public static void DrawBuffers(DrawBufferTarget[] bufs)
        {
            Delegates.glDrawBuffers(bufs.Length, ref bufs[0]);
        }

        /// <summary>
        /// Creates a new shader id with specified ShaderType.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static uint CreateShader(ShaderType type)
        {
            return Delegates.glCreateShader(type);
        }
        /// <summary>
        /// Marks a shader id for deletion.
        /// if no shader program has this id attached, its delete immidiatly, otherwise it will be deleted at a later time.
        /// </summary>
        /// <param name="Shader"></param>
        public static void DeleteShader(uint Shader)
        {
            Delegates.glDeleteShader(Shader);
        }
        /// <summary>
        /// Returns true if this id is a valid shader id.
        /// </summary>
        /// <param name="Shader"></param>
        /// <returns></returns>
        public static bool IsShader(uint Shader)
        {
            return Delegates.glIsShader(Shader);
        }
        /// <summary>
        /// Uploads the shader source to specified shader.
        /// </summary>
        /// <param name="Shader">Shader id to upload code to.</param>
        /// <param name="Count">The size of the arrays with source code and source code lengths.</param>
        /// <param name="source">array of string with the source code to upload.</param>
        /// <param name="Lengths">array of ints with lengths of the strings of source code.</param>
        public static void ShaderSource(uint Shader, int Count, string[] source, int[] Lengths)
        {
            //Delegates.glShaderSource(Shader, Count, source, Lengths);
            Delegates.glShaderSource(Shader, Count, ref source[0], ref Lengths[0]);
        }
        public static void ShaderSource(uint Shader, string[] source)
        {
            int[] arrLength = new int[source.Length];
            for (int i = 0; i < arrLength.Length; i++)
                arrLength[i] = source[i].Length;

            Delegates.glShaderSource(Shader, source.Length, ref source[0], ref arrLength[0]);
        }

        /// <summary>
        /// Uploads the shader source to the specified shader.
        /// </summary>
        /// <param name="Shader">Shader to upload to.</param>
        /// <param name="source">the source code to upload.</param>
        public static void ShaderSource(uint Shader, string source)
        {
            //Delegates.glShaderSource(Shader, 1, new string[] { source }, new int[] { source.Length });
            int len = source.Length;
            Delegates.glShaderSource(Shader, 1, ref source, ref len);
        }
        /// <summary>
        /// Compiles the shader.
        /// Note: Most OpenGL implementations asynchronosly compiles shaders.
        /// To prevent stalling running thread waiting for compile result, dont query the shader for a while.
        /// </summary>
        /// <param name="Shader"></param>
        public static void CompileShader(uint Shader)
        {
            Delegates.glCompileShader(Shader);
        }
        /// <summary>
        /// Retrive shader parameters.
        /// </summary>
        /// <param name="Shader"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        public static void GetShaderiv(uint Shader, ShaderParameters pname, int[] @params)
        {
            Delegates.glGetShaderiv(Shader, pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives shader parameters.
        /// </summary>
        /// <param name="Shader"></param>
        /// <param name="pname"></param>
        /// <returns></returns>
        public static int GetShaderiv(uint Shader, ShaderParameters pname)
        {
            int tmp = 0;
            Delegates.glGetShaderiv(Shader, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Retrives the shader code of a shader object.
        /// </summary>
        /// <param name="Shader"></param>
        /// <param name="BufSize"></param>
        /// <param name="Length"></param>
        /// <param name="source"></param>
        public static void GetShaderSource(uint Shader, int BufSize, out int Length, StringBuilder source)
        {
            Delegates.glGetShaderSource(Shader, BufSize, out Length, source);
        }
        /// <summary>
        /// Retrives the shader code from a shader id.
        /// </summary>
        /// <param name="Shader">Shader id to get shader code from.</param>
        /// <returns>The shader code.</returns>
        public static string GetShaderSource(uint Shader)
        {
            var sourcelen = GetShaderiv(Shader, ShaderParameters.ShaderSourceLength);
            var sb = new StringBuilder(sourcelen + 4);

            Delegates.glGetShaderSource(Shader, sb.Capacity - 2, out sourcelen, sb);

            return sb.ToString();
        }
        /// <summary>
        /// Retrives the shader info log.
        /// </summary>
        /// <param name="Shader"></param>
        /// <param name="BufSize"></param>
        /// <param name="Length"></param>
        /// <param name="infoLog"></param>
        public static void GetShaderInfoLog(uint Shader, int BufSize, out int Length, StringBuilder infoLog)
        {
            Delegates.glGetShaderInfoLog(Shader, BufSize, out Length, infoLog);
        }

        /// <summary>
        /// Retrives the shader info log.
        /// </summary>
        /// <param name="Shader"></param>
        /// <param name="InfoLogLength">When you already know the info log length add it here to prevent this function for retriving it again.</param>
        /// <returns>Retrives shader info log.</returns>
        public static string GetShaderInfoLog(uint Shader, int InfoLogLength = -1)
        {
            if(InfoLogLength == -1)
                InfoLogLength = GetShaderiv(Shader, ShaderParameters.InfoLogLength);

            if (InfoLogLength > 1)
            {
                var sb = new StringBuilder(InfoLogLength + 4);
                Delegates.glGetShaderInfoLog(Shader, sb.Capacity - 2, out InfoLogLength, sb);

                return sb.ToString();
            }
            else
                return string.Empty;
        }

        /// <summary>
        /// Creates a shader program.
        /// </summary>
        /// <returns></returns>
        public static uint CreateProgram()
        {
            return Delegates.glCreateProgram();
        }
        /// <summary>
        /// Deletes a shader program.
        /// </summary>
        /// <param name="Program"></param>
        public static void DeleteProgram(uint Program)
        {
            Delegates.glDeleteProgram(Program);
        }
        /// <summary>
        /// Is this a valid shader program?
        /// </summary>
        /// <param name="Program"></param>
        /// <returns></returns>
        public static bool IsProgram(uint Program)
        {
            return Delegates.glIsProgram(Program);
        }
        /// <summary>
        /// Attaches a shader to a program.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="Shader"></param>
        public static void AttachShader(uint Program, uint Shader)
        {
            Delegates.glAttachShader(Program, Shader);
        }
        /// <summary>
        /// Detaches a shader from a program.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="Shader"></param>
        public static void DetachShader(uint Program, uint Shader)
        {
            Delegates.glDetachShader(Program, Shader);
        }
        /// <summary>
        /// Links the shaders in a program together.
        /// </summary>
        /// <param name="Program"></param>
        public static void LinkProgram(uint Program)
        {
            Delegates.glLinkProgram(Program);
        }
        /// <summary>
        /// Validates a program.
        /// </summary>
        /// <param name="Program"></param>
        public static void ValidateProgram(uint Program)
        {
            Delegates.glValidateProgram(Program);
        }
        /// <summary>
        /// Binds the specified program id as current program.
        /// Call with program=0 to unbind any program.
        /// </summary>
        /// <param name="Program"></param>
        public static void UseProgram(uint Program)
        {
            Delegates.glUseProgram(Program);
        }

        /// <summary>
        /// Retrives a program parameter.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="pname"></param>
        /// <param name="params"></param>
        public static void GetProgramiv(uint Program, GetProgramParameters pname, int[] @params)
        {
            Delegates.glGetProgramiv(Program, pname, ref @params[0]);
        }
        public static int GetProgramiv(uint Program, GetProgramParameters pname)
        {
            int tmp = 0;
            Delegates.glGetProgramiv(Program, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Retrives the program info log.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="BufSize"></param>
        /// <param name="Length"></param>
        /// <param name="infoLog"></param>
        public static void GetProgramInfoLog(uint Program, int BufSize, out int Length, StringBuilder infoLog)
        {
            Delegates.glGetProgramInfoLog(Program, BufSize, out Length, infoLog);
        }

        /// <summary>
        /// Retrives the program info log.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="InfoLogLength">If not -1, assumes this is the length of the infolog, otherwise it calls opengl to retrive it.</param>
        /// <returns></returns>
        public static string GetProgramInfoLog(uint Program, int InfoLogLength = -1)
        {
            if(InfoLogLength > -1)
                InfoLogLength = GetProgramiv(Program, GetProgramParameters.InfoLogLength);

            if (InfoLogLength > 1)
            {
                var sb = new StringBuilder(InfoLogLength + 4);
                Delegates.glGetProgramInfoLog(Program, sb.Capacity - 2, out InfoLogLength, sb);

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
        public static int GetAttachedShaders(uint Program, uint[] Shaders)
        {
            int len = 0;
            Delegates.glGetAttachedShaders(Program, Shaders.Length, out len, ref Shaders[0]);
            return len;
        }
        public static uint[] GetAttachedShaders(uint Program)
        {
            var shadercount = GetProgramiv(Program, GetProgramParameters.AttachedShaders);
            var buf = new uint[shadercount];

            Delegates.glGetAttachedShaders(Program, buf.Length, out shadercount, ref buf[0]);

            return buf;
        }

        public static void GetActiveUniform(uint Program, uint index, int bufSize, out int length, out int size, out UniformType UniformType, StringBuilder Name)
        {
            Delegates.glGetActiveUniform(Program, index, bufSize, out length, out size, out UniformType, Name);
        }
        public static void GetActiveUniform(uint Program, uint index, out int size, out UniformType UniformType, out string Name)
        {
            var maxlen = GetProgramiv(Program, GetProgramParameters.ActiveUniformMaxLength);
            GetActiveUniform(Program, index, out size, out UniformType, out Name, maxlen);
        }
        public static void GetActiveUniform(uint Program, uint index, out int size, out UniformType UniformType, out string Name, int MaxUniformNameLength = 64)
        {
            //if (MaxAttributeNameLength > 0)
            {
                var sb = new StringBuilder(MaxUniformNameLength + 4);

                Delegates.glGetActiveUniform(Program, index, sb.Capacity - 2, out MaxUniformNameLength, out size, out UniformType, sb);

                Name = sb.ToString();
            }
        }

        public static void GetActiveUniformName(uint Program, uint UniformIndex, int BufSize, out int length, StringBuilder UniformName)
        {
            Delegates.glGetActiveUniformName(Program, UniformIndex, BufSize, out length, UniformName);
        }

        /// <summary>
        /// 
        /// Note: Queries the program for max uniform name length. Everytime!
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="UniformIndex"></param>
        /// <returns></returns>
        public static string GetActiveUniformName(uint Program, uint UniformIndex)
        {
            var maxlen = GetProgramiv(Program, GetProgramParameters.ActiveUniformMaxLength);
            return GetActiveUniformName(Program, UniformIndex, maxlen);
        }

        /// <summary>
        /// Retrives the name of the active uniform. Also avoids the opengl query to get max uniform name length.
        /// </summary>
        /// <param name="Program"></param>
        /// <param name="UniformIndex"></param>
        /// <param name="MaxUniformNameLength"></param>
        /// <returns></returns>
        public static string GetActiveUniformName(uint Program, uint UniformIndex, int MaxUniformNameLength = 64)
        {
            if (MaxUniformNameLength > 0)
            {
                var sb = new StringBuilder(MaxUniformNameLength + 4);
                Delegates.glGetActiveUniformName(Program, UniformIndex, sb.Capacity - 2, out MaxUniformNameLength, sb);

                return sb.ToString();
            }
            else
                return string.Empty;
        }

        public static void GetActiveUniformsiv(uint Program, int UniformCount, int[] UniformIndices, UniformParameters pname, int[] @params)
        {
            Delegates.glGetActiveUniformsiv(Program, UniformCount, ref UniformIndices[0], pname, ref @params[0]);
        }

        public static int GetUniformLocation(uint Program, string Name)
        {
            return Delegates.glGetUniformLocation(Program, Name);
        }
        public static void GetUniformfv(uint Program, int Location, float[] @params)
        {
            Delegates.glGetUniformfv(Program, Location, ref @params[0]);
        }
        public static float GetUniformfv(uint Program, int Location)
        {
            float tmp = 0.0f;
            Delegates.glGetUniformfv(Program, Location, ref tmp);
            return tmp;
        }
        public static void GetUniformiv(uint Program, int Location, int[] @params)
        {
            Delegates.glGetUniformiv(Program, Location, ref @params[0]);
        }
        public static int GetUniformiv(uint Program, int Location)
        {
            int tmp = 0;
            Delegates.glGetUniformiv(Program, Location, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object
        /// glUniform1i and glUniform1iv are the only two functions that may be used to load uniform variables defined as sampler types. Loading samplers with any other function will result in a GL_INVALID_OPERATION error.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="v1"></param>
        public static void Uniform1f(int location, float v1)
        {
            Delegates.glUniform1f(location, v1);
        }
        /// <summary>
        /// Specify the value of a uniform variable for the current program object
        /// glUniform1i and glUniform1iv are the only two functions that may be used to load uniform variables defined as sampler types. Loading samplers with any other function will result in a GL_INVALID_OPERATION error.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="v1"></param>
        /// <remarks>
        /// If location is a value other than -1 and it does not represent a valid uniform variable location in the current program object, an error will be generated, and no changes will be made to the uniform variable storage of the current program object. If location is equal to -1, the data passed in will be silently ignored and the specified uniform variable will not be changed.
        /// </remarks>
        public static void Uniform1i(int location, int v1)
        {
            Delegates.glUniform1i(location, v1);
        }

        public static void Uniform2f(int location, float v1, float v2)
        {
            Delegates.glUniform2f(location, v1, v2);
        }
        public static void Uniform2i(int location, int v1, int v2)
        {
            Delegates.glUniform2i(location, v1, v2);
        }

        public static void Uniform3f(int location, float v1, float v2, float v3)
        {
            Delegates.glUniform3f(location, v1, v2, v3);
        }
        public static void Uniform3i(int location, int v1, int v2, int v3)
        {
            Delegates.glUniform3i(location, v1, v2, v3);
        }

        public static void Uniform4f(int location, float v1, float v2, float v3, float v4)
        {
            Delegates.glUniform4f(location, v1, v2, v3, v4);
        }
        public static void Uniform4i(int location, int v1, int v2, int v3, int v4)
        {
            Delegates.glUniform4i(location, v1, v2, v3, v4);
        }

        public static void Uniform1fv(int location, ref float v, int count = 1)
        {
            Delegates.glUniform1fv(location, count, ref v);
        }
        public static void Uniform1fv(int location, float[] v, int count = 1)
        {
            Delegates.glUniform1fv(location, count, ref v[0]);
        }

        /// <summary>
        /// Specify the value of a uniform variable for the current program object
        /// glUniform1i and glUniform1iv are the only two functions that may be used to load uniform variables defined as sampler types. Loading samplers with any other function will result in a GL_INVALID_OPERATION error.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="v"></param>
        public static void Uniform1iv(int location, ref int v, int count = 1)
        {
            Delegates.glUniform1iv(location, count, ref v);
        }
        /// <summary>
        /// Specify the value of a uniform variable for the current program object
        /// glUniform1i and glUniform1iv are the only two functions that may be used to load uniform variables defined as sampler types. Loading samplers with any other function will result in a GL_INVALID_OPERATION error.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="v"></param>
        public static void Uniform1iv(int location, int[] v)
        {
            Delegates.glUniform1iv(location, v.Length, ref v[0]);
        }

        public static void Uniform2fv(int location, ref float v, int count = 1)
        {
            Delegates.glUniform2fv(location, count, ref v);
        }
        public static void Uniform2fv(int location, float[] v)
        {
            Delegates.glUniform2fv(location, v.Length / 2, ref v[0]);
        }

        public static void Uniform2iv(int location, ref int v, int count = 1)
        {
            Delegates.glUniform2iv(location, count, ref v);
        }
        public static void Uniform2iv(int location, int[] v)
        {
            Delegates.glUniform2iv(location, v.Length / 2, ref v[0]);
        }

        public static void Uniform3fv(int location, ref float v, int count = 1)
        {
            Delegates.glUniform3fv(location, count, ref v);
        }
        public static void Uniform3fv(int location, float[] v)
        {
            Delegates.glUniform3fv(location, v.Length / 3, ref v[0]);
        }

        public static void Uniform3iv(int location, ref int v, int count = 1)
        {
            Delegates.glUniform3iv(location, count, ref v);
        }
        public static void Uniform3iv(int location, int[] v)
        {
            Delegates.glUniform3iv(location, v.Length / 3, ref v[0]);
        }

        public static void Uniform4fv(int location, ref float v, int count = 1)
        {
            Delegates.glUniform4fv(location, count, ref v);
        }
        public static void Uniform4fv(int location, float[] v)
        {
            Delegates.glUniform4fv(location, v.Length / 4, ref v[0]);
        }

        public static void Uniform4iv(int location, ref int v, int count = 1)
        {
            Delegates.glUniform4iv(location, count, ref v);
        }
        public static void Uniform4iv(int location, int[] v)
        {
            Delegates.glUniform4iv(location, v.Length / 4, ref v[0]);
        }

        //public static void UniformMatrix2fv(int location, int count, bool transpose, ref float matrix)
        //{
        //    Delegates.glUniformMatrix2fv(location, count, transpose, ref matrix);
        //}
        public static void UniformMatrix2fv(int location, ref float matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix2fv(location, count, transpose, ref matrix);
        }

        //public static void UniformMatrix3fv(int location, int count, bool transpose, ref float matrix)
        //{
        //    Delegates.glUniformMatrix3fv(location, count, transpose, ref matrix);
        //}
        public static void UniformMatrix3fv(int location, ref float matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix3fv(location, count, transpose, ref matrix);
        }
        //public static void UniformMatrix4fv(int location, int count, bool transpose, ref float matrix)
        //{
        //    Delegates.glUniformMatrix4fv(location, count, transpose, ref matrix);
        //}
        public static void UniformMatrix4fv(int location, ref float matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix4fv(location, count, transpose, ref matrix);
        }

        /// <summary>
        /// Enables the vertex attribute for currently bound VertexArrayObject.
        /// </summary>
        /// <param name="index"></param>
        public static void EnableVertexAttribArray(uint index)
        {
            Delegates.glEnableVertexAttribArray(index);
        }
        /// <summary>
        /// Disables the vertex attribute for currently bound VertexArrayObject.
        /// </summary>
        /// <param name="index"></param>
        public static void DisableVertexAttribArray(uint index)
        {
            Delegates.glDisableVertexAttribArray(index);
        }

        /// <summary>
        /// Defines the vertex specification for an Attribute Index on the current bound VertexArrayObject.
        /// </summary>
        /// <param name="index">Attribute Index to specify vertex data for.</param>
        /// <param name="Size">Number of components of type. or BGRA if ARB_vertex_array_bgra/gl3.2 is supported.</param>
        /// <param name="type">The opengl base type of data to set.</param>
        /// <param name="normalized">Is data normalized</param>
        /// <param name="stride">The stride between vertices.</param>
        /// <param name="offset">offset in current bound buffer object to start sourcing at.</param>
        public static void VertexAttribPointer(uint index, int Size, VertexAttribFormat type, int stride, long offset, bool normalized = false)
        {
            Delegates.glVertexAttribPointer(index, Size, type, normalized, stride, (IntPtr)offset);
        }

        /// <summary>
        /// Binds a Named Attribute to the specified Index.
        /// Note that you need to relink program for this to take effect.
        /// </summary>
        /// <param name="Program">Program to set.</param>
        /// <param name="aIndex">Attribute Index to bind to.</param>
        /// <param name="Name">The name of the attribute to specify index for.</param>
        public static void BindAttribLocation(uint Program, uint aIndex, string Name)
        {
            Delegates.glBindAttribLocation(Program, aIndex, Name);
        }
        /// <summary>
        /// Returns the Attribute index of a named Attribute
        /// </summary>
        /// <param name="Program">The program to query.</param>
        /// <param name="Name">The name of the attribute to retrive index for.</param>
        /// <returns></returns>
        public static int GetAttribLocation(uint Program, string Name)
        {
            return Delegates.glGetAttribLocation(Program, Name);
        }

        public static void GetActiveAttrib(uint Program, uint index, int bufSize, out int Length, out int Size, out AttributeType type, StringBuilder name)
        {
            Delegates.glGetActiveAttrib(Program, index, bufSize, out Length, out Size, out type, name);
        }
        public static void GetActiveAttrib(uint Program, uint index, out int Size, out AttributeType type, out string name, int MaxAttributeNameLength = 64)
        {
            var sb = new StringBuilder(MaxAttributeNameLength + 4);
            Delegates.glGetActiveAttrib(Program, index, sb.Capacity - 2, out MaxAttributeNameLength, out Size, out type, sb);

            name = sb.ToString();
        }

        /// <summary>
        /// Gets Current Vertex Declaration Information of double type for current bound vertex array and specified Attribute Index.
        /// </summary>
        /// <param name="index">Attribute Index to query</param>
        /// <param name="pname">Name of value to retrive.</param>
        /// <param name="params">Preallocated double array of sufficient size.</param>
        public static void GetVertexAttribdv(uint index, VertexAttribParameters pname, ref double @params)
        {
            Delegates.glGetVertexAttribdv(index, pname, ref @params);
        }
        /// <summary>
        /// Gets Current Vertex Declaration Information of double type for current bound vertex array and specified Attribute Index.
        /// </summary>
        /// <param name="index">Attribute Index to query</param>
        /// <param name="pname">Name of value to retrive.</param>
        /// <returns>Result</returns>
        public static double GetVertexAttribdv(uint index, VertexAttribParameters pname)
        {
            double tmp = 0.0d;
            Delegates.glGetVertexAttribdv(index, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Gets Current Vertex Declaration Information of float type for current bound vertex array and specified Attribute Index.
        /// </summary>
        /// <param name="index">Attribute Index to query</param>
        /// <param name="pname">Name of value to retrive.</param>
        /// <param name="params">Preallocated float array of sufficient size.</param>
        public static void GetVertexAttribfv(uint index, VertexAttribParameters pname, ref float @params)
        {
            Delegates.glGetVertexAttribfv(index, pname, ref @params);
        }
        /// <summary>
        /// Gets Current Vertex Declaration Information of float type for current bound vertex array and specified Attribute Index.
        /// </summary>
        /// <param name="index">Attribute Index to query</param>
        /// <param name="pname">Name of value to retrive.</param>
        /// <returns>Result</returns>
        public static float GetVertexAttribfv(uint index, VertexAttribParameters pname)
        {
            float tmp = 0.0f;
            Delegates.glGetVertexAttribfv(index, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Gets Current Vertex Declaration Information of int type for current bound vertex array and specified Attribute Index.
        /// </summary>
        /// <param name="index">Attribute Index to query</param>
        /// <param name="pname">Name of value to retrive.</param>
        /// <param name="params">Preallocated int array of sufficient size.</param>
        public static void GetVertexAttribiv(uint index, VertexAttribParameters pname, ref int @params)
        {
            Delegates.glGetVertexAttribiv(index, pname, ref @params);
        }
        /// <summary>
        /// Gets Current Vertex Declaration Information of int type for current bound vertex array and specified Attribute Index.
        /// </summary>
        /// <param name="index">Attribute Index to query.</param>
        /// <param name="pname">Name of value to retrive.</param>
        /// <returns></returns>
        public static int GetVertexAttribiv(uint index, VertexAttribParameters pname)
        {
            int tmp = 0;
            Delegates.glGetVertexAttribiv(index, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Returns the current pointer of specified Attribute Index in current bound VertexArrayObject.
        /// </summary>
        /// <param name="index">Attribute Index to query.</param>
        /// <param name="pname">Type of pointer to retrive.</param>
        /// <param name="ptr"></param>
        public static void GetVertexAttribPointerv(uint index, out IntPtr ptr,  VertexAttribPointerParameters pname = VertexAttribPointerParameters.ArrayPointer)
        {
            Delegates.glGetVertexAttribPointerv(index, pname, out ptr);
        }
        /// <summary>
        /// Returns the current pointer of specified Attribute Index in current bound VertexArrayObject.
        /// </summary>
        /// <param name="index">Attribute Index to query.</param>
        /// <param name="pname">Type of pointer to retrive.</param>
        /// <returns></returns>
        public static IntPtr GetVertexAttribPointerv(uint index, VertexAttribPointerParameters pname = VertexAttribPointerParameters.ArrayPointer)
        {
            IntPtr ptr;
            Delegates.glGetVertexAttribPointerv(index, pname, out ptr);
            return ptr;
        }

        #endregion
    }
}
