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
    /// glGetString[i] can be called with these name constants.
    /// Copyright © 1991-2006 Silicon Graphics, Inc. Copyright © 2010 Khronos Group. This document is licensed under the SGI Free Software B License. For details, see http://oss.sgi.com/projects/FreeB/.
    /// </summary>
    public enum StringName
    {
        /// <summary>
        /// Returns the company responsible for this GL implementation. This name does not change from release to release.
        /// Strings GL_VENDOR and GL_RENDERER together uniquely specify a platform. They do not change from release to release and should be used by platform-recognition algorithms.
        /// </summary>
        Vendor = All.VENDOR,
        /// <summary>
        /// Returns the name of the renderer. This name is typically specific to a particular configuration of a hardware platform. It does not change from release to release.
        /// Strings GL_VENDOR and GL_RENDERER together uniquely specify a platform. They do not change from release to release and should be used by platform-recognition algorithms.
        /// </summary>
        Renderer = All.RENDERER,
        /// <summary>
        /// Returns a version or release number.
        /// The GL_VERSION and GL_SHADING_LANGUAGE_VERSION strings begin with a version number. The version number uses one of these forms:
        /// major_number.minor_number major_number.minor_number.release_number
        /// Vendor-specific information may follow the version number. Its format depends on the implementation, but a space always separates the version number and the vendor-specific information.
        /// </summary>
        Version = All.VERSION,
        /// <summary>
        /// Returns a version or release number for the shading language.
        /// The GL_VERSION and GL_SHADING_LANGUAGE_VERSION strings begin with a version number. The version number uses one of these forms:
        /// major_number.minor_number major_number.minor_number.release_number
        /// Vendor-specific information may follow the version number. Its format depends on the implementation, but a space always separates the version number and the vendor-specific information.
        /// </summary>
        ShadingLanguageVersion = All.SHADING_LANGUAGE_VERSION,
        /// <summary>
        /// For glGetStringi only, returns the extension string supported by the implementation at index.
        /// </summary>
        Extensions = All.EXTENSIONS,
    }
}
