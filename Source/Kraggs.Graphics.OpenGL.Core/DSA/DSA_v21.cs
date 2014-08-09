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
    // template class until gl 4.4 where its not neede for another year.
    partial class GL
    {
        //#region Delegate Class

        //partial class Delegates
        //{

        //    #region Delegates

        //    public delegate void delProgramUniformMatrix2x3fvEXT(uint ProgramID, int location, int count, bool transpose, ref float value);
        //    public delegate void delProgramUniformMatrix2x4fvEXT(uint ProgramID, int location, int count, bool transpose, ref float value);

        //    public delegate void delProgramUniformMatrix3x2fvEXT(uint ProgramID, int location, int count, bool transpose, ref float value);
        //    public delegate void delProgramUniformMatrix3x4fvEXT(uint ProgramID, int location, int count, bool transpose, ref float value);

        //    public delegate void delProgramUniformMatrix4x2fvEXT(uint ProgramID, int location, int count, bool transpose, ref float value);
        //    public delegate void delProgramUniformMatrix4x3fvEXT(uint ProgramID, int location, int count, bool transpose, ref float value);

        //    #endregion

        //    #region GL Fields

        //    public static delProgramUniformMatrix2x3fvEXT glProgramUniformMatrix2x3fvEXT;
        //    public static delProgramUniformMatrix2x4fvEXT glProgramUniformMatrix2x4fvEXT;

        //    public static delProgramUniformMatrix3x2fvEXT glProgramUniformMatrix3x2fvEXT;
        //    public static delProgramUniformMatrix3x4fvEXT glProgramUniformMatrix3x4fvEXT;

        //    public static delProgramUniformMatrix4x2fvEXT glProgramUniformMatrix4x2fvEXT;
        //    public static delProgramUniformMatrix4x3fvEXT glProgramUniformMatrix4x3fvEXT;


        //    #endregion
        //}

        //#endregion

        //#region Public functions.

        //public static void ProgramUniformMatrix2x3fvEXT(uint ProgramID, int location, ref float value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix2x3fvEXT(ProgramID, location, count, transpose, ref value);
        //}
        //public static void ProgramUniformMatrix2x4fvEXT(uint ProgramID, int location, ref float value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix2x4fvEXT(ProgramID, location, count, transpose, ref value);
        //}

        //public static void ProgramUniformMatrix3x2fvEXT(uint ProgramID, int location, ref float value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix3x2fvEXT(ProgramID, location, count, transpose, ref value);
        //}
        //public static void ProgramUniformMatrix3x4fvEXT(uint ProgramID, int location, ref float value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix3x4fvEXT(ProgramID, location, count, transpose, ref value);
        //}

        //public static void ProgramUniformMatrix4x2fvEXT(uint ProgramID, int location, ref float value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix4x2fvEXT(ProgramID, location, count, transpose, ref value);
        //}
        //public static void ProgramUniformMatrix4x3fvEXT(uint ProgramID, int location, ref float value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix4x3fvEXT(ProgramID, location, count, transpose, ref value);
        //}


        //#endregion

        #region OpenGL DLLImports


        [EntryPointSlot(51)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix2x3fvEXT(uint ProgramID, int location, int count, bool transpose, float* value);
        [EntryPointSlot(52)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix2x4fvEXT(uint ProgramID, int location, int count, bool transpose, float* value);

        [EntryPointSlot(53)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix3x2fvEXT(uint ProgramID, int location, int count, bool transpose, float* value);
        [EntryPointSlot(54)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix3x4fvEXT(uint ProgramID, int location, int count, bool transpose, float* value);

        [EntryPointSlot(55)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix4x2fvEXT(uint ProgramID, int location, int count, bool transpose, float* value);
        [EntryPointSlot(56)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glProgramUniformMatrix4x3fvEXT(uint ProgramID, int location, int count, bool transpose, float* value);

        #endregion

        #region Public functions

        //[EntryPoint(FunctionName = "gl")]
        //public static void BindTexture(TextureTarget target, uint textureid) { throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x3fvEXT")]
        unsafe public static void ProgramUniformMatrix2x3fvEXT(uint ProgramID, int location, int count, bool transpose, float* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x3fvEXT")]
        public static void ProgramUniformMatrix2x3fvEXT(uint ProgramID, int location, int count, bool transpose, float[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x3fvEXT")]
        public static void ProgramUniformMatrix2x3fvEXT(uint ProgramID, int location, int count, bool transpose, ref float value) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniformMatrix2x4fvEXT")]
        unsafe public static void ProgramUniformMatrix2x4fvEXT(uint ProgramID, int location, int count, bool transpose, float* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x4fvEXT")]
        public static void ProgramUniformMatrix2x4fvEXT(uint ProgramID, int location, int count, bool transpose, float[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix2x4fvEXT")]
        public static void ProgramUniformMatrix2x4fvEXT(uint ProgramID, int location, int count, bool transpose, ref float value) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glProgramUniformMatrix3x2fvEXT")]
        unsafe public static void ProgramUniformMatrix3x2fvEXT(uint ProgramID, int location, int count, bool transpose, float* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x2fvEXT")]
        public static void ProgramUniformMatrix3x2fvEXT(uint ProgramID, int location, int count, bool transpose, float[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x2fvEXT")]
        public static void ProgramUniformMatrix3x2fvEXT(uint ProgramID, int location, int count, bool transpose, ref float value) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniformMatrix3x4fvEXT")]
        unsafe public static void ProgramUniformMatrix3x4fvEXT(uint ProgramID, int location, int count, bool transpose, float* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x4fvEXT")]
        public static void ProgramUniformMatrix3x4fvEXT(uint ProgramID, int location, int count, bool transpose, float[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix3x4fvEXT")]
        public static void ProgramUniformMatrix3x4fvEXT(uint ProgramID, int location, int count, bool transpose, ref float value) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glProgramUniformMatrix4x2fvEXT")]
        unsafe public static void ProgramUniformMatrix4x2fvEXT(uint ProgramID, int location, int count, bool transpose, float* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x2fvEXT")]
        public static void ProgramUniformMatrix4x2fvEXT(uint ProgramID, int location, int count, bool transpose, float[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x2fvEXT")]
        public static void ProgramUniformMatrix4x2fvEXT(uint ProgramID, int location, int count, bool transpose, ref float value) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glProgramUniformMatrix4x3fvEXT")]
        unsafe public static void ProgramUniformMatrix4x3fvEXT(uint ProgramID, int location, int count, bool transpose, float* value){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x3fvEXT")]
        public static void ProgramUniformMatrix4x3fvEXT(uint ProgramID, int location, int count, bool transpose, float[] value) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glProgramUniformMatrix4x3fvEXT")]
        public static void ProgramUniformMatrix4x3fvEXT(uint ProgramID, int location, int count, bool transpose, ref float value) { throw new NotImplementedException(); }

        #endregion

        #region Public Helper Functions

        #endregion

    }
}
