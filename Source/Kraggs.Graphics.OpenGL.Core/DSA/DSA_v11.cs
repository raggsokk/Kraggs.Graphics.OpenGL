#region License

// Kraggs.Graphics.OpenGL (github.com/raggsokk)
//
// Copyright (c) 2014 Jarle Hansen (github.com/raggsokk)
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
    // template class until gl 4.4 where its not neede for another year.
    partial class DSA
    {
        //#region Delegate Class

        //partial class Delegates
        //{

        //    #region Delegates

        //    public delegate void delBindMultiTextureEXT(TextureUnit texUnit, TextureTarget target, uint TextureID);

        //    public delegate void delTextureParameteriEXT(uint TextureID, TextureTarget target, TextureParameters pname, int param);
        //    public delegate void delTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int[] param);
        //    public delegate void delTextureParameterfEXT(uint TextureID, TextureTarget target, TextureParameters pname, float param);
        //    public delegate void delTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float[] param);

        //    public delegate void delTextureImage1DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int border, PixelFormat format, PixelType type, IntPtr data);
        //    public delegate void delTextureImage2DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr data);
        //    public delegate void delTextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr data);
        //    public delegate void delTextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr data);
        //    public delegate void delGetTextureImageEXT(uint TextureID, TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr img);
        //    public delegate void delGetTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref int @params);
        //    public delegate void delGetTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref float @params);
        //    public delegate void delGetTextureLevelParameterfvEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, ref float @params);
        //    public delegate void delGetTextureLevelParameterivEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, ref int @params);

        //    #endregion

        //    #region GL Fields

        //    public static delBindMultiTextureEXT glBindMultiTextureEXT;

        //    public static delTextureParameteriEXT glTextureParameteriEXT;
        //    public static delTextureParameterivEXT glTextureParameterivEXT;
        //    public static delTextureParameterfEXT glTextureParameterfEXT;
        //    public static delTextureParameterfvEXT glTextureParameterfvEXT;

        //    public static delTextureImage1DEXT glTextureImage1DEXT;
        //    public static delTextureImage2DEXT glTextureImage2DEXT;
        //    public static delTextureSubImage1DEXT glTextureSubImage1DEXT;
        //    public static delTextureSubImage2DEXT glTextureSubImage2DEXT;
        //    public static delGetTextureImageEXT glGetTextureImageEXT;
        //    public static delGetTextureParameterivEXT glGetTextureParameterivEXT;
        //    public static delGetTextureParameterfvEXT glGetTextureParameterfvEXT;
        //    public static delGetTextureLevelParameterfvEXT glGetTextureLevelParameterfvEXT;
        //    public static delGetTextureLevelParameterivEXT glGetTextureLevelParameterivEXT;

        //    #endregion
        //}

        //#endregion

        //#region Public functions.

        ///// <summary>
        ///// Binds a texture to a texture unit and texture target in one call.
        ///// </summary>
        ///// <param name="texUnit">The TextureUnit to bind texture to.</param>
        ///// <param name="target">The TextureTarget to bind texture as.</param>
        ///// <param name="TextureID">The id of the texture to bind.</param>
        //public static void BindMultiTextureEXT(TextureUnit texUnit, TextureTarget target, uint TextureID)
        //{
        //    Delegates.glBindMultiTextureEXT(texUnit, target, TextureID);
        //}


        //public static void TextureParameteriEXT(uint TextureID, TextureTarget target, TextureParameters pname, int param)
        //{
        //    Delegates.glTextureParameteriEXT(TextureID, target, pname, param);
        //}
        //public static void TextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int[] param)
        //{
        //    Delegates.glTextureParameterivEXT(TextureID, target, pname, param);
        //}
        //public static void TextureParameterfEXT(uint TextureID, TextureTarget target, TextureParameters pname, float param)
        //{
        //    Delegates.glTextureParameterfEXT(TextureID, target, pname, param);
        //}
        //public static void TextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float[] param)
        //{
        //    Delegates.glTextureParameterfvEXT(TextureID, target, pname, param);
        //}

        ///// <summary>
        ///// see TexImage1D
        ///// </summary>
        ///// <param name="TextureID"></param>
        ///// <param name="target"></param>
        ///// <param name="level"></param>
        ///// <param name="piformat"></param>
        ///// <param name="width"></param>
        ///// <param name="format"></param>
        ///// <param name="type"></param>
        ///// <param name="data"></param>
        //public static void TextureImage1DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, PixelFormat format, PixelType type, IntPtr data)
        //{
        //    Delegates.glTextureImage1DEXT(TextureID, target, level, piformat, width, 0, format, type, data);
        //}
        ///// <summary>
        ///// see TexImage2D
        ///// </summary>
        ///// <param name="TextureID"></param>
        ///// <param name="target"></param>
        ///// <param name="level"></param>
        ///// <param name="piformat"></param>
        ///// <param name="width"></param>
        ///// <param name="height"></param>
        ///// <param name="format"></param>
        ///// <param name="type"></param>
        ///// <param name="data"></param>
        //public static void TextureImage2DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, PixelFormat format, PixelType type, IntPtr data)
        //{
        //    Delegates.glTextureImage2DEXT(TextureID, target, level, piformat, width, height, 0, format, type, data);
        //}

        ///// <summary>
        ///// see TexSubImage1D
        ///// </summary>
        ///// <param name="TextureID"></param>
        ///// <param name="target"></param>
        ///// <param name="level"></param>
        ///// <param name="xoffset"></param>
        ///// <param name="width"></param>
        ///// <param name="format"></param>
        ///// <param name="type"></param>
        ///// <param name="data"></param>
        //public static void TextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr data)
        //{
        //    Delegates.glTextureSubImage1DEXT(TextureID, target, level, xoffset, width, format, type, data);
        //}
        ///// <summary>
        ///// see TexSubImage2D
        ///// </summary>
        ///// <param name="TextureID"></param>
        ///// <param name="target"></param>
        ///// <param name="level"></param>
        ///// <param name="xoffset"></param>
        ///// <param name="yoffset"></param>
        ///// <param name="width"></param>
        ///// <param name="height"></param>
        ///// <param name="format"></param>
        ///// <param name="type"></param>
        ///// <param name="data"></param>
        //public static void TextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr data)
        //{
        //    Delegates.glTextureSubImage2DEXT(TextureID, target, level, xoffset, yoffset, width, height, format, type, data);
        //}

        ///// <summary>
        ///// Retrives a single texture mipmap level from specified texture id and writes them to img in specified pixelformat and PixelType.
        ///// </summary>
        ///// <param name="TextureID">The texture id of texture to get.</param>
        ///// <param name="target">The Target type of specified texture id.</param>
        ///// <param name="level">The mipmap level to retrive.</param>
        ///// <param name="format">The format to retrive as.</param>
        ///// <param name="type">The pixel typ eto retrive as.</param>
        ///// <param name="img">if pixelpack binding is non-zero, treats img as a byte-offset into that buffer to write at, otherwise writes to pointer in system memory specified by img.</param>
        //public static void GetTextureImageEXT(uint TextureID, TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr img)
        //{
        //    Delegates.glGetTextureImageEXT(TextureID, target, level, format, type, img);
        //}


        //public static void GetTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int[] @params)
        //{
        //    Delegates.glGetTextureParameterivEXT(TextureID, target, pname, ref @params[0]);
        //}
        //public static int GetTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname)
        //{
        //    int tmp = 0;
        //    Delegates.glGetTextureParameterivEXT(TextureID, target, pname, ref tmp);
        //    return tmp;
        //}
        //public static void GetTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float[] @params)
        //{
        //    Delegates.glGetTextureParameterfvEXT(TextureID, target, pname, ref @params[0]);
        //}
        //public static float GetTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname)
        //{
        //    float tmp = 0.0f;
        //    Delegates.glGetTextureParameterfvEXT(TextureID, target, pname, ref tmp);
        //    return tmp;
        //}

        //public static void GetTextureLevelParameterfvEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, float[] @params)
        //{
        //    Delegates.glGetTextureLevelParameterfvEXT(TextureID, target, level, pname, ref  @params[0]);
        //}
        //public static float GetTextureLevelParameterfvEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname)
        //{
        //    float tmp = 0.0f;
        //    Delegates.glGetTextureLevelParameterfvEXT(TextureID, target, level, pname, ref tmp);
        //    return tmp;
        //}
        //public static void GetTextureLevelParameterivEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, int[] @params)
        //{
        //    Delegates.glGetTextureLevelParameterivEXT(TextureID, target, level, pname, ref @params[0]);
        //}
        //public static int GetTextureLevelParameterivEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname)
        //{
        //    int tmp = 0;
        //    Delegates.glGetTextureLevelParameterivEXT(TextureID, target, level, pname, ref tmp);
        //    return tmp;
        //}



        //#endregion

        #region OpenGL DLLImports

        //[EntryPointSlot(1)]
        //[DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        //private static extern void glBindTexture(TextureTarget target, uint textureid);

        [EntryPointSlot(1)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindMultiTextureEXT(TextureUnit texUnit, TextureTarget target, uint TextureID);

        [EntryPointSlot(2)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureParameteriEXT(uint TextureID, TextureTarget target, TextureParameters pname, int param);
        [EntryPointSlot(3)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int* param);
        [EntryPointSlot(4)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureParameterfEXT(uint TextureID, TextureTarget target, TextureParameters pname, float param);
        [EntryPointSlot(5)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float* param);

        [EntryPointSlot(6)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureImage1DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int border, PixelFormat format, PixelType type, IntPtr data);
        [EntryPointSlot(7)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureImage2DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr data);
        [EntryPointSlot(8)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr data);
        [EntryPointSlot(9)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glTextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr data);
        [EntryPointSlot(10)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glGetTextureImageEXT(uint TextureID, TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr img);
        [EntryPointSlot(11)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int* result);
        [EntryPointSlot(12)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float* result);
        [EntryPointSlot(13)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureLevelParameterfvEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, float* result);
        [EntryPointSlot(14)]
        [DllImport(LIBRARY, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        unsafe private static extern void glGetTextureLevelParameterivEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, int* result);


        #endregion

        #region Public functions

        /// <summary>
        /// Binds a texture to a texture unit and texture target in one call.
        /// </summary>
        /// <param name="texUnit">The TextureUnit to bind texture to.</param>
        /// <param name="target">The TextureTarget to bind texture as.</param>
        /// <param name="TextureID">The id of the texture to bind.</param>
        [EntryPoint(FunctionName = "glBindMultiTextureEXT")]
        public static void BindMultiTextureEXT(TextureUnit texUnit, TextureTarget target, uint TextureID){ throw new NotImplementedException(); }

        
        [EntryPoint(FunctionName = "glTextureParameteriEXT")]
        public static void TextureParameteriEXT(uint TextureID, TextureTarget target, TextureParameters pname, int param){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureParameterivEXT")]
        unsafe public static void TextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int* param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterivEXT")]
        public static void TextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int[] param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterivEXT")]
        public static void TextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref int param) { throw new NotImplementedException(); }

        [EntryPoint(FunctionName = "glTextureParameterfEXT")]
        public static void TextureParameterfEXT(uint TextureID, TextureTarget target, TextureParameters pname, float param){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureParameterfvEXT")]
        unsafe public static void TextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float* param){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterfvEXT")]
        public static void TextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float[] param) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glTextureParameterfvEXT")]
        public static void TextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref float param) { throw new NotImplementedException(); }


        [EntryPoint(FunctionName = "glTextureImage1DEXT")]
        public static void TextureImage1DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int border, PixelFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureImage2DEXT")]
        public static void TextureImage2DEXT(uint TextureID, TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureSubImage1DEXT")]
        public static void TextureSubImage1DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glTextureSubImage2DEXT")]
        public static void TextureSubImage2DEXT(uint TextureID, TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr data){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetTextureImageEXT")]
        public static void GetTextureImageEXT(uint TextureID, TextureTarget target, int level, PixelFormat format, PixelType type, IntPtr img){ throw new NotImplementedException(); }
        
        [EntryPoint(FunctionName = "glGetTextureParameterivEXT")]
        unsafe public static void GetTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterivEXT")]
        public static void GetTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterivEXT")]
        public static void GetTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref int result) { throw new NotImplementedException(); }
        public static int GetTextureParameterivEXT(uint TextureID, TextureTarget target, TextureParameters pname)
        {
            int tmp = 0;
            GetTextureParameterivEXT(TextureID, target, pname, ref tmp);
            return tmp;
        }

        [EntryPoint(FunctionName = "glGetTextureParameterfvEXT")]
        unsafe public static void GetTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterfvEXT")]
        public static void GetTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, float[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureParameterfvEXT")]
        public static void GetTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname, ref float result) { throw new NotImplementedException(); }
        
        public static float GetTextureParameterfvEXT(uint TextureID, TextureTarget target, TextureParameters pname)
        {
            float tmp = 0.0f;
            GetTextureParameterfvEXT(TextureID, target, pname, ref tmp);
            return tmp;
        }

        [EntryPoint(FunctionName = "glGetTextureLevelParameterfvEXT")]
        unsafe public static void GetTextureLevelParameterfvEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, float* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureLevelParameterfvEXT")]
        public static void GetTextureLevelParameterfvEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, float[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureLevelParameterfvEXT")]
        public static void GetTextureLevelParameterfvEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, ref float result) { throw new NotImplementedException(); }

        public static float GetTextureLevelParameterfvEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname)
        {
            float tmp = 0.0f;
            GetTextureLevelParameterfvEXT(TextureID, target, level, pname, ref tmp);
            return tmp;
        }

        [EntryPoint(FunctionName = "glGetTextureLevelParameterivEXT")]
        unsafe public static void GetTextureLevelParameterivEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, int* result){ throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureLevelParameterivEXT")]
        public static void GetTextureLevelParameterivEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, int[] result) { throw new NotImplementedException(); }
        [EntryPoint(FunctionName = "glGetTextureLevelParameterivEXT")]
        public static void GetTextureLevelParameterivEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname, ref int result) { throw new NotImplementedException(); }
        
        public static int GetTextureLevelParameterivEXT(uint TextureID, TextureTarget target, int level, TextureLevelParameters pname)
        {
            int tmp = 0;
            GetTextureLevelParameterivEXT(TextureID, target, level, pname, ref tmp);
            return tmp;
        }

        #endregion

        #region Public Helper Functions

        #endregion
    }
}
