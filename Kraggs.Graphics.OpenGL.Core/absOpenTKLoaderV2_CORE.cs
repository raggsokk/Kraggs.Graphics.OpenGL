#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

using Kraggs.Graphics.OpenGL;

namespace Kraggs.Graphics
{
    partial class absOpenTKLoaderV2
    {
        /// <summary>
        /// Fall back GetProcAddress function. Preferable the user should use their own GetProcAddress.
        /// </summary>
        /// <returns></returns>
        protected virtual IGetProcAddress GetDefaultGetProcAddress()
        {
            if (sGetProcAddress == null)
            {
                if (Environment.OSVersion.Platform == PlatformID.Unix)
                    sGetProcAddress = new clsGLXGetProcAddress();
                else if (Environment.OSVersion.Platform == PlatformID.MacOSX)
                    throw new NotImplementedException("GetProcAddress is not implemented for MAC yet.");
                else
                    sGetProcAddress = new clsWGLGetProcAddress();
            }

            return sGetProcAddress;
        }

        #region clsWGLGetProcAddress

        /// <summary>
        /// Simple class for loading OpenGL Function Pointers on Windows.
        /// </summary>
        internal class clsWGLGetProcAddress : IGetProcAddress
        {
            const string WGL_LIBRARY = "OpenGL32.dll";

            [DllImport(WGL_LIBRARY, EntryPoint = "wglGetProcAddress")]
            private static extern IntPtr wglGetProcAddressPtr(IntPtr procName);

            [DllImport("kernel32.dll")]
            internal static extern IntPtr GetProcAddress(IntPtr handle, IntPtr funcname);

            [DllImport("kernel32.dll")]
            internal static extern IntPtr GetModuleHandle([MarshalAs(UnmanagedType.LPTStr)]string module_name);

            [DllImport("kernel32.dll", SetLastError = true)]
            internal static extern IntPtr LoadLibrary(string dllName);

            [DllImport("kernel32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool FreeLibrary(IntPtr handle);

            private static IntPtr sOpenGLHandle;

            public clsWGLGetProcAddress()
            {
                if (sOpenGLHandle == IntPtr.Zero)
                {
                    // maybe change this to getmodulehandle??
                    sOpenGLHandle = LoadLibrary(WGL_LIBRARY);
                }
            }

            public IntPtr GetProcAddress(IntPtr ProcName)
            {
                var ptr = wglGetProcAddressPtr(ProcName);
                // wglGetProcAddress will return zero for OpenGL 1.0/1.1
                if (ptr == IntPtr.Zero)
                {
                    // Windows GetProcAddress returns correct address.
                    ptr = GetProcAddress(sOpenGLHandle, ProcName);
                }

                return ptr;
            }
        }

        #endregion

        #region clsGLXGetProcAddress

        /// <summary>
        /// Simple class for loading OpenGL Function Pointers on Linux.
        /// </summary>
        internal class clsGLXGetProcAddress : IGetProcAddress
        {
            const string GLX_LIBRARY = "libGL.so.1";

            [DllImport(GLX_LIBRARY, EntryPoint = "glXGetProcAddress")]
            private static extern IntPtr GetProcAddressPtr(IntPtr procName);

            [DllImport(GLX_LIBRARY, EntryPoint = "glXGetProcAddressARB")]
            public static extern IntPtr GetProcAddressARBPtr(IntPtr procName);

            public IntPtr GetProcAddress(IntPtr ProcName)
            {
                return GetProcAddressPtr(ProcName);
            }
        }

        #endregion
    }
}
