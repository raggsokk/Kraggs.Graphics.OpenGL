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
    partial class ARB
    {
        #region OpenGL DLLImports

        [EntryPointSlot(30)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform1i64ARB(int location, long x);

        [EntryPointSlot(31)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform2i64ARB(int location, long x, long y);

        [EntryPointSlot(32)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform3i64ARB(int location, long x, long y, long z);

        [EntryPointSlot(33)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform4i64ARB(int location, long x, long y, long z, long w);

        [EntryPointSlot(34)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private unsafe static extern void glUniform1i64vARB(int location, int count, long* value);

        [EntryPointSlot(35)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private unsafe static extern void glUniform2i64vARB(int location, int count, long* value);

        [EntryPointSlot(36)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private unsafe static extern void glUniform3i64vARB(int location, int count, long* value);

        [EntryPointSlot(37)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private unsafe static extern void glUniform4i64vARB(int location, int count, long* value);


        [EntryPointSlot(38)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform1ui64ARB(int location, ulong x);

        [EntryPointSlot(39)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform2ui64ARB(int location, ulong x, ulong y);

        [EntryPointSlot(40)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform3ui64ARB(int location, ulong x, ulong y, ulong z);

        [EntryPointSlot(41)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniform4ui64ARB(int location, ulong x, ulong y, ulong z, ulong w);

        [EntryPointSlot(42)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private unsafe static extern void glUniform1ui64vARB(int location, int count, ulong* value);

        [EntryPointSlot(43)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private unsafe static extern void glUniform2ui64vARB(int location, int count, ulong* value);

        [EntryPointSlot(44)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private unsafe static extern void glUniform3ui64vARB(int location, int count, ulong* value);

        [EntryPointSlot(45)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private unsafe static extern void glUniform4ui64vARB(int location, int count, ulong* value);



        [EntryPointSlot(46)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private unsafe static extern void glGetUniformi64vARB(uint program, int location, long* values);

        [EntryPointSlot(47)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private unsafe static extern void glGetUniformui64vARB(uint program, int location, ulong* values);

        [EntryPointSlot(48)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private unsafe static extern void glGetnUniformi64vARB(uint program, int location, int bufsize, long* values);

        [EntryPointSlot(49)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private unsafe static extern void glGetnUniformui64vARB(uint program, int location, int bufsize, ulong* values);




        [EntryPointSlot(50)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform1i64ARB(uint program, int location, long x);

        [EntryPointSlot(51)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform2i64ARB(uint program, int location, long x, long y);

        [EntryPointSlot(52)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform3i64ARB(uint program, int location, long x, long y, long z);

        [EntryPointSlot(53)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform4i64ARB(uint program, int location, long x, long y, long z, long w);

        [EntryPointSlot(54)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform1i64vARB(uint program, int location, int count, long* values);

        [EntryPointSlot(55)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform2i64vARB(uint program, int location, int count, long* values);

        [EntryPointSlot(56)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform3i64vARB(uint program, int location, int count, long* values);

        [EntryPointSlot(57)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform4i64vARB(uint program, int location, int count, long* values);



        [EntryPointSlot(58)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform1ui64ARB(uint program, int location, ulong x);

        [EntryPointSlot(59)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform2ui64ARB(uint program, int location, ulong x, ulong y);

        [EntryPointSlot(60)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform3ui64ARB(uint program, int location, ulong x, ulong y, ulong z);

        [EntryPointSlot(61)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform4ui64ARB(uint program, int location, ulong x, ulong y, ulong z, ulong w);

        [EntryPointSlot(62)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform1ui64vARB(uint program, int location, int count, ulong* values);

        [EntryPointSlot(63)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform2ui64vARB(uint program, int location, int count, ulong* values);

        [EntryPointSlot(64)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform3ui64vARB(uint program, int location, int count, ulong* values);

        [EntryPointSlot(65)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform4ui64vARB(uint program, int location, int count, ulong* values);



        #endregion

        #region Public functions

        [EntryPoint(FunctionName = "glUniform1i64ARB")]
        public static void Uniform1i64ARB(int location, long x) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform2i64ARB")]
        public static void Uniform2i64ARB(int location, long x, long y) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform3i64ARB")]
        public static void Uniform3i64ARB(int location, long x, long y, long z) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform4i64ARB")]
        public static void Uniform4i64ARB(int location, long x, long y, long z, long w) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform1i64vARB")]
        public unsafe static void Uniform1i64vARB(int location, int count, long* value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform1i64vARB")]
        public unsafe static void Uniform1i64vARB(int location, int count, long[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform1i64vARB")]
        public unsafe static void Uniform1i64vARB(int location, int count, ref long value) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glUniform2i64vARB")]
        public unsafe static void Uniform2i64vARB(int location, int count, long* value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform2i64vARB")]
        public unsafe static void Uniform2i64vARB(int location, int count, long[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform2i64vARB")]
        public unsafe static void Uniform2i64vARB(int location, int count, ref long value) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform3i64vARB")]
        public unsafe static void Uniform3i64vARB(int location, int count, long* value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform3i64vARB")]
        public unsafe static void Uniform3i64vARB(int location, int count, long[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform3i64vARB")]
        public unsafe static void Uniform3i64vARB(int location, int count, ref long value) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform4i64vARB")]
        public unsafe static void Uniform4i64vARB(int location, int count, long* value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform4i64vARB")]
        public unsafe static void Uniform4i64vARB(int location, int count, long[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform4i64vARB")]
        public unsafe static void Uniform4i64vARB(int location, int count, ref long value) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glUniform1ui64ARB")]
        public static void Uniform1ui64ARB(int location, ulong x) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform2ui64ARB")]
        public static void Uniform2ui64ARB(int location, ulong x, ulong y) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform3ui64ARB")]
        public static void Uniform3ui64ARB(int location, ulong x, ulong y, ulong z) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform4ui64ARB")]
        public static void Uniform4ui64ARB(int location, ulong x, ulong y, ulong z, ulong w) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform1ui64vARB")]
        public unsafe static void Uniform1ui64vARB(int location, int count, ulong* value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform1ui64vARB")]
        public unsafe static void Uniform1ui64vARB(int location, int count, ulong[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform1ui64vARB")]
        public unsafe static void Uniform1ui64vARB(int location, int count, ref ulong value) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform2ui64vARB")]
        public unsafe static void Uniform2ui64vARB(int location, int count, ulong* value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform2ui64vARB")]
        public unsafe static void Uniform2ui64vARB(int location, int count, ulong[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform2ui64vARB")]
        public unsafe static void Uniform2ui64vARB(int location, int count, ref ulong value) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform3ui64vARB")]
        public unsafe static void Uniform3ui64vARB(int location, int count, ulong* value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform3ui64vARB")]
        public unsafe static void Uniform3ui64vARB(int location, int count, ulong[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform3ui64vARB")]
        public unsafe static void Uniform3ui64vARB(int location, int count, ref ulong value) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glUniform4ui64vARB")]
        public unsafe static void Uniform4ui64vARB(int location, int count, ulong* value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform4ui64vARB")]
        public unsafe static void Uniform4ui64vARB(int location, int count, ulong[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glUniform4ui64vARB")]
        public unsafe static void Uniform4ui64vARB(int location, int count, ref ulong value) { throw new NotImplementedException(); }



        [EntryPoint(FunctionName = "glGetUniformi64vARB")]
        public unsafe static void GetUniformi64vARB(uint program, int location, long* values) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetUniformi64vARB")]
        public unsafe static void GetUniformi64vARB(uint program, int location, long[] values) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetUniformi64vARB")]
        public unsafe static void GetUniformi64vARB(uint program, int location, ref long values) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetUniformui64vARB")]
        public unsafe static void GetUniformui64vARB(uint program, int location, ulong* values) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetUniformui64vARB")]
        public unsafe static void GetUniformui64vARB(uint program, int location, ulong[] values) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetUniformui64vARB")]
        public unsafe static void GetUniformui64vARB(uint program, int location, ref ulong values) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glGetnUniformi64vARB")]
        public unsafe static void GetnUniformi64vARB(uint program, int location, int bufsize, long* values){ throw new NotImplementedException(); }        
        public unsafe static void GetnUniformi64vARB(uint program, int location, long[] values, int start = 0)
        {
            GetnUniformi64vARB(program, location, values.Length, ref values[start]);
        }
        [EntryPoint(FunctionName = "glGetnUniformi64vARB")]
        public unsafe static void GetnUniformi64vARB(uint program, int location, int bufsize, ref long values) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glGetnUniformui64vARB")]
        public unsafe static void GetnUniformui64vARB(uint program, int location, int bufsize, ulong* values){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetnUniformui64vARB")]
        public unsafe static void GetnUniformui64vARB(uint program, int location, int bufsize, ref ulong values) { throw new NotImplementedException(); }        
        public unsafe static void GetnUniformui64vARB(uint program, int location, ulong[] values, int start = 0)
        {
            GetnUniformui64vARB(program, location, values.Length, ref values[start]);
        }


        [EntryPoint(FunctionName = "glProgramUniform1i64ARB")]
        public static void ProgramUniform1i64ARB(uint program, int location, long x){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform2i64ARB")]
        public static void ProgramUniform2i64ARB(uint program, int location, long x, long y){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform3i64ARB")]
        public static void ProgramUniform3i64ARB(uint program, int location, long x, long y, long z){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform4i64ARB")]
        public static void ProgramUniform4i64ARB(uint program, int location, long x, long y, long z, long w){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform1i64vARB")]
        unsafe public static void ProgramUniform1i64vARB(uint program, int location, int count, long* values){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1i64vARB")]
        unsafe public static void ProgramUniform1i64vARB(uint program, int location, int count, ref long values) { throw new NotImplementedException(); }
        unsafe public static void ProgramUniform1i64vARB(uint program, int location, int count, long[] values, int start = 0)
        {
            ProgramUniform1i64vARB(program, location, count, ref values[start]);
        }


        [EntryPoint(FunctionName = "glProgramUniform2i64vARB")]
        unsafe public static void ProgramUniform2i64vARB(uint program, int location, int count, long* values){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2i64vARB")]
        unsafe public static void ProgramUniform2i64vARB(uint program, int location, int count, ref long values) { throw new NotImplementedException(); }
        unsafe public static void ProgramUniform2i64vARB(uint program, int location, int count, long[] values, int start = 0)
        {
            ProgramUniform2i64vARB(program, location, count, ref values[start]);
        }


        [EntryPoint(FunctionName = "glProgramUniform3i64vARB")]
        unsafe public static void ProgramUniform3i64vARB(uint program, int location, int count, long* values){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3i64vARB")]
        unsafe public static void ProgramUniform3i64vARB(uint program, int location, int count, ref long values) { throw new NotImplementedException(); }
        unsafe public static void ProgramUniform3i64vARB(uint program, int location, int count, long[] values, int start = 0)
        {
            ProgramUniform3i64vARB(program, location, count, ref values[start]);
        }


        [EntryPoint(FunctionName = "glProgramUniform4i64vARB")]
        unsafe public static void ProgramUniform4i64vARB(uint program, int location, int count, long* values){ throw new NotImplementedException(); }                
        [EntryPoint(FunctionName = "glProgramUniform4i64vARB")]
        unsafe public static void ProgramUniform4i64vARB(uint program, int location, int count, ref long values) { throw new NotImplementedException(); }
        unsafe public static void ProgramUniform4i64vARB(uint program, int location, int count, long[] values, int start = 0)
        {
            ProgramUniform4i64vARB(program, location, count, ref values[start]);
        }



        [EntryPoint(FunctionName = "glProgramUniform1ui64ARB")]
        public static void ProgramUniform1ui64ARB(uint program, int location, ulong x){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform2ui64ARB")]
        public static void ProgramUniform2ui64ARB(uint program, int location, ulong x, ulong y){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform3ui64ARB")]
        public static void ProgramUniform3ui64ARB(uint program, int location, ulong x, ulong y, ulong z){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform4ui64ARB")]
        public static void ProgramUniform4ui64ARB(uint program, int location, ulong x, ulong y, ulong z, ulong w){ throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform1ui64vARB")]
        unsafe public static void ProgramUniform1ui64vARB(uint program, int location, int count, ulong* values){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1ui64vARB")]
        unsafe public static void ProgramUniform1ui64vARB(uint program, int location, int count, ref ulong values) { throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glProgramUniform1ui64vARB")]
        //unsafe public static void ProgramUniform1ui64vARB(uint program, int location, int count, ulong[] values) { throw new NotImplementedException(); }        
        unsafe public static void ProgramUniform1ui64vARB(uint program, int location, int count, ulong[] values, int start = 0)
        {
            ProgramUniform1ui64vARB(program, location, count, ref values[start]);
        }


        [EntryPoint(FunctionName = "glProgramUniform2ui64vARB")]
        unsafe public static void ProgramUniform2ui64vARB(uint program, int location, int count, ulong* values){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2ui64vARB")]
        unsafe public static void ProgramUniform2ui64vARB(uint program, int location, int count, ref ulong values) { throw new NotImplementedException(); }        
        unsafe public static void ProgramUniform2ui64vARB(uint program, int location, int count, ulong[] values, int start = 0)
        {
            ProgramUniform2ui64vARB(program, location, count, ref values[start]);
        }

        [EntryPoint(FunctionName = "glProgramUniform3ui64vARB")]
        unsafe public static void ProgramUniform3ui64vARB(uint program, int location, int count, ulong* values){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3ui64vARB")]
        unsafe public static void ProgramUniform3ui64vARB(uint program, int location, int count, ref ulong values) { throw new NotImplementedException(); }        
        unsafe public static void ProgramUniform3ui64vARB(uint program, int location, int count, ulong[] values, int start = 0)
        {
            ProgramUniform3ui64vARB(program, location, count, ref values[start]);
        }

        [EntryPoint(FunctionName = "glProgramUniform4ui64vARB")]
        unsafe public static void ProgramUniform4ui64vARB(uint program, int location, int count, ulong* values){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4ui64vARB")]
        unsafe public static void ProgramUniform4ui64vARB(uint program, int location, int count, ref ulong values) { throw new NotImplementedException(); }
        unsafe public static void ProgramUniform4ui64vARB(uint program, int location, int count, ulong[] values, int start = 0)
        {
            ProgramUniform4ui64vARB(program, location, count, ref values[start]);
        }


        #endregion

        #region Public Helper Functions

        #endregion
    }
}
