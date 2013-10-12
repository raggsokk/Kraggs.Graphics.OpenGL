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
    // template class until gl 4.4 where its not neede for another year.
    partial class EXT
    {
        #region Delegate Class

        partial class Delegates
        {

            #region Delegates

            public delegate void delColorMaskIndexedEXT(uint buf, bool r, bool g, bool b, bool a);

            public delegate void delGetBooleanIndexedvEXT(GetParameters value, uint index, ref bool data);

            public delegate void delGetIntegerIndexedvEXT(GetParameters value, uint index, ref int data);

            public delegate void delEnableIndexedEXT(EnableStateIndexed target, uint index);

            public delegate void delDisableIndexedEXT(EnableStateIndexed target, uint index);

            public delegate bool delIsEnabledIndexedEXT(EnableStateIndexed target, uint index);  

            #endregion

            #region GL Fields

            public static delColorMaskIndexedEXT glColorMaskIndexedEXT;
            public static delGetBooleanIndexedvEXT glGetBooleanIndexedvEXT;
            public static delGetIntegerIndexedvEXT glGetIntegerIndexedvEXT;
            public static delEnableIndexedEXT glEnableIndexedEXT;
            public static delDisableIndexedEXT glDisableIndexedEXT;
            public static delIsEnabledIndexedEXT glIsEnabledIndexedEXT;

            #endregion
        }

        #endregion

        #region Public functions.

        public static void ColorMaskIndexedEXT(uint buf, bool r, bool g, bool b, bool a)
        {
            Delegates.glColorMaskIndexedEXT(buf, r, g, b, a);
        }

        public static void GetBooleanIndexedvEXT(GetParameters value, uint index, ref bool data)
        {
            Delegates.glGetBooleanIndexedvEXT(value, index, ref data);
        }

        public static void GetIntegerIndexedvEXT(GetParameters value, uint index, ref int data)
        {
            Delegates.glGetIntegerIndexedvEXT(value, index, ref data);
        }

        public static void EnableIndexedEXT(EnableStateIndexed target, uint index)
        {
            Delegates.glEnableIndexedEXT(target, index);
        }

        public static void DisableIndexedEXT(EnableStateIndexed target, uint index)
        {
            Delegates.glDisableIndexedEXT(target, index);
        }

        public static bool IsEnabledIndexedEXT(EnableStateIndexed target, uint index)
        {
            return Delegates.glIsEnabledIndexedEXT(target, index);
        }


        #endregion
    }
}
