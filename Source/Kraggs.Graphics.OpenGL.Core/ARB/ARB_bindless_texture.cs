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

using uint64 = System.UInt64; // should this be IntPtr instead??

namespace Kraggs.Graphics.OpenGL
{
    partial class ARB
    {
        #region OpenGL DLLImports

        //[EntryPointSlot(4400)]
        //[DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //public static extern void glBufferStorage(BufferTarget target, IntPtr size, IntPtr data, BufferStorageFlags flags);
        [EntryPointSlot(1)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern uint64 glGetTextureHandleARB(uint texture);

        [EntryPointSlot(2)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern uint64 glGetTextureSamplerHandleARB(uint texture, uint sampler);

        [EntryPointSlot(3)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMakeTextureHandleResidentARB(uint64 handle);

        [EntryPointSlot(4)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMakeTextureHandleNonResidentARB(uint64 handle);

        [EntryPointSlot(5)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern uint64 glGetImageHandleARB(uint texture, int level, bool layered, int layer, int format);

        [EntryPointSlot(6)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMakeImageHandleResidentARB(uint64 handle, int access);

        [EntryPointSlot(7)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glMakeImageHandleNonResidentARB(uint64 handle);

        [EntryPointSlot(8)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glUniformHandleui64ARB(int location, uint64 value);

        [EntryPointSlot(9)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glUniformHandleui64vARB(int location, int count, uint64* value);

        [EntryPointSlot(10)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glProgramUniformHandleui64ARB(uint program, int location, uint64 value);

        [EntryPointSlot(11)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glProgramUniformHandleui64vARB(uint program, int location, int count, uint64* value);

        [EntryPointSlot(12)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern byte glIsTextureHandleResidentARB(uint64 handle);

        [EntryPointSlot(13)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern byte glIsImageHandleResidentARB(uint64 handle);

        #endregion

        #region Public functions

        /// <summary>
        /// will create a texture handle using the current state of the texture named<texture>, including any embedded sampler state.
        /// </summary>
        /// <param name="texture"></param>
        /// <returns>In both cases, a 64-bit unsigned integer handle is returned.</returns>
        //[EntryPoint("glGetTextureHandleARB")]
        [EntryPoint(FunctionName = "glGetTextureHandleARB")]
        public static uint64 GetTextureHandleARB(uint texture) { throw new NotImplementedException(); }

        /// <summary>
        /// will create a texture handle using the current non-sampler state from the texture named<texture> and the sampler state from the sampler object <sampler>.
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="sampler"></param>
        /// <returns>In both cases, a 64-bit unsigned integer handle is returned.</returns>
        [EntryPoint("glGetTextureSamplerHandleARB")]
        public static uint64 GetTextureSamplerHandleARB(uint texture, uint sampler) { throw new NotImplementedException(); }

        /// <summary>
        /// To make a texture handle accessible to shaders for texture mapping operations, a texture handle must first be made resident
        /// </summary>
        /// <param name="handle"></param>
        [EntryPoint("glMakeTextureHandleResidentARB")]
        public static void MakeTextureHandleResidentARB(uint64 handle) { throw new NotImplementedException(); }

        /// <summary>
        /// A texture handle may be made inaccessible to shaders by calling
        /// </summary>
        /// <param name="handle"></param>
        [EntryPoint("glMakeTextureHandleNonResidentARB")]
        public static void MakeTextureHandleNonResidentARB(uint64 handle) { throw new NotImplementedException(); }

        /// <summary>
        /// creates and returns an image handle for level <level> of the texture named<texture>.If<layered> is TRUE, a handle is created for the entire texture level.If<layered> is FALSE, a handle is created for only the layer<layer> of the texture level. <format> specifies a format used to interpret the texels of the image when used for image loads, stores, and atomics
        /// </summary>
        /// <param name="texture">Texture id to get handle fore.</param>
        /// <param name="level">Texture mipmap level to get handle fore.</param>
        /// <param name="layered">If TRUE, a handle is created for the entire texture level.If FALSE, a handle is created for only the layer <layer> of the texture level.</param>
        /// <param name="layer">Layer to get handle fore</param>
        /// <param name="format"><format> specifies a format used to interpret the texels of the image when used for image loads, stores, and atomics</param>
         /// <returns>A 64-bit unsigned integer handle is returned if the command succeeds; otherwise, zero is returned.</returns>
        [EntryPoint("glGetImageHandleARB")]
        public static uint64 GetImageHandleARB(uint texture, int level, bool layered, int layer, SizedInternalFormat format) { throw new NotImplementedException(); }

        /// <summary>
        /// To make an image handle accessible to shaders for image loads, stores, and atomic operations, the handle must be made resident by calling
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="access">specifies whether the texture bound to the image handle will be treated as READ_ONLY, WRITE_ONLY, or READ_WRITE.</param>
        /// <remarks>
        /// When an image handle is resident, the texture it references is not necessarily considered resident for the purposes of the AreTexturesResident command
        /// </remarks>
        [EntryPoint("glMakeImageHandleResidentARB")]
        public static void MakeImageHandleResidentARB(uint64 handle, MapBufferAccess access) { throw new NotImplementedException(); }

        /// <summary>
        /// An image handle may be made inaccessible to shaders by calling
        /// </summary>
        /// <param name="handle"></param>
        [EntryPoint("glMakeImageHandleNonResidentARB")]
        public static void MakeImageHandleNonResidentARB(uint64 handle) { throw new NotImplementedException(); }

        /// <summary>
        /// The glUniformHandleui64ARB command will load a 64-bit unsigned integer handle into a uniform location corresponding to sampler or image variable types.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="value"></param>
        [EntryPoint("glUniformHandleui64ARB")]
        public static void UniformHandleui64ARB(int location, uint64 value) { throw new NotImplementedException(); }

        /// <summary>
        /// The glUniformHandleui64vARB command will load [count] 64-bit unsigned integer handles into a uniform location corresponding to sampler or image variable types.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="count"></param>
        /// <param name="value"></param>
        [EntryPoint("glUniformHandleui64vARB")]
        public static unsafe void UniformHandleui64vARB(int location, int count, uint64* value) { throw new NotImplementedException(); }

        /// <summary>
        /// The glProgramUniformHandleui64ARB command will load a 64-bit unsigned integer handle into a uniform location corresponding to sampler or image variable types.
        /// </summary>
        /// <param name="program"></param>
        /// <param name="location"></param>
        /// <param name="value"></param>
        [EntryPoint("glProgramUniformHandleui64ARB")]
        public static void ProgramUniformHandleui64ARB(uint program, int location, uint64 value) { throw new NotImplementedException(); }

        /// <summary>
        /// The glUniformHandleui64vARB command will load [count] 64-bit unsigned integer handles into a uniform location corresponding to sampler or image variable types.
        /// </summary>
        /// <param name="program"></param>
        /// <param name="location"></param>
        /// <param name="count"></param>
        /// <param name="value"></param>
        [EntryPoint("glProgramUniformHandleui64vARB")]
        public static unsafe void ProgramUniformHandleui64vARB(uint program, int location, int count, uint64* value) { throw new NotImplementedException(); }

        /// <summary>
        /// return TRUE if the specified texture or image handle is resident in the current context.
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [EntryPoint("glIsTextureHandleResidentARB")]
        public static bool IsTextureHandleResidentARB(uint64 handle) { throw new NotImplementedException(); }

        /// <summary>
        /// return TRUE if the specified texture or image handle is resident in the current context.
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [EntryPoint("glIsImageHandleResidentARB")]
        public static bool IsImageHandleResidentARB(uint64 handle) { throw new NotImplementedException(); }

        #endregion

        #region Public Helper Functions

        /// <summary>
        /// The glUniformHandleui64vARB command will load [count] 64-bit unsigned integer handles into a uniform location corresponding to sampler or image variable types.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="value"></param>
        public static unsafe void UniformHandleui64vARB(int location, uint64[] value)
        {
            fixed(uint64* ptr = value)
            {
                UniformHandleui64vARB(location, value.Length, ptr);
            }
        }

        /// <summary>
        /// The glUniformHandleui64vARB command will load [count] 64-bit unsigned integer handles into a uniform location corresponding to sampler or image variable types.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="value"></param>
        /// <param name="index"></param>
        /// <param name="count"></param>
        public static unsafe void UniformHandleui64vARB(int location, uint64[] value, int index, int count)
        {
            // should we detect errors here or silently ignore the call, silently fix partly the call or what.
            fixed(uint64* ptr = &value[index])
            {
                UniformHandleui64vARB(location, count, ptr);
            }
        }

        #endregion
    }
}
