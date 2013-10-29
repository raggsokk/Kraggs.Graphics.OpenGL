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

    partial class EXT
    {
        public delegate void DebugMessageDelegateAMD(uint id, DebugCategoryAMD category, DebugSeverity severity, int length, string message, IntPtr userParam);

        #region Delegate Class

        partial class Delegates
        {

            #region Delegates

            public delegate void delDebugMessageEnableAMD(DebugCategoryAMD category, DebugSeverity severity, int count, ref uint ids, bool enabled);
            public delegate void delDebugMessageInsertAMD(DebugCategoryAMD category, DebugSeverity severity, uint id, int length,  string message);
            public delegate void delDebugMessageCallbackAMD(DebugMessageDelegateAMD callback, IntPtr userParam);    
            public delegate uint delGetDebugMessageLogAMD(uint count, int bufsize, ref DebugCategoryAMD categories, ref DebugSeverity severities, ref uint ids, ref int lengths,  StringBuilder message);

            #endregion

            #region GL Fields

            public static delDebugMessageEnableAMD glDebugMessageEnableAMD;
            public static delDebugMessageInsertAMD glDebugMessageInsertAMD;
            public static delDebugMessageCallbackAMD glDebugMessageCallbackAMD;
            public static delGetDebugMessageLogAMD glGetDebugMessageLogAMD;

            #endregion
        }

        #endregion

        #region Public functions.

        /// <summary>
        /// Applications can control which messages are generated
        /// </summary>
        /// <param name="category">Zero means all categories.</param>
        /// <param name="severity">Zero means all severities.</param>
        /// <param name="ids">if category or serverity is zero, ids is ignored.</param>
        /// <param name="enabled">Enables or disables the debug messages matched</param>
        /// <remarks>
        /// All messages of severity level DEBUG_SEVERITY_MEDIUM_AMD and DEBUG_SEVERITY_HIGH_AMD in all categories are initially enabled, and all messages at DEBUG_SEVERITY_LOW_AMD are initially disabled.
        /// </remarks>
        public static void DebugMessageEnableAMD(DebugCategoryAMD category, DebugSeverity severity, uint[] ids, bool enabled)
        {
            Delegates.glDebugMessageEnableAMD(category, severity, ids.Length, ref ids[0], enabled);
        }
        /// <summary>
        /// To easily support custom application timestamps, applications can inject their own messages to the debug message stream
        /// </summary>        
        /// <param name="severity">indicates its severity level as defined by the application.</param>
        /// <param name="id">ID is defined by the application.</param>
        /// <param name="message">message</param>
        /// <param name="category">must be DEBUG_CATEGORY_APPLICATION_AMD</param>
        public static void DebugMessageInsertAMD(DebugSeverity severity, uint id, string message, DebugCategoryAMD category = DebugCategoryAMD.APPLICATION_AMD)
        {
            Delegates.glDebugMessageInsertAMD(category, severity, id, message.Length, message);
        }
        /// <summary>
        /// Applications can listen for messages by providing the GL with a callback function pointer.
        /// </summary>
        /// <param name="callback">Specifying zero as the value of callback clears the current callback and disables message output through callbacks.</param>
        /// <param name="userParam">The context will store this pointer and will include it as one of the parameters of each call to the callback function.</param>
        public static void DebugMessageCallbackAMD(DebugMessageDelegateAMD callback, IntPtr userParam)
        {
            //Delegates.glDebugMessageCallbackAMD(callback, userParam);
            Delegates.glDebugMessageCallbackAMD(callback, userParam);
        }
        /// <summary>
        /// Applications can listen for messages by providing the GL with a callback function pointer.
        /// </summary>
        /// <param name="callback">Specifying zero as the value of callback clears the current callback and disables message output through callbacks.</param>
        public static void DebugMessageCallbackAMD(DebugMessageDelegateAMD callback)
        {
            //Delegates.glDebugMessageCallbackAMD(callback, IntPtr.Zero);
            Delegates.glDebugMessageCallbackAMD(callback, IntPtr.Zero);
        }

        public static uint GetDebugMessageLogAMD(DebugCategoryAMD[] categories, DebugSeverity[] severities, uint[] ids, int[] lengths, StringBuilder message, uint count = 1)
        {
            count = (uint)Math.Min(categories.Length, Math.Min(severities.Length, Math.Min(ids.Length, Math.Min(lengths.Length, (int)count))));

            return Delegates.glGetDebugMessageLogAMD(count, message.Capacity, ref categories[0], ref severities[0], ref ids[0], ref lengths[0], message);
            //if (count < 1)
            //{
            //    count = (uint)GL.GetIntegerv(GetParameters.DebugLoggedMessages);
            //}

            //count = (uint)Math.Min(categories.Length, Math.Min(severities.Length, Math.Min(ids.Length, Math.Min(lengths.Length, (int)count))));

            //if (count > 0)
            //{
            //    var sb
            //}
        }




        #endregion
    }
}
