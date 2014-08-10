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

        [EntryPointSlot(20)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glNamedStringARB(NamedStringEnumARB type, int namelen, string name, int stringlen, string source);
        [EntryPointSlot(21)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDeleteNamedStringARB(int namelen, string name);

        [EntryPointSlot(22)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glCompileShaderIncludeARB(uint shader, int count, string[] searchpaths, int* length);

        [EntryPointSlot(23)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern bool glIsNamedStringARB(int namelen, string name);
        [EntryPointSlot(24)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetNamedStringARB(int namelen, string name, int bufSize, out int stringlen, IntPtr source);
        [EntryPointSlot(25)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetNamedStringivARB(int namelen, string name, GetNamedStringIndexedARB pname, int* result);

        #endregion

        #region Public functions

        
        [EntryPoint(FunctionName = "glNamedStringARB")]
        public static void NamedStringARB(NamedStringEnumARB type, int namelen, string name, int stringlen, string source){ throw new NotImplementedException(); }


        /// <summary>
        /// Arbitrary strings may be defined and given names. These strings can be included by name in shaders during compilation, allowing reuse of the same code segments.
        /// name must begin with the character '/'.
        /// </summary>
        /// <param name="type">must be SHADER_INCLUDE_ARB.</param>
        /// <param name="name">defines the name associated with the string. must begin with the character '/'.</param>
        /// <param name="source">is an arbitrary string of characters.</param>
        public static void NamedStringARB(NamedStringEnumARB type, string name, string source)
        {
            //NamedStringARB(type, name.Length, name, source.Length, source);
            // null terminated string.
            NamedStringARB(type, -1, name, -1, source);
        }

        [EntryPoint(FunctionName = "glDeleteNamedStringARB")]
        public static void DeleteNamedStringARB(int namelen, string name){ throw new NotImplementedException(); }
        /// <summary>
        /// To delete a named string
        /// </summary>
        /// <param name="name"></param>
        public static void DeleteNamedStringARB(string name)
        {
            // null terminated string.
            DeleteNamedStringARB(-1, name);
        }

        [EntryPoint(FunctionName = "glCompileShaderIncludeARB")]
        unsafe public static void CompileShaderIncludeARB(uint shader, int count, string[] searchpaths, int* length){ throw new NotImplementedException(); }

        /// <summary>
        /// Once the source code for a shader has been loaded, a shader object can be compiled with the command
        /// </summary>
        /// <param name="shader"></param>
        /// <param name="searchpaths"></param>
        unsafe public static void CompileShaderIncludeARB(uint shader, string[] searchpaths)
        {
            if (searchpaths == null || searchpaths.Length == 0)
                GL.CompileShader(shader);
            else
            {
                // null terminated string.
                CompileShaderIncludeARB(shader, searchpaths.Length, searchpaths, null);
            }
        }

        [EntryPoint(FunctionName = "glIsNamedStringARB")]
        public static bool IsNamedStringARB(int namelen, string name){ throw new NotImplementedException(); }
        /// <summary>
        /// returns TRUE if the tree location corresponding to 'name' has a string associated with it, and FALSE if the tree location has no string associated with it.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool IsNamedStringARB(string name)
        {
            // null terminated string.
            return IsNamedStringARB(-1, name);
        }

        [EntryPoint(FunctionName = "glGetNamedStringARB")]
        public static void GetNamedStringARB(int namelen, string name, int bufSize, out int stringlen, StringBuilder source){ throw new NotImplementedException(); }
        /// <summary>
        /// returns the string corresponding to the specified 'name'.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetNamedStringARB(string name)
        {
            var len = GetNamedStringivARB(name, GetNamedStringIndexedARB.LengthARB);

            var sb = new StringBuilder(len + 4);
            GetNamedStringARB(-1, name, sb.Capacity - 2, out len, sb);

            return sb.ToString();
        }

        [EntryPoint(FunctionName = "glGetNamedStringivARB")]
        unsafe public static void GetNamedStringivARB(int namelen, string name, GetNamedStringIndexedARB pname, int* result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedStringivARB")]
        public static void GetNamedStringivARB(int namelen, string name, GetNamedStringIndexedARB pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetNamedStringivARB")]
        public static void GetNamedStringivARB(int namelen, string name, GetNamedStringIndexedARB pname, ref int result) { throw new NotImplementedException(); }

        /// <summary>
        /// returns properties of the named string whose tree location corresponds to<name>.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pname"></param>
        /// <returns></returns>
        public static int GetNamedStringivARB(string name, GetNamedStringIndexedARB pname)
        {
            int t = 0;
            GetNamedStringivARB(-1, name, pname, ref t);
            return t;
        }

        #endregion

        #region Public Helper Functions

        #endregion
    }
}
