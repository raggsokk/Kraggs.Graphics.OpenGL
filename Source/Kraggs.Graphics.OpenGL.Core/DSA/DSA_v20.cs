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
        
        [EntryPointSlot(32)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform1fEXT(uint ProgramID, uint location, float v1);
        [EntryPointSlot(33)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform1iEXT(uint ProgramID, uint location, int v1);

        [EntryPointSlot(34)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform2fEXT(uint ProgramID, uint location, float v1, float v2);
        [EntryPointSlot(35)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform2iEXT(uint ProgramID, uint location, int v1, int v2);

        [EntryPointSlot(36)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform3fEXT(uint ProgramID, uint location, float v1, float v2, float v3);
        [EntryPointSlot(37)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform3iEXT(uint ProgramID, uint location, int v1, int v2, int v3);

        [EntryPointSlot(38)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform4fEXT(uint ProgramID, uint location, float v1, float v2, float v3, float v4);
        [EntryPointSlot(39)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform4iEXT(uint ProgramID, uint location, int v1, int v2, int v3, int v4);

        [EntryPointSlot(40)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform1fvEXT(uint ProgramID, uint location, int count, float* v);
        [EntryPointSlot(41)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform1ivEXT(uint ProgramID, uint location, int count, int* v);

        [EntryPointSlot(42)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform2fvEXT(uint ProgramID, uint location, int count, float* v);
        [EntryPointSlot(43)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform2ivEXT(uint ProgramID, uint location, int count, int* v);

        [EntryPointSlot(44)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform3fvEXT(uint ProgramID, uint location, int count, float* v);
        [EntryPointSlot(45)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform3ivEXT(uint ProgramID, uint location, int count, int* v);

        [EntryPointSlot(46)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform4fvEXT(uint ProgramID, uint location, int count, float* v);
        [EntryPointSlot(47)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform4ivEXT(uint ProgramID, uint location, int count, int* v);

        [EntryPointSlot(48)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix2fvEXT(uint ProgramID, uint location, int count, bool transpose, float* matrix);
        [EntryPointSlot(49)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix3fvEXT(uint ProgramID, uint location, int count, bool transpose, float* matrix);
        [EntryPointSlot(50)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix4fvEXT(uint ProgramID, uint location, int count, bool transpose, float* matrix);

        #endregion

        #region Public functions

        
        [EntryPoint(FunctionName = "glProgramUniform1fEXT")]
        public static void ProgramUniform1fEXT(uint ProgramID, uint location, float v1){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform1iEXT")]
        public static void ProgramUniform1iEXT(uint ProgramID, uint location, int v1){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glProgramUniform2fEXT")]
        public static void ProgramUniform2fEXT(uint ProgramID, uint location, float v1, float v2){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform2iEXT")]
        public static void ProgramUniform2iEXT(uint ProgramID, uint location, int v1, int v2){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glProgramUniform3fEXT")]
        public static void ProgramUniform3fEXT(uint ProgramID, uint location, float v1, float v2, float v3){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform3iEXT")]
        public static void ProgramUniform3iEXT(uint ProgramID, uint location, int v1, int v2, int v3){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glProgramUniform4fEXT")]
        public static void ProgramUniform4fEXT(uint ProgramID, uint location, float v1, float v2, float v3, float v4){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform4iEXT")]
        public static void ProgramUniform4iEXT(uint ProgramID, uint location, int v1, int v2, int v3, int v4){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glProgramUniform1fvEXT")]
        unsafe public static void ProgramUniform1fvEXT(uint ProgramID, uint location, int count, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1fvEXT")]
        public static void ProgramUniform1fvEXT(uint ProgramID, uint location, int count, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1fvEXT")]
        public static void ProgramUniform1fvEXT(uint ProgramID, uint location, int count, ref float v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform1ivEXT")]
        unsafe public static void ProgramUniform1ivEXT(uint ProgramID, uint location, int count, int* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1ivEXT")]
        public static void ProgramUniform1ivEXT(uint ProgramID, uint location, int count, int[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1ivEXT")]
        public static void ProgramUniform1ivEXT(uint ProgramID, uint location, int count, ref int v) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glProgramUniform2fvEXT")]
        unsafe public static void ProgramUniform2fvEXT(uint ProgramID, uint location, int count, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2fvEXT")]
        public static void ProgramUniform2fvEXT(uint ProgramID, uint location, int count, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2fvEXT")]
        public static void ProgramUniform2fvEXT(uint ProgramID, uint location, int count, ref float v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform2ivEXT")]
        unsafe public static void ProgramUniform2ivEXT(uint ProgramID, uint location, int count, int* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2ivEXT")]
        public static void ProgramUniform2ivEXT(uint ProgramID, uint location, int count, int[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2ivEXT")]
        public static void ProgramUniform2ivEXT(uint ProgramID, uint location, int count, ref int v) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glProgramUniform3fvEXT")]
        unsafe public static void ProgramUniform3fvEXT(uint ProgramID, uint location, int count, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3fvEXT")]
        public static void ProgramUniform3fvEXT(uint ProgramID, uint location, int count, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3fvEXT")]
        public static void ProgramUniform3fvEXT(uint ProgramID, uint location, int count, ref float v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform3ivEXT")]
        unsafe public static void ProgramUniform3ivEXT(uint ProgramID, uint location, int count, int* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3ivEXT")]
        public static void ProgramUniform3ivEXT(uint ProgramID, uint location, int count, int[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3ivEXT")]
        public static void ProgramUniform3ivEXT(uint ProgramID, uint location, int count, ref int v) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glProgramUniform4fvEXT")]
        unsafe public static void ProgramUniform4fvEXT(uint ProgramID, uint location, int count, float* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4fvEXT")]
        public static void ProgramUniform4fvEXT(uint ProgramID, uint location, int count, float[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4fvEXT")]
        public static void ProgramUniform4fvEXT(uint ProgramID, uint location, int count, ref float v) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniform4ivEXT")]
        unsafe public static void ProgramUniform4ivEXT(uint ProgramID, uint location, int count, int* v){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4ivEXT")]
        public static void ProgramUniform4ivEXT(uint ProgramID, uint location, int count, int[] v) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4ivEXT")]
        public static void ProgramUniform4ivEXT(uint ProgramID, uint location, int count, ref int v) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glProgramUniformMatrix2fvEXT")]
        unsafe public static void ProgramUniformMatrix2fvEXT(uint ProgramID, uint location, int count, bool transpose, float* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2fvEXT")]
        public static void ProgramUniformMatrix2fvEXT(uint ProgramID, uint location, int count, bool transpose, float[] matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2fvEXT")]
        public static void ProgramUniformMatrix2fvEXT(uint ProgramID, uint location, int count, bool transpose, ref float matrix) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniformMatrix3fvEXT")]
        unsafe public static void ProgramUniformMatrix3fvEXT(uint ProgramID, uint location, int count, bool transpose, float* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3fvEXT")]
        public static void ProgramUniformMatrix3fvEXT(uint ProgramID, uint location, int count, bool transpose, float[] matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3fvEXT")]
        public static void ProgramUniformMatrix3fvEXT(uint ProgramID, uint location, int count, bool transpose, ref float matrix) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniformMatrix4fvEXT")]
        unsafe public static void ProgramUniformMatrix4fvEXT(uint ProgramID, uint location, int count, bool transpose, float* matrix){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4fvEXT")]
        public static void ProgramUniformMatrix4fvEXT(uint ProgramID, uint location, int count, bool transpose, float[] matrix) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4fvEXT")]
        public static void ProgramUniformMatrix4fvEXT(uint ProgramID, uint location, int count, bool transpose, ref float matrix) { throw new NotImplementedException(); }


        #endregion

        #region Public Helper Functions

        #endregion

    }
}
