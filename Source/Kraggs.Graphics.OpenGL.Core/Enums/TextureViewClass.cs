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
    public enum TextureViewClass
    {
        ViewClass128Bits = 0x82C4,
        ViewClass96Bits = 0x82C5,
        ViewClass64Bits = 0x82C6,
        ViewClass48Bits = 0x82C7,
        ViewClass32Bits = 0x82C8,
        ViewClass24Bits = 0x82C9,
        ViewClass16Bits = 0x82CA,
        ViewClass8Bits = 0x82CB,
        ViewClassS3TC_DXT1_RGB = 0x82CC,
        ViewClassS3TC_DXT1_RGBA = 0x82CD,
        ViewClassS3TC_DXT3_RGBA = 0x82CE,
        ViewClassS3TC_DXT5_RGBA = 0x82CF,
        ViewClassRGTC1_RED = 0x82D0,
        ViewClassRGTC2_RG = 0x82D1,
        ViewClassBPTC_UNORM = 0x82D2,
        ViewClassBPTC_FLOAT = 0x82D3,
    }
}
