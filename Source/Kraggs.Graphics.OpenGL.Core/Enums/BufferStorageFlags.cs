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
    [Flags]
    public enum BufferStorageFlags
    {
        /// <summary>
        /// Immutable, nonmappable buffer storage.
        /// </summary>
        None = All.NONE,
        MapRead = All.MAP_READ_BIT,
        MapWrite = All.MAP_WRITE_BIT,
        MapPersistent = All.MAP_PERSISTENT_BIT,
        MapCoherent = All.MAP_COHERENT_BIT,
        DynamicStorage = All.DYNAMIC_STORAGE_BIT,
        ClientStorage = All.CLIENT_STORAGE_BIT,
        //ARB_sparse_buffer
        /// <summary>
        /// If <flags> contains SPARSE_STORAGE_BIT_ARB, then it may not also contain any combination of MAP_READ_BIT or MAP_WRITE_BIT.
        /// SPARSE_STORAGE_BIT_ARB The data store of the buffer object is sparse, consisting only of a virtual allocation. Physical storage for buffer contents may be later allocated and assigned using BufferPageCommitmentARB. Initially, the entire data store is uncommitted.As a side effect, the data specified in the<data> parameter is discarded, although the GL may still acces the client's address space within the specified region.
        /// </summary>
        SparseStorage = All.SPARSE_STORAGE_BIT_ARB,
    }
}
