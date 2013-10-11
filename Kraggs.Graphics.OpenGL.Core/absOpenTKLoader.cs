// this code is heavily/ripped on work from OpenTK project.
// therefore I cant take copyright on this code.

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
    /// <summary>
    /// This is a implementation of OpenTK opengl loader using reflection.
    /// </summary>
    public abstract partial class absOpenTKLoader
    {
        internal readonly Type pDelegatesClass;

        static absOpenTKLoader()
        {
            // sets up the default fallback getproc implementation.
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
                sGetProcAddress = new clsglGetProcAddress();
            
            //TODO: Implement default Linux/MacOS GetProcAddress Implementation.
        }

        protected absOpenTKLoader()
        {
            pDelegatesClass = this.GetType().GetNestedType("Delegates", BindingFlags.Static | BindingFlags.NonPublic);
        }

        public virtual void Initialize(IGetProcAddress GetProcAddress = null)
        {
            if (GetProcAddress == null)
                GetProcAddress = sGetProcAddress;

            var methods = pDelegatesClass.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            //if (methods == null)
            //    throw new InvalidOperationException("No method fields found in class");

            foreach (var f in methods)
            {
                var ptr = GetProcAddress.GetProcAddress(f.Name);
                if (ptr != IntPtr.Zero)
                {
                    var d = Marshal.GetDelegateForFunctionPointer(ptr, f.FieldType);
                    f.SetValue(null, d);
                }
#if DEBUG
                else
                {
                    Debug.WriteLine(string.Format(
                        "{0} not found!", f.Name), "OpenGL Loader");
                }
#endif
            }
        }
    }

    #region IGetProcAddress

    public interface IGetProcAddress
    {
        IntPtr GetProcAddress(string ProcName);
    }

    partial class absOpenTKLoader
    {
        internal static IGetProcAddress sGetProcAddress;

        internal class clsglGetProcAddress : IGetProcAddress
        {
            [DllImport(GL.OPENGL_LIBRARY)]
            public static extern IntPtr wglGetProcAddress(string procName);

            public IntPtr GetProcAddress(string procName)
            {
                return wglGetProcAddress(procName);
            }
        }
    }

    #endregion
}
