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

            //ARB_timer_query
            public delegate void delGetQueryObjecti64v(uint id, GetQueryObjectParameters pname, ref int @params);
            public delegate void delGetQueryObjectui64v(uint id, GetQueryObjectParameters pname, ref uint @params);
            public delegate void delQueryCounter(uint id, QueryCounterTarget target);

            //ARB_blend_func_extended
            public delegate void delBindFragDataLocationIndexed(uint Program, DrawBufferTarget colorNumber, int Index, string Name);
            public delegate int delGetFragDataIndex(uint Program, string Name);

            //ARB_instanced_arrays
            public delegate void delVertexAttribDivisor(uint index, uint Divisor);

            //ARB_vertex_type_2_10_10_10_rev
            /* VertexAttrib: 8 functions ignored.
            public delegate void delVertexAttribP1ui(uint index, VertexAttribPType type, bool normalized, uint value);
            public delegate void delVertexAttribP2ui(uint index, VertexAttribPType type, bool normalized, uint value);
            public delegate void delVertexAttribP3ui(uint index, VertexAttribPType type, bool normalized, uint value);
            public delegate void delVertexAttribP4ui(uint index, VertexAttribPType type, bool normalized, uint value);

            public delegate void delVertexAttribP1uiv(uint index, VertexAttribPType type, bool normalized, uint[] value);
            public delegate void delVertexAttribP2uiv(uint index, VertexAttribPType type, bool normalized, uint[] value);
            public delegate void delVertexAttribP3uiv(uint index, VertexAttribPType type, bool normalized, uint[] value);
            public delegate void delVertexAttribP4uiv(uint index, VertexAttribPType type, bool normalized, uint[] value);
            */

            //ARB_sampler_objects
            public delegate void delGenSamplers(int Count, ref uint Samplers);
            public delegate void delBindSampler(TextureUnit texUnit, uint Sampler);
            public delegate void delSamplerParameteri(uint Sampler, SamplerParameters pname, int param);
            public delegate void delSamplerParameterf(uint Sampler, SamplerParameters pname, float param);
            public delegate void delSamplerParameteriv(uint Sampler, SamplerParameters pname, ref int @params);
            public delegate void delSamplerParameterfv(uint Sampler, SamplerParameters pname, ref float @params);
            public delegate void delSamplerParameterIiv(uint Sampler, SamplerParameters pname, ref int @params);
            public delegate void delSamplerParameterIuiv(uint Sampler, SamplerParameters pname, ref uint @params);
            public delegate void delDeleteSamplers(int Count, ref uint Samplers);
            public delegate bool delIsSampler(uint Sampler);

            public delegate void delGetSamplerParameteriv(uint Sampler, SamplerParameters pname, ref int @params);
            public delegate void delGetSamplerParameterfv(uint Sampler, SamplerParameters pname, ref float @params);

            public delegate void delGetSamplerParameterIiv(uint Sampler, SamplerParameters pname, ref int @params);
            public delegate void delGetSamplerParameterIuiv(uint Sampler, SamplerParameters pname, ref uint @params);

            #endregion

            #region GL Fields

            //ARB_timer_query
            public static delGetQueryObjecti64v glGetQueryObjecti64v;
            public static delGetQueryObjectui64v glGetQueryObjectui64v;
            public static delQueryCounter glQueryCounter;

            //ARB_blend_func_extended
            public static delBindFragDataLocationIndexed glBindFragDataLocationIndexed;
            public static delGetFragDataIndex glGetFragDataIndex;

            //ARB_instanced_arrays
            public static delVertexAttribDivisor glVertexAttribDivisor;

            //ARB_vertex_type_2_10_10_10_rev
            /*
            public static delVertexAttribP1ui glVertexAttribP1ui;
            public static delVertexAttribP2ui glVertexAttribP2ui;
            public static delVertexAttribP3ui glVertexAttribP3ui;
            public static delVertexAttribP4ui glVertexAttribP4ui;

            public static delVertexAttribP1uiv glVertexAttribP1uiv;
            public static delVertexAttribP2uiv glVertexAttribP2uiv;
            public static delVertexAttribP3uiv glVertexAttribP3uiv;
            public static delVertexAttribP4uiv glVertexAttribP4uiv;
            */

            public static delGenSamplers glGenSamplers;
            public static delBindSampler glBindSampler;
            public static delSamplerParameteri glSamplerParameteri;
            public static delSamplerParameterf glSamplerParameterf;
            public static delSamplerParameteriv glSamplerParameteriv;
            public static delSamplerParameterfv glSamplerParameterfv;
            public static delSamplerParameterIiv glSamplerParameterIiv;
            public static delSamplerParameterIuiv glSamplerParameterIuiv;
            public static delDeleteSamplers glDeleteSamplers;
            public static delIsSampler glIsSampler;

            public static delGetSamplerParameteriv glGetSamplerParameteriv;
            public static delGetSamplerParameterfv glGetSamplerParameterfv;

            public static delGetSamplerParameterIiv glGetSamplerParameterIiv;
            public static delGetSamplerParameterIuiv glGetSamplerParameterIuiv;


            #endregion
        }

        #endregion

        #region Public functions.

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
        public static void GetQueryObjecti64v(uint id, GetQueryObjectParameters pname, int[] @params)
        {
            Delegates.glGetQueryObjecti64v(id, pname, ref @params[0]);
        }
        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <returns></returns>
        public static int GetQueryObjecti64v(uint id, GetQueryObjectParameters pname)
        {
            int tmp = 0;
            Delegates.glGetQueryObjecti64v(id, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <param name="params"></param>
        public static void GetQueryObjectui64v(uint id, GetQueryObjectParameters pname, uint[] @params)
        {
            Delegates.glGetQueryObjectui64v(id, pname, ref @params[0]);
        }
        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <returns></returns>
        public static uint GetQueryObjectui64v(uint id, GetQueryObjectParameters pname)
        {
            uint tmp = 0;
            Delegates.glGetQueryObjectui64v(id, pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// record the GL time into a query object after all previous commands have reached the GL server but have not yet necessarily executed.
        /// </summary>
        /// <param name="id">Specify the name of a query object into which to record the GL time.</param>
        /// <param name="target">Specify the counter to query. target must be GL_TIMESTAMP.</param>
        /// <remarks>
        /// glQueryCounter causes the GL to record the current time into the query object named id. target must be GL_TIMESTAMP. The time is recorded after all previous commands on the GL client and server state and the framebuffer have been fully realized. When the time is recorded, the query result for that object is marked available. glQueryCounter timer queries can be used within a glBeginQuery / glEndQuery block where the target is GL_TIME_ELAPSED and it does not affect the result of that query object.
        /// </remarks>
        public static void QueryCounter(uint id, QueryCounterTarget target)
        {
            Delegates.glQueryCounter(id, target);
        }

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
        public static void BindFragDataLocationIndexed(uint Program, DrawBufferTarget colorNumber, int Index, string Name)
        {
            Delegates.glBindFragDataLocationIndexed(Program, colorNumber, Index, Name);
        }
        /// <summary>
        /// query the bindings of color indices to user-defined varying out variables
        /// glGetFragDataIndex returns the index of the fragment color to which the variable name was bound when the program object program was last linked. If name is not a varying out variable of program, or if an error occurs, -1 will be returned.
        /// </summary>
        /// <param name="Program">The name of the program containing varying out variable whose binding to query</param>
        /// <param name="Name">The name of the user-defined varying out variable whose index to query</param>
        /// <returns></returns>
        public static int GetFragDataIndex(uint Program, string Name)
        {
            return Delegates.glGetFragDataIndex(Program, Name);
        }

        //ARB_instanced_arrays
        /// <summary>
        /// Sets the divisor for an Attribute Index on current bound VertexArrayObject.
        /// If the divisor is zero, the corresponding attributesadvance once per vertex. Otherwise, attributes advance once per divisor instances of the set(s) of vertices being rendered. A generic attribute is referred to as in-stanced if its corresponding divisor value is non-zero.
        /// </summary>
        /// <param name="index">AttributeIndex to set divisor for.</param>
        /// <param name="Divisor">Divisor.</param>
        public static void VertexAttribDivisor(uint index, uint Divisor)
        {
            Delegates.glVertexAttribDivisor(index, Divisor);
        }

        /// <summary>
        /// Generates an array of sampler ids.
        /// </summary>
        /// <param name="Samplers"></param>
        public static void GenSamplers(uint[] Samplers)
        {
            Delegates.glGenSamplers(Samplers.Length, ref Samplers[0]);
        }
        /// <summary>
        /// Generates a single sampler id.
        /// </summary>
        /// <returns></returns>
        public static uint GenSamplers()
        {
            uint tmp = 0;
            Delegates.glGenSamplers(1, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Binds a sampler to a texture unit.
        /// </summary>
        /// <param name="texUnit">Texture unit to bind sampler to.</param>
        /// <param name="Sampler">Id of sampler to bind.</param>
        public static void BindSampler(TextureUnit texUnit, uint Sampler)
        {
            Delegates.glBindSampler(texUnit, Sampler);
        }

        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="param">new values for parameter</param>
        public static void SamplerParameteri(uint Sampler, SamplerParameters pname, int param)
        {
            Delegates.glSamplerParameteri(Sampler, pname, param);
        }
        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="param">new values for parameter</param>
        public static void SamplerParameterf(uint Sampler, SamplerParameters pname, float param)
        {
            Delegates.glSamplerParameterf(Sampler, pname, param);
        }
        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        public static void SamplerParameteriv(uint Sampler, SamplerParameters pname, int[] @params)
        {
            Delegates.glSamplerParameteriv(Sampler, pname, ref @params[0]);
        }
        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        public static void SamplerParameterfv(uint Sampler, SamplerParameters pname, float[] @params)
        {
            Delegates.glSamplerParameterfv(Sampler, pname, ref @params[0]);
        }
        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        public static void SamplerParameterIiv(uint Sampler, SamplerParameters pname, int[] @params)
        {
            Delegates.glSamplerParameterIiv(Sampler, pname, ref @params[0]);
        }
        /// <summary>
        /// Sets the parameter of a sampler object.
        /// </summary>
        /// <param name="Sampler">id of sampler to change.</param>
        /// <param name="pname">Name of parameter to set.</param>
        /// <param name="params">new values for parameter</param>
        public static void SamplerParameterIuiv(uint Sampler, SamplerParameters pname, uint[] @params)
        {
            Delegates.glSamplerParameterIuiv(Sampler, pname, ref @params[0]);
        }

        /// <summary>
        /// Deletes an array of samplers.
        /// </summary>
        /// <param name="Samplers"></param>
        public static void DeleteSamplers(uint[] Samplers)
        {
            Delegates.glDeleteSamplers(Samplers.Length, ref Samplers[0]);
        }
        /// <summary>
        /// Deletes a single sampler.
        /// </summary>
        /// <param name="SamplerID"></param>
        public static void DeleteSamplers(uint SamplerID)
        {
            Delegates.glDeleteSamplers(1, ref SamplerID);
        }

        /// <summary>
        /// Is this a sampler?
        /// </summary>
        /// <param name="Sampler"></param>
        /// <returns></returns>
        public static bool IsSampler(uint Sampler)
        {
            return Delegates.glIsSampler(Sampler);
        }

        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        public static void GetSamplerParameteriv(uint Sampler, SamplerParameters pname, int[] @params)
        {
            Delegates.glGetSamplerParameteriv(Sampler, pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <returns></returns>
        public static int GetSamplerParameteriv(uint Sampler, SamplerParameters pname)
        {
            int tmp = 0;
            Delegates.glGetSamplerParameteriv(Sampler, pname, ref tmp);
            return tmp;
        }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        public static void GetSamplerParameterfv(uint Sampler, SamplerParameters pname, float[] @params)
        {
            Delegates.glGetSamplerParameterfv(Sampler, pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <returns></returns>
        public static float GetSamplerParameterfv(uint Sampler, SamplerParameters pname)
        {
            float tmp = 0.0f;
            Delegates.glGetSamplerParameterfv(Sampler, pname, ref tmp);
            return tmp;
        }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        public static void GetSamplerParameterIiv(uint Sampler, SamplerParameters pname, int[] @params)
        {
            Delegates.glGetSamplerParameterIiv(Sampler, pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <returns></returns>
        public static int GetSamplerParameterIiv(uint Sampler, SamplerParameters pname)
        {
            int tmp = 0;
            Delegates.glGetSamplerParameterIiv(Sampler, pname, ref tmp);
            return tmp;
        }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <param name="params"></param>
        public static void GetSamplerParameterIuiv(uint Sampler, SamplerParameters pname, uint[] @params)
        {
            Delegates.glGetSamplerParameterIuiv(Sampler, pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives a sampler parameter from named sampler
        /// </summary>
        /// <param name="Sampler">id of sampler to query.</param>
        /// <param name="pname">Name of parameter to retrive value for.</param>
        /// <returns></returns>
        public static uint GetSamplerParameterIuiv(uint Sampler, SamplerParameters pname)
        {
            uint tmp = 0;
            Delegates.glGetSamplerParameterIuiv(Sampler, pname, ref tmp);
            return tmp;
        }


        #endregion
    }
}
