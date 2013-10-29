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

    partial class ARB
    {
        #region Delegate Class

        partial class Delegates
        {

            #region Delegates

            public delegate void delDebugMessageControlARB(DebugSource source, DebugType type, DebugSeverity severity, int Count, ref uint ids, bool Enabled);
            public delegate void delDebugMessageInsertARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, int length, string buf);
            public delegate void delDebugMessageCallbackARB(DebugMessageDelegate callback, IntPtr userParam);
            public delegate uint delGetDebugMessageLogARB(uint count, int bufsize, ref DebugSource sources, ref DebugType types, ref uint ids, ref DebugSeverity severities, ref int lengths, StringBuilder messageLog);
            public delegate void delGetPointervARB(GetPointerName pname, out IntPtr ptr);

            #endregion

            #region GL Fields

            public static delDebugMessageControlARB glDebugMessageControlARB;
            public static delDebugMessageInsertARB glDebugMessageInsertARB;
            public static delDebugMessageCallbackARB glDebugMessageCallbackARB;
            public static delGetDebugMessageLogARB glGetDebugMessageLogARB;
            public static delGetPointervARB glGetPointerv;

            #endregion
        }

        #endregion

        #region Public functions.

        /// <summary>
        /// Changes the properties of an array of debug message ids.
        /// This might be source, type, severity or just enable/disable them.
        /// Enables or Disables an array of Debug Messages ids
        /// </summary>
        /// <param name="source">Source of ids.</param>
        /// <param name="type">Type of ids</param>
        /// <param name="severity">Severity of ids.</param>
        /// <param name="ids">array of ids to change.</param>
        /// <param name="Enabled">Enables or disables the ids.</param>
        public static void DebugMessageControlARB(DebugSource source, DebugType type, DebugSeverity severity, uint[] ids, bool Enabled)
        {
            Delegates.glDebugMessageControlARB(source, type, severity, ids.Length, ref ids[0], Enabled);
        }
        /// <summary>
        /// Insert a new debug message in the debug message log array.
        /// </summary>
        /// <param name="source">Source of inserted message.</param>
        /// <param name="type">type of inserted message.</param>
        /// <param name="id">id of inserted message. Userid has own range of ids.</param>
        /// <param name="severity">Severity of inserted message.</param>
        /// <param name="Text">The text of inserted message.</param>
        public static void DebugMessageInsertARB(DebugSource source, DebugType type, uint id, DebugSeverity severity, string Text)
        {
            Delegates.glDebugMessageInsertARB(source, type, id, severity, Text.Length, Text);
        }

        /// <summary>
        /// Defines the Debug MessageCallback Delegate and its optionally userParam.
        /// </summary>
        /// <param name="callback">Delegate to a function which will be called by opengl with debug messages.</param>
        /// <param name="userParam">Optionally userParam which will be one of the arguments opengl calls the delegate with.</param>
        public static void DebugMessageCallbackARB(DebugMessageDelegate callback, IntPtr userParam)
        {
            Delegates.glDebugMessageCallbackARB(callback, userParam);
        }
        /// <summary>
        /// Defines the Debug MessageCallback Delegate and its optionally userParam.
        /// </summary>
        /// <param name="callback">Delegate to a function which will be called by opengl with debug messages.</param>
        public static void DebugMessageCallbackARB(DebugMessageDelegate callback)
        {
            Delegates.glDebugMessageCallbackARB(callback, IntPtr.Zero);
        }

        /// <summary>
        /// Retrives a number of messages from message log.
        /// How many retrives is determined by Math.Min([all arrays]) and availible messages.
        /// </summary>
        /// <param name="sources"></param>
        /// <param name="types"></param>
        /// <param name="ids"></param>
        /// <param name="severities"></param>
        /// <param name="lengths"></param>
        /// <param name="messageLog">A single preallocated stringbuilder with enough capacity to contain all the messages?</param>
        /// <returns></returns>
        public static uint GetDebugMessageLogARB(DebugSource[] sources, DebugType[] types, uint[] ids, DebugSeverity[] severities, int[] lengths, StringBuilder messageLog)
        {
            var count = Math.Min(sources.Length, Math.Min(types.Length, Math.Min(ids.Length, Math.Min(severities.Length, lengths.Length))));

            return Delegates.glGetDebugMessageLogARB((uint)count, messageLog.Capacity, ref sources[0], ref types[0], ref ids[0], ref severities[0], ref lengths[0], messageLog);
        }


        #endregion
    }
}
