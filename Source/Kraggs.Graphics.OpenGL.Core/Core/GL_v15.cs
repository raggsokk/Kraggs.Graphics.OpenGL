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
        /// Delete a number of buffers.
        /// </summary>
        /// <param name="BufferIDs">array of buffers to delete.</param>
        [EntryPoint(FunctionName = "glDeleteBuffers")]
        public static void DeleteBuffers(int number, ref uint BufferIDs) { throw new NotImplementedException(); }
        /// <summary>
        /// Delete a number of buffer ids.
        /// </summary>
        /// <param name="BufferIDs"></param>
        public static void DeleteBuffers(uint[] BufferIDs)
        {
            DeleteBuffers(BufferIDs.Length, ref BufferIDs[0]);
        }
        /// <summary>
        /// Delete a number of buffer ids.
        /// </summary>
        /// <param name="BufferIDs"></param>
        public static void DeleteBuffers(uint BufferIDs)
        {
            DeleteBuffers(1, ref BufferIDs);
        }

        /// <summary>
        /// Create a number of buffer ids.
        /// </summary>
        /// <param name="number">size of array</param>
        /// <param name="BufferIDs"></param>
        [EntryPoint(FunctionName = "glGenBuffers")]
        unsafe public static void GenBuffers(int number, uint* BufferIDs){ throw new NotImplementedException(); }
        /// <summary>
        /// Create a number of buffer ids.
        /// </summary>
        /// <param name="number">size of array</param>
        /// <param name="BufferIDs"></param>
        [EntryPoint(FunctionName = "glGenBuffers")]
        public static void GenBuffers(int number, ref uint BufferIDs) { throw new NotImplementedException(); }
        /// <summary>
        /// Create a number of buffer ids.
        /// </summary>
        /// <param name="number">size of array</param>
        public static uint[] GenBuffers(int number)
        {
            var bufs = new uint[number];
            GenBuffers(bufs.Length, ref bufs[0]);
            return bufs;
        }

        /// <summary>
        /// Create a single buffer id.
        /// </summary>        
        public static uint GenBuffers()
        {
            uint buf = 0;
            GenBuffers(1, ref buf);
            return buf;
        }

        /// <summary>
        /// Create a number of buffer ids.
        /// </summary>
        /// <param name="BufferIDs"></param>
        public static void GenBuffers(uint[] BufferIDs)
        {
            GenBuffers(BufferIDs.Length, ref BufferIDs[0]);
        }

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
        /// Create/Allocate and upload buffer data.
        /// </summary>
        /// <param name="target">Buffertarget to upload/allocate to.</param>
        /// <param name="usage">Give Opengl a hint of how your gonna use this buffer.</param>
        /// <param name="data">data to upload</param>
        /// <param name="index">index in data to upload at, default at start.</param>
        /// <param name="count">number of elements to upload, starting at index. default is data.length</param>
        unsafe public static void BufferData(BufferTarget target, BufferUsage usage, byte[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count);

            fixed(byte* ptr = &data[index])
            {
                BufferData(target, (IntPtr)count, (IntPtr)ptr, usage);
            }
        }
        /// <summary>
        /// Create/Allocate and upload buffer data.
        /// </summary>
        /// <param name="target">Buffertarget to upload/allocate to.</param>
        /// <param name="usage">Give Opengl a hint of how your gonna use this buffer.</param>
        /// <param name="data">data to upload</param>
        /// <param name="index">index in data to upload at, default at start.</param>
        /// <param name="count">number of elements to upload, starting at index. default is data.length</param>
        unsafe public static void BufferData(BufferTarget target, BufferUsage usage, ushort[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count) * sizeof(ushort);

            fixed (ushort* ptr = &data[index])
            {
                BufferData(target, (IntPtr)count, (IntPtr)ptr, usage);
            }
        }
        /// <summary>
        /// Create/Allocate and upload buffer data.
        /// </summary>
        /// <param name="target">Buffertarget to upload/allocate to.</param>
        /// <param name="usage">Give Opengl a hint of how your gonna use this buffer.</param>
        /// <param name="data">data to upload</param>
        /// <param name="index">index in data to upload at, default at start.</param>
        /// <param name="count">number of elements to upload, starting at index. default is data.length</param>
        unsafe public static void BufferData(BufferTarget target, BufferUsage usage, uint[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count) * sizeof(uint);

            fixed (uint* ptr = &data[index])
            {
                BufferData(target, (IntPtr)count, (IntPtr)ptr, usage);
            }
        }
        /// <summary>
        /// Create/Allocate and upload buffer data.
        /// </summary>
        /// <param name="target">Buffertarget to upload/allocate to.</param>
        /// <param name="usage">Give Opengl a hint of how your gonna use this buffer.</param>
        /// <param name="data">data to upload</param>
        /// <param name="index">index in data to upload at, default at start.</param>
        /// <param name="count">number of elements to upload, starting at index. default is data.length</param>
        unsafe public static void BufferData(BufferTarget target, BufferUsage usage, float[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count) * sizeof(float);

            fixed (float* ptr = &data[index])
            {
                BufferData(target, (IntPtr)count, (IntPtr)ptr, usage);
            }
        }

        /// <summary>
        /// Create/Allocate and upload buffer data.
        /// </summary>
        /// <typeparam name="TValueType">struct data type</typeparam>
        /// <param name="target">Buffertarget to upload/allocate to.</param>
        /// <param name="usage">Give Opengl a hint of how your gonna use this buffer.</param>
        /// <param name="data">data to upload</param>
        /// <param name="index">index in data to upload at, default at start.</param>
        /// <param name="count">number of elements to upload, starting at index. default is data.length</param>
        public static void BufferData<TValueType>(BufferTarget target, BufferUsage usage, TValueType[] data, int index = 0, int count = -1) where TValueType : struct
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count) * Marshal.SizeOf(typeof(TValueType));

            if (count > 0)
            {
                GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);

                var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(data, index);

                BufferData(target, (IntPtr)count, ptr, usage);

                handle.Free();
            }

        }

        /// <summary>
        /// Upload data into an existing buffer.
        /// </summary>
        /// <param name="target">Target to upload buffer data to.</param>
        /// <param name="Offset">Offset in buffer to start writing at.</param>
        /// <param name="Size">The size of buffer upload</param>
        /// <param name="data">The pointer to the data to upload.</param>
        /// <remarks>
        /// If the target of the operation is sparse and the range specified by <offset> and<size> includes uncommited regions, data destined for those regions is silently discarded.
        /// </remarks>
        [EntryPoint(FunctionName = "glBufferSubData")]
        public static void BufferSubData(BufferTarget target, IntPtr Offset, IntPtr Size, IntPtr data){ throw new NotImplementedException(); }

        /// <summary>
        /// Uploads data into an existing buffer.
        /// </summary>
        /// <param name="target">Target to upload buffer data to.</param>
        /// <param name="Offset">Offset in buffer to start writing at.</param>
        /// <param name="Size">The size of buffer upload</param>
        /// <param name="data">The pointer to the data to upload.</param>
        /// <remarks>
        /// If the target of the operation is sparse and the range specified by <offset> and<size> includes uncommited regions, data destined for those regions is silently discarded.
        /// </remarks>
        public static void BufferSubData(BufferTarget target, long Offset, long Size, IntPtr data)
        {
            BufferSubData(target, (IntPtr)Offset, (IntPtr)Size, data);
        }

        /// <summary>
        /// Uploads data into an existing buffer.
        /// </summary>
        /// <param name="target">Target to upload buffer data to.</param>
        /// <param name="Offset">Offset in buffer to start writing at.</param>
        /// <param name="data">data to upload</param>
        /// <param name="index">index in data to upload at, default at start.</param>
        /// <param name="count">number of elements to upload, starting at index. default is data.length</param>
        /// <remarks>
        /// If the target of the operation is sparse and the range specified by <offset> and<size> includes uncommited regions, data destined for those regions is silently discarded.
        /// </remarks>
        public unsafe static void BufferSubData(BufferTarget target, long Offset, byte[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count) * sizeof(byte);

            fixed(byte* ptr = &data[index])
            {
                BufferSubData(target, (IntPtr)Offset, (IntPtr)count, (IntPtr)ptr);
            }
        }

        /// <summary>
        /// Uploads data into an existing buffer.
        /// </summary>
        /// <param name="target">Target to upload buffer data to.</param>
        /// <param name="Offset">Offset in buffer to start writing at.</param>
        /// <param name="data">data to upload</param>
        /// <param name="index">index in data to upload at, default at start.</param>
        /// <param name="count">number of elements to upload, starting at index. default is data.length</param>
        public unsafe static void BufferSubData(BufferTarget target, long Offset, ushort[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count) * sizeof(ushort);

            fixed (ushort* ptr = &data[index])
            {
                BufferSubData(target, (IntPtr)Offset, (IntPtr)count, (IntPtr)ptr);
            }
        }
        /// <summary>
        /// Uploads data into an existing buffer.
        /// </summary>
        /// <param name="target">Target to upload buffer data to.</param>
        /// <param name="Offset">Offset in buffer to start writing at.</param>
        /// <param name="data">data to upload</param>
        /// <param name="index">index in data to upload at, default at start.</param>
        /// <param name="count">number of elements to upload, starting at index. default is data.length</param>
        public unsafe static void BufferSubData(BufferTarget target, long Offset, uint[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count) * sizeof(uint);

            fixed (uint* ptr = &data[index])
            {
                BufferSubData(target, (IntPtr)Offset, (IntPtr)count, (IntPtr)ptr);
            }
        }
        /// <summary>
        /// Uploads data into an existing buffer.
        /// </summary>
        /// <param name="target">Target to upload buffer data to.</param>
        /// <param name="Offset">Offset in buffer to start writing at.</param>
        /// <param name="data">data to upload</param>
        /// <param name="index">index in data to upload at, default at start.</param>
        /// <param name="count">number of elements to upload, starting at index. default is data.length</param>
        public unsafe static void BufferSubData(BufferTarget target, long Offset, float[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count) * sizeof(float);

            fixed (float* ptr = &data[index])
            {
                BufferSubData(target, (IntPtr)Offset, (IntPtr)count, (IntPtr)ptr);
            }
        }

        /// <summary>
        /// Uploads data into an existing buffer.
        /// </summary>
        /// <typeparam name="TValueType">struct data type</typeparam>
        /// <param name="target">Target to upload buffer data to.</param>
        /// <param name="Offset">Offset in buffer to start writing at.</param>
        /// <param name="data">data to upload</param>
        /// <param name="index">index in data to upload at, default at start.</param>
        /// <param name="count">number of elements to upload, starting at index. default is data.length</param>
        public unsafe static void BufferSubData<TValueType>(BufferTarget target, long Offset, TValueType[] data, int index = 0, int count = -1) where TValueType : struct
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count) * Marshal.SizeOf(typeof(TValueType));

            if(count > 0)
            {
                GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);

                var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(data, index);

                BufferSubData(target, (IntPtr)Offset, (IntPtr)count, ptr);

                handle.Free();
            }
        }

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
        /// Retrive the contents of bound buffer target into data pointer.
        /// </summary>
        /// <param name="target">The buffer target to retrive from.</param>
        /// <param name="Offset">The byte-offset from start of bound buffer to retrive.</param>
        /// <param name="data">buffer to write download data to.</param>
        /// <param name="index">index to start writing at.</param>
        /// <param name="count">number of elements to get.</param>
        unsafe public static void GetBufferSubData(BufferTarget target, long Offset, byte[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count);

            fixed(byte* ptr = &data[index])
            {
                GetBufferSubData(target, (IntPtr)Offset, (IntPtr)count, (IntPtr)ptr);
            }
        }
        /// <summary>
        /// Retrive the contents of bound buffer target into data pointer.
        /// </summary>
        /// <param name="target">The buffer target to retrive from.</param>
        /// <param name="Offset">The byte-offset from start of bound buffer to retrive.</param>
        /// <param name="data">buffer to write download data to.</param>
        /// <param name="index">index to start writing at.</param>
        /// <param name="count">number of elements to get.</param>
        unsafe public static void GetBufferSubData(BufferTarget target, long Offset, ushort[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count) * sizeof(ushort);

            fixed (ushort* ptr = &data[index])
            {
                GetBufferSubData(target, (IntPtr)Offset, (IntPtr)count, (IntPtr)ptr);
            }
        }
        /// <summary>
        /// Retrive the contents of bound buffer target into data pointer.
        /// </summary>
        /// <param name="target">The buffer target to retrive from.</param>
        /// <param name="Offset">The byte-offset from start of bound buffer to retrive.</param>
        /// <param name="data">buffer to write download data to.</param>
        /// <param name="index">index to start writing at.</param>
        /// <param name="count">number of elements to get.</param>
        unsafe public static void GetBufferSubData(BufferTarget target, long Offset, uint[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count) * sizeof(uint);

            fixed (uint* ptr = &data[index])
            {
                GetBufferSubData(target, (IntPtr)Offset, (IntPtr)count, (IntPtr)ptr);
            }
        }
        /// <summary>
        /// Retrive the contents of bound buffer target into data pointer.
        /// </summary>
        /// <param name="target">The buffer target to retrive from.</param>
        /// <param name="Offset">The byte-offset from start of bound buffer to retrive.</param>
        /// <param name="data">buffer to write download data to.</param>
        /// <param name="index">index to start writing at.</param>
        /// <param name="count">number of elements to get.</param>
        unsafe public static void GetBufferSubData(BufferTarget target, long Offset, float[] data, int index = 0, int count = -1)
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count) * sizeof(float);

            fixed (float* ptr = &data[index])
            {
                GetBufferSubData(target, (IntPtr)Offset, (IntPtr)count, (IntPtr)ptr);
            }
        }

        public static void GetBufferSubData<TValueType>(BufferTarget target, long Offset, TValueType[] data, int index = 0, int count = -1) where TValueType : struct
        {
            if (count == -1)
                count = data.Length;

            // TODO: Should we silently clamp this??
            count = Math.Min(data.Length - index, index + count) * Marshal.SizeOf(typeof(TValueType));

            if(count > 0)
            {
                GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);

                var ptr = Marshal.UnsafeAddrOfPinnedArrayElement(data, index);

                GetBufferSubData(target, (IntPtr)Offset, (IntPtr)count, ptr);

                handle.Free();
            }
        }

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
        public static void GetBufferParameteriv(BufferTarget target, BufferParameters pname, out int result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetBufferParameteriv")]
        public static int GetBufferParameteriv(BufferTarget target, BufferParameters pname) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetBufferPointerv")]
        public static void GetBufferPointerv(BufferTarget target, BufferPointerParameters pname, out IntPtr param){ throw new NotImplementedException(); }


        /// <summary>
        /// Generates an array of query ids.
        /// </summary>
        /// <param name="number">size of array</param>
        /// <param name="QueryIDs"></param>
        [EntryPoint(FunctionName = "glGenQueries")]
        unsafe public static void GenQueries(int number, uint* QueryIDs){ throw new NotImplementedException(); }
        /// <summary>
        /// Generates an array of query ids.
        /// </summary>
        /// <param name="number">size of array</param>
        /// <param name="QueryIDs"></param>
        [EntryPoint(FunctionName = "glGenQueries")]
        public static void GenQueries(int number, ref uint QueryIDs) { throw new NotImplementedException(); }

        /// <summary>
        /// Generates a single query id.
        /// </summary>        
        /// <param name="number">size of array</param>
        /// <returns></returns>        
        public static uint[] GenQueries(int number)
        {
            var t = new uint[number];
            GenQueries(t.Length, ref t[0]);
            return t;
        }

        /// <summary>
        /// Generates a single query id.
        /// </summary>        
        /// <returns></returns>        
        public static uint GenQueries()
        {
            uint t = 0;
            GenQueries(1, ref t);
            return t;
        }

        /// <summary>
        /// Generates an array of query objects
        /// </summary>
        /// <param name="QueryIDs"></param>
        public static void GenQueries(uint[] QueryIDs)
        {
            GenQueries(QueryIDs.Length, ref QueryIDs[0]);
        }


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
        public static void DeleteQueries(int number, ref uint QueryIDs) { throw new NotImplementedException(); }
        /// <summary>
        /// Deletes a single query object
        /// </summary>
        /// <param name="QueryID"></param>        
        public static void DeleteQueries(uint QueryID)
        {
            DeleteQueries(1, ref QueryID);
        }

        /// <summary>
        /// Delets an array of query objects
        /// </summary>
        /// <param name="QueryIDs"></param>
        public static void DeleteQueries(uint[] QueryIDs)
        {
            DeleteQueries(QueryIDs.Length, ref QueryIDs[0]);
        }

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
        public static void GetQueryiv(QueryTarget target, GetQueryParameters pname, int[] result) { throw new NotImplementedException(); }
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




        #endregion

    }
}
