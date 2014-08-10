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
    partial class AMD
    {
        #region OpenGL DLLImports

        [EntryPointSlot(1)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glDebugMessageEnableAMD(DebugCategoryAMD category, DebugSeverity severity, int count, uint* ids, bool enabled);
        [EntryPointSlot(2)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDebugMessageInsertAMD(DebugCategoryAMD category, DebugSeverity severity, uint id, int length,  IntPtr message);
        [EntryPointSlot(3)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDebugMessageCallbackAMD(DebugMessageDelegateAMD callback, IntPtr userParam);
        [EntryPointSlot(4)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern uint glGetDebugMessageLogAMD(uint count, int bufsize, DebugCategoryAMD* categories, DebugSeverity* severities, uint* ids, int* lengths, IntPtr message);

        #endregion

        #region Public functions

        //[EntryPoint(FunctionName = "gl")]
        //public static void BindTexture(TextureTarget target, uint textureid) { throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glDebugMessageEnableAMD")]
        unsafe public static void DebugMessageEnableAMD(DebugCategoryAMD category, DebugSeverity severity, int count, uint* ids, bool enabled){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glDebugMessageEnableAMD")]
        unsafe private static void DebugMessageEnableAMD(DebugCategoryAMD category, DebugSeverity severity, int count, uint[] ids, bool enabled) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glDebugMessageEnableAMD")]
        unsafe public static void DebugMessageEnableAMD(DebugCategoryAMD category, DebugSeverity severity, int count, ref uint ids, bool enabled) { throw new NotImplementedException(); }
        public static void DebugMessageEnableAMD(DebugCategoryAMD category, DebugSeverity severity, uint[] ids, bool enabled)
        {
            DebugMessageEnableAMD(category, severity, ids != null ? ids.Length : 0, ids, enabled);
        }

        [EntryPoint(FunctionName = "glDebugMessageInsertAMD")]        
        public static void DebugMessageInsertAMD(DebugCategoryAMD category, DebugSeverity severity, uint id, int length, string message) { throw new NotImplementedException(); }
        public static void DebugMessageInsertAMD(DebugSeverity severity, uint id, string message)
        {
            DebugMessageInsertAMD(DebugCategoryAMD.Application, severity, id, 0, message);
        }

        [EntryPoint(FunctionName = "glDebugMessageCallbackAMD")]
        public static void DebugMessageCallbackAMD(DebugMessageDelegateAMD callback, IntPtr userParam){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetDebugMessageLogAMD")]
        unsafe public static uint GetDebugMessageLogAMD(uint count, int bufsize, DebugCategoryAMD* categories, DebugSeverity* severities, uint* ids, int* lengths, StringBuilder message){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetDebugMessageLogAMD")]
        public static uint GetDebugMessageLogAMD(uint count, int bufsize, DebugCategoryAMD[] categories, DebugSeverity[] severities, uint[] ids, int[] lengths, StringBuilder message) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetDebugMessageLogAMD")]
        public static uint GetDebugMessageLogAMD(uint count, int bufsize, ref DebugCategoryAMD categories, ref DebugSeverity severities, ref uint ids, ref int lengths, StringBuilder message) { throw new NotImplementedException(); }

        public static uint GetDebugMessageLogAMD(DebugCategoryAMD[] categories, DebugSeverity[] severities, uint[] ids, StringBuilder message)
        {
            var count = Math.Min(categories.Length, Math.Min(severities.Length, ids.Length));
            var lengths = new int[count];

            var ret = GetDebugMessageLogAMD((uint)count, message.Capacity, categories, severities, ids, lengths, message);
            return ret;
        }

        #endregion

        #region Public Helper Functions

        #endregion
    }
}
