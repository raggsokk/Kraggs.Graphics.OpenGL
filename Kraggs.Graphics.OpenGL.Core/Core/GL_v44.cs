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
    
    partial class GL
    {
        #region Delegate Class

        //partial class Delegates
        //{

        //    #region Delegates

        //    //ARB_buffer_storage
        //    public delegate void delBufferStorage(BufferTarget target, IntPtr size, IntPtr data, BufferStorageFlags flags);

        //    //ARB_clear_texture
        //    public delegate void delClearTexImage(uint texture, int level, PixelFormat format, PixelType type, IntPtr FillData);
        //    public delegate void delClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr FillData);

        //    //ARB_multi_bind
        //    public delegate void delBindBuffersBase(BufferProgramTarget target, int first, int count, ref uint buffers);
        //    public delegate void delBindBuffersRange(BufferProgramTarget target, int first, int count, ref uint buffers, ref IntPtr Offsets, ref IntPtr Sizes);
        //    public delegate void delBindTextures(uint first, int count, ref uint textures);
        //    public delegate void delBindSamplers(uint first, int count, ref uint samplers);
        //    public delegate void delBindImageTextures(uint first, int count, ref uint textures);
        //    public delegate void delBindVertexBuffers(uint first, int count, ref uint buffers, ref IntPtr Offsets, ref int Strides);
        //    //public unsafe delegate void delBindVertexBuffers(uint first, int count, uint* buffers, IntPtr* Offsets, int* Strides);

        //    #endregion

        //    #region GL Fields

        //    //ARB_buffer_storage
        //    public static delBufferStorage glBufferStorage;

        //    //ARB_clear_texture
        //    public static delClearTexImage glClearTexImage;
        //    public static delClearTexSubImage glClearTexSubImage;

        //    //ARB_multi_bind
        //    public static delBindBuffersBase glBindBuffersBase;
        //    public static delBindBuffersRange glBindBuffersRange;
        //    public static delBindTextures glBindTextures;
        //    public static delBindSamplers glBindSamplers;
        //    public static delBindImageTextures glBindImageTextures;
        //    public static delBindVertexBuffers glBindVertexBuffers;

        //    #endregion
        //}

        #endregion

        #region Public functions.

        //ARB_buffer_storage
        /// <summary>
        /// Allocates immutable storage for buffer bound to specified target.
        /// </summary>
        /// <param name="target">Target containging a buffer to allocate immutable storage for.s</param>
        /// <param name="size">Size in bytes of allocates storage.</param>
        /// <param name="data">Data to upload to buffer or zero to just allocate.</param>
        /// <param name="flags">Buffer Allocation Flags.</param>
        [EntryPoint("glBufferStorage")]
        public static void BufferStorage(BufferTarget target, IntPtr size, IntPtr data, BufferStorageFlags flags)
        { throw new NotImplementedException(); }

        public static void BufferStorage<TValueType>(BufferTarget target, TValueType[] data, BufferStorageFlags flags) where TValueType : new()
        {
            var totalsize = Marshal.SizeOf(typeof(TValueType)) * data.Length;

            var handle = GCHandle.Alloc(data, GCHandleType.Pinned);

            BufferStorage(target, (IntPtr)totalsize, handle.AddrOfPinnedObject(), flags);
            //Delegates.glBufferStorage(target, (IntPtr)totalsize, handle.AddrOfPinnedObject(), flags);

            handle.Free();
        }

        //ARB_clear_texture
        /// <summary>
        /// Clears the content of a texture mipmap level
        /// </summary>
        /// <param name="texture">Texture to clear.</param>
        /// <param name="level">Mipmap level in texture to clear.</param>
        /// <param name="format">Pixelformat of filldata to clear with.</param>
        /// <param name="type">PixelType of Filldata to clear with.</param>
        /// <param name="FillData">is a pointer to an array of between one and four components of texel data that will be used as the source for the constant fill value.If data is NULL, then the pointer is ignored and the sub-range of the texture image is filled with zeros.</param>
        [EntryPoint("glClearTexImage")]
        public static void ClearTexImage(uint texture, int level, PixelFormat format, PixelType type, IntPtr FillData)
        { throw new NotImplementedException(); }

        /// <summary>
        /// Clears a subpart of a texture mipmap level.
        /// </summary>
        /// <param name="texture"></param>
        /// <param name="level"></param>
        /// <param name="xoffset"></param>
        /// <param name="yoffset"></param>
        /// <param name="zoffset"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="depth"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="FillData"></param>
        [EntryPoint("glClearTexSubImage")]
        public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr FillData)
        { throw new NotImplementedException(); }

        //ARB_multi_bind'

        /// <summary>
        /// Binds an array of buffer ids to a range of bindingindexes of target type.
        /// </summary>
        /// <param name="target">Type of BindingIndexes.</param>
        /// <param name="first">first BindingIndex to bind first buffer to.</param>
        /// <param name="count">Size of array buffers and number of buffers to bind continiously from first and upwards.</param>
        /// <param name="buffers">Array of buffer ids to bind.</param>
        [EntryPoint("glBindBuffersBase")]
        public static void BindBuffersBase(BufferProgramTarget target, int first, int count, ref uint buffers)
        { throw new NotImplementedException(); }

        /// <summary>
        /// Binds an array of buffer ids to a bindingindex of target type starting at first.
        /// </summary>
        /// <param name="target">The sets or type of bindingindexes to bind to.</param>
        /// <param name="first">First Bindingindex to start binding at.</param>
        /// <param name="buffers">Array of buffer ids to bind.</param>
        [EntryPoint("glBindBuffersBase")]
        public static void BindBuffersBase(BufferProgramTarget target, int first, uint[] buffers)
        { throw new NotImplementedException(); }

        ///// <summary>
        ///// Resets a range of bindingindexes to no buffer.
        ///// </summary>
        ///// <param name="target">Which sets of binding indexes to set to zero?</param>
        ///// <param name="first">first BindingIndex to reset.</param>
        ///// <param name="count">Number of bindingindexes to reset.</param>
        //public static void BindBuffersBase(BufferProgramTarget target, int first, int count)
        //{
        //    var tmp = new uint[count];
        //    Delegates.glBindBuffersBase(target, first, tmp.Length, ref tmp[0]);
        //}
        [EntryPoint("glBindBuffersRange")]
        public static void BindBuffersRange(BufferProgramTarget target, int first, int count, ref uint buffers, ref IntPtr Offsets, ref IntPtr Sizes)
        { throw new NotImplementedException(); }

        public static void BindBuffersRange(BufferProgramTarget target, int first, uint[] buffers, IntPtr[] Offsets, IntPtr[] Sizes)
        {
            var count = Math.Min(buffers.Length, Math.Min(Offsets.Length, Sizes.Length));

            BindBuffersRange(target, first, count, ref buffers[0], ref Offsets[0], ref Sizes[0]);
        }

        /// <summary>
        /// Binds a range of textures to a range of texture units.
        /// TextureTarget used is the first texturetarget used to bind after texture id generation.
        /// </summary>
        /// <param name="first">First zerobased texture unit to bind textures[0] to.</param>
        /// <param name="count">Size of array textures and number of textures to bind continiously from first and upwards.</param>
        /// <param name="textures">Array of texture ids to bind.</param>
        [EntryPoint("glBindTextures")]
        public static void BindTextures(uint first, int count, ref uint textures)
        { throw new NotImplementedException(); }

        /// <summary>
        /// Binds a range of textures to a range of texture units.
        /// TextureTarget used is the first texturetarget used to bind after texture id generation.
        /// </summary>
        /// <param name="first">First Texture unit to bind textures[0] to..</param>
        /// <param name="textures">Array of texture ids to bind. Texture target used is the target specified when the texture object was created.</param>
        [EntryPoint("glBindTextures")]
        public static void BindTextures(uint first, uint[] textures)
        { throw new NotImplementedException(); }

        ///// <summary>
        ///// Resets a range of texture units to their default texture.(0)
        ///// </summary>
        ///// <param name="first">First Texture unit to reset.</param>
        ///// <param name="count">Count Texture unit to reset.</param>
        //public static void BindTextures(uint first, int count)
        //{
        //    var tmp = new uint[count];
        //    Delegates.glBindTextures(first, tmp.Length, ref tmp[0]);
        //}

        /// <summary>
        /// Binds a range of sampler ids to a range of texture units.
        /// </summary>
        /// <param name="first">First zerobased texture unit to bind samplers[0] to.</param>
        /// <param name="count">Size of array Samplers and number of Samplers to bind continiously from first and upwards.</param>
        /// <param name="samplers">Array of sampler ids to bind.</param>
        [EntryPoint("glBindSamplers")]
        public static void BindSamplers(uint first, int count, ref uint samplers)
        { throw new NotImplementedException(); }

        /// <summary>
        /// Binds a range of sampler ids to a range of texture units.
        /// </summary>
        /// <param name="first">First Texture Unit to bind samplers[0] to.</param>
        /// <param name="samplers">Array of sampler ids to bind.</param>
        public static void BindSamplers(uint first, uint[] samplers)
        {
            BindSamplers(first, samplers.Length, ref samplers[0]);
        }

        /// <summary>
        /// Binds a range of image textures to a range of image units.
        /// When binding a non-zero texture object to an image unit, the image unit [level, layered, layer, and access] parameters are set to [zero, TRUE, zero, and READ_WRITE], respectively.
        /// </summary>
        /// <param name="first">First Image unit to bind to.</param>
        /// <param name="count">Size of array textures and number of textures to bind continiously from first and upwards.</param>
        /// <param name="textures">Array of textures to bind to image units.</param>
        [EntryPoint("glBindImageTextures")]
        public static void BindImageTextures(uint first, int count, ref uint textures)
        { throw new NotImplementedException(); }

        /// <summary>
        /// Binds a range of image textures to a range of image units.
        /// When binding a non-zero texture object to an image unit, the image unit [level, layered, layer, and access] parameters are set to [zero, TRUE, zero, and READ_WRITE], respectively.
        /// </summary>
        /// <param name="first">First Image unit to bind to.</param>
        /// <param name="textures">Array of textures to bind to image units.</param>
        public static void BindImageTextures(uint first, uint[] textures)
        {
            BindImageTextures(first, textures.Length, ref textures[0]);
        }

        /// <summary>
        /// Binds an array of buffers to a range of vertex buffer binding points starting at first.
        /// </summary>
        /// <param name="first">First binding point to bind first set of parametes to. aka buffers[0], Offsets[0], and Strides[0]</param>
        /// <param name="count">Size of arrays and number of bindingpoints to bind continiously from first and upwards.</param>
        /// <param name="buffers">Array of buffer ids to bind.</param>
        /// <param name="Offsets">Array of OFfsets to use, 1 per binding</param>
        /// <param name="Strides">Array of Strides to use, 1 per binding.</param>
        [EntryPoint("glBindVertexBuffers")]
        public static void BindVertexBuffers(uint first, int count, ref uint buffers, ref IntPtr Offsets, ref int Strides)
        { throw new NotImplementedException(); }

        /// <summary>
        /// Binds an array of buffers to a range of  vertex buffer binding points starting at first.
        /// </summary>
        /// <param name="first">First BufferBindingPoint to bind buffer to.</param>
        /// <param name="buffers">Array of buffer ids to bind continiously.</param>
        /// <param name="Offsets">Array of Offsets to use during binding.</param>
        /// <param name="Strides">Array of Strides to use during binding.</param>
        public unsafe static void BindVertexBuffers(uint first, uint[] buffers, IntPtr[] Offsets, int[] Strides)
        {
            //Debug.Assert(buffers != null && Offsets != null && Strides != null);

            //uint* ptrBuffers = null;
            //IntPtr* ptrOffsets = null;
            //IntPtr* ptrStrides = null;

            int count = Math.Min(buffers.Length, Math.Min(Offsets.Length, Strides.Length));

            BindVertexBuffers(first, count, ref buffers[0], ref Offsets[0], ref Strides[0]);

            //fixed(uint* ptrBuffers = &buffers[0])
            //    fixed(IntPtr* ptrOffsets = &Offsets[0])
            //        fixed(int* ptrStrides = &Strides[0])
            //{
            //    Delegates.glBindVertexBuffers(first, count, ptrBuffers, ptrOffsets, ptrStrides);
            //}
        }
        /// <summary>
        /// Binds an array of buffers to a range of  vertex buffer binding points starting at first.
        /// This creates a IntPtr[] and converts Offsets into this before calling.
        /// </summary>
        /// <param name="first">First BufferBindingPoint to bind buffer to.</param>
        /// <param name="buffers">Array of buffer ids to bind continiously.</param>
        /// <param name="Offsets">Array of Offsets to use during binding, converted to IntPtr array.</param>
        /// <param name="Strides">>Array of Strides to use during binding, converted to IntPtr arrray.</param>
        /// <returns></returns>
        public unsafe static int BindVertexBuffers(uint first, uint[] buffers, long[] Offsets, int[] Strides)
        {
            int count = Math.Min(buffers.Length, Math.Min(Offsets.Length, Strides.Length));

            var ptrOffsets = new IntPtr[count];
            for (int i = 0; i < ptrOffsets.Length; ++i)
                ptrOffsets[i] = (IntPtr)Offsets[i];

            BindVertexBuffers(first, count, ref buffers[0], ref ptrOffsets[0], ref Strides[0]);
            //if (count > 0)
            //{
            //    var ptrOffsets = new IntPtr[count];
            //    for (int i = 0; i < ptrOffsets.Length; i++)
            //        ptrOffsets[i] = (IntPtr)Offsets[i];

            //    var ptrStrides = new IntPtr[count];
            //    for (int i = 0; i < ptrStrides.Length; i++)
            //        ptrStrides[i] = (IntPtr)Strides[i];

            //    BindVertexBuffers(first, buffers, ptrOffsets, ptrStrides);
            //}

            return count;
        }

        ///// <summary>
        ///// Resets a range [first,count-first] of vertex buffer binding points to zero.
        ///// </summary>
        ///// <param name="first">First BufferBindingPoint to reset.</param>
        ///// <param name="count">Number of continous BufferBindingPoints to reset.</param>
        //public unsafe static void BindVertexBuffers(uint first, int count)
        //{
        //    Delegates.glBindVertexBuffers(first, count, null, null, null);
        //}

        #endregion

        #region DllImports

        //ARB_buffer_storage
        [EntryPointSlot(4400)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glBufferStorage(BufferTarget target, IntPtr size, IntPtr data, BufferStorageFlags flags);

        //ARB_clear_texture
        [EntryPointSlot(4401)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glClearTexImage(uint texture, int level, PixelFormat format, PixelType type, IntPtr FillData);
        [EntryPointSlot(4402)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        public static extern void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr FillData);

        //ARB_multi_bind
        [EntryPointSlot(4403)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindBuffersBase(BufferProgramTarget target, int first, int count, ref uint buffers);
        [EntryPointSlot(4404)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindBuffersRange(BufferProgramTarget target, int first, int count, ref uint buffers, ref IntPtr Offsets, ref IntPtr Sizes);
        [EntryPointSlot(4405)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindTextures(uint first, int count, ref uint textures);
        [EntryPointSlot(4406)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindSamplers(uint first, int count, ref uint samplers);
        [EntryPointSlot(4407)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindImageTextures(uint first, int count, ref uint textures);
        [EntryPointSlot(4408)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindVertexBuffers(uint first, int count, ref uint buffers, ref IntPtr Offsets, ref int Strides);

        #endregion
    }
}
