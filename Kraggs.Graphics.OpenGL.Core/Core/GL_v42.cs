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

        partial class Delegates
        {

            #region Delegates

            //ARB_base_instance
            public delegate void delDrawArraysInstancedBaseInstance(BeginMode mode, int first, int count, int InstanceCount, uint BaseInstance);
            public delegate void delDrawElementsInstancedBaseInstance(BeginMode mode, int count, IndicesType type, IntPtr Indices, int InstanceCount, uint BaseInstance);
            public delegate void delDrawElementsInstancedBaseVertexBaseInstance(BeginMode mode, int count, IndicesType type, IntPtr Indices, int InstanceCount, int BaseVertex, uint BaseInstance);

            //ARB_internalformat_query
            public delegate void delGetInternalformativ(GetInternalformatTargets target, PixelInternalFormat internalformat, GetInternalformatParameters pname, int bufSize, ref int @params);

            //ARB_shader_atomic_counters
            public delegate void delGetActiveAtomicCounterBufferiv(uint Program, uint BufferIndex, AtomicCounterBufferParameters pname, ref int @params);

            //ARB_shader_image_-load_store
            public delegate void delMemoryBarrier(MemoryBarrierFlags barriers);
            public delegate void delBindImageTexture(uint index, uint TextureID, int level, bool layered, int layer, MapBufferAccess access, SizedInternalFormat format);

            //ARB_texture_storage
            public delegate void delTexStorage1D(TextureTarget target, int levels, PixelInternalFormat piformat, int Width);
            public delegate void delTexStorage2D(TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height);
            public delegate void delTexStorage3D(TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height, int Depth);

            //ARB_transform_feedback_-instanced   
            public delegate void delDrawTransformFeedbackInstanced(BeginMode mode, uint TransformFeedbackId, int InstanceCount);
            public delegate void delDrawTransformFeedbackStreamInstanced(BeginMode mode, uint TransformFeedbackId, uint Stream, int InstanceCount);

            #endregion

            #region GL Fields

            //ARB_base_instance
            public static delDrawArraysInstancedBaseInstance glDrawArraysInstancedBaseInstance;
            public static delDrawElementsInstancedBaseInstance glDrawElementsInstancedBaseInstance;
            public static delDrawElementsInstancedBaseVertexBaseInstance glDrawElementsInstancedBaseVertexBaseInstance;

            //ARB_internalformat_query
            public static delGetInternalformativ glGetInternalformativ;

            //ARB_shader_atomic_counters
            public static delGetActiveAtomicCounterBufferiv glGetActiveAtomicCounterBufferiv;

            //ARB_shader_image_-load_store
            public static delMemoryBarrier glMemoryBarrier;
            public static delBindImageTexture glBindImageTexture;

            //ARB_texture_storage
            public static delTexStorage1D glTexStorage1D;
            public static delTexStorage2D glTexStorage2D;
            public static delTexStorage3D glTexStorage3D;


            //ARB_transform_feedback_-instanced   
            public static delDrawTransformFeedbackInstanced glDrawTransformFeedbackInstanced;
            public static delDrawTransformFeedbackStreamInstanced glDrawTransformFeedbackStreamInstanced;

            #endregion
        }

        #endregion

        #region Public functions.

        //ARB_base_instance
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="first"></param>
        /// <param name="count"></param>
        /// <param name="InstanceCount"></param>
        /// <param name="BaseInstance"></param>
        public static void DrawArraysInstancedBaseInstance(BeginMode mode, int first, int count, int InstanceCount, uint BaseInstance)
        {
            Delegates.glDrawArraysInstancedBaseInstance(mode, first, count, InstanceCount, BaseInstance);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="count"></param>
        /// <param name="type"></param>
        /// <param name="Indices"></param>
        /// <param name="InstanceCount"></param>
        /// <param name="BaseInstance"></param>
        public static void DrawElementsInstancedBaseInstance(BeginMode mode, int count, IndicesType type, IntPtr Indices, int InstanceCount, uint BaseInstance)
        {
            Delegates.glDrawElementsInstancedBaseInstance(mode, count, type, Indices, InstanceCount, BaseInstance);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="count"></param>
        /// <param name="type"></param>
        /// <param name="Indices"></param>
        /// <param name="InstanceCount"></param>
        /// <param name="BaseVertex"></param>
        /// <param name="BaseInstance"></param>
        public static void DrawElementsInstancedBaseVertexBaseInstance(BeginMode mode, int count, IndicesType type, IntPtr Indices, int InstanceCount, int BaseVertex, uint BaseInstance)
        {
            Delegates.glDrawElementsInstancedBaseVertexBaseInstance(mode, count, type, Indices, InstanceCount, BaseVertex, BaseInstance);
        }

        //ARB_shader_atomic_counters
        /// <summary>
        /// Retrives information of ActiveAtomicCounters in a Program.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="BufferIndex">Index of Atomic Counter to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params"></param>
        public static void GetActiveAtomicCounterBufferiv(uint Program, uint BufferIndex, AtomicCounterBufferParameters pname, int[] @params)
        {
            Delegates.glGetActiveAtomicCounterBufferiv(Program, BufferIndex, pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives information of ActiveAtomicCounters in a Program.
        /// </summary>
        /// <param name="Program">Program to Query.</param>
        /// <param name="BufferIndex">Index of Atomic Counter to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <returns></returns>
        public static int GetActiveAtomicCounterBufferiv(uint Program, uint BufferIndex, AtomicCounterBufferParameters pname)
        {
            int tmp = 0;
            Delegates.glGetActiveAtomicCounterBufferiv(Program, BufferIndex, pname, ref tmp);
            return tmp;
        }

        //ARB_shader_image_-load_store
        /// <summary>
        /// defines a barrier ordering the memory transactions issued prior to the command relative to those issued after the barrier.
        /// </summary>
        /// <param name="barriers">See MemoryBarrierFlags for description of what the flags does.</param>
        public static void MemoryBarrier(MemoryBarrierFlags barriers)
        {
            Delegates.glMemoryBarrier(barriers);
        }
        /// <summary>
        /// The contents of a texture may be made available for shaders to read and write by binding the texture to one of a collection of image units.
        /// If the texture identified by texture does not have multiple layers or faces, the entire texture level is bound, regardless of the values specified for layered and layer
        /// </summary>
        /// <param name="unit">identifies the image unit [0, MAX_IMAGE_UNITS]</param>
        /// <param name="TextureID">texture is the name of the texture.If texture is zero, any texture currently bound to image unit unit is unbound.</param>
        /// <param name="level">selects a single level of the texture.</param>
        /// <param name="layered"> If layered is TRUE, the entire level is bound. If layered is FALSE, only the single layer identified by layer will be bound</param>
        /// <param name="layer"></param>
        /// <param name="access">access specifies whether the texture bound to the image will be treated as READ_ONLY, WRITE_ONLY, or READ_WRITE.</param>
        /// <param name="format">format specifies the format that the elements of the image will be treated as when doing formatted stores</param>
        public static void BindImageTexture(uint unit, uint TextureID, int level, MapBufferAccess access, SizedInternalFormat format, bool layered = false, int layer = 0)
        {
            Delegates.glBindImageTexture(unit, TextureID, level, layered, layer, access, format);
        }

        //ARB_internalformat_query
        /// <summary>
        /// Information about implementation-dependent support for internal formats can be queried with the command GetInternalformativ
        /// </summary>
        /// <param name="target">target indicates the usage of the internalformat, and must be one the targets listed in enum.</param>
        /// <param name="internalFormat">internalformat can be any value</param>
        /// <param name="pname">The INTERNALFORMAT_SUPPORTED pname can be used to determine if the internal format is supported, and the other pnames are defined in terms of whether or not the format is supported</param>
        /// <param name="params">No more than @params.Length integers will be written into params. If more data are available, they will be ignored and no error will be generated.</param>
        public static void GetInternalformativ(GetInternalformatTargets target, PixelInternalFormat internalFormat, GetInternalformatParameters pname, int[] @params)
        {
            Delegates.glGetInternalformativ(target, internalFormat, pname, @params.Length, ref @params[0]);
        }
        /// <summary>
        /// Information about implementation-dependent support for internal formats can be queried with the command GetInternalformativ
        /// No more than 1 int will be returned. If more data are available, they will be ignored and no error will be generated.
        /// </summary>
        /// <param name="target">target indicates the usage of the internalformat, and must be one the targets listed in enum.</param>
        /// <param name="internalFormat">internalformat can be any value</param>
        /// <param name="pname">The INTERNALFORMAT_SUPPORTED pname can be used to determine if the internal format is supported, and the other pnames are defined in terms of whether or not the format is supported</param>
        /// <returns>No more than 1 int will be returned. If more data are available, they will be ignored and no error will be generated.</returns>
        public static int GetInternalformativ(GetInternalformatTargets target, PixelInternalFormat internalFormat, GetInternalformatParameters pname)
        {
            int tmp = 0;
            Delegates.glGetInternalformativ(target, internalFormat, pname, 1, ref tmp);
            return tmp;
        }

        //ARB_texture_storage
        /// <summary>
        /// TexStorageXX allocates images with the given size (width​, height​, and depth​, where appropriate), with the number of mipmaps given by levels​. The storage is created here, but the contents of that storage is undefined.
        /// </summary>
        /// <param name="target">Valid target​: GL_TEXTURE_1D​</param>
        /// <param name="levels">Number of mipmaps to alloc.</param>
        /// <param name="piformat">Any Sized Internal format.</param>
        /// <param name="Width">Width of base mipmap.</param>
        /// <remarks>
        ///  immutable storage allocates all of the images for the texture all at once. Every mipmap level, array layer, and cube map face is all allocated with a single call, giving all of these images a specific Image Format. It is called "immutable" because once the storage is allocated, the storage cannot be changed. The texture can be deleted as normal, but the storage cannot be altered. A 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format will *always* be a 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format.
        ///  Note that what immutable storage refers to is the allocation of the memory, not the contents of that memory. You can upload different pixel data to immutable storage all you want. With mutable storage, you can re-vamp the storage of a texture object entirely, changing a 256x256 texture into a 1024x1024 texture.
        /// </remarks>
        public static void TexStorage1D(TextureTarget target, int levels, PixelInternalFormat piformat, int Width)
        {
            Delegates.glTexStorage1D(target, levels, piformat, Width);
        }
        /// <summary>
        /// TexStorageXX allocates images with the given size (width​, height​, and depth​, where appropriate), with the number of mipmaps given by levels​. The storage is created here, but the contents of that storage is undefined.
        /// For 1D array textures, the number of array layers in each mipmap level is the height​ value. For rectangle textures, the number of mipmap levels must be 1.
        /// </summary>
        /// <param name="target">Valid target​s: GL_TEXTURE_2D​, GL_TEXTURE_RECTANGE​, GL_TEXTURE_CUBEMAP​, or GL_TEXTURE_1D_ARRAY​.</param>
        /// <param name="levels">Number of mipmaps to alloc.</param>
        /// <param name="piformat">Any Sized Internal format.</param>
        /// <param name="Width">Width of base mipmap.</param>
        /// <param name="Height">Height of base mipmap. For 1D array textures, the number of array layers in each mipmap level is the height​ value. For rectangle textures, the number of mipmap levels must be 1.</param>
        /// <remarks>
        ///  immutable storage allocates all of the images for the texture all at once. Every mipmap level, array layer, and cube map face is all allocated with a single call, giving all of these images a specific Image Format. It is called "immutable" because once the storage is allocated, the storage cannot be changed. The texture can be deleted as normal, but the storage cannot be altered. A 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format will *always* be a 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format.
        ///  Note that what immutable storage refers to is the allocation of the memory, not the contents of that memory. You can upload different pixel data to immutable storage all you want. With mutable storage, you can re-vamp the storage of a texture object entirely, changing a 256x256 texture into a 1024x1024 texture.
        /// </remarks>
        public static void TexStorage2D(TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height)
        {
            Delegates.glTexStorage2D(target, levels, piformat, Width, Height);
        }
        /// <summary>
        /// TexStorageXX allocates images with the given size (width​, height​, and depth​, where appropriate), with the number of mipmaps given by levels​. The storage is created here, but the contents of that storage is undefined.
        /// For 2D array textures, the number of array layers in each mipmap level is the depth​ value. For 2D cubemap array textures, the number of cubemap layer-faces is the depth​, which must be a multiple of 6. Therefore, the number of individual cubemaps in the array is given by depth​ / 6.
        /// </summary>
        /// <param name="target">Valid target​s: GL_TEXTURE_3D​, GL_TEXTURE_2D_ARRAY​, GL_TEXTURE_CUBE_ARRAY​</param>
        /// <param name="levels">Number of mipmaps to alloc.</param>
        /// <param name="piformat">Any Sized Internal format.</param>
        /// <param name="Width">Width of base mipmap.</param>
        /// <param name="Height">Height of base mipmap.</param>
        /// <param name="Depth">Depth of base mipmap.For 2D array textures, the number of array layers in each mipmap level is the depth​ value.</param>
        /// <remarks>
        ///  immutable storage allocates all of the images for the texture all at once. Every mipmap level, array layer, and cube map face is all allocated with a single call, giving all of these images a specific Image Format. It is called "immutable" because once the storage is allocated, the storage cannot be changed. The texture can be deleted as normal, but the storage cannot be altered. A 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format will *always* be a 256x256 2D texture with 5 mipmap layers that uses the GL_RGBA8​ image format.
        ///  Note that what immutable storage refers to is the allocation of the memory, not the contents of that memory. You can upload different pixel data to immutable storage all you want. With mutable storage, you can re-vamp the storage of a texture object entirely, changing a 256x256 texture into a 1024x1024 texture.
        /// </remarks>
        public static void TexStorage3D(TextureTarget target, int levels, PixelInternalFormat piformat, int Width, int Height, int Depth)
        {
            Delegates.glTexStorage3D(target, levels, piformat, Width, Height, Depth);
        }

        //ARB_transform_feedback_-instanced 
        /// <summary>
        /// Same as DrawTransformFeedback but with instanced possibilities.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="TransformFeedbackId"></param>
        /// <param name="InstanceCount"></param>
        public static void DrawTransformFeedbackInstanced(BeginMode mode, uint TransformFeedbackId, int InstanceCount)
        {
            Delegates.glDrawTransformFeedbackInstanced(mode, TransformFeedbackId, InstanceCount);
        }
        /// <summary>
        /// Same as DrawTransformFeedbackStream but with instanced possibilities.
        /// </summary>
        /// <param name="mode"></param>
        /// <param name="TransformFeedbackId"></param>
        /// <param name="Stream"></param>
        /// <param name="InstanceCount"></param>
        public static void DrawTransformFeedbackStreamInstanced(BeginMode mode, uint TransformFeedbackId, uint Stream, int InstanceCount)
        {
            Delegates.glDrawTransformFeedbackStreamInstanced(mode, TransformFeedbackId, Stream, InstanceCount);
        }

        #endregion
    }
}
