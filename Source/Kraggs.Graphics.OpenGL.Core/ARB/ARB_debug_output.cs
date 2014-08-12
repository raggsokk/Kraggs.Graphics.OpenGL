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

        [EntryPointSlot(14)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glDebugMessageControlARB(DebugSource source, DebugType type, DebugSeverity severity, int Count, uint* ids, bool Enabled);
        [EntryPointSlot(15)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDebugMessageInsertARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf);
        [EntryPointSlot(16)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDebugMessageCallbackARB(DebugMessageDelegate callback, IntPtr userParam);
        [EntryPointSlot(17)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern uint glGetDebugMessageLogARB(uint count, int bufsize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, IntPtr messageLog);
        //[EntryPointSlot(18)]
        //[DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //private static extern void glGetPointervARB(GetPointerName pname, out IntPtr ptr);

        #endregion

        #region Public functions

        //[EntryPoint(FunctionName = "gl")]
        //public static void BindTexture(TextureTarget target, uint textureid) { throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glDebugMessageControlARB")]
        unsafe public static void DebugMessageControlARB(DebugSource source, DebugType type, DebugSeverity severity, int Count, uint* ids, bool Enabled){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glDebugMessageControlARB")]
        private static void DebugMessageControlARB(DebugSource source, DebugType type, DebugSeverity severity, int Count, uint[] ids, bool Enabled) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glDebugMessageControlARB")]
        public static void DebugMessageControlARB(DebugSource source, DebugType type, DebugSeverity severity, int Count, ref uint ids, bool Enabled) { throw new NotImplementedException(); }

        public static void DebugMessageControlARB(DebugSource source, DebugType type, DebugSeverity severity, uint[] ids, bool Enabled)
        {
            DebugMessageControlARB(source, type, severity, ids != null ? ids.Length : 0, ids, Enabled);
        }

        [EntryPoint(FunctionName = "glDebugMessageInsertARB")]
        public static void DebugMessageInsertARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf){ throw new NotImplementedException(); }

        public static void DebugMessageInsertARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, string message)
        {
            DebugMessageInsertARB(source, type, id, severity, message.Length, message);
        }

        [EntryPoint(FunctionName = "glDebugMessageCallbackARB")]
        public static void DebugMessageCallbackARB(DebugMessageDelegate callback, IntPtr userParam){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetDebugMessageLogARB")]
        unsafe public static uint GetDebugMessageLogARB(uint count, int bufsize, DebugSource* sources, DebugType* types, uint* ids, DebugSeverity* severities, int* lengths, StringBuilder messageLog){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetDebugMessageLogARB")]
        public static uint GetDebugMessageLogARB(uint count, int bufsize, DebugSource[] sources, DebugType[] types, uint[] ids, DebugSeverity[] severities, int[] lengths, StringBuilder messageLog) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetDebugMessageLogARB")]
        public static uint GetDebugMessageLogARB(uint count, int bufsize, ref DebugSource sources, ref DebugType types, ref uint ids, ref DebugSeverity severities, ref int lengths, StringBuilder messageLog) { throw new NotImplementedException(); }

        public static uint GetDebugMessageLogARB(DebugSource[] sources, DebugType[] types, uint[] ids, DebugSeverity[] severities,StringBuilder messageLog)
        {
            //uint count, int bufsize,  int[] lengths, 
            var count = Math.Min(sources.Length, Math.Min(types.Length, Math.Min(ids.Length, severities.Length)));
            var lengths = new int[count];

            var ret = GetDebugMessageLogARB((uint)count, messageLog.Capacity, sources, types, ids, severities, lengths, messageLog);

            return ret;
        }

        //[EntryPoint(FunctionName = "glGetPointervARB")]
        //public static void GetPointervARB(GetPointerName pname, out IntPtr ptr){ throw new NotImplementedException(); }


        #endregion

        #region Public Helper Functions

        #endregion

    }
}
