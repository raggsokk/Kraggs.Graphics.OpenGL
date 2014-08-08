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

        //    public delegate void delProgramUniform1fEXT(uint ProgramID, uint location, float v1);
        //    public delegate void delProgramUniform1iEXT(uint ProgramID, uint location, int v1);

        //    public delegate void delProgramUniform2fEXT(uint ProgramID, uint location, float v1, float v2);
        //    public delegate void delProgramUniform2iEXT(uint ProgramID, uint location, int v1, int v2);

        //    public delegate void delProgramUniform3fEXT(uint ProgramID, uint location, float v1, float v2, float v3);
        //    public delegate void delProgramUniform3iEXT(uint ProgramID, uint location, int v1, int v2, int v3);

        //    public delegate void delProgramUniform4fEXT(uint ProgramID, uint location, float v1, float v2, float v3, float v4);
        //    public delegate void delProgramUniform4iEXT(uint ProgramID, uint location, int v1, int v2, int v3, int v4);

        //    public delegate void delProgramUniform1fvEXT(uint ProgramID, uint location, int count, ref float v);
        //    public delegate void delProgramUniform1ivEXT(uint ProgramID, uint location, int count, ref int v);

        //    public delegate void delProgramUniform2fvEXT(uint ProgramID, uint location, int count, ref float v);
        //    public delegate void delProgramUniform2ivEXT(uint ProgramID, uint location, int count, ref int v);

        //    public delegate void delProgramUniform3fvEXT(uint ProgramID, uint location, int count, ref float v);
        //    public delegate void delProgramUniform3ivEXT(uint ProgramID, uint location, int count, ref int v);

        //    public delegate void delProgramUniform4fvEXT(uint ProgramID, uint location, int count, ref float v);
        //    public delegate void delProgramUniform4ivEXT(uint ProgramID, uint location, int count, ref int v);

        //    public delegate void delProgramUniformMatrix2fvEXT(uint ProgramID, uint location, int count, bool transpose, ref float matrix);
        //    public delegate void delProgramUniformMatrix3fvEXT(uint ProgramID, uint location, int count, bool transpose, ref float matrix);
        //    public delegate void delProgramUniformMatrix4fvEXT(uint ProgramID, uint location, int count, bool transpose, ref float matrix);

        //    #endregion

        //    #region GL Fields

        //    public static delProgramUniform1fEXT glProgramUniform1fEXT;
        //    public static delProgramUniform1iEXT glProgramUniform1iEXT;

        //    public static delProgramUniform2fEXT glProgramUniform2fEXT;
        //    public static delProgramUniform2iEXT glProgramUniform2iEXT;

        //    public static delProgramUniform3fEXT glProgramUniform3fEXT;
        //    public static delProgramUniform3iEXT glProgramUniform3iEXT;

        //    public static delProgramUniform4fEXT glProgramUniform4fEXT;
        //    public static delProgramUniform4iEXT glProgramUniform4iEXT;

        //    public static delProgramUniform1fvEXT glProgramUniform1fvEXT;
        //    public static delProgramUniform1ivEXT glProgramUniform1ivEXT;

        //    public static delProgramUniform2fvEXT glProgramUniform2fvEXT;
        //    public static delProgramUniform2ivEXT glProgramUniform2ivEXT;

        //    public static delProgramUniform3fvEXT glProgramUniform3fvEXT;
        //    public static delProgramUniform3ivEXT glProgramUniform3ivEXT;

        //    public static delProgramUniform4fvEXT glProgramUniform4fvEXT;
        //    public static delProgramUniform4ivEXT glProgramUniform4ivEXT;

        //    public static delProgramUniformMatrix2fvEXT glProgramUniformMatrix2fvEXT;
        //    public static delProgramUniformMatrix3fvEXT glProgramUniformMatrix3fvEXT;
        //    public static delProgramUniformMatrix4fvEXT glProgramUniformMatrix4fvEXT;

        //    #endregion
        //}

        //#endregion

        //#region Public functions.

        //public static void ProgramUniform1fEXT(uint ProgramID, uint location, float v1)
        //{
        //    Delegates.glProgramUniform1fEXT(ProgramID, location, v1);
        //}
        //public static void ProgramUniform1iEXT(uint ProgramID, uint location, int v1)
        //{
        //    Delegates.glProgramUniform1iEXT(ProgramID, location, v1);
        //}

        //public static void ProgramUniform2fEXT(uint ProgramID, uint location, float v1, float v2)
        //{
        //    Delegates.glProgramUniform2fEXT(ProgramID, location, v1, v2);
        //}
        //public static void ProgramUniform2iEXT(uint ProgramID, uint location, int v1, int v2)
        //{
        //    Delegates.glProgramUniform2iEXT(ProgramID, location, v1, v2);
        //}

        //public static void ProgramUniform3fEXT(uint ProgramID, uint location, float v1, float v2, float v3)
        //{
        //    Delegates.glProgramUniform3fEXT(ProgramID, location, v1, v2, v3);
        //}
        //public static void ProgramUniform3iEXT(uint ProgramID, uint location, int v1, int v2, int v3)
        //{
        //    Delegates.glProgramUniform3iEXT(ProgramID, location, v1, v2, v3);
        //}

        //public static void ProgramUniform4fEXT(uint ProgramID, uint location, float v1, float v2, float v3, float v4)
        //{
        //    Delegates.glProgramUniform4fEXT(ProgramID, location, v1, v2, v3, v4);
        //}
        //public static void ProgramUniform4iEXT(uint ProgramID, uint location, int v1, int v2, int v3, int v4)
        //{
        //    Delegates.glProgramUniform4iEXT(ProgramID, location, v1, v2, v3, v4);
        //}

        //public static void ProgramUniform1fvEXT(uint ProgramID, uint location, ref float v, int count = 1)
        //{
        //    Delegates.glProgramUniform1fvEXT(ProgramID, location, count, ref v);
        //}
        //public static void ProgramUniform1ivEXT(uint ProgramID, uint location, ref int v, int count = 1)
        //{
        //    Delegates.glProgramUniform1ivEXT(ProgramID, location, count, ref v);
        //}

        //public static void ProgramUniform2fvEXT(uint ProgramID, uint location, ref float v, int count = 1)
        //{
        //    Delegates.glProgramUniform2fvEXT(ProgramID, location, count, ref v);
        //}
        //public static void ProgramUniform2ivEXT(uint ProgramID, uint location, ref int v, int count = 1)
        //{
        //    Delegates.glProgramUniform2ivEXT(ProgramID, location, count, ref v);
        //}

        //public static void ProgramUniform3fvEXT(uint ProgramID, uint location, ref float v, int count = 1)
        //{
        //    Delegates.glProgramUniform3fvEXT(ProgramID, location, count, ref v);
        //}
        //public static void ProgramUniform3ivEXT(uint ProgramID, uint location, ref int v, int count = 1)
        //{
        //    Delegates.glProgramUniform3ivEXT(ProgramID, location, count, ref v);
        //}

        //public static void ProgramUniform4fvEXT(uint ProgramID, uint location, ref float v, int count = 1)
        //{
        //    Delegates.glProgramUniform4fvEXT(ProgramID, location, count, ref v);
        //}
        //public static void ProgramUniform4ivEXT(uint ProgramID, uint location, ref int v, int count = 1)
        //{
        //    Delegates.glProgramUniform4ivEXT(ProgramID, location, count, ref v);
        //}

        ////public static void ProgramUniformMatrix2fvEXT(uint ProgramID, uint location, int count, bool transpose, ref float matrix)
        ////{
        ////    Delegates.glProgramUniformMatrix2fvEXT(ProgramID, location, count, transpose, ref matrix);
        ////}
        //public static void ProgramUniformMatrix2fvEXT(uint ProgramID, uint location, ref float matrix, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix2fvEXT(ProgramID, location, count, transpose, ref matrix);
        //}

        ////public static void ProgramUniformMatrix3fvEXT(uint ProgramID, uint location, int count, bool transpose, ref float matrix)
        ////{
        ////    Delegates.glProgramUniformMatrix3fvEXT(ProgramID, location, count, transpose, ref matrix);
        ////}
        //public static void ProgramUniformMatrix3fvEXT(uint ProgramID, uint location, ref float matrix, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix3fvEXT(ProgramID, location, count, transpose, ref matrix);
        //}

        ////public static void ProgramUniformMatrix4fvEXT(uint ProgramID, uint location, int count, bool transpose, ref float matrix)
        ////{
        ////    Delegates.glProgramUniformMatrix4fvEXT(ProgramID, location, count, transpose, ref matrix);
        ////}
        //public static void ProgramUniformMatrix4fvEXT(uint ProgramID, uint location, ref float matrix, int count = 1, bool transpose = false)
        //{
        //    Delegates.glProgramUniformMatrix4fvEXT(ProgramID, location, count, transpose, ref matrix);
        //}


        //#endregion
    }
}
