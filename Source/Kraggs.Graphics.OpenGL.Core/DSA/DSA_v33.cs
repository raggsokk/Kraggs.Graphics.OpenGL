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

        //    //ARB_instanced_arrays
        //    public delegate void delVertexArrayVertexAttribDivisorEXT(uint vaobj, uint index, uint divisor);

        //    #endregion

        //    #region GL Fields

        //    public static delVertexArrayVertexAttribDivisorEXT glVertexArrayVertexAttribDivisorEXT;

        //    #endregion
        //}

        //#endregion

        //#region Public functions.

        ///// <summary>
        ///// Sets the divisor for an Attribute Index on named VertexArrayObject.
        ///// If the divisor is zero, the corresponding attributesadvance once per vertex. Otherwise, attributes advance once per divisor instances of the set(s) of vertices being rendered. A generic attribute is referred to as in-stanced if its corresponding divisor value is non-zero.
        ///// </summary>
        ///// <param name="vaobj">id of VertexArrayObject to set divisor for.</param>
        ///// <param name="index">AttributeIndex to set divisor for.</param>
        ///// <param name="divisor">Divisor.</param>
        //public static void VertexArrayVertexAttribDivisorEXT(uint vaobj, uint index, uint divisor)
        //{
        //    Delegates.glVertexArrayVertexAttribDivisorEXT(vaobj, index, divisor);
        //}

        //#endregion
    }
}
