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

//TODO: Should uint64EXT be ulong???
using uint64EXT = System.IntPtr;

namespace Kraggs.Graphics.OpenGL
{
    partial class NV
    {
        #region OpenGL DLLImports

        [EntryPointSlot(16)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBufferAddressRangeNV(BufferAddressRangeNV pname, uint index, uint64EXT address, IntPtr length);
        [EntryPointSlot(17)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexAttribFormatNV(uint index, int size, VertexAttribFormat type, bool normalized, int stride);
        [EntryPointSlot(18)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glVertexAttribIFormatNV(uint index, int size, VertexAttribIFormat type, int stride);
        [EntryPointSlot(19)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetIntegerui64i_vNV(GetParameters value, uint index, uint64EXT* result);

        #endregion

        #region Public functions

        //[EntryPoint(FunctionName = "gl")]
        //public static void BindTexture(TextureTarget target, uint textureid) { throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glBufferAddressRangeNV")]
        public static void BufferAddressRangeNV(BufferAddressRangeNV pname, uint index, uint64EXT address, IntPtr length){ throw new NotImplementedException(); }

        public static void BufferAddressRangeNV(BufferAddressRangeNV pname, uint index, uint64EXT address, long length)
        {
            BufferAddressRangeNV(pname, index, address, (IntPtr)length);
        }

        [EntryPoint(FunctionName = "glVertexAttribFormatNV")]
        public static void VertexAttribFormatNV(uint index, int size, VertexAttribFormat type, bool normalized, int stride){ throw new NotImplementedException(); }

        public static void VertexAttribFormatNV(uint index, int size, VertexAttribFormat type, int stride, bool normalized = false)
        {
            VertexAttribFormatNV(index, size, type, normalized, stride);
        }

        [EntryPoint(FunctionName = "glVertexAttribIFormatNV")]
        public static void VertexAttribIFormatNV(uint index, int size, VertexAttribIFormat type, int stride){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetIntegerui64i_vNV")]
        unsafe public static void GetIntegerui64i_vNV(GetParameters value, uint index, uint64EXT* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetIntegerui64i_vNV")]
        public static void GetIntegerui64i_vNV(GetParameters value, uint index, uint64EXT[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetIntegerui64i_vNV")]
        public static void GetIntegerui64i_vNV(GetParameters value, uint index, ref uint64EXT result) { throw new NotImplementedException(); }
        public static uint64EXT GetIntegerui64i_vNV(GetParameters value, uint index)
        {
            uint64EXT address = (uint64EXT)0;
            GetIntegerui64i_vNV(value, index, ref address);
            return address;
        }

        #endregion

        #region Public Helper Functions

        #endregion
    }
}
