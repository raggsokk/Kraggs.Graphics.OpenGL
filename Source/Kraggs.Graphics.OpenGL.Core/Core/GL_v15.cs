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
    // template class until gl 4.4 where its not neede for another year.
    partial class GL
    {
//        #region Delegate Class

//        partial class Delegates
//        {

//            #region Delegates

//            public delegate void delBindBuffer(BufferTarget target, uint BufferID);
//            public delegate void delDeleteBuffers(int number, ref uint BufferIDs);
//            public delegate void delGenBuffers(int number, ref uint BufferIDs);
//            public delegate bool delIsBuffer(uint BufferID);
//            public delegate void delBufferData(BufferTarget target, IntPtr Size, IntPtr Data, BufferUsage usage);
//            public delegate void delBufferSubData(BufferTarget target, IntPtr Offset, IntPtr Size, IntPtr data);
//            public delegate void delGetBufferSubData(BufferTarget target, IntPtr Offset, IntPtr Size, IntPtr data);
//            public delegate IntPtr delMapBuffer(BufferTarget target, MapBufferAccess access);
//            public delegate void delUnmapBuffer(BufferTarget target);
//            public delegate void delGetBufferParameteriv(BufferTarget target, BufferParameters pname, ref int @params);
//            public delegate void delGetBufferPointerv(BufferTarget target, BufferPointerParameters pname, out IntPtr param);

//            public delegate void delGenQueries(int number, ref uint QueryIDs);
//            public delegate void delDeleteQueries(int number, ref uint QueryIDs);
//            public delegate bool delIsQuery(uint QueryID);
//            public delegate void delBeginQuery(QueryTarget target, uint QueryID);
//            public delegate void delEndQuery(QueryTarget target);
//            public delegate void delGetQueryiv(QueryTarget target, GetQueryParameters pname, ref int @params);
//            //public delegate void delGetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname, ref int @params);
//            public unsafe delegate void delGetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname, int* param);
//            public delegate void delGetQueryObjectuiv(uint QueryID, GetQueryObjectParameters pname, ref uint @params);

//            #endregion

//            #region GL Fields

//            public static delGenQueries glGenQueries;
//            public static delDeleteQueries glDeleteQueries;
//            public static delIsQuery glIsQuery;
//            public static delBeginQuery glBeginQuery;
//            public static delEndQuery glEndQuery;
//            public static delGetQueryiv glGetQueryiv;
//            public static delGetQueryObjectiv glGetQueryObjectiv;
//            public static delGetQueryObjectuiv glGetQueryObjectuiv;
//            public static delBindBuffer glBindBuffer;
//            public static delDeleteBuffers glDeleteBuffers;
//            public static delGenBuffers glGenBuffers;
//            public static delIsBuffer glIsBuffer;
//            public static delBufferData glBufferData;
//            public static delBufferSubData glBufferSubData;
//            public static delGetBufferSubData glGetBufferSubData;
//            public static delMapBuffer glMapBuffer;
//            public static delUnmapBuffer glUnmapBuffer;
//            public static delGetBufferParameteriv glGetBufferParameteriv;
//            public static delGetBufferPointerv glGetBufferPointerv;

//            #endregion
//        }

//        #endregion

//        #region Public functions.

//        /// <summary>
//        /// Bind a buffer to a buffertarget.
//        /// </summary>
//        /// <param name="target">The buffer target to bind to.</param>
//        /// <param name="BufferID">The id of the buffer to bind.</param>
//        public static void BindBuffer(BufferTarget target, uint BufferID)
//        {
//            Delegates.glBindBuffer(target, BufferID);
//        }

//        /// <summary>
//        /// Delete a number of buffers.
//        /// </summary>
//        /// <param name="BufferIDs">array of buffers to delete.</param>
//        public static void DeleteBuffers(uint[] BufferIDs)
//        {
//            Delegates.glDeleteBuffers(BufferIDs.Length, ref BufferIDs[0]);
//        }
//        /// <summary>
//        /// Delete a single buffer id.
//        /// </summary>
//        /// <param name="BufferID"></param>
//        public static void DeleteBuffers(uint BufferID)
//        {
//            Delegates.glDeleteBuffers(1, ref BufferID);
//        }

//        /// <summary>
//        /// Create a number of buffer ids.
//        /// </summary>
//        /// <param name="BufferIDs"></param>
//        public static void GenBuffers(uint[] BufferIDs)
//        {
//            Delegates.glGenBuffers(BufferIDs.Length, ref BufferIDs[0]);
//        }
//        /// <summary>
//        /// Create a buffer id.
//        /// </summary>
//        /// <returns></returns>
//        public static uint GenBuffers()
//        {
//            uint tmp = 0;
//            Delegates.glGenBuffers(1, ref tmp);
//            return tmp;
//        }

//        /// <summary>
//        /// Is this id a valid buffer?
//        /// </summary>
//        /// <param name="BufferID"></param>
//        /// <returns></returns>
//        public static bool IsBuffer(uint BufferID)
//        {
//            return Delegates.glIsBuffer(BufferID);
//        }

//        /// <summary>
//        /// Create and upload buffer data,
//        /// </summary>
//        /// <param name="target">Buffertarget to upload to.</param>
//        /// <param name="Size">Size in bytes of data to upload/allocate</param>
//        /// <param name="Data">Pointer to the data to upload, or zero for allocate</param>
//        /// <param name="usage">Give Opengl a hint of how your gonna use this buffer.</param>
//        public static void BufferData(BufferTarget target, IntPtr Size, IntPtr Data, BufferUsage usage)
//        {
//            Delegates.glBufferData(target, Size, Data, usage);
//        }
//        /// <summary>
//        /// Create/Allocate and upload buffer data.
//        /// </summary>
//        /// <param name="target">Buffertarget to upload/allocate to.</param>
//        /// <param name="Size">Size in bytes of data to upload/allocate</param>
//        /// <param name="Data">Pointer to the data to upload, or zero for allocate</param>
//        /// <param name="usage">Give Opengl a hint of how your gonna use this buffer.</param>
//        public static void BufferData(BufferTarget target, long Size, IntPtr Data, BufferUsage usage)
//        {
//            Delegates.glBufferData(target, (IntPtr)Size, Data, usage);
//        }

//        /// <summary>
//        /// Upload data into an existing buffer.
//        /// </summary>
//        /// <param name="target">Target to upload buffer data to.</param>
//        /// <param name="Offset">Offset in buffer to start writing at.</param>
//        /// <param name="Size">The size of buffer upload</param>
//        /// <param name="data">The pointer to the data to upload.</param>
//        public static void BufferSubData(BufferTarget target, IntPtr Offset, IntPtr Size, IntPtr data)
//        {
//            Delegates.glBufferSubData(target, Offset, Size, data);
//        }
//        /// <summary>
//        /// Uploads data into an existing buffer.
//        /// </summary>
//        /// <param name="target">Target to upload buffer data to.</param>
//        /// <param name="Offset">Offset in buffer to start writing at.</param>
//        /// <param name="Size">The size of buffer upload</param>
//        /// <param name="data">The pointer to the data to upload.</param>
//        public static void BufferSubData(BufferTarget target, long Offset, long Size, IntPtr data)
//        {
//            Delegates.glBufferSubData(target, (IntPtr)Offset, (IntPtr)Size, data);
//        }
//        public static void BufferSubData(BufferTarget target, long Offset, byte[] data)
//        {
//            BufferSubData(target, Offset, data, 0, data.Length);
//        }
//        public unsafe static void BufferSubData(BufferTarget target, long Offset, byte[] data, int index,int length)
//        {
//            var len = Math.Min(data.Length, index + length) - index;

//#if DEBUG
//            Debug.Assert(len >= 0);
//#endif

//            //if (len > 0)
//            {
//                fixed (byte* ptr = &data[index])
//                {
//                    Delegates.glBufferSubData(target, (IntPtr)Offset, (IntPtr)len, (IntPtr)ptr);
//                }
//            }
//        }
//        public static void BufferSubData(BufferTarget target, long Offset, float[] data)
//        {
//            BufferSubData(target, Offset, data, 0, data.Length);
//        }
//        public unsafe static void BufferSubData(BufferTarget target, long Offset, float[] data, int index, int length)
//        {
//            var len = Math.Min(data.Length, index + length) - index;

//#if DEBUG
//            Debug.Assert(len >= 0);
//#endif

//            //if (len > 0)
//            {
//                fixed (float* ptr = &data[index])
//                {
//                    Delegates.glBufferSubData(target, (IntPtr)Offset, (IntPtr)len, (IntPtr)ptr);
//                }
//            }
//        }

//        public static void BufferSubData<TValueType>(BufferTarget target, long Offset, TValueType[] data)
//        {
//            BufferSubData<TValueType>(target, Offset, data, 0, data.Length);
//        }
//        public static void BufferSubData<TValueType>(BufferTarget target, long Offset, TValueType[] data, int index, int count)
//        {
//            var elementcount = Math.Min(data.Length, index + count) - index;

//            var sizeinbytes = Marshal.SizeOf(typeof(TValueType)) * elementcount;

//            var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

//            var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(data, index);

//            Delegates.glBufferSubData(target, (IntPtr)Offset, (IntPtr)sizeinbytes, ptr);

//            handle.Free();
//        }

//        /// <summary>
//        /// Retrive the contents of bound buffer target into data pointer.
//        /// </summary>
//        /// <param name="target">The buffer target to retrive from.</param>
//        /// <param name="Offset">The byte-offset from start of bound buffer to retrive.</param>
//        /// <param name="Size">The size in bytes of data to retrive.</param>
//        /// <param name="data">The pointer to copy data to.</param>
//        public static void GetBufferSubData(BufferTarget target, IntPtr Offset, IntPtr Size, IntPtr data)
//        {
//            Delegates.glGetBufferSubData(target, Offset, Size, data);
//        }

//        /// <summary>
//        /// Maps a buffer into client space.
//        /// </summary>
//        /// <param name="target"></param>
//        /// <param name="access"></param>
//        /// <returns></returns>
//        public static IntPtr MapBuffer(BufferTarget target, MapBufferAccess access)
//        {
//            return Delegates.glMapBuffer(target, access);
//        }

//        /// <summary>
//        /// Unmaps a previously mapped buffer.
//        /// </summary>
//        /// <param name="target"></param>
//        public static void UnmapBuffer(BufferTarget target)
//        {
//            Delegates.glUnmapBuffer(target);
//        }

//        public static void GetBufferParameteriv(BufferTarget target, BufferParameters pname, int[] @params)
//        {
//            Delegates.glGetBufferParameteriv(target, pname, ref @params[0]);
//        }
//        public static int GetBufferParameteriv(BufferTarget target, BufferParameters pname)
//        {
//            int tmp = 0;
//            Delegates.glGetBufferParameteriv(target, pname, ref tmp);
//            return tmp;
//        }

//        public static void GetBufferPointerv(BufferTarget target, BufferPointerParameters pname, out IntPtr param)
//        {
//            Delegates.glGetBufferPointerv(target, pname, out @param);
//        }



//        /// <summary>
//        /// Generates an array of query ids.
//        /// </summary>
//        /// <param name="QueryIDs"></param>
//        public static void GenQueries(uint[] QueryIDs)
//        {
//            Delegates.glGenQueries(QueryIDs.Length, ref QueryIDs[0]);
//        }
//        /// <summary>
//        /// Generates a single query id.
//        /// </summary>
//        /// <param name="QueryID"></param>
//        /// <returns></returns>
//        public static uint GenQueries()
//        {
//            uint tmp = 0;
//            Delegates.glGenQueries(1, ref tmp);
//            return tmp;
//        }
//        /// <summary>
//        /// Delets an array of query objects
//        /// </summary>
//        /// <param name="QueryIDs"></param>
//        public static void DeleteQueries(uint[] QueryIDs)
//        {
//            Delegates.glDeleteQueries(QueryIDs.Length, ref QueryIDs[0]);
//        }
//        /// <summary>
//        /// Deletes a single query object
//        /// </summary>
//        /// <param name="QueryID"></param>
//        public static void DeleteQueries(uint QueryID)
//        {
//            Delegates.glDeleteQueries(1, ref QueryID);
//        }

//        /// <summary>
//        /// Is this a query?
//        /// </summary>
//        /// <param name="QueryID"></param>
//        /// <returns></returns>
//        public static bool IsQuery(uint QueryID)
//        {
//            return Delegates.glIsQuery(QueryID);
//        }
//        /// <summary>
//        /// glBeginQuery and glEndQuery delimit the boundaries of a query object. query must be a name previously returned from a call to glGenQueries. If a query object with name id does not yet exist it is created with the type determined by target. target must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.
//        /// Calling glBeginQuery or glEndQuery is equivalent to calling glBeginQueryIndexed or glEndQueryIndexed with index set to zero, respectively.
//        /// </summary>
//        /// <param name="target">Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic constant must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.</param>
//        /// <param name="QueryID">Specifies the name of a query object.</param>
//        public static void BeginQuery(QueryTarget target, uint QueryID)
//        {
//            Delegates.glBeginQuery(target, QueryID);
//        }

//        /// <summary>
//        /// glBeginQuery and glEndQuery delimit the boundaries of a query object. query must be a name previously returned from a call to glGenQueries. If a query object with name id does not yet exist it is created with the type determined by target. target must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.
//        /// Calling glBeginQuery or glEndQuery is equivalent to calling glBeginQueryIndexed or glEndQueryIndexed with index set to zero, respectively.
//        /// </summary>
//        /// <param name="target">Specifies the target type of query object to be concluded. The symbolic constant must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.</param>
//        public static void EndQuery(QueryTarget target)
//        {
//            Delegates.glEndQuery(target);
//        }

//        /// <summary>
//        /// glGetQueryiv returns in params a selected parameter of the query object target specified by target.
//        /// Calling glGetQueryiv is equivalent to calling glGetQueryIndexediv with index set to zero.
//        /// </summary>
//        /// <param name="target">Specifies a query object target. Must be GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or GL_TIMESTAMP.</param>
//        /// <param name="pname">Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or GL_QUERY_COUNTER_BITS.</param>
//        /// <param name="params"></param>
//        public static void GetQueryiv(QueryTarget target, GetQueryParameters pname, int[] @params)
//        {
//            Delegates.glGetQueryiv(target, pname, ref @params[0]);
//        }
//        /// <summary>
//        /// glGetQueryiv returns in params a selected parameter of the query object target specified by target.
//        /// Calling glGetQueryiv is equivalent to calling glGetQueryIndexediv with index set to zero.
//        /// </summary>
//        /// <param name="target">Specifies a query object target. Must be GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or GL_TIMESTAMP.</param>
//        /// <param name="pname">Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or GL_QUERY_COUNTER_BITS.</param>
//        /// <returns></returns>
//        public static int GetQueryiv(QueryTarget target, GetQueryParameters pname)
//        {
//            int tmp = 0;
//            Delegates.glGetQueryiv(target, pname, ref tmp);
//            return tmp;
//        }
//        /// <summary>
//        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
//        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
//        /// </summary>
//        /// <param name="QueryID">Specifies the name of a query object.</param>
//        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
//        /// <param name="params">If no buffer is bound to GL_QUERY_RESULT_BUFFER, then params is treated as an address in client memory of a variable to receive the resulting data.</param>
//        /// <remarks>
//        /// If an error is generated, no change is made to the contents of params.
//        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
//        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
//        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
//        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater.
//        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
//        /// </remarks>        
//        public unsafe static void GetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname, int[] @params)
//        {
//            //Delegates.glGetQueryObjectiv(QueryID, pname, ref @params[0]);
//            fixed(int* ptr = &@params[0])
//                Delegates.glGetQueryObjectiv(QueryID, pname, ptr);
//        }
//        /// <summary>
//        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
//        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
//        /// </summary>
//        /// <param name="QueryID">Specifies the name of a query object.</param>
//        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
//        /// <returns></returns>
//        /// <remarks>
//        /// If an error is generated, no change is made to the contents of params.
//        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
//        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
//        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
//        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater.
//        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
//        /// </remarks>        
//        public unsafe static int GetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname)
//        {
//            int tmp = 0;
//            Delegates.glGetQueryObjectiv(QueryID, pname, &tmp);
//            return tmp;
//        }
//        /// <summary>
//        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
//        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
//        /// </summary>
//        /// <param name="QueryID">Specifies the name of a query object.</param>
//        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
//        /// <param name="params">If no buffer is bound to GL_QUERY_RESULT_BUFFER, then params is treated as an address in client memory of a variable to receive the resulting data.</param>
//        /// <remarks>
//        /// If an error is generated, no change is made to the contents of params.
//        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
//        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
//        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
//        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater.
//        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
//        /// </remarks>        
//        public static void GetQueryObjectuiv(uint QueryID, GetQueryObjectParameters pname, uint[] @params)
//        {
//            Delegates.glGetQueryObjectuiv(QueryID, pname, ref @params[0]);
//        }
//        /// <summary>
//        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
//        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
//        /// </summary>
//        /// <param name="QueryID">Specifies the name of a query object.</param>
//        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
//        /// <returns></returns>
//        /// <remarks>
//        /// If an error is generated, no change is made to the contents of params.
//        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
//        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
//        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
//        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater.
//        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
//        /// </remarks>        
//        public static uint GetQueryObjectuiv(uint QueryID, GetQueryObjectParameters pname)
//        {
//            uint tmp = 0;
//            Delegates.glGetQueryObjectuiv(QueryID, pname, ref tmp);
//            return tmp;
//        }

//        #endregion
    }
}
