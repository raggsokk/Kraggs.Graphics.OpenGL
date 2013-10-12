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

            //ARB_ES2_compatibility
            public delegate void delClearDepthf(float d);
            public delegate void delDepthRangef(float near, float far);
            public delegate void delGetShaderPrecisionFormat(ShaderType type, PrecisionType precisiontype, int[] range, int[] precision);
            public delegate void delReleaseShaderCompiler();
            public delegate void delShaderBinary(int count, uint[] shaders, int BinaryFormat , IntPtr binary, int Length);

            //ARB_get_program_binary
            public delegate void delGetProgramBinary(uint Program, int bufSize, out int Length, out int BinaryFormat , IntPtr binary);
            public delegate void delProgramBinary(uint Program, int BinaryFormat , IntPtr binary, int Length);            
            public delegate void delProgramParameteri(uint Program, ProgramParameters pname, int value);

            //ARB_separate_shader_objects
            public delegate void delUseProgramStages(uint Pipeline, ProgramStages stages, uint Program);
            public delegate void delActiveShaderProgram(uint Pipeline, uint Program);
            public delegate void delCreateShaderProgramv(ShaderType type, int count, string[] strings);
            public delegate void delBindProgramPipeline(uint Pipeline);
            public delegate void delDeleteProgramPipelines(int number, ref uint Pipelines);
            public delegate void delGenProgramPipelines(int number, ref uint Pipelines);
            public delegate bool delIsProgramPipeline(uint pipeline);            
            //public delegate void delProgramParameteri;
            public delegate void delGetProgramPipelineiv(uint pipeline, ProgramPipelineParameters pname, ref int @params);

            public delegate void delValidateProgramPipeline(uint Pipeline);
            public delegate void delGetProgramPipelineInfoLog(uint pipeline, int bufSize, out int length, StringBuilder infoLog);

            public delegate void delProgramUniform1f(uint Program, int location, float v1);
            public delegate void delProgramUniform2f(uint Program, int location, float v1, float v2);
            public delegate void delProgramUniform3f(uint Program, int location, float v1, float v2, float v3);
            public delegate void delProgramUniform4f(uint Program, int location, float v1, float v2, float v3, float v4);

            public delegate void delProgramUniform1d(uint Program, int location, double v1);
            public delegate void delProgramUniform2d(uint Program, int location, double v1, double v2);
            public delegate void delProgramUniform3d(uint Program, int location, double v1, double v2, double v3);
            public delegate void delProgramUniform4d(uint Program, int location, double v1, double v2, double v3, double v4);

            public delegate void delProgramUniform1i(uint Program, int location, int v1);
            public delegate void delProgramUniform2i(uint Program, int location, int v1, int v2);
            public delegate void delProgramUniform3i(uint Program, int location, int v1, int v2, int v3);
            public delegate void delProgramUniform4i(uint Program, int location, int v1, int v2, int v3, int v4);

            public delegate void delProgramUniform1ui(uint Program, int location, uint v1);
            public delegate void delProgramUniform2ui(uint Program, int location, uint v1, uint v2);
            public delegate void delProgramUniform3ui(uint Program, int location, uint v1, uint v2, uint v3);
            public delegate void delProgramUniform4ui(uint Program, int location, uint v1, uint v2, uint v3, uint v4);


            public delegate void delProgramUniform1fv(uint Program, int location, int count, ref float v);
            public delegate void delProgramUniform2fv(uint Program, int location, int count, ref float v);
            public delegate void delProgramUniform3fv(uint Program, int location, int count, ref float v);
            public delegate void delProgramUniform4fv(uint Program, int location, int count, ref float v);

            public delegate void delProgramUniform1dv(uint Program, int location, int count, ref double v);
            public delegate void delProgramUniform2dv(uint Program, int location, int count, ref double v);
            public delegate void delProgramUniform3dv(uint Program, int location, int count, ref double v);
            public delegate void delProgramUniform4dv(uint Program, int location, int count, ref double v);

            public delegate void delProgramUniform1iv(uint Program, int location, int count, ref int v);
            public delegate void delProgramUniform2iv(uint Program, int location, int count, ref int v);
            public delegate void delProgramUniform3iv(uint Program, int location, int count, ref int v);
            public delegate void delProgramUniform4iv(uint Program, int location, int count, ref int v);

            public delegate void delProgramUniform1uiv(uint Program, int location, int count, ref uint v);
            public delegate void delProgramUniform2uiv(uint Program, int location, int count, ref uint v);
            public delegate void delProgramUniform3uiv(uint Program, int location, int count, ref uint v);
            public delegate void delProgramUniform4uiv(uint Program, int location, int count, ref uint v);

            public delegate void delProgramUniformMatrix2fv(uint Program, int location, int count, bool transpose, ref float v);
            public delegate void delProgramUniformMatrix3fv(uint Program, int location, int count, bool transpose, ref float v);
            public delegate void delProgramUniformMatrix4fv(uint Program, int location, int count, bool transpose, ref float v);

            public delegate void delProgramUniformMatrix2dv(uint Program, int location, int count, bool transpose, ref double v);
            public delegate void delProgramUniformMatrix3dv(uint Program, int location, int count, bool transpose, ref double v);
            public delegate void delProgramUniformMatrix4dv(uint Program, int location, int count, bool transpose, ref double v);

            public delegate void delProgramUniformMatrix2x3fv(uint Program, int location, int count, bool transpose, ref float v);
            public delegate void delProgramUniformMatrix2x4fv(uint Program, int location, int count, bool transpose, ref float v);
            public delegate void delProgramUniformMatrix3x2fv(uint Program, int location, int count, bool transpose, ref float v);
            public delegate void delProgramUniformMatrix3x4fv(uint Program, int location, int count, bool transpose, ref float v);
            public delegate void delProgramUniformMatrix4x2fv(uint Program, int location, int count, bool transpose, ref float v);
            public delegate void delProgramUniformMatrix4x3fv(uint Program, int location, int count, bool transpose, ref float v);

            public delegate void delProgramUniformMatrix2x3dv(uint Program, int location, int count, bool transpose, ref double v);
            public delegate void delProgramUniformMatrix2x4dv(uint Program, int location, int count, bool transpose, ref double v);
            public delegate void delProgramUniformMatrix3x2dv(uint Program, int location, int count, bool transpose, ref double v);
            public delegate void delProgramUniformMatrix3x4dv(uint Program, int location, int count, bool transpose, ref double v);
            public delegate void delProgramUniformMatrix4x2dv(uint Program, int location, int count, bool transpose, ref double v);
            public delegate void delProgramUniformMatrix4x3dv(uint Program, int location, int count, bool transpose, ref double v);

            //ARB_vertex_attrib_64bit
            public delegate void delVertexAttribLPointer(uint index, int size, VertexAttribLFormat type, int stride, IntPtr ptr);
            public delegate void delGetVertexAttribLdv(uint index, VertexAttribParameters pname, ref double @params);

            /* ignored.
            public delegate void delVertexAttribL1d(uint index, double v1);
            public delegate void delVertexAttribL2d(uint index, double v1, double v2);
            public delegate void delVertexAttribL3d(uint index, double v1, double v2, double v3);
            public delegate void delVertexAttribL4d(uint index, double v1, double v2, double v3, double v4);

            public delegate void delVertexAttribL1dv(uint index, ref double v);
            public delegate void delVertexAttribL2dv(uint index, ref double v);
            public delegate void delVertexAttribL3dv(uint index, ref double v);
            public delegate void delVertexAttribL4dv(uint index, ref double v);
            */
            

            //ARB_viewport_array
            public delegate void delDepthRangeArrayv(uint first, int count, ref double v);
            public delegate void delDepthRangeIndexed(uint index, double near, double far);
            public delegate void delGetDoublei_v(GetParameters pname, uint index, ref double data);
            public delegate void delGetFloati_v(GetParameters pname, uint index, ref float data);
            public delegate void delScissorArrayv(uint first, int count, ref int v);
            public delegate void delScissorIndexed(uint index, int left, int bottom, int width, int height);
            public delegate void delScissorIndexedv(uint index, ref int vScissorRect);
            public delegate void delViewportArrayv(uint first, int count, ref float v);
            public delegate void delViewportIndexedf(uint index, float x, float y, float w, float h);
            public delegate void delViewportIndexedfv(uint index, ref float viewport);


            #endregion

            #region GL Fields

            //ARB_ES2_compatibility
            public static delClearDepthf glClearDepthf;
            public static delDepthRangef glDepthRangef;
            public static delGetShaderPrecisionFormat glGetShaderPrecisionFormat;
            public static delReleaseShaderCompiler glReleaseShaderCompiler;
            public static delShaderBinary glShaderBinary;

            //ARB_get_program_binary
            public static delGetProgramBinary glGetProgramBinary;
            public static delProgramBinary glProgramBinary;            
            public static delProgramParameteri glProgramParameteri;

            //ARB_separate_shader_objects
            public static delUseProgramStages glUseProgramStages;
            public static delActiveShaderProgram glActiveShaderProgram;
            public static delCreateShaderProgramv glCreateShaderProgramv;
            public static delBindProgramPipeline glBindProgramPipeline;            
            public static delDeleteProgramPipelines glDeleteProgramPipelines;
            public static delGenProgramPipelines glGenProgramPipelines;
            public static delIsProgramPipeline glIsProgramPipeline;
            //public static delProgramParameteri            
            public static delGetProgramPipelineiv glGetProgramPipelineiv;
            public static delValidateProgramPipeline glValidateProgramPipeline;
            public static delGetProgramPipelineInfoLog glGetProgramPipelineInfoLog;



            public static delProgramUniform1f glProgramUniform1f;
            public static delProgramUniform2f glProgramUniform2f;
            public static delProgramUniform3f glProgramUniform3f;
            public static delProgramUniform4f glProgramUniform4f;

            public static delProgramUniform1d glProgramUniform1d;
            public static delProgramUniform2d glProgramUniform2d;
            public static delProgramUniform3d glProgramUniform3d;
            public static delProgramUniform4d glProgramUniform4d;

            public static delProgramUniform1i glProgramUniform1i;
            public static delProgramUniform2i glProgramUniform2i;
            public static delProgramUniform3i glProgramUniform3i;
            public static delProgramUniform4i glProgramUniform4i;

            public static delProgramUniform1ui glProgramUniform1ui;
            public static delProgramUniform2ui glProgramUniform2ui;
            public static delProgramUniform3ui glProgramUniform3ui;
            public static delProgramUniform4ui glProgramUniform4ui;


            public static delProgramUniform1fv glProgramUniform1fv;
            public static delProgramUniform2fv glProgramUniform2fv;
            public static delProgramUniform3fv glProgramUniform3fv;
            public static delProgramUniform4fv glProgramUniform4fv;

            public static delProgramUniform1dv glProgramUniform1dv;
            public static delProgramUniform2dv glProgramUniform2dv;
            public static delProgramUniform3dv glProgramUniform3dv;
            public static delProgramUniform4dv glProgramUniform4dv;

            public static delProgramUniform1iv glProgramUniform1iv;
            public static delProgramUniform2iv glProgramUniform2iv;
            public static delProgramUniform3iv glProgramUniform3iv;
            public static delProgramUniform4iv glProgramUniform4iv;

            public static delProgramUniform1uiv glProgramUniform1uiv;
            public static delProgramUniform2uiv glProgramUniform2uiv;
            public static delProgramUniform3uiv glProgramUniform3uiv;
            public static delProgramUniform4uiv glProgramUniform4uiv;

            public static delProgramUniformMatrix2fv glProgramUniformMatrix2fv;
            public static delProgramUniformMatrix3fv glProgramUniformMatrix3fv;
            public static delProgramUniformMatrix4fv glProgramUniformMatrix4fv;

            public static delProgramUniformMatrix2dv glProgramUniformMatrix2dv;
            public static delProgramUniformMatrix3dv glProgramUniformMatrix3dv;
            public static delProgramUniformMatrix4dv glProgramUniformMatrix4dv;

            public static delProgramUniformMatrix2x3fv glProgramUniformMatrix2x3fv;
            public static delProgramUniformMatrix2x4fv glProgramUniformMatrix2x4fv;
            public static delProgramUniformMatrix3x2fv glProgramUniformMatrix3x2fv;
            public static delProgramUniformMatrix3x4fv glProgramUniformMatrix3x4fv;
            public static delProgramUniformMatrix4x2fv glProgramUniformMatrix4x2fv;
            public static delProgramUniformMatrix4x3fv glProgramUniformMatrix4x3fv;

            public static delProgramUniformMatrix2x3dv glProgramUniformMatrix2x3dv;
            public static delProgramUniformMatrix2x4dv glProgramUniformMatrix2x4dv;
            public static delProgramUniformMatrix3x2dv glProgramUniformMatrix3x2dv;
            public static delProgramUniformMatrix3x4dv glProgramUniformMatrix3x4dv;
            public static delProgramUniformMatrix4x2dv glProgramUniformMatrix4x2dv;
            public static delProgramUniformMatrix4x3dv glProgramUniformMatrix4x3dv;


            //ARB_vertex_attrib_64bit
            public static delGetVertexAttribLdv glGetVertexAttribLdv;
            public static delVertexAttribLPointer glVertexAttribLPointer;

            /* ignored.
            public static delVertexAttribL1d glVertexAttribL1d;
            public static delVertexAttribL2d glVertexAttribL2d;
            public static delVertexAttribL3d glVertexAttribL3d;
            public static delVertexAttribL4d glVertexAttribL4d;

            public static delVertexAttribL1dv glVertexAttribL1dv;
            public static delVertexAttribL2dv glVertexAttribL2dv;
            public static delVertexAttribL3dv glVertexAttribL3dv;
            public static delVertexAttribL4dv glVertexAttribL4dv;
            */
            
            //ARB_viewport_array
            public static delDepthRangeArrayv glDepthRangeArrayv;
            public static delDepthRangeIndexed glDepthRangeIndexed;
            public static delGetDoublei_v glGetDoublei_v;
            public static delGetFloati_v glGetFloati_v;
            public static delScissorArrayv glScissorArrayv;
            public static delScissorIndexed glScissorIndexed;
            public static delScissorIndexedv glScissorIndexedv;
            public static delViewportArrayv glViewportArrayv;
            public static delViewportIndexedf glViewportIndexedf;
            public static delViewportIndexedfv glViewportIndexedfv;

            #endregion
        }

        #endregion

        #region Public functions.

        //ARB_ES2_compatibility
        /// <summary>
        /// sets the depth value used when clearing the depth buffer. d is clamped to the range [0, 1] when specified.
        /// </summary>
        /// <param name="d"></param>
        public static void ClearDepthf(float d)
        {
            Delegates.glClearDepthf(d);
        }
        /// <summary>
        /// Sets the depth range.
        /// </summary>
        /// <param name="near"></param>
        /// <param name="far"></param>
        public static void DepthRangef(float near, float far)
        {
            Delegates.glDepthRangef(near, far);
        }
        public static void GetShaderPrecisionFormat(ShaderType type, PrecisionType precisiontype, int[] range, int[] precision)
        {
            Delegates.glGetShaderPrecisionFormat(type, precisiontype, range, precision);
        }
        public static void ReleaseShaderCompiler()
        {
            Delegates.glReleaseShaderCompiler();
        }
        public static void ShaderBinary(int count, uint[] shaders, int BinaryFormat, IntPtr binary, int Length)
        {
            Delegates.glShaderBinary(count, shaders, BinaryFormat, binary, Length);
        }

        //ARB_get_program_binary
        /// <summary>
        /// Returns a binary representation of the program object’s compiled and linked exe-cutable source
        /// </summary>
        /// <param name="Program">ID of program to retrive binary for.</param>
        /// <param name="bufSize">Size of buffer allocated for binary ptr.</param>
        /// <param name="Length">Length of binary data written to binary ptr.</param>
        /// <param name="BinaryFormat">Vendor specific format.</param>
        /// <param name="binary">Pointe to write program binary to.</param>
        public static void GetProgramBinary(uint Program, int bufSize, out int Length, out int BinaryFormat, IntPtr binary)
        {
            Delegates.glGetProgramBinary(Program, bufSize, out Length, out BinaryFormat, binary);
        }
        /// <summary>
        /// Returns a binary representation of the program object’s compiled and linked exe-cutable source
        /// </summary>
        /// <param name="Program">ID of program to retrive binary for.</param>
        /// <param name="BinaryFormat">Vendor specific format.</param>
        /// <param name="binary">Buffer of sufficient size to store binary in.(Hint: GetProgramiv(PROGRAM_BINARY_LENGTH) </param>
        /// <returns>Number of bytes actually written to binary buffer.</returns>
        public static int GetProgramBinary(uint Program, out int BinaryFormat, byte[] binary)
        {
            int written = 0;
            GCHandle handle = GCHandle.Alloc(binary, GCHandleType.Pinned);

            Delegates.glGetProgramBinary(Program, binary.Length, out written, out BinaryFormat, handle.AddrOfPinnedObject());

            handle.Free();

            return written;
        }
        /// <summary>
        /// Loads a program object with a program binary previously returned from GetProgramBinary.
        /// </summary>
        /// <param name="Program">Program id to upload code to.</param>
        /// <param name="BinaryFormat">Vendor specific format.</param>
        /// <param name="binary">Pointer to buffer with binary code.</param>
        /// <param name="Length">Length of buffer with binary code.</param>
        public static void ProgramBinary(uint Program, int BinaryFormat, IntPtr binary, int Length)
        {
            Delegates.glProgramBinary(Program, BinaryFormat, binary, Length);
        }
        /// <summary>
        /// Loads a program object with a program binary previously returned from GetProgramBinary.
        /// </summary>
        /// <param name="Program">Program id to upload code to.</param>
        /// <param name="BinaryFormat">Vendor specific format.</param>
        /// <param name="binary">buffer containing binary code. </param>
        public static void ProgramBinary(uint Program, int BinaryFormat, byte[] binary)
        {
            GCHandle handle = GCHandle.Alloc(binary, GCHandleType.Pinned);

            Delegates.glProgramBinary(Program, BinaryFormat, handle.AddrOfPinnedObject(), binary.Length);

            handle.Free();
        }  
        /// <summary>
        /// Sets program parameters
        /// </summary>
        /// <param name="Program">program to set parameter on.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="value">new value of parameter.</param>
        public static void ProgramParameteri(uint Program, ProgramParameters pname, int value)
        {
            Delegates.glProgramParameteri(Program, pname, value);
        }


        //ARB_separate_shader_objects
        public static void UseProgramStages(uint Pipeline, ProgramStages stages, uint Program)
        {
            Delegates.glUseProgramStages(Pipeline, stages, Program);
        }
        public static void ActiveShaderProgram(uint Pipeline, uint Program)
        {
            Delegates.glActiveShaderProgram(Pipeline, Program);
        }
        public static void CreateShaderProgramv(ShaderType type, int count, string[] strings)
        {
            Delegates.glCreateShaderProgramv(type, count, strings);
        }
        /// <summary>
        /// Binds a pipeline as current. 
        /// </summary>
        /// <param name="Pipeline"></param>
        public static void BindProgramPipeline(uint Pipeline)
        {
            Delegates.glBindProgramPipeline(Pipeline);
        }
        /// <summary>
        /// Deletes an array of pipeline ids.
        /// </summary>
        /// <param name="Pipelines"></param>
        public static void DeleteProgramPipelines(uint[] Pipelines)
        {
            Delegates.glDeleteProgramPipelines(Pipelines.Length, ref Pipelines[0]);
        }
        /// <summary>
        /// Deletes a single pipeline id.
        /// </summary>
        /// <param name="Pipeline"></param>
        public static void DeleteProgramPipelines(uint Pipeline)
        {
            Delegates.glDeleteProgramPipelines(1, ref Pipeline);
        }

        /// <summary>
        /// Generates an array of pipeline ids.
        /// </summary>
        /// <param name="Pipelines"></param>
        public static void GenProgramPipelines(uint[] Pipelines)
        {
            Delegates.glGenProgramPipelines(Pipelines.Length, ref Pipelines[0]);
        }
        /// <summary>
        /// Generates a single pipeline id.
        /// </summary>
        /// <returns></returns>
        public static uint GenProgramPipelines()
        {
            uint tmp = 0;
            Delegates.glGenProgramPipelines(1, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Is this a pipeline?
        /// </summary>
        /// <param name="Pipeline"></param>
        /// <returns></returns>
        public static bool IsProgramPipeline(uint Pipeline)
        {
            return Delegates.glIsProgramPipeline(Pipeline);
        }
        //public static void ProgramParameteri;
        /// <summary>
        /// Retrives a parameter value from a pipeline.
        /// </summary>
        /// <param name="Pipeline">id of pipeline to query</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">result</param>
        public static void GetProgramPipelineiv(uint Pipeline, ProgramPipelineParameters pname, int[] @params)
        {
            Delegates.glGetProgramPipelineiv(Pipeline, pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives a parameter value from a pipeline.
        /// </summary>
        /// <param name="Pipeline">id of pipeline to query</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <returns>result</returns>
        public static int GetProgramPipelineiv(uint Pipeline, ProgramPipelineParameters pname)
        {
            int tmp = 0;
            Delegates.glGetProgramPipelineiv(Pipeline, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Validates a program pipeline.
        /// </summary>
        /// <param name="Pipeline"></param>
        public static void ValidateProgramPipeline(uint Pipeline)
        {
            Delegates.glValidateProgramPipeline(Pipeline);
        }

        /// <summary>
        /// Retrives a Program Pipelines info log.
        /// </summary>
        /// <param name="Pipeline">id of pipeline to retrive infolog for.</param>
        /// <param name="bufSize">The capacity of stringbuilder.</param>
        /// <param name="length">number of characters written to stringbuilder.</param>
        /// <param name="infoLog">Stringbuilder where infolog is written to.</param>
        public static void GetProgramPipelineInfoLog(uint Pipeline, int bufSize, out int length, StringBuilder infoLog)
        {
            Delegates.glGetProgramPipelineInfoLog(Pipeline, bufSize, out length, infoLog);
        }
        /// <summary>
        /// Retrives a Program Pipelines info log.
        /// NOTE: this calls GetProgramiv to query info log size!
        /// </summary>
        /// <param name="Pipeline">id of pipeline to retrive infolog for.</param>
        /// <returns>Infolog</returns>
        public static string GetProgramPipelineInfoLog(uint Pipeline)
        {
            var len = GetProgramiv(Pipeline, GetProgramParameters.InfoLogLength);
            if (len > 2)
            {
                var sb = new StringBuilder(len + 4);

                Delegates.glGetProgramPipelineInfoLog(Pipeline, sb.Capacity - 2, out len, sb);

                return sb.ToString();
            }
            else
                return string.Empty;
        }

        public static void ProgramUniform1f(uint Program, int location, float v1)
        {
            Delegates.glProgramUniform1f(Program, location, v1);
        }
        public static void ProgramUniform2f(uint Program, int location, float v1, float v2)
        {
            Delegates.glProgramUniform2f(Program, location, v1, v2);
        }
        public static void ProgramUniform3f(uint Program, int location, float v1, float v2, float v3)
        {
            Delegates.glProgramUniform3f(Program, location, v1, v2, v3);
        }
        public static void ProgramUniform4f(uint Program, int location, float v1, float v2, float v3, float v4)
        {
            Delegates.glProgramUniform4f(Program, location, v1, v2, v3, v4);
        }

        public static void ProgramUniform1d(uint Program, int location, double v1)
        {
            Delegates.glProgramUniform1d(Program, location, v1);
        }
        public static void ProgramUniform2d(uint Program, int location, double v1, double v2)
        {
            Delegates.glProgramUniform2d(Program, location, v1, v2);
        }
        public static void ProgramUniform3d(uint Program, int location, double v1, double v2, double v3)
        {
            Delegates.glProgramUniform3d(Program, location, v1, v2, v3);
        }
        public static void ProgramUniform4d(uint Program, int location, double v1, double v2, double v3, double v4)
        {
            Delegates.glProgramUniform4d(Program, location, v1, v2, v3, v4);
        }

        public static void ProgramUniform1i(uint Program, int location, int v1)
        {
            Delegates.glProgramUniform1i(Program, location, v1);
        }
        public static void ProgramUniform2i(uint Program, int location, int v1, int v2)
        {
            Delegates.glProgramUniform2i(Program, location, v1, v2);
        }
        public static void ProgramUniform3i(uint Program, int location, int v1, int v2, int v3)
        {
            Delegates.glProgramUniform3i(Program, location, v1, v2, v3);
        }
        public static void ProgramUniform4i(uint Program, int location, int v1, int v2, int v3, int v4)
        {
            Delegates.glProgramUniform4i(Program, location, v1, v2, v3, v4);
        }

        public static void ProgramUniform1ui(uint Program, int location, uint v1)
        {
            Delegates.glProgramUniform1ui(Program, location, v1);
        }
        public static void ProgramUniform2ui(uint Program, int location, uint v1, uint v2)
        {
            Delegates.glProgramUniform2ui(Program, location, v1, v2);
        }
        public static void ProgramUniform3ui(uint Program, int location, uint v1, uint v2, uint v3)
        {
            Delegates.glProgramUniform3ui(Program, location, v1, v2, v3);
        }
        public static void ProgramUniform4ui(uint Program, int location, uint v1, uint v2, uint v3, uint v4)
        {
            Delegates.glProgramUniform4ui(Program, location, v1, v2, v3, v4);
        }


        public static void ProgramUniform1fv(uint Program, int location, ref float v, int count = 1)
        {
            Delegates.glProgramUniform1fv(Program, location, count, ref v);
        }
        public static void ProgramUniform2fv(uint Program, int location, ref float v, int count = 1)
        {
            Delegates.glProgramUniform2fv(Program, location, count, ref v);
        }
        public static void ProgramUniform3fv(uint Program, int location, ref float v, int count = 1)
        {
            Delegates.glProgramUniform3fv(Program, location, count, ref v);
        }
        public static void ProgramUniform4fv(uint Program, int location, ref float v, int count = 1)
        {
            Delegates.glProgramUniform4fv(Program, location, count, ref v);
        }

        public static void ProgramUniform1fv(uint Program, int location, float[] v)
        {
            Delegates.glProgramUniform1fv(Program, location, v.Length, ref v[0]);
        }
        public static void ProgramUniform2fv(uint Program, int location, float[] v)
        {
            Delegates.glProgramUniform2fv(Program, location, v.Length / 2, ref v[0]);
        }
        public static void ProgramUniform3fv(uint Program, int location, float[] v)
        {
            Delegates.glProgramUniform3fv(Program, location, v.Length / 3, ref v[0]);
        }
        public static void ProgramUniform4fv(uint Program, int location, float[] v)
        {
            Delegates.glProgramUniform4fv(Program, location, v.Length / 4, ref v[0]);
        }

        public static void ProgramUniform1dv(uint Program, int location, ref double v, int count = 1)
        {
            Delegates.glProgramUniform1dv(Program, location, count, ref v);
        }
        public static void ProgramUniform2dv(uint Program, int location, ref double v, int count = 1)
        {
            Delegates.glProgramUniform2dv(Program, location, count, ref v);
        }
        public static void ProgramUniform3dv(uint Program, int location, ref double v, int count = 1)
        {
            Delegates.glProgramUniform3dv(Program, location, count, ref v);
        }
        public static void ProgramUniform4dv(uint Program, int location, ref double v, int count = 1)
        {
            Delegates.glProgramUniform4dv(Program, location, count, ref v);
        }
        public static void ProgramUniform1dv(uint Program, int location, double[] v)
        {
            Delegates.glProgramUniform1dv(Program, location, v.Length, ref v[0]);
        }
        public static void ProgramUniform2dv(uint Program, int location, double[] v)
        {
            Delegates.glProgramUniform2dv(Program, location, v.Length / 2, ref v[0]);
        }
        public static void ProgramUniform3dv(uint Program, int location, double[] v)
        {
            Delegates.glProgramUniform3dv(Program, location, v.Length / 3, ref v[0]);
        }
        public static void ProgramUniform4dv(uint Program, int location, double[] v)
        {
            Delegates.glProgramUniform4dv(Program, location, v.Length / 4, ref v[0]);
        }

        public static void ProgramUniform1iv(uint Program, int location, ref int v, int count = 1)
        {
            Delegates.glProgramUniform1iv(Program, location, count, ref v);
        }
        public static void ProgramUniform2iv(uint Program, int location, ref int v, int count = 1)
        {
            Delegates.glProgramUniform2iv(Program, location, count, ref v);
        }
        public static void ProgramUniform3iv(uint Program, int location, ref int v, int count = 1)
        {
            Delegates.glProgramUniform3iv(Program, location, count, ref v);
        }
        public static void ProgramUniform4iv(uint Program, int location, ref int v, int count = 1)
        {
            Delegates.glProgramUniform4iv(Program, location, count, ref v);
        }

        public static void ProgramUniform1iv(uint Program, int location, int[] v)
        {
            Delegates.glProgramUniform1iv(Program, location, v.Length, ref v[0]);
        }
        public static void ProgramUniform2iv(uint Program, int location, int[] v)
        {
            Delegates.glProgramUniform2iv(Program, location, v.Length / 2, ref v[0]);
        }
        public static void ProgramUniform3iv(uint Program, int location, int[] v)
        {
            Delegates.glProgramUniform3iv(Program, location, v.Length / 3, ref v[0]);
        }
        public static void ProgramUniform4iv(uint Program, int location, int[] v)
        {
            Delegates.glProgramUniform4iv(Program, location, v.Length / 4, ref v[0]);
        }

        public static void ProgramUniform1uiv(uint Program, int location, ref uint v, int count = 1)
        {
            Delegates.glProgramUniform1uiv(Program, location, count, ref v);
        }
        public static void ProgramUniform2uiv(uint Program, int location, ref uint v, int count = 1)
        {
            Delegates.glProgramUniform2uiv(Program, location, count, ref v);
        }
        public static void ProgramUniform3uiv(uint Program, int location, ref uint v, int count = 1)
        {
            Delegates.glProgramUniform3uiv(Program, location, count, ref v);
        }
        public static void ProgramUniform4uiv(uint Program, int location, ref uint v, int count = 1)
        {
            Delegates.glProgramUniform4uiv(Program, location, count, ref v);
        }

        public static void ProgramUniform1uiv(uint Program, int location, uint[] v)
        {
            Delegates.glProgramUniform1uiv(Program, location, v.Length, ref v[0]);
        }
        public static void ProgramUniform2uiv(uint Program, int location, uint[] v)
        {
            Delegates.glProgramUniform2uiv(Program, location, v.Length / 2, ref v[0]);
        }
        public static void ProgramUniform3uiv(uint Program, int location, uint[] v)
        {
            Delegates.glProgramUniform3uiv(Program, location, v.Length / 3, ref v[0]);
        }
        public static void ProgramUniform4uiv(uint Program, int location, uint[] v)
        {
            Delegates.glProgramUniform4uiv(Program, location, v.Length / 4, ref v[0]);
        }

        public static void ProgramUniformMatrix2fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix2fv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix3fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix3fv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix4fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix4fv(Program, location, count, transpose, ref v);
        }

        public static void ProgramUniformMatrix2dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix2dv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix3dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix3dv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix4dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix4dv(Program, location, count, transpose, ref v);
        }

        public static void ProgramUniformMatrix2x3fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix2x3fv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix2x4fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix2x4fv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix3x2fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix3x2fv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix3x4fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix3x4fv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix4x2fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix4x2fv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix4x3fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix4x3fv(Program, location, count, transpose, ref v);
        }

        public static void ProgramUniformMatrix2x3dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix2x3dv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix2x4dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix2x4dv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix3x2dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix3x2dv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix3x4dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix3x4dv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix4x2dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix4x2dv(Program, location, count, transpose, ref v);
        }
        public static void ProgramUniformMatrix4x3dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            Delegates.glProgramUniformMatrix4x3dv(Program, location, count, transpose, ref v);
        }


        //ARB_vertex_attrib_64bit
        public static void GetVertexAttribLdv(uint index, VertexAttribParameters pname, double[] @params)
        {
            Delegates.glGetVertexAttribLdv(index, pname, ref @params[0]);
        }
        public static double GetVertexAttribLdv(uint index, VertexAttribParameters pname)
        {
            double tmp = 0.0d;
            Delegates.glGetVertexAttribLdv(index, pname, ref tmp);
            return tmp;
        }

        public static void VertexAttribLPointer(uint index, int size, VertexAttribLFormat type, int stride, long Offset)
        {
            Delegates.glVertexAttribLPointer(index, size, type, stride, (IntPtr)Offset);
        }

        /* ignored.
        public static void VertexAttribL1d(uint index, double v1)
        {
            Delegates.glVertexAttrib1d(index, v1);
        }
        public static void VertexAttribL2d(uint index, double v1, double v2)
        {
            Delegates.glVertexAttrib2d(index, v1, v2);
        }
        public static void VertexAttribL3d(uint index, double v1, double v2, double v3)
        {
            Delegates.glVertexAttrib3d(index, v1, v2, v3);
        }
        public static void VertexAttribL4d(uint index, double v1, double v2, double v3, double v4)
        {
            Delegates.glVertexAttrib4d(index, v1, v2, v3, v4);
        }

        public static void VertexAttribL1dv(uint index, ref double v)
        {
            Delegates.glVertexAttribL1dv(index, ref v);
        }
        public static void VertexAttribL2dv(uint index, ref double v)
        {
            Delegates.glVertexAttribL2dv(index, ref v);
        }
        public static void VertexAttribL3dv(uint index, ref double v)
        {
            Delegates.glVertexAttribL3dv(index, ref v);
        }
        public static void VertexAttribL4dv(uint index, ref double v)
        {
            Delegates.glVertexAttribL4dv(index, ref v);
        }
        */

        //ARB_viewport_array
        /// <summary>
        /// DepthRangeArrayv is used to specify the depth range for multiple viewports simultaneously.
        /// Viewports whose indices lie outside the range [first; first + v.Length) are not modified.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="v">The v parameter contains the address of an array of double types specifying near (n) and far (f) for each viewport in that order. Values in v are each clamped to the range [0; 1] when specified.</param>
        public static void DepthRangeArrayv(uint first, double[] v)
        {
            Delegates.glDepthRangeArrayv(first, v.Length / 2, ref v[0]);
        }

        /// <summary>
        /// DepthRangeIndexed specifies the depth range for a single viewport
        /// </summary>
        /// <param name="index">Viewport to set depthrange for. Needs to be in range [0, MAX_VIEWPORTS]</param>
        /// <param name="near"></param>
        /// <param name="far"></param>
        public static void DepthRangeIndexed(uint index, double near, double far)
        {
            Delegates.glDepthRangeIndexed(index, near, far);
        }
        /// <summary>
        /// Gets double values from an indexed parameter targets.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning is dependert on pname.</param>
        /// <param name="data"></param>
        public static void GetDoublei_v(GetParameters pname, uint index, double[] data)
        {
            Delegates.glGetDoublei_v(pname, index, ref data[0]);
        }
        /// <summary>
        /// Gets float values from an indexed parameter target.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning is dependert on pname.</param>
        /// <param name="data"></param>
        public static void GetFloati_v(GetParameters pname, uint index, float[] data)
        {
            Delegates.glGetFloati_v(pname, index, ref data[0]);
        }
        /// <summary>
        /// glScissorArrayv is used to specify the scissor for multiple viewports simultaneously.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="v">The v parameter contains the address of an array of int types specifying left, bottom, width and height and for each viewport in that order.</param>
        public static void ScissorArrayv(uint first, int[] v)
        {
            Delegates.glScissorArrayv(first, v.Length / 4, ref v[0]);
        }
        /// <summary>
        /// Sets the scissor box for a single viewport.
        /// </summary>
        /// <param name="index">Index of viewport to set.</param>
        /// <param name="left"></param>
        /// <param name="bottom"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public static void ScissorIndexed(uint index, int left, int bottom, int width, int height)
        {
            Delegates.glScissorIndexed(index, left, bottom, width, height);
        }
        /// <summary>
        /// Sets the scissor box for a single viewport
        /// </summary>
        /// <param name="index">Index of viewport to set.</param>
        /// <param name="vScissorRect">int array with values[left, bottom, width, height]</param>
        public static void ScissorIndexedv(uint index, int[] vScissorRect)
        {
            Delegates.glScissorIndexedv(index, ref vScissorRect[0]);
        }

        /// <summary>
        /// ViewportArrayv is used to specify the Viewport for multiple viewports simultaneously.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="v">The v parameter contains the address of an array of int types specifying x, y, width and height and for each viewport in that order.</param>
        public static void ViewportArrayv(uint first, float[] v)
        {
            Delegates.glViewportArrayv(first, v.Length / 4, ref v[0]);
        }
        /// <summary>
        /// Sets the viewport for a single viewport
        /// </summary>
        /// <param name="index">Index of viewport to set.</param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        public static void ViewportIndexedf(uint index, float x, float y, float w, float h)
        {
            Delegates.glViewportIndexedf(index, x, y, w, h);
        }
        /// <summary>
        /// Sets the viewport for a single viewport
        /// </summary>
        /// <param name="index">Index of viewport to set.</param>
        /// <param name="viewport">float array containg [x, y, width, height]</param>
        public static void ViewportIndexedfv(uint index, float[] viewport)
        {
            Delegates.glViewportIndexedfv(index, ref viewport[0]);
        }


        #endregion
    }
}
