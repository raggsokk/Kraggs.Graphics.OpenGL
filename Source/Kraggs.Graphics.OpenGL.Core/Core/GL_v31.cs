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
        //#region Delegate Class

        //partial class Delegates
        //{

        //    #region Delegates

        //    //ARB_copy_buffer
        //    public delegate void delCopyBufferSubData(BufferTarget readTarget, BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr Size);

        //    //ARB_draw_instanced
        //    public delegate void delDrawArraysInstanced(BeginMode mode, int first, int count, int InstanceCount);
        //    public delegate void delDrawElementsInstanced(BeginMode mode, int count, IndicesType type, IntPtr Indices, int InstanceCount);
        //    //ARB_uniform_buffer_object
        //    //public delegate void delGetUniformIndices(uint Program, int UniformCount, string[] UniformNames, uint[] UniformIndices);
        //    public delegate void delGetUniformIndices(uint Program, int UniformCount, ref string UniformNames, ref uint UniformIndices);
        //    public delegate uint delGetUniformBlockIndex(uint Program, string UniformBlockName);
        //    public delegate void delGetActiveUniformBlockName(uint Program, uint UniformBlockIndex, int bufSize, out int length, StringBuilder UniformBlockName);
        //    public delegate void delGetActiveUniformBlockiv(uint Program, uint UniformBlockIndex, UniformBlockParameters pname, ref int @params);
        //    public delegate void delUniformBlockBinding(uint Program, uint UniformBlockIndex, uint UniformBlockBinding);

        //    //ARB_primitive_restart
        //    public delegate void delPrimitiveRestartIndex(uint Index);
        //    //ARB_texture_rectangle
        //    //ARB_texture_buffer_object
        //    public delegate void delTexBuffer(BufferTextureTarget target, TextureBufferInternalFormat format, uint BufferId);


        //    #endregion

        //    #region GL Fields

        //    public static delCopyBufferSubData glCopyBufferSubData;

        //    //ARB_draw_instanced
        //    public static delDrawArraysInstanced glDrawArraysInstanced;
        //    public static delDrawElementsInstanced glDrawElementsInstanced;
        //    //ARB_uniform_buffer_object
        //    public static delGetUniformIndices glGetUniformIndices;
        //    public static delGetUniformBlockIndex glGetUniformBlockIndex;
        //    public static delGetActiveUniformBlockName glGetActiveUniformBlockName;
        //    public static delGetActiveUniformBlockiv glGetActiveUniformBlockiv;
        //    public static delUniformBlockBinding glUniformBlockBinding;

        //    //ARB_primitive_restart
        //    public static delPrimitiveRestartIndex glPrimitiveRestartIndex;
        //    //ARB_texture_rectangle
        //    //ARB_texture_buffer_object
        //    public static delTexBuffer glTexBuffer;


        //    #endregion
        //}

        //#endregion

        //#region Public functions.

        ////ARB_copy_buffer
        ///// <summary>
        ///// Copies between two buffers from bound readbuffer to bound writebuffer.
        ///// Note that this doesn't have to be CopyReadBuffer or CopyWriteBuffer, it can be between ArrayBuffer and UniformBuffer.
        ///// </summary>
        ///// <param name="readOffset">Offset in bytes from start of buffer bound to readtarget</param>
        ///// <param name="writeOffset">Offset in bytes from start of buffer bound to writetarget.</param>
        ///// <param name="Size">Size in bytes to copy from read to write.</param>
        ///// <param name="readTarget">Buffer target to read from, doesn't have to be CopyReadBuffer</param>
        ///// <param name="writeTarget">Buffer target to write to, doesn't have to be CopyWriteBuffer</param>
        //public static void CopyBufferSubData(long readOffset, long writeOffset, long Size, BufferTarget readTarget = BufferTarget.CopyReadBuffer, BufferTarget writeTarget = BufferTarget.CopyWriteBuffer)
        //{
        //    Delegates.glCopyBufferSubData(readTarget, writeTarget, (IntPtr)readOffset, (IntPtr)writeOffset, (IntPtr)Size);
        //}

        ////ARB_draw_instanced
        ///// <summary>
        ///// Same as DrawArrays except this calls generate Instance id inside shaders
        ///// </summary>
        ///// <param name="mode">Primitive Mode.</param>
        ///// <param name="first">start buffer.</param>
        ///// <param name="count">number of Primitive types to render.</param>
        ///// <param name="InstanceCount">Number of instances in [first, count] range.</param>
        //public static void DrawArraysInstanced(BeginMode mode, int first, int count, int InstanceCount)
        //{
        //    Delegates.glDrawArraysInstanced(mode, first, count, InstanceCount);
        //}

        ///// <summary>
        ///// Same as DrawElements excep this calls generate InstaceID inside shaders.
        ///// </summary>
        ///// <param name="mode">Primitive Mode to render.</param>
        ///// <param name="count">Number of primitives to render.</param>
        ///// <param name="type">Type of element/indices</param>
        ///// <param name="InstanceCount">Number of instances inside [Offset, Count] range.</param>
        ///// <param name="offset">Offset in bytes in bound Element/Indices buffer to source Element data from.</param>
        //public static void DrawElementsInstanced(BeginMode mode, int count, IndicesType type, int InstanceCount, long offset = 0)
        //{
        //    Delegates.glDrawElementsInstanced(mode, count, type, (IntPtr)offset, InstanceCount);
        //}
        ////ARB_uniform_buffer_object
        ///// <summary>
        ///// Retrives an array of uniform indices from an array of uniform names on a program.
        ///// </summary>
        ///// <param name="Program">Program to query.</param>
        ///// <param name="UniformNames">Array of UniformNames to get Indices for.</param>
        ///// <param name="UniformIndices">Preallocated array of same dimension as UniformNames.</param>
        //public static void GetUniformIndices(uint Program, string[] UniformNames, uint[] UniformIndices)
        //{
        //    var len = Math.Min(UniformNames.Length, UniformIndices.Length);
        //    //Delegates.glGetUniformIndices(Program, len, UniformNames, UniformIndices);
        //    Delegates.glGetUniformIndices(Program, len, ref UniformNames[0], ref UniformIndices[0]);
        //}
        ///// <summary>
        ///// Retrives an array indices for the array of unifornames on a program.
        ///// </summary>
        ///// <param name="Program">Program to query.</param>
        ///// <param name="UniformNames">Array of UniformNames to get Indices for.</param>
        ///// <returns></returns>
        //public static uint[] GetUniformIndices(uint Program, string[] UniformNames)
        //{
        //    var indices = new uint[UniformNames.Length];
        //    //Delegates.glGetUniformIndices(Program, UniformNames.Length, UniformNames, indices);
        //    Delegates.glGetUniformIndices(Program, indices.Length, ref UniformNames[0], ref indices[0]);
        //    return indices;
        //}
        ///// <summary>
        ///// Returns the BlockIndex of a UniformBlock in a program.
        ///// </summary>
        ///// <param name="Program">Program to Query.</param>
        ///// <param name="UniformBlockName">Name of UniformBlock</param>
        ///// <returns></returns>
        //public static uint GetUniformBlockIndex(uint Program, string UniformBlockName)
        //{
        //    return Delegates.glGetUniformBlockIndex(Program, UniformBlockName);
        //}
        ///// <summary>
        ///// Returns the name of a uniform block at block index location on a program.
        ///// </summary>
        ///// <param name="Program">Program to query.</param>
        ///// <param name="UniformBlockIndex">Block index to get name for.</param>
        ///// <param name="bufSize"></param>
        ///// <param name="length"></param>
        ///// <param name="UniformBlockName"></param>
        //public static void GetActiveUniformBlockName(uint Program, uint UniformBlockIndex, int bufSize, out int length, StringBuilder UniformBlockName)
        //{
        //    Delegates.glGetActiveUniformBlockName(Program, UniformBlockIndex, bufSize, out length, UniformBlockName);
        //}
        ///// <summary>
        ///// Returns the name of a uniform block at block index location on a program.
        ///// </summary>
        ///// <param name="Program">Program to query.</param>
        ///// <param name="UniformBlockIndex">Block index to get name for.</param>
        ///// <param name="MaxUniformBlockNameLength">The capacity of the allocated StringBuilder used to retrive UniformBlockName.</param>
        ///// <returns></returns>
        //public static string GetActiveUniformBlockName(uint Program, uint UniformBlockIndex, int MaxUniformBlockNameLength = 64)        
        //{
        //    var sb = new StringBuilder(MaxUniformBlockNameLength + 4);
        //    Delegates.glGetActiveUniformBlockName(Program, UniformBlockIndex, sb.Capacity - 2, out MaxUniformBlockNameLength, sb);
        //    return sb.ToString();
        //    //Delegates.glGetActiveUniformBlockName(Program, UniformBlockIndex, bufSize, out length, UniformBlockName);
        //}

        ///// <summary>
        ///// Retrives a parameter from a UniformBlock in program.
        ///// </summary>
        ///// <param name="Program">Program to query</param>
        ///// <param name="UniformBlockIndex">Index of UniformBlock to query.</param>
        ///// <param name="pname">Name of parameter to retrive.</param>
        ///// <param name="params">result</param>
        //public static void GetActiveUniformBlockiv(uint Program, uint UniformBlockIndex, UniformBlockParameters pname, int[] @params)
        //{
        //    Delegates.glGetActiveUniformBlockiv(Program, UniformBlockIndex, pname, ref @params[0]);
        //}
        ///// <summary>
        ///// Retrives a parameter from a UniformBlock in program.
        ///// </summary>
        ///// <param name="Program">Program to query</param>
        ///// <param name="UniformBlockIndex">Index of UniformBlock to query.</param>
        ///// <param name="pname">Name of parameter to retrive.</param>
        ///// <returns></returns>
        //public static int GetActiveUniformBlockiv(uint Program, uint UniformBlockIndex, UniformBlockParameters pname)
        //{
        //    int tmp = 0;
        //    Delegates.glGetActiveUniformBlockiv(Program, UniformBlockIndex, pname, ref tmp);
        //    return tmp;
        //}

        ///// <summary>
        ///// Sets up the UniformBlockIndex to UniformBlockBinding Index mapping.
        ///// Example:
        /////     Program shader has two UniformBlocks which by default is index 0 and 1.
        /////     We have to uniform buffers (1,2) we want to bind as backing store to uniform blocks in program.
        /////     
        /////     // set up blockindex to binding index mapping.
        /////     glUniformBlockBinding(ProgID, 0, 3) // BlockBindingIndex choosen is not relevant.
        /////     glUniformBlockBinding(ProgID, 0, 5) // BlockBindingIndex choosen is not relevant.
        /////     // bind buffers to binding index.        
        /////     glBindBufferBase(UniformBuffer, 3, 1) // binds bufferid 1 to blockbindingindex 3
        /////     glBindBufferBase(UniformBuffer, 5, 2) // binds bufferid 2 to blockbindingindex 5.
        /////     // now Uniformblock at index 0 will use bufferid 1 as backing store.
        /////     // and UniformBlock at index 1 will use bufferid 2 as backing store.
        ///// </summary>
        ///// <param name="Program">Program to set</param>
        ///// <param name="UniformBlockIndex">Index of uniform block to set.</param>
        ///// <param name="UniformBlockBinding">Binding index to use as backstore for Uniform Block idnex.</param>
        //public static void UniformBlockBinding(uint Program, uint UniformBlockIndex, uint UniformBlockBinding)
        //{
        //    Delegates.glUniformBlockBinding(Program, UniformBlockIndex, UniformBlockBinding);
        //}

        ////ARB_primitive_restart
        ///// <summary>
        ///// Specifies a number as a primitive restart marker.
        ///// Example: PrimitiveRestartIndex(ushort.MaxValue -1)
        ///// Everytime drawelements[xxx] finds this number it starts a new primitive.
        ///// </summary>
        ///// <param name="Index"></param>
        //public static void PrimitiveRestartIndex(uint Index)
        //{
        //    Delegates.glPrimitiveRestartIndex(Index);
        //}
        ////ARB_texture_rectangle
        ////ARB_texture_buffer_object
        ///// <summary>
        ///// Creates a Texture buffer from a created buffer id on current bound texture id?.
        ///// </summary>
        ///// <param name="format">Desired internal format of this texture buffer.</param>
        ///// <param name="BufferId">Buffer id to create on.</param>
        ///// <param name="target">Type of texture buffer to create.</param>
        //public static void TexBuffer(TextureBufferInternalFormat format, uint BufferId, BufferTextureTarget target = BufferTextureTarget.TextureBuffer)
        //{
        //    Delegates.glTexBuffer(target, format, BufferId);
        //}


        //#endregion
    }
}
