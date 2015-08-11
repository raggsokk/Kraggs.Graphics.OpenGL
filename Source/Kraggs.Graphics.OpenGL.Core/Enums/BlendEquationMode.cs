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
    public enum BlendEquationMode
    {
        //NoneAddedYet,

        //KHR_blend_equation_advanced - part of ARB_ES3_2_compatibility
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        Multiply = All.MULTIPLY_KHR,
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        Screen = All.SCREEN_KHR,
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        Overlay = All.OVERLAY_KHR,
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        Darken = All.DARKEN_KHR,
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        Lighten = All.LIGHTEN_KHR,
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        ColorDodge = All.COLORDODGE_KHR,
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        ColorBurn = All.COLORBURN_KHR,
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        HardLight = All.HARDLIGHT_KHR,
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        SoftLight = All.SOFTLIGHT_KHR,
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        Difference = All.DIFFERENCE_KHR,
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        Exclusion = All.EXCLUSION_KHR,

        // not completely satisified with these names.
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        HSLHue = All.HSL_HUE_KHR,
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        HSLSaturation = All.HSL_SATURATION_KHR,
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        HSLColor = All.HSL_COLOR_KHR,
        /// <summary>
        /// These enums are not accepted by the [modeRGB] or [modeAlpha] parameters of BlendEquationSeparate or BlendEquationSeparatei.
        /// </summary>
        HSLLuminosity = All.HSL_LUMINOSITY_KHR,
    }
}
