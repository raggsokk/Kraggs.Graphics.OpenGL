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
    /// <summary>
    /// OpenGL External Pixel Data Format Enumeration.
    /// </summary>
    public enum PixelFormat
    {
        /// <summary>
        /// Invalid.
        /// </summary>
        EXTERNAL_NONE = 0,					//GL_NONE

        EXTERNAL_RED = 0x1903,				//GL_RED
        EXTERNAL_RG = 0x8227,				//GL_RG
        EXTERNAL_RGB = 0x1907,				//GL_RGB
        EXTERNAL_BGR = 0x80E0,				//GL_BGR
        EXTERNAL_RGBA = 0x1908,				//GL_RGBA
        EXTERNAL_BGRA = 0x80E1,				//GL_BGRA
        EXTERNAL_RED_INTEGER = 0x8D94,		//GL_RED_INTEGER
        EXTERNAL_RG_INTEGER = 0x8228,		//GL_RG_INTEGER
        EXTERNAL_RGB_INTEGER = 0x8D98,		//GL_RGB_INTEGER
        EXTERNAL_BGR_INTEGER = 0x8D9A,		//GL_BGR_INTEGER
        EXTERNAL_RGBA_INTEGER = 0x8D99,		//GL_RGBA_INTEGER
        EXTERNAL_BGRA_INTEGER = 0x8D9B,		//GL_BGRA_INTEGER
        EXTERNAL_DEPTH = 0x1902,			//GL_DEPTH_COMPONENT
        EXTERNAL_DEPTH_STENCIL = 0x84F9,	//GL_DEPTH_STENCIL
        EXTERNAL_STENCIL = 0x1901,          //GL_STENCIL_INDEX, GL 4.4



        //StencilIndex = All.STENCIL_INDEX,
        //DepthComponent = All.DEPTH_COMPONENT,
        //DepthStencil = All.DEPTH_STENCIL,

        //Red = All.RED,
        //Green = All.GREEN,
        //Blue = All.BLUE,

        //RG = All.RG,
        //RGB = All.RGB,
        //RGBA = All.RGBA,
        //BGR = All.BGR,
        //BGRA = All.BGRA,

        //RedInt = All.RED_INTEGER,
        //GreenInt = All.GREEN_INTEGER,
        //BlueInt = All.BLUE_INTEGER,
        //RGInt = All.RG_INTEGER,
        //RGBInt = All.RGB_INTEGER,
        //RGBAInt = All.RGBA_INTEGER,
        //BGRInt = All.BGR_INTEGER,
        //BGRAInt = All.BGRA_INTEGER,
    }
}
