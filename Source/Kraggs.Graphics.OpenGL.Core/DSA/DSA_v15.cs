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
    partial class DSA
    {

        #region OpenGL DLLImports

        [EntryPointSlot(25)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedBufferDataEXT(uint BufferID, IntPtr size, IntPtr data, BufferUsage usage);
        [EntryPointSlot(26)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedBufferSubDataEXT(uint BufferID, IntPtr Offset, IntPtr Size, IntPtr Data);
        [EntryPointSlot(27)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern IntPtr glMapNamedBufferEXT(uint BufferID, MapBufferAccess access);
        [EntryPointSlot(28)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glUnmapNamedBufferEXT(uint BufferID);

        [EntryPointSlot(29)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetNamedBufferParameterivEXT(uint BufferID, BufferParameters pname, int* result);
        [EntryPointSlot(30)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetNamedBufferPointervEXT(uint BufferID, BufferPointerParameters pname, out IntPtr ptr);
        [EntryPointSlot(31)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetNamedBufferSubDataEXT(uint BufferID, IntPtr Offset, IntPtr Size, IntPtr data);


        #endregion

        #region Public functions

        
        [EntryPoint(FunctionName = "glNamedBufferDataEXT")]
        public static void NamedBufferDataEXT(uint BufferID, IntPtr size, IntPtr data, BufferUsage usage){ throw new NotImplementedException(); }
        public static void NamedBufferDataEXT(uint BufferID, long size, IntPtr data, BufferUsage usage)
        {
            NamedBufferDataEXT(BufferID, (IntPtr)size, data, usage);
        }
        unsafe public static void NamedBufferDataEXT(uint BufferID, byte[] data, BufferUsage usage)
        {
            fixed(byte* ptr = &data[0])
            {
                NamedBufferDataEXT(BufferID, data.Length, (IntPtr)ptr, usage);
            }
        }
        unsafe public static void NamedBufferDataEXT(uint BufferID, float[] data, BufferUsage usage)
        {
            fixed (float* ptr = &data[0])
            {
                NamedBufferDataEXT(BufferID, data.Length * sizeof(float), (IntPtr)ptr, usage);
            }
        }
        unsafe public static void NamedBufferDataEXT(uint BufferID, ushort[] data, BufferUsage usage)
        {
            fixed (ushort* ptr = &data[0])
            {
                NamedBufferDataEXT(BufferID, data.Length * sizeof(ushort), (IntPtr)ptr, usage);
            }
        }
        unsafe public static void NamedBufferDataEXT(uint BufferID, uint[] data, BufferUsage usage)
        {
            fixed (uint* ptr = &data[0])
            {
                NamedBufferDataEXT(BufferID, data.Length * sizeof(uint), (IntPtr)ptr, usage);
            }
        }

        public static void NamedBufferDataEXT<TValueType>(uint BufferID, TValueType[] data, BufferUsage usage) where TValueType : struct
        {
            var size = Marshal.SizeOf(typeof(TValueType)) * data.Length;

            GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);

            NamedBufferDataEXT(BufferID, size, handle.AddrOfPinnedObject(), usage);

            handle.Free();
        }


        [EntryPoint(FunctionName = "glNamedBufferSubDataEXT")]
        public static void NamedBufferSubDataEXT(uint BufferID, IntPtr Offset, IntPtr Size, IntPtr Data){ throw new NotImplementedException(); }
        public static void NamedBufferSubDataEXT(uint BufferID, long Offset, long Size, IntPtr Data)
        {
            NamedBufferSubDataEXT(BufferID, (IntPtr)Offset, (IntPtr)Size, Data);
        }
        public static void NamedBufferSubDataEXT<TValueType>(uint BufferID, long Offset, TValueType[] Data, int index = 0, int count = -1) where TValueType : struct
        {
            if (count == -1)
                count = Data.Length;
            var SizeInBytes = Math.Min(Data.Length, count - index) * Marshal.SizeOf(typeof(TValueType));
            //NamedBufferSubDataEXT(BufferID, (IntPtr)Offset, (IntPtr)Size, Data);
            GCHandle handle = GCHandle.Alloc(Data, GCHandleType.Pinned);

            if(index != 0)
                NamedBufferSubDataEXT(BufferID, Offset, SizeInBytes, Marshal.UnsafeAddrOfPinnedArrayElement(Data, index));
            else
                NamedBufferSubDataEXT(BufferID, Offset, SizeInBytes, handle.AddrOfPinnedObject());

            handle.Free();
        }

        unsafe public static void NamedBufferSubDataEXT(uint BufferID, long Offset, byte[] Data)
        {
            fixed(byte* ptr = &Data[0])
            {
                NamedBufferSubDataEXT(BufferID, Offset, Data.Length, (IntPtr)ptr);
            }
        }
        unsafe public static void NamedBufferSubDataEXT(uint BufferID, long Offset, ushort[] Data)
        {
            fixed (ushort* ptr = &Data[0])
            {
                NamedBufferSubDataEXT(BufferID, Offset, Data.Length * sizeof(ushort), (IntPtr)ptr);
            }
        }
        unsafe public static void NamedBufferSubDataEXT(uint BufferID, long Offset, uint[] Data)
        {
            fixed (uint* ptr = &Data[0])
            {
                NamedBufferSubDataEXT(BufferID, Offset, Data.Length * sizeof(uint), (IntPtr)ptr);
            }
        }
        unsafe public static void NamedBufferSubDataEXT(uint BufferID, long Offset, float[] Data)
        {
            fixed (float* ptr = &Data[0])
            {
                NamedBufferSubDataEXT(BufferID, Offset, Data.Length * sizeof(float), (IntPtr)ptr);
            }
        }

        [EntryPoint(FunctionName = "glMapNamedBufferEXT")]
        public static IntPtr MapNamedBufferEXT(uint BufferID, MapBufferAccess access){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glUnmapNamedBufferEXT")]
        public static bool UnmapNamedBufferEXT(uint BufferID){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glGetNamedBufferParameterivEXT")]
        unsafe public static void GetNamedBufferParameterivEXT(uint BufferID, BufferParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedBufferParameterivEXT")]
        public static void GetNamedBufferParameterivEXT(uint BufferID, BufferParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedBufferParameterivEXT")]
        public static void GetNamedBufferParameterivEXT(uint BufferID, BufferParameters pname, ref int result) { throw new NotImplementedException(); }
        
        public static int GetNamedBufferParameterivEXT(uint BufferID, BufferParameters pname)
        {
            int tmp = 0;
            GetNamedBufferParameterivEXT(BufferID, pname, ref tmp);
            return tmp;
        }

        [EntryPoint(FunctionName = "glGetNamedBufferPointervEXT")]
        public static void GetNamedBufferPointervEXT(uint BufferID, BufferPointerParameters pname, out IntPtr ptr){ throw new NotImplementedException(); }
        
        public static IntPtr GetNamedBufferPointervEXT(uint BufferID, BufferPointerParameters pname)
        {
            var ptr = IntPtr.Zero;
            GetNamedBufferPointervEXT(BufferID, pname, out ptr);
            return ptr;
        }

        [EntryPoint(FunctionName = "glGetNamedBufferSubDataEXT")]
        public static void GetNamedBufferSubDataEXT(uint BufferID, IntPtr Offset, IntPtr Size, IntPtr data){ throw new NotImplementedException(); }
        public static void GetNamedBufferSubDataEXT(uint BufferID, long Offset, long Size, IntPtr data)
        {
            GetNamedBufferSubDataEXT(BufferID, (IntPtr)Offset, (IntPtr)Size, data);
        }

        #endregion

        #region Public Helper Functions

        #endregion

    }
}
