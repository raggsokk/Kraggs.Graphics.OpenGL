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

            public delegate void delClearColor(float red, float green, float blue, float alpha);
            public delegate void delClearDepthf(float depth);
            public delegate void delLineWidth(float width);
            public delegate void delPolygonOffset(float factor, float units);

            // opengl 1.4
            public delegate void delBlendColor(float red, float green, float blue, float alpha);
            public delegate void delBlendEquation(BlendEquationMode mode);
            public delegate void delBlendFuncSeparate(BlendFactorSrc sfactorRGB, BlendFactorDst dfactorRGB, BlendFactorSrc sfactorAlpha, BlendFactorDst dfactorAlpha);

            public delegate void delStencilFuncSeparate(CullMode face, StencilFunction func, int @ref, uint mask);
            public delegate void delStencilMaskSeparate(CullMode face, uint mask);
            public delegate void delStencilOpSeparate(CullMode face, StencilOperation StencilFails, StencilOperation DepthFails, StencilOperation StencilPasses);
            
            // opengl 2.0
            public delegate void delBlendEquationSeparate(BlendEquationSeparateRGB modeRGB, BlendEquationSeparateAlpha modeAlpha);

            public delegate void delAttachShader(uint Program, uint Shader);
            public delegate void delBindAttribLocation(uint Program, uint aIndex, string Name);
            public delegate void delCompileShader(uint Shader);
            public delegate uint delCreateProgram();
            public delegate uint delCreateShader(ShaderType type);
            public delegate void delDeleteProgram(uint Program);
            public delegate void delDeleteShader(uint Shader);
            public delegate void delDetachShader(uint Program, uint Shader);
            public delegate void delDisableVertexAttribArray(uint index);
            public delegate void delEnableVertexAttribArray(uint index);
            public delegate void delGetActiveAttrib(uint Program, uint index, int bufSize, out int Length, out int Size, out AttributeType type, StringBuilder name);
            public delegate void delGetActiveUniform(uint Program, uint index, int bufSize, out int length, out int size, out UniformType UniformType, StringBuilder Name);
            public delegate void delGetAttachedShaders(uint Program, int MaxCount, out int Count, ref uint Shaders);
            public delegate int delGetAttribLocation(uint Program, string Name);
            public delegate void delGetProgramiv(uint Program, GetProgramParameters pname, ref int @params);
            public delegate void delGetProgramInfoLog(uint Program, int BufSize, out int Length, StringBuilder infoLog);
            public delegate void delGetShaderiv(uint Shader, ShaderParameters pname, ref int @params);            
            public delegate void delGetShaderInfoLog(uint Shader, int BufSize, out int Length, StringBuilder infoLog);
            public delegate void delGetShaderPrecisionFormat(ShaderType type, PrecisionType precisiontype, ref int range, ref int precision);
            public delegate void delGetShaderSource(uint Shader, int BufSize, out int Length, StringBuilder source);
            public delegate void delGetUniformiv(uint Program, int Location, ref int @params);
            public delegate void delGetUniformfv(uint Program, int Location, ref float @params);            
            public delegate int delGetUniformLocation(uint Program, string Name);
            public delegate void delGetVertexAttribfv(uint index, VertexAttribParameters pname, ref float @params);
            public delegate void delGetVertexAttribiv(uint index, VertexAttribParameters pname, ref int @params);
            public delegate void delGetVertexAttribPointerv(uint index, VertexAttribPointerParameters pname, out IntPtr ptr);
            public delegate bool delIsProgram(uint Program);
            public delegate bool delIsShader(uint Shader);
            public delegate void delLinkProgram(uint Program);
            public delegate void delValidateProgram(uint Program);
            public delegate void delUseProgram(uint Program);
            //public delegate void delShaderSource(uint Shader, int Count, ref string source, ref int Lengths);
            public delegate void delShaderSource(uint Shader, int Count, string[] source, int[] Lengths);
            public delegate void delReleaseShaderCompiler();
            public delegate void delShaderBinary(int count, ref uint shaders, int BinaryFormat, IntPtr binary, int Length);
            public delegate void delVertexAttribPointer(uint index, int Size, VertexAttribFormat type, bool normalized, int stride, IntPtr ptr);

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


            // opengl 3.0
            public delegate void delBindFramebuffer(FramebufferTarget target, uint Framebuffer);
            public delegate void delBindRenderbuffer(RenderbufferTarget target, uint Renderbuffer);
            public delegate void delDeleteFramebuffers(int number, ref uint Framebuffers);
            public delegate void delDeleteRenderbuffers(int number, ref uint Renderbuffers);
            public delegate void delFramebufferRenderbuffer(FramebufferTarget ftarget, FramebufferAttachmentType attachment, RenderbufferTarget rtarget, uint Renderbuffer);
            public delegate void delFramebufferTexture2D(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, TextureTarget texTarget2D, uint TextureID, int level);
            public delegate void delGenerateMipmap(TextureTarget target);
            public delegate void delGenFramebuffers(int number, ref uint Framebuffers);
            public delegate void delGenRenderbuffers(int number, ref uint Renderbuffers);
            public delegate void delGetFramebufferAttachmentParameteriv(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, AttachmentParameters pname, ref int @params);
            public delegate void delGetRenderbufferParameteriv(RenderbufferTarget rTarget, RenderbufferParameters pname, ref int @params);
            public delegate bool delIsFramebuffer(uint Framebuffer);
            public delegate bool delIsRenderbuffer(uint Renderbuffer);
            public delegate FramebufferStatus delCheckFramebufferStatus(FramebufferTarget fboTarget);

            /*
             * AttachShader
             * BindAttribLocation
             * BindFramebuffer
             * BindRenderbuffer
             * BlendColor
             * BlendEquation
             * BlendEquationSeperate
             * BlendFuncSeparate
             * CompileShader
             * CreateProgram
             * CreateShader
             * DeleteFramebuffers
             * DeleteProgram
             * DeleteRenderbuffers
             * DeleteShader
             * DetachShader
             * DisableVertexAttribArray
             * EnableVertexAttribArray
             * FramebufferRenderbuffer
             * FramebufferTexture2D
             * GenerateMipmap
             * GenFramebuffers
             * GenRanderbuffers
             * GetActiveAttrib
             * GetActiveUniform
             * GetAttachedShaders
             * GetAttribLocation
             * GetFramebufferAttachmentParameteriv
             * GetProgramiv
             * GetProgramInfoLog
             * GetRenderbufferParameteriv
             * GetShaderiv
             * GetShaderInfoLog
             * GetShaderPrecisionFormat
             * GetShaderSource
             * GetUniformfv
             * GetUniformiv
             * GetUniformLocation
             * GetVertexAttribfv
             * GetVertexAttribiv
             * GetVertexAttribPointerv
             * IsFramebuffer
             * IsProgram
             * IsRenderbuffer
             * IsShader
             * LinkProgram
             * ReleaseShaderCompiler
             * RenderbufferStorage
             * ShaderBinary
             * ShaderSource
             * StencilFuncSeparate
             * StencilMaskSeparate
             * StencilOpSeparate
             * Uniform1f
             * Uniform2f
             * Uniform3f
             * Uniform4f
             * Uniform1fv
             * Uniform2fv
             * Uniform3fv
             * Uniform4fv
             * Uniform1i
             * Uniform2i
             * Uniform3i
             * Uniform4i
             * Uniform1iv
             * Uniform2iv
             * Uniform3iv
             * Uniform4iv
             * UniformMatrix2fv
             * UniformMatrix3fv
             * UniformMatrix4fv
             * UseProgram
             * ValidateProgram
             * VertexAttrib1f
             * VertexAttrib2f
             * VertexAttrib3f
             * VertexAttrib4f
             * VertexAttrib1fv
             * VertexAttrib2fv
             * VertexAttrib3fv
             * VertexAttrib4fv
             * VertexAttribPointer
             * 
             */


            #endregion

            #region GL Fields

            public static delClearColor glClearColor;
            public static delClearDepthf glClearDepthf;
            public static delLineWidth glLineWidth;
            public static delPolygonOffset glPolygonOffset;

            // opengl 1.4
            public static delBlendColor glBlendColor;
            public static delBlendEquation glBlendEquation;
            public static delBlendFuncSeparate glBlendFuncSeparate;

            public static delStencilFuncSeparate glStencilFuncSeparate;
            public static delStencilMaskSeparate glStencilMaskSeparate;
            public static delStencilOpSeparate glStencilOpSeparate;

            // opengl 2.0
            public static delBlendEquationSeparate glBlendEquationSeparate;

            public static delAttachShader glAttachShader;
            public static delBindAttribLocation glBindAttribLocation; 
            public static delCompileShader glCompileShader;
            public static delCreateProgram glCreateProgram;
            public static delCreateShader glCreateShader;
            public static delDeleteProgram glDeleteProgram;
            public static delDeleteShader glDeleteShader;
            public static delDetachShader glDetachShader;
            public static delDisableVertexAttribArray glDisableVertexAttribArray;
            public static delEnableVertexAttribArray glEnableVertexAttribArray;
            public static delGetActiveAttrib glGetActiveAttrib;
            public static delGetActiveUniform glGetActiveUniform;
            public static delGetAttachedShaders glGetAttachedShaders;
            public static delGetAttribLocation glGetAttribLocation;
            public static delGetProgramiv glGetProgramiv;
            public static delGetProgramInfoLog glGetProgramInfoLog;
            public static delGetShaderiv glGetShaderiv;
            public static delGetShaderInfoLog glGetShaderInfoLog;
            public static delGetShaderPrecisionFormat glGetShaderPrecisionFormat;
            public static delGetShaderSource glGetShaderSource;
            public static delGetUniformiv glGetUniformiv;
            public static delGetUniformfv glGetUniformfv;
            public static delGetUniformLocation glGetUniformLocation;
            public static delGetVertexAttribfv glGetVertexAttribfv;
            public static delGetVertexAttribiv glGetVertexAttribiv;
            public static delGetVertexAttribPointerv glGetVertexAttribPointerv;
            public static delIsProgram glIsProgram;
            public static delIsShader glIsShader;
            public static delLinkProgram glLinkProgram;
            public static delValidateProgram glValidateProgram;
            public static delUseProgram glUseProgram;
            public static delShaderSource glShaderSource;
            public static delReleaseShaderCompiler glReleaseShaderCompiler;
            public static delShaderBinary glShaderBinary;
            public static delVertexAttribPointer glVertexAttribPointer;

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


            // opengl 3.0
            public static delBindFramebuffer glBindFramebuffer;
            public static delBindRenderbuffer glBindRenderbuffer;
            public static delDeleteFramebuffers glDeleteFramebuffers;
            public static delDeleteRenderbuffers glDeleteRenderbuffers;
            public static delFramebufferRenderbuffer glFramebufferRenderbuffer;
            public static delFramebufferTexture2D glFramebufferTexture2D;
            public static delGenerateMipmap glGenerateMipmap;
            public static delGenFramebuffers glGenFramebuffers;
            public static delGenRenderbuffers glGenRenderbuffers;
            public static delGetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;
            public static delGetRenderbufferParameteriv glGetRenderbufferParameteriv;
            public static delIsFramebuffer glIsFramebuffer;
            public static delIsRenderbuffer glIsRenderbuffer;
            public static delCheckFramebufferStatus glCheckFramebufferStatus;


            #endregion
        }

        #endregion

        #region Public functions.

        public static void ClearColor(float red, float green, float blue, float alpha)
        {
            Delegates.glClearColor(red, green, blue, alpha);
        }

        public static void ClearDepthf(float depth)
        {
            Delegates.glClearDepthf(depth);
        }

        public static void LineWidth(float width)
        {
            Delegates.glLineWidth(width);
        }

        public static void PolygonOffset(float factor, float units)
        {
            Delegates.glPolygonOffset(factor, units);
        }

        // opengl 1.4
        public static void BlendColor(float red, float green, float blue, float alpha)
        {
            Delegates.glBlendColor(red, green, blue, alpha);
        }

        public static void BlendEquation(BlendEquationMode mode)
        {
            Delegates.glBlendEquation(mode);
        }

        public static void BlendFuncSeparate(BlendFactorSrc sfactorRGB, BlendFactorDst dfactorRGB, BlendFactorSrc sfactorAlpha, BlendFactorDst dfactorAlpha)
        {
            Delegates.glBlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        }

        public static void StencilFuncSeparate(CullMode face, StencilFunction func, int @ref, uint mask)
        {
            Delegates.glStencilFuncSeparate(face, func, @ref, mask);
        }
        public static void StencilMaskSeparate(CullMode face, uint mask)
        {
            Delegates.glStencilMaskSeparate(face, mask);
        }
        public static void StencilOpSeparate(CullMode face, StencilOperation StencilFails, StencilOperation DepthFails, StencilOperation StencilPasses)
        {
            Delegates.glStencilOpSeparate(face, StencilFails, DepthFails, StencilPasses);
        }


        // opengl 2.0
        public static void BlendEquationSeparate(BlendEquationSeparateRGB modeRGB, BlendEquationSeparateAlpha modeAlpha)
        {
            Delegates.glBlendEquationSeparate(modeRGB, modeAlpha);
        }

        public static void AttachShader(uint Program, uint Shader)
        {
            Delegates.glAttachShader(Program, Shader);
        }
        public static void BindAttribLocation(uint Program, uint aIndex, string Name)
        {
            Delegates.glBindAttribLocation(Program, aIndex, Name);
        }
        public static void CompileShader(uint Shader)
        {
            Delegates.glCompileShader(Shader);
        }
        public static uint CreateProgram()
        {
            return Delegates.glCreateProgram();
        }
        public static uint CreateShader(ShaderType type)
        {
            return Delegates.glCreateShader(type);
        }
        public static void DeleteProgram(uint Program)
        {
            Delegates.glDeleteProgram(Program);
        }
        public static void DeleteShader(uint Shader)
        {
            Delegates.glDeleteShader(Shader);
        }
        public static void DetachShader(uint Program, uint Shader)
        {
            Delegates.glDetachShader(Program, Shader);
        }
        public static void DisableVertexAttribArray(uint index)
        {
            Delegates.glDisableVertexAttribArray(index);
        }
        public static void EnableVertexAttribArray(uint index)
        {
            Delegates.glEnableVertexAttribArray(index);
        }
        public static void GetActiveAttrib(uint Program, uint index, int bufSize, out int Length, out int Size, out AttributeType type, StringBuilder name)
        {
            Delegates.glGetActiveAttrib(Program, index, bufSize, out Length, out Size, out type, name);
        }
        public static void GetActiveAttrib(uint Program, uint index, out int Size, out AttributeType type, out string name, int MaxAttribNameLength = 64)
        {
            var sb = new StringBuilder(MaxAttribNameLength + 4);
            //var len = 0;

            Delegates.glGetActiveAttrib(Program, index, sb.Capacity - 2, out MaxAttribNameLength, out Size, out type, sb);
            name = sb.ToString();
        }
        public static void GetActiveUniform(uint Program, uint index, int bufSize, out int length, out int size, out UniformType UniformType, StringBuilder Name)
        {
            Delegates.glGetActiveUniform(Program, index, bufSize, out length, out size, out UniformType, Name);
        }
        public static void GetActiveUniform(uint Program, uint index, out int size, out UniformType UniformType, out string Name, int MaxUniformNameLength = 64)
        {
            var sb = new StringBuilder(MaxUniformNameLength + 4);

            Delegates.glGetActiveUniform(Program, index, sb.Capacity - 2, out MaxUniformNameLength, out size, out UniformType, sb);
            Name = sb.ToString();
        }
        public static void GetAttachedShaders(uint Program, int MaxCount, out int Count, ref uint Shaders)
        {
            Delegates.glGetAttachedShaders(Program, MaxCount, out Count, ref Shaders);
        }
        public static uint[] GetAttachedShaders(uint Program, int MaxShaders = 8)
        {
            var shadercount = GetProgramiv(Program, GetProgramParameters.AttachedShaders);
            var buf = new uint[shadercount];

            Delegates.glGetAttachedShaders(Program, buf.Length, out shadercount, ref buf[0]);

            return buf;
        }
        public static int GetAttribLocation(uint Program, string Name)
        {
            return Delegates.glGetAttribLocation(Program, Name);
        }
        public static void GetProgramiv(uint Program, GetProgramParameters pname, ref int @params)
        {
            Delegates.glGetProgramiv(Program, pname, ref @params);
        }
        public static int GetProgramiv(uint Program, GetProgramParameters pname)
        {
            var tmp = new int[1];
            Delegates.glGetProgramiv(Program, pname, ref tmp[0]);
            return tmp[0];
        }
        public static void GetProgramInfoLog(uint Program, int BufSize, out int Length, StringBuilder infoLog)
        {
            Delegates.glGetProgramInfoLog(Program, BufSize, out Length, infoLog);
        }
        public static string GetProgramInfoLog(uint Program)
        {
            var loglength = GetProgramiv(Program, GetProgramParameters.InfoLogLength);
            if (loglength > 1)
            {
                var sb = new StringBuilder(loglength + 4);
                Delegates.glGetProgramInfoLog(Program, sb.Capacity - 2, out loglength, sb);

                return sb.ToString();
            }
            else
                return string.Empty;
        }
        public static void GetShaderiv(uint Shader, ShaderParameters pname, ref int @params)
        {
            Delegates.glGetShaderiv(Shader, pname, ref @params);
        }
        public static int GetShaderiv(uint Shader, ShaderParameters pname)
        {
            var tmp = 0;
            Delegates.glGetShaderiv(Shader, pname, ref tmp);
            return tmp;
        }
        public static void GetShaderInfoLog(uint Shader, int BufSize, out int Length, StringBuilder infoLog)
        {
            Delegates.glGetShaderInfoLog(Shader, BufSize, out Length, infoLog);
        }
        public static string GetShaderInfoLog(uint Shader)
        {
            var loglength = GetShaderiv(Shader, ShaderParameters.InfoLogLength);
            if (loglength > 1)
            {
                var sb = new StringBuilder(loglength + 4);
                Delegates.glGetShaderInfoLog(Shader, sb.Capacity - 2, out loglength, sb);
                
                return sb.ToString();
            }
            else
                return string.Empty;

        }

        public static void GetShaderPrecisionFormat(ShaderType type, PrecisionType precisiontype, ref int range, ref int precision)
        {
            Delegates.glGetShaderPrecisionFormat(type, precisiontype, ref range, ref precision);
        }
        public static void GetShaderSource(uint Shader, int BufSize, out int Length, StringBuilder source)
        {
            Delegates.glGetShaderSource(Shader, BufSize, out Length, source);
        }
        public static string GetShaderSource(uint Shader)
        {
            var sourcelength = GetShaderiv(Shader, ShaderParameters.ShaderSourceLength);

            if (sourcelength > 1)
            {
                var sb = new StringBuilder(sourcelength + 4);

                Delegates.glGetShaderSource(Shader, sb.Capacity - 2, out sourcelength, sb);

                return sb.ToString();
            }
            else
                return string.Empty;
        }
        public static void GetUniformiv(uint Program, int Location, ref int @params)
        {
            Delegates.glGetUniformiv(Program, Location, ref @params);
        }
        public static int GetUniformiv(uint Program, int Location)
        {
            var tmp = new int[1];
            Delegates.glGetUniformiv(Program, Location, ref tmp[0]);
            return tmp[0];
        }
        public static void GetUniformfv(uint Program, int Location, ref float @params)
        {
            Delegates.glGetUniformfv(Program, Location, ref @params);
        }
        public static float GetUniformfv(uint Program, int Location)
        {
            var tmp = new float[1];
            Delegates.glGetUniformfv(Program, Location, ref tmp[0]);
            return tmp[0];
        }
        public static int GetUniformLocation(uint Program, string Name)
        {
            return Delegates.glGetUniformLocation(Program, Name);
        }
        public static void GetVertexAttribfv(uint index, VertexAttribParameters pname, ref float @params)
        {
            Delegates.glGetVertexAttribfv(index, pname, ref @params);
        }
        public static float GetVertexAttribfv(uint index, VertexAttribParameters pname)
        {
            var tmp = new float[1];
            Delegates.glGetVertexAttribfv(index, pname, ref tmp[0]);
            return tmp[0];
        }
        public static void GetVertexAttribiv(uint index, VertexAttribParameters pname, ref int @params)
        {
            Delegates.glGetVertexAttribiv(index, pname, ref @params);
        }
        public static int GetVertexAttribiv(uint index, VertexAttribParameters pname)
        {
            var tmp = new int[1];
            Delegates.glGetVertexAttribiv(index, pname, ref tmp[0]);
            return tmp[0];
        }
        public static void GetVertexAttribPointerv(uint index, VertexAttribPointerParameters pname, out IntPtr ptr)
        {
            Delegates.glGetVertexAttribPointerv(index, pname, out ptr);
        }
        public static IntPtr GetVertexAttribPointerv(uint index, VertexAttribPointerParameters pname)
        {
            IntPtr tmp;
            Delegates.glGetVertexAttribPointerv(index, pname, out tmp);
            return tmp;
        }
        public static bool IsProgram(uint Program)
        {
            return Delegates.glIsProgram(Program);
        }
        public static bool IsShader(uint Shader)
        {
            return Delegates.glIsShader(Shader);
        }
        public static void LinkProgram(uint Program)
        {
            Delegates.glLinkProgram(Program);
        }
        public static void ValidateProgram(uint Program)
        {
            Delegates.glValidateProgram(Program);
        }
        public static void UseProgram(uint Program)
        {
            Delegates.glUseProgram(Program);
        }
        public static void ShaderSource(uint Shader, int Count, string[] source, int[] Lengths)
        {
            Delegates.glShaderSource(Shader, Count, source, Lengths);
        }
        public static void ShaderSource(uint Shader, string source)
        {
            var arrLength = new int[] { source.Length };
            var arrSource = new string[] { source };
            Delegates.glShaderSource(Shader, arrSource.Length, arrSource, arrLength);
        }
        public static void ReleaseShaderCompiler()
        {
            Delegates.glReleaseShaderCompiler();
        }
        public static void ShaderBinary(int count, ref uint shaders, int BinaryFormat, IntPtr binary, int Length)
        {
            Delegates.glShaderBinary(count, ref shaders, BinaryFormat, binary, Length);
        }
        public static void VertexAttribPointer(uint index, int Size, VertexAttribFormat type, int stride, long offset, bool normalized = false)
        {
            Delegates.glVertexAttribPointer(index, Size, type, normalized, stride, (IntPtr)offset);
        }

        public static void Uniform1f(int location, float v1)
        {
            Delegates.glUniform1f(location, v1);
        }
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
        public static void Uniform1iv(int location, ref int v, int count = 1)
        {
            Delegates.glUniform1iv(location, count, ref v);
        }
        public static void Uniform2fv(int location, ref float v, int count = 1)
        {
            Delegates.glUniform2fv(location, count, ref v);
        }
        public static void Uniform2iv(int location, ref int v, int count = 1)
        {
            Delegates.glUniform2iv(location, count, ref v);
        }

        public static void Uniform3fv(int location, ref float v, int count = 1)
        {
            Delegates.glUniform3fv(location, count, ref v);
        }
        public static void Uniform3iv(int location, ref int v, int count = 1)
        {
            Delegates.glUniform3iv(location, count, ref v);
        }

        public static void Uniform4fv(int location, ref float v, int count = 1)
        {
            Delegates.glUniform4fv(location, count, ref v);
        }
        public static void Uniform4iv(int location, ref int v, int count = 1)
        {
            Delegates.glUniform4iv(location, count, ref v);
        }
        public static void UniformMatrix2fv(int location, ref float matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix2fv(location, count, transpose, ref matrix);
        }
        public static void UniformMatrix3fv(int location, ref float matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix3fv(location, count, transpose, ref matrix);
        }
        public static void UniformMatrix4fv(int location, ref float matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix4fv(location, count, transpose, ref matrix);
        }

        // opengl 3.0
        public static void BindFramebuffer(FramebufferTarget target, uint Framebuffer)
        {
            Delegates.glBindFramebuffer(target, Framebuffer);
        }
        public static void BindRenderbuffer(uint Renderbuffer, RenderbufferTarget target = RenderbufferTarget.Renderbuffer)
        {
            Delegates.glBindRenderbuffer(target, Renderbuffer);
        }
        public static void DeleteFramebuffers(uint[] Framebuffers)
        {
            Delegates.glDeleteFramebuffers(Framebuffers.Length, ref Framebuffers[0]);
        }
        public static void DeleteFramebuffers(uint Framebuffer)
        {
            //var tmp = new uint[] { Framebuffers };
            Delegates.glDeleteFramebuffers(1, ref Framebuffer);
        }
        public static void DeleteRenderbuffers(uint[] Renderbuffers)
        {
            Delegates.glDeleteRenderbuffers(Renderbuffers.Length, ref Renderbuffers[0]);
        }
        public static void DeleteRenderbuffers(uint Renderbuffer)
        {
            Delegates.glDeleteRenderbuffers(1, ref Renderbuffer);
        }
        public static void FramebufferRenderbuffer(FramebufferTarget ftarget, FramebufferAttachmentType attachment, uint Renderbuffer, RenderbufferTarget rtarget = RenderbufferTarget.Renderbuffer)
        {
            Delegates.glFramebufferRenderbuffer(ftarget, attachment, rtarget, Renderbuffer);
        }
        public static void FramebufferTexture2D(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, TextureTarget texTarget2D, uint TextureID, int level = 0)
        {
            Delegates.glFramebufferTexture2D(fboTarget, attachment, texTarget2D, TextureID, level);
        }
        public static void GenerateMipmap(TextureTarget target)
        {
            Delegates.glGenerateMipmap(target);
        }
        public static void GenFramebuffers(uint[] Framebuffers)
        {
            Delegates.glGenFramebuffers(Framebuffers.Length, ref Framebuffers[0]);
        }
        public static uint GenFramebuffers()
        {
            uint tmp = 0;
            Delegates.glGenFramebuffers(1, ref tmp);
            return tmp;
        }
        public static void GenRenderbuffers(uint[] Renderbuffers)
        {
            Delegates.glGenRenderbuffers(Renderbuffers.Length, ref Renderbuffers[0]);
        }
        public static uint GenRenderbuffers()
        {
            uint tmp = 0;
            Delegates.glGenRenderbuffers(1, ref tmp);
            return tmp;
        }
        public static void GetFramebufferAttachmentParameteriv(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, AttachmentParameters pname, ref int @params)
        {
            Delegates.glGetFramebufferAttachmentParameteriv(fboTarget, attachment, pname, ref @params);
        }
        public static int GetFramebufferAttachmentParameteriv(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, AttachmentParameters pname)
        {
            var tmp = 0;
            Delegates.glGetFramebufferAttachmentParameteriv(fboTarget, attachment, pname, ref tmp);
            return tmp;
        }
        public static void GetRenderbufferParameteriv(RenderbufferParameters pname, ref int @params, RenderbufferTarget rTarget = RenderbufferTarget.Renderbuffer)
        {
            Delegates.glGetRenderbufferParameteriv(rTarget, pname, ref @params);
        }
        public static int GetRenderbufferParameteriv(RenderbufferParameters pname, RenderbufferTarget rTarget = RenderbufferTarget.Renderbuffer)
        {
            var tmp = 0;
            Delegates.glGetRenderbufferParameteriv(rTarget, pname, ref tmp);
            return tmp;
        }
        public static bool IsFramebuffer(uint Framebuffer)
        {
            return Delegates.glIsFramebuffer(Framebuffer);
        }
        public static bool IsRenderbuffer(uint Renderbuffer)
        {
            return Delegates.glIsRenderbuffer(Renderbuffer);
        }
        public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget fboTarget)
        {
            return Delegates.glCheckFramebufferStatus(fboTarget);
        }

        #endregion
    }
}
