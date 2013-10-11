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
    public abstract partial class absOpenTKDllImportLoader : absOpenTKLoader
    {
        private readonly Type pDllImportClass;
        private readonly SortedList<string, MethodInfo> pDllImportMap;

        protected absOpenTKDllImportLoader(Type loader)
        {
            pDllImportClass = loader.GetNestedType("DllImports", BindingFlags.Public | BindingFlags.NonPublic);

            var funcs = pDllImportClass.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

            //if (funcs == null)
            //    throw new ApplicationException("Failed to find any static functions in DllImports??");

            pDllImportMap = new SortedList<string, MethodInfo>();

            foreach (var m in funcs)
                pDllImportMap.Add(m.Name, m);
        }

        public override void Initialize(IGetProcAddress GetProcAddress = null)
        {
            if (GetProcAddress == null)
                GetProcAddress = sGetProcAddress;

            var methods = pDelegatesClass.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);

            //if(methods == null)
            //    throw new InvalidOperationException("No method fields found in class");

            foreach (var f in methods)
            {
                Delegate d = null;
                MethodInfo m;

                if (pDllImportMap.TryGetValue(f.Name, out m))
                {
                    d = Delegate.CreateDelegate(f.FieldType, m);
                }
                else
                {
                    var ptr = GetProcAddress.GetProcAddress(f.Name);

                    if (ptr != IntPtr.Zero)
                        d = Marshal.GetDelegateForFunctionPointer(ptr, f.FieldType);
#if DEBUG
                    else
                    {
                        Debug.WriteLine(string.Format(
                            "{0} not found!", f.Name), "OpenGL Loader");
                    }
#endif
                }

                if (d != null)
                    f.SetValue(null, d);
            }

#if DEBUG
            Marshal.PrelinkAll(pDllImportClass);
#endif
        }
    }
}
