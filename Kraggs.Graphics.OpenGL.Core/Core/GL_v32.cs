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

            //ARB_draw_elements_base_vertex
            public delegate void delDrawElementsBaseVertex(BeginMode mode, int count, IndicesType type, IntPtr Indices, int BaseVertex);
            public delegate void delDrawElementsInstancedBaseVertex(BeginMode mode, int count, IndicesType type, IntPtr Indices, int InstanceCount, int BaseVertex);
            public delegate void delDrawRangeElementsBaseVertex(BeginMode mode, uint start, uint end, int count, IndicesType type, IntPtr Indices, int BaseVertex);
            public delegate void delMultiDrawElementsBaseVertex(BeginMode mode, ref int Count, IndicesType type, ref IntPtr Indices, int drawCount, ref int BaseVertex);
            //ARB_provoking_vertex
            public delegate void delProvokingVertex(ProvokeVertexMode mode);

            //ARB_sync
            public delegate void delDeleteSync(IntPtr Sync);
            public delegate IntPtr delFenceSync(SyncCondition condition, int flagsZero);
            public delegate bool delIsSync(IntPtr Sync);
            public delegate void delGetSynciv(IntPtr Sync, SyncParameters pname, int bufSize, out int Length, ref int values);

            public delegate ClientWaitSyncStatus delClientWaitSync(IntPtr Sync, SyncFlags flags, ulong timeout_ns);
            public delegate void delWaitSync(IntPtr Sync, SyncFlags flags, ulong timeout);

            public delegate void delGetInteger64v(GetParameters pname, ref long @params);
            public delegate void delGetInteger64i_v(GetParameters pname, uint index, ref long @params);
            public delegate void delGetBufferParameteri64v(GetParameters pname, ref long param);

            //ARB_texture_multisample
            public delegate void delGetMultisamplefv(MultisampleParameters pname, uint index, ref float val);
            public delegate void delSampleMaski(uint MaskNumber, uint mask);
            public delegate void delTexImage2DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations);
            public delegate void delTexImage3DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations);
            
            //ARB_geometry_shader4
            public delegate void delFramebufferTexture(FramebufferTarget target, FramebufferAttachmentType attachment, uint TextureID, int level);
            public delegate void delFramebufferTextureLayer(FramebufferTarget target, FramebufferAttachmentType attachment, uint TextureID, int level, int layer);

            #endregion

            #region GL Fields

            public static delDrawElementsBaseVertex glDrawElementsBaseVertex;
            public static delDrawElementsInstancedBaseVertex glDrawElementsInstancedBaseVertex;
            public static delDrawRangeElementsBaseVertex glDrawRangeElementsBaseVertex;
            public static delMultiDrawElementsBaseVertex glMultiDrawElementsBaseVertex;
            //ARB_provoking_vertex
            public static delProvokingVertex glProvokingVertex;

            //ARB_sync
            public static delDeleteSync glDeleteSync;
            public static delFenceSync glFenceSync;
            public static delIsSync glIsSync;
            public static delGetSynciv glGetSynciv;

            public static delClientWaitSync glClientWaitSync;
            public static delWaitSync glWaitSync;

            public static delGetInteger64v glGetInteger64v;
            public static delGetInteger64i_v glGetInteger64i_v;
            public static delGetBufferParameteri64v glGetBufferParameteri64v;

            //ARB_texture_multisample
            public static delGetMultisamplefv glGetMultisamplefv;
            public static delSampleMaski glSampleMaski;
            public static delTexImage2DMultisample glTexImage2DMultisample;
            public static delTexImage3DMultisample glTexImage3DMultisample;
            
            //ARB_geometry_shader4
            public static delFramebufferTexture glFramebufferTexture;
            public static delFramebufferTextureLayer glFramebufferTextureLayer;


            #endregion
        }

        #endregion

        #region Public functions.

        /// <summary>
        /// DrawElementsBaseVertex behaves identically to DrawElements except that the ith element transferred by the corresponding draw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting value is larger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned integers (with wrapping on overflow conditions). The operation is undefined if the sum would be negative.
        /// </summary>
        /// <param name="mode">Primitive mode</param>
        /// <param name="count">Number of primitive types to render.</param>
        /// <param name="type">Element/Indices type.</param>
        /// <param name="Offset">Offset into current element/indices buffer bound to retive element/indices from.</param>
        /// <param name="BaseVertex">Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.</param>
        public static void DrawElementsBaseVertex(BeginMode mode, int count, IndicesType type, long Offset, int BaseVertex)
        {
            Delegates.glDrawElementsBaseVertex(mode, count, type, (IntPtr)Offset, BaseVertex);
        }

        /// <summary>
        /// DrawElementsInstancedBaseVertex behaves identically to DrawElementsInstanced except that the ith element transferred by the corresponding draw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting value is larger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned integers (with wrapping on overflow conditions). The operation is undefined if the sum would be negative.
        /// </summary>
        /// <param name="mode">Primitive mode</param>
        /// <param name="count">Number of primitive types to render.</param>
        /// <param name="type">Element/Indices type.</param>
        /// <param name="Offset">Offset into current element/indices buffer bound to retive element/indices from.</param>
        /// <param name="InstanceCount">Number of instances to render.</param>
        /// <param name="BaseVertex">Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.</param>
        public static void DrawElementsInstancedBaseVertex(BeginMode mode, int count, IndicesType type, long Offset, int InstanceCount, int BaseVertex)
        {
            Delegates.glDrawElementsInstancedBaseVertex(mode, count, type, (IntPtr)Offset, InstanceCount, BaseVertex);
        }
        /// <summary>
        /// glDrawRangeElementsBaseVertex is a restricted form of glDrawElementsBaseVertex. mode, start, end, count and basevertex match the corresponding arguments to glDrawElementsBaseVertex, with the additional constraint that all values in the array indices must lie between start and end, inclusive, prior to adding basevertex. Index values lying outside the range [start, end] are treated in the same way as glDrawElementsBaseVertex. The ith element transferred by the corresponding draw call will be taken from element indices[i] + basevertex of each enabled array. If the resulting value is larger than the maximum value representable by type, it is as if the calculation were upconverted to 32-bit unsigned integers (with wrapping on overflow conditions). The operation is undefined if the sum would be negative.
        /// </summary>
        /// <param name="mode">Primitive mode</param>
        /// <param name="start">Specifies the minimum array index contained in indices.</param>
        /// <param name="end">Specifies the maximum array index contained in indices.</param>
        /// <param name="count">Specifies the number of elements to be rendered.</param>
        /// <param name="type">Element/Indices type.</param>
        /// <param name="Offset">Offset into current element/indices buffer bound to retive element/indices from.</param>
        /// <param name="BaseVertex">Specifies a constant that should be added to each element of indices when chosing elements from the enabled vertex arrays.</param>
        public static void DrawRangeElementsBaseVertex(BeginMode mode, uint start, uint end, int count, IndicesType type, long Offset, int BaseVertex)
        {
            Delegates.glDrawRangeElementsBaseVertex(mode, start, end, count, type, (IntPtr)Offset, BaseVertex);
        }
        /// <summary>
        /// render multiple sets of primitives by specifying indices of array data elements and an index to apply to each index
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="Count">An array of the elements counts.</param>
        /// <param name="type">Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</param>
        /// <param name="Indices"></param>
        /// <param name="drawCount">Specifies the size of the count, indices and basevertex arrays.</param>
        /// <param name="BaseVertex"></param>
        public static void MultiDrawElementsBaseVertex(BeginMode mode, int[] Count, IndicesType type, IntPtr[] Indices, int drawCount, int[] BaseVertex)
        {
            Delegates.glMultiDrawElementsBaseVertex(mode, ref Count[0], type, ref Indices[0], drawCount, ref BaseVertex[0]);
        }
        /// <summary>
        /// render multiple sets of primitives by specifying indices of array data elements and an index to apply to each index
        /// </summary>
        /// <param name="mode">Specifies what kind of primitives to render.</param>
        /// <param name="Count">An array of the elements counts.</param>
        /// <param name="type">Specifies the type of the values in indices. Must be one of GL_UNSIGNED_BYTE, GL_UNSIGNED_SHORT, or GL_UNSIGNED_INT.</param>
        /// <param name="IndiceOffsets">An array of the element/indices offsets.</param>
        /// <param name="BaseVertex">An array of the basevertices.</param>
        public static void MultiDrawElementsBaseVertex(BeginMode mode, int[] Count, IndicesType type, long[] IndiceOffsets, int[] BaseVertex)
        {
            var drawcount = Math.Min(Count.Length, Math.Min(IndiceOffsets.Length, BaseVertex.Length));

            var iptrs = new IntPtr[IndiceOffsets.Length];
            for (int i = 0; i < iptrs.Length; i++)
                iptrs[i] = (IntPtr)IndiceOffsets[i];

            Delegates.glMultiDrawElementsBaseVertex(mode, ref Count[0], type, ref iptrs[0], drawcount, ref BaseVertex[0]);
        }


        //ARB_provoking_vertex
        /// <summary>
        /// Sets the provking vertex mode.
        /// </summary>
        /// <param name="mode"></param>
        public static void ProvokingVertex(ProvokeVertexMode mode)
        {
            Delegates.glProvokingVertex(mode);
        }

        //ARB_sync
        /// <summary>
        /// Deletes a sync object.
        /// </summary>
        /// <param name="Sync">Sync pointer to delete.</param>
        public static void DeleteSync(IntPtr Sync)
        {
            Delegates.glDeleteSync(Sync);
        }
        /// <summary>
        /// glFenceSync creates a new fence sync object, inserts a fence command into the GL command stream and associates it with that sync object, and returns a non-zero name corresponding to the sync object.
        /// </summary>
        /// <param name="condition">Specifies the condition that must be met to set the sync object's state to signaled. condition must be GL_SYNC_GPU_COMMANDS_COMPLETE.</param>
        /// <param name="flagsZero">Specifies a bitwise combination of flags controlling the behavior of the sync object. No flags are presently defined for this operation and flags must be zero.</param>
        /// <returns>New Sync Object</returns>
        /// <remarks>
        /// glFenceSync creates a new fence sync object, inserts a fence command into the GL command stream and associates it with that sync object, and returns a non-zero name corresponding to the sync object.
        /// When the specified condition of the sync object is satisfied by the fence command, the sync object is signaled by the GL, causing any glWaitSync, glClientWaitSync commands blocking in sync to unblock. No other state is affected by glFenceSync or by the execution of the associated fence command.
        /// condition must be GL_SYNC_GPU_COMMANDS_COMPLETE. This condition is satisfied by completion of the fence command corresponding to the sync object and all preceding commands in the same command stream. The sync object will not be signaled until all effects from these commands on GL client and server state and the framebuffer are fully realized. Note that completion of the fence command occurs once the state of the corresponding sync object has been changed, but commands waiting on that sync object may not be unblocked until after the fence command completes.
        /// </remarks>
        public static IntPtr FenceSync(SyncCondition condition = SyncCondition.GpuCommandsComplete, int flagsZero = 0)
        {
            return Delegates.glFenceSync(condition, flagsZero);
        }
        /// <summary>
        /// IS this pointer a sync object?
        /// </summary>
        /// <param name="Sync"></param>
        /// <returns></returns>
        public static bool IsSync(IntPtr Sync)
        {
            return Delegates.glIsSync(Sync);
        }

        /// <summary>
        /// Retrives sync properties.
        /// </summary>
        /// <param name="Sync">Sync object to query.</param>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="Length">How many ints was written to values?</param>
        /// <param name="values">Prealloceted array with enough space to store result of query.</param>
        public static void GetSynciv(IntPtr Sync, SyncParameters pname, out int Length, int[] values)
        {
            Delegates.glGetSynciv(Sync, pname, values.Length, out Length, ref values[0]);
        }

        /// <summary>
        /// block and wait for a sync object to become signaled
        /// </summary>
        /// <param name="Sync">The sync object whose status to wait on.</param>
        /// <param name="flags">A bitfield controlling the command flushing behavior. flags may be GL_SYNC_FLUSH_COMMANDS_BIT.</param>
        /// <param name="timeout_ns">The timeout, specified in nanoseconds, for which the implementation should wait for sync to become signaled.</param>
        /// <returns>
        /// <list type="bullet">
        ///   <listheader>The return value is one of four status values:</listheader>
        ///   <item>GL_ALREADY_SIGNALED indicates that sync was signaled at the time that glClientWaitSync was called.</item>
        ///   <item>GL_TIMEOUT_EXPIRED indicates that at least timeout nanoseconds passed and sync did not become signaled.</item>
        ///   <item>GL_CONDITION_SATISFIED indicates that sync was signaled before the timeout expired.</item>
        ///   <item>GL_WAIT_FAILED indicates that an error occurred. Additionally, an OpenGL error will be generated.</item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// glClientWaitSync causes the client to block and wait for the sync object specified by sync to become signaled. If sync is signaled when glClientWaitSync is called, glClientWaitSync returns immediately, otherwise it will block and wait for up to timeout nanoseconds for sync to become signaled.
        /// </remarks>
        public static ClientWaitSyncStatus ClientWaitSync(IntPtr Sync, SyncFlags flags, ulong timeout_ns)
        {
            return Delegates.glClientWaitSync(Sync, flags, timeout_ns);
        }
        /// <summary>
        /// instruct the GL server to block until the specified sync object becomes signaled
        /// </summary>
        /// <param name="Sync">Specifies the sync object whose status to wait on.</param>
        /// <param name="flags">A bitfield controlling the command flushing behavior. flags may be zero.</param>
        /// <param name="timeout">Specifies the timeout that the server should wait before continuing. timeout must be GL_TIMEOUT_IGNORED.</param>
        /// <remarks>
        /// glWaitSync causes the GL server to block and wait until sync becomes signaled. sync is the name of an existing sync object upon which to wait. flags and timeout are currently not used and must be set to zero and the special value GL_TIMEOUT_IGNORED, respectively[1]. glWaitSync will always wait no longer than an implementation-dependent timeout. The duration of this timeout in nanoseconds may be queried by calling glGet with the parameter GL_MAX_SERVER_WAIT_TIMEOUT. There is currently no way to determine whether glWaitSync unblocked because the timeout expired or because the sync object being waited on was signaled.
        /// If an error occurs, glWaitSync does not cause the GL server to block.
        /// </remarks>
        public static void WaitSync(IntPtr Sync, SyncFlags flags = SyncFlags.Zero, ulong timeout = TIMEOUT_IGNORED)
        {
            Delegates.glWaitSync(Sync, flags, timeout);
        }

        /// <summary>
        /// Retrives an possible array long sized parameter value.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="params">Preallocated array to write result into.</param>
        public static void GetInteger64v(GetParameters pname, long[] @params)
        {
            Delegates.glGetInteger64v(pname, ref @params[0]);
        }
        /// <summary>
        /// Retrives a single long sized parameter value.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <returns>result.</returns>
        public static long GetInteger64v(GetParameters pname)
        {
            long tmp = 0;
            Delegates.glGetInteger64v(pname, ref tmp);
            return tmp;
        }

        /// <summary>
        /// Retrives a possible array long sized parameters from an indexed target.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning of index is dependent on Paramenter Name.</param>
        /// <param name="params">Preallocated long array to write result of sufficient size.</param>
        public static void GetInteger64i_v(GetParameters pname, uint index, long[] @params)
        {
            Delegates.glGetInteger64i_v(pname, index, ref @params[0]);
        }
        /// <summary>
        /// Retrives a single long sized parameter value from an indexed target.
        /// </summary>
        /// <param name="pname">Name of parameter to retrive.</param>
        /// <param name="index">Meaning of index is dependant on parameter name.</param>
        /// <returns>result.</returns>
        public static long GetInteger64i_v(GetParameters pname, uint index)
        {
            long tmp = 0;
            Delegates.glGetInteger64i_v(pname, index, ref tmp);
            return tmp;
        }

        public static void GetBufferParameteri64v(GetParameters pname, ref long param)
        {
            Delegates.glGetBufferParameteri64v(pname, ref param);
        }
        public static long GetBufferParameteri64v(GetParameters pname)
        {
            long tmp = 0;
            Delegates.glGetBufferParameteri64v(pname, ref tmp);
            return tmp;
        }


        //ARB_texture_multisample
        /// <summary>
        /// retrieve the location of a sample (on multisample framebuffers)
        /// If the multisample mode does not have fixed sample locations, the returned values may only reflect the locations of samples within some pixels.
        /// </summary>
        /// <param name="pname">Specifies the sample parameter name. pname must be GL_SAMPLE_POSITION.</param>
        /// <param name="index">index must be between zero and the value of GL_SAMPLES - 1.</param>
        /// <param name="val">The sample location is returned as two floating-point values in val[0] and val[1], each between 0 and 1, corresponding to the x and y locations respectively in the GL pixel space of that sample. (0.5, 0.5) this corresponds to the pixel center.</param>
        public static void GetMultisamplefv(MultisampleParameters pname, uint index, float[] val)
        {
            Delegates.glGetMultisamplefv(pname, index, ref val[0]);
        }
        /// <summary>
        /// retrieve the location of a sample (on multisample framebuffers)
        /// If the multisample mode does not have fixed sample locations, the returned values may only reflect the locations of samples within some pixels.
        /// </summary>
        /// <param name="pname">Specifies the sample parameter name. pname must be GL_SAMPLE_POSITION.</param>
        /// <param name="index">index must be between zero and the value of GL_SAMPLES - 1.</param>
        /// <returns>The sample location is returned as two floating-point values in val[0] and val[1], each between 0 and 1, corresponding to the x and y locations respectively in the GL pixel space of that sample. (0.5, 0.5) this corresponds to the pixel center.</returns>
        public static float[] GetMultisamplefv(MultisampleParameters pname, uint index)
        {
            float[] tmp = new float[2];
            Delegates.glGetMultisamplefv(pname, index, ref tmp[0]);
            return tmp;
        }

        /// <summary>
        /// set the value of a sub-word of the sample mask
        /// </summary>
        /// <param name="MaskNumber">Specifies which 32-bit sub-word of the sample mask to update.</param>
        /// <param name="mask">Specifies the new value of the mask sub-word.</param>
        /// <remarks>
        /// glSampleMaski sets one 32-bit sub-word of the multi-word sample mask, GL_SAMPLE_MASK_VALUE.
        /// maskIndex specifies which 32-bit sub-word of the sample mask to update, and mask specifies the new value to use for that sub-word. maskIndex must be less than the value of GL_MAX_SAMPLE_MASK_WORDS. Bit B of mask word M corresponds to sample 32 x M + B.
        /// glSampleMaski is available only if the GL version is 3.2 or greater, or if the ARB_texture_multisample extension is supported.
        /// </remarks>
        public static void SampleMaski(uint MaskNumber, uint mask)
        {
            Delegates.glSampleMaski(MaskNumber, mask);
        }
        /// <summary>
        /// Allocates a multisample texture. Multisample texture can't have mipmaps.
        /// </summary>
        /// <param name="target">Texture target with currently bound texture id to create multisample storage for.</param>
        /// <param name="samples">Number of samples to use.</param>
        /// <param name="piformat">Format of multisample texture.</param>
        /// <param name="width">Width</param>
        /// <param name="height">Height</param>
        /// <param name="fixedSampleLocations">Use fixed sample locations?</param>
        public static void TexImage2DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations)
        {
            Delegates.glTexImage2DMultisample(target, samples, piformat, width, height, fixedSampleLocations);
        }
        /// <summary>
        /// Allocates a multisample texture. Multisample texture can't have mipmaps.
        /// </summary>
        /// <param name="target">Texture target with currently bound texture id to create multisample storage for.</param>
        /// <param name="samples">Number of samples to use.</param>
        /// <param name="piformat">Format of multisample texture.</param>
        /// <param name="width">Width</param>
        /// <param name="height">Height</param>
        /// <param name="depth">Depth</param>
        /// <param name="fixedSampleLocations">Use fixed sample locations?</param>
        public static void TexImage3DMultisample(TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations)
        {
            Delegates.glTexImage3DMultisample(target, samples, piformat, width, height, depth, fixedSampleLocations);
        }

        
        //ARB_geometry_shader4
        /// <summary>
        /// Attaches a texture mipmap level to specified attachment point on framebuffer current bound to specified target.
        /// Simplified version of FrameBufferTexture1D,FrameBufferTexture2D,FrameBufferTexture3D.
        /// </summary>
        /// <param name="target">Framebuffer target with bound framebuffer to attach to.</param>
        /// <param name="attachment">Attachment point on framebuffer to attach to.</param>
        /// <param name="TextureID">Texture id to attach.</param>
        /// <param name="level">Texture Mipmap level to attach.</param>
        /// <remarks>
        /// glFramebufferTexture, glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture attach a selected mipmap level or image of a texture object as one of the logical buffers of the framebuffer object currently bound to target. target must be GL_DRAW_FRAMEBUFFER, GL_READ_FRAMEBUFFER, or GL_FRAMEBUFFER. GL_FRAMEBUFFER is equivalent to GL_DRAW_FRAMEBUFFER.
        /// attachment specifies the logical attachment of the framebuffer and must be GL_COLOR_ATTACHMENTi, GL_DEPTH_ATTACHMENT, GL_STENCIL_ATTACHMENT or GL_DEPTH_STENCIL_ATTACHMENT. i in GL_COLOR_ATTACHMENTi may range from zero to the value of GL_MAX_COLOR_ATTACHMENTS - 1. Attaching a level of a texture to GL_DEPTH_STENCIL_ATTACHMENT is equivalent to attaching that level to both the GL_DEPTH_ATTACHMENT and the GL_STENCIL_ATTACHMENT attachment points simultaneously.
        /// textarget specifies what type of texture is named by texture, and for cube map textures, specifies the face that is to be attached. If texture is not zero, it must be the name of an existing texture with type textarget, unless it is a cube map texture, in which case textarget must be GL_TEXTURE_CUBE_MAP_POSITIVE_X GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// If texture is non-zero, the specified level of the texture object named texture is attached to the framebfufer attachment point named by attachment. For glFramebufferTexture1D, glFramebufferTexture2D, and glFramebufferTexture3D, texture must be zero or the name of an existing texture with a target of textarget, or texture must be the name of an existing cube-map texture and textarget must be one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
        /// If textarget is GL_TEXTURE_RECTANGLE, GL_TEXTURE_2D_MULTISAMPLE, or GL_TEXTURE_2D_MULTISAMPLE_ARRAY, then level must be zero. If textarget is GL_TEXTURE_3D, then level must be greater than or equal to zero and less than or equal to log2 of the value of GL_MAX_3D_TEXTURE_SIZE. If textarget is one of GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, or GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, then level must be greater than or equal to zero and less than or equal to log2 of the value of GL_MAX_CUBE_MAP_TEXTURE_SIZE. For all other values of textarget, level must be greater than or equal to zero and no larger than log2 of the value of GL_MAX_TEXTURE_SIZE.
        /// layer specifies the layer of a 2-dimensional image within a 3-dimensional texture.
        /// For glFramebufferTexture1D, if texture is not zero, then textarget must be GL_TEXTURE_1D. For glFramebufferTexture2D, if texture is not zero, textarget must be one of GL_TEXTURE_2D, GL_TEXTURE_RECTANGLE, GL_TEXTURE_CUBE_MAP_POSITIVE_X, GL_TEXTURE_CUBE_MAP_POSITIVE_Y, GL_TEXTURE_CUBE_MAP_POSITIVE_Z, GL_TEXTURE_CUBE_MAP_NEGATIVE_X, GL_TEXTURE_CUBE_MAP_NEGATIVE_Y, GL_TEXTURE_CUBE_MAP_NEGATIVE_Z, or GL_TEXTURE_2D_MULTISAMPLE. For glFramebufferTexture3D, if texture is not zero, then textarget must be GL_TEXTURE_3D.
        /// </remarks>
        public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachmentType attachment, uint TextureID, int level = 0)
        {
            Delegates.glFramebufferTexture(target, attachment, TextureID, level);
        }

        /// <summary>
        /// glFramebufferTextureLayer operates like glFramebufferTexture, except that only a single layer of the texture level, given by layer, is attached to the attachment point
        /// Attaches a single texture layers mipmap to a specifed attachment point on framebuffer currently bound to specified target.
        /// </summary>
        /// <param name="fboTarget">Framebuffer target with bound framebuffer to attach to.</param>
        /// <param name="attachment">Attachment point on framebuffer to attach to.</param>
        /// <param name="TextureID">Specifies the texture object to attach to the framebuffer attachment point named by attachment.</param>
        /// <param name="level">Specifies the mipmap level of texture to attach.</param>
        /// <param name="Layer">Specifies the layer of texture to attach.</param>
        /// <remarks>
        /// glFramebufferTextureLayer operates like glFramebufferTexture, except that only a single layer of the texture level, given by layer, is attached to the attachment point. If texture is not zero, layer must be greater than or equal to zero. texture must either be zero or the name of an existing three-dimensional texture, one- or two-dimensional array texture, or multisample array texture.
        /// </remarks>
        public static void FramebufferTextureLayer(FramebufferTarget fboTarget, FramebufferAttachmentType attachment, uint TextureID, int level = 0, int Layer= 0)
        {
            Delegates.glFramebufferTextureLayer(fboTarget, attachment, TextureID, level, Layer);
        }


        #endregion
    }
}
