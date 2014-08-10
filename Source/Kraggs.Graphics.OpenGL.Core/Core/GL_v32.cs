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

        //ARB_draw_elements_base_vertex
        [EntryPointSlot(235)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawElementsBaseVertex(BeginMode mode, int count, IndicesType type, IntPtr Indices, int BaseVertex);
        [EntryPointSlot(236)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawElementsInstancedBaseVertex(BeginMode mode, int count, IndicesType type, IntPtr Indices, int InstanceCount, int BaseVertex);
        [EntryPointSlot(237)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawRangeElementsBaseVertex(BeginMode mode, uint start, uint end, int count, IndicesType type, IntPtr Indices, int BaseVertex);
        [EntryPointSlot(238)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glMultiDrawElementsBaseVertex(BeginMode mode, int* Count, IndicesType type, IntPtr Indices, int drawCount, int* BaseVertex);
        //ARB_provoking_vertex
        [EntryPointSlot(239)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProvokingVertex(ProvokeVertexMode mode);

        //ARB_sync
        [EntryPointSlot(240)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDeleteSync(IntPtr Sync);
        [EntryPointSlot(241)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern IntPtr glFenceSync(SyncCondition condition, int flagsZero);
        [EntryPointSlot(242)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsSync(IntPtr Sync);
        [EntryPointSlot(243)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetSynciv(IntPtr Sync, SyncParameters pname, int bufSize, out int Length, int* values);

        [EntryPointSlot(244)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern ClientWaitSyncStatus glClientWaitSync(IntPtr Sync, SyncFlags flags, ulong timeout_ns);
        [EntryPointSlot(245)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glWaitSync(IntPtr Sync, SyncFlags flags, ulong timeout);

        [EntryPointSlot(246)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetInteger64v(GetParameters pname, long* result);
        [EntryPointSlot(247)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetInteger64i_v(GetParameters pname, uint index, long* result);
        [EntryPointSlot(248)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetBufferParameteri64v(GetParameters pname, long* result);

        //ARB_texture_multisample
        [EntryPointSlot(249)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetMultisamplefv(MultisampleParameters pname, uint index, float* val);
        [EntryPointSlot(250)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glSampleMaski(uint MaskNumber, uint mask);
        [EntryPointSlot(251)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTexImage2DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations);
        [EntryPointSlot(252)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTexImage3DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations);

        //ARB_geometry_shader4
        [EntryPointSlot(253)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferTexture(FramebufferTarget target, FramebufferAttachmentType attachment, uint TextureID, int level);
        [EntryPointSlot(254)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachmentType attachment, uint TextureID, int level, int layer);

        #endregion

        #region Public functions

        //[EntryPoint(FunctionName = "gl")]
        //public static void BindTexture(TextureTarget target, uint textureid) { throw new NotImplementedException(); }

        //ARB_draw_elements_base_vertex        
        /// <summary>
        /// DrawElementsBaseVertex behaves identically to DrawElements except that the ith element transferred by the corresponding draw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting value is larger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned integers (with wrapping on overflow conditions). The operation is undefined if the sum would be negative.
        /// </summary>
        /// <param name="mode">Primitive mode</param>
        /// <param name="count">Number of primitive types to render.</param>
        /// <param name="type">Element/Indices type.</param>
        /// <param name="Offset">Offset into current element/indices buffer bound to retive element/indices from.</param>
        /// <param name="BaseVertex">Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.</param>
        [EntryPoint(FunctionName = "glDrawElementsBaseVertex")]
        public static void DrawElementsBaseVertex(BeginMode mode, int count, IndicesType type, IntPtr Indices, int BaseVertex) { throw new NotImplementedException(); }

        /// <summary>
        /// DrawElementsBaseVertex behaves identically to DrawElements except that the ith element transferred by the corresponding draw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting value is larger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned integers (with wrapping on overflow conditions). The operation is undefined if the sum would be negative.
        /// </summary>
        /// <param name="mode">Primitive mode</param>
        /// <param name="count">Number of primitive types to render.</param>
        /// <param name="type">Element/Indices type.</param>
        /// <param name="Offset">Offset into current element/indices buffer bound to retive element/indices from.</param>
        /// <param name="BaseVertex">Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.</param>
        public static void DrawElementsBaseVertex(BeginMode mode, int count, IndicesType type, long IndiceOffset, int BaseVertex)
        {
            DrawElementsBaseVertex(mode, count, type, (IntPtr)IndiceOffset, BaseVertex);
        }

        /// <summary>
        /// DrawElementsInstancedBaseVertex behaves identically to DrawElementsInstanced except that the ith element transferred by the corresponding draw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting value is larger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned integers (with wrapping on overflow conditions). The operation is undefined if the sum would be negative.
        /// </summary>
        /// <param name="mode">Primitive mode</param>
        /// <param name="count">Number of primitive types to render.</param>
        /// <param name="type">Element/Indices type.</param>
        /// <param name="Offset">Offset into current element/indices buffer bound to retive element/indices from.</param>
        /// <param name="InstanceCount">Number of instances to render.</param>
        /// <param name="BaseVertex">Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.</param>
        [EntryPoint(FunctionName = "glDrawElementsInstancedBaseVertex")]
        public static void DrawElementsInstancedBaseVertex(BeginMode mode, int count, IndicesType type, IntPtr Indices, int InstanceCount, int BaseVertex) { throw new NotImplementedException(); }

        /// <summary>
        /// DrawElementsInstancedBaseVertex behaves identically to DrawElementsInstanced except that the ith element transferred by the corresponding draw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting value is larger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned integers (with wrapping on overflow conditions). The operation is undefined if the sum would be negative.
        /// </summary>
        /// <param name="mode">Primitive mode</param>
        /// <param name="count">Number of primitive types to render.</param>
        /// <param name="type">Element/Indices type.</param>
        /// <param name="IndiceOffset">Offset into current element/indices buffer bound to retive element/indices from.</param>
        /// <param name="InstanceCount">Number of instances to render.</param>
        /// <param name="BaseVertex">Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.</param>        
        public static void DrawElementsInstancedBaseVertex(BeginMode mode, int count, IndicesType type, long IndiceOffset, int InstanceCount, int BaseVertex)
        {
            DrawElementsInstancedBaseVertex(mode, count, type, (IntPtr)IndiceOffset, InstanceCount, BaseVertex);
        }

        /// <summary>
        /// glDrawRangeElementsBaseVertex is a restricted form of glDrawElementsBaseVertex. mode, start, end, count and basevertex match the corresponding arguments to glDrawElementsBaseVertex, with the additional constraint that all values in the array indices must lie between start and end, inclusive, prior to adding basevertex. Index values lying outside the range [start, end] are treated in the same way as glDrawElementsBaseVertex. The ith element transferred by the corresponding draw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting value is larger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned integers (with wrapping on overflow conditions). The operation is undefined if the sum would be negative.
        /// </summary>
        /// <param name="mode">Primitive mode</param>
        /// <param name="start">Specifies the minimum array index contained in indices.</param>
        /// <param name="end">Specifies the maximum array index contained in indices.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">Element/Indices type.</param>
        /// <param name="Offset">Offset into current element/indices buffer bound to retive element/indices from.</param>
        /// <param name="BaseVertex">Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.</param>
        [EntryPoint(FunctionName = "glDrawRangeElementsBaseVertex")]
        public static void DrawRangeElementsBaseVertex(BeginMode mode, uint start, uint end, int count, IndicesType type, IntPtr Indices, int BaseVertex) { throw new NotImplementedException(); }

        /// <summary>
        /// glDrawRangeElementsBaseVertex is a restricted form of glDrawElementsBaseVertex. mode, start, end, count and basevertex match the corresponding arguments to glDrawElementsBaseVertex, with the additional constraint that all values in the array indices must lie between start and end, inclusive, prior to adding basevertex. Index values lying outside the range [start, end] are treated in the same way as glDrawElementsBaseVertex. The ith element transferred by the corresponding draw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting value is larger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned integers (with wrapping on overflow conditions). The operation is undefined if the sum would be negative.
        /// </summary>
        /// <param name="mode">Primitive mode</param>
        /// <param name="start">Specifies the minimum array index contained in indices.</param>
        /// <param name="end">Specifies the maximum array index contained in indices.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">Element/Indices type.</param>
        /// <param name="IndiceOffset">Offset into current element/indices buffer bound to retive element/indices from.</param>
        /// <param name="BaseVertex">Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.</param>        
        public static void DrawRangeElementsBaseVertex(BeginMode mode, uint start, uint end, int count, IndicesType type, long IndiceOffset, int BaseVertex)
        {
            DrawRangeElementsBaseVertex(mode, start, end, count, type, IndiceOffset, BaseVertex);
        }


        [EntryPoint(FunctionName = "glMultiDrawElementsBaseVertex")]
        unsafe public static void MultiDrawElementsBaseVertex(BeginMode mode, int* Count, IndicesType type, IntPtr Indices, int drawCount, int* BaseVertex) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glMultiDrawElementsBaseVertex")]
        public static void MultiDrawElementsBaseVertex(BeginMode mode, ref int Count, IndicesType type, IntPtr Indices, int drawCount, ref int BaseVertex) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glMultiDrawElementsBaseVertex")]
        public static void MultiDrawElementsBaseVertex<T3>(BeginMode mode, ref int Count, IndicesType type, ref T3 Indices, int drawCount, ref int BaseVertex) where T3 : struct { throw new NotImplementedException(); }

        //ARB_provoking_vertex
        /// <summary>
        /// Sets the provking vertex mode.
        /// </summary>
        /// <param name="mode"></param>
        [EntryPoint(FunctionName = "glProvokingVertex")]
        public static void ProvokingVertex(ProvokeVertexMode mode) { throw new NotImplementedException(); }

        //ARB_sync
        /// <summary>
        /// Deletes a sync object.
        /// </summary>
        /// <param name="Sync">Sync pointer to delete.</param>
        [EntryPoint(FunctionName = "glDeleteSync")]
        public static void DeleteSync(IntPtr Sync) { throw new NotImplementedException(); }

        /// <summary>
        /// glFenceSync creates a new fence sync object, inserts a fence command into the GL command stream and associates it with that sync object, and returns a non-zero name corresponding to the sync object.
        /// </summary>
        /// <param name="condition">Specifies the condition that must be met to set the sync object's state to signaled. condition must be GL_SYNC_GPU_COMMANDS_COMPLETE.</param>
        /// <param name="flagsZero">Specifies a bitwise combination of flags controlling the behavior of the sync object. No flags are presently defined for this operation and flags must be zero.</param>
        /// <returns>New Sync Object</returns>
        /// <remarks>
        /// glFenceSync creates a new fence sync object, inserts a fence command into the GL command stream and associates it with that sync object, and returns a non-zero name corresponding to the sync object.
        /// When the specified condition of the sync object is satisfied by the fence command, the sync object is signaled by the GL, causing any glWaitSync, glClientWaitSync commands blocking in sync to unblock. No other state is affected by glFenceSync or by the execution of the associated fence command.
        /// condition must be GL_SYNC_GPU_COMMANDS_COMPLETE. This condition is satisfied by completion of the fence command corresponding to the sync object and all preceding commands in the same command stream. The sync object will not be signaled until all effects from these commands on GL client and server state and the framebuffer are fully realized. Note that completion of the fence command occurs once the state of the corresponding sync object has been changed, but commands waiting on that sync object may not be unblocked until after the fence command completes.
        /// </remarks>
        [EntryPoint(FunctionName = "glFenceSync")]
        public static IntPtr FenceSync(SyncCondition condition, int flagsZero) { throw new NotImplementedException(); }

        /// <summary>
        /// IS this pointer a sync object?
        /// </summary>
        /// <param name="Sync"></param>
        /// <returns></returns>
        [EntryPoint(FunctionName = "glIsSync")]
        public static bool IsSync(IntPtr Sync) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glGetSynciv")]
        unsafe public static void GetSynciv(IntPtr Sync, SyncParameters pname, int bufSize, out int Length, int* values) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetSynciv")]
        public static void GetSynciv(IntPtr Sync, SyncParameters pname, int bufSize, out int Length, int[] values) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetSynciv")]
        public static void GetSynciv(IntPtr Sync, SyncParameters pname, int bufSize, out int Length, ref int values) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives sync properties into preallocated array of size.
        /// </summary>
        /// <param name="Sync">Sync object to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="values">Prealloceted array with enough space to store result of query.</param>
        /// <returns>Number of properties available.</returns>
        public static int GetSynciv(IntPtr Sync, SyncParameters pname, int[] values)
        {
            //int bufSize, out int Length
            int len = 0;
            GetSynciv(Sync, pname, values.Length, out len, ref values[0]);
            return len;
        }

        /// <summary>
        /// block and wait for a sync object to become signaled
        /// </summary>
        /// <param name="Sync">The sync object whose status to wait on.</param>
        /// <param name="flags">A bitfield controlling the command flushing behavior. flags may be GL_SYNC_FLUSH_COMMANDS_BIT.</param>
        /// <param name="timeout_ns">The timeout, specified in nanoseconds, for which the implementation should wait for sync to become signaled.</param>
        /// <returns>
        /// <list type="bullet">
        ///   <listheader>The return value is one of four status values:</listheader>
        ///   <item>GL_ALREADY_SIGNALED indicates that sync was signaled at the time that glClientWaitSync was called.</item>
        ///   <item>GL_TIMEOUT_EXPIRED indicates that at least timeout nanoseconds passed and sync did not become signaled.</item>
        ///   <item>GL_CONDITION_SATISFIED indicates that sync was signaled before the timeout expired.</item>
        ///   <item>GL_WAIT_FAILED indicates that an error occurred. Additionally, an OpenGL error will be generated.</item>
        /// </list>
        /// </returns>
        /// <remarks>
        [EntryPoint(FunctionName = "glClientWaitSync")]
        public static ClientWaitSyncStatus ClientWaitSync(IntPtr Sync, SyncFlags flags, ulong timeout_ns){ throw new NotImplementedException(); }

        /// <summary>
        /// instruct the GL server to block until the specified sync object becomes signaled
        /// </summary>
        /// <param name="Sync">Specifies the sync object whose status to wait on.</param>
        /// <param name="flags">A bitfield controlling the command flushing behavior. flags may be zero.</param>
        /// <param name="timeout">Specifies the timeout that the server should wait before continuing. timeout must be GL_TIMEOUT_IGNORED.</param>
        /// <remarks>
        /// glWaitSync causes the GL server to block and wait until sync becomes signaled. sync is the name of an existing sync object upon which to wait. flags and timeout are currently not used and must be set to zero and the special value GL_TIMEOUT_IGNORED, respectively[1]. glWaitSync will always wait no longer than an implementation-dependent timeout. The duration of this timeout in nanoseconds may be queried by calling glGet with the parameter GL_MAX_SERVER_WAIT_TIMEOUT. There is currently no way to determine whether glWaitSync unblocked because the timeout expired or because the sync object being waited on was signaled.
        /// If an error occurs, glWaitSync does not cause the GL server to block.
        /// </remarks>
        [EntryPoint(FunctionName = "glWaitSync")]
        public static void WaitSync(IntPtr Sync, SyncFlags flags = SyncFlags.Zero, ulong timeout = TIMEOUT_IGNORED){ throw new NotImplementedException(); }


        /// <summary>
        /// Retrives an possible array long sized parameter value.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">Preallocated array to write result into.</param>
        [EntryPoint(FunctionName = "glGetInteger64v")]
        unsafe public static void GetInteger64v(GetParameters pname, long* result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives an possible array long sized parameter value.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">Preallocated array to write result into.</param>
        [EntryPoint(FunctionName = "glGetInteger64v")]
        public static void GetInteger64v(GetParameters pname, long[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a single long sized parameter value.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">Preallocated array to write result into.</param>
        [EntryPoint(FunctionName = "glGetInteger64v")]
        public static void GetInteger64v(GetParameters pname, ref long result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a single long sized parameter value.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <returns>result.</returns>
        [EntryPoint(FunctionName = "glGetInteger64v")]
        public static long GetInteger64v(GetParameters pname) { throw new NotImplementedException(); }

        /// <summary>
        /// Retrives a possible array long sized parameters from an indexed target.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning of index is dependent on Paramenter Name.</param>
        /// <param name="params">Preallocated long array to write result of sufficient size.</param>
        [EntryPoint(FunctionName = "glGetInteger64i_v")]
        unsafe public static void GetInteger64i_v(GetParameters pname, uint index, long* result){ throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a possible array long sized parameters from an indexed target.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning of index is dependent on Paramenter Name.</param>
        /// <param name="params">Preallocated long array to write result of sufficient size.</param>
        [EntryPoint(FunctionName = "glGetInteger64i_v")]
        public static void GetInteger64i_v(GetParameters pname, uint index, long[] result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a single long sized parameter value from an indexed target.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning of index is dependent on Paramenter Name.</param>
        /// <param name="params">result.</param>
        [EntryPoint(FunctionName = "glGetInteger64i_v")]
        public static void GetInteger64i_v(GetParameters pname, uint index, ref long result) { throw new NotImplementedException(); }
        /// <summary>
        /// Retrives a single long sized parameter value from an indexed target.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning of index is dependant on parameter name.</param>
        /// <returns>result.</returns>
        [EntryPoint(FunctionName = "glGetInteger64i_v")]
        public static long GetInteger64i_v(GetParameters pname, uint index) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetBufferParameteri64v")]
        unsafe public static void GetBufferParameteri64v(GetParameters pname, long* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetBufferParameteri64v")]
        public static void GetBufferParameteri64v(GetParameters pname, long[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetBufferParameteri64v")]
        public static void GetBufferParameteri64v(GetParameters pname, ref long result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetBufferParameteri64v")]
        public static long GetBufferParameteri64v(GetParameters pname) { throw new NotImplementedException(); }

        //ARB_texture_multisample

        /// <summary>
        /// retrieve the location of a sample (on multisample framebuffers)
        /// If the multisample mode does not have fixed sample locations, the returned values may only reflect the locations of samples within some pixels.
        /// </summary>
        /// <param name="pname">Specifies the sample parameter name. pname must be GL_SAMPLE_POSITION.</param>
        /// <param name="index">index must be between zero and the value of GL_SAMPLES - 1.</param>
        /// <param name="val">The sample location is returned as two floating-point values in val[0] and val[1], each between 0 and 1, corresponding to the x and y locations respectively in the GL pixel space of that sample. (0.5, 0.5) this corresponds to the pixel center.</param>
        [EntryPoint(FunctionName = "glGetMultisamplefv")]
        unsafe public static void GetMultisamplefv(MultisampleParameters pname, uint index, float* val){ throw new NotImplementedException(); }
        /// <summary>
        /// retrieve the location of a sample (on multisample framebuffers)
        /// If the multisample mode does not have fixed sample locations, the returned values may only reflect the locations of samples within some pixels.
        /// </summary>
        /// <param name="pname">Specifies the sample parameter name. pname must be GL_SAMPLE_POSITION.</param>
        /// <param name="index">index must be between zero and the value of GL_SAMPLES - 1.</param>
        /// <param name="val">The sample location is returned as two floating-point values in val[0] and val[1], each between 0 and 1, corresponding to the x and y locations respectively in the GL pixel space of that sample. (0.5, 0.5) this corresponds to the pixel center.</param>
        [EntryPoint(FunctionName = "glGetMultisamplefv")]
        public static void GetMultisamplefv(MultisampleParameters pname, uint index, float[] val) { throw new NotImplementedException(); }
        /// <summary>
        /// retrieve the location of a sample (on multisample framebuffers)
        /// If the multisample mode does not have fixed sample locations, the returned values may only reflect the locations of samples within some pixels.
        /// </summary>
        /// <param name="pname">Specifies the sample parameter name. pname must be GL_SAMPLE_POSITION.</param>
        /// <param name="index">index must be between zero and the value of GL_SAMPLES - 1.</param>
        /// <param name="val">The sample location is returned as two floating-point values in val[0] and val[1], each between 0 and 1, corresponding to the x and y locations respectively in the GL pixel space of that sample. (0.5, 0.5) this corresponds to the pixel center.</param>
        [EntryPoint(FunctionName = "glGetMultisamplefv")]
        public static void GetMultisamplefv(MultisampleParameters pname, uint index, ref float val) { throw new NotImplementedException(); }

        /// <summary>
        /// set the value of a sub-word of the sample mask
        /// </summary>
        /// <param name="MaskNumber">Specifies which 32-bit sub-word of the sample mask to update.</param>
        /// <param name="mask">Specifies the new value of the mask sub-word.</param>
        /// <remarks>
        /// glSampleMaski sets one 32-bit sub-word of the multi-word sample mask, GL_SAMPLE_MASK_VALUE.
        /// maskIndex specifies which 32-bit sub-word of the sample mask to update, and mask specifies the new value to use for that sub-word. maskIndex must be less than the value of GL_MAX_SAMPLE_MASK_WORDS. Bit B of mask word M corresponds to sample 32 x M + B.
        /// glSampleMaski is available only if the GL version is 3.2 or greater, or if the ARB_texture_multisample extension is supported.
        /// </remarks>
        [EntryPoint(FunctionName = "glSampleMaski")]
        public static void SampleMaski(uint MaskNumber, uint mask){ throw new NotImplementedException(); }

        /// <summary>
        /// Allocates a multisample texture. Multisample texture can't have mipmaps.
        /// </summary>
        /// <param name="target">Texture target with currently bound texture id to create multisample storage for.</param>
        /// <param name="samples">Number of samples to use.</param>
        /// <param name="piformat">Format of multisample texture.</param>
        /// <param name="width">Width</param>
        /// <param name="height">Height</param>
        /// <param name="fixedSampleLocations">Use fixed sample locations?</param>
        [EntryPoint(FunctionName = "glTexImage2DMultisample")]
        public static void TexImage2DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations){ throw new NotImplementedException(); }

        /// <summary>
        /// Allocates a multisample texture. Multisample texture can't have mipmaps.
        /// </summary>
        /// <param name="target">Texture target with currently bound texture id to create multisample storage for.</param>
        /// <param name="samples">Number of samples to use.</param>
        /// <param name="piformat">Format of multisample texture.</param>
        /// <param name="width">Width</param>
        /// <param name="height">Height</param>
        /// <param name="depth">Depth</param>
        /// <param name="fixedSampleLocations">Use fixed sample locations?</param>
        [EntryPoint(FunctionName = "glTexImage3DMultisample")]
        public static void TexImage3DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations){ throw new NotImplementedException(); }

        //ARB_geometry_shader4
        /// <summary>
        /// Attaches a texture mipmap level to specified attachment point on framebuffer current bound to specified target.
        /// Simplified version of FrameBufferTexture1D,FrameBufferTexture2D,FrameBufferTexture3D.
        /// </summary>
        /// <param name="target">Framebuffer target with bound framebuffer to attach to.</param>
        /// <param name="attachment">Attachment point on framebuffer to attach to.</param>
        /// <param name="TextureID">Texture id to attach.</param>
        /// <param name="level">Texture Mipmap level to attach.</param>
        /// <remarks>
        /// glFramebufferTexture, glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture attach a selected mipmap level or image of a texture object as one of the logical buffers of the framebuffer object currently bound to target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER.
        /// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT. i in GL_COLOR_ATTACHMENTi may range from zero to the value of GL_MAX_COLOR_ATTACHMENTS - 1. Attaching a level of a texture to GL_DEPTH_STENCIL_ATTACHMENT is equivalent to attaching that level to both the GL_DEPTH_ATTACHMENT and the GL_STENCIL_ATTACHMENT attachment points simultaneously.
        /// textarget specifies what type of texture is named by texture, and for cube map textures, specifies the face that is to be attached. If texture is not zero, it must be the name of an existing texture with type textarget, unless it is a cube map texture, in which case textarget must be GL_TEXTURE_CUBE_MAP_POSITIVE_X GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// If texture is non-zero, the specified level of the texture object named texture is attached to the framebfufer attachment point named by attachment. For glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture3D, texture must be zero or the name of an existing texture with a target of textarget, or texture must be the name of an existing cube-map texture and textarget must be one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// If textarget is GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY, then level must be zero. If textarget is GL_TEXTURE_3D, then level must be greater than or equal to zero and less than or equal to log2 of the value of GL_MAX_3D_TEXTURE_SIZE. If textarget is one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, then level must be greater than or equal to zero and less than or equal to log2 of the value of GL_MAX_CUBE_MAP_TEXTURE_SIZE. For all other values of textarget, level must be greater than or equal to zero and no larger than log2 of the value of GL_MAX_TEXTURE_SIZE.
        /// layer specifies the layer of a 2-dimensional image within a 3-dimensional texture.
        /// For glFramebufferTexture1D, if texture is not zero, then textarget must be GL_TEXTURE_1D. For glFramebufferTexture2D, if texture is not zero, textarget must be one of GL_TEXTURE_2D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_2D_MULTISAMPLE. For glFramebufferTexture3D, if texture is not zero, then textarget must be GL_TEXTURE_3D.
        /// </remarks>
        [EntryPoint(FunctionName = "glFramebufferTexture")]
        public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachmentType attachment, uint TextureID, int level = 0){ throw new NotImplementedException(); }

        /// <summary>
        /// glFramebufferTextureLayer operates like glFramebufferTexture, except that only a single layer of the texture level, given by layer, is attached to the attachment point
        /// Attaches a single texture layers mipmap to a specifed attachment point on framebuffer currently bound to specified target.
        /// </summary>
        /// <param name="fboTarget">Framebuffer target with bound framebuffer to attach to.</param>
        /// <param name="attachment">Attachment point on framebuffer to attach to.</param>
        /// <param name="TextureID">Specifies the texture object to attach to the framebuffer attachment point named by attachment.</param>
        /// <param name="level">Specifies the mipmap level of texture to attach.</param>
        /// <param name="Layer">Specifies the layer of texture to attach.</param>
        /// <remarks>
        /// glFramebufferTextureLayer operates like glFramebufferTexture, except that only a single layer of the texture level, given by layer, is attached to the attachment point. If texture is not zero, layer must be greater than or equal to zero. texture must either be zero or the name of an existing three-dimensional texture, one- or two-dimensional array texture, or multisample array texture.
        /// </remarks>
        [EntryPoint(FunctionName = "glFramebufferTextureLayer")]
        public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachmentType attachment, uint TextureID, int level = 0, int layer = 0){ throw new NotImplementedException(); }

        #endregion

        #region Public Helper Functions

        #endregion

    }
}
