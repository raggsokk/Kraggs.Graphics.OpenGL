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
    public enum TextureLevelParameters
    {
        Width = All.TEXTURE_WIDTH,
        Height = All.TEXTURE_HEIGHT,
        Depth = All.TEXTURE_DEPTH,
        InternalFormat = All.TEXTURE_INTERNAL_FORMAT,
        //BorderColor = All.TEXTURE_BORDER_COLOR

        RedSize = All.TEXTURE_RED_SIZE,
        GreenSize = All.TEXTURE_GREEN_SIZE,
        BlueSize = All.TEXTURE_BLUE_SIZE,
        AlphaSize = All.TEXTURE_ALPHA_SIZE,
        DepthSize = All.TEXTURE_DEPTH_SIZE,
        StencilSize = All.TEXTURE_STENCIL_SIZE,

        RedType = All.TEXTURE_RED_TYPE,
        GreenType = All.TEXTURE_GREEN_TYPE,
        BlueType = All.TEXTURE_BLUE_TYPE,
        AlphaType = All.TEXTURE_ALPHA_TYPE,
        DepthType = All.TEXTURE_DEPTH_TYPE,

        Compressed = All.TEXTURE_COMPRESSED,
        CompressedImageSize = All.TEXTURE_COMPRESSED_IMAGE_SIZE,

        TextureBufferOffset = All.TEXTURE_BUFFER_OFFSET,
        TextureBufferSize = All.TEXTURE_BUFFER_SIZE,
    }
}
