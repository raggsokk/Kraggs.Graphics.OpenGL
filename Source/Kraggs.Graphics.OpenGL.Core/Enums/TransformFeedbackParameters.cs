#region License

// Kraggs.Graphics.OpenGL (github.com/raggsokk)
//
// Copyright (c) 2014 Jarle Hansen (github.com/raggsokk)
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

namespace Kraggs.Graphics.OpenGL
{
    public enum TransformFeedbackParameters
    {
        /// <summary>
        /// Requires GetTransformFeedbackiv
        /// </summary>
        Paused = All.TRANSFORM_FEEDBACK_PAUSED,
        /// <summary>
        /// Requires GetTransformFeedbackiv
        /// </summary>
        Active = All.TRANSFORM_FEEDBACK_ACTIVE,

        /// <summary>
        /// Requires GetTransformFeedbacki_v
        /// </summary>
        BufferBinding = All.TRANSFORM_FEEDBACK_BUFFER_BINDING,

        /// <summary>
        /// Requires GetTransformFeedbacki64_v
        /// </summary>
        BufferStart = All.TRANSFORM_FEEDBACK_BUFFER_START,
        /// <summary>
        /// Requires GetTransformFeedbacki64_v
        /// </summary>
        BufferSize = All.TRANSFORM_FEEDBACK_BUFFER_SIZE,
    }
}
