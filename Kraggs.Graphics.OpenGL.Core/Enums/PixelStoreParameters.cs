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
    public enum PixelStoreParameters
    {
        PackSwapBytes = All.PACK_SWAP_BYTES,
        PackLsbFirst = All.PACK_LSB_FIRST,
        PackRowLength = All.PACK_ROW_LENGTH,
        PackImageHeight = All.PACK_IMAGE_HEIGHT,
        PackSkipPixels = All.PACK_SKIP_PIXELS,
        PackSkipRows = All.PACK_SKIP_ROWS,
        PackSkipImages = All.PACK_SKIP_IMAGES,
        PackAlignment = All.PACK_ALIGNMENT,

        UnpackSwapBytes = All.UNPACK_SWAP_BYTES,
        UnpackLsbFirst = All.UNPACK_LSB_FIRST,
        UnpackRowLength = All.UNPACK_ROW_LENGTH,
        UnpackImageHeight = All.UNPACK_IMAGE_HEIGHT,
        UnpackSkipPixels = All.UNPACK_SKIP_PIXELS,
        UnpackSkipRows = All.UNPACK_SKIP_ROWS,
        UnpackSkipImages = All.UNPACK_SKIP_IMAGES,
        UnpackAlignment = All.UNPACK_ALIGNMENT,

        PackCompressedBlockWidth = All.PACK_COMPRESSED_BLOCK_WIDTH,
        PackCompressedBlockHeight = All.PACK_COMPRESSED_BLOCK_HEIGHT,
        PackCompressedBlockDepth = All.PACK_COMPRESSED_BLOCK_DEPTH,
        PackCompressedBlockSize = All.PACK_COMPRESSED_BLOCK_SIZE,

        UnpackCompressedBlockWidth = All.UNPACK_COMPRESSED_BLOCK_WIDTH,
        UnpackCompressedBlockHeight = All.UNPACK_COMPRESSED_BLOCK_HEIGHT,
        UnpackCompressedBlockDepth = All.UNPACK_COMPRESSED_BLOCK_DEPTH,
        UnpackCompressedBlockSize = All.UNPACK_COMPRESSED_BLOCK_SIZE,
    }
}
