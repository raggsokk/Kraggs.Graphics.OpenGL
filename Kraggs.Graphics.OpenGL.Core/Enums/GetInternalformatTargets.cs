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
    /// Used by GetInternalformativ to retrive target and internalformat combo information.
    /// </summary>
    public enum GetInternalformatTargets
    {
        Texture1D = All.TEXTURE_1D,
        Texture1DArray = All.TEXTURE_1D_ARRAY,
        Texture2D = All.TEXTURE_2D,
        Texture2DArray = All.TEXTURE_2D_ARRAY,
        Texture3D = All.TEXTURE_3D,
        TextureCubemap = All.TEXTURE_CUBE_MAP,
        TextureCubemapArray = All.TEXTURE_CUBE_MAP_ARRAY,
        TextureRectangle = All.TEXTURE_RECTANGLE,
        TextureBuffer = All.TEXTURE_BUFFER,

        Renderbuffer = All.RENDERBUFFER,
        Texture2DMultisample = All.TEXTURE_2D_MULTISAMPLE,
        Texture2DMultisampleArray = All.TEXTURE_2D_MULTISAMPLE_ARRAY,
    }
}
