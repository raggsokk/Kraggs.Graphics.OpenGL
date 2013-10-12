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
    partial class DSA
    {
        #region Delegate Class

        partial class Delegates
        {

            #region Delegates

            //ARB_texture_storage_multisample
            public delegate void delTextureStorage2DMultisampleEXT(uint TextureID, TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations);
            public delegate void delTextureStorage3DMultisampleEXT(uint TextureID, TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations);


            #endregion

            #region GL Fields

            //ARB_texture_storage_multisample
            public static delTextureStorage2DMultisampleEXT glTextureStorage2DMultisampleEXT;
            public static delTextureStorage3DMultisampleEXT glTextureStorage3DMultisampleEXT;


            #endregion
        }

        #endregion

        #region Public functions.

        /// <summary>
        /// Allocates multisample storage for a named texture id.
        /// </summary>
        /// <param name="TextureID">id of texture to allocat multisample storage.</param>
        /// <param name="target">Texture target of texture.</param>
        /// <param name="samples">Number of samples to allocate</param>
        /// <param name="piformat">Format of storage.</param>
        /// <param name="width">Width of texture.</param>
        /// <param name="height">Height of texture.</param>
        /// <param name="fixedSampleLocations">Should we use fixed sample locations?</param>
        public static void TextureStorage2DMultisampleEXT(uint TextureID, TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, bool fixedSampleLocations)
        {
            Delegates.glTextureStorage2DMultisampleEXT(TextureID, target, samples, piformat, width, height, fixedSampleLocations);
        }
        /// <summary>
        /// Allocates multisample storage for a named texture id.
        /// </summary>
        /// <param name="TextureID">id of texture to allocat multisample storage.</param>
        /// <param name="target">Texture target of texture.</param>
        /// <param name="samples">Number of samples to allocate</param>
        /// <param name="piformat">Format of storage.</param>
        /// <param name="width">Width of texture.</param>
        /// <param name="height">Height of texture.</param>
        /// <param name="depth">Depth of texture.</param>
        /// <param name="fixedSampleLocations">Should we use fixed sample locations?</param>
        public static void TextureStorage3DMultisampleEXT(uint TextureID, TextureTarget target, int samples, PixelInternalFormat piformat, int width, int height, int depth, bool fixedSampleLocations)
        {
            Delegates.glTextureStorage3DMultisampleEXT(TextureID, target, samples, piformat, width, height, depth, fixedSampleLocations);
        }


        #endregion
    }
}
