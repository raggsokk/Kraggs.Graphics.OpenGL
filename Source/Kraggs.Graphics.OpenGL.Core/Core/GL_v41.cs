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

        //ARB_ES2_compatibility
        [EntryPointSlot(321)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glClearDepthf(float d);
        [EntryPointSlot(322)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDepthRangef(float near, float far);
        [EntryPointSlot(323)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetShaderPrecisionFormat(ShaderType type, PrecisionType precisiontype, int* range, int* precision);
        [EntryPointSlot(324)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glReleaseShaderCompiler();
        [EntryPointSlot(325)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glShaderBinary(int count, uint* shaders, int BinaryFormat, IntPtr binary, int Length);

        //ARB_get_program_binary
        [EntryPointSlot(326)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetProgramBinary(uint Program, int bufSize, out int Length, out int BinaryFormat, IntPtr binary);
        [EntryPointSlot(327)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramBinary(uint Program, int BinaryFormat, IntPtr binary, int Length);
        [EntryPointSlot(328)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramParameteri(uint Program, ProgramParameters pname, int value);

        //ARB_separate_shader_objects
        [EntryPointSlot(329)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUseProgramStages(uint Pipeline, ProgramStages stages, uint Program);
        [EntryPointSlot(330)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glActiveShaderProgram(uint Pipeline, uint Program);
        [EntryPointSlot(331)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glCreateShaderProgramv(ShaderType type, int count, IntPtr strings);
        [EntryPointSlot(332)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindProgramPipeline(uint Pipeline);
        [EntryPointSlot(333)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glDeleteProgramPipelines(int number, uint* Pipelines);
        [EntryPointSlot(334)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGenProgramPipelines(int number, uint* Pipelines);
        [EntryPointSlot(335)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsProgramPipeline(uint pipeline);
        //private static extern void glProgramParameteri;
        [EntryPointSlot(336)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetProgramPipelineiv(uint pipeline, ProgramPipelineParameters pname, int* result);

        [EntryPointSlot(337)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glValidateProgramPipeline(uint Pipeline);
        [EntryPointSlot(338)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, out int length, IntPtr infoLog);

        [EntryPointSlot(339)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform1f(uint Program, int location, float v1);
        [EntryPointSlot(340)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform2f(uint Program, int location, float v1, float v2);
        [EntryPointSlot(341)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform3f(uint Program, int location, float v1, float v2, float v3);
        [EntryPointSlot(342)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform4f(uint Program, int location, float v1, float v2, float v3, float v4);

        [EntryPointSlot(343)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform1d(uint Program, int location, double v1);
        [EntryPointSlot(344)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform2d(uint Program, int location, double v1, double v2);
        [EntryPointSlot(345)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform3d(uint Program, int location, double v1, double v2, double v3);
        [EntryPointSlot(346)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform4d(uint Program, int location, double v1, double v2, double v3, double v4);

        [EntryPointSlot(347)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform1i(uint Program, int location, int v1);
        [EntryPointSlot(348)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform2i(uint Program, int location, int v1, int v2);
        [EntryPointSlot(349)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform3i(uint Program, int location, int v1, int v2, int v3);
        [EntryPointSlot(350)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform4i(uint Program, int location, int v1, int v2, int v3, int v4);

        [EntryPointSlot(351)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform1ui(uint Program, int location, uint v1);
        [EntryPointSlot(352)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform2ui(uint Program, int location, uint v1, uint v2);
        [EntryPointSlot(353)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform3ui(uint Program, int location, uint v1, uint v2, uint v3);
        [EntryPointSlot(354)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform4ui(uint Program, int location, uint v1, uint v2, uint v3, uint v4);


        [EntryPointSlot(355)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform1fv(uint Program, int location, int count, float* v);
        [EntryPointSlot(356)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform2fv(uint Program, int location, int count, float* v);
        [EntryPointSlot(357)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform3fv(uint Program, int location, int count, float* v);
        [EntryPointSlot(358)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform4fv(uint Program, int location, int count, float* v);

        [EntryPointSlot(359)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform1dv(uint Program, int location, int count, double* v);
        [EntryPointSlot(360)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform2dv(uint Program, int location, int count, double* v);
        [EntryPointSlot(361)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform3dv(uint Program, int location, int count, double* v);
        [EntryPointSlot(362)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform4dv(uint Program, int location, int count, double* v);

        [EntryPointSlot(363)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform1iv(uint Program, int location, int count, int* v);
        [EntryPointSlot(364)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform2iv(uint Program, int location, int count, int* v);
        [EntryPointSlot(365)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform3iv(uint Program, int location, int count, int* v);
        [EntryPointSlot(366)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform4iv(uint Program, int location, int count, int* v);

        [EntryPointSlot(367)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform1uiv(uint Program, int location, int count, uint* v);
        [EntryPointSlot(368)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform2uiv(uint Program, int location, int count, uint* v);
        [EntryPointSlot(369)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform3uiv(uint Program, int location, int count, uint* v);
        [EntryPointSlot(370)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform4uiv(uint Program, int location, int count, uint* v);

        [EntryPointSlot(371)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix2fv(uint Program, int location, int count, bool transpose, float* v);
        [EntryPointSlot(372)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix3fv(uint Program, int location, int count, bool transpose, float* v);
        [EntryPointSlot(373)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix4fv(uint Program, int location, int count, bool transpose, float* v);

        [EntryPointSlot(374)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix2dv(uint Program, int location, int count, bool transpose, double* v);
        [EntryPointSlot(375)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix3dv(uint Program, int location, int count, bool transpose, double* v);
        [EntryPointSlot(376)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix4dv(uint Program, int location, int count, bool transpose, double* v);

        [EntryPointSlot(377)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix2x3fv(uint Program, int location, int count, bool transpose, float* v);
        [EntryPointSlot(378)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix2x4fv(uint Program, int location, int count, bool transpose, float* v);
        [EntryPointSlot(379)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix3x2fv(uint Program, int location, int count, bool transpose, float* v);
        [EntryPointSlot(380)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix3x4fv(uint Program, int location, int count, bool transpose, float* v);
        [EntryPointSlot(381)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix4x2fv(uint Program, int location, int count, bool transpose, float* v);
        [EntryPointSlot(382)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix4x3fv(uint Program, int location, int count, bool transpose, float* v);

        [EntryPointSlot(383)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix2x3dv(uint Program, int location, int count, bool transpose, double* v);
        [EntryPointSlot(384)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix2x4dv(uint Program, int location, int count, bool transpose, double* v);
        [EntryPointSlot(385)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix3x2dv(uint Program, int location, int count, bool transpose, double* v);
        [EntryPointSlot(386)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix3x4dv(uint Program, int location, int count, bool transpose, double* v);
        [EntryPointSlot(387)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix4x2dv(uint Program, int location, int count, bool transpose, double* v);
        [EntryPointSlot(388)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix4x3dv(uint Program, int location, int count, bool transpose, double* v);

        //ARB_vertex_attrib_64bit
        [EntryPointSlot(389)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexAttribLPointer(uint index, int size, VertexAttribLFormat type, int stride, IntPtr ptr);
        [EntryPointSlot(390)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetVertexAttribLdv(uint index, VertexAttribParameters pname, double* result);

        /* ignored.
        private static extern void glVertexAttribL1d(uint index, double v1);
        private static extern void glVertexAttribL2d(uint index, double v1, double v2);
        private static extern void glVertexAttribL3d(uint index, double v1, double v2, double v3);
        private static extern void glVertexAttribL4d(uint index, double v1, double v2, double v3, double v4);

        unsafe private static extern void glVertexAttribL1dv(uint index, double* v);
        unsafe private static extern void glVertexAttribL2dv(uint index, double* v);
        unsafe private static extern void glVertexAttribL3dv(uint index, double* v);
        unsafe private static extern void glVertexAttribL4dv(uint index, double* v);
        */


        //ARB_viewport_array
        [EntryPointSlot(391)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glDepthRangeArrayv(uint first, int count, double* v);
        [EntryPointSlot(392)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDepthRangeIndexed(uint index, double near, double far);
        [EntryPointSlot(393)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetDoublei_v(GetParameters pname, uint index, double* data);
        [EntryPointSlot(394)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetFloati_v(GetParameters pname, uint index, float* data);
        [EntryPointSlot(395)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glScissorArrayv(uint first, int count, int* v);
        [EntryPointSlot(396)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glScissorIndexed(uint index, int left, int bottom, int width, int height);
        [EntryPointSlot(397)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glScissorIndexedv(uint index, int* vScissorRect);
        [EntryPointSlot(398)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glViewportArrayv(uint first, int count, float* v);
        [EntryPointSlot(399)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glViewportIndexedf(uint index, float x, float y, float w, float h);
        [EntryPointSlot(400)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glViewportIndexedfv(uint index, float* viewport);


        #endregion

        #region Public functions

        //ARB_ES2_compatibility
        /// <summary>
        /// sets the depth value used when clearing the depth buffer. d is clamped to the range [0, 1] when specified.
        /// </summary>
        /// <param name="d"></param>
        [EntryPoint(FunctionName = "glClearDepthf")]
        public static void ClearDepthf(float d){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets the depth range.
        /// </summary>
        /// <param name="near"></param>
        /// <param name="far"></param>
        [EntryPoint(FunctionName = "glDepthRangef")]
        public static void DepthRangef(float near, float far){ throw new NotImplementedException(); }

        /// <summary>
        /// returns the range and precision for different numeric formats supported by the shader compiler.
        /// </summary>
        /// <param name="type"> must be VERTEX_SHADER or FRAGMENT_SHADER.</param>
        /// <param name="precisiontype">must be one of LOW_FLOAT, MEDIUM_FLOAT, HIGH_FLOAT, LOW_INT, MEDIUM_INT or HIGH_INT.</param>
        /// <param name="range">points to an array of two integers in which encodings of the format's numeric range are returned.</param>
        /// <param name="precision">points to an integer in which the log2 value of the number of bits of precision of the format is returned.</param>
        [EntryPoint(FunctionName = "glGetShaderPrecisionFormat")]
        unsafe public static void GetShaderPrecisionFormat(ShaderType type, PrecisionType precisiontype, int* range, int* precision){ throw new NotImplementedException(); }
        /// <summary>
        /// returns the range and precision for different numeric formats supported by the shader compiler.
        /// </summary>
        /// <param name="type"> must be VERTEX_SHADER or FRAGMENT_SHADER.</param>
        /// <param name="precisiontype">must be one of LOW_FLOAT, MEDIUM_FLOAT, HIGH_FLOAT, LOW_INT, MEDIUM_INT or HIGH_INT.</param>
        /// <param name="range">points to an array of two integers in which encodings of the format's numeric range are returned.</param>
        /// <param name="precision">points to an integer in which the log2 value of the number of bits of precision of the format is returned.</param>
        [EntryPoint(FunctionName = "glGetShaderPrecisionFormat")]
        public static void GetShaderPrecisionFormat(ShaderType type, PrecisionType precisiontype, int[] range, int[] precision) { throw new NotImplementedException(); }
        /// <summary>
        /// returns the range and precision for different numeric formats supported by the shader compiler.
        /// </summary>
        /// <param name="type"> must be VERTEX_SHADER or FRAGMENT_SHADER.</param>
        /// <param name="precisiontype">must be one of LOW_FLOAT, MEDIUM_FLOAT, HIGH_FLOAT, LOW_INT, MEDIUM_INT or HIGH_INT.</param>
        /// <param name="range">points to an array of two integers in which encodings of the format's numeric range are returned.</param>
        /// <param name="precision">points to an integer in which the log2 value of the number of bits of precision of the format is returned.</param>
        [EntryPoint(FunctionName = "glGetShaderPrecisionFormat")]
        public static void GetShaderPrecisionFormat(ShaderType type, PrecisionType precisiontype, ref int range, ref int precision) { throw new NotImplementedException(); }
        /// <summary>
        /// returns the range and precision for different numeric formats supported by the shader compiler.
        /// </summary>
        /// <param name="type"> must be VERTEX_SHADER or FRAGMENT_SHADER.</param>
        /// <param name="precisiontype">must be one of LOW_FLOAT, MEDIUM_FLOAT, HIGH_FLOAT, LOW_INT, MEDIUM_INT or HIGH_INT.</param>
        /// <param name="range">points to an array of two integers in which encodings of the format's numeric range are returned.</param>
        /// <param name="precision">points to an integer in which the log2 value of the number of bits of precision of the format is returned.</param>
        public static void GetShaderPrecisionFormat(ShaderType type, PrecisionType precisiontype, out int[] range, out int precision)
        {
            var r = new int[2];
            var p = 0;
            GetShaderPrecisionFormat(type, precisiontype, ref r[0], ref p);
            range = r;
            precision = p;
        }
        /// <summary>
        /// OpenGL Desktop never releases its compiler so this is a noop.
        /// </summary>
        [EntryPoint(FunctionName = "glReleaseShaderCompiler")]
        public static void ReleaseShaderCompiler(){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glShaderBinary")]
        unsafe public static void ShaderBinary(int count, uint* shaders, int BinaryFormat, IntPtr binary, int Length){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glShaderBinary")]
        private static void ShaderBinary(int count, ref uint shaders, int BinaryFormat, IntPtr binary, int Length) { throw new NotImplementedException(); }
        unsafe public static void ShaderBinary(uint[] shaders, int BinaryFormat, byte[] binary)
        {
            fixed(byte* ptr = &binary[0])
            {
                ShaderBinary(shaders.Length, ref shaders[0], BinaryFormat, (IntPtr)ptr, binary.Length);
            }
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
        [EntryPoint(FunctionName = "glGetProgramBinary")]
        public static void GetProgramBinary(uint Program, int bufSize, out int Length, out int BinaryFormat, IntPtr binary){ throw new NotImplementedException(); }

        /// <summary>
        /// Returns a binary representation of the program object’s compiled and linked exe-cutable source
        /// </summary>
        /// <param name="Program">ID of program to retrive binary for.</param>
        /// <param name="Length">Length of binary data written to binary.</param>
        /// <param name="BinaryFormat">Vendor specific format.</param>
        /// <param name="binary">Pointe to write program binary to.</param>
        unsafe public static void GetProgramBinary(uint Program, out int Length, out int BinaryFormat, byte[] binary)
        {
            fixed(byte* ptr = &binary[0])
            {
                GetProgramBinary(Program, binary.Length, out Length, out BinaryFormat, (IntPtr)ptr);
            }
            
        }

        /// <summary>
        /// Loads a program object with a program binary previously returned from GetProgramBinary.
        /// </summary>
        /// <param name="Program">Program id to upload code to.</param>
        /// <param name="BinaryFormat">Vendor specific format.</param>
        /// <param name="binary">Pointer to buffer with binary code.</param>
        /// <param name="Length">Length of buffer with binary code.</param>
        [EntryPoint(FunctionName = "glProgramBinary")]
        public static void ProgramBinary(uint Program, int BinaryFormat, IntPtr binary, int Length){ throw new NotImplementedException(); }
        /// <summary>
        /// Loads a program object with a program binary previously returned from GetProgramBinary.
        /// </summary>
        /// <param name="Program">Program id to upload code to.</param>
        /// <param name="BinaryFormat">Vendor specific format.</param>
        /// <param name="binary">buffer containing binary code. </param>
        unsafe public static void ProgramBinary(uint Program, int BinaryFormat, byte[] binary)
        {
            fixed(byte* ptr = &binary[0])
            {
                ProgramBinary(Program, BinaryFormat, (IntPtr)ptr, binary.Length);
            }
        }
        /// <summary>
        /// Sets program parameters
        /// </summary>
        /// <param name="Program">program to set parameter on.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="value">new value of parameter.</param>
        [EntryPoint(FunctionName = "glProgramParameteri")]
        public static void ProgramParameteri(uint Program, ProgramParameters pname, int value){ throw new NotImplementedException(); }

        //ARB_separate_shader_objects
        
        [EntryPoint(FunctionName = "glUseProgramStages")]
        public static void UseProgramStages(uint Pipeline, ProgramStages stages, uint Program){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glActiveShaderProgram")]
        public static void ActiveShaderProgram(uint Pipeline, uint Program){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glCreateShaderProgramv")]
        public static void CreateShaderProgramv(ShaderType type, int count, string[] strings){ throw new NotImplementedException(); }

        /// <summary>
        /// Binds a pipeline as current. 
        /// </summary>
        /// <param name="Pipeline"></param>
        [EntryPoint(FunctionName = "glBindProgramPipeline")]
        public static void BindProgramPipeline(uint Pipeline){ throw new NotImplementedException(); }

        /// <summary>
        /// Deletes an array of pipeline ids.
        /// </summary>
        /// <param name="Pipelines"></param>
        [EntryPoint(FunctionName = "glDeleteProgramPipelines")]
        unsafe public static void DeleteProgramPipelines(int number, uint* Pipelines){ throw new NotImplementedException(); }
        /// <summary>
        /// Deletes an array of pipeline ids.
        /// </summary>
        /// <param name="Pipelines"></param>
        [EntryPoint(FunctionName = "glDeleteProgramPipelines")]
        public static void DeleteProgramPipelines(int number, uint[] Pipelines) { throw new NotImplementedException(); }
        /// <summary>
        /// Deletes an array of pipeline ids.
        /// </summary>
        /// <param name="Pipelines"></param>
        [EntryPoint(FunctionName = "glDeleteProgramPipelines")]
        public static void DeleteProgramPipelines(int number, ref uint Pipelines) { throw new NotImplementedException(); }
        /// <summary>
        /// Deletes a single pipeline id.
        /// </summary>
        /// <param name="Pipeline"></param>
        public static void DeleteProgramPipelines(uint Pipeline)
        {
            DeleteProgramPipelines(1, ref Pipeline);
        }
        /// <summary>
        /// Generates an array of pipeline ids.
        /// </summary>
        /// <param name="Pipelines"></param>
        [EntryPoint(FunctionName = "glGenProgramPipelines")]
        unsafe public static void GenProgramPipelines(int number, uint* Pipelines){ throw new NotImplementedException(); }
        /// <summary>
        /// Generates an array of pipeline ids.
        /// </summary>
        /// <param name="Pipelines"></param>
        [EntryPoint(FunctionName = "glGenProgramPipelines")]
        public static void GenProgramPipelines(int number, uint[] Pipelines) { throw new NotImplementedException(); }
        /// <summary>
        /// Generates an array of pipeline ids.
        /// </summary>
        /// <param name="Pipelines"></param>
        [EntryPoint(FunctionName = "glGenProgramPipelines")]
        public static void GenProgramPipelines(int number, ref uint Pipelines) { throw new NotImplementedException(); }
        /// <summary>
        /// Generates a single pipeline id.
        /// </summary>
        /// <returns></returns>
        public static uint GenProgramPipelines()
        {
            uint tmp = 0;
            GenProgramPipelines(1, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Is this a pipeline?
        /// </summary>
        /// <param name="Pipeline"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glIsProgramPipeline")]
        public static bool IsProgramPipeline(uint pipeline){ throw new NotImplementedException(); }
        //public static void ProgramParameteri{ throw new NotImplementedException(); }

        /// <summary>
        /// Retrives a parameter value from a pipeline.
        /// </summary>
        /// <param name="Pipeline">id of pipeline to query</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">result</param>
        [EntryPoint(FunctionName = "glGetProgramPipelineiv")]
        unsafe public static void GetProgramPipelineiv(uint pipeline, ProgramPipelineParameters pname, int* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a parameter value from a pipeline.
        /// </summary>
        /// <param name="Pipeline">id of pipeline to query</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">result</param>
        [EntryPoint(FunctionName = "glGetProgramPipelineiv")]
        public static void GetProgramPipelineiv(uint pipeline, ProgramPipelineParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a parameter value from a pipeline.
        /// </summary>
        /// <param name="Pipeline">id of pipeline to query</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">result</param>
        [EntryPoint(FunctionName = "glGetProgramPipelineiv")]
        public static void GetProgramPipelineiv(uint pipeline, ProgramPipelineParameters pname, ref int result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a parameter value from a pipeline.
        /// </summary>
        /// <param name="Pipeline">id of pipeline to query</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <returns>result</returns>
        [EntryPoint(FunctionName = "glGetProgramPipelineiv")]
        public static int GetProgramPipelineiv(uint pipeline, ProgramPipelineParameters pname) { throw new NotImplementedException(); }

        /// <summary>
        /// Validates a program pipeline.
        /// </summary>
        /// <param name="Pipeline"></param>
        [EntryPoint(FunctionName = "glValidateProgramPipeline")]
        public static void ValidateProgramPipeline(uint Pipeline){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrives a Program Pipelines info log.
        /// </summary>
        /// <param name="Pipeline">id of pipeline to retrive infolog for.</param>
        /// <param name="bufSize">The capacity of stringbuilder.</param>
        /// <param name="length">number of characters written to stringbuilder.</param>
        /// <param name="infoLog">Stringbuilder where infolog is written to.</param>
        [EntryPoint(FunctionName = "glGetProgramPipelineInfoLog")]
        public static void GetProgramPipelineInfoLog(uint pipeline, int bufSize, out int length, StringBuilder infoLog){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a Program Pipelines info log.
        /// NOTE: this calls GetProgramiv to query info log size!
        /// </summary>
        /// <param name="Pipeline">id of pipeline to retrive infolog for.</param>
        /// <returns>Infolog</returns>
        public static string GetProgramPipelineInfoLog(uint pipeline)
        {
            var len = GetProgramiv(pipeline, GetProgramParameters.InfoLogLength);

            if (len > 2)
            {
                var sb = new StringBuilder(len + 4);
                GetProgramPipelineInfoLog(pipeline, sb.Capacity - 2, out len, sb);
                return sb.ToString();
            }
            else
                return string.Empty;
        }

        [EntryPoint(FunctionName = "glProgramUniform1f")]
        public static void ProgramUniform1f(uint Program, int location, float v1){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform2f")]
        public static void ProgramUniform2f(uint Program, int location, float v1, float v2){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform3f")]
        public static void ProgramUniform3f(uint Program, int location, float v1, float v2, float v3){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform4f")]
        public static void ProgramUniform4f(uint Program, int location, float v1, float v2, float v3, float v4){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glProgramUniform1d")]
        public static void ProgramUniform1d(uint Program, int location, double v1){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform2d")]
        public static void ProgramUniform2d(uint Program, int location, double v1, double v2){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform3d")]
        public static void ProgramUniform3d(uint Program, int location, double v1, double v2, double v3){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform4d")]
        public static void ProgramUniform4d(uint Program, int location, double v1, double v2, double v3, double v4){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glProgramUniform1i")]
        public static void ProgramUniform1i(uint Program, int location, int v1){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform2i")]
        public static void ProgramUniform2i(uint Program, int location, int v1, int v2){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform3i")]
        public static void ProgramUniform3i(uint Program, int location, int v1, int v2, int v3){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform4i")]
        public static void ProgramUniform4i(uint Program, int location, int v1, int v2, int v3, int v4){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glProgramUniform1ui")]
        public static void ProgramUniform1ui(uint Program, int location, uint v1){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform2ui")]
        public static void ProgramUniform2ui(uint Program, int location, uint v1, uint v2){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform3ui")]
        public static void ProgramUniform3ui(uint Program, int location, uint v1, uint v2, uint v3){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform4ui")]
        public static void ProgramUniform4ui(uint Program, int location, uint v1, uint v2, uint v3, uint v4){ throw new NotImplementedException(); }


        
        [EntryPoint(FunctionName = "glProgramUniform1fv")]
        unsafe public static void ProgramUniform1fv(uint Program, int location, int count, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1fv")]
        public static void ProgramUniform1fv(uint Program, int location, int count, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1fv")]
        public static void ProgramUniform1fv(uint Program, int location, int count, ref float v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform2fv")]
        unsafe public static void ProgramUniform2fv(uint Program, int location, int count, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2fv")]
        public static void ProgramUniform2fv(uint Program, int location, int count, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2fv")]
        public static void ProgramUniform2fv(uint Program, int location, int count, ref float v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform3fv")]
        unsafe public static void ProgramUniform3fv(uint Program, int location, int count, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3fv")]
        public static void ProgramUniform3fv(uint Program, int location, int count, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3fv")]
        public static void ProgramUniform3fv(uint Program, int location, int count, ref float v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform4fv")]
        unsafe public static void ProgramUniform4fv(uint Program, int location, int count, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4fv")]
        public static void ProgramUniform4fv(uint Program, int location, int count, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4fv")]
        public static void ProgramUniform4fv(uint Program, int location, int count, ref float v) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glProgramUniform1dv")]
        unsafe public static void ProgramUniform1dv(uint Program, int location, int count, double* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1dv")]
        public static void ProgramUniform1dv(uint Program, int location, int count, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1dv")]
        public static void ProgramUniform1dv(uint Program, int location, int count, ref double v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform2dv")]
        unsafe public static void ProgramUniform2dv(uint Program, int location, int count, double* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2dv")]
        public static void ProgramUniform2dv(uint Program, int location, int count, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2dv")]
        public static void ProgramUniform2dv(uint Program, int location, int count, ref double v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform3dv")]
        unsafe public static void ProgramUniform3dv(uint Program, int location, int count, double* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3dv")]
        public static void ProgramUniform3dv(uint Program, int location, int count, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3dv")]
        public static void ProgramUniform3dv(uint Program, int location, int count, ref double v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform4dv")]
        unsafe public static void ProgramUniform4dv(uint Program, int location, int count, double* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4dv")]
        public static void ProgramUniform4dv(uint Program, int location, int count, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4dv")]
        public static void ProgramUniform4dv(uint Program, int location, int count, ref double v) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glProgramUniform1iv")]
        unsafe public static void ProgramUniform1iv(uint Program, int location, int count, int* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1iv")]
        public static void ProgramUniform1iv(uint Program, int location, int count, int[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1iv")]
        public static void ProgramUniform1iv(uint Program, int location, int count, ref int v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform2iv")]
        unsafe public static void ProgramUniform2iv(uint Program, int location, int count, int* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2iv")]
        public static void ProgramUniform2iv(uint Program, int location, int count, int[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2iv")]
        public static void ProgramUniform2iv(uint Program, int location, int count, ref int v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform3iv")]
        unsafe public static void ProgramUniform3iv(uint Program, int location, int count, int* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3iv")]
        public static void ProgramUniform3iv(uint Program, int location, int count, int[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3iv")]
        public static void ProgramUniform3iv(uint Program, int location, int count, ref int v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform4iv")]
        unsafe public static void ProgramUniform4iv(uint Program, int location, int count, int* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4iv")]
        public static void ProgramUniform4iv(uint Program, int location, int count, int[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4iv")]
        public static void ProgramUniform4iv(uint Program, int location, int count, ref int v) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glProgramUniform1uiv")]
        unsafe public static void ProgramUniform1uiv(uint Program, int location, int count, uint* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1uiv")]
        public static void ProgramUniform1uiv(uint Program, int location, int count, uint[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1uiv")]
        public static void ProgramUniform1uiv(uint Program, int location, int count, ref uint v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform2uiv")]
        unsafe public static void ProgramUniform2uiv(uint Program, int location, int count, uint* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2uiv")]
        public static void ProgramUniform2uiv(uint Program, int location, int count, uint[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2uiv")]
        public static void ProgramUniform2uiv(uint Program, int location, int count, ref uint v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform3uiv")]
        unsafe public static void ProgramUniform3uiv(uint Program, int location, int count, uint* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3uiv")]
        public static void ProgramUniform3uiv(uint Program, int location, int count, uint[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3uiv")]
        public static void ProgramUniform3uiv(uint Program, int location, int count, ref uint v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform4uiv")]
        unsafe public static void ProgramUniform4uiv(uint Program, int location, int count, uint* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4uiv")]
        public static void ProgramUniform4uiv(uint Program, int location, int count, uint[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4uiv")]
        public static void ProgramUniform4uiv(uint Program, int location, int count, ref uint v) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glProgramUniformMatrix2fv")]
        unsafe public static void ProgramUniformMatrix2fv(uint Program, int location, int count, bool transpose, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2fv")]
        public static void ProgramUniformMatrix2fv(uint Program, int location, int count, bool transpose, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2fv")]
        public static void ProgramUniformMatrix2fv(uint Program, int location, int count, bool transpose, ref float v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix2fv(uint Program, int location, float[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2fv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix2fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2fv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix3fv")]
        unsafe public static void ProgramUniformMatrix3fv(uint Program, int location, int count, bool transpose, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3fv")]
        public static void ProgramUniformMatrix3fv(uint Program, int location, int count, bool transpose, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3fv")]
        public static void ProgramUniformMatrix3fv(uint Program, int location, int count, bool transpose, ref float v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix3fv(uint Program, int location, float[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3fv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix3fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3fv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix4fv")]
        unsafe public static void ProgramUniformMatrix4fv(uint Program, int location, int count, bool transpose, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4fv")]
        public static void ProgramUniformMatrix4fv(uint Program, int location, int count, bool transpose, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4fv")]
        public static void ProgramUniformMatrix4fv(uint Program, int location, int count, bool transpose, ref float v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix4fv(uint Program, int location, float[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4fv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix4fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4fv(Program, location, count, transpose, ref v);
        }


        [EntryPoint(FunctionName = "glProgramUniformMatrix2dv")]
        unsafe public static void ProgramUniformMatrix2dv(uint Program, int location, int count, bool transpose, double* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2dv")]
        public static void ProgramUniformMatrix2dv(uint Program, int location, int count, bool transpose, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2dv")]
        public static void ProgramUniformMatrix2dv(uint Program, int location, int count, bool transpose, ref double v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix2dv(uint Program, int location, double[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2dv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix2dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2dv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix3dv")]
        unsafe public static void ProgramUniformMatrix3dv(uint Program, int location, int count, bool transpose, double* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3dv")]
        public static void ProgramUniformMatrix3dv(uint Program, int location, int count, bool transpose, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3dv")]
        public static void ProgramUniformMatrix3dv(uint Program, int location, int count, bool transpose, ref double v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix3dv(uint Program, int location, double[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3dv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix3dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3dv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix4dv")]
        unsafe public static void ProgramUniformMatrix4dv(uint Program, int location, int count, bool transpose, double* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4dv")]
        public static void ProgramUniformMatrix4dv(uint Program, int location, int count, bool transpose, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4dv")]
        public static void ProgramUniformMatrix4dv(uint Program, int location, int count, bool transpose, ref double v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix4dv(uint Program, int location, double[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4dv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix4dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4dv(Program, location, count, transpose, ref v);
        }


        [EntryPoint(FunctionName = "glProgramUniformMatrix2x3fv")]
        unsafe public static void ProgramUniformMatrix2x3fv(uint Program, int location, int count, bool transpose, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x3fv")]
        public static void ProgramUniformMatrix2x3fv(uint Program, int location, int count, bool transpose, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x3fv")]
        public static void ProgramUniformMatrix2x3fv(uint Program, int location, int count, bool transpose, ref float v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix2x3fv(uint Program, int location, float[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2x3fv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix2x3fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2x3fv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix2x4fv")]
        unsafe public static void ProgramUniformMatrix2x4fv(uint Program, int location, int count, bool transpose, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x4fv")]
        public static void ProgramUniformMatrix2x4fv(uint Program, int location, int count, bool transpose, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x4fv")]
        public static void ProgramUniformMatrix2x4fv(uint Program, int location, int count, bool transpose, ref float v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix2x4fv(uint Program, int location, float[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2x4fv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix2x4fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2x4fv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix3x2fv")]
        unsafe public static void ProgramUniformMatrix3x2fv(uint Program, int location, int count, bool transpose, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x2fv")]
        public static void ProgramUniformMatrix3x2fv(uint Program, int location, int count, bool transpose, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x2fv")]
        public static void ProgramUniformMatrix3x2fv(uint Program, int location, int count, bool transpose, ref float v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix3x2fv(uint Program, int location, float[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3x2fv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix3x2fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3x2fv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix3x4fv")]
        unsafe public static void ProgramUniformMatrix3x4fv(uint Program, int location, int count, bool transpose, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x4fv")]
        public static void ProgramUniformMatrix3x4fv(uint Program, int location, int count, bool transpose, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x4fv")]
        public static void ProgramUniformMatrix3x4fv(uint Program, int location, int count, bool transpose, ref float v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix3x4fv(uint Program, int location, float[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3x4fv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix3x4fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3x4fv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix4x2fv")]
        unsafe public static void ProgramUniformMatrix4x2fv(uint Program, int location, int count, bool transpose, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x2fv")]
        public static void ProgramUniformMatrix4x2fv(uint Program, int location, int count, bool transpose, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x2fv")]
        public static void ProgramUniformMatrix4x2fv(uint Program, int location, int count, bool transpose, ref float v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix4x2fv(uint Program, int location, float[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4x2fv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix4x2fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4x2fv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix4x3fv")]
        unsafe public static void ProgramUniformMatrix4x3fv(uint Program, int location, int count, bool transpose, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x3fv")]
        public static void ProgramUniformMatrix4x3fv(uint Program, int location, int count, bool transpose, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x3fv")]
        public static void ProgramUniformMatrix4x3fv(uint Program, int location, int count, bool transpose, ref float v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix4x3fv(uint Program, int location, float[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4x3fv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix4x3fv(uint Program, int location, ref float v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4x3fv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix2x3dv")]
        unsafe public static void ProgramUniformMatrix2x3dv(uint Program, int location, int count, bool transpose, double* v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x3dv")]
        public static void ProgramUniformMatrix2x3dv(uint Program, int location, int count, bool transpose, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x3dv")]
        public static void ProgramUniformMatrix2x3dv(uint Program, int location, int count, bool transpose, ref double v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix2x3dv(uint Program, int location, double[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2x3dv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix2x3dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2x3dv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix2x4dv")]
        unsafe public static void ProgramUniformMatrix2x4dv(uint Program, int location, int count, bool transpose, double* v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x4dv")]
        public static void ProgramUniformMatrix2x4dv(uint Program, int location, int count, bool transpose, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x4dv")]
        public static void ProgramUniformMatrix2x4dv(uint Program, int location, int count, bool transpose, ref double v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix2x4dv(uint Program, int location, double[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2x4dv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix2x4dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2x4dv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix3x2dv")]
        unsafe public static void ProgramUniformMatrix3x2dv(uint Program, int location, int count, bool transpose, double* v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x2dv")]
        public static void ProgramUniformMatrix3x2dv(uint Program, int location, int count, bool transpose, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x2dv")]
        public static void ProgramUniformMatrix3x2dv(uint Program, int location, int count, bool transpose, ref double v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix3x2dv(uint Program, int location, double[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3x2dv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix3x2dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3x2dv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix3x4dv")]
        unsafe public static void ProgramUniformMatrix3x4dv(uint Program, int location, int count, bool transpose, double* v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x4dv")]
        public static void ProgramUniformMatrix3x4dv(uint Program, int location, int count, bool transpose, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x4dv")]
        public static void ProgramUniformMatrix3x4dv(uint Program, int location, int count, bool transpose, ref double v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix3x4dv(uint Program, int location, double[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3x4dv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix3x4dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3x4dv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix4x2dv")]
        unsafe public static void ProgramUniformMatrix4x2dv(uint Program, int location, int count, bool transpose, double* v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x2dv")]
        public static void ProgramUniformMatrix4x2dv(uint Program, int location, int count, bool transpose, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x2dv")]
        public static void ProgramUniformMatrix4x2dv(uint Program, int location, int count, bool transpose, ref double v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix4x2dv(uint Program, int location, double[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4x2dv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix4x2dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4x2dv(Program, location, count, transpose, ref v);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix4x3dv")]
        unsafe public static void ProgramUniformMatrix4x3dv(uint Program, int location, int count, bool transpose, double* v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x3dv")]
        public static void ProgramUniformMatrix4x3dv(uint Program, int location, int count, bool transpose, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x3dv")]
        public static void ProgramUniformMatrix4x3dv(uint Program, int location, int count, bool transpose, ref double v) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix4x3dv(uint Program, int location, double[] v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4x3dv(Program, location, count, transpose, v);
        }
        public static void ProgramUniformMatrix4x3dv(uint Program, int location, ref double v, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4x3dv(Program, location, count, transpose, ref v);
        }



        //[EntryPoint(FunctionName = "glProgramUniformMatrix2x3dv")]
        //unsafe public static void ProgramUniformMatrix2x3dv(uint Program, int location, int count, bool transpose, double* v){ throw new NotImplementedException(); }
        
        //[EntryPoint(FunctionName = "glProgramUniformMatrix2x4dv")]
        //unsafe public static void ProgramUniformMatrix2x4dv(uint Program, int location, int count, bool transpose, double* v){ throw new NotImplementedException(); }
        
        //[EntryPoint(FunctionName = "glProgramUniformMatrix3x2dv")]
        //unsafe public static void ProgramUniformMatrix3x2dv(uint Program, int location, int count, bool transpose, double* v){ throw new NotImplementedException(); }
        
        //[EntryPoint(FunctionName = "glProgramUniformMatrix3x4dv")]
        //unsafe public static void ProgramUniformMatrix3x4dv(uint Program, int location, int count, bool transpose, double* v){ throw new NotImplementedException(); }
        
        //[EntryPoint(FunctionName = "glProgramUniformMatrix4x2dv")]
        //unsafe public static void ProgramUniformMatrix4x2dv(uint Program, int location, int count, bool transpose, double* v){ throw new NotImplementedException(); }
        
        //[EntryPoint(FunctionName = "glProgramUniformMatrix4x3dv")]
        //unsafe public static void ProgramUniformMatrix4x3dv(uint Program, int location, int count, bool transpose, double* v){ throw new NotImplementedException(); }

        //ARB_vertex_attrib_64bit
        
        [EntryPoint(FunctionName = "glVertexAttribLPointer")]
        public static void VertexAttribLPointer(uint index, int size, VertexAttribLFormat type, int stride, IntPtr ptr){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetVertexAttribLdv")]
        unsafe public static void GetVertexAttribLdv(uint index, VertexAttribParameters pname, double* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribLdv")]
        public static void GetVertexAttribLdv(uint index, VertexAttribParameters pname, double[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribLdv")]
        public static void GetVertexAttribLdv(uint index, VertexAttribParameters pname, ref double result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetVertexAttribLdv")]
        public static double GetVertexAttribLdv(uint index, VertexAttribParameters pname) { throw new NotImplementedException(); }

        /* ignored.
        public static void VertexAttribL1d(uint index, double v1){ throw new NotImplementedException(); }
        public static void VertexAttribL2d(uint index, double v1, double v2){ throw new NotImplementedException(); }
        public static void VertexAttribL3d(uint index, double v1, double v2, double v3){ throw new NotImplementedException(); }
        public static void VertexAttribL4d(uint index, double v1, double v2, double v3, double v4){ throw new NotImplementedException(); }

        unsafe public static void VertexAttribL1dv(uint index, double* v){ throw new NotImplementedException(); }
        unsafe public static void VertexAttribL2dv(uint index, double* v){ throw new NotImplementedException(); }
        unsafe public static void VertexAttribL3dv(uint index, double* v){ throw new NotImplementedException(); }
        unsafe public static void VertexAttribL4dv(uint index, double* v){ throw new NotImplementedException(); }
        */


        //ARB_viewport_array
        /// <summary>
        /// DepthRangeArrayv is used to specify the depth range for multiple viewports simultaneously.
        /// Viewports whose indices lie outside the range [first; first + v.Length) are not modified.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="v">The v parameter contains the address of an array of double types specifying near (n) and far (f) for each viewport in that order. Values in v are each clamped to the range [0; 1] when specified.</param>
        [EntryPoint(FunctionName = "glDepthRangeArrayv")]
        unsafe public static void DepthRangeArrayv(uint first, int count, double* v){ throw new NotImplementedException(); }
        /// <summary>
        /// DepthRangeArrayv is used to specify the depth range for multiple viewports simultaneously.
        /// Viewports whose indices lie outside the range [first; first + v.Length) are not modified.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="v">The v parameter contains the address of an array of double types specifying near (n) and far (f) for each viewport in that order. Values in v are each clamped to the range [0; 1] when specified.</param>
        [EntryPoint(FunctionName = "glDepthRangeArrayv")]
        public static void DepthRangeArrayv(uint first, int count, double[] v) { throw new NotImplementedException(); }
        /// <summary>
        /// DepthRangeArrayv is used to specify the depth range for multiple viewports simultaneously.
        /// Viewports whose indices lie outside the range [first; first + v.Length) are not modified.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="v">The v parameter contains the address of an array of double types specifying near (n) and far (f) for each viewport in that order. Values in v are each clamped to the range [0; 1] when specified.</param>
        [EntryPoint(FunctionName = "glDepthRangeArrayv")]
        public static void DepthRangeArrayv(uint first, int count, ref double v) { throw new NotImplementedException(); }

        /// <summary>
        /// DepthRangeIndexed specifies the depth range for a single viewport
        /// </summary>
        /// <param name="index">Viewport to set depthrange for. Needs to be in range [0, MAX_VIEWPORTS]</param>
        /// <param name="near"></param>
        /// <param name="far"></param>
        [EntryPoint(FunctionName = "glDepthRangeIndexed")]
        public static void DepthRangeIndexed(uint index, double near, double far){ throw new NotImplementedException(); }

        /// <summary>
        /// Gets double values from an indexed parameter targets.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning is dependert on pname.</param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetDoublei_v")]
        unsafe public static void GetDoublei_v(GetParameters pname, uint index, double* data){ throw new NotImplementedException(); }
        /// <summary>
        /// Gets double values from an indexed parameter targets.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning is dependert on pname.</param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetDoublei_v")]
        public static void GetDoublei_v(GetParameters pname, uint index, double[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Gets double values from an indexed parameter targets.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning is dependert on pname.</param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetDoublei_v")]
        public static void GetDoublei_v(GetParameters pname, uint index, ref double data) { throw new NotImplementedException(); }

        /// <summary>
        /// Gets double values from an indexed parameter targets.
        /// </summary>
        /// <param name="pname"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetDoublei_v")]
        public static double GetDoublei_v(GetParameters pname, uint index) { throw new NotImplementedException(); }

        /// <summary>
        /// Gets float values from an indexed parameter target.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning is dependert on pname.</param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetFloati_v")]
        unsafe public static void GetFloati_v(GetParameters pname, uint index, float* data){ throw new NotImplementedException(); }
        /// <summary>
        /// Gets float values from an indexed parameter target.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning is dependert on pname.</param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetFloati_v")]
        public static void GetFloati_v(GetParameters pname, uint index, float[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Gets float values from an indexed parameter target.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning is dependert on pname.</param>
        /// <param name="data"></param>
        [EntryPoint(FunctionName = "glGetFloati_v")]
        public static void GetFloati_v(GetParameters pname, uint index, ref float data) { throw new NotImplementedException(); }
        /// <summary>
        /// Gets float values from an indexed parameter target.
        /// </summary>
        /// <param name="pname"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetFloati_v")]
        public static float GetFloati_v(GetParameters pname, uint index) { throw new NotImplementedException(); }

        /// <summary>
        /// ScissorArrayv is used to specify the scissor for multiple viewports simultaneously.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="count">number of viewports to change, v should be multiple of this * 4. NOT SIZE OF V ARRAY</param>
        /// <param name="v">The v parameter contains the address of an array of int types specifying left, bottom, width and height and for each viewport in that order.</param>
        [EntryPoint(FunctionName = "glScissorArrayv")]        
        unsafe public static void ScissorArrayv(uint first, int count, int* v){ throw new NotImplementedException(); }
        /// <summary>
        /// ScissorArrayv is used to specify the scissor for multiple viewports simultaneously.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="count">number of viewports to change, v should be multiple of this * 4. NOT SIZE OF V ARRAY</param>
        /// <param name="v">The v parameter contains the address of an array of int types specifying left, bottom, width and height and for each viewport in that order.</param>
        [EntryPoint(FunctionName = "glScissorArrayv")]
        public static void ScissorArrayv(uint first, int count, int[] v) { throw new NotImplementedException(); }
        /// <summary>
        /// ScissorArrayv is used to specify the scissor for multiple viewports simultaneously.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="count">number of viewports to change, v should be multiple of this * 4. NOT SIZE OF V ARRAY</param>
        /// <param name="v">The v parameter contains the address of an array of int types specifying left, bottom, width and height and for each viewport in that order.</param>
        [EntryPoint(FunctionName = "glScissorArrayv")]
        public static void ScissorArrayv(uint first, int count, ref int v) { throw new NotImplementedException(); }
        /// <summary>
        /// ScissorArrayv is used to specify the scissor for multiple viewports simultaneously.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="v">The v parameter contains the address of an array of int types specifying left, bottom, width and height and for each viewport in that order.</param>
        public static void ScissorArrayv(uint first, int[] v)
        {
            ScissorArrayv(first, v.Length / 4, v);
        }

        /// <summary>
        /// Sets the scissor box for a single viewport.
        /// </summary>
        /// <param name="index">Index of viewport to set.</param>
        /// <param name="left"></param>
        /// <param name="bottom"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        [EntryPoint(FunctionName = "glScissorIndexed")]
        public static void ScissorIndexed(uint index, int left, int bottom, int width, int height){ throw new NotImplementedException(); }

        /// <summary>
        /// Sets the scissor box for a single viewport
        /// </summary>
        /// <param name="index">Index of viewport to set.</param>
        /// <param name="vScissorRect">int array with values[left, bottom, width, height]</param>
        [EntryPoint(FunctionName = "glScissorIndexedv")]
        unsafe public static void ScissorIndexedv(uint index, int* vScissorRect){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets the scissor box for a single viewport
        /// </summary>
        /// <param name="index">Index of viewport to set.</param>
        /// <param name="vScissorRect">int array with values[left, bottom, width, height]</param>
        [EntryPoint(FunctionName = "glScissorIndexedv")]
        public static void ScissorIndexedv(uint index, int[] vScissorRect) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the scissor box for a single viewport
        /// </summary>
        /// <param name="index">Index of viewport to set.</param>
        /// <param name="vScissorRect">int array with values[left, bottom, width, height]</param>
        [EntryPoint(FunctionName = "glScissorIndexedv")]
        public static void ScissorIndexedv(uint index, ref int vScissorRect) { throw new NotImplementedException(); }

        /// <summary>
        /// ViewportArrayv is used to specify the Viewport for multiple viewports simultaneously.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="count">number of viewports to change, v should be multiple of this * 4. NOT SIZE OF V ARRAY</param>
        /// <param name="v">The v parameter contains the address of an array of int types specifying x, y, width and height and for each viewport in that order.</param>
        [EntryPoint(FunctionName = "glViewportArrayv")]
        unsafe public static void ViewportArrayv(uint first, int count, float* v){ throw new NotImplementedException(); }
        /// <summary>
        /// ViewportArrayv is used to specify the Viewport for multiple viewports simultaneously.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="count">number of viewports to change, v should be multiple of this * 4. NOT SIZE OF V ARRAY</param>
        /// <param name="v">The v parameter contains the address of an array of int types specifying x, y, width and height and for each viewport in that order.</param>
        [EntryPoint(FunctionName = "glViewportArrayv")]
        public static void ViewportArrayv(uint first, int count, float[] v) { throw new NotImplementedException(); }
        /// <summary>
        /// ViewportArrayv is used to specify the Viewport for multiple viewports simultaneously.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="count">number of viewports to change, v should be multiple of this * 4. NOT SIZE OF V ARRAY</param>
        /// <param name="v">The v parameter contains the address of an array of int types specifying x, y, width and height and for each viewport in that order.</param>
        [EntryPoint(FunctionName = "glViewportArrayv")]
        public static void ViewportArrayv(uint first, int count, ref float v) { throw new NotImplementedException(); }
        /// <summary>
        /// ViewportArrayv is used to specify the Viewport for multiple viewports simultaneously.
        /// </summary>
        /// <param name="first">first specifies the index of the first viewport to modify</param>
        /// <param name="v">The v parameter contains the address of an array of int types specifying x, y, width and height and for each viewport in that order.</param>        
        public static void ViewportArrayv(uint first, float[] v)
        {
            ViewportArrayv(first, v.Length / 4, v);
        }

        /// <summary>
        /// Sets the viewport for a single viewport
        /// </summary>
        /// <param name="index">Index of viewport to set.</param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="w"></param>
        /// <param name="h"></param>
        [EntryPoint(FunctionName = "glViewportIndexedf")]
        public static void ViewportIndexedf(uint index, float x, float y, float w, float h){ throw new NotImplementedException(); }

        /// <summary>
        /// Sets the viewport for a single viewport
        /// </summary>
        /// <param name="index">Index of viewport to set.</param>
        /// <param name="viewport">float array containg [x, y, width, height]</param>
        [EntryPoint(FunctionName = "glViewportIndexedfv")]
        unsafe public static void ViewportIndexedfv(uint index, float* viewport) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the viewport for a single viewport
        /// </summary>
        /// <param name="index">Index of viewport to set.</param>
        /// <param name="viewport">float array containg [x, y, width, height]</param>
        [EntryPoint(FunctionName = "glViewportIndexedfv")]
        public static void ViewportIndexedfv(uint index, float[] viewport) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the viewport for a single viewport
        /// </summary>
        /// <param name="index">Index of viewport to set.</param>
        /// <param name="viewport">float array containg [x, y, width, height]</param>
        [EntryPoint(FunctionName = "glViewportIndexedfv")]
        public static void ViewportIndexedfv(uint index, ref float viewport) { throw new NotImplementedException(); }

        #endregion

        #region Public Helper Functions

        #endregion

    }
}
