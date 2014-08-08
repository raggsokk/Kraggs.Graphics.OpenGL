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

        //    public delegate void delVertexArrayVertexAttribLOffsetEXT(uint vaobj, uint buffer, uint index, int size, VertexAttribLFormat type, int stride, IntPtr offset); 

        //    #endregion

        //    #region GL Fields

        //    public static delVertexArrayVertexAttribLOffsetEXT glVertexArrayVertexAttribLOffsetEXT;

        //    #endregion
        //}

        //#endregion

        //#region Public functions.

        ///// <summary>
        ///// Sets up Vertex Declaration for a shader attribute variable declared with 64-bit double precision.
        ///// </summary>
        ///// <param name="vaobj">identifies a vertex array object used instead of the currently bound one</param>
        ///// <param name="buffer">buffer is used in place of the buffer object bound to ARRAY_BUFFER</param>
        ///// <param name="index">Attribute Index to declare vertex specification for.</param>
        ///// <param name="size">size may be one, two, three or four</param>
        ///// <param name="type">type must be DOUBLE</param>
        ///// <param name="stride">the length in bytes between two vertices.</param>
        ///// <param name="offset">offset in bytes in named buffer to retrive vertices from.</param>
        //public static void VertexArrayVertexAttribLOffsetEXT(uint vaobj, uint buffer, uint index, int size, VertexAttribLFormat type = VertexAttribLFormat.Double, int stride = 0, long offset = 0)
        //{
        //    Delegates.glVertexArrayVertexAttribLOffsetEXT(vaobj, buffer, index, size, type, stride, (IntPtr)offset);
        //}

        //#endregion
    }
}
