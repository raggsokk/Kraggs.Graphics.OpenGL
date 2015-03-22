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

        //ARB_timer_query
        [EntryPointSlot(255)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetQueryObjecti64v(uint id, GetQueryObjectParameters pname, long* result);
        [EntryPointSlot(256)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetQueryObjectui64v(uint id, GetQueryObjectParameters pname, ulong* result);
        [EntryPointSlot(257)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glQueryCounter(uint id, QueryCounterTarget target);

        //ARB_blend_func_extended
        [EntryPointSlot(258)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindFragDataLocationIndexed(uint Program, DrawBufferTarget colorNumber, int Index, string Name);
        [EntryPointSlot(259)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern int glGetFragDataIndex(uint Program, string Name);

        //ARB_instanced_arrays
        [EntryPointSlot(260)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexAttribDivisor(uint index, uint Divisor);

        //ARB_vertex_type_2_10_10_10_rev
        /* VertexAttrib: 8 functions ignored.
        private static extern void glVertexAttribP1ui(uint index, VertexAttribPType type, bool normalized, uint value);
        private static extern void glVertexAttribP2ui(uint index, VertexAttribPType type, bool normalized, uint value);
        private static extern void glVertexAttribP3ui(uint index, VertexAttribPType type, bool normalized, uint value);
        private static extern void glVertexAttribP4ui(uint index, VertexAttribPType type, bool normalized, uint value);

        private static extern void glVertexAttribP1uiv(uint index, VertexAttribPType type, bool normalized, uint[] value);
        private static extern void glVertexAttribP2uiv(uint index, VertexAttribPType type, bool normalized, uint[] value);
        private static extern void glVertexAttribP3uiv(uint index, VertexAttribPType type, bool normalized, uint[] value);
        private static extern void glVertexAttribP4uiv(uint index, VertexAttribPType type, bool normalized, uint[] value);
        */

        //ARB_sampler_objects
        [EntryPointSlot(261)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGenSamplers(int Count, uint* Samplers);
        [EntryPointSlot(262)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindSampler(uint texUnit, uint Sampler);
        //private static extern void glBindSampler(TextureUnit texUnit, uint Sampler);
        [EntryPointSlot(263)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glSamplerParameteri(uint Sampler, SamplerParameters pname, int param);
        [EntryPointSlot(264)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glSamplerParameterf(uint Sampler, SamplerParameters pname, float param);
        [EntryPointSlot(265)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glSamplerParameteriv(uint Sampler, SamplerParameters pname, int* data);
        [EntryPointSlot(266)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glSamplerParameterfv(uint Sampler, SamplerParameters pname, float* data);
        [EntryPointSlot(267)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glSamplerParameterIiv(uint Sampler, SamplerParameters pname, int* data);
        [EntryPointSlot(274)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glSamplerParameterIuiv(uint Sampler, SamplerParameters pname, uint* data);
        [EntryPointSlot(268)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glDeleteSamplers(int Count, uint* Samplers);
        [EntryPointSlot(269)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsSampler(uint Sampler);

        [EntryPointSlot(270)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetSamplerParameteriv(uint Sampler, SamplerParameters pname, int* result);
        [EntryPointSlot(271)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetSamplerParameterfv(uint Sampler, SamplerParameters pname, float* result);

        [EntryPointSlot(272)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetSamplerParameterIiv(uint Sampler, SamplerParameters pname, int* result);
        [EntryPointSlot(273)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetSamplerParameterIuiv(uint Sampler, SamplerParameters pname, uint* result);


        #endregion

        #region Public functions

        //ARB_timer_query
        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="id">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <param name="params"></param>
        /// <remarks>
        /// 
        /// If an error is generated, no change is made to the contents of params.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater        
        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
        /// </remarks>
        [EntryPoint(FunctionName = "glGetQueryObjecti64v")]
        unsafe public static void GetQueryObjecti64v(uint id, GetQueryObjectParameters pname, long* result){ throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="id">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <param name="params"></param>
        /// <remarks>
        /// 
        /// If an error is generated, no change is made to the contents of params.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater        
        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
        /// </remarks>
        [EntryPoint(FunctionName = "glGetQueryObjecti64v")]
        public static void GetQueryObjecti64v(uint id, GetQueryObjectParameters pname, long[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="id">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <param name="params"></param>
        /// <remarks>
        /// 
        /// If an error is generated, no change is made to the contents of params.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater        
        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
        /// </remarks>
        [EntryPoint(FunctionName = "glGetQueryObjecti64v")]
        public static void GetQueryObjecti64v(uint id, GetQueryObjectParameters pname, ref long result) { throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetQueryObjecti64v")]
        public static long GetQueryObjecti64v(uint id, GetQueryObjectParameters pname) { throw new NotImplementedException(); }


        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetQueryObjectui64v")]
        unsafe public static void GetQueryObjectui64v(uint id, GetQueryObjectParameters pname, ulong* result){ throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetQueryObjectui64v")]
        public static void GetQueryObjectui64v(uint id, GetQueryObjectParameters pname, ulong[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetQueryObjectui64v")]
        public static void GetQueryObjectui64v(uint id, GetQueryObjectParameters pname, ref ulong result) { throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetQueryObjectui64v")]
        public static ulong GetQueryObjectui64v(uint id, GetQueryObjectParameters pname) { throw new NotImplementedException(); }

        /// <summary>
        /// record the GL time into a query object after all previous commands have reached the GL server but have not yet necessarily executed.
        /// </summary>
        /// <param name="id">Specify the name of a query object into which to record the GL time.</param>
        /// <param name="target">Specify the counter to query. target must be GL_TIMESTAMP.</param>
        /// <remarks>
        /// glQueryCounter causes the GL to record the current time into the query object named id. target must be GL_TIMESTAMP. The time is recorded after all previous commands on the GL client and server state and the framebuffer have been fully realized. When the time is recorded, the query result for that object is marked available. glQueryCounter timer queries can be used within a glBeginQuery / glEndQuery block where the target is GL_TIME_ELAPSED and it does not affect the result of that query object.
        /// </remarks>
        [EntryPoint(FunctionName = "glQueryCounter")]
        public static void QueryCounter(uint id, QueryCounterTarget target){ throw new NotImplementedException(); }

        //ARB_blend_func_extended
        /// <summary>
        /// bind a user-defined varying/attribute out variable to a fragment shader color number and index
        /// </summary>
        /// <param name="Program">The name of the program containing varying/attribute out variable whose binding to modify</param>
        /// <param name="colorNumber">The color number to bind the user-defined varying out variable to. colorNumber must be less than the value of GL_MAX_DRAW_BUFFERS</param>
        /// <param name="Index">The index of the color input to bind the user-defined varying out variable to</param>
        /// <param name="Name">The name of the user-defined varying/attribute out variable whose binding to modify</param>
        /// <remarks>
        /// glBindFragDataLocationIndexed specifies that the varying out variable name in program should be bound to fragment color colorNumber when the program is next linked. index may be zero or one to specify that the color be used as either the first or second color input to the blend equation, respectively.
        /// The bindings specified by glBindFragDataLocationIndexed have no effect until program is next linked. Bindings may be specified at any time after program has been created. Specifically, they may be specified before shader objects are attached to the program. Therefore, any name may be specified in name, including a name that is never used as a varying out variable in any fragment shader object. Names beginning with gl_ are reserved by the GL.
        /// If name was bound previously, its assigned binding is replaced with colorNumber and index. name must be a null-terminated string. index must be less than or equal to one, and colorNumber must be less than the value of GL_MAX_DRAW_BUFFERS if index is zero, and less than the value of GL_MAX_DUAL_SOURCE_DRAW_BUFFERS if index is greater than or equal to one.
        /// <list type="bullet">
        ///     <listheader>In addition to the errors generated by glBindFragDataLocationIndexed, the program program will fail to link if:</listheader>
        ///     <item>The number of active outputs is greater than the value GL_MAX_DRAW_BUFFERS.</item>
        ///     <item>More than one varying out variable is bound to the same color number.</item>
        /// </list>
        /// Varying out varyings may have locations assigned explicitly in the shader text using a location layout qualifier. If a shader statically assigns a location to a varying out variable in the shader text, that location is used and any location assigned with glBindFragDataLocation is ignored.
        /// </remarks>
        [EntryPoint(FunctionName = "glBindFragDataLocationIndexed")]
        public static void BindFragDataLocationIndexed(uint Program, DrawBufferTarget colorNumber, int Index, string Name){ throw new NotImplementedException(); }

        /// <summary>
        /// query the bindings of color indices to user-defined varying out variables
        /// glGetFragDataIndex returns the index of the fragment color to which the variable name was bound when the program object program was last linked. If name is not a varying out variable of program, or if an error occurs, -1 will be returned.
        /// </summary>
        /// <param name="Program">The name of the program containing varying out variable whose binding to query</param>
        /// <param name="Name">The name of the user-defined varying out variable whose index to query</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetFragDataIndex")]
        public static int GetFragDataIndex(uint Program, string Name){ throw new NotImplementedException(); }

        //ARB_instanced_arrays
        /// <summary>
        /// Sets the divisor for an Attribute Index on current bound VertexArrayObject.
        /// If the divisor is zero, the corresponding attributesadvance once per vertex. Otherwise, attributes advance once per divisor instances of the set(s) of vertices being rendered. A generic attribute is referred to as in-stanced if its corresponding divisor value is non-zero.
        /// </summary>
        /// <param name="index">AttributeIndex to set divisor for.</param>
        /// <param name="Divisor">Divisor.</param>
        [EntryPoint(FunctionName = "glVertexAttribDivisor")]
        public static void VertexAttribDivisor(uint index, uint Divisor){ throw new NotImplementedException(); }

        //ARB_vertex_type_2_10_10_10_rev
        /* VertexAttrib: 8 functions ignored.
        public static void VertexAttribP1ui(uint index, VertexAttribPType type, bool normalized, uint value){ throw new NotImplementedException(); }
        public static void VertexAttribP2ui(uint index, VertexAttribPType type, bool normalized, uint value){ throw new NotImplementedException(); }
        public static void VertexAttribP3ui(uint index, VertexAttribPType type, bool normalized, uint value){ throw new NotImplementedException(); }
        public static void VertexAttribP4ui(uint index, VertexAttribPType type, bool normalized, uint value){ throw new NotImplementedException(); }

        public static void VertexAttribP1uiv(uint index, VertexAttribPType type, bool normalized, uint[] value){ throw new NotImplementedException(); }
        public static void VertexAttribP2uiv(uint index, VertexAttribPType type, bool normalized, uint[] value){ throw new NotImplementedException(); }
        public static void VertexAttribP3uiv(uint index, VertexAttribPType type, bool normalized, uint[] value){ throw new NotImplementedException(); }
        public static void VertexAttribP4uiv(uint index, VertexAttribPType type, bool normalized, uint[] value){ throw new NotImplementedException(); }
        */

        //ARB_sampler_objects

        /// <summary>
        /// Generates an array of sampler ids.
        /// </summary>
        /// <param name="Samplers"></param>
        [EntryPoint(FunctionName = "glGenSamplers")]
        unsafe public static void GenSamplers(int Count, uint* Samplers){ throw new NotImplementedException(); }
        /// <summary>
        /// Generates an array of sampler ids.
        /// </summary>
        /// <param name="Samplers"></param>
        [EntryPoint(FunctionName = "glGenSamplers")]
        public static void GenSamplers(int Count, uint[] Samplers) { throw new NotImplementedException(); }
        /// <summary>
        /// Generates an array of sampler ids.
        /// </summary>
        /// <param name="Samplers"></param>
        [EntryPoint(FunctionName = "glGenSamplers")]
        public static void GenSamplers(int Count, ref uint Samplers) { throw new NotImplementedException(); }
        /// <summary>
        /// Generates an array of sampler ids.
        /// </summary>
        public static uint[] GenSamplers(int Count)
        {
            var t = new uint[Count];
            GenSamplers(t.Length, ref t[0]);
            return t;
        }
        /// <summary>
        /// Generates a single sampler id.
        /// </summary>
        /// <returns></returns>        
        public static uint GenSamplers()
        {
            uint t = 0;
            GenSamplers(1, ref t);
            return t;
        }

        /// <summary>
        /// Binds a sampler to a texture unit.
        /// </summary>
        /// <param name="texUnit">Texture unit to bind sampler to.</param>
        /// <param name="Sampler">Id of sampler to bind.</param>
        [EntryPoint(FunctionName = "glBindSampler")]
        public static void BindSampler(uint texUnit, uint Sampler) { throw new NotImplementedException(); }
        //public static void BindSampler(TextureUnit texUnit, uint Sampler){ throw new NotImplementedException(); }

        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="param">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameteri")]
        public static void SamplerParameteri(uint Sampler, SamplerParameters pname, int param) { throw new NotImplementedException(); }

        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="param">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameterf")]
        public static void SamplerParameterf(uint Sampler, SamplerParameters pname, float param) { throw new NotImplementedException(); }

        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameteriv")]
        unsafe public static void SamplerParameteriv(uint Sampler, SamplerParameters pname, int* data){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameteriv")]
        public static void SamplerParameteriv(uint Sampler, SamplerParameters pname, int[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameteriv")]
        public static void SamplerParameteriv(uint Sampler, SamplerParameters pname, ref int data) { throw new NotImplementedException(); }

        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameterfv")]
        unsafe public static void SamplerParameterfv(uint Sampler, SamplerParameters pname, float* data) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameterfv")]
        public static void SamplerParameterfv(uint Sampler, SamplerParameters pname, float[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameterfv")]
        public static void SamplerParameterfv(uint Sampler, SamplerParameters pname, ref float data) { throw new NotImplementedException(); }

        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameterIiv")]
        unsafe public static void SamplerParameterIiv(uint Sampler, SamplerParameters pname, int* data){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameterIiv")]
        public static void SamplerParameterIiv(uint Sampler, SamplerParameters pname, int[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameterIiv")]
        public static void SamplerParameterIiv(uint Sampler, SamplerParameters pname, ref int data) { throw new NotImplementedException(); }

        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameterIuiv")]
        unsafe public static void SamplerParameterIuiv(uint Sampler, SamplerParameters pname, uint* data){ throw new NotImplementedException(); }
        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameterIuiv")]
        public static void SamplerParameterIuiv(uint Sampler, SamplerParameters pname, uint[] data) { throw new NotImplementedException(); }
        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        [EntryPoint(FunctionName = "glSamplerParameterIuiv")]
        public static void SamplerParameterIuiv(uint Sampler, SamplerParameters pname, ref uint data) { throw new NotImplementedException(); }

        /// <summary>
        /// Deletes an array of samplers.
        /// </summary>
        /// <param name="Samplers"></param>
        [EntryPoint(FunctionName = "glDeleteSamplers")]
        unsafe public static void DeleteSamplers(int Count, uint* Samplers){ throw new NotImplementedException(); }
        /// <summary>
        /// Deletes an array of samplers.
        /// </summary>
        /// <param name="Samplers"></param>        
        public static void DeleteSamplers(uint[] Samplers)
        {
            DeleteSamplers(Samplers.Length, ref Samplers[0]);
        }
        /// <summary>
        /// Deletes an array of samplers.
        /// </summary>
        /// <param name="Samplers"></param>
        [EntryPoint(FunctionName = "glDeleteSamplers")]
        public static void DeleteSamplers(int Count, ref uint Samplers) { throw new NotImplementedException(); }
        /// <summary>
        /// Deletes a single sampler.
        /// </summary>
        /// <param name="SamplerID"></param>
        public static void DeleteSamplers(uint SamplerID)
        {
            DeleteSamplers(1, ref SamplerID);
        }

        /// <summary>
        /// Is this a sampler?
        /// </summary>
        /// <param name="Sampler"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glIsSampler")]
        public static bool IsSampler(uint Sampler){ throw new NotImplementedException(); }


        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetSamplerParameteriv")]
        unsafe public static void GetSamplerParameteriv(uint Sampler, SamplerParameters pname, int* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetSamplerParameteriv")]
        public static void GetSamplerParameteriv(uint Sampler, SamplerParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetSamplerParameteriv")]
        public static void GetSamplerParameteriv(uint Sampler, SamplerParameters pname, ref int result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetSamplerParameteriv")]
        public static int GetSamplerParameteriv(uint Sampler, SamplerParameters pname) { throw new NotImplementedException(); }

        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetSamplerParameterfv")]
        unsafe public static void GetSamplerParameterfv(uint Sampler, SamplerParameters pname, float* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetSamplerParameterfv")]
        public static void GetSamplerParameterfv(uint Sampler, SamplerParameters pname, float[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetSamplerParameterfv")]
        public static void GetSamplerParameterfv(uint Sampler, SamplerParameters pname, ref float result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetSamplerParameterfv")]
        public static float GetSamplerParameterfv(uint Sampler, SamplerParameters pname) { throw new NotImplementedException(); }

        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetSamplerParameterIiv")]
        unsafe public static void GetSamplerParameterIiv(uint Sampler, SamplerParameters pname, int* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetSamplerParameterIiv")]
        public static void GetSamplerParameterIiv(uint Sampler, SamplerParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetSamplerParameterIiv")]
        public static void GetSamplerParameterIiv(uint Sampler, SamplerParameters pname, ref int result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetSamplerParameterIiv")]
        public static int GetSamplerParameterIiv(uint Sampler, SamplerParameters pname) { throw new NotImplementedException(); }

        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetSamplerParameterIuiv")]
        unsafe public static void GetSamplerParameterIuiv(uint Sampler, SamplerParameters pname, uint* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetSamplerParameterIuiv")]
        public static void GetSamplerParameterIuiv(uint Sampler, SamplerParameters pname, uint[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        [EntryPoint(FunctionName = "glGetSamplerParameterIuiv")]
        public static void GetSamplerParameterIuiv(uint Sampler, SamplerParameters pname, ref uint result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGetSamplerParameterIuiv")]
        public static uint GetSamplerParameterIuiv(uint Sampler, SamplerParameters pname) { throw new NotImplementedException(); }

        #endregion

        #region Public Helper Functions

        #endregion

    }
}
