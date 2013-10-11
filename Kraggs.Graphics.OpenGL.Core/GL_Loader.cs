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
using System.Reflection;

namespace Kraggs.Graphics.OpenGL
{
    partial class GL : absOpenTKDllImportLoader
    {
        public GL() : base(typeof(GL))
        {}

        //private readonly Type pDllImportClass;
        //private readonly SortedList<string, MethodInfo> pDllImportMap;

        //public GL()
        //{
        //    pDllImportClass = typeof(GL).GetNestedType("DllImports", BindingFlags.Public | BindingFlags.NonPublic);

        //    var funcs = pDllImportClass.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

        //    if (funcs == null)
        //        throw new InvalidOperationException("Failed to find any static functions in DllImports??");

        //    pDllImportMap = new SortedList<string, MethodInfo>();

        //    foreach (var m in funcs)
        //        pDllImportMap.Add(m.Name, m);
        //}

        //public override void Initialize(IGetProcAddress GetProcAddress = null)
        //{
        //    if (GetProcAddress == null)
        //        GetProcAddress = sGetProcAddress;


        //}
    }
}
