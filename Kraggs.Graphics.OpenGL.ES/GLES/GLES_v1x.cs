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

    partial class GLES
    {
        #region Delegate Class

        partial class Delegates
        {
            #region Delegates

            public delegate void delActiveTexture(TextureUnit unit);
            public delegate void delBindBuffer(BufferTarget target, uint BufferID);
            public delegate void delBindTexture(TextureTarget target, uint TextureID);
            public delegate void delBlendFunc(BlendFactorSrc src, BlendFactorDst dst);
            public delegate void delBufferData(BufferTarget target, IntPtr size, IntPtr data, BufferUsage usage);
            public delegate void delBufferSubData(BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            public delegate void delClear(ClearBufferFlags mask);
            public delegate void delClearStencil(int s);
            public delegate void delColorMask(bool red, bool green, bool blue, bool alpha);
            public delegate void delCompressedTexImage2D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, int imageSize, IntPtr data);
            public delegate void delCompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelInternalFormat format, int imageSize, IntPtr data);
            public delegate void delCopyTexImage2D(TextureTarget target, int level, PixelInternalFormat piformat, int x, int y, int width, int height, int border);
            public delegate void delCopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
            public delegate void delCullFace(CullMode mode);
            public delegate void delDeleteTextures(int number, ref uint textures);
            public delegate void delDeleteBuffers(int number, ref uint BufferIDs);
            public delegate void delDepthFunc(DepthFunction function);
            public delegate void delDepthMask(bool writeable);
            public delegate void delDepthRangef(float nearVal, float farVal);
            public delegate void delDrawArrays(BeginMode mode, int first, int count);
            public delegate void delDrawElements(BeginMode mode, int count, IndicesType type, IntPtr ptr);
            public delegate void delDisable(EnableState cap);
            public delegate void delEnable(EnableState cap);
            public delegate void delFinish();
            public delegate void delFlush();
            public delegate void delFrontFace(FrontFaceMode mode);
            public delegate void delGenBuffers(int number, ref uint BufferIDs);
            public delegate void delGenTextures(int number, ref uint textures);
            public delegate void delGetBooleanv(GetParameters pname, ref bool @params);
            public delegate void delGetFloatv(GetParameters pname, ref float @params);
            public delegate void delGetIntegerv(GetParameters pname, ref int @params);
            public delegate void delGetBufferParameteriv(BufferTarget target, BufferParameters pname, ref int @params);
            public delegate ErrorCode delGetError();
            public delegate IntPtr delGetString(StringName name);
            public delegate void delGetTexParameteriv(TextureTarget target, TextureParameters pname, ref int @params);
            public delegate void delHint(HintTarget target, HintMode mode);
            public delegate bool delIsBuffer(uint BufferID);
            public delegate bool delIsEnabled(EnableState cap);
            public delegate bool delIsTexture(uint textureid);
            
            public delegate void delPixelStorei(PixelStoreParameters pname, int param);
            
            public delegate void delReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr data);
            public delegate void delSampleCoverage(float value, bool Invert);
            public delegate void delScissor(int x, int y, int width, int height);
            public delegate void delStencilFunc(StencilFunction function, int @ref, uint mask);
            public delegate void delStencilMask(uint mask);
            public delegate void delStencilOp(StencilOperation fail, StencilOperation zfail, StencilOperation zpass);            
            public delegate void delTexImage2D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr data);
            public delegate void delTexParameteri(TextureTarget target, TextureParameters pname, int param);
            public delegate void delTexParameteriv(TextureTarget target, TextureParameters pname, int[] param);
            public delegate void delTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr data);
            public delegate void delViewport(int x, int y, int width, int height);




            /*
             * ActiveTexture
             * BindBuffer
             * BindTexture
             * BlendFunc
             * BufferData
             * BufferSubData
             * Clear
             * ClearColor
             * ClearDepth
             * ClearStencil
             * ColorMask
             * CompressedTexImage2D
             * CompressedTexSubImage2D
             * CopyTexImage2D
             * CopyTexSubImage2D
             * CullFace
             * DeleteBuffers
             * DeleteTextures 
             * DepthFunc
             * DepthMask
             * DepthRange
             * DrawArrays
             * DrawElements
             * Disable
             * Enable
             * Finish
             * Flush
             * FrontFace
             * GenBuffers
             * GenTextures
             * GetBooleanv
             * GetIntegerv
             * GetFloatv
             * GetBufferParameteriv
             * GetError
             * GetString
             * GetTexParameteriv
             * Hint
             * IsBuffer
             * IsEnabled
             * IsTexture
             * LineWidth
             * PixelStorei
             * PolygonOffset
             * ReadPixels
             * SampleCoverage
             * Scissor
             * StencilFunc
             * StencilMask
             * StencilOp
             * TexImage2D
             * TexParameteri
             * TexParameteriv
             * TexSubImage2D 
             * Viewport
             */            



            #endregion

            #region GL Fields

            public static delActiveTexture glActiveTexture;
            public static delBindBuffer glBindBuffer;
            public static delBindTexture glBindTexture;
            public static delBlendFunc glBlendFunc;
            public static delBufferData glBufferData;
            public static delBufferSubData glBufferSubData;
            public static delClear glClear;
            public static delClearStencil glClearStencil;
            public static delColorMask glColorMask;
            public static delCompressedTexImage2D glCompressedTexImage2D;
            public static delCompressedTexSubImage2D glCompressedTexSubImage2D;
            public static delCopyTexImage2D glCopyTexImage2D;
            public static delCopyTexSubImage2D glCopyTexSubImage2D;
            public static delCullFace glCullFace;
            public static delDeleteTextures glDeleteTextures;
            public static delDeleteBuffers glDeleteBuffers;
            public static delDepthFunc glDepthFunc;
            public static delDepthMask glDepthMask;
            public static delDepthRangef glDepthRangef;
            public static delDrawArrays glDrawArrays;
            public static delDrawElements glDrawElements;
            public static delDisable glDisable;
            public static delEnable glEnable;
            public static delFinish glFinish;
            public static delFlush glFlush;
            public static delFrontFace glFrontFace;
            public static delGenBuffers glGenBuffers;
            public static delGenTextures glGenTextures;
            public static delGetBooleanv glGetBooleanv;
            public static delGetFloatv glGetFloatv;
            public static delGetIntegerv glGetIntegerv;
            public static delGetBufferParameteriv glGetBufferParameteriv;
            public static delGetError glGetError;
            public static delGetString glGetString;
            public static delGetTexParameteriv glGetTexParameteriv;
            public static delHint glHint;
            public static delIsBuffer glIsBuffer;
            public static delIsEnabled glIsEnabled;
            public static delIsTexture glIsTexture;
            public static delPixelStorei glPixelStorei;
            public static delReadPixels glReadPixels;
            public static delSampleCoverage glSampleCoverage;
            public static delScissor glScissor;
            public static delStencilFunc glStencilFunc;
            public static delStencilMask glStencilMask;
            public static delStencilOp glStencilOp;
            public static delTexImage2D glTexImage2D;
            public static delTexParameteri glTexParameteri;
            public static delTexParameteriv glTexParameteriv;
            public static delTexSubImage2D glTexSubImage2D;
            public static delViewport glViewport;


            #endregion
        }

        #endregion

        #region Public functions.

        public static void ActiveTexture(TextureUnit unit)
        {
            Delegates.glActiveTexture(unit);
        }
        public static void BindBuffer(BufferTarget target, uint BufferID)
        {
            Delegates.glBindBuffer(target, BufferID);
        }
        public static void BindTexture(TextureTarget target, uint TextureID)
        {
            Delegates.glBindTexture(target, TextureID);
        }
        public static void BlendFunc(BlendFactorSrc src, BlendFactorDst dst)
        {
            Delegates.glBlendFunc(src, dst);
        }

        public static void BufferData(BufferTarget target, long size, IntPtr data, BufferUsage usage)
        {
            Delegates.glBufferData(target, (IntPtr)size, data, usage);
        }

        public static void BufferSubData(BufferTarget target, long offset, long size, IntPtr data)
        {
            Delegates.glBufferSubData(target, (IntPtr)offset, (IntPtr)size, data);
        }

        public static void Clear(ClearBufferFlags mask)
        {
            Delegates.glClear(mask);
        }

        public static void ClearStencil(int s)
        {
            Delegates.glClearStencil(s);
        }

        public static void ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            Delegates.glColorMask(red, green, blue, alpha);
        }

        public static void CompressedTexImage2D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, int imageSize, IntPtr data, int border = 0)
        {
            Delegates.glCompressedTexImage2D(target, level, piformat, width, height, border, imageSize, data);
        }

        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelInternalFormat format, int imageSize, IntPtr data)
        {
            Delegates.glCompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        public static void CopyTexImage2D(TextureTarget target, int level, PixelInternalFormat piformat, int x, int y, int width, int height, int border = 0)
        {
            Delegates.glCopyTexImage2D(target, level, piformat, x, y, width, height, border);
        }

        public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        {
            Delegates.glCopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
        }

        public static void CullFace(CullMode mode)
        {
            Delegates.glCullFace(mode);
        }
        public static void DeleteTextures(uint[] textures)
        {
            Delegates.glDeleteTextures(textures.Length, ref textures[0]);
        }
        public static void DeleteTextures(int number, ref uint textures)
        {
            Delegates.glDeleteTextures(number, ref textures);
        }
        public static void DeleteBuffers(uint[] BufferIDs)
        {
            Delegates.glDeleteBuffers(BufferIDs.Length, ref BufferIDs[0]);
        }
        public static void DeleteBuffers(int number, ref uint BufferIDs)
        {
            Delegates.glDeleteBuffers(number, ref BufferIDs);
        }

        public static void DepthFunc(DepthFunction function)
        {
            Delegates.glDepthFunc(function);
        }

        public static void DepthMask(bool writeable)
        {
            Delegates.glDepthMask(writeable);
        }


        public static void DepthRangef(float nearVal, float farVal)
        {
            Delegates.glDepthRangef(nearVal, farVal);
        }

        public static void DrawArrays(BeginMode mode, int first, int count)
        {
            Delegates.glDrawArrays(mode, first, count);
        }

        public static void DrawElements(BeginMode mode, int count, IndicesType type, IntPtr ptr)
        {
            Delegates.glDrawElements(mode, count, type, ptr);
        }

        public static void Disable(EnableState cap)
        {
            Delegates.glDisable(cap);
        }

        public static void Enable(EnableState cap)
        {
            Delegates.glEnable(cap);
        }

        public static void Finish()
        {
            Delegates.glFinish();
        }

        public static void Flush()
        {
            Delegates.glFlush();
        }

        public static void FrontFace(FrontFaceMode mode)
        {
            Delegates.glFrontFace(mode);
        }
        public static uint GenBuffers()
        {
            var tmp = new uint[1];
            Delegates.glGenBuffers(1, ref tmp[0]);
            return tmp[0];
        }
        public static void GenBuffers(uint[] BufferIDs)
        {
            if(BufferIDs.Length >0)
                Delegates.glGenBuffers(BufferIDs.Length, ref BufferIDs[0]);
        }
        public static void GenBuffers(int number, ref uint BufferIDs)
        {
            Delegates.glGenBuffers(number, ref BufferIDs);
        }

        public static uint GenTextures()
        {
            var tmp = new uint[1];
            Delegates.glGenTextures(1, ref tmp[0]);
            return tmp[0];
        }
        public static void GenTextures(uint[] textures)
        {
            Delegates.glGenTextures(textures.Length, ref textures[0]);
        }
        public static void GenTextures(int number, ref uint textures)
        {
            Delegates.glGenTextures(number, ref textures);
        }
        public static bool GetBooleanv(GetParameters pname)
        {
            bool tmp = false;
            Delegates.glGetBooleanv(pname, ref tmp);
            return tmp;
        }
        //public static void GetBooleanv(GetParameters pname, bool[] @params)
        //{
        //    Delegates.glGetBooleanv(pname, ref @params[0]);
        //}
        public static void GetBooleanv(GetParameters pname, ref bool @params)
        {
            Delegates.glGetBooleanv(pname, ref @params);
        }
        public static float GetFloatv(GetParameters pname)
        {
            float tmp = 0.0f;
            Delegates.glGetFloatv(pname, ref tmp);
            return tmp;
        }
        public static void GetFloatv(GetParameters pname, ref float @params)
        {
            Delegates.glGetFloatv(pname, ref @params);
        }
        public static int GetIntegerv(GetParameters pname)
        {
            int tmp = 0;
            Delegates.glGetIntegerv(pname, ref tmp);
            return tmp;
        }
        public static void GetIntegerv(GetParameters pname, ref int @params)
        {
            Delegates.glGetIntegerv(pname, ref @params);
        }
        public static int GetBufferParameteriv(BufferTarget target, BufferParameters pname)
        {
            int tmp = 0;
            Delegates.glGetBufferParameteriv(target, pname, ref tmp);
            return tmp;
        }
        public static void GetBufferParameteriv(BufferTarget target, BufferParameters pname, ref int @params)
        {
            Delegates.glGetBufferParameteriv(target, pname, ref @params);
        }

        public static ErrorCode GetError()
        {
            return Delegates.glGetError();
        }

        public static string GetString(StringName name)
        {
            var ptr = Delegates.glGetString(name);
            if (ptr != IntPtr.Zero)
                return Marshal.PtrToStringAnsi(ptr);
            else
                return string.Empty;
        }
        public static int GetTexParameteriv(TextureTarget target, TextureParameters pname)
        {
            var tmp = 0;
            Delegates.glGetTexParameteriv(target, pname, ref tmp);
            return tmp;
        }
        public static void GetTexParameteriv(TextureTarget target, TextureParameters pname, ref int @params)
        {
            Delegates.glGetTexParameteriv(target, pname, ref @params);
        }

        public static void Hint(HintTarget target, HintMode mode)
        {
            Delegates.glHint(target, mode);
        }

        public static bool IsBuffer(uint BufferID)
        {
            return Delegates.glIsBuffer(BufferID);
        }

        public static bool IsEnabled(EnableState cap)
        {
            return Delegates.glIsEnabled(cap);
        }

        public static bool IsTexture(uint TextureID)
        {
            return Delegates.glIsTexture(TextureID);
        }

        public static void PixelStorei(PixelStoreParameters pname, int param)
        {
            Delegates.glPixelStorei(pname, param);
        }

        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, IntPtr data)
        {
            Delegates.glReadPixels(x, y, width, height, format, type, data);
        }

        public static void SampleCoverage(float value, bool Invert)
        {
            Delegates.glSampleCoverage(value, Invert);
        }

        public static void Scissor(int x, int y, int width, int height)
        {
            Delegates.glScissor(x, y, width, height);
        }

        public static void StencilFunc(StencilFunction function, int @ref, uint mask)
        {
            Delegates.glStencilFunc(function, @ref, mask);
        }

        public static void StencilMask(uint mask)
        {
            Delegates.glStencilMask(mask);
        }

        public static void StencilOp(StencilOperation fail, StencilOperation zfail, StencilOperation zpass)
        {
            Delegates.glStencilOp(fail, zfail, zpass);
        }

        public static void TexImage2D(TextureTarget target, int level, PixelInternalFormat piformat, int width, int height, PixelFormat format, PixelType type, IntPtr data, int border = 0)
        {
            Delegates.glTexImage2D(target, level, piformat, width, height, border, format, type, data);
        }

        public static void TexParameteri(TextureTarget target, TextureParameters pname, int param)
        {
            Delegates.glTexParameteri(target, pname, param);
        }

        public static void TexParameteriv(TextureTarget target, TextureParameters pname, int[] param)
        {
            Delegates.glTexParameteriv(target, pname, param);
        }

        public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr data)
        {
            Delegates.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, data);
        }

        public static void Viewport(int x, int y, int width, int height)
        {
            Delegates.glViewport(x, y, width, height);
        }



        #endregion
    }
}
