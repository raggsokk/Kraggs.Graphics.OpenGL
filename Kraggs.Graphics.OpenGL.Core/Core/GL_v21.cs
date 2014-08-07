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
        //#region Delegate Class

        //partial class Delegates
        //{

        //    #region Delegates

        //    public delegate void delUniformMatrix2x3fv(int location, int count, bool transpose, ref float value);
        //    public delegate void delUniformMatrix2x4fv(int location, int count, bool transpose, ref float value);

        //    public delegate void delUniformMatrix3x2fv(int location, int count, bool transpose, ref float value);
        //    public delegate void delUniformMatrix3x4fv(int location, int count, bool transpose, ref float value);

        //    public delegate void delUniformMatrix4x2fv(int location, int count, bool transpose, ref float value);
        //    public delegate void delUniformMatrix4x3fv(int location, int count, bool transpose, ref float value);


        //    #endregion

        //    #region GL Fields

        //    public static delUniformMatrix2x3fv glUniformMatrix2x3fv;
        //    public static delUniformMatrix2x4fv glUniformMatrix2x4fv;

        //    public static delUniformMatrix3x2fv glUniformMatrix3x2fv;
        //    public static delUniformMatrix3x4fv glUniformMatrix3x4fv;

        //    public static delUniformMatrix4x2fv glUniformMatrix4x2fv;
        //    public static delUniformMatrix4x3fv glUniformMatrix4x3fv;

        //    #endregion
        //}

        //#endregion

        //#region Public functions.

        ///// <summary>
        ///// Specify the value of a uniform variable for the current program object
        ///// </summary>
        ///// <param name="location">Specifies the location of the uniform value to be modified.</param>
        ///// <param name="value">Specifies the first float of a matrix struct of hopefully correct size.</param>
        ///// <param name="count">Specifies the number of matrices that are to be modified. This should be 1 if the targeted uniform variable is not an array of matrices, and 1 or more if it is an array of matrices.</param>
        ///// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        //public static void UniformMatrix2x3fv(int location, ref float value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glUniformMatrix2x3fv(location, count, transpose, ref value);
        //}

        ///// <summary>
        ///// Specify the value of a uniform variable for the current program object
        ///// </summary>
        ///// <param name="location">Specifies the location of the uniform value to be modified.</param>
        ///// <param name="value">Specifies the first float of a matrix struct of hopefully correct size.</param>
        ///// <param name="count">Specifies the number of matrices that are to be modified. This should be 1 if the targeted uniform variable is not an array of matrices, and 1 or more if it is an array of matrices.</param>
        ///// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        //public static void UniformMatrix2x4fv(int location, ref float value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glUniformMatrix2x4fv(location, count, transpose, ref value);
        //}

        ///// <summary>
        ///// Specify the value of a uniform variable for the current program object
        ///// </summary>
        ///// <param name="location">Specifies the location of the uniform value to be modified.</param>
        ///// <param name="value">Specifies the first float of a matrix struct of hopefully correct size.</param>
        ///// <param name="count">Specifies the number of matrices that are to be modified. This should be 1 if the targeted uniform variable is not an array of matrices, and 1 or more if it is an array of matrices.</param>
        ///// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        //public static void UniformMatrix3x2v(int location, ref float value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glUniformMatrix3x2fv(location, count, transpose, ref value);
        //}
        ///// <summary>
        ///// Specify the value of a uniform variable for the current program object
        ///// </summary>
        ///// <param name="location">Specifies the location of the uniform value to be modified.</param>
        ///// <param name="value">Specifies the first float of a matrix struct of hopefully correct size.</param>
        ///// <param name="count">Specifies the number of matrices that are to be modified. This should be 1 if the targeted uniform variable is not an array of matrices, and 1 or more if it is an array of matrices.</param>
        ///// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        //public static void UniformMatrix3x4v(int location, ref float value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glUniformMatrix3x4fv(location, count, transpose, ref value);
        //}

        ///// <summary>
        ///// Specify the value of a uniform variable for the current program object
        ///// </summary>
        ///// <param name="location">Specifies the location of the uniform value to be modified.</param>
        ///// <param name="value">Specifies the first float of a matrix struct of hopefully correct size.</param>
        ///// <param name="count">Specifies the number of matrices that are to be modified. This should be 1 if the targeted uniform variable is not an array of matrices, and 1 or more if it is an array of matrices.</param>
        ///// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        //public static void UniformMatrix4x2v(int location, ref float value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glUniformMatrix4x2fv(location, count, transpose, ref value);
        //}
        ///// <summary>
        ///// Specify the value of a uniform variable for the current program object
        ///// </summary>
        ///// <param name="location">Specifies the location of the uniform value to be modified.</param>
        ///// <param name="value">Specifies the first float of a matrix struct of hopefully correct size.</param>
        ///// <param name="count">Specifies the number of matrices that are to be modified. This should be 1 if the targeted uniform variable is not an array of matrices, and 1 or more if it is an array of matrices.</param>
        ///// <param name="transpose">Specifies whether to transpose the matrix as the values are loaded into the uniform variable.</param>
        //public static void UniformMatrix4x3v(int location, ref float value, int count = 1, bool transpose = false)
        //{
        //    Delegates.glUniformMatrix4x3fv(location, count, transpose, ref value);
        //}


        //#endregion
    }
}
