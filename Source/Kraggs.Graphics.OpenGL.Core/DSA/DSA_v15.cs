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

        //    public delegate void delNamedBufferDataEXT(uint BufferID, IntPtr size, IntPtr data, BufferUsage usage);
        //    public delegate void delNamedBufferSubDataEXT(uint BufferID, IntPtr Offset, IntPtr Size, IntPtr Data);
        //    public delegate IntPtr delMapNamedBufferEXT(uint BufferID, MapBufferAccess access);
        //    public delegate bool delUnmapNamedBufferEXT(uint BufferID);

        //    public delegate void delGetNamedBufferParameterivEXT(uint BufferID, BufferParameters pname, ref int @params);
        //    public delegate void delGetNamedBufferPointervEXT(uint BufferID, BufferPointerParameters pname, out IntPtr ptr);
        //    public delegate void delGetNamedBufferSubDataEXT(uint BufferID, IntPtr Offset, IntPtr Size, IntPtr data);

        //    #endregion

        //    #region GL Fields

        //    public static delNamedBufferDataEXT glNamedBufferDataEXT;
        //    public static delNamedBufferSubDataEXT glNamedBufferSubDataEXT;

        //    public static delMapNamedBufferEXT glMapNamedBufferEXT;
        //    public static delUnmapNamedBufferEXT glUnmapNamedBufferEXT;
        //    public static delGetNamedBufferParameterivEXT glGetNamedBufferParameterivEXT;
        //    public static delGetNamedBufferPointervEXT glGetNamedBufferPointervEXT;
        //    public static delGetNamedBufferSubDataEXT glGetNamedBufferSubDataEXT;

        //    #endregion
        //}

        //#endregion

        //#region Public functions.

        //public static void NamedBufferData(uint BufferID, IntPtr size, IntPtr data, BufferUsage usage)
        //{
        //    Delegates.glNamedBufferDataEXT(BufferID, size, data, usage);
        //}
        //public static void NamedBufferData(uint BufferID, long size, IntPtr data, BufferUsage usage)
        //{
        //    Delegates.glNamedBufferDataEXT(BufferID, (IntPtr)size, data, usage);
        //}

        //public static void NamedBufferSubData(uint BufferID, IntPtr Offset, IntPtr Size, IntPtr Data)
        //{
        //    Delegates.glNamedBufferSubDataEXT(BufferID, Offset, Size, Data);
        //}
        //public static void NamedBufferSubData(uint BufferID, long Offset, long Size, IntPtr Data)
        //{
        //    Delegates.glNamedBufferSubDataEXT(BufferID, (IntPtr)Offset, (IntPtr)Size, Data);
        //}

        //public static IntPtr MapNamedBufferEXT(uint BufferID, MapBufferAccess access)
        //{
        //    return Delegates.glMapNamedBufferEXT(BufferID, access);
        //}
        //public static bool UnmapNamedBufferEXT(uint BufferID)
        //{
        //    return Delegates.glUnmapNamedBufferEXT(BufferID);
        //}

        //public static void GetNamedBufferParameterivEXT(uint BufferID, BufferParameters pname, int[] @params)
        //{
        //    Delegates.glGetNamedBufferParameterivEXT(BufferID, pname, ref @params[0]);
        //}
        //public static int GetNamedBufferParameterivEXT(uint BufferID, BufferParameters pname)
        //{
        //    int tmp = 0;
        //    Delegates.glGetNamedBufferParameterivEXT(BufferID, pname, ref tmp);
        //    return tmp;
        //}

        //public static void GetNamedBufferPointervEXT(uint BufferID, BufferPointerParameters pname, out IntPtr ptr)
        //{
        //    Delegates.glGetNamedBufferPointervEXT(BufferID, pname, out ptr);
        //}
        //public static IntPtr GetNamedBufferPointervEXT(uint BufferID, BufferPointerParameters pname)
        //{
        //    IntPtr ptr;
        //    Delegates.glGetNamedBufferPointervEXT(BufferID, pname, out ptr);
        //    return ptr;
        //}

        //public static void GetNamedBufferSubDataEXT(uint BufferID, IntPtr Offset, IntPtr Size, IntPtr data)
        //{
        //    Delegates.glGetNamedBufferSubDataEXT(BufferID, Offset, Size, data);
        //}
        //public static void GetNamedBufferSubDataEXT(uint BufferID, long Offset, long Size, IntPtr data)
        //{
        //    Delegates.glGetNamedBufferSubDataEXT(BufferID, (IntPtr)Offset, (IntPtr)Size, data);
        //}

        //#endregion
    }
}
