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

using uint64EXT = System.IntPtr;

namespace Kraggs.Graphics.OpenGL
{
    partial class NV
    {
        #region OpenGL DLLImports

        [EntryPointSlot(2)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMakeBufferResidentNV(BufferTarget target, BufferResidentAccessNV access);
        [EntryPointSlot(3)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMakeBufferNonResidentNV(BufferTarget target);
        [EntryPointSlot(4)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsBufferResidentNV(BufferTarget target);

        [EntryPointSlot(5)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMakeNamedBufferResidentNV(uint buffer, BufferResidentAccessNV access);
        [EntryPointSlot(6)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMakeNamedBufferNonResidentNV(uint buffer);
        [EntryPointSlot(7)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsNamedBufferResidentNV(uint buffer);

        [EntryPointSlot(8)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetBufferParameterui64vNV(BufferTarget target, BufferParameters pname, uint64EXT* result);
        [EntryPointSlot(9)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetNamedBufferParameterui64vNV(uint buffer, BufferParameters pname, uint64EXT* result);

        [EntryPointSlot(10)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetIntegerui64vNV(GetParameters value, uint64EXT* result);

        [EntryPointSlot(11)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniformui64NV(int location, uint64EXT value);
        [EntryPointSlot(12)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glUniformui64vNV(int location, int count, uint64EXT* value);
        [EntryPointSlot(13)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetUniformui64vNV(uint program, int location, uint64EXT* result);
        [EntryPointSlot(14)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniformui64NV(uint program, int location, uint64EXT value);
        [EntryPointSlot(15)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformui64vNV(uint program, int location, int count, uint64EXT* value);

        #endregion

        #region Public functions

        [EntryPoint(FunctionName = "glMakeBufferResidentNV")]
        public static void MakeBufferResidentNV(BufferTarget target, BufferResidentAccessNV access) { throw new NotImplementedException(); }
        /// <summary>
        /// Makes buffer resident READONLY
        /// </summary>
        /// <param name="target"></param>
        public static void MakeBufferResidentNV(BufferTarget target)
        {
            MakeBufferResidentNV(target, BufferResidentAccessNV.ReadOnly);
        }

        [EntryPoint(FunctionName = "glMakeBufferNonResidentNV")]
        public static void MakeBufferNonResidentNV(BufferTarget target) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glIsBufferResidentNV")]
        public static bool IsBufferResidentNV(BufferTarget target) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glMakeNamedBufferResidentNV")]
        public static void MakeNamedBufferResidentNV(uint buffer, BufferResidentAccessNV access) { throw new NotImplementedException(); }
        /// <summary>
        /// Makes buffer resident READONLY
        /// </summary>
        /// <param name="buffer"></param>
        public static void MakeNamedBufferResidentNV(uint buffer)
        {
            MakeNamedBufferResidentNV(buffer, BufferResidentAccessNV.ReadOnly);
        }

        [EntryPoint(FunctionName = "glMakeNamedBufferNonResidentNV")]
        public static void MakeNamedBufferNonResidentNV(uint buffer) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glIsNamedBufferResidentNV")]
        public static bool IsNamedBufferResidentNV(uint buffer) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glGetBufferParameterui64vNV")]
        unsafe public static void GetBufferParameterui64vNV(BufferTarget target, BufferParameters pname, uint64EXT* result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetBufferParameterui64vNV")]
        public static void GetBufferParameterui64vNV(BufferTarget target, BufferParameters pname, uint64EXT[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetBufferParameterui64vNV")]
        public static void GetBufferParameterui64vNV(BufferTarget target, BufferParameters pname, ref uint64EXT result) { throw new NotImplementedException(); }
        public static uint64EXT GetBufferParameterui64vNV(BufferTarget target, BufferParameters pname)
        {
            uint64EXT result = (uint64EXT)0;
            GetBufferParameterui64vNV(target, pname, ref result);
            return result;
        }

        [EntryPoint(FunctionName = "glGetNamedBufferParameterui64vNV")]
        unsafe public static void GetNamedBufferParameterui64vNV(uint buffer, BufferParameters pname, uint64EXT* result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedBufferParameterui64vNV")]
        public static void GetNamedBufferParameterui64vNV(uint buffer, BufferParameters pname, uint64EXT[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedBufferParameterui64vNV")]
        public static void GetNamedBufferParameterui64vNV(uint buffer, BufferParameters pname, ref uint64EXT result) { throw new NotImplementedException(); }
        public static uint64EXT GetNamedBufferParameterui64vNV(uint buffer, BufferParameters pname)
        {
            uint64EXT result = (uint64EXT)0;
            GetNamedBufferParameterui64vNV(buffer, pname, ref result);
            return result;
        }


        [EntryPoint(FunctionName = "glGetIntegerui64vNV")]
        unsafe public static void GetIntegerui64vNV(GetParameters value, uint64EXT* result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetIntegerui64vNV")]
        public static void GetIntegerui64vNV(GetParameters value, uint64EXT[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetIntegerui64vNV")]
        public static void GetIntegerui64vNV(GetParameters value, ref uint64EXT result) { throw new NotImplementedException(); }

        public static uint64EXT GetIntegerui64vNV(GetParameters value)
        {
            uint64EXT result = (uint64EXT)0;
            GetIntegerui64vNV(value, ref result);
            return result;
        }

        [EntryPoint(FunctionName = "glUniformui64NV")]
        public static void Uniformui64NV(int location, uint64EXT value) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniformui64vNV")]
        unsafe public static void Uniformui64vNV(int location, int count, uint64EXT* value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformui64vNV")]
        public static void Uniformui64vNV(int location, int count, uint64EXT[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniformui64vNV")]
        public static void Uniformui64vNV(int location, int count, ref uint64EXT value) { throw new NotImplementedException(); }
        public static void Uniformui64vNV(int location, uint64EXT[] value, int count = 1, int vindex = 0)
        {
            Uniformui64vNV(location, count, ref value[vindex]);
        }        
        public static void Uniformui64vNV(int location, ref uint64EXT value, int count = 1)
        {
            Uniformui64vNV(location, count, ref value);
        }

        [EntryPoint(FunctionName = "glGetUniformui64vNV")]
        unsafe public static void GetUniformui64vNV(uint program, int location, uint64EXT* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetUniformui64vNV")]
        public static void GetUniformui64vNV(uint program, int location, uint64EXT[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetUniformui64vNV")]
        public static void GetUniformui64vNV(uint program, int location, ref uint64EXT result) { throw new NotImplementedException(); }        
        public static uint64EXT GetUniformui64vNV(uint program, int location)
        {
            uint64EXT result = (uint64EXT)0;
            GetUniformui64vNV(program, location, ref result);
            return result;
        }

        [EntryPoint(FunctionName = "glProgramUniformui64NV")]
        public static void ProgramUniformui64NV(uint program, int location, uint64EXT value){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniformui64vNV")]
        unsafe public static void ProgramUniformui64vNV(uint program, int location, int count, uint64EXT* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformui64vNV")]
        public static void ProgramUniformui64vNV(uint program, int location, int count, uint64EXT[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformui64vNV")]
        public static void ProgramUniformui64vNV(uint program, int location, int count, ref uint64EXT value) { throw new NotImplementedException(); }
        public static void ProgramUniformui64vNV(uint program, int location, uint64EXT[] value, int count = 1, int vindex = 0)
        {
            ProgramUniformui64vNV(program, location, count, ref value[vindex]);
        }        
        public static void ProgramUniformui64vNV(uint program, int location, ref uint64EXT value, int count = 1)
        {
            ProgramUniformui64vNV(program, location, count, ref value);
        }

        #endregion

        #region Public Helper Functions

        #endregion
    }
}
