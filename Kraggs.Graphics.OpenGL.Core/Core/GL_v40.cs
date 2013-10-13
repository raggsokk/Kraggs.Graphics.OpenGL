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

            //ARB_draw_buffer_blend
            public delegate void delBlendEquationSeparatei(uint buf, BlendEquationSeparateRGB modeRGB, BlendEquationSeparateAlpha modeAlpha);
            public delegate void delBlendEquationi(uint buf, BlendEquationMode mode);
            public delegate void delBlendFuncSeparatei(uint buf, BlendFactorSrc srcRGB, BlendFactorDst dstRGB, BlendFactorSrc srcAlpha, BlendFactorDst dstAlpha);
            public delegate void delBlendFunci(uint buf, BlendFactorSrc src, BlendFactorDst dst);
            //ARB_draw_indirect
            public delegate void delDrawArraysIndirect(BeginMode mode, IntPtr indirect);
            public delegate void delDrawElementsIndirect(BeginMode mode, IndicesType type, IntPtr Indirect);

            //ARB_shader_subroutine
            public delegate void delGetActiveSubroutineName(uint Program, ShaderType type, uint index, int bufSize, out int Length, StringBuilder Name);
            public delegate void delGetActiveSubroutineUniformName(uint Program, ShaderType type, uint index, int bufsize, out int length, StringBuilder Name);
            public delegate void delGetActiveSubroutineUniformiv(uint Program, ShaderType type, uint Index, SubroutineUniformParameters pname, ref int values);
            public delegate void delGetProgramStageiv(uint Program, ShaderType type, ProgramStageParameters pname, ref int values);
            public delegate uint delGetSubroutineIndex(uint Program, ShaderType type, string Name);
            public delegate int delGetSubroutineUniformLocation(uint Program, ShaderType type, string Name);
            public delegate void delGetUniformSubroutineuiv(uint Program, int location, ref uint @params);
            public delegate void delUniformSubroutinesuiv(ShaderType type, int count, ref uint Indices);

            //ARB_gpu_shader_fp64
            public delegate void delGetUniformdv(uint Program, int location, ref double @params);

            public delegate void delUniform1d(int location, double v1);
            public delegate void delUniform2d(int location, double v1, double v2);
            public delegate void delUniform3d(int location, double v1, double v2, double v3);
            public delegate void delUniform4d(int location, double v1, double v2, double v3, double v4);

            public delegate void delUniform1dv(int location, int count, ref double v);
            public delegate void delUniform2dv(int location, int count, ref double v);
            public delegate void delUniform3dv(int location, int count, ref double v);
            public delegate void delUniform4dv(int location, int count, ref double v);

            public delegate void delUniformMatrix2dv(int location, int count, bool transpose, ref double matrix);
            public delegate void delUniformMatrix3dv(int location, int count, bool transpose, ref double matrix);
            public delegate void delUniformMatrix4dv(int location, int count, bool transpose, ref double matrix);

            public delegate void delUniformMatrix2x3dv(int location, int count, bool transpose, ref double matrix);
            public delegate void delUniformMatrix2x4dv(int location, int count, bool transpose, ref double matrix);

            public delegate void delUniformMatrix3x2dv(int location, int count, bool transpose, ref double matrix);
            public delegate void delUniformMatrix3x4dv(int location, int count, bool transpose, ref double matrix);

            public delegate void delUniformMatrix4x2dv(int location, int count, bool transpose, ref double matrix);
            public delegate void delUniformMatrix4x3dv(int location, int count, bool transpose, ref double matrix);

            //ARB_sample_shading
            public delegate void delMinSampleShading(float value);

            //ARB_tessellation_shader
            public delegate void delPatchParameteri(PatchParameters pname, int value);
            public delegate void delPatchParameterfv(PatchParameters pname, ref float values);

            //ARB_transform_feedback2
            public delegate void delBindTransformFeedback(TransformFeedbackTarget target, uint TransformFeedbackId);
            public delegate void delDeleteTransformFeedbacks(int number, ref uint TransformFeedbackIds);
            public delegate void delDrawTransformFeedback(BeginMode mode, uint TransformFeedbackId);
            public delegate void delGenTransformFeedbacks(int number, ref uint TransformFeedbackIds);
            public delegate bool delIsTransformFeedback(uint TransformFeedbackId);
            public delegate void delPauseTransformFeedback();
            public delegate void delResumeTransformFeedback();

            //ARB_transform_feedback3
            public delegate void delBeginQueryIndexed(QueryTarget target, uint Index, uint QueryID);
            public delegate void delDrawTransformFeedbackStream(BeginMode mode, uint TransformFeedbackId, uint Stream);
            public delegate void delEndQueryIndexed(QueryTarget target, uint Index);
            public delegate void delGetQueryIndexediv(QueryTarget target, uint Index, GetQueryIndexedParameters pname, ref int @params);

            #endregion

            #region GL Fields

            //ARB_draw_buffer_blend
            public static delBlendEquationSeparatei glBlendEquationSeparatei;
            public static delBlendEquationi glBlendEquationi;
            public static delBlendFuncSeparatei glBlendFuncSeparatei;
            public static delBlendFunci glBlendFunci;

            //ARB_draw_indirect
            public static delDrawArraysIndirect glDrawArraysIndirect;
            public static delDrawElementsIndirect glDrawElementsIndirect;

            //ARB_shader_subroutine
            public static delGetActiveSubroutineName glGetActiveSubroutineName;
            public static delGetActiveSubroutineUniformName glGetActiveSubroutineUniformName;
            public static delGetActiveSubroutineUniformiv glGetActiveSubroutineUniformiv;
            public static delGetProgramStageiv glGetProgramStageiv;
            public static delGetSubroutineIndex glGetSubroutineIndex;
            public static delGetSubroutineUniformLocation glGetSubroutineUniformLocation;
            public static delGetUniformSubroutineuiv glGetUniformSubroutineuiv;
            public static delUniformSubroutinesuiv glUniformSubroutinesuiv;

            //ARB_gpu_shader_fp64
            public static delGetUniformdv glGetUniformdv;

            public static delUniform1d glUniform1d;
            public static delUniform2d glUniform2d;
            public static delUniform3d glUniform3d;
            public static delUniform4d glUniform4d;

            public static delUniform1dv glUniform1dv;
            public static delUniform2dv glUniform2dv;
            public static delUniform3dv glUniform3dv;
            public static delUniform4dv glUniform4dv;

            public static delUniformMatrix2dv glUniformMatrix2dv;
            public static delUniformMatrix3dv glUniformMatrix3dv;
            public static delUniformMatrix4dv glUniformMatrix4dv;

            public static delUniformMatrix2x3dv glUniformMatrix2x3dv;
            public static delUniformMatrix2x4dv glUniformMatrix2x4dv;

            public static delUniformMatrix3x2dv glUniformMatrix3x2dv;
            public static delUniformMatrix3x4dv glUniformMatrix3x4dv;

            public static delUniformMatrix4x2dv glUniformMatrix4x2dv;
            public static delUniformMatrix4x3dv glUniformMatrix4x3dv;

            //ARB_sample_shading
            public static delMinSampleShading glMinSampleShading;

            //ARB_tessellation_shader
            public static delPatchParameteri glPatchParameteri;
            public static delPatchParameterfv glPatchParameterfv;

            //ARB_transform_feedback2
            public static delBindTransformFeedback glBindTransformFeedback;
            public static delDeleteTransformFeedbacks glDeleteTransformFeedbacks;
            public static delDrawTransformFeedback glDrawTransformFeedback;
            public static delGenTransformFeedbacks glGenTransformFeedbacks;
            public static delIsTransformFeedback glIsTransformFeedback;
            public static delPauseTransformFeedback glPauseTransformFeedback;
            public static delResumeTransformFeedback glResumeTransformFeedback;

            //ARB_transform_feedback3
            public static delBeginQueryIndexed glBeginQueryIndexed;
            public static delDrawTransformFeedbackStream glDrawTransformFeedbackStream;
            public static delEndQueryIndexed glEndQueryIndexed;
            public static delGetQueryIndexediv glGetQueryIndexediv;

            #endregion
        }

        #endregion

        #region Public functions.

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
        public static void BlendEquationSeparatei(uint buf, BlendEquationSeparateRGB modeRGB, BlendEquationSeparateAlpha modeAlpha)
        {
            Delegates.glBlendEquationSeparatei(buf, modeRGB, modeAlpha);
        }
        /// <summary>
        /// Sets  the equation used for both the RGB blend equation and the Alpha blend equation
        /// </summary>
        /// <param name="buf">specifies the index of the draw buffer for which to set the blend equation.</param>
        /// <param name="mode">specifies how source and destination colors are combined. It must be GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN, GL_MAX.</param>
        /// <remarks>
        /// The blend equations determine how a new pixel (the ''source'' color) is combined with a pixel already in the framebuffer (the ''destination'' color). This function sets both the RGB blend equation and the alpha blend equation to a single equation. glBlendEquationi specifies the blend equation for a single draw buffer whereas glBlendEquation sets the blend equation for all draw buffers.
        /// </remarks>
        public static void BlendEquationi(uint buf, BlendEquationMode mode)
        {
            Delegates.glBlendEquationi(buf, mode);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buf">specifies the index of the draw buffer</param>
        /// <param name="srcRGB"></param>
        /// <param name="dstRGB"></param>
        /// <param name="srcAlpha"></param>
        /// <param name="dstAlpha"></param>
        public static void BlendFuncSeparatei(uint buf, BlendFactorSrc srcRGB, BlendFactorDst dstRGB, BlendFactorSrc srcAlpha, BlendFactorDst dstAlpha)
        {
            Delegates.glBlendFuncSeparatei(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="buf">specifies the index of the draw buffer</param>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        public static void BlendFunci(uint buf, BlendFactorSrc src, BlendFactorDst dst)
        {
            Delegates.glBlendFunci(buf, src, dst);
        }
        //ARB_draw_indirect
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
            Delegates.glDrawArraysIndirect(mode, (IntPtr)indirectOffset);
        }
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
            Delegates.glDrawElementsIndirect(mode, type, (IntPtr)indirectOffset);
        }
        //
        //ARB_texture_cube_map_array
        //ARB_texture_query_lod
        //ARB_texture_buffer_object_rgb32

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
        public static void GetActiveSubroutineName(uint Program, ShaderType type, uint index, int bufSize, out int Length, StringBuilder Name)
        {
            Delegates.glGetActiveSubroutineName(Program, type, index, bufSize, out Length, Name);
        }
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

            Delegates.glGetActiveSubroutineName(Program, type, index, sb.Capacity - 2, out MaxSubroutineNameLength, sb);

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
        public static void GetActiveSubroutineUniformName(uint Program, ShaderType type, uint index, int bufsize, out int length, StringBuilder Name)
        {
            Delegates.glGetActiveSubroutineUniformName(Program, type, index, bufsize, out length, Name);
        }
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

            Delegates.glGetActiveSubroutineUniformName(Program, type, index, sb.Capacity -2, out MaxSubroutineUniformNameLength, sb);

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
        public static void GetActiveSubroutineUniformiv(uint Program, ShaderType type, uint Index, SubroutineUniformParameters pname, int[] values)
        {
            Delegates.glGetActiveSubroutineUniformiv(Program, type, Index, pname, ref values[0]);
        }
        /// <summary>
        /// Retrives subroutine uniform parameters for a program stage.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="Index">Subroutine Uniform Index to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <returns></returns>
        public static int GetActiveSubroutineUniformiv(uint Program, ShaderType type, uint Index, SubroutineUniformParameters pname)
        {
            int tmp = 0;
            Delegates.glGetActiveSubroutineUniformiv(Program, type, Index, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Returns the Subroutine index for a Subroutine. 
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="Name">Name of subroutine to get index for.</param>
        /// <returns></returns>
        public static uint GetSubroutineIndex(uint Program, ShaderType type, string Name)
        {
            return Delegates.glGetSubroutineIndex(Program, type, Name);
        }
        /// <summary>
        /// Retrives the subroutine uniform location used to set uniform selector value.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="Name">Name of SubroutineUnifrom.</param>
        /// <returns></returns>
        public static int GetSubroutineUniformLocation(uint Program, ShaderType type, string Name)
        {
            return Delegates.glGetSubroutineUniformLocation(Program, type, Name);
        }

        /// <summary>
        /// Retrives parameters about a UniformSubroutine.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="location">SubroutineUniform Location to query.</param>
        /// <param name="params"></param>
        public static void GetUniformSubroutineuiv(uint Program, int location, uint[] @params)
        {
            Delegates.glGetUniformSubroutineuiv(Program, location, ref @params[0]);
        }
        /// <summary>
        /// Retrives parameters about a UniformSubroutine.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="location">SubroutineUniform Location to query.</param>
        /// <returns></returns>
        public static uint GetUniformSubroutineuiv(uint Program, int location)
        {
            uint tmp = 0;
            Delegates.glGetUniformSubroutineuiv(Program, location, ref tmp);
            return tmp;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="count"></param>
        /// <param name="Indices"></param>
        public static void UniformSubroutinesuiv(ShaderType type, int count, uint[] Indices)
        {
            Delegates.glUniformSubroutinesuiv(type, count, ref Indices[0]);
        }

        /// <summary>
        /// Gets Program Stage Parameters.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="values"></param>
        public static void GetProgramStageiv(uint Program, ShaderType type, ProgramStageParameters pname, int[] values)
        {
            Delegates.glGetProgramStageiv(Program, type, pname, ref values[0]);
        }
        /// <summary>
        /// Gets Program Stage Parameters.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="type">Which shader stage of program to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <returns></returns>
        public static int GetProgramStageiv(uint Program, ShaderType type, ProgramStageParameters pname)
        {
            int tmp = 0;
            Delegates.glGetProgramStageiv(Program, type, pname, ref tmp);
            return tmp;
        }

        //ARB_gpu_shader5
        //ARB_gpu_shader_fp64

        /// <summary>
        /// Retrives the double value of a uniform.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="location">Uniform location to retrive value from.</param>
        /// <param name="params"></param>
        public static void GetUniformdv(uint Program, int location, double[] @params)
        {
            Delegates.glGetUniformdv(Program, location, ref @params[0]);
        }
        /// <summary>
        /// Retrives the double value of a uniform.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="location">Uniform location to retrive value from.</param>
        /// <returns></returns>
        public static double GetUniformdv(uint Program, int location)
        {
            double tmp = 0.0d;
            Delegates.glGetUniformdv(Program, location, ref tmp);
            return tmp;
        }

        public static void Uniform1d(int location, double v1)
        {
            Delegates.glUniform1d(location, v1);
        }
        public static void Uniform2d(int location, double v1, double v2)
        {
            Delegates.glUniform2d(location, v1, v2);
        }
        public static void Uniform3d(int location, double v1, double v2, double v3)
        {
            Delegates.glUniform3d(location, v1, v2, v3);
        }
        public static void Uniform4d(int location, double v1, double v2, double v3, double v4)
        {
            Delegates.glUniform4d(location, v1, v2, v3, v4);
        }

        public static void Uniform1dv(int location, ref double v, int count = 1)
        {
            Delegates.glUniform1dv(location, count, ref v);
        }
        public static void Uniform1dv(int location, double[] v)
        {
            Delegates.glUniform1dv(location, v.Length, ref v[0]);
        }

        public static void Uniform2dv(int location, ref double v, int count = 1)
        {
            Delegates.glUniform2dv(location, count, ref v);
        }
        public static void Uniform2dv(int location, double[] v)
        {
            Delegates.glUniform2dv(location, v.Length / 2, ref v[0]);
        }

        public static void Uniform3dv(int location, ref double v, int count = 1)
        {
            Delegates.glUniform3dv(location, count, ref v);
        }
        public static void Uniform3dv(int location, double[] v)
        {
            Delegates.glUniform3dv(location, v.Length / 3, ref v[0]);
        }

        public static void Uniform4dv(int location, ref double v, int count = 1)
        {
            Delegates.glUniform4dv(location, count, ref v);
        }
        public static void Uniform4dv(int location, double[] v)
        {
            Delegates.glUniform4dv(location, v.Length / 4, ref v[0]);
        }

        public static void UniformMatrix2dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix2dv(location, count, transpose, ref matrix);
        }
        public static void UniformMatrix3dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix3dv(location, count, transpose, ref matrix);
        }
        public static void UniformMatrix4dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix4dv(location, count, transpose, ref matrix);
        }

        public static void UniformMatrix2x3dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix2x3dv(location, count, transpose, ref matrix);
        }
        public static void UniformMatrix2x4dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix2x4dv(location, count, transpose, ref matrix);
        }

        public static void UniformMatrix3x2dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix3x2dv(location, count, transpose, ref matrix);
        }
        public static void UniformMatrix3x4dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix3x4dv(location, count, transpose, ref matrix);
        }

        public static void UniformMatrix4x2dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix4x2dv(location, count, transpose, ref matrix);
        }
        public static void UniformMatrix4x3dv(int location, ref double matrix, int count = 1, bool transpose = false)
        {
            Delegates.glUniformMatrix4x3dv(location, count, transpose, ref matrix);
        }

        //ARB_sample_shading
        /// <summary>
        /// Sets the minimum sample shadering?
        /// </summary>
        /// <param name="value"></param>
        public static void MinSampleShading(float value)
        {
            Delegates.glMinSampleShading(value);
        }
        //ARB_texture_gather
        //ARB_tessellation_shader
        //public static void PatchParameteri;
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
        public static void PatchParameteri(PatchParameters pname, int value)
        {
            Delegates.glPatchParameteri(pname, value);
        }
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
        public static void PatchParameterfv(PatchParameters pname, float value)
        {
            Delegates.glPatchParameterfv(pname, ref value);
        }
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
        public static void PatchParameterfv(PatchParameters pname, float[] values)
        {
            Delegates.glPatchParameterfv(pname, ref values[0]);
        }

        //ARB_transform_feedback2
        /// <summary>
        /// Binds a Transformfeedback id as current transformfeedback target.
        /// </summary>
        /// <param name="TransformFeedbackId"></param>
        /// <param name="target"></param>
        public static void BindTransformFeedback(uint TransformFeedbackId, TransformFeedbackTarget target = TransformFeedbackTarget.TransformFeedback)
        {
            Delegates.glBindTransformFeedback(target, TransformFeedbackId);
        }

        /// <summary>
        /// Deletes an array of transformfeedback ids.
        /// </summary>
        /// <param name="TransformFeedbackIds"></param>
        public static void DeleteTransformFeedbacks(uint[] TransformFeedbackIds)
        {
            Delegates.glDeleteTransformFeedbacks(TransformFeedbackIds.Length, ref TransformFeedbackIds[0]);
        }
        /// <summary>
        /// Deletes a single transformfeedback id.
        /// </summary>
        /// <param name="TransformFeedbackId"></param>
        public static void DeleteTransformFeedbacks(uint TransformFeedbackId)
        {
            Delegates.glDeleteTransformFeedbacks(1, ref TransformFeedbackId);
        }
        /// <summary>
        /// glDrawTransformFeedback draws primitives of a type specified by mode using a count retrieved from the transform feedback specified by id. Calling glDrawTransformFeedback is equivalent to calling glDrawArrays with mode as specified, first set to zero, and count set to the number of vertices captured on vertex stream zero the last time transform feedback was active on the transform feedback object named by id.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.</param>
        /// <param name="TransformFeedbackId">Specifies the name of a transform feedback object from which to retrieve a primitive count.</param>
        /// <remarks>glDrawTransformFeedback draws primitives of a type specified by mode using a count retrieved from the transform feedback specified by id. Calling glDrawTransformFeedback is equivalent to calling glDrawArrays with mode as specified, first set to zero, and count set to the number of vertices captured on vertex stream zero the last time transform feedback was active on the transform feedback object named by id.</remarks>
        public static void DrawTransformFeedback(BeginMode mode, uint TransformFeedbackId)
        {
            Delegates.glDrawTransformFeedback(mode, TransformFeedbackId);
        }

        /// <summary>
        /// Generates an array of transformfeeback ids.
        /// </summary>
        /// <param name="TransformFeedbackIds"></param>
        public static void GenTransformFeedbacks(uint[] TransformFeedbackIds)
        {
            Delegates.glGenTransformFeedbacks(TransformFeedbackIds.Length, ref TransformFeedbackIds[0]);
        }
        /// <summary>
        /// Generates a single transformfeedback id.
        /// </summary>
        /// <returns></returns>
        public static uint GenTransformFeedbacks()
        {
            uint tmp = 0;
            Delegates.glGenTransformFeedbacks(1, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Is this a transformfeedback object?
        /// </summary>
        /// <param name="TransformFeedbackId"></param>
        /// <returns></returns>
        public static bool IsTransformFeedback(uint TransformFeedbackId)
        {
            return Delegates.glIsTransformFeedback(TransformFeedbackId);
        }
        /// <summary>
        /// Pauses the running transformfeedback.
        /// </summary>
        public static void PauseTransformFeedback()
        {
            Delegates.glPauseTransformFeedback();
        }
        /// <summary>
        /// Resumes the previusly paused transformfeedback.
        /// </summary>
        public static void ResumeTransformFeedback()
        {
            Delegates.glResumeTransformFeedback();
        }
        //ARB_transform_feedback3
        /// <summary>
        /// glDrawTransformFeedbackStream draws primitives of a type specified by mode using a count retrieved from the transform feedback stream specified by stream of the transform feedback object specified by id. Calling glDrawTransformFeedbackStream is equivalent to calling glDrawArrays with mode as specified, first set to zero, and count set to the number of vertices captured on vertex stream stream the last time transform feedback was active on the transform feedback object named by id.
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render. Symbolic constants GL_POINTS, GL_LINE_STRIP, GL_LINE_LOOP, GL_LINES, GL_LINE_STRIP_ADJACENCY, GL_LINES_ADJACENCY, GL_TRIANGLE_STRIP, GL_TRIANGLE_FAN, GL_TRIANGLES, GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLES_ADJACENCY, and GL_PATCHES are accepted.</param>
        /// <param name="TransformFeedbackId">Specifies the name of a transform feedback object from which to retrieve a primitive count.</param>
        /// <param name="Stream">Specifies the index of the transform feedback stream from which to retrieve a primitive count.</param>
        /// <remarks>glDrawTransformFeedbackStream draws primitives of a type specified by mode using a count retrieved from the transform feedback stream specified by stream of the transform feedback object specified by id. Calling glDrawTransformFeedbackStream is equivalent to calling glDrawArrays with mode as specified, first set to zero, and count set to the number of vertices captured on vertex stream stream the last time transform feedback was active on the transform feedback object named by id.</remarks>
        public static void DrawTransformFeedbackStream(BeginMode mode, uint TransformFeedbackId, uint Stream)
        {
            Delegates.glDrawTransformFeedbackStream(mode, TransformFeedbackId, Stream);
        }
        //GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.
        //GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED. GL_ANY_SAMPLES_PASSED_CONSERVATIVE, 
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
        public static void BeginQueryIndexed(QueryTarget target, uint Index, uint QueryID)
        {
            Delegates.glBeginQueryIndexed(target, Index, QueryID);
        }
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
        public static void EndQueryIndexed(QueryTarget target, uint Index)
        {
            Delegates.glEndQueryIndexed(target, Index);
        }
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
        public static void GetQueryIndexediv(QueryTarget target, uint Index, GetQueryIndexedParameters pname, int[] @params)
        {
            Delegates.glGetQueryIndexediv(target, Index, pname, ref @params[0]);
        }
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
            Delegates.glGetQueryIndexediv(target, Index, pname, ref tmp);
            return tmp;
        }        

        #endregion
    }
}
