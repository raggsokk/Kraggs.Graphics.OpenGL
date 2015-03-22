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
    /// TextureUnit Zero Based.
    /// </summary>
    public enum TextureUnit
    {
        //Texture0 = 0,
        //Texture1 = 1,
        //Texture2 = 2,
        //Texture3 = 3,
        //Texture4 = 4,
        //Texture5 = 5,
        //Texture6 = 6,
        //Texture7 = 7,
        //Texture8 = 8,
        //Texture9 = 9,

        //Texture10 = 10,
        //Texture11 = 11,
        //Texture12 = 12,
        //Texture13 = 13,
        //Texture14 = 14,
        //Texture15 = 15,
        //Texture16 = 16,
        //Texture17 = 17,
        //Texture18 = 18,
        //Texture19 = 19,

        //Texture20 = 20,
        //Texture21 = 21,
        //Texture22 = 22,
        //Texture23 = 23,
        //Texture24 = 24,
        //Texture25 = 25,
        //Texture26 = 26,
        //Texture27 = 27,
        //Texture28 = 28,
        //Texture29 = 29,

        //Texture30 = 30,
        //Texture31 = 31,


        // Summary:
        //     Original was GL_TEXTURE0 = 0x84C0
        Texture0 = 33984,
        //
        // Summary:
        //     Original was GL_TEXTURE1 = 0x84C1
        Texture1 = 33985,
        //
        // Summary:
        //     Original was GL_TEXTURE2 = 0x84C2
        Texture2 = 33986,
        //
        // Summary:
        //     Original was GL_TEXTURE3 = 0x84C3
        Texture3 = 33987,
        //
        // Summary:
        //     Original was GL_TEXTURE4 = 0x84C4
        Texture4 = 33988,
        //
        // Summary:
        //     Original was GL_TEXTURE5 = 0x84C5
        Texture5 = 33989,
        //
        // Summary:
        //     Original was GL_TEXTURE6 = 0x84C6
        Texture6 = 33990,
        //
        // Summary:
        //     Original was GL_TEXTURE7 = 0x84C7
        Texture7 = 33991,
        //
        // Summary:
        //     Original was GL_TEXTURE8 = 0x84C8
        Texture8 = 33992,
        //
        // Summary:
        //     Original was GL_TEXTURE9 = 0x84C9
        Texture9 = 33993,
        //
        // Summary:
        //     Original was GL_TEXTURE10 = 0x84CA
        Texture10 = 33994,
        //
        // Summary:
        //     Original was GL_TEXTURE11 = 0x84CB
        Texture11 = 33995,
        //
        // Summary:
        //     Original was GL_TEXTURE12 = 0x84CC
        Texture12 = 33996,
        //
        // Summary:
        //     Original was GL_TEXTURE13 = 0x84CD
        Texture13 = 33997,
        //
        // Summary:
        //     Original was GL_TEXTURE14 = 0x84CE
        Texture14 = 33998,
        //
        // Summary:
        //     Original was GL_TEXTURE15 = 0x84CF
        Texture15 = 33999,
        //
        // Summary:
        //     Original was GL_TEXTURE16 = 0x84D0
        Texture16 = 34000,
        //
        // Summary:
        //     Original was GL_TEXTURE17 = 0x84D1
        Texture17 = 34001,
        //
        // Summary:
        //     Original was GL_TEXTURE18 = 0x84D2
        Texture18 = 34002,
        //
        // Summary:
        //     Original was GL_TEXTURE19 = 0x84D3
        Texture19 = 34003,
        //
        // Summary:
        //     Original was GL_TEXTURE20 = 0x84D4
        Texture20 = 34004,
        //
        // Summary:
        //     Original was GL_TEXTURE21 = 0x84D5
        Texture21 = 34005,
        //
        // Summary:
        //     Original was GL_TEXTURE22 = 0x84D6
        Texture22 = 34006,
        //
        // Summary:
        //     Original was GL_TEXTURE23 = 0x84D7
        Texture23 = 34007,
        //
        // Summary:
        //     Original was GL_TEXTURE24 = 0x84D8
        Texture24 = 34008,
        //
        // Summary:
        //     Original was GL_TEXTURE25 = 0x84D9
        Texture25 = 34009,
        //
        // Summary:
        //     Original was GL_TEXTURE26 = 0x84DA
        Texture26 = 34010,
        //
        // Summary:
        //     Original was GL_TEXTURE27 = 0x84DB
        Texture27 = 34011,
        //
        // Summary:
        //     Original was GL_TEXTURE28 = 0x84DC
        Texture28 = 34012,
        //
        // Summary:
        //     Original was GL_TEXTURE29 = 0x84DD
        Texture29 = 34013,
        //
        // Summary:
        //     Original was GL_TEXTURE30 = 0x84DE
        Texture30 = 34014,
        //
        // Summary:
        //     Original was GL_TEXTURE31 = 0x84DF
        Texture31 = 34015,
    }
}
