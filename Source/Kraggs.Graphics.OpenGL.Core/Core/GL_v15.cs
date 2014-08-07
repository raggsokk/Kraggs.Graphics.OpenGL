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

        #region OpenGL DLLImports

        //[EntryPointSlot(85)]
        //[DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //private static extern void glBindTexture(TextureTarget target, uint textureid);

        [EntryPointSlot(85)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindBuffer(BufferTarget target, uint BufferID);
        [EntryPointSlot(86)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glDeleteBuffers(int number, uint* BufferIDs);
        [EntryPointSlot(87)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGenBuffers(int number, uint* BufferIDs);
        [EntryPointSlot(88)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsBuffer(uint BufferID);
        [EntryPointSlot(89)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBufferData(BufferTarget target, IntPtr Size, IntPtr Data, BufferUsage usage);
        [EntryPointSlot(90)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBufferSubData(BufferTarget target, IntPtr Offset, IntPtr Size, IntPtr data);
        [EntryPointSlot(91)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetBufferSubData(BufferTarget target, IntPtr Offset, IntPtr Size, IntPtr data);
        [EntryPointSlot(92)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern IntPtr glMapBuffer(BufferTarget target, MapBufferAccess access);
        [EntryPointSlot(93)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUnmapBuffer(BufferTarget target);
        [EntryPointSlot(94)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetBufferParameteriv(BufferTarget target, BufferParameters pname, int* result);
        [EntryPointSlot(95)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetBufferPointerv(BufferTarget target, BufferPointerParameters pname, out IntPtr param);

        [EntryPointSlot(96)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGenQueries(int number, uint* QueryIDs);
        [EntryPointSlot(97)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glDeleteQueries(int number, uint* QueryIDs);
        [EntryPointSlot(98)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsQuery(uint QueryID);
        [EntryPointSlot(99)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBeginQuery(QueryTarget target, uint QueryID);
        [EntryPointSlot(100)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glEndQuery(QueryTarget target);
        [EntryPointSlot(101)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetQueryiv(QueryTarget target, GetQueryParameters pname, int* result);
        //private static extern void glGetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname, ref int @params);

        [EntryPointSlot(102)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname, int* result);
        [EntryPointSlot(103)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetQueryObjectuiv(uint QueryID, GetQueryObjectParameters pname, uint* result);


        #endregion

        #region Public functions

        /// <summary>
        /// Bind a buffer to a buffertarget.
        /// </summary>
        /// <param name="target">The buffer target to bind to.</param>
        /// <param name="BufferID">The id of the buffer to bind.</param>
        [EntryPoint(FunctionName = "glBindBuffer")]
        public static void BindBuffer(BufferTarget target, uint BufferID){ throw new NotImplementedException(); }
        /// <summary>
        /// Delete a number of buffers.
        /// </summary>
        /// <param name="BufferIDs">array of buffers to delete.</param>
        [EntryPoint(FunctionName = "glDeleteBuffers")]
        unsafe public static void DeleteBuffers(int number, uint* BufferIDs){ throw new NotImplementedException(); }
        /// <summary>
        /// Delete a single buffer.
        /// </summary>
        /// <param name="BufferID">id of buffer to delete.</param>
        [EntryPoint(FunctionName = "glDeleteBuffers")]
        public static void DeleteBuffers(uint BufferID) { throw new NotImplementedException(); }

        /// <summary>
        /// Create a number of buffer ids.
        /// </summary>
        /// <param name="BufferIDs"></param>
        [EntryPoint(FunctionName = "glGenBuffers")]
        unsafe public static void GenBuffers(int number, uint* BufferIDs){ throw new NotImplementedException(); }
        /// <summary>
        /// Create a single buffer id.
        /// </summary>
        [EntryPoint(FunctionName = "glGenBuffers")]
        public static uint GenBuffers() { throw new NotImplementedException(); }
        /// <summary>
        /// Is this id a valid buffer?
        /// </summary>
        /// <param name="BufferID"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glIsBuffer")]
        public static bool IsBuffer(uint BufferID){ throw new NotImplementedException(); }

        /// <summary>
        /// Create and upload buffer data,
        /// </summary>
        /// <param name="target">Buffertarget to upload to.</param>
        /// <param name="Size">Size in bytes of data to upload/allocate</param>
        /// <param name="Data">Pointer to the data to upload, or zero for allocate</param>
        /// <param name="usage">Give Opengl a hint of how your gonna use this buffer.</param>
        [EntryPoint(FunctionName = "glBufferData")]
        public static void BufferData(BufferTarget target, IntPtr Size, IntPtr Data, BufferUsage usage){ throw new NotImplementedException(); }

        /// <summary>
        /// Upload data into an existing buffer.
        /// </summary>
        /// <param name="target">Target to upload buffer data to.</param>
        /// <param name="Offset">Offset in buffer to start writing at.</param>
        /// <param name="Size">The size of buffer upload</param>
        /// <param name="data">The pointer to the data to upload.</param>
        [EntryPoint(FunctionName = "glBufferSubData")]
        public static void BufferSubData(BufferTarget target, IntPtr Offset, IntPtr Size, IntPtr data){ throw new NotImplementedException(); }

        /// <summary>
        /// Retrive the contents of bound buffer target into data pointer.
        /// </summary>
        /// <param name="target">The buffer target to retrive from.</param>
        /// <param name="Offset">The byte-offset from start of bound buffer to retrive.</param>
        /// <param name="Size">The size in bytes of data to retrive.</param>
        /// <param name="data">The pointer to copy data to.</param>
        [EntryPoint(FunctionName = "glGetBufferSubData")]
        public static void GetBufferSubData(BufferTarget target, IntPtr Offset, IntPtr Size, IntPtr data){ throw new NotImplementedException(); }

        /// <summary>
        /// Maps a buffer into client space.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="access"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glMapBuffer")]
        public static IntPtr MapBuffer(BufferTarget target, MapBufferAccess access){ throw new NotImplementedException(); }

        /// <summary>
        /// Unmaps a previously mapped buffer.
        /// </summary>
        /// <param name="target"></param>
        [EntryPoint(FunctionName = "glUnmapBuffer")]
        public static void UnmapBuffer(BufferTarget target){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetBufferParameteriv")]
        unsafe public static void GetBufferParameteriv(BufferTarget target, BufferParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetBufferParameteriv")]
        public static void GetBufferParameteriv(BufferTarget target, BufferParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetBufferParameteriv")]
        public static int GetBufferParameteriv(BufferTarget target, BufferParameters pname) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetBufferParameteriv")]
        public static void GetBufferParameteriv(BufferTarget target, BufferParameters pname, out int result) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetBufferPointerv")]
        public static void GetBufferPointerv(BufferTarget target, BufferPointerParameters pname, out IntPtr param){ throw new NotImplementedException(); }


        /// <summary>
        /// Generates an array of query ids.
        /// </summary>
        /// <param name="QueryIDs"></param>
        [EntryPoint(FunctionName = "glGenQueries")]
        unsafe public static void GenQueries(int number, uint* QueryIDs){ throw new NotImplementedException(); }
        /// <summary>
        /// Generates an array of query ids.
        /// </summary>
        /// <param name="QueryIDs"></param>
        [EntryPoint(FunctionName = "glGenQueries")]
        public static void GenQueries(int number, uint[] QueryIDs) { throw new NotImplementedException(); }
        /// <summary>
        /// Generates a single query id.
        /// </summary>        
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGenQueries")]
        unsafe public static uint GenQueries() { throw new NotImplementedException(); }
        /// <summary>
        /// Generates a single query id.
        /// </summary>
        /// <param name="QueryID"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glGenQueries")]
        unsafe public static void GenQueries(out uint QueryID) { throw new NotImplementedException(); }

        /// <summary>
        /// Delets an array of query objects
        /// </summary>
        /// <param name="QueryIDs"></param>
        [EntryPoint(FunctionName = "glDeleteQueries")]
        unsafe public static void DeleteQueries(int number, uint* QueryIDs){ throw new NotImplementedException(); }
        /// <summary>
        /// Delets an array of query objects
        /// </summary>
        /// <param name="QueryIDs"></param>
        [EntryPoint(FunctionName = "glDeleteQueries")]
        public static void DeleteQueries(int number, uint[] QueryIDs) { throw new NotImplementedException(); }
        /// <summary>
        /// Deletes a single query object
        /// </summary>
        /// <param name="QueryID"></param>
        [EntryPoint(FunctionName = "glDeleteQueries")]
        public static void DeleteQueries(uint QueryID) { throw new NotImplementedException(); }

        /// <summary>
        /// Is this a query?
        /// </summary>
        /// <param name="QueryID"></param>
        [EntryPoint(FunctionName = "glIsQuery")]
        public static bool IsQuery(uint QueryID){ throw new NotImplementedException(); }

        /// <summary>
        /// glBeginQuery and glEndQuery delimit the boundaries of a query object. query must be a name previously returned from a call to glGenQueries. If a query object with name id does not yet exist it is created with the type determined by target. target must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.
        /// Calling glBeginQuery or glEndQuery is equivalent to calling glBeginQueryIndexed or glEndQueryIndexed with index set to zero, respectively.
        /// </summary>
        /// <param name="target">Specifies the target type of query object established between glBeginQuery and the subsequent glEndQuery. The symbolic constant must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.</param>
        /// <param name="QueryID">Specifies the name of a query object.</param>
        [EntryPoint(FunctionName = "glBeginQuery")]
        public static void BeginQuery(QueryTarget target, uint QueryID){ throw new NotImplementedException(); }

        /// <summary>
        /// glBeginQuery and glEndQuery delimit the boundaries of a query object. query must be a name previously returned from a call to glGenQueries. If a query object with name id does not yet exist it is created with the type determined by target. target must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.
        /// Calling glBeginQuery or glEndQuery is equivalent to calling glBeginQueryIndexed or glEndQueryIndexed with index set to zero, respectively.
        /// </summary>
        /// <param name="target">Specifies the target type of query object to be concluded. The symbolic constant must be one of GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, or GL_TIME_ELAPSED.</param>
        [EntryPoint(FunctionName = "glEndQuery")]
        public static void EndQuery(QueryTarget target){ throw new NotImplementedException(); }

        /// <summary>
        /// glGetQueryiv returns in params a selected parameter of the query object target specified by target.
        /// Calling glGetQueryiv is equivalent to calling glGetQueryIndexediv with index set to zero.
        /// </summary>
        /// <param name="target">Specifies a query object target. Must be GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or GL_TIMESTAMP.</param>
        /// <param name="pname">Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or GL_QUERY_COUNTER_BITS.</param>
        /// <param name="result"></param>
        [EntryPoint(FunctionName = "glGetQueryiv")]
        unsafe public static void GetQueryiv(QueryTarget target, GetQueryParameters pname, int* result){ throw new NotImplementedException(); }
        //public static void GetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname, ref int @params){ throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryiv returns in params a selected parameter of the query object target specified by target.
        /// Calling glGetQueryiv is equivalent to calling glGetQueryIndexediv with index set to zero.
        /// </summary>
        /// <param name="target">Specifies a query object target. Must be GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or GL_TIMESTAMP.</param>
        /// <param name="pname">Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or GL_QUERY_COUNTER_BITS.</param>
        /// <param name="result"></param>
        [EntryPoint(FunctionName = "glGetQueryiv")]
        public static void GetQueryiv(QueryTarget target, GetQueryParameters pname, out int result) { throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryiv returns in params a selected parameter of the query object target specified by target.
        /// Calling glGetQueryiv is equivalent to calling glGetQueryIndexediv with index set to zero.
        /// </summary>
        /// <param name="target">Specifies a query object target. Must be GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or GL_TIMESTAMP.</param>
        /// <param name="pname">Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or GL_QUERY_COUNTER_BITS.</param>        
        [EntryPoint(FunctionName = "glGetQueryiv")]
        public static int GetQueryiv(QueryTarget target, GetQueryParameters pname) { throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryiv returns in params a selected parameter of the query object target specified by target.
        /// Calling glGetQueryiv is equivalent to calling glGetQueryIndexediv with index set to zero.
        /// </summary>
        /// <param name="target">Specifies a query object target. Must be GL_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED, GL_ANY_SAMPLES_PASSED_CONSERVATIVE GL_PRIMITIVES_GENERATED, GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN, GL_TIME_ELAPSED, or GL_TIMESTAMP.</param>
        /// <param name="pname">Specifies the symbolic name of a query object target parameter. Accepted values are GL_CURRENT_QUERY or GL_QUERY_COUNTER_BITS.</param>
        /// <param name="result"></param>
        [EntryPoint(FunctionName = "glGetQueryiv")]
        public static void GetQueryiv(QueryTarget target, GetQueryParameters pname, int[] result) { throw new NotImplementedException(); }

        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="QueryID">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <param name="result">If no buffer is bound to GL_QUERY_RESULT_BUFFER, then params is treated as an address in client memory of a variable to receive the resulting data.</param>
        /// <remarks>
        /// If an error is generated, no change is made to the contents of params.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater.
        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
        /// </remarks>        
        [EntryPoint(FunctionName = "glGetQueryObjectiv")]
        unsafe public static void GetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname, int* result){ throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="QueryID">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <param name="result">If no buffer is bound to GL_QUERY_RESULT_BUFFER, then params is treated as an address in client memory of a variable to receive the resulting data.</param>
        /// <remarks>
        /// If an error is generated, no change is made to the contents of params.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater.
        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
        /// </remarks>        
        [EntryPoint(FunctionName = "glGetQueryObjectiv")]
        public static void GetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname, int[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="QueryID">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <param name="result">If no buffer is bound to GL_QUERY_RESULT_BUFFER, then params is treated as an address in client memory of a variable to receive the resulting data.</param>
        /// <remarks>
        /// If an error is generated, no change is made to the contents of params.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater.
        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
        /// </remarks>        
        [EntryPoint(FunctionName = "glGetQueryObjectiv")]
        public static void GetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname, out int result) { throw new NotImplementedException(); }
        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="QueryID">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>        
        /// <remarks>
        /// If an error is generated, no change is made to the contents of params.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater.
        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
        /// </remarks>        
        /// <returns>If no buffer is bound to GL_QUERY_RESULT_BUFFER, then params is treated as an address in client memory of a variable to receive the resulting data.</returns>
        [EntryPoint(FunctionName = "glGetQueryObjectiv")]
        public static int GetQueryObjectiv(uint QueryID, GetQueryObjectParameters pname) { throw new NotImplementedException(); }

        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="QueryID">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <param name="result">If no buffer is bound to GL_QUERY_RESULT_BUFFER, then params is treated as an address in client memory of a variable to receive the resulting data.</param>
        /// <remarks>
        /// If an error is generated, no change is made to the contents of params.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater.
        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
        /// </remarks>        
        [EntryPoint(FunctionName = "glGetQueryObjectuiv")]
        unsafe public static void GetQueryObjectuiv(uint QueryID, GetQueryObjectParameters pname, uint* result){ throw new NotImplementedException(); }

        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="QueryID">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <param name="result">If no buffer is bound to GL_QUERY_RESULT_BUFFER, then params is treated as an address in client memory of a variable to receive the resulting data.</param>
        /// <remarks>
        /// If an error is generated, no change is made to the contents of params.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater.
        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
        /// </remarks>        
        [EntryPoint(FunctionName = "glGetQueryObjectuiv")]
        public static void GetQueryObjectuiv(uint QueryID, GetQueryObjectParameters pname, uint[] result) { throw new NotImplementedException(); }

        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="QueryID">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <returns></returns>
        /// <remarks>
        /// If an error is generated, no change is made to the contents of params.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater.
        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
        /// </remarks>        
        [EntryPoint(FunctionName = "glGetQueryObjectuiv")]
        public static void GetQueryObjectuiv(uint QueryID, GetQueryObjectParameters pname, out uint result) { throw new NotImplementedException(); }

        /// <summary>
        /// glGetQueryObject returns in params a selected parameter of the query object specified by id.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// </summary>
        /// <param name="QueryID">Specifies the name of a query object.</param>
        /// <param name="pname">Specifies the symbolic name of a query object parameter. Accepted values are GL_QUERY_RESULT or GL_QUERY_RESULT_AVAILABLE.</param>
        /// <returns></returns>
        /// <remarks>
        /// If an error is generated, no change is made to the contents of params.
        /// glGetQueryObject implicitly flushes the GL pipeline so that any incomplete rendering delimited by the occlusion query completes in finite time.
        /// If multiple queries are issued using the same query object id before calling glGetQueryObject, the results of the most recent query will be returned. In this case, when issuing a new query, the results of the previous query are discarded.
        /// glGetQueryObjecti64v and glGetQueryObjectui64v are available only if the GL version is 3.3 or greater.
        /// GL_QUERY_RESULT_NO_WAIT is accepted for pname only if the GL version is 4.4 or greater.
        /// The GL_QUERY_RESULT_BUFFER target is available only if the GL version is 4.4 or higher. On earlier versions of the GL, params is always an address in client memory.
        /// </remarks>        
        [EntryPoint(FunctionName = "glGetQueryObjectuiv")]
        public static uint GetQueryObjectuiv(uint QueryID, GetQueryObjectParameters pname) { throw new NotImplementedException(); }


        #endregion

        #region Public Helper Functions

        /// <summary>
        /// Delete a number of buffer ids.
        /// </summary>
        /// <param name="BufferIDs"></param>
        unsafe public static void DeleteBuffers(uint[] BufferIDs)
        {
            fixed(uint* ptr = &BufferIDs[0])
            {
                DeleteBuffers(BufferIDs.Length, ptr);
            }
        }

        /// <summary>
        /// Create a number of buffer ids.
        /// </summary>
        /// <param name="BufferIDs"></param>
        unsafe public static void GenBuffers(uint[] BufferIDs)
        {
            fixed(uint* ptr = &BufferIDs[0])
            {
                GenBuffers(BufferIDs.Length, ptr);
            }
        }

        /// <summary>
        /// Create/Allocate and upload buffer data.
        /// </summary>
        /// <param name="target">Buffertarget to upload/allocate to.</param>
        /// <param name="Size">Size in bytes of data to upload/allocate</param>
        /// <param name="Data">Pointer to the data to upload, or zero for allocate</param>
        /// <param name="usage">Give Opengl a hint of how your gonna use this buffer.</param>
        public static void BufferData(BufferTarget target, long Size, IntPtr Data, BufferUsage usage)
        {
            BufferData(target, (IntPtr)Size, Data, usage);
        }

        /// <summary>
        /// Uploads data into an existing buffer.
        /// </summary>
        /// <param name="target">Target to upload buffer data to.</param>
        /// <param name="Offset">Offset in buffer to start writing at.</param>
        /// <param name="Size">The size of buffer upload</param>
        /// <param name="data">The pointer to the data to upload.</param>
        public static void BufferSubData(BufferTarget target, long Offset, long Size, IntPtr data)
        {
            BufferSubData(target, (IntPtr)Offset, (IntPtr)Size, data);
        }
        public unsafe static void BufferSubData(BufferTarget target, long Offset, byte[] data)
        {
            BufferSubData(target, Offset, data, 0, data.Length);
        }
        public unsafe static void BufferSubData(BufferTarget target, long Offset, byte[] data, int index, int length)
        {
            var len = Math.Min(data.Length, index + length) - index;

            if(len > 0)
            {
                fixed(byte* ptr = &data[index])
                {
                    BufferSubData(target, (IntPtr)Offset, (IntPtr)len, (IntPtr)ptr);
                }
            }
        }

        public unsafe static void BufferSubData(BufferTarget target, long Offset, float[] data)
        {
            BufferSubData(target, Offset, data, 0, data.Length);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <param name="Offset">Offset in BYTES</param>
        /// <param name="data"></param>
        /// <param name="index">position in floats inside data array.</param>
        /// <param name="length">number of floats to upload</param>
        public unsafe static void BufferSubData(BufferTarget target, long Offset, float[] data, int index, int length)
        {
            var len = (Math.Min(data.Length, index + length) - index) * sizeof(float);

            if (len > 0)
            {
                fixed (float* ptr = &data[index])
                {
                    BufferSubData(target, (IntPtr)Offset, (IntPtr)len, (IntPtr)ptr);
                }
            }
        }
        public static void BufferSubData<TValueType>(BufferTarget target, long Offset, TValueType[] data) where TValueType : struct
        {
            BufferSubData<TValueType>(target, Offset, data, 0, data.Length);
        }
        public static void BufferSubData<TValueType>(BufferTarget target, long Offset, TValueType[] data, int index, int count) where TValueType : struct
        {
            var elementsize = Marshal.SizeOf(typeof(TValueType));

            var len = (Math.Min(data.Length, index + count) - index) * elementsize;

            if(len > 0)
            {
                GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);

                var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(data, index);

                BufferSubData(target, (IntPtr)Offset, (IntPtr)len, ptr);

                handle.Free();
            }
        }

        /// <summary>
        /// Generates an array of query objects
        /// </summary>
        /// <param name="QueryIDs"></param>
        public static void GenQueries(uint[] QueryIDs)
        {
            GenQueries(QueryIDs.Length, QueryIDs);
        }

        /// <summary>
        /// Delets an array of query objects
        /// </summary>
        /// <param name="QueryIDs"></param>
        public static void DeleteQueries(uint[] QueryIDs)
        {
            DeleteQueries(QueryIDs.Length, QueryIDs);
            //fixed(uint* ptr = &QueryIDs[0])
            //{
            //    DeleteQueries(QueryIDs.Length, ptr);
            //}
        }


        #endregion

    }
}
