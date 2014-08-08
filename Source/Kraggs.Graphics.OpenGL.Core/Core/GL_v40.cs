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

        //ARB_draw_buffer_blend
        [EntryPointSlot(275)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBlendEquationSeparatei(uint buf, BlendEquationSeparateRGB modeRGB, BlendEquationSeparateAlpha modeAlpha);
        [EntryPointSlot(276)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBlendEquationi(uint buf, BlendEquationMode mode);
        [EntryPointSlot(277)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBlendFuncSeparatei(uint buf, BlendFactorSrc srcRGB, BlendFactorDst dstRGB, BlendFactorSrc srcAlpha, BlendFactorDst dstAlpha);
        [EntryPointSlot(278)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBlendFunci(uint buf, BlendFactorSrc src, BlendFactorDst dst);
        //ARB_draw_indirect
        [EntryPointSlot(279)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawArraysIndirect(BeginMode mode, IntPtr indirect);
        [EntryPointSlot(280)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawElementsIndirect(BeginMode mode, IndicesType type, IntPtr Indirect);

        //ARB_shader_subroutine
        [EntryPointSlot(281)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetActiveSubroutineName(uint Program, ShaderType type, uint index, int bufSize, out int Length, IntPtr Name);
        [EntryPointSlot(282)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetActiveSubroutineUniformName(uint Program, ShaderType type, uint index, int bufsize, out int length, IntPtr Name);
        [EntryPointSlot(283)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetActiveSubroutineUniformiv(uint Program, ShaderType type, uint Index, SubroutineUniformParameters pname, int* values);
        [EntryPointSlot(284)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetProgramStageiv(uint Program, ShaderType type, ProgramStageParameters pname, int* values);
        [EntryPointSlot(285)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern uint glGetSubroutineIndex(uint Program, ShaderType type, string Name);
        [EntryPointSlot(286)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern int glGetSubroutineUniformLocation(uint Program, ShaderType type, string Name);
        [EntryPointSlot(287)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetUniformSubroutineuiv(uint Program, int location, uint* result);
        [EntryPointSlot(288)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformSubroutinesuiv(ShaderType type, int count, uint* Indices);

        //ARB_gpu_shader_fp64
        [EntryPointSlot(289)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetUniformdv(uint Program, int location, double* result);

        [EntryPointSlot(290)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform1d(int location, double v1);
        [EntryPointSlot(291)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform2d(int location, double v1, double v2);
        [EntryPointSlot(292)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform3d(int location, double v1, double v2, double v3);
        [EntryPointSlot(293)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform4d(int location, double v1, double v2, double v3, double v4);


        [EntryPointSlot(294)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform1dv(int location, int count, double* v);
        [EntryPointSlot(295)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform2dv(int location, int count, double* v);
        [EntryPointSlot(296)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform3dv(int location, int count, double* v);
        [EntryPointSlot(297)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniform4dv(int location, int count, double* v);

        [EntryPointSlot(298)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformMatrix2dv(int location, int count, bool transpose, double* matrix);
        [EntryPointSlot(299)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformMatrix3dv(int location, int count, bool transpose, double* matrix);
        [EntryPointSlot(300)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformMatrix4dv(int location, int count, bool transpose, double* matrix);

        [EntryPointSlot(301)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformMatrix2x3dv(int location, int count, bool transpose, double* matrix);
        [EntryPointSlot(302)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformMatrix2x4dv(int location, int count, bool transpose, double* matrix);

        [EntryPointSlot(303)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformMatrix3x2dv(int location, int count, bool transpose, double* matrix);
        [EntryPointSlot(304)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformMatrix3x4dv(int location, int count, bool transpose, double* matrix);

        [EntryPointSlot(305)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformMatrix4x2dv(int location, int count, bool transpose, double* matrix);
        [EntryPointSlot(306)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformMatrix4x3dv(int location, int count, bool transpose, double* matrix);

        //ARB_sample_shading
        [EntryPointSlot(307)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMinSampleShading(float value);

        //ARB_tessellation_shader
        [EntryPointSlot(308)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glPatchParameteri(PatchParameters pname, int value);
        [EntryPointSlot(309)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glPatchParameterfv(PatchParameters pname,  float* values);

        //ARB_transform_feedback2
        [EntryPointSlot(310)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindTransformFeedback(TransformFeedbackTarget target, uint TransformFeedbackId);
        [EntryPointSlot(311)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glDeleteTransformFeedbacks(int number, uint* TransformFeedbackIds);
        [EntryPointSlot(312)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawTransformFeedback(BeginMode mode, uint TransformFeedbackId);
        [EntryPointSlot(313)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGenTransformFeedbacks(int number, uint* TransformFeedbackIds);
        [EntryPointSlot(314)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsTransformFeedback(uint TransformFeedbackId);
        [EntryPointSlot(315)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glPauseTransformFeedback();
        [EntryPointSlot(316)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glResumeTransformFeedback();

        //ARB_transform_feedback3
        [EntryPointSlot(317)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBeginQueryIndexed(QueryTarget target, uint Index, uint QueryID);
        [EntryPointSlot(318)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawTransformFeedbackStream(BeginMode mode, uint TransformFeedbackId, uint Stream);
        [EntryPointSlot(319)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glEndQueryIndexed(QueryTarget target, uint Index);
        [EntryPointSlot(320)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetQueryIndexediv(QueryTarget target, uint Index, GetQueryIndexedParameters pname, int* result);


        #endregion

        #region Public functions

        //[EntryPoint(FunctionName = "gl")]
        //public static void BindTexture(TextureTarget target, uint textureid) { throw new NotImplementedException(); }

        //ARB_draw_buffer_blend       
        /// <summary>
        /// Sets the RGB blend equation and the alpha blend equation separately
        /// </summary>
        /// <param name="buf">specifies the index of the draw buffer for which to set the blend equations.</param>
        /// <param name="modeRGB">specifies the RGB blend equation, how the red, green, and blue components of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.</param>
        /// <param name="modeAlpha">specifies the alpha blend equation, how the alpha component of the source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.</param>
        /// <remarks>
        /// The blend equations determines how a new pixel (the ''source'' color) is combined with a pixel already in the framebuffer (the ''destination'' color). These functions specifie one blend equation for the RGB-color components and one blend equation for the alpha component. glBlendEquationSeparatei specifies the blend equations for a single draw buffer whereas glBlendEquationSeparate sets the blend equations for all draw buffers.
        /// </remarks>
        [EntryPoint(FunctionName = "glBlendEquationSeparatei")]
        public static void BlendEquationSeparatei(uint buf, BlendEquationSeparateRGB modeRGB, BlendEquationSeparateAlpha modeAlpha){ throw new NotImplementedException(); }

        /// <summary>
        /// Sets  the equation used for both the RGB blend equation and the Alpha blend equation
        /// </summary>
        /// <param name="buf">specifies the index of the draw buffer for which to set the blend equation.</param>
        /// <param name="mode">specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.</param>
        /// <remarks>
        /// The blend equations determine how a new pixel (the ''source'' color) is combined with a pixel already in the framebuffer (the ''destination'' color). This function sets both the RGB blend equation and the alpha blend equation to a single equation. glBlendEquationi specifies the blend equation for a single draw buffer whereas glBlendEquation sets the blend equation for all draw buffers.
        /// </remarks>
        [EntryPoint(FunctionName = "glBlendEquationi")]
        public static void BlendEquationi(uint buf, BlendEquationMode mode){ throw new NotImplementedException(); }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="buf">specifies the index of the draw buffer</param>
        /// <param name="srcRGB"></param>
        /// <param name="dstRGB"></param>
        /// <param name="srcAlpha"></param>
        /// <param name="dstAlpha"></param>
        [EntryPoint(FunctionName = "glBlendFuncSeparatei")]
        public static void BlendFuncSeparatei(uint buf, BlendFactorSrc srcRGB, BlendFactorDst dstRGB, BlendFactorSrc srcAlpha, BlendFactorDst dstAlpha){ throw new NotImplementedException(); }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="buf">specifies the index of the draw buffer</param>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [EntryPoint(FunctionName = "glBlendFunci")]
        public static void BlendFunci(uint buf, BlendFactorSrc src, BlendFactorDst dst){ throw new NotImplementedException(); }

        //ARB_draw_indirect        
        [EntryPoint(FunctionName = "glDrawArraysIndirect")]
        public static void DrawArraysIndirect(BeginMode mode, IntPtr indirect){ throw new NotImplementedException(); }
        /// <summary>
        /// Specifies the address of a structure containing the draw parameters.
        /// glDrawArraysIndirect specifies multiple geometric primitives with very few subroutine calls. glDrawArraysIndirect behaves similarly to glDrawArraysInstancedBaseInstance, execept that the parameters to glDrawArraysInstancedBaseInstance are stored in memory at the address given by indirect.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.</param>
        /// <param name="indirectOffset">Offset in bytes of current bound GL_DRAW_INDIRECT_BUFFER where there should be a structure containing the draw parameters.</param>
        /// <remarks>
        /// glDrawArraysIndirect specifies multiple geometric primitives with very few subroutine calls. glDrawArraysIndirect behaves similarly to glDrawArraysInstancedBaseInstance, execept that the parameters to glDrawArraysInstancedBaseInstance are stored in memory at the address given by indirect.
        /// The parameters addressed by indirect are packed into a structure that takes the form (in C):
        /// <code>
        /// typedef  struct {
        ///     uint  count;
        ///     uint  primCount;
        ///     uint  first;
        ///     uint  baseInstance;
        /// } DrawArraysIndirectCommand;
        /// 
        /// const DrawArraysIndirectCommand  *cmd  = (const DrawArraysIndirectCommand  *)indirect;
        /// glDrawArraysInstancedBaseInstance(mode,  cmd->first,  cmd->count,  cmd->primCount, cmd->baseInstance);
        /// </code>
        /// If a buffer is bound to the GL_DRAW_INDIRECT_BUFFER binding at the time of a call to glDrawArraysIndirect, indirect is interpreted as an offset, in basic machine units, into that buffer and the parameter data is read from the buffer rather than from client memory.
        /// In contrast to glDrawArraysInstancedBaseInstance, the first member of the parameter structure is unsigned, and out-of-range indices do not generate an error.
        /// Vertex attributes that are modified by glDrawArraysIndirect have an unspecified value after glDrawArraysIndirect returns. Attributes that aren't modified remain well defined.
        /// </remarks>
        public static void DrawArraysIndirect(BeginMode mode, long indirectOffset)
        {
            DrawArraysIndirect(mode, (IntPtr)indirectOffset);
        }

        [EntryPoint(FunctionName = "glDrawElementsIndirect")]
        public static void DrawElementsIndirect(BeginMode mode, IndicesType type, IntPtr Indirect){ throw new NotImplementedException(); }
        /// <summary>
        /// render indexed primitives from array data, taking parameters from memory
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.</param>
        /// <param name="type">Specifies the type of data in the buffer bound to the GL_ELEMENT_ARRAY_BUFFER binding.</param>
        /// <param name="indirectOffset">Offset in bytes in current bound GL_DRAW_INDIRECT_BUFFER where a structure (DrawElementsIndirectCommand) with draw commands are expected to be </param>
        /// <remarks>
        /// glDrawElementsIndirect specifies multiple indexed geometric primitives with very few subroutine calls. glDrawElementsIndirect behaves similarly to glDrawElementsInstancedBaseVertexBaseInstance, execpt that the parameters to glDrawElementsInstancedBaseVertexBaseInstance are stored in memory at the address given by indirect.
        /// 
        /// The parameters addressed by indirect are packed into a structure that takes the form (in C):
        /// <code>
        /// typedef  struct {
        ///     uint  count;
        ///     uint  primCount;
        ///     uint  firstIndex;
        ///     uint  baseVertex;
        ///     uint  baseInstance;
        ///     } DrawElementsIndirectCommand;
        /// </code>
        /// glDrawElementsIndirect is equivalent to:        
        /// <code>
        /// void glDrawElementsIndirect(GLenum mode, GLenum type, const void * indirect)
        /// {
        ///     const DrawElementsIndirectCommand *cmd  = (const DrawElementsIndirectCommand *)indirect;
        ///     glDrawElementsInstancedBaseVertexBaseInstance(mode,
        ///                                                     cmd->count,
        ///                                                     type,
        ///                                                     cmd->firstIndex + size-of-type,
        ///                                                     cmd->primCount,
        ///                                                     cmd->baseVertex,
        ///                                                     cmd->baseInstance);
        ///     }
        /// </code>
        /// If a buffer is bound to the GL_DRAW_INDIRECT_BUFFER binding at the time of a call to glDrawElementsIndirect, indirect is interpreted as an offset, in basic machine units, into that buffer and the parameter data is read from the buffer rather than from client memory.
        /// Note that indices stored in client memory are not supported. If no buffer is bound to the GL_ELEMENT_ARRAY_BUFFER binding, an error will be generated.
        /// The results of the operation are undefined if the reservedMustBeZero member of the parameter structure is non-zero. However, no error is generated in this case.
        /// Vertex attributes that are modified by glDrawElementsIndirect have an unspecified value after glDrawElementsIndirect returns. Attributes that aren't modified remain well defined.
        /// The baseInstance member of the DrawElementsIndirectCommand structure is defined only if the GL version is 4.2 or greater. For versions of the GL less than 4.2, this parameter is present but is reserved and should be set to zero. On earlier versions of the GL, behavior is undefined if it is non-zero.
        /// </remarks>
        public static void DrawElementsIndirect(BeginMode mode, IndicesType type, long indirectOffset)
        {
            DrawElementsIndirect(mode, type, (IntPtr)indirectOffset);
        }

        //ARB_shader_subroutine       
        /// <summary>
        /// Retrives the name of a subroutine 
        /// </summary>
        /// <param name="Program">Program to Query</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="index">Subroutine index to get name for.</param>
        /// <param name="bufSize">Size of StringBuilder Capacity.</param>
        /// <param name="Length">Number of characters written to stringbuilder.</param>
        /// <param name="Name">Stringbuilder to write name of uniform to.</param>
        [EntryPoint(FunctionName = "glGetActiveSubroutineName")]
        public static void GetActiveSubroutineName(uint Program, ShaderType type, uint index, int bufSize, out int Length, StringBuilder Name){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives the name of a subroutine
        /// </summary>
        /// <param name="Program">Program to Query</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="index">Subroutine index to get name for.</param>
        /// <param name="MaxSubroutineNameLength">Default size of allocated StringBuilder used to retrive name.</param>
        /// <returns></returns>
        public static string GetActiveSubroutineName(uint Program, ShaderType type, uint index, int MaxSubroutineNameLength = 64)
        {
            var sb = new StringBuilder(MaxSubroutineNameLength + 4);

            GetActiveSubroutineName(Program, type, index, sb.Capacity - 2, out MaxSubroutineNameLength, sb);

            return sb.ToString();
        }
        /// <summary>
        /// Returns the name of a SubroutineUniform.
        /// </summary>
        /// <param name="Program">Program to Query</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="index">Subroutine Uniform Index to query.</param>
        /// <param name="bufsize">Capacity of string builder.</param>
        /// <param name="length">The number of characters to write to StringBuilder.</param>
        /// <param name="Name">StringBuilder to write name to.</param>
        [EntryPoint(FunctionName = "glGetActiveSubroutineUniformName")]
        public static void GetActiveSubroutineUniformName(uint Program, ShaderType type, uint index, int bufsize, out int length, StringBuilder Name){ throw new NotImplementedException(); }
        /// <summary>
        /// Returns the name of a SubroutineUniform.
        /// </summary>
        /// <param name="Program">Program to Query</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="index">Subroutine Uniform Index to query.</param>
        /// <param name="MaxSubroutineUniformNameLength">Default size of allocated Stringbuilder used to retrive name string.</param>
        /// <returns></returns>
        public static string GetActiveSubroutineUniformName(uint Program, ShaderType type, uint index, int MaxSubroutineUniformNameLength = 64)
        {
            var sb = new StringBuilder(MaxSubroutineUniformNameLength + 4);

            GetActiveSubroutineUniformName(Program, type, index, sb.Capacity - 2, out MaxSubroutineUniformNameLength, sb);

            return sb.ToString();
        }
        /// <summary>
        /// Retrives subroutine uniform parameters for a program stage.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="Index">Subroutine Uniform Index to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="values"></param>
        [EntryPoint(FunctionName = "glGetActiveSubroutineUniformiv")]
        unsafe public static void GetActiveSubroutineUniformiv(uint Program, ShaderType type, uint Index, SubroutineUniformParameters pname, int* values) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives subroutine uniform parameters for a program stage.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="Index">Subroutine Uniform Index to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="values"></param>
        [EntryPoint(FunctionName = "glGetActiveSubroutineUniformiv")]
        public static void GetActiveSubroutineUniformiv(uint Program, ShaderType type, uint Index, SubroutineUniformParameters pname, int[] values) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives subroutine uniform parameters for a program stage.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="Index">Subroutine Uniform Index to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="values"></param>
        [EntryPoint(FunctionName = "glGetActiveSubroutineUniformiv")]
        public static void GetActiveSubroutineUniformiv(uint Program, ShaderType type, uint Index, SubroutineUniformParameters pname, ref int values) { throw new NotImplementedException(); }

        /// <summary>
        /// Gets Program Stage Parameters.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="values"></param>
        [EntryPoint(FunctionName = "glGetProgramStageiv")]
        unsafe public static void GetProgramStageiv(uint Program, ShaderType type, ProgramStageParameters pname, int* values){ throw new NotImplementedException(); }
        /// <summary>
        /// Gets Program Stage Parameters.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="values"></param>
        [EntryPoint(FunctionName = "glGetProgramStageiv")]
        public static void GetProgramStageiv(uint Program, ShaderType type, ProgramStageParameters pname, int[] values) { throw new NotImplementedException(); }
        /// <summary>
        /// Gets a Program Stage Parameter.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>        
        [EntryPoint(FunctionName = "glGetProgramStageiv")]
        public static void GetProgramStageiv(uint Program, ShaderType type, ProgramStageParameters pname, ref int values) { throw new NotImplementedException(); }
        public static int GetProgramStageiv(uint Program, ShaderType type, ProgramStageParameters pname)
        {
            int tmp = 0;
            GetProgramStageiv(Program, type, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Returns the Subroutine index for a Subroutine. 
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="Name">Name of subroutine to get index for.</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetSubroutineIndex")]
        public static uint GetSubroutineIndex(uint Program, ShaderType type, string Name){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrives the subroutine uniform location used to set uniform selector value.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="Name">Name of SubroutineUnifrom.</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetSubroutineUniformLocation")]
        public static int GetSubroutineUniformLocation(uint Program, ShaderType type, string Name){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrives parameters about a UniformSubroutine.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="location">SubroutineUniform Location to query.</param>
        /// <param name="result"></param>
        [EntryPoint(FunctionName = "glGetUniformSubroutineuiv")]
        unsafe public static void GetUniformSubroutineuiv(uint Program, int location, uint* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives parameters about a UniformSubroutine.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="location">SubroutineUniform Location to query.</param>
        /// <param name="result"></param>
        [EntryPoint(FunctionName = "glGetUniformSubroutineuiv")]
        public static void GetUniformSubroutineuiv(uint Program, int location, uint[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives parameters about a UniformSubroutine.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="location">SubroutineUniform Location to query.</param>
        /// <param name="result"></param>
        [EntryPoint(FunctionName = "glGetUniformSubroutineuiv")]
        public static void GetUniformSubroutineuiv(uint Program, int location, ref uint result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives parameters about a UniformSubroutine.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="location">SubroutineUniform Location to query.</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetUniformSubroutineuiv")]
        public static uint GetUniformSubroutineuiv(uint Program, int location) { throw new NotImplementedException(); }

        /// <summary>
        /// Sets Uniform Subroutine params
        /// </summary>
        /// <param name="type"></param>
        /// <param name="count"></param>
        /// <param name="Indices"></param>
        [EntryPoint(FunctionName = "glUniformSubroutinesuiv")]
        unsafe public static void UniformSubroutinesuiv(ShaderType type, int count, uint* Indices){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets Uniform Subroutine params
        /// </summary>
        /// <param name="type"></param>
        /// <param name="count"></param>
        /// <param name="Indices"></param>
        [EntryPoint(FunctionName = "glUniformSubroutinesuiv")]
        public static void UniformSubroutinesuiv(ShaderType type, int count, uint[] Indices) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets Uniform Subroutine params
        /// </summary>
        /// <param name="type"></param>
        /// <param name="count"></param>
        /// <param name="Indices"></param>
        [EntryPoint(FunctionName = "glUniformSubroutinesuiv")]
        public static void UniformSubroutinesuiv(ShaderType type, int count, ref uint Indices) { throw new NotImplementedException(); }

        //ARB_gpu_shader_fp64        
        /// <summary>
        /// Retrives the double value of a uniform.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="location">Uniform location to retrive value from.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetUniformdv")]
        unsafe public static void GetUniformdv(uint Program, int location, double* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives the double value of a uniform.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="location">Uniform location to retrive value from.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetUniformdv")]
        public static void GetUniformdv(uint Program, int location, double[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives the double value of a uniform.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="location">Uniform location to retrive value from.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetUniformdv")]
        public static void GetUniformdv(uint Program, int location, ref double result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives the double value of a uniform
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="location">Uniform location to retrive value from.</param>       
        [EntryPoint(FunctionName = "glGetUniformdv")]
        public static double GetUniformdv(uint Program, int location) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glUniform1d")]
        public static void Uniform1d(int location, double v1){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glUniform2d")]
        public static void Uniform2d(int location, double v1, double v2){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glUniform3d")]
        public static void Uniform3d(int location, double v1, double v2, double v3){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glUniform4d")]
        public static void Uniform4d(int location, double v1, double v2, double v3, double v4){ throw new NotImplementedException(); }


        
        [EntryPoint(FunctionName = "glUniform1dv")]
        unsafe public static void Uniform1dv(int location, int count, double* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform1dv")]
        public static void Uniform1dv(int location, int count, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform1dv")]
        public static void Uniform1dv(int location, int count, ref double v) { throw new NotImplementedException(); }
        public static void Uniform1dv(int location, double[] v)
        {
            Uniform1dv(location, v.Length, v);
        }

        [EntryPoint(FunctionName = "glUniform2dv")]
        unsafe public static void Uniform2dv(int location, int count, double* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform2dv")]
        public static void Uniform2dv(int location, int count, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform2dv")]
        public static void Uniform2dv(int location, int count, ref double v) { throw new NotImplementedException(); }        
        public static void Uniform2dv(int location, double[] v)
        {
            Uniform2dv(location, v.Length / 2, v);
        }

        [EntryPoint(FunctionName = "glUniform3dv")]
        unsafe public static void Uniform3dv(int location, int count, double* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform3dv")]
        public static void Uniform3dv(int location, int count, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform3dv")]
        public static void Uniform3dv(int location, int count, ref double v) { throw new NotImplementedException(); }
        public static void Uniform3dv(int location, double[] v)
        {
            Uniform3dv(location, v.Length / 3, v);
        }

        [EntryPoint(FunctionName = "glUniform4dv")]
        unsafe public static void Uniform4dv(int location, int count, double* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform4dv")]
        unsafe public static void Uniform4dv(int location, int count, double[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform4dv")]
        unsafe public static void Uniform4dv(int location, int count, ref double v) { throw new NotImplementedException(); }        
        unsafe public static void Uniform4dv(int location, double[] v)
        {
            Uniform4dv(location, v.Length / 4, v);
        }


        [EntryPoint(FunctionName = "glUniformMatrix2dv")]
        unsafe public static void UniformMatrix2dv(int location, int count, bool transpose, double* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix2dv")]
        public static void UniformMatrix2dv(int location, int count, bool transpose, double[] matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix2dv")]
        public static void UniformMatrix2dv(int location, int count, bool transpose, ref double matrix) { throw new NotImplementedException(); }

        public static void UniformMatrix2dv(int location, double[] matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix2dv(location, count, transpose, matrix);
        }
        public static void UniformMatrix2dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix2dv(location, count, transpose, ref matrix);
        }

        [EntryPoint(FunctionName = "glUniformMatrix3dv")]
        unsafe public static void UniformMatrix3dv(int location, int count, bool transpose, double* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix3dv")]
        public static void UniformMatrix3dv(int location, int count, bool transpose, double[] matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix3dv")]
        public static void UniformMatrix3dv(int location, int count, bool transpose, ref double matrix) { throw new NotImplementedException(); }
        public static void UniformMatrix3dv(int location, double[] matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix3dv(location, count, transpose, matrix);
        }
        public static void UniformMatrix3dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix3dv(location, count, transpose, ref matrix);
        }

        [EntryPoint(FunctionName = "glUniformMatrix4dv")]
        unsafe public static void UniformMatrix4dv(int location, int count, bool transpose, double* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix4dv")]
        public static void UniformMatrix4dv(int location, int count, bool transpose, double[] matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix4dv")]
        public static void UniformMatrix4dv(int location, int count, bool transpose, ref double matrix) { throw new NotImplementedException(); }
        public static void UniformMatrix4dv(int location, double[] matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix4dv(location, count, transpose, matrix);
        }
        public static void UniformMatrix4dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix4dv(location, count, transpose, ref matrix);
        }

        [EntryPoint(FunctionName = "glUniformMatrix2x3dv")]
        unsafe public static void UniformMatrix2x3dv(int location, int count, bool transpose, double* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix2x3dv")]
        public static void UniformMatrix2x3dv(int location, int count, bool transpose, double[] matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix2x3dv")]
        public static void UniformMatrix2x3dv(int location, int count, bool transpose, ref double matrix) { throw new NotImplementedException(); }
        public static void UniformMatrix2x3dv(int location, double[] matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix2x3dv(location, count, transpose, matrix);
        }
        public static void UniformMatrix2x3dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix2x3dv(location, count, transpose, ref matrix);
        }

        [EntryPoint(FunctionName = "glUniformMatrix2x4dv")]
        unsafe public static void UniformMatrix2x4dv(int location, int count, bool transpose, double* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix2x4dv")]
        public static void UniformMatrix2x4dv(int location, int count, bool transpose, double[] matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix2x4dv")]
        public static void UniformMatrix2x4dv(int location, int count, bool transpose, ref double matrix) { throw new NotImplementedException(); }
        public static void UniformMatrix2x4dv(int location, double[] matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix2x4dv(location, count, transpose, matrix);
        }
        public static void UniformMatrix2x4dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix2x4dv(location, count, transpose, ref matrix);
        }


        [EntryPoint(FunctionName = "glUniformMatrix3x2dv")]
        unsafe public static void UniformMatrix3x2dv(int location, int count, bool transpose, double* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix3x2dv")]
        public static void UniformMatrix3x2dv(int location, int count, bool transpose, double[] matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix3x2dv")]
        public static void UniformMatrix3x2dv(int location, int count, bool transpose, ref double matrix) { throw new NotImplementedException(); }
        public static void UniformMatrix3x2dv(int location, double[] matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix3x2dv(location, count, transpose, matrix);
        }
        public static void UniformMatrix3x2dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix3x2dv(location, count, transpose, ref matrix);
        }

        [EntryPoint(FunctionName = "glUniformMatrix3x4dv")]
        unsafe public static void UniformMatrix3x4dv(int location, int count, bool transpose, double* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix3x4dv")]
        public static void UniformMatrix3x4dv(int location, int count, bool transpose, double[] matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix3x4dv")]
        public static void UniformMatrix3x4dv(int location, int count, bool transpose, ref double matrix) { throw new NotImplementedException(); }
        public static void UniformMatrix3x4dv(int location, double[] matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix3x4dv(location, count, transpose, matrix);
        }
        public static void UniformMatrix3x4dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix3x4dv(location, count, transpose, ref matrix);
        }


        [EntryPoint(FunctionName = "glUniformMatrix4x2dv")]
        unsafe public static void UniformMatrix4x2dv(int location, int count, bool transpose, double* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix4x2dv")]
        public static void UniformMatrix4x2dv(int location, int count, bool transpose, double[] matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix4x2dv")]
        public static void UniformMatrix4x2dv(int location, int count, bool transpose, ref double matrix) { throw new NotImplementedException(); }
        public static void UniformMatrix4x2dv(int location, double[] matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix4x2dv(location, count, transpose, matrix);
        }
        public static void UniformMatrix4x2dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix4x2dv(location, count, transpose, ref matrix);
        }

        [EntryPoint(FunctionName = "glUniformMatrix4x3dv")]
        unsafe public static void UniformMatrix4x3dv(int location, int count, bool transpose, double* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix4x3dv")]
        public static void UniformMatrix4x3dv(int location, int count, bool transpose, double[] matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformMatrix4x3dv")]
        public static void UniformMatrix4x3dv(int location, int count, bool transpose, ref double matrix) { throw new NotImplementedException(); }
        public static void UniformMatrix4x3dv(int location, double[] matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix4x3dv(location, count, transpose, matrix);
        }
        public static void UniformMatrix4x3dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            UniformMatrix4x3dv(location, count, transpose, ref matrix);
        }

        //ARB_sample_shading       
        /// <summary>
        /// Sets the minimum sample shadering?
        /// </summary>
        /// <param name="value"></param>
        [EntryPoint(FunctionName = "glMinSampleShading")]
        public static void MinSampleShading(float value){ throw new NotImplementedException(); }

        //ARB_tessellation_shader        
        /// <summary>
        /// specifies the parameters for patch primitives
        /// </summary>
        /// <param name="pname">Specifies the name of the parameter to set. The symbolc constants GL_PATCH_VERTICES, GL_PATCH_DEFAULT_OUTER_LEVEL, and GL_PATCH_DEFAULT_INNER_LEVEL are accepted.</param>
        /// <param name="value">Specifies the new value for the parameter given by pname.</param>
        /// <remarks>
        /// glPatchParameter specifies the parameters that will be used for patch primitives. pname specifies the parameter to modify and must be either GL_PATCH_VERTICES, GL_PATCH_DEFAULT_OUTER_LEVEL or GL_PATCH_DEFAULT_INNER_LEVEL. For glPatchParameteri, value specifies the new value for the parameter specified by pname. For glPatchParameterfv, values specifies the address of an array containing the new values for the parameter specified by pname.
        /// When pname is GL_PATCH_VERTICES, value specifies the number of vertices that will be used to make up a single patch primitive. Patch primitives are consumed by the tessellation control shader (if present) and subsequently used for tessellation. When primitives are specified using glDrawArrays or a similar function, each patch will be made from parameter control points, each represented by a vertex taken from the enabeld vertex arrays. parameter must be greater than zero, and less than or equal to the value of GL_MAX_PATCH_VERTICES.
        /// When pname is GL_PATCH_DEFAULT_OUTER_LEVEL or GL_PATCH_DEFAULT_INNER_LEVEL, values contains the address of an array contiaining the default outer or inner tessellation levels, respectively, to be used when no tessellation control shader is present.
        /// </remarks>
        [EntryPoint(FunctionName = "glPatchParameteri")]
        public static void PatchParameteri(PatchParameters pname, int value){ throw new NotImplementedException(); }

        /// <summary>
        /// specifies the parameters for patch primitives
        /// </summary>
        /// <param name="pname">Specifies the name of the parameter to set. The symbolc constants GL_PATCH_VERTICES, GL_PATCH_DEFAULT_OUTER_LEVEL, and GL_PATCH_DEFAULT_INNER_LEVEL are accepted.</param>
        /// <param name="values">Specifies the new values for the parameter given by pname.</param>
        /// <remarks>
        /// glPatchParameter specifies the parameters that will be used for patch primitives. pname specifies the parameter to modify and must be either GL_PATCH_VERTICES, GL_PATCH_DEFAULT_OUTER_LEVEL or GL_PATCH_DEFAULT_INNER_LEVEL. For glPatchParameteri, value specifies the new value for the parameter specified by pname. For glPatchParameterfv, values specifies the address of an array containing the new values for the parameter specified by pname.
        /// When pname is GL_PATCH_VERTICES, value specifies the number of vertices that will be used to make up a single patch primitive. Patch primitives are consumed by the tessellation control shader (if present) and subsequently used for tessellation. When primitives are specified using glDrawArrays or a similar function, each patch will be made from parameter control points, each represented by a vertex taken from the enabeld vertex arrays. parameter must be greater than zero, and less than or equal to the value of GL_MAX_PATCH_VERTICES.
        /// When pname is GL_PATCH_DEFAULT_OUTER_LEVEL or GL_PATCH_DEFAULT_INNER_LEVEL, values contains the address of an array contiaining the default outer or inner tessellation levels, respectively, to be used when no tessellation control shader is present.
        /// </remarks>
        [EntryPoint(FunctionName = "glPatchParameterfv")]
        unsafe public static void PatchParameterfv(PatchParameters pname, float* values){ throw new NotImplementedException(); }
        /// <summary>
        /// specifies the parameters for patch primitives
        /// </summary>
        /// <param name="pname">Specifies the name of the parameter to set. The symbolc constants GL_PATCH_VERTICES, GL_PATCH_DEFAULT_OUTER_LEVEL, and GL_PATCH_DEFAULT_INNER_LEVEL are accepted.</param>
        /// <param name="values">Specifies the new values for the parameter given by pname.</param>
        /// <remarks>
        /// glPatchParameter specifies the parameters that will be used for patch primitives. pname specifies the parameter to modify and must be either GL_PATCH_VERTICES, GL_PATCH_DEFAULT_OUTER_LEVEL or GL_PATCH_DEFAULT_INNER_LEVEL. For glPatchParameteri, value specifies the new value for the parameter specified by pname. For glPatchParameterfv, values specifies the address of an array containing the new values for the parameter specified by pname.
        /// When pname is GL_PATCH_VERTICES, value specifies the number of vertices that will be used to make up a single patch primitive. Patch primitives are consumed by the tessellation control shader (if present) and subsequently used for tessellation. When primitives are specified using glDrawArrays or a similar function, each patch will be made from parameter control points, each represented by a vertex taken from the enabeld vertex arrays. parameter must be greater than zero, and less than or equal to the value of GL_MAX_PATCH_VERTICES.
        /// When pname is GL_PATCH_DEFAULT_OUTER_LEVEL or GL_PATCH_DEFAULT_INNER_LEVEL, values contains the address of an array contiaining the default outer or inner tessellation levels, respectively, to be used when no tessellation control shader is present.
        /// </remarks>
        [EntryPoint(FunctionName = "glPatchParameterfv")]
        public static void PatchParameterfv(PatchParameters pname, float[] values) { throw new NotImplementedException(); }
        /// <summary>
        /// specifies the parameters for patch primitives
        /// </summary>
        /// <param name="pname">Specifies the name of the parameter to set. The symbolc constants GL_PATCH_VERTICES, GL_PATCH_DEFAULT_OUTER_LEVEL, and GL_PATCH_DEFAULT_INNER_LEVEL are accepted.</param>
        /// <param name="values">Specifies the new values for the parameter given by pname.</param>
        /// <remarks>
        /// glPatchParameter specifies the parameters that will be used for patch primitives. pname specifies the parameter to modify and must be either GL_PATCH_VERTICES, GL_PATCH_DEFAULT_OUTER_LEVEL or GL_PATCH_DEFAULT_INNER_LEVEL. For glPatchParameteri, value specifies the new value for the parameter specified by pname. For glPatchParameterfv, values specifies the address of an array containing the new values for the parameter specified by pname.
        /// When pname is GL_PATCH_VERTICES, value specifies the number of vertices that will be used to make up a single patch primitive. Patch primitives are consumed by the tessellation control shader (if present) and subsequently used for tessellation. When primitives are specified using glDrawArrays or a similar function, each patch will be made from parameter control points, each represented by a vertex taken from the enabeld vertex arrays. parameter must be greater than zero, and less than or equal to the value of GL_MAX_PATCH_VERTICES.
        /// When pname is GL_PATCH_DEFAULT_OUTER_LEVEL or GL_PATCH_DEFAULT_INNER_LEVEL, values contains the address of an array contiaining the default outer or inner tessellation levels, respectively, to be used when no tessellation control shader is present.
        /// </remarks>
        [EntryPoint(FunctionName = "glPatchParameterfv")]
        public static void PatchParameterfv(PatchParameters pname, ref float values) { throw new NotImplementedException(); }

        //ARB_transform_feedback2        
        /// <summary>
        /// Binds a Transformfeedback id as current transformfeedback target.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="TransformFeedbackId"></param>
        [EntryPoint(FunctionName = "glBindTransformFeedback")]
        public static void BindTransformFeedback(TransformFeedbackTarget target, uint TransformFeedbackId){ throw new NotImplementedException(); }
        /// <summary>
        /// Binds a Transformfeedback id as current transformfeedback target.
        /// </summary>
        /// <param name="TransformFeedbackId"></param>
        /// <param name="target"></param>
        public static void BindTransformFeedback(uint TransformFeedbackId, TransformFeedbackTarget target = TransformFeedbackTarget.TransformFeedback)
        {
            BindTransformFeedback(target, TransformFeedbackId);
        }
        /// <summary>
        /// Deletes an array of transformfeedback ids.
        /// </summary>
        /// <param name="TransformFeedbackIds"></param>
        [EntryPoint(FunctionName = "glDeleteTransformFeedbacks")]
        unsafe public static void DeleteTransformFeedbacks(int number, uint* TransformFeedbackIds){ throw new NotImplementedException(); }
        /// <summary>
        /// Deletes an array of transformfeedback ids.
        /// </summary>
        /// <param name="TransformFeedbackIds"></param>
        [EntryPoint(FunctionName = "glDeleteTransformFeedbacks")]
        public static void DeleteTransformFeedbacks(int number, uint[] TransformFeedbackIds) { throw new NotImplementedException(); }
        /// <summary>
        /// Deletes an array of transformfeedback ids.
        /// </summary>
        /// <param name="TransformFeedbackIds"></param>
        [EntryPoint(FunctionName = "glDeleteTransformFeedbacks")]
        public static void DeleteTransformFeedbacks(int number, ref uint TransformFeedbackIds) { throw new NotImplementedException(); }
        /// <summary>
        /// Deletes a single transformfeedback id.
        /// </summary>
        /// <param name="TransformFeedbackId"></param>
        public static void DeleteTransformFeedbacks(uint TransformFeedbackId)
        {
            DeleteTransformFeedbacks(1, ref TransformFeedbackId);
        }

        /// <summary>
        /// glDrawTransformFeedback draws primitives of a type specified by mode using a count retrieved from the transform feedback specified by id. Calling glDrawTransformFeedback is equivalent to calling glDrawArrays with mode as specified, first set to zero, and count set to the number of vertices captured on vertex stream zero the last time transform feedback was active on the transform feedback object named by id.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.</param>
        /// <param name="TransformFeedbackId">Specifies the name of a transform feedback object from which to retrieve a primitive count.</param>
        /// <remarks>glDrawTransformFeedback draws primitives of a type specified by mode using a count retrieved from the transform feedback specified by id. Calling glDrawTransformFeedback is equivalent to calling glDrawArrays with mode as specified, first set to zero, and count set to the number of vertices captured on vertex stream zero the last time transform feedback was active on the transform feedback object named by id.</remarks>
        [EntryPoint(FunctionName = "glDrawTransformFeedback")]
        public static void DrawTransformFeedback(BeginMode mode, uint TransformFeedbackId){ throw new NotImplementedException(); }

        /// <summary>
        /// Generates an array of transformfeeback ids.
        /// </summary>
        /// <param name="TransformFeedbackIds"></param>
        [EntryPoint(FunctionName = "glGenTransformFeedbacks")]
        unsafe public static void GenTransformFeedbacks(int number, uint* TransformFeedbackIds){ throw new NotImplementedException(); }
        /// <summary>
        /// Generates an array of transformfeeback ids.
        /// </summary>
        /// <param name="TransformFeedbackIds"></param>
        [EntryPoint(FunctionName = "glGenTransformFeedbacks")]
        public static void GenTransformFeedbacks(int number, uint[] TransformFeedbackIds) { throw new NotImplementedException(); }
        /// <summary>
        /// Generates an array of transformfeeback ids.
        /// </summary>
        /// <param name="TransformFeedbackIds"></param>
        [EntryPoint(FunctionName = "glGenTransformFeedbacks")]
        public static void GenTransformFeedbacks(int number, ref uint TransformFeedbackIds) { throw new NotImplementedException(); }
        /// <summary>
        /// Generates a single transformfeedback id.
        /// </summary>
        /// <returns></returns>
        public static uint GenTransformFeedbacks()
        {
            uint tmp = 0;
            GenTransformFeedbacks(1, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Is this a transformfeedback object?
        /// </summary>
        /// <param name="TransformFeedbackId"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glIsTransformFeedback")]
        public static bool IsTransformFeedback(uint TransformFeedbackId){ throw new NotImplementedException(); }

        /// <summary>
        /// Pauses the running transformfeedback.
        /// </summary>
        [EntryPoint(FunctionName = "glPauseTransformFeedback")]
        public static void PauseTransformFeedback(){ throw new NotImplementedException(); }

        /// <summary>
        /// Resumes the previusly paused transformfeedback.
        /// </summary>
        [EntryPoint(FunctionName = "glResumeTransformFeedback")]
        public static void ResumeTransformFeedback(){ throw new NotImplementedException(); }

        //ARB_transform_feedback3        
        /// <summary>
        /// glBeginQueryIndexed and glEndQueryIndexed delimit the boundaries of a query object. query must be a name previously returned from a call to glGenQueries. If a query object with name id does not yet exist it is created with the type determined by target. target must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED. The behavior of the query object depends on its type and is explained in QueryTarget enum.
        /// Querying the GL_QUERY_RESULT implicitly flushes the GL pipeline until the rendering delimited by the query object has completed and the result is available. GL_QUERY_RESULT_AVAILABLE can be queried to determine if the result is immediately available or if the rendering is not yet complete.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="Index">index specifies the index of the query target and must be between a target-specific maximum.</param>
        /// <param name="QueryID"></param>
        /// <remarks>
        /// If the query target's count exceeds the maximum value representable in the number of available bits, as reported by glGetQueryiv with target set to the appropriate query target and pname GL_QUERY_COUNTER_BITS, the count becomes undefined.
        /// An implementation may support 0 bits in its counter, in which case query results are always undefined and essentially useless.
        /// When GL_SAMPLE_BUFFERS is 0, the samples-passed counter of an occlusion query will increment once for each fragment that passes the depth test. When GL_SAMPLE_BUFFERS is 1, an implementation may either increment the samples-passed counter individually for each sample of a fragment that passes the depth test, or it may choose to increment the counter for all samples of a fragment if any one of them passes the depth test.
        /// Calling glBeginQuery or glEndQuery is equivalent to calling glBeginQueryIndexed or glEndQueryIndexed with index set to zero, respectively.
        /// </remarks>
        [EntryPoint(FunctionName = "glBeginQueryIndexed")]
        public static void BeginQueryIndexed(QueryTarget target, uint Index, uint QueryID){ throw new NotImplementedException(); }
        /// <summary>
        /// glDrawTransformFeedbackStream draws primitives of a type specified by mode using a count retrieved from the transform feedback stream specified by stream of the transform feedback object specified by id. Calling glDrawTransformFeedbackStream is equivalent to calling glDrawArrays with mode as specified, first set to zero, and count set to the number of vertices captured on vertex stream stream the last time transform feedback was active on the transform feedback object named by id.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.</param>
        /// <param name="TransformFeedbackId">Specifies the name of a transform feedback object from which to retrieve a primitive count.</param>
        /// <param name="Stream">Specifies the index of the transform feedback stream from which to retrieve a primitive count.</param>
        /// <remarks>glDrawTransformFeedbackStream draws primitives of a type specified by mode using a count retrieved from the transform feedback stream specified by stream of the transform feedback object specified by id. Calling glDrawTransformFeedbackStream is equivalent to calling glDrawArrays with mode as specified, first set to zero, and count set to the number of vertices captured on vertex stream stream the last time transform feedback was active on the transform feedback object named by id.</remarks>
        [EntryPoint(FunctionName = "glDrawTransformFeedbackStream")]
        public static void DrawTransformFeedbackStream(BeginMode mode, uint TransformFeedbackId, uint Stream){ throw new NotImplementedException(); }

        /// <summary>
        /// glBeginQueryIndexed and glEndQueryIndexed delimit the boundaries of a query object. query must be a name previously returned from a call to glGenQueries. If a query object with name id does not yet exist it is created with the type determined by target. target must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED. The behavior of the query object depends on its type and is explained in QueryTarget enum.
        /// Querying the GL_QUERY_RESULT implicitly flushes the GL pipeline until the rendering delimited by the query object has completed and the result is available. GL_QUERY_RESULT_AVAILABLE can be queried to determine if the result is immediately available or if the rendering is not yet complete.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="Index">index specifies the index of the query target and must be between a target-specific maximum.</param>
        /// <remarks>
        /// If the query target's count exceeds the maximum value representable in the number of available bits, as reported by glGetQueryiv with target set to the appropriate query target and pname GL_QUERY_COUNTER_BITS, the count becomes undefined.
        /// An implementation may support 0 bits in its counter, in which case query results are always undefined and essentially useless.
        /// When GL_SAMPLE_BUFFERS is 0, the samples-passed counter of an occlusion query will increment once for each fragment that passes the depth test. When GL_SAMPLE_BUFFERS is 1, an implementation may either increment the samples-passed counter individually for each sample of a fragment that passes the depth test, or it may choose to increment the counter for all samples of a fragment if any one of them passes the depth test.
        /// Calling glBeginQuery or glEndQuery is equivalent to calling glBeginQueryIndexed or glEndQueryIndexed with index set to zero, respectively.
        /// </remarks>
        [EntryPoint(FunctionName = "glEndQueryIndexed")]
        public static void EndQueryIndexed(QueryTarget target, uint Index){ throw new NotImplementedException(); }

        /// <summary>
        /// glGetQueryIndexediv returns in params a selected parameter of the indexed query object target specified by target and index.
        /// </summary>
        /// <param name="target">Specifies a query object target. Must be GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or GL_TIMESTAMP.</param>
        /// <param name="Index">index specifies the index of the query object target and must be between zero and a target-specific maxiumum.</param>
        /// <param name="pname">Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or GL_QUERY_COUNTER_BITS.</param>
        /// <param name="params">Returns the requested data.</param>
        /// <remarks>
        /// glGetQueryIndexediv returns in params a selected parameter of the indexed query object target specified by target and index. index specifies the index of the query object target and must be between zero and a target-specific maxiumum.
        /// pname names a specific query object target parameter. When pname is GL_CURRENT_QUERY, the name of the currently active query for the specified index of target, or zero if no query is active, will be placed in params. If pname is GL_QUERY_COUNTER_BITS, the implementation-dependent number of bits used to hold the result of queries for target is returned in params.
        /// The target GL_ANY_SAMPLES_PASSED_CONSERVATIVE is available only if the GL version is 4.3 or greater.
        /// If an error is generated, no change is made to the contents of params.
        /// Calling glGetQueryiv is equivalent to calling glGetQueryIndexediv with index set to zero.
        /// </remarks>
        [EntryPoint(FunctionName = "glGetQueryIndexediv")]
        unsafe public static void GetQueryIndexediv(QueryTarget target, uint Index, GetQueryIndexedParameters pname, int* result){ throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryIndexediv returns in params a selected parameter of the indexed query object target specified by target and index.
        /// </summary>
        /// <param name="target">Specifies a query object target. Must be GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or GL_TIMESTAMP.</param>
        /// <param name="Index">index specifies the index of the query object target and must be between zero and a target-specific maxiumum.</param>
        /// <param name="pname">Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or GL_QUERY_COUNTER_BITS.</param>
        /// <param name="params">Returns the requested data.</param>
        /// <remarks>
        /// glGetQueryIndexediv returns in params a selected parameter of the indexed query object target specified by target and index. index specifies the index of the query object target and must be between zero and a target-specific maxiumum.
        /// pname names a specific query object target parameter. When pname is GL_CURRENT_QUERY, the name of the currently active query for the specified index of target, or zero if no query is active, will be placed in params. If pname is GL_QUERY_COUNTER_BITS, the implementation-dependent number of bits used to hold the result of queries for target is returned in params.
        /// The target GL_ANY_SAMPLES_PASSED_CONSERVATIVE is available only if the GL version is 4.3 or greater.
        /// If an error is generated, no change is made to the contents of params.
        /// Calling glGetQueryiv is equivalent to calling glGetQueryIndexediv with index set to zero.
        /// </remarks>
        [EntryPoint(FunctionName = "glGetQueryIndexediv")]
        public static void GetQueryIndexediv(QueryTarget target, uint Index, GetQueryIndexedParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryIndexediv returns in params a selected parameter of the indexed query object target specified by target and index.
        /// </summary>
        /// <param name="target">Specifies a query object target. Must be GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or GL_TIMESTAMP.</param>
        /// <param name="Index">index specifies the index of the query object target and must be between zero and a target-specific maxiumum.</param>
        /// <param name="pname">Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or GL_QUERY_COUNTER_BITS.</param>
        /// <param name="params">Returns the requested data.</param>
        /// <remarks>
        /// glGetQueryIndexediv returns in params a selected parameter of the indexed query object target specified by target and index. index specifies the index of the query object target and must be between zero and a target-specific maxiumum.
        /// pname names a specific query object target parameter. When pname is GL_CURRENT_QUERY, the name of the currently active query for the specified index of target, or zero if no query is active, will be placed in params. If pname is GL_QUERY_COUNTER_BITS, the implementation-dependent number of bits used to hold the result of queries for target is returned in params.
        /// The target GL_ANY_SAMPLES_PASSED_CONSERVATIVE is available only if the GL version is 4.3 or greater.
        /// If an error is generated, no change is made to the contents of params.
        /// Calling glGetQueryiv is equivalent to calling glGetQueryIndexediv with index set to zero.
        /// </remarks>
        [EntryPoint(FunctionName = "glGetQueryIndexediv")]
        public static void GetQueryIndexediv(QueryTarget target, uint Index, GetQueryIndexedParameters pname, ref int result) { throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryIndexediv returns in params a selected parameter of the indexed query object target specified by target and index.
        /// </summary>
        /// <param name="target">Specifies a query object target. Must be GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or GL_TIMESTAMP.</param>
        /// <param name="Index">index specifies the index of the query object target and must be between zero and a target-specific maxiumum.</param>
        /// <param name="pname">Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or GL_QUERY_COUNTER_BITS.</param>
        /// <returns>Returns the requested data.</returns>
        /// <remarks>
        /// glGetQueryIndexediv returns in params a selected parameter of the indexed query object target specified by target and index. index specifies the index of the query object target and must be between zero and a target-specific maxiumum.
        /// pname names a specific query object target parameter. When pname is GL_CURRENT_QUERY, the name of the currently active query for the specified index of target, or zero if no query is active, will be placed in params. If pname is GL_QUERY_COUNTER_BITS, the implementation-dependent number of bits used to hold the result of queries for target is returned in params.
        /// The target GL_ANY_SAMPLES_PASSED_CONSERVATIVE is available only if the GL version is 4.3 or greater.
        /// If an error is generated, no change is made to the contents of params.
        /// Calling glGetQueryiv is equivalent to calling glGetQueryIndexediv with index set to zero.
        /// </remarks>
        public static int GetQueryIndexediv(QueryTarget target, uint Index, GetQueryIndexedParameters pname)
        {
            int tmp = 0;
            GetQueryIndexediv(target, Index, pname, ref tmp);
            return tmp;
        }

        #endregion

        #region Public Helper Functions

        #endregion

    }
}
