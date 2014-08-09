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
        //#region Delegate Class

        //partial class Delegates
        //{

        //    #region Delegates

        //    //ARB_gpu_shader_fp64
        //    public delegate void delProgramUniform1dEXT(uint program, int location, double x);
        //    public delegate void delProgramUniform2dEXT(uint program, int location, double x, double y);
        //    public delegate void delProgramUniform3dEXT(uint program, int location, double x, double y, double z);
        //    public delegate void delProgramUniform4dEXT(uint program, int location, double x, double y, double z, double w);
        //    public delegate void delProgramUniform1dvEXT(uint program, int location, int count, ref double value);
        //    public delegate void delProgramUniform2dvEXT(uint program, int location, int count, ref double value);
        //    public delegate void delProgramUniform3dvEXT(uint program, int location, int count, ref double value);
        //    public delegate void delProgramUniform4dvEXT(uint program, int location, int count, ref double value);

        //    public delegate void delProgramUniformMatrix2dvEXT(uint program, int location, int count, bool transpose, ref double value);
        //    public delegate void delProgramUniformMatrix3dvEXT(uint program, int location, int count, bool transpose, ref double value);
        //    public delegate void delProgramUniformMatrix4dvEXT(uint program, int location, int count, bool transpose, ref double value);
        //    public delegate void delProgramUniformMatrix2x3dvEXT(uint program, int location, int count, bool transpose, ref double value);
        //    public delegate void delProgramUniformMatrix2x4dvEXT(uint program, int location, int count, bool transpose, ref double value);
        //    public delegate void delProgramUniformMatrix3x2dvEXT(uint program, int location, int count, bool transpose, ref double value);
        //    public delegate void delProgramUniformMatrix3x4dvEXT(uint program, int location, int count, bool transpose, ref double value);
        //    public delegate void delProgramUniformMatrix4x2dvEXT(uint program, int location, int count, bool transpose, ref double value);
        //    public delegate void delProgramUniformMatrix4x3dvEXT(uint program, int location, int count, bool transpose, ref double value);



        //    #endregion

        //    #region GL Fields

        //    public static delProgramUniform1dEXT glProgramUniform1dEXT;
        //    public static delProgramUniform2dEXT glProgramUniform2dEXT;
        //    public static delProgramUniform3dEXT glProgramUniform3dEXT;
        //    public static delProgramUniform4dEXT glProgramUniform4dEXT;
        //    public static delProgramUniform1dvEXT glProgramUniform1dvEXT;
        //    public static delProgramUniform2dvEXT glProgramUniform2dvEXT;
        //    public static delProgramUniform3dvEXT glProgramUniform3dvEXT;
        //    public static delProgramUniform4dvEXT glProgramUniform4dvEXT;

        //    public static delProgramUniformMatrix2dvEXT glProgramUniformMatrix2dvEXT;
        //    public static delProgramUniformMatrix3dvEXT glProgramUniformMatrix3dvEXT;
        //    public static delProgramUniformMatrix4dvEXT glProgramUniformMatrix4dvEXT;
        //    public static delProgramUniformMatrix2x3dvEXT glProgramUniformMatrix2x3dvEXT;
        //    public static delProgramUniformMatrix2x4dvEXT glProgramUniformMatrix2x4dvEXT;
        //    public static delProgramUniformMatrix3x2dvEXT glProgramUniformMatrix3x2dvEXT;
        //    public static delProgramUniformMatrix3x4dvEXT glProgramUniformMatrix3x4dvEXT;
        //    public static delProgramUniformMatrix4x2dvEXT glProgramUniformMatrix4x2dvEXT;
        //    public static delProgramUniformMatrix4x3dvEXT glProgramUniformMatrix4x3dvEXT;

        //    #endregion
        //}

        //#endregion

        //#region Public functions.

        //public static void ProgramUniform1dEXT(uint program, int location, double x)
        //{
        //    Delegates.glProgramUniform1dEXT(program, location, x);
        //}
        //public static void ProgramUniform2dEXT(uint program, int location, double x, double y)
        //{
        //    Delegates.glProgramUniform2dEXT(program, location, x, y);
        //}
        //public static void ProgramUniform3dEXT(uint program, int location, double x, double y, double z)
        //{
        //    Delegates.glProgramUniform3dEXT(program, location, x, y, z);
        //}
        //public static void ProgramUniform4dEXT(uint program, int location, double x, double y, double z, double w)
        //{
        //    Delegates.glProgramUniform4dEXT(program, location, x, y, z, w);
        //}
        //public static void ProgramUniform1dvEXT(uint program, int location, ref double value, int count = 1)
        //{
        //    Delegates.glProgramUniform1dvEXT(program, location, count, ref value);
        //}
        //public static void ProgramUniform2dvEXT(uint program, int location, ref double value, int count = 1)
        //{
        //    Delegates.glProgramUniform2dvEXT(program, location, count, ref value);
        //}
        //public static void ProgramUniform3dvEXT(uint program, int location, ref double value, int count = 1)
        //{
        //    Delegates.glProgramUniform3dvEXT(program, location, count, ref value);
        //}
        //public static void ProgramUniform4dvEXT(uint program, int location, ref double value, int count = 1)
        //{
        //    Delegates.glProgramUniform4dvEXT(program, location, count, ref value);
        //}

        //public static void ProgramUniformMatrix2dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix2dvEXT(program, location, count, transpose, ref value);
        //}
        //public static void ProgramUniformMatrix3dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix3dvEXT(program, location, count, transpose, ref value);
        //}
        //public static void ProgramUniformMatrix4dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix4dvEXT(program, location, count, transpose, ref value);
        //}
        //public static void ProgramUniformMatrix2x3dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix2x3dvEXT(program, location, count, transpose, ref value);
        //}
        //public static void ProgramUniformMatrix2x4dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix2x4dvEXT(program, location, count, transpose, ref value);
        //}
        //public static void ProgramUniformMatrix3x2dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix3x2dvEXT(program, location, count, transpose, ref value);
        //}
        //public static void ProgramUniformMatrix3x4dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix3x4dvEXT(program, location, count, transpose, ref value);
        //}
        //public static void ProgramUniformMatrix4x2dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix4x2dvEXT(program, location, count, transpose, ref value);
        //}
        //public static void ProgramUniformMatrix4x3dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix4x3dvEXT(program, location, count, transpose, ref value);
        //}


        //#endregion

        #region OpenGL DLLImports


        //ARB_gpu_shader_fp64
        [EntryPointSlot(97)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform1dEXT(uint program, int location, double x);
        [EntryPointSlot(98)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform2dEXT(uint program, int location, double x, double y);
        [EntryPointSlot(99)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform3dEXT(uint program, int location, double x, double y, double z);
        [EntryPointSlot(100)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniform4dEXT(uint program, int location, double x, double y, double z, double w);

        [EntryPointSlot(101)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform1dvEXT(uint program, int location, int count, double* value);
        [EntryPointSlot(102)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform2dvEXT(uint program, int location, int count, double* value);
        [EntryPointSlot(103)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform3dvEXT(uint program, int location, int count, double* value);
        [EntryPointSlot(104)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniform4dvEXT(uint program, int location, int count, double* value);

        [EntryPointSlot(105)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix2dvEXT(uint program, int location, int count, bool transpose, double* value);
        [EntryPointSlot(106)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix3dvEXT(uint program, int location, int count, bool transpose, double* value);
        [EntryPointSlot(107)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix4dvEXT(uint program, int location, int count, bool transpose, double* value);
        [EntryPointSlot(108)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix2x3dvEXT(uint program, int location, int count, bool transpose, double* value);
        [EntryPointSlot(109)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix2x4dvEXT(uint program, int location, int count, bool transpose, double* value);
        [EntryPointSlot(110)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix3x2dvEXT(uint program, int location, int count, bool transpose, double* value);
        [EntryPointSlot(111)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix3x4dvEXT(uint program, int location, int count, bool transpose, double* value);
        [EntryPointSlot(112)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix4x2dvEXT(uint program, int location, int count, bool transpose, double* value);
        [EntryPointSlot(113)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix4x3dvEXT(uint program, int location, int count, bool transpose, double* value);

        #endregion

        #region Public functions

        //[EntryPoint(FunctionName = "gl")]
        //public static void BindTexture(TextureTarget target, uint textureid) { throw new NotImplementedException(); }
        //ARB_gpu_shader_fp64
        
        [EntryPoint(FunctionName = "glProgramUniform1dEXT")]
        public static void ProgramUniform1dEXT(uint program, int location, double x){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform2dEXT")]
        public static void ProgramUniform2dEXT(uint program, int location, double x, double y){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform3dEXT")]
        public static void ProgramUniform3dEXT(uint program, int location, double x, double y, double z){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glProgramUniform4dEXT")]
        public static void ProgramUniform4dEXT(uint program, int location, double x, double y, double z, double w){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glProgramUniform1dvEXT")]
        unsafe public static void ProgramUniform1dvEXT(uint program, int location, int count, double* value){ throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glProgramUniform1dvEXT")]
        //public static void ProgramUniform1dvEXT(uint program, int location, int count, double[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform1dvEXT")]
        public static void ProgramUniform1dvEXT(uint program, int location, int count, ref double value) { throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glProgramUniform1dvEXT")]
        public static void ProgramUniform1dvEXT(uint program, int location, double[] value, int count = 1, int vindex = 0)
        {
            ProgramUniform1dvEXT(program, location, count, ref value[vindex]);
        }
        public static void ProgramUniform1dvEXT(uint program, int location, ref double value, int count = 1)
        {
            ProgramUniform1dvEXT(program, location, count, ref value);
        }


        [EntryPoint(FunctionName = "glProgramUniform2dvEXT")]
        unsafe public static void ProgramUniform2dvEXT(uint program, int location, int count, double* value){ throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "ProgramUniform2dvEXT")]
        //public static void ProgramUniform2dvEXT(uint program, int location, int count, double[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform2dvEXT")]
        public static void ProgramUniform2dvEXT(uint program, int location, int count, ref double value) { throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glProgramUniform2dvEXT")]
        public static void ProgramUniform2dvEXT(uint program, int location, double[] value, int count = 1, int vindex = 0)
        {
            Debug.Assert(value.Length >= (count * 2), "value.length needs be greater or equal to count * 2");
            ProgramUniform2dvEXT(program, location, count, ref value[vindex]);
        }
        public static void ProgramUniform2dvEXT(uint program, int location, ref double value, int count = 1)
        {
            ProgramUniform2dvEXT(program, location, count, ref value);
        }


        [EntryPoint(FunctionName = "glProgramUniform3dvEXT")]
        unsafe public static void ProgramUniform3dvEXT(uint program, int location, int count, double* value){ throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glProgramUniform3dvEXT")]
        //public static void ProgramUniform3dvEXT(uint program, int location, int count, double[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform3dvEXT")]
        public static void ProgramUniform3dvEXT(uint program, int location, int count, ref double value) { throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glProgramUniform3dvEXT")]
        public static void ProgramUniform3dvEXT(uint program, int location, double[] value, int count = 1, int vindex = 0)
        {
            Debug.Assert(value.Length >= (count * 3), "value.length needs be greater or equal to count * 3");
            ProgramUniform3dvEXT(program, location, count, ref value[vindex]);
        }
        public static void ProgramUniform3dvEXT(uint program, int location, ref double value, int count = 1)
        {
            ProgramUniform3dvEXT(program, location, count, ref value);
        }


        [EntryPoint(FunctionName = "glProgramUniform4dvEXT")]
        unsafe public static void ProgramUniform4dvEXT(uint program, int location, int count, double* value){ throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glProgramUniform4dvEXT")]
        //public static void ProgramUniform4dvEXT(uint program, int location, int count, double[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniform4dvEXT")]
        public static void ProgramUniform4dvEXT(uint program, int location, int count, ref double value) { throw new NotImplementedException(); }
        //[EntryPoint(FunctionName = "glProgramUniform4dvEXT")]
        public static void ProgramUniform4dvEXT(uint program, int location, double[] value, int count = 1, int vindex = 0)
        {
            Debug.Assert(value.Length >= (count * 4), "value.length needs be greater or equal to count * 4");
            ProgramUniform4dvEXT(program, location, count, ref value[vindex]);
        }
        public static void ProgramUniform4dvEXT(uint program, int location, ref double value, int count = 1)
        {
            ProgramUniform4dvEXT(program, location, count, ref value);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix2dvEXT")]
        unsafe public static void ProgramUniformMatrix2dvEXT(uint program, int location, int count, bool transpose, double* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2dvEXT")]
        public static void ProgramUniformMatrix2dvEXT(uint program, int location, int count, bool transpose, double[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2dvEXT")]
        public static void ProgramUniformMatrix2dvEXT(uint program, int location, int count, bool transpose, ref double value) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix2dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2dvEXT(program, location, count, transpose, ref value);
        }
        public static void ProgramUniformMatrix2dvEXT(uint program, int location, double[] value, int count = 1, bool transpose = false, int vindex = 0)
        {
            Debug.Assert(value.Length >= (count * 4), "value.length needs be greater or equal to count * 4");
            ProgramUniformMatrix2dvEXT(program, location, count, transpose, ref value[vindex]);
        }


        [EntryPoint(FunctionName = "glProgramUniformMatrix3dvEXT")]
        unsafe public static void ProgramUniformMatrix3dvEXT(uint program, int location, int count, bool transpose, double* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3dvEXT")]
        public static void ProgramUniformMatrix3dvEXT(uint program, int location, int count, bool transpose, double[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3dvEXT")]
        public static void ProgramUniformMatrix3dvEXT(uint program, int location, int count, bool transpose, ref double value) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix3dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3dvEXT(program, location, count, transpose, ref value);
        }
        public static void ProgramUniformMatrix3dvEXT(uint program, int location, double[] value, int count = 1, bool transpose = false, int vindex = 0)
        {
            Debug.Assert(value.Length >= (count * 9), "value.length needs be greater or equal to count * 9");
            ProgramUniformMatrix3dvEXT(program, location, count, transpose, ref value[vindex]);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix4dvEXT")]
        unsafe public static void ProgramUniformMatrix4dvEXT(uint program, int location, int count, bool transpose, double* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4dvEXT")]
        public static void ProgramUniformMatrix4dvEXT(uint program, int location, int count, bool transpose, double[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4dvEXT")]
        public static void ProgramUniformMatrix4dvEXT(uint program, int location, int count, bool transpose, ref double value) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix4dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4dvEXT(program, location, count, transpose, ref value);
        }
        public static void ProgramUniformMatrix4dvEXT(uint program, int location, double[] value, int count = 1, bool transpose = false, int vindex = 0)
        {
            Debug.Assert(value.Length >= (count * 16), "value.length needs be greater or equal to count * 16");
            ProgramUniformMatrix4dvEXT(program, location, count, transpose, ref value[vindex]);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix2x3dvEXT")]
        unsafe public static void ProgramUniformMatrix2x3dvEXT(uint program, int location, int count, bool transpose, double* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x3dvEXT")]
        public static void ProgramUniformMatrix2x3dvEXT(uint program, int location, int count, bool transpose, double[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x3dvEXT")]
        public static void ProgramUniformMatrix2x3dvEXT(uint program, int location, int count, bool transpose, ref double value) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix2x3dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2x3dvEXT(program, location, count, transpose, ref value);
        }
        public static void ProgramUniformMatrix2x3dvEXT(uint program, int location, double[] value, int count = 1, bool transpose = false, int vindex = 0)
        {
            Debug.Assert(value.Length >= (count * 6), "value.length needs be greater or equal to count * 6");
            ProgramUniformMatrix2x3dvEXT(program, location, count, transpose, ref value[vindex]);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix2x4dvEXT")]
        unsafe public static void ProgramUniformMatrix2x4dvEXT(uint program, int location, int count, bool transpose, double* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x4dvEXT")]
        public static void ProgramUniformMatrix2x4dvEXT(uint program, int location, int count, bool transpose, double[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x4dvEXT")]
        public static void ProgramUniformMatrix2x4dvEXT(uint program, int location, int count, bool transpose, ref double value) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix2x4dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix2x4dvEXT(program, location, count, transpose, ref value);
        }
        public static void ProgramUniformMatrix2x4dvEXT(uint program, int location, double[] value, int count = 1, bool transpose = false, int vindex = 0)
        {
            Debug.Assert(value.Length >= (count * 8), "value.length needs be greater or equal to count * 8");
            ProgramUniformMatrix2x4dvEXT(program, location, count, transpose, ref value[vindex]);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix3x2dvEXT")]
        unsafe public static void ProgramUniformMatrix3x2dvEXT(uint program, int location, int count, bool transpose, double* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x2dvEXT")]
        public static void ProgramUniformMatrix3x2dvEXT(uint program, int location, int count, bool transpose, double[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x2dvEXT")]
        public static void ProgramUniformMatrix3x2dvEXT(uint program, int location, int count, bool transpose, ref double value) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix3x2dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3x2dvEXT(program, location, count, transpose, ref value);
        }
        public static void ProgramUniformMatrix3x2dvEXT(uint program, int location, double[] value, int count = 1, bool transpose = false, int vindex = 0)
        {
            Debug.Assert(value.Length >= (count * 6), "value.length needs be greater or equal to count * 6");
            ProgramUniformMatrix3x2dvEXT(program, location, count, transpose, ref value[vindex]);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix3x4dvEXT")]
        unsafe public static void ProgramUniformMatrix3x4dvEXT(uint program, int location, int count, bool transpose, double* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x4dvEXT")]
        public static void ProgramUniformMatrix3x4dvEXT(uint program, int location, int count, bool transpose, double[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x2dvEXT")]
        public static void ProgramUniformMatrix3x4dvEXT(uint program, int location, int count, bool transpose, ref double value) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix3x4dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix3x4dvEXT(program, location, count, transpose, ref value);
        }
        public static void ProgramUniformMatrix3x4dvEXT(uint program, int location, double[] value, int count = 1, bool transpose = false, int vindex = 0)
        {
            Debug.Assert(value.Length >= (count * 12), "value.length needs be greater or equal to count * 12");
            ProgramUniformMatrix3x4dvEXT(program, location, count, transpose, ref value[vindex]);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix4x2dvEXT")]
        unsafe public static void ProgramUniformMatrix4x2dvEXT(uint program, int location, int count, bool transpose, double* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x2dvEXT")]
        public static void ProgramUniformMatrix4x2dvEXT(uint program, int location, int count, bool transpose, double[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x2dvEXT")]
        public static void ProgramUniformMatrix4x2dvEXT(uint program, int location, int count, bool transpose, ref double value) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix4x2dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4x2dvEXT(program, location, count, transpose, ref value);
        }
        public static void ProgramUniformMatrix4x2dvEXT(uint program, int location, double[] value, int count = 1, bool transpose = false, int vindex = 0)
        {
            Debug.Assert(value.Length >= (count * 8), "value.length needs be greater or equal to count * 8");
            ProgramUniformMatrix4x2dvEXT(program, location, count, transpose, ref value[vindex]);
        }

        [EntryPoint(FunctionName = "glProgramUniformMatrix4x3dvEXT")]
        unsafe public static void ProgramUniformMatrix4x3dvEXT(uint program, int location, int count, bool transpose, double* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x3dvEXT")]
        public static void ProgramUniformMatrix4x3dvEXT(uint program, int location, int count, bool transpose, double[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x3dvEXT")]
        public static void ProgramUniformMatrix4x3dvEXT(uint program, int location, int count, bool transpose, ref double value) { throw new NotImplementedException(); }
        public static void ProgramUniformMatrix4x3dvEXT(uint program, int location, ref double value, int count = 1, bool transpose = false)
        {
            ProgramUniformMatrix4x3dvEXT(program, location, count, transpose, ref value);
        }
        public static void ProgramUniformMatrix4x3dvEXT(uint program, int location, double[] value, int count = 1, bool transpose = false, int vindex = 0)
        {
            Debug.Assert(value.Length >= (count * 12), "value.length needs be greater or equal to count * 12");
            ProgramUniformMatrix4x3dvEXT(program, location, count, transpose, ref value[vindex]);
        }


        #endregion

        #region Public Helper Functions

        #endregion

    }
}
