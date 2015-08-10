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
    /// 
    /// Copyright © 1991-2006 Silicon Graphics, Inc. Copyright © 2010 Khronos Group. This document is licensed under the SGI Free Software B License. For details, see http://oss.sgi.com/projects/FreeB/.
    /// </summary>
    public enum GetParameters
    {
        /// <summary>
        /// params returns a single value indicating the active multitexture unit. The initial value is GL_TEXTURE0. See glActiveTexture.
        /// </summary>
        ActiveTexture = All.ACTIVE_TEXTURE,
        /// <summary>
        /// params returns a pair of values indicating the range of widths supported for aliased lines. See glLineWidth.
        /// </summary>
        AliasedLineWidthRange = All.ALIASED_LINE_WIDTH_RANGE,
        /// <summary>
        /// params returns a single value, the name of the buffer object currently bound to the target GL_ARRAY_BUFFER. If no buffer object is bound to this target, 0 is returned. The initial value is 0. See glBindBuffer.
        /// </summary>
        ArrayBufferBinding = All.ARRAY_BUFFER_BINDING,
        /// <summary>
        /// params returns a single boolean value indicating whether blending is enabled. The initial value is GL_FALSE. See glBlendFunc.
        /// </summary>
        Blend = All.BLEND,
        //BlendColor = All.Blend_COLOR,        
        /// <summary>
        /// params returns one value, the symbolic constant identifying the alpha destination blend function. The initial value is GL_ZERO. See glBlendFunc and glBlendFuncSeparate.
        /// </summary>
        BlendDstAlpha = All.BLEND_DST_ALPHA,
        /// <summary>
        /// params returns one value, the symbolic constant identifying the RGB destination blend function. The initial value is GL_ZERO. See glBlendFunc and glBlendFuncSeparate.
        /// </summary>
        BlendDstRgb = All.BLEND_DST_RGB,
        /// <summary>
        /// params returns one value, a symbolic constant indicating whether the RGB blend equation is GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN or GL_MAX. See glBlendEquationSeparate
        /// </summary>
        BlendEquationRgb = All.BLEND_EQUATION_RGB,
        /// <summary>
        /// params returns one value, a symbolic constant indicating whether the Alpha blend equation is GL_FUNC_ADD, GL_FUNC_SUBTRACT, GL_FUNC_REVERSE_SUBTRACT, GL_MIN or GL_MAX. See glBlendEquationSeparate.
        /// </summary>
        BlendEquationAlpha = All.BLEND_EQUATION_ALPHA,
        /// <summary>
        /// params returns one value, the symbolic constant identifying the alpha source blend function. The initial value is GL_ONE. See glBlendFunc and glBlendFuncSeparate.
        /// </summary>
        BlendSrcAlpha = All.BLEND_SRC_ALPHA,
        /// <summary>
        /// params returns one value, the symbolic constant identifying the RGB source blend function. The initial value is GL_ONE. See glBlendFunc and glBlendFuncSeparate.
        /// </summary>
        BlendSrcRgb = All.BLEND_SRC_RGB,
        /// <summary>
        /// params returns four values: the red, green, blue, and alpha values used to clear the color buffers. Integer values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most positive representable integer value, and -1.0 returns the most negative representable integer value. The initial value is (0, 0, 0, 0). See glClearColor.
        /// </summary>
        ColorClearValue = All.COLOR_CLEAR_VALUE,
        /// <summary>
        /// params returns a single boolean value indicating whether a fragment's RGBA color values are merged into the framebuffer using a logical operation. The initial value is GL_FALSE. See glLogicOp.
        /// </summary>
        ColorLogicOp = All.COLOR_LOGIC_OP,
        /// <summary>
        /// params returns four boolean values: the red, green, blue, and alpha write enables for the color buffers. The initial value is (GL_TRUE, GL_TRUE, GL_TRUE, GL_TRUE). See glColorMask.
        /// </summary>
        ColorWriteMask = All.COLOR_WRITEMASK,
        /// <summary>
        /// params returns a list of symbolic constants of length GL_NUM_COMPRESSED_TEXTURE_FORMATS indicating which compressed texture formats are available. See glCompressedTexImage2D.
        /// </summary>
        CompressedTextureFormats = All.COMPRESSED_TEXTURE_FORMATS,
        /// <summary>
        /// params returns one value, the maximum number of active shader storage blocks that may be accessed by a compute shader.
        /// </summary>
        MaxComputeShaderStorageBlocks = All.MAX_COMPUTE_SHADER_STORAGE_BLOCKS,
        /// <summary>
        /// params returns one value, the maximum total number of active shader storage blocks that may be accessed by all active shaders.
        /// </summary>
        MaxCombinedShaderStorageBlocks = All.MAX_COMBINED_SHADER_STORAGE_BLOCKS,
        /// <summary>
        /// params returns one value, the maximum number of uniform blocks per compute shader. The value must be at least 14. See glUniformBlockBinding.
        /// </summary>
        MaxComputeUniformBlocks = All.MAX_COMPUTE_UNIFORM_BLOCKS,
        /// <summary>
        /// params returns one value, the maximum supported texture image units that can be used to access texture maps from the compute shader. The value may be at least 16. See glActiveTexture.
        /// </summary>
        MaxComputeTextureImageUnits = All.MAX_COMPUTE_TEXTURE_IMAGE_UNITS,
        /// <summary>
        /// params returns one value, the maximum number of individual floating-point, integer, or boolean values that can be held in uniform variable storage for a compute shader. The value must be at least 1024. See glUniform.
        /// </summary>
        MaxComputeUniformComponents = All.MAX_COMPUTE_UNIFORM_COMPONENTS,
        /// <summary>
        /// params returns a single value, the maximum number of atomic counters available to compute shaders.
        /// </summary>
        MaxComputeAtomicCounters = All.MAX_COMPUTE_ATOMIC_COUNTERS,
        /// <summary>
        /// params returns a single value, the maximum number of atomic counter buffers that may be accessed by a compute shader.
        /// </summary>
        MaxComputeAtomicCounterBuffers = All.MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS,
        /// <summary>
        /// params returns one value, the number of words for compute shader uniform variables in all uniform blocks (including default). The value must be at least 1. See glUniform.
        /// </summary>
        MaxCombinedComputeUniformComponents = All.MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS,
        //TODO: MaxComputeWorkGroupInvocations
        //MaxComputeWorkGroupInvocations = All.MAX_COMPUTE_WORK_GROUP_INVOCATIONS,    
    
        /// <summary>
        /// Accepted by the indexed versions of glGet. params the maximum number of work groups that may be dispatched to a compute shader. Indices 0, 1, and 2 correspond to the X, Y and Z dimensions, respectively.
        /// </summary>
        MaxComputeWorkGroupCount = All.MAX_COMPUTE_WORK_GROUP_COUNT,
        /// <summary>
        /// Accepted by the indexed versions of glGet. params the maximum size of a work groups that may be used during compilation of a compute shader. Indices 0, 1, and 2 correspond to the X, Y and Z dimensions, respectively.
        /// </summary>
        MaxComputeWorkGroupSize = All.MAX_COMPUTE_WORK_GROUP_SIZE,
        /// <summary>
        /// params returns a single value, the name of the buffer object currently bound to the target GL_DISPATCH_INDIRECT_BUFFER. If no buffer object is bound to this target, 0 is returned. The initial value is 0. See glBindBuffer.
        /// </summary>
        DispatchIndirectBufferBinding = All.DISPATCH_INDIRECT_BUFFER_BINDING,
        /// <summary>
        /// params returns a single value, the maximum depth of the debug message group stack.
        /// </summary>
        MaxDebugGroupStackDepth = All.MAX_DEBUG_GROUP_STACK_DEPTH,
        /// <summary>
        /// params returns a single value, the current depth of the debug message group stack.
        /// </summary>
        DebugGroupStackDepth = All.DEBUG_GROUP_STACK_DEPTH,
        /// <summary>
        /// params returns one value, the flags with which the context was created (such as debugging functionality).
        /// </summary>
        ContextFlags = All.CONTEXT_FLAGS,
        /// <summary>
        /// params returns a single boolean value indicating whether polygon culling is enabled. The initial value is GL_FALSE. See glCullFace.
        /// </summary>
        CullFace = All.CULL_FACE,
        /// <summary>
        /// params returns one value, the name of the program object that is currently active, or 0 if no program object is active. See glUseProgram.
        /// </summary>
        CurrentProgram = All.CURRENT_PROGRAM,
        /// <summary>
        /// params returns one value, the value that is used to clear the depth buffer. Integer values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most positive representable integer value, and -1.0 returns the most negative representable integer value. The initial value is 1. See glClearDepth.
        /// </summary>
        DepthClearValue = All.DEPTH_CLEAR_VALUE,
        /// <summary>
        /// params returns one value, the symbolic constant that indicates the depth comparison function. The initial value is GL_LESS. See glDepthFunc.
        /// </summary>
        DepthFunc = All.DEPTH_FUNC,
        /// <summary>
        /// params returns two values: the near and far mapping limits for the depth buffer. Integer values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most positive representable integer value, and -1.0 returns the most negative representable integer value. The initial value is (0, 1). See glDepthRange.
        /// </summary>
        DepthRange = All.DEPTH_RANGE,
        /// <summary>
        /// params returns a single boolean value indicating whether depth testing of fragments is enabled. The initial value is GL_FALSE. See glDepthFunc and glDepthRange.
        /// </summary>
        DepthTest = All.DEPTH_TEST,
        /// <summary>
        /// params returns a single boolean value indicating if the depth buffer is enabled for writing. The initial value is GL_TRUE. See glDepthMask.
        /// </summary>
        DepthWritemask = All.DEPTH_WRITEMASK,
        /// <summary>
        /// params returns a single boolean value indicating whether dithering of fragment colors and indices is enabled. The initial value is GL_TRUE.
        /// </summary>
        Dither = All.DITHER,

        /// <summary>
        /// params returns a single boolean value indicating whether double buffering is supported.
        /// </summary>
        DoubleBuffer = All.DOUBLEBUFFER,
        /// <summary>
        /// params returns one value, a symbolic constant indicating which buffers are being drawn to. See glDrawBuffer. The initial value is GL_BACK if there are back buffers, otherwise it is GL_FRONT.
        /// </summary>
        DrawBuffer = All.DRAW_BUFFER,
        /// <summary>
        /// params returns one value, a symbolic constant indicating which buffers are being drawn to by the corresponding output color. See glDrawBuffers. The initial value of GL_DRAW_BUFFER0 is GL_BACK if there are back buffers, otherwise it is GL_FRONT. The initial values of draw buffers for all other output colors is GL_NONE.
        /// </summary>
        DrawBuffer0 = All.DRAW_BUFFER0,
        DrawBuffer1 = All.DRAW_BUFFER1,
        DrawBuffer2 = All.DRAW_BUFFER2,
        DrawBuffer3 = All.DRAW_BUFFER3,
        DrawBuffer4 = All.DRAW_BUFFER4,
        DrawBuffer5 = All.DRAW_BUFFER5,
        DrawBuffer6 = All.DRAW_BUFFER6,
        DrawBuffer7 = All.DRAW_BUFFER7,
        DrawBuffer8 = All.DRAW_BUFFER8,
        DrawBuffer9 = All.DRAW_BUFFER9,
        DrawBuffer10 = All.DRAW_BUFFER10,
        DrawBuffer11 = All.DRAW_BUFFER11,
        DrawBuffer12 = All.DRAW_BUFFER12,
        DrawBuffer13 = All.DRAW_BUFFER13,
        DrawBuffer14 = All.DRAW_BUFFER14,
        DrawBuffer15 = All.DRAW_BUFFER15,
        /// <summary>
        /// params returns one value, the name of the framebuffer object currently bound to the GL_DRAW_FRAMEBUFFER target. If the default framebuffer is bound, this value will be zero. The initial value is zero. See glBindFramebuffer.
        /// </summary>
        DrawFramebufferBinding = All.DRAW_FRAMEBUFFER_BINDING,
        /// <summary>
        /// params returns one value, the name of the framebuffer object currently bound to the GL_READ_FRAMEBUFFER target. If the default framebuffer is bound, this value will be zero. The initial value is zero. See glBindFramebuffer.
        /// </summary>
        ReadFramebufferBinding = All.READ_FRAMEBUFFER_BINDING,
        /// <summary>
        /// params returns a single value, the name of the buffer object currently bound to the target GL_ELEMENT_ARRAY_BUFFER. If no buffer object is bound to this target, 0 is returned. The initial value is 0. See glBindBuffer.
        /// </summary>
        ElementArrayBufferBinding = All.ELEMENT_ARRAY_BUFFER_BINDING,
        /// <summary>
        /// params returns one value, a symbolic constant indicating the mode of the derivative accuracy hint for fragment shaders. The initial value is GL_DONT_CARE. See glHint.
        /// </summary>
        FragmentShaderDerivativeHint = All.FRAGMENT_SHADER_DERIVATIVE_HINT,
        /// <summary>
        /// params returns a single GLenum value indicating the implementation's preferred pixel data format. See glReadPixels.
        /// </summary>
        ImplementationColorReadformat = All.IMPLEMENTATION_COLOR_READ_FORMAT,
        /// <summary>
        /// params returns a single GLenum value indicating the implementation's preferred pixel data type. See glReadPixels.
        /// </summary>
        ImplementationColorReadType = All.IMPLEMENTATION_COLOR_READ_TYPE,
        /// <summary>
        /// params returns a single boolean value indicating whether antialiasing of lines is enabled. The initial value is GL_FALSE. See glLineWidth.
        /// </summary>
        LineSmooth = All.LINE_SMOOTH,
        /// <summary>
        /// params returns one value, a symbolic constant indicating the mode of the line antialiasing hint. The initial value is GL_DONT_CARE. See glHint.
        /// </summary>
        LineSmoothHint = All.LINE_SMOOTH_HINT,
        /// <summary>
        /// params returns one value, the line width as specified with glLineWidth. The initial value is 1.
        /// </summary>
        LineWidth = All.LINE_WIDTH,
        /// <summary>
        /// params returns one value, the implementation dependent specifc vertex of a primitive that is used to select the rendering layer. If the value returned is equivalent to GL_PROVOKING_VERTEX, then the vertex selection follows the convention specified by glProvokingVertex. If the value returned is equivalent to GL_FIRST_VERTEX_CONVENTION, then the selection is always taken from the first vertex in the primitive. If the value returned is equivalent to GL_LAST_VERTEX_CONVENTION, then the selection is always taken from the last vertex in the primitive. If the value returned is equivalent to GL_UNDEFINED_VERTEX, then the selection is not guaranteed to be taken from any specific vertex in the primitive.
        /// </summary>
        LayerProvokingVertex = All.LAYER_PROVOKING_VERTEX,
        //LineWidthGranularity = All.LINE_WIDTH_GRANULARITY,
        //LineWidthRange = All.LINE_WIDTH_RANGE,
        /// <summary>
        /// params returns one value, a symbolic constant indicating the selected logic operation mode. The initial value is GL_COPY. See glLogicOp.
        /// </summary>
        LogicOpMode = All.LOGIC_OP_MODE,
        /// <summary>
        /// params returns one value, the major version number of the OpenGL API supported by the current context.
        /// </summary>
        MajorVersion = All.MAJOR_VERSION,
        /// <summary>
        /// params returns one value, a rough estimate of the largest 3D texture that the GL can handle. The value must be at least 64. Use GL_PROXY_TEXTURE_3D to determine if a texture is too large. See glTexImage3D.
        /// </summary>
        MaxTexture3DSize = All.MAX_3D_TEXTURE_SIZE,
        /// <summary>
        /// params returns one value. The value indicates the maximum number of layers allowed in an array texture, and must be at least 256. See glTexImage2D.
        /// </summary>
        MaxTextureArrayLayers = All.MAX_ARRAY_TEXTURE_LAYERS,
        /// <summary>
        /// params returns one value, the maximum number of application-defined clipping distances. The value must be at least 8.
        /// </summary>
        MaxClipDistance = All.MAX_CLIP_DISTANCES,
        /// <summary>
        /// params returns one value, the maximum number of samples in a color multisample texture.
        /// </summary>
        MaxColorTextureSamples = All.MAX_COLOR_TEXTURE_SAMPLES,
        /// <summary>
        /// params returns a single value, the maximum number of atomic counters available to all active shaders.
        /// </summary>
        MaxCombinedAtomicCounters = All.MAX_COMBINED_ATOMIC_COUNTERS,
        /// <summary>
        /// params returns one value, the number of words for fragment shader uniform variables in all uniform blocks (including default). The value must be at least 1. See glUniform.
        /// </summary>
        MaxCombinedFragmentUniformComponents = All.MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS,
        //TODO: MaxCombinedGeometryUniformComponents
        //MaxCombinedGeometryUniformComponents = All.MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS,
        /// <summary>
        /// params returns one value, the maximum supported texture image units that can be used to access texture maps from the vertex shader and the fragment processor combined. If both the vertex shader and the fragment processing stage access the same texture image unit, then that counts as using two texture image units against this limit. The value must be at least 48. See glActiveTexture.
        /// </summary>
        MaxCombinedTextureImageUnits = All.MAX_COMBINED_TEXTURE_IMAGE_UNITS,
        /// <summary>
        /// params returns one value, the maximum number of uniform blocks per program. The value must be at least 70. See glUniformBlockBinding.
        /// </summary>
        MaxCombinedUniformBlocks = All.MAX_COMBINED_UNIFORM_BLOCKS,
        /// <summary>
        /// params returns one value, the number of words for vertex shader uniform variables in all uniform blocks (including default). The value must be at least 1. See glUniform.
        /// </summary>
        MaxCombinedVertexUniformComponents = All.MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS,
        /// <summary>
        /// params returns one value. The value gives a rough estimate of the largest cube-map texture that the GL can handle. The value must be at least 1024. Use GL_PROXY_TEXTURE_CUBE_MAP to determine if a texture is too large. See glTexImage2D.
        /// </summary>
        MaxTextureCubemapSize = All.MAX_CUBE_MAP_TEXTURE_SIZE,
        /// <summary>
        /// params returns one value, the maximum number of samples in a multisample depth or depth-stencil texture.
        /// </summary>
        MaxTextureDepthSamples = All.MAX_DEPTH_TEXTURE_SAMPLES,
        /// <summary>
        /// params returns one value, the maximum number of simultaneous outputs that may be written in a fragment shader. The value must be at least 8. See glDrawBuffers.
        /// </summary>
        MaxDrawBuffers = All.MAX_DRAW_BUFFERS,
        /// <summary>
        /// params returns one value, the maximum number of active draw buffers when using dual-source blending. The value must be at least 1. See glBlendFunc and glBlendFuncSeparate.
        /// </summary>
        MaxDualSourceDrawBuffers = All.MAX_DUAL_SOURCE_DRAW_BUFFERS,
        /// <summary>
        /// params returns one value, the recommended maximum number of vertex array indices. See glDrawRangeElements.
        /// </summary>
        MaxElementsIndices = All.MAX_ELEMENTS_INDICES,
        /// <summary>
        /// params returns one value, the recommended maximum number of vertex array vertices. See glDrawRangeElements.
        /// </summary>
        MaxElementsVertices = All.MAX_ELEMENTS_VERTICES,
        /// <summary>
        /// params returns a single value, the maximum number of atomic counters available to fragment shaders.
        /// </summary>
        MaxFragmentAtomicCounters = All.MAX_FRAGMENT_ATOMIC_COUNTERS,
        /// <summary>
        /// params returns one value, the maximum number of active shader storage blocks that may be accessed by a fragment shader.
        /// </summary>
        MaxFragmentShaderStorageBlocks = All.MAX_FRAGMENT_SHADER_STORAGE_BLOCKS,
        /// <summary>
        /// params returns one value, the maximum number of components of the inputs read by the fragment shader, which must be at least 128.
        /// </summary>
        MaxFragmentInputComponents = All.MAX_FRAGMENT_INPUT_COMPONENTS,
        /// <summary>
        /// params returns one value, the maximum number of individual floating-point, integer, or boolean values that can be held in uniform variable storage for a fragment shader. The value must be at least 1024. See glUniform.
        /// </summary>
        MaxFragmentUniformComponents = All.MAX_FRAGMENT_UNIFORM_COMPONENTS,
        /// <summary>
        /// params returns one value, the maximum number of individual 4-vectors of floating-point, integer, or boolean values that can be held in uniform variable storage for a fragment shader. The value is equal to the value of GL_MAX_FRAGMENT_UNIFORM_COMPONENTS divided by 4 and must be at least 256. See glUniform.
        /// </summary>
        MaxFragmentUniformVectors = All.MAX_FRAGMENT_UNIFORM_VECTORS,
        /// <summary>
        /// params returns one value, the maximum number of uniform blocks per fragment shader. The value must be at least 12. See glUniformBlockBinding.
        /// </summary>
        MaxFragmentUniformBlocks = All.MAX_FRAGMENT_UNIFORM_BLOCKS,
        /// <summary>
        /// params returns one value, the maximum width for a framebuffer that has no attachments, which must be at least 16384. See glFramebufferParameter.
        /// </summary>
        MaxFramebufferWidth = All.MAX_FRAMEBUFFER_WIDTH,
        /// <summary>
        /// params returns one value, the maximum height for a framebuffer that has no attachments, which must be at least 16384. See glFramebufferParameter.
        /// </summary>
        MaxFramebufferHeight = All.MAX_FRAMEBUFFER_HEIGHT,
        /// <summary>
        /// params returns one value, the maximum number of layers for a framebuffer that has no attachments, which must be at least 2048. See glFramebufferParameter.
        /// </summary>
        MaxFramebufferLayers = All.MAX_FRAMEBUFFER_LAYERS,
        /// <summary>
        /// params returns one value, the maximum samples in a framebuffer that has no attachments, which must be at least 4. See glFramebufferParameter.
        /// </summary>
        MaxFramebufferSamples = All.MAX_FRAMEBUFFER_SAMPLES,
        /// <summary>
        /// params returns a single value, the maximum number of atomic counters available to geometry shaders.
        /// </summary>
        MaxGeometryAtomicCounters = All.MAX_GEOMETRY_ATOMIC_COUNTERS,
        /// <summary>
        /// params returns one value, the maximum number of active shader storage blocks that may be accessed by a geometry shader.
        /// </summary>
        MaxGeometryShaderStorageBlocks = All.MAX_GEOMETRY_SHADER_STORAGE_BLOCKS,
        /// <summary>
        /// params returns one value, the maximum number of components of inputs read by a geometry shader, which must be at least 64.
        /// </summary>
        MaxGeometryInputComponents = All.MAX_GEOMETRY_INPUT_COMPONENTS,
        /// <summary>
        /// params returns one value, the maximum number of components of outputs written by a geometry shader, which must be at least 128.
        /// </summary>
        MaxGeometryOutputComponents = All.MAX_GEOMETRY_OUTPUT_COMPONENTS,
        /// <summary>
        /// params returns one value, the maximum supported texture image units that can be used to access texture maps from the geometry shader. The value must be at least 16. See glActiveTexture.
        /// </summary>
        MaxGeometryTextureImageUnits = All.MAX_GEOMETRY_TEXTURE_IMAGE_UNITS,
        //TODO: MaxGeometryUniformBlocks
        //MaxGeometryUniformBlocks = All.MAX_GEOMETRY_UNIFORM_BLOCKS,
        /// <summary>
        /// params returns one value, the maximum number of individual floating-point, integer, or boolean values that can be held in uniform variable storage for a geometry shader. The value must be at least 1024. See glUniform.
        /// </summary>
        MaxGeometryUniformComponents = All.MAX_GEOMETRY_UNIFORM_COMPONENTS,
        /// <summary>
        /// params returns one value, the maximum number of samples supported in integer format multisample buffers.
        /// </summary>
        MaxIntegerSamples = All.MAX_INTEGER_SAMPLES,
        /// <summary>
        /// params returns one value, the minimum alignment in basic machine units of pointers returned fromglMapBuffer and glMapBufferRange. This value must be a power of two and must be at least 64.
        /// </summary>
        MinMapBufferAlignment = All.MIN_MAP_BUFFER_ALIGNMENT,
        /// <summary>
        /// params returns one value, the maximum length of a label that may be assigned to an object. See glObjectLabel and glObjectPtrLabel.
        /// </summary>
        MaxLabelLength = All.MAX_LABEL_LENGTH,
        /// <summary>
        /// params returns one value, the maximum texel offset allowed in a texture lookup, which must be at least 7.
        /// </summary>
        MaxProgramTexelOffset = All.MAX_PROGRAM_TEXEL_OFFSET,
        /// <summary>
        /// params returns one value, the minimum texel offset allowed in a texture lookup, which must be at most -8.
        /// </summary>
        MinProgramTexelOffset = All.MIN_PROGRAM_TEXEL_OFFSET,
        /// <summary>
        /// params returns one value. The value gives a rough estimate of the largest rectangular texture that the GL can handle. The value must be at least 1024. Use GL_PROXY_TEXTURE_RECTANGLE to determine if a texture is too large. See glTexImage2D.
        /// </summary>
        MaxTextureRectangeSize = All.MAX_RECTANGLE_TEXTURE_SIZE,
        /// <summary>
        /// params returns one value. The value indicates the maximum supported size for renderbuffers. See glFramebufferRenderbuffer.
        /// </summary>
        MaxRenderbufferSize = All.MAX_RENDERBUFFER_SIZE,
        /// <summary>
        /// params returns one value, the maximum number of sample mask words.
        /// </summary>
        MaxSampleMaskWords = All.MAX_SAMPLE_MASK_WORDS,
        /// <summary>
        /// params returns one value, the maximum glWaitSync timeout interval.
        /// </summary>
        MaxServerWaitTimout = All.MAX_SERVER_WAIT_TIMEOUT,
        /// <summary>
        /// params returns one value, the maximum number of shader storage buffer binding points on the context, which must be at least 8.
        /// </summary>
        MaxShaderStorageBufferBindings = All.MAX_SHADER_STORAGE_BUFFER_BINDINGS,
        /// <summary>
        /// params returns a single value, the maximum number of atomic counters available to tessellation control shaders.
        /// </summary>
        MaxTessControlAtomicCounters = All.MAX_TESS_CONTROL_ATOMIC_COUNTERS,
        /// <summary>
        /// params returns a single value, the maximum number of atomic counters available to tessellation evaluation shaders.
        /// </summary>
        MaxTessEvaluationAtomicCounters = All.MAX_TESS_EVALUATION_ATOMIC_COUNTERS,
        /// <summary>
        /// params returns one value, the maximum number of active shader storage blocks that may be accessed by a tessellation control shader.
        /// </summary>
        MaxTessControlShaderStorageBlocks = All.MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS,
        /// <summary>
        /// params returns one value, the maximum number of active shader storage blocks that may be accessed by a tessellation evaluation shader.
        /// </summary>
        MaxTessEvaluationShaderStorageBlocks = All.MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS,
        /// <summary>
        /// params returns one value. The value gives the maximum number of texels allowed in the texel array of a texture buffer object. Value must be at least 65536.
        /// </summary>
        MaxTextureBufferSize = All.MAX_TEXTURE_BUFFER_SIZE,
        /// <summary>
        /// params returns one value, the maximum supported texture image units that can be used to access texture maps from the fragment shader. The value must be at least 16. See glActiveTexture.
        /// </summary>
        MaxTextureImageUnits = All.MAX_TEXTURE_IMAGE_UNITS,
        /// <summary>
        /// params returns one value, the maximum, absolute value of the texture level-of-detail bias. The value must be at least 2.0.
        /// </summary>
        MaxTextureLodBias = All.MAX_TEXTURE_LOD_BIAS,
        /// <summary>
        /// params returns one value. The value gives a rough estimate of the largest texture that the GL can handle. The value must be at least 1024. Use a proxy texture target such as GL_PROXY_TEXTURE_1D or GL_PROXY_TEXTURE_2D to determine if a texture is too large. See glTexImage1D and glTexImage2D.
        /// </summary>
        MaxTextureSize = All.MAX_TEXTURE_SIZE,
        /// <summary>
        /// params returns one value, the maximum number of uniform buffer binding points on the context, which must be at least 36.
        /// </summary>
        MaxUniformBufferBindings = All.MAX_UNIFORM_BUFFER_BINDINGS,
        /// <summary>
        /// params returns one value, the maximum size in basic machine units of a uniform block, which must be at least 16384.
        /// </summary>
        MaxUniformBlockSize = All.MAX_UNIFORM_BLOCK_SIZE,
        /// <summary>
        /// params returns one value, the maximum number of explicitly assignable uniform locations, which must be at least 1024.
        /// </summary>
        MaxUniformLocations = All.MAX_UNIFORM_LOCATIONS,
        /// <summary>
        /// params returns one value, the number components for varying variables, which must be at least 60.
        /// </summary>
        MaxVaryingComponents = All.MAX_VARYING_COMPONENTS,
        /// <summary>
        /// params returns one value, the number 4-vectors for varying variables, which is equal to the value of GL_MAX_VARYING_COMPONENTS and must be at least 15.
        /// </summary>
        MaxVaryingVectors = All.MAX_VARYING_VECTORS,
        /// <summary>
        /// params returns one value, the maximum number of interpolators available for processing varying variables used by vertex and fragment shaders. This value represents the number of individual floating-point values that can be interpolated; varying variables declared as vectors, matrices, and arrays will all consume multiple interpolators. The value must be at least 32.
        /// </summary>
        MaxVaryingFloats = All.MAX_VARYING_FLOATS,
        /// <summary>
        /// params returns a single value, the maximum number of atomic counters available to vertex shaders.
        /// </summary>
        MaxVertexAtomicCounters = All.MAX_VERTEX_ATOMIC_COUNTERS,
        /// <summary>
        /// params returns one value, the maximum number of 4-component generic vertex attributes accessible to a vertex shader. The value must be at least 16. See glVertexAttrib.
        /// </summary>
        MaxVertexAttribs = All.MAX_VERTEX_ATTRIBS,
        /// <summary>
        /// params returns one value, the maximum number of active shader storage blocks that may be accessed by a vertex shader.
        /// </summary>
        MaxVertexShaderStorageBlocks = All.MAX_VERTEX_SHADER_STORAGE_BLOCKS,
        /// <summary>
        /// params returns one value, the maximum supported texture image units that can be used to access texture maps from the vertex shader. The value may be at least 16. See glActiveTexture.
        /// </summary>
        MaxVertexTextureImageUnits = All.MAX_VERTEX_TEXTURE_IMAGE_UNITS,
        /// <summary>
        /// params returns one value, the maximum number of individual floating-point, integer, or boolean values that can be held in uniform variable storage for a vertex shader. The value must be at least 1024. See glUniform.
        /// </summary>
        MaxVertexUniformComponents = All.MAX_VERTEX_UNIFORM_COMPONENTS,
        /// <summary>
        /// params returns one value, the maximum number of 4-vectors that may be held in uniform variable storage for the vertex shader. The value of GL_MAX_VERTEX_UNIFORM_VECTORS is equal to the value of GL_MAX_VERTEX_UNIFORM_COMPONENTS and must be at least 256.
        /// </summary>
        MaxVertexUniformVectors = All.MAX_VERTEX_UNIFORM_VECTORS,
        /// <summary>
        /// params returns one value, the maximum number of components of output written by a vertex shader, which must be at least 64.
        /// </summary>
        MaxVertexOutputComponents = All.MAX_VERTEX_OUTPUT_COMPONENTS,
        /// <summary>
        /// params returns one value, the maximum number of uniform blocks per vertex shader. The value must be at least 12. See glUniformBlockBinding.
        /// </summary>
        MaxVertexUniformBlocks = All.MAX_VERTEX_UNIFORM_BLOCKS,
        /// <summary>
        /// params returns two values: the maximum supported width and height of the viewport. These must be at least as large as the visible dimensions of the display being rendered to. See glViewport.
        /// </summary>
        MaxViewportDimensions = All.MAX_VIEWPORT_DIMS,
        /// <summary>
        /// params returns one value, the maximum number of simultaneous viewports that are supported. The value must be at least 16. See glViewportIndexed.
        /// </summary>
        MaxViewports = All.MAX_VIEWPORTS,
        /// <summary>
        /// params returns one value, the minor version number of the OpenGL API supported by the current context.
        /// </summary>
        MinorVersion = All.MINOR_VERSION,
        /// <summary>
        /// params returns a single integer value indicating the number of available compressed texture formats. The minimum value is 4. See glCompressedTexImage2D.
        /// </summary>
        NumCompressedTextureFormats = All.NUM_COMPRESSED_TEXTURE_FORMATS,
        /// <summary>
        /// params returns one value, the number of extensions supported by the GL implementation for the current context. See glGetString.
        /// </summary>
        NumExtensions = All.NUM_EXTENSIONS,
        /// <summary>
        /// params returns one value, the number of program binary formats supported by the implementation.
        /// </summary>
        NumProgramBinaryFormats = All.NUM_PROGRAM_BINARY_FORMATS,
        /// <summary>
        /// params returns one value, the number of binary shader formats supported by the implementation. If this value is greater than zero, then the implementation supports loading binary shaders. If it is zero, then the loading of binary shaders by the implementation is not supported.
        /// </summary>
        NumShaderBinaryFormats = All.NUM_SHADER_BINARY_FORMATS,
        /// <summary>
        /// params returns one value, the byte alignment used for writing pixel data to memory. The initial value is 4. See glPixelStore.
        /// </summary>
        PackAlignment = All.PACK_ALIGNMENT,
        /// <summary>
        /// params returns one value, the image height used for writing pixel data to memory. The initial value is 0. See glPixelStore.
        /// </summary>
        PackImageHeight = All.PACK_IMAGE_HEIGHT,
        /// <summary>
        /// params returns a single boolean value indicating whether single-bit pixels being written to memory are written first to the least significant bit of each unsigned byte. The initial value is GL_FALSE. See glPixelStore.
        /// </summary>
        PackLsbFirst = All.PACK_LSB_FIRST,
        /// <summary>
        /// params returns one value, the row length used for writing pixel data to memory. The initial value is 0. See glPixelStore.
        /// </summary>
        PackRowLength = All.PACK_ROW_LENGTH,
        /// <summary>
        /// params returns one value, the number of pixel images skipped before the first pixel is written into memory. The initial value is 0. See glPixelStore.
        /// </summary>
        PackSkipImages = All.PACK_SKIP_IMAGES,
        /// <summary>
        /// params returns one value, the number of pixel locations skipped before the first pixel is written into memory. The initial value is 0. See glPixelStore.
        /// </summary>
        PackSkipPixels = All.PACK_SKIP_PIXELS,
        /// <summary>
        /// params returns one value, the number of rows of pixel locations skipped before the first pixel is written into memory. The initial value is 0. See glPixelStore.
        /// </summary>
        PackSkipRows = All.PACK_SKIP_ROWS,
        /// <summary>
        /// params returns a single boolean value indicating whether the bytes of two-byte and four-byte pixel indices and components are swapped before being written to memory. The initial value is GL_FALSE. See glPixelStore.
        /// </summary>
        PackSwapBytes = All.PACK_SWAP_BYTES,
        /// <summary>
        /// params returns a single value, the name of the buffer object currently bound to the target GL_PIXEL_PACK_BUFFER. If no buffer object is bound to this target, 0 is returned. The initial value is 0. See glBindBuffer.
        /// </summary>
        PixelPackBufferBinding = All.PIXEL_PACK_BUFFER_BINDING,
        /// <summary>
        /// params returns a single value, the name of the buffer object currently bound to the target GL_PIXEL_UNPACK_BUFFER. If no buffer object is bound to this target, 0 is returned. The initial value is 0. See glBindBuffer.
        /// </summary>
        PixelUnpackBufferBinding = All.PIXEL_UNPACK_BUFFER_BINDING,
        /// <summary>
        /// params returns one value, the point size threshold for determining the point size. See glPointParameter.
        /// </summary>
        PointFadeThresholdSize = All.POINT_FADE_THRESHOLD_SIZE,
        /// <summary>
        /// params returns one value, the current primitive restart index. The initial value is 0. See glPrimitiveRestartIndex.
        /// </summary>
        PrimitiveRestartIndex = All.PRIMITIVE_RESTART_INDEX,
        /// <summary>
        /// params an array of GL_NUM_PROGRAM_BINARY_FORMATS values, indicating the proram binary formats supported by the implementation.
        /// </summary>
        ProgramBinaryFormats = All.PROGRAM_BINARY_FORMATS,

        /// <summary>
        /// params returns a single boolean value indicating whether vertex program point size mode is enabled. If enabled, then the point size is taken from the shader built-in gl_PointSize. If disabled, then the point size is taken from the point state as specified by glPointSize. The initial value is GL_FALSE.
        /// </summary>
        ProgramPointSize = All.PROGRAM_POINT_SIZE,
        /// <summary>
        /// params a single value, the name of the currently bound program pipeline object, or zero if no program pipeline object is bound. See glBindProgramPipeline.
        /// </summary>
        ProgramPipelineBinding = All.PROGRAM_PIPELINE_BINDING,
        /// <summary>
        /// params returns one value, the currently selected provoking vertex convention. The initial value is GL_LAST_VERTEX_CONVENTION. See glProvokingVertex.
        /// </summary>
        ProvokingVertex = All.PROVOKING_VERTEX,
        /// <summary>
        /// params returns one value, the point size as specified by glPointSize. The initial value is 1.
        /// </summary>
        PointSize = All.POINT_SIZE,
        /// <summary>
        /// params returns one value, the size difference between adjacent supported sizes for antialiased points. See glPointSize.
        /// </summary>
        PointSizeGranularity = All.POINT_SIZE_GRANULARITY,
        /// <summary>
        /// params returns two values: the smallest and largest supported sizes for antialiased points. The smallest size must be at most 1, and the largest size must be at least 1. See glPointSize.
        /// </summary>
        PointSizeRange = All.POINT_SIZE_RANGE,
        /// <summary>
        /// params returns one value, the scaling factor used to determine the variable offset that is added to the depth value of each fragment generated when a polygon is rasterized. The initial value is 0. See glPolygonOffset.
        /// </summary>
        PolygonOffsetFactor = All.POLYGON_OFFSET_FACTOR,
        /// <summary>
        /// params returns one value. This value is multiplied by an implementation-specific value and then added to the depth value of each fragment generated when a polygon is rasterized. The initial value is 0. See glPolygonOffset.
        /// </summary>
        PolygonOffsetUnits = All.POLYGON_OFFSET_UNITS,
        /// <summary>
        /// params returns a single boolean value indicating whether polygon offset is enabled for polygons in fill mode. The initial value is GL_FALSE. See glPolygonOffset.
        /// </summary>
        PolygonOffsetFill = All.POLYGON_OFFSET_FILL,
        /// <summary>
        /// params returns a single boolean value indicating whether polygon offset is enabled for polygons in line mode. The initial value is GL_FALSE. See glPolygonOffset.
        /// </summary>
        PolygonOffsetLine = All.POLYGON_OFFSET_LINE,
        /// <summary>
        /// params returns a single boolean value indicating whether polygon offset is enabled for polygons in point mode. The initial value is GL_FALSE. See glPolygonOffset.
        /// </summary>
        PolygonOffsetPoint = All.POLYGON_OFFSET_POINT,
        /// <summary>
        /// params returns a single boolean value indicating whether antialiasing of polygons is enabled. The initial value is GL_FALSE. See glPolygonMode.
        /// </summary>
        PolygonSmooth = All.POLYGON_SMOOTH,
        /// <summary>
        /// params returns one value, a symbolic constant indicating the mode of the polygon antialiasing hint. The initial value is GL_DONT_CARE. See glHint.
        /// </summary>
        PolygonSmoothHint = All.POLYGON_SMOOTH_HINT,
        /// <summary>
        /// params returns one value, a symbolic constant indicating which color buffer is selected for reading. The initial value is GL_BACK if there is a back buffer, otherwise it is GL_FRONT. See glReadPixels.
        /// </summary>
        ReadBuffer = All.READ_BUFFER,
        /// <summary>
        /// params returns a single value, the name of the renderbuffer object currently bound to the target GL_RENDERBUFFER. If no renderbuffer object is bound to this target, 0 is returned. The initial value is 0. See glBindRenderbuffer.
        /// </summary>
        RenderbufferBinding = All.RENDERBUFFER_BINDING,
        /// <summary>
        /// params returns a single integer value indicating the number of sample buffers associated with the framebuffer. See glSampleCoverage.
        /// </summary>
        SampleBuffers = All.SAMPLE_BUFFERS,
        /// <summary>
        /// params returns a single positive floating-point value indicating the current sample coverage value. See glSampleCoverage.
        /// </summary>
        SampleCoverageValue = All.SAMPLE_COVERAGE_VALUE,
        /// <summary>
        /// params returns a single boolean value indicating if the temporary coverage value should be inverted. See glSampleCoverage.
        /// </summary>
        SampleCoverageInvert = All.SAMPLE_COVERAGE_INVERT,
        /// <summary>
        /// params returns a single value, the name of the sampler object currently bound to the active texture unit. The initial value is 0. See glBindSampler.
        /// </summary>
        SamplerBinding = All.SAMPLER_BINDING,
        /// <summary>
        /// params returns a single integer value indicating the coverage mask size. See glSampleCoverage.
        /// </summary>
        Samples = All.SAMPLES,
        /// <summary>
        /// params returns four values: the x and y window coordinates of the scissor box, followed by its width and height. Initially the x and y window coordinates are both 0 and the width and height are set to the size of the window. See glScissor.
        /// </summary>
        ScissorBox = All.SCISSOR_BOX,
        /// <summary>
        /// params returns a single boolean value indicating whether scissoring is enabled. The initial value is GL_FALSE. See glScissor.
        /// </summary>
        ScissorTest = All.SCISSOR_TEST,
        /// <summary>
        /// params returns a single boolean value indicating whether an online shader compiler is present in the implementation. All desktop OpenGL implementations must support online shader compilations, and therefore the value of GL_SHADER_COMPILER will always be GL_TRUE.
        /// </summary>
        ShaderCompiler = All.SHADER_COMPILER,
        /// <summary>
        /// When used with non-indexed variants of glGet (such as glGetIntegerv), params returns a single value, the name of the buffer object currently bound to the target GL_SHADER_STORAGE_BUFFER. If no buffer object is bound to this target, 0 is returned. When used with indexed variants of glGet (such as glGetIntegeri_v), params returns a single value, the name of the buffer object bound to the indexed shader storage buffer binding points. The initial value is 0 for all targets. See glBindBuffer, glBindBufferBase, and glBindBufferRange.
        /// </summary>
        ShaderStorageBufferBinding = All.SHADER_STORAGE_BUFFER_BINDING,
        /// <summary>
        /// params returns a single value, the minimum required alignment for shader storage buffer sizes and offset. The initial value is 1. See glShaderStorateBlockBinding.
        /// </summary>
        ShaderStorageBufferOffsetAlignment = All.SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT,
        /// <summary>
        /// When used with indexed variants of glGet (such as glGetInteger64i_v), params returns a single value, the start offset of the binding range for each indexed shader storage buffer binding. The initial value is 0 for all bindings. See glBindBufferRange.
        /// </summary>
        ShaderStorageBufferStart = All.SHADER_STORAGE_BUFFER_START,
        /// <summary>
        /// When used with indexed variants of glGet (such as glGetInteger64i_v), params returns a single value, the size of the binding range for each indexed shader storage buffer binding. The initial value is 0 for all bindings. See glBindBufferRange.
        /// </summary>
        ShaderStorageBufferSize = All.SHADER_STORAGE_BUFFER_SIZE,
        /// <summary>
        /// params returns a pair of values indicating the range of widths supported for smooth (antialiased) lines. See glLineWidth.
        /// </summary>
        SmoothLineWidthRange = All.SMOOTH_LINE_WIDTH_RANGE,
        /// <summary>
        /// params returns a single value indicating the level of quantization applied to smooth line width parameters.
        /// </summary>
        SmoothLineWidthGranularity = All.SMOOTH_LINE_WIDTH_GRANULARITY,
        /// <summary>
        /// params returns one value, a symbolic constant indicating what action is taken for back-facing polygons when the stencil test fails. The initial value is GL_KEEP. See glStencilOpSeparate.
        /// </summary>
        StencilBackFail = All.STENCIL_BACK_FAIL,
        /// <summary>
        /// params returns one value, a symbolic constant indicating what function is used for back-facing polygons to compare the stencil reference value with the stencil buffer value. The initial value is GL_ALWAYS. See glStencilFuncSeparate.
        /// </summary>
        StencilBackFunc = All.STENCIL_BACK_FUNC,
        /// <summary>
        /// params returns one value, a symbolic constant indicating what action is taken for back-facing polygons when the stencil test passes, but the depth test fails. The initial value is GL_KEEP. See glStencilOpSeparate.
        /// </summary>
        StencilBackPassDepthFail = All.STENCIL_BACK_PASS_DEPTH_FAIL,
        /// <summary>
        /// params returns one value, a symbolic constant indicating what action is taken for back-facing polygons when the stencil test passes and the depth test passes. The initial value is GL_KEEP. See glStencilOpSeparate.
        /// </summary>
        StencilBackPassDepthPass = All.STENCIL_BACK_PASS_DEPTH_PASS,
        /// <summary>
        /// params returns one value, the reference value that is compared with the contents of the stencil buffer for back-facing polygons. The initial value is 0. See glStencilFuncSeparate.
        /// </summary>
        StencilBackRef = All.STENCIL_BACK_REF,
        /// <summary>
        /// params returns one value, the mask that is used for back-facing polygons to mask both the stencil reference value and the stencil buffer value before they are compared. The initial value is all 1's. See glStencilFuncSeparate.
        /// </summary>
        StencilBackValueMask = All.STENCIL_BACK_VALUE_MASK,
        /// <summary>
        /// params returns one value, the mask that controls writing of the stencil bitplanes for back-facing polygons. The initial value is all 1's. See glStencilMaskSeparate.
        /// </summary>
        StencilBackWriteMask = All.STENCIL_BACK_WRITEMASK,
        /// <summary>
        /// params returns one value, the index to which the stencil bitplanes are cleared. The initial value is 0. See glClearStencil.
        /// </summary>
        StencilClearValue = All.STENCIL_CLEAR_VALUE,
        /// <summary>
        /// params returns one value, a symbolic constant indicating what action is taken when the stencil test fails. The initial value is GL_KEEP. See glStencilOp. This stencil state only affects non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See glStencilOpSeparate.
        /// </summary>
        StencilFail = All.STENCIL_FAIL,
        /// <summary>
        /// params returns one value, a symbolic constant indicating what function is used to compare the stencil reference value with the stencil buffer value. The initial value is GL_ALWAYS. See glStencilFunc. This stencil state only affects non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See glStencilFuncSeparate.
        /// </summary>
        StencilFunc = All.STENCIL_FUNC,
        /// <summary>
        /// params returns one value, a symbolic constant indicating what action is taken when the stencil test passes, but the depth test fails. The initial value is GL_KEEP. See glStencilOp. This stencil state only affects non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See glStencilOpSeparate.
        /// </summary>
        StencilPassDepthFail = All.STENCIL_PASS_DEPTH_FAIL,
        /// <summary>
        /// params returns one value, a symbolic constant indicating what action is taken when the stencil test passes and the depth test passes. The initial value is GL_KEEP. See glStencilOp. This stencil state only affects non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See glStencilOpSeparate.
        /// </summary>
        StencilPassDepthPass = All.STENCIL_PASS_DEPTH_PASS,
        /// <summary>
        /// params returns one value, the reference value that is compared with the contents of the stencil buffer. The initial value is 0. See glStencilFunc. This stencil state only affects non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See glStencilFuncSeparate.
        /// </summary>
        StencilRef = All.STENCIL_REF,
        /// <summary>
        /// params returns a single boolean value indicating whether stencil testing of fragments is enabled. The initial value is GL_FALSE. See glStencilFunc and glStencilOp.
        /// </summary>
        StencilTest = All.STENCIL_TEST,
        /// <summary>
        /// params returns one value, the mask that is used to mask both the stencil reference value and the stencil buffer value before they are compared. The initial value is all 1's. See glStencilFunc. This stencil state only affects non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See glStencilFuncSeparate.
        /// </summary>
        StencilValueMask = All.STENCIL_VALUE_MASK,
        /// <summary>
        /// params returns one value, the mask that controls writing of the stencil bitplanes. The initial value is all 1's. See glStencilMask. This stencil state only affects non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See glStencilMaskSeparate.
        /// </summary>
        StencilWriteMask = All.STENCIL_WRITEMASK,
        /// <summary>
        /// params returns a single boolean value indicating whether stereo buffers (left and right) are supported.
        /// </summary>
        Stereo = All.STEREO,
        /// <summary>
        /// params returns one value, an estimate of the number of bits of subpixel resolution that are used to position rasterized geometry in window coordinates. The value must be at least 4.
        /// </summary>
        SubPixelBits = All.SUBPIXEL_BITS,
        /// <summary>
        /// params returns a single value, the name of the texture currently bound to the target GL_TEXTURE_1D. The initial value is 0. See glBindTexture.
        /// </summary>
        TextureBinding1D = All.TEXTURE_BINDING_1D,
        /// <summary>
        /// params returns a single value, the name of the texture currently bound to the target GL_TEXTURE_1D_ARRAY. The initial value is 0. See glBindTexture.
        /// </summary>
        TextureBinding1DArray = All.TEXTURE_BINDING_1D_ARRAY,
        /// <summary>
        /// params returns a single value, the name of the texture currently bound to the target GL_TEXTURE_2D. The initial value is 0. See glBindTexture.
        /// </summary>
        TextureBinding2D = All.TEXTURE_BINDING_2D,
        /// <summary>
        /// params returns a single value, the name of the texture currently bound to the target GL_TEXTURE_2D_ARRAY. The initial value is 0. See glBindTexture.
        /// </summary>
        TextureBinding2DArray = All.TEXTURE_BINDING_2D_ARRAY,
        /// <summary>
        /// params returns a single value, the name of the texture currently bound to the target GL_TEXTURE_2D_MULTISAMPLE. The initial value is 0. See glBindTexture.
        /// </summary>
        TextureBinding2DMultiSample = All.TEXTURE_BINDING_2D_MULTISAMPLE,
        /// <summary>
        /// params returns a single value, the name of the texture currently bound to the target GL_TEXTURE_2D_MULTISAMPLE_ARRAY. The initial value is 0. See glBindTexture.
        /// </summary>
        TextureBinding2DMultiSampleArray = All.TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY,
        /// <summary>
        /// params returns a single value, the name of the texture currently bound to the target GL_TEXTURE_3D. The initial value is 0. See glBindTexture.
        /// </summary>
        TextureBinding3D = All.TEXTURE_BINDING_3D,
        /// <summary>
        /// params returns a single value, the name of the texture currently bound to the target GL_TEXTURE_BUFFER. The initial value is 0. See glBindTexture.
        /// </summary>
        TextureBindingBuffer = All.TEXTURE_BINDING_BUFFER,
        /// <summary>
        /// params returns a single value, the name of the texture currently bound to the target GL_TEXTURE_CUBE_MAP. The initial value is 0. See glBindTexture.
        /// </summary>
        TextureBindingCubeMap = All.TEXTURE_BINDING_CUBE_MAP,
        /// <summary>
        /// params returns a single value, the name of the texture currently bound to the target GL_TEXTURE_RECTANGLE. The initial value is 0. See glBindTexture.
        /// </summary>
        TextureBindingRectangle = All.TEXTURE_BINDING_RECTANGLE,
        /// <summary>
        /// 
        /// </summary>
        TextureBindingCubeMapArray = All.TEXTURE_BINDING_CUBE_MAP_ARRAY,
        /// <summary>
        /// params returns a single value indicating the mode of the texture compression hint. The initial value is GL_DONT_CARE.
        /// </summary>
        TextureCompressionHint = All.TEXTURE_COMPRESSION_HINT,        
        ///// <summary>
        ///// params returns a single value, the name of the buffer object currently bound to the GL_TEXTURE_BUFFER buffer binding point. The initial value is 0. See glBindBuffer.
        ///// </summary>
        //TextureBindingBuffer = All.TEXTURE_BINDING_BUFFER,
        TextureBufferDataStoreBinding = All.TEXTURE_BUFFER_DATA_STORE_BINDING,
        /// <summary>
        /// params returns a single value, the minimum required alignment for texture buffer sizes and offset. The initial value is 1. See glUniformBlockBinding.
        /// </summary>
        TextureBufferOffsetAlignment = All.TEXTURE_BUFFER_OFFSET_ALIGNMENT,
        /// <summary>
        /// params returns a single value, the 64-bit value of the current GL time. See glQueryCounter.
        /// </summary>
        Timestamp = All.TIMESTAMP,
        /// <summary>
        /// When used with non-indexed variants of glGet (such as glGetIntegerv), params returns a single value, the name of the buffer object currently bound to the target GL_TRANSFORM_FEEDBACK_BUFFER. If no buffer object is bound to this target, 0 is returned. When used with indexed variants of glGet (such as glGetIntegeri_v), params returns a single value, the name of the buffer object bound to the indexed transform feedback attribute stream. The initial value is 0 for all targets. See glBindBuffer, glBindBufferBase, and glBindBufferRange.
        /// </summary>
        TransformFeedbackBufferBinding = All.TRANSFORM_FEEDBACK_BUFFER_BINDING,
        /// <summary>
        /// When used with indexed variants of glGet (such as glGetInteger64i_v), params returns a single value, the start offset of the binding range for each transform feedback attribute stream. The initial value is 0 for all streams. See glBindBufferRange.
        /// </summary>
        TransformFeedbackBufferStart = All.TRANSFORM_FEEDBACK_BUFFER_START,
        /// <summary>
        /// When used with indexed variants of glGet (such as glGetInteger64i_v), params returns a single value, the size of the binding range for each transform feedback attribute stream. The initial value is 0 for all streams. See glBindBufferRange.
        /// </summary>
        TransformFeedbackBufferSize = All.TRANSFORM_FEEDBACK_BUFFER_SIZE,
        /// <summary>
        /// When used with non-indexed variants of glGet (such as glGetIntegerv), params returns a single value, the name of the buffer object currently bound to the target GL_UNIFORM_BUFFER. If no buffer object is bound to this target, 0 is returned. When used with indexed variants of glGet (such as glGetIntegeri_v), params returns a single value, the name of the buffer object bound to the indexed uniform buffer binding point. The initial value is 0 for all targets. See glBindBuffer, glBindBufferBase, and glBindBufferRange.
        /// </summary>
        UniformBufferBinding = All.UNIFORM_BUFFER_BINDING,
        /// <summary>
        /// params returns a single value, the minimum required alignment for uniform buffer sizes and offset. The initial value is 1. See glUniformBlockBinding.
        /// </summary>
        UniformBufferOffsetAlignment = All.UNIFORM_BUFFER_OFFSET_ALIGNMENT,
        /// <summary>
        /// When used with indexed variants of glGet (such as glGetInteger64i_v), params returns a single value, the size of the binding range for each indexed uniform buffer binding. The initial value is 0 for all bindings. See glBindBufferRange.
        /// </summary>
        UniformBufferSize = All.UNIFORM_BUFFER_SIZE,
        /// <summary>
        /// When used with indexed variants of glGet (such as glGetInteger64i_v), params returns a single value, the start offset of the binding range for each indexed uniform buffer binding. The initial value is 0 for all bindings. See glBindBufferRange.
        /// </summary>
        UniformBufferStart = All.UNIFORM_BUFFER_START,
        /// <summary>
        /// params returns one value, the byte alignment used for reading pixel data from memory. The initial value is 4. See glPixelStore.
        /// </summary>
        UnpackAlignment = All.UNPACK_ALIGNMENT,
        /// <summary>
        /// params returns one value, the image height used for reading pixel data from memory. The initial is 0. See glPixelStore.
        /// </summary>
        UnpackImageHeight = All.UNPACK_IMAGE_HEIGHT,
        /// <summary>
        /// params returns a single boolean value indicating whether single-bit pixels being read from memory are read first from the least significant bit of each unsigned byte. The initial value is GL_FALSE. See glPixelStore.
        /// </summary>
        UnpackLsbFirst = All.UNPACK_LSB_FIRST,
        /// <summary>
        /// params returns one value, the row length used for reading pixel data from memory. The initial value is 0. See glPixelStore.
        /// </summary>
        UnpackRowLength = All.UNPACK_ROW_LENGTH,
        /// <summary>
        /// params returns one value, the number of pixel images skipped before the first pixel is read from memory. The initial value is 0. See glPixelStore.
        /// </summary>
        UnpackSkipImages = All.UNPACK_SKIP_IMAGES,
        /// <summary>
        /// params returns one value, the number of pixel locations skipped before the first pixel is read from memory. The initial value is 0. See glPixelStore.
        /// </summary>
        UnpackSkipPixels = All.UNPACK_SKIP_PIXELS,
        /// <summary>
        /// params returns one value, the number of rows of pixel locations skipped before the first pixel is read from memory. The initial value is 0. See glPixelStore.
        /// </summary>
        UnpackSkipRows = All.UNPACK_SKIP_ROWS,
        /// <summary>
        /// params returns a single boolean value indicating whether the bytes of two-byte and four-byte pixel indices and components are swapped after being read from memory. The initial value is GL_FALSE. See glPixelStore.
        /// </summary>
        UnpackSwapBytes = All.UNPACK_SWAP_BYTES,
        /// <summary>
        /// params returns a single value, the name of the vertex array object currently bound to the context. If no vertex array object is bound to the context, 0 is returned. The initial value is 0. See glBindVertexArray.
        /// </summary>
        VertexArrayBinding = All.VERTEX_ARRAY_BINDING,
        /// <summary>
        /// 
        /// </summary>
        VertexProgramPointSize = All.VERTEX_PROGRAM_POINT_SIZE,
        /// <summary>
        /// Accepted by the indexed forms. params returns a single integer value representing the instance step divisor of the first element in the bound buffer's data store for vertex attribute bound to index.
        /// </summary>
        VertexBindingDivisor = All.VERTEX_BINDING_DIVISOR,
        /// <summary>
        /// Accepted by the indexed forms. params returns a single integer value representing the byte offset of the first element in the bound buffer's data store for vertex attribute bound to index.
        /// </summary>
        VertexBindingOffset = All.VERTEX_BINDING_OFFSET,
        /// <summary>
        /// Accepted by the indexed forms. params returns a single integer value representing the byte offset between the start of each element in the bound buffer's data store for vertex attribute bound to index.
        /// </summary>
        VertexBindingStride = All.VERTEX_BINDING_STRIDE,
        /// <summary>
        /// params returns a single integer value containing the maximum offset that may be added to a vertex binding offset.
        /// </summary>
        MaxVertexAttribRelativeOffset = All.MAX_VERTEX_ATTRIB_RELATIVE_OFFSET,
        /// <summary>
        /// params returns a single integer value containing the maximum number of vertex buffers that may be bound.
        /// </summary>
        MaxVertexAttribBindings = All.MAX_VERTEX_ATTRIB_BINDINGS,
        /// <summary>
        /// When used with non-indexed variants of glGet (such as glGetIntegerv), params returns four values: the x and y window coordinates of the viewport, followed by its width and height. Initially the x and y window coordinates are both set to 0, and the width and height are set to the width and height of the window into which the GL will do its rendering. See glViewport. When used with indexed variants of glGet (such as glGetIntegeri_v), params returns four values: the x and y window coordinates of the indexed viewport, followed by its width and height. Initially the x and y window coordinates are both set to 0, and the width and height are set to the width and height of the window into which the GL will do its rendering. See glViewportIndexedf.
        /// </summary>
        Viewport = All.VIEWPORT,
        /// <summary>
        /// params returns two values, the minimum and maximum viewport bounds range. The minimum range should be at least [-32768, 32767].
        /// </summary>
        ViewportBoundsRange = All.VIEWPORT_BOUNDS_RANGE,
        /// <summary>
        /// params returns one value, the implementation dependent specifc vertex of a primitive that is used to select the viewport index. If the value returned is equivalent to GL_PROVOKING_VERTEX, then the vertex selection follows the convention specified by glProvokingVertex. If the value returned is equivalent to GL_FIRST_VERTEX_CONVENTION, then the selection is always taken from the first vertex in the primitive. If the value returned is equivalent to GL_LAST_VERTEX_CONVENTION, then the selection is always taken from the last vertex in the primitive. If the value returned is equivalent to GL_UNDEFINED_VERTEX, then the selection is not guaranteed to be taken from any specific vertex in the primitive.
        /// </summary>
        ViewportIndexProvokingVertex = All.VIEWPORT_INDEX_PROVOKING_VERTEX,
        /// <summary>
        /// params returns a single value, the number of bits of sub-pixel precision which the GL uses to interpret the floating point viewport bounds. The minimum value is 0.
        /// </summary>
        ViewportSubPixelBits = All.VIEWPORT_SUBPIXEL_BITS,
        /// <summary>
        /// params returns a single value, the maximum index that may be specified during the transfer of generic vertex attributes to the GL.
        /// </summary>
        MaxElementIndex = All.MAX_ELEMENT_INDEX,

        QueryBufferBinding = All.QUERY_BUFFER_BINDING,

        #region OpenGL 4.0 Additions.

        // opengl 4.0 / ARB_gpu_shader5
        MaxGeometryShaderInvocations = All.MAX_GEOMETRY_SHADER_INVOCATIONS,
        MinFragmentInterpolationOffset = All.MIN_FRAGMENT_INTERPOLATION_OFFSET,
        MaxFragmentInterpolationOffset = All.MAX_FRAGMENT_INTERPOLATION_OFFSET,
        FragmentInterpolationOffsetBits = All.FRAGMENT_INTERPOLATION_OFFSET_BITS,
        //MaxVertexStreams = All.MAX_VERTEX_STREAMS, also part of ARB_transform_feedback3

        // opengl 4.0 / ARB_sample_shading
        SampleShading = All.SAMPLE_SHADING,
        MinSampleShadingValue = All.MIN_SAMPLE_SHADING_VALUE,

        // opengl 4.0 / ARB_shader_subroutine
        MaxSubroutines = All.MAX_SUBROUTINES,
        MaxSubroutineUniformLocations = All.MAX_SUBROUTINE_UNIFORM_LOCATIONS,

        // opengl 4.0 / ARB_tessellation_shader
        DefaultInnerLevel = All.PATCH_DEFAULT_INNER_LEVEL,
        DefaultOuterLevel = All.PATCH_DEFAULT_OUTER_LEVEL,
        MaxPatchVertices = All.MAX_PATCH_VERTICES,
        MaxTessGenLevel = All.MAX_TESS_GEN_LEVEL,
        MaxTessControlUniformComponents = All.MAX_TESS_CONTROL_UNIFORM_COMPONENTS,
        MaxTessControlTextureImageUnits = All.MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS,
        MaxTessControlOutputComponents = All.MAX_TESS_CONTROL_OUTPUT_COMPONENTS,
        MaxTessPatchComponents = All.MAX_TESS_PATCH_COMPONENTS,
        MaxTessControlTotalOutputComponents = All.MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS,
        MaxTessControlUniformBlocks = All.MAX_TESS_CONTROL_UNIFORM_BLOCKS,
        MaxTessControlInputComponents = All.MAX_TESS_CONTROL_INPUT_COMPONENTS,
        MaxCombinedTessControlUniformComponents = All.MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS,

        MaxTessEvaluationUniformComponents = All.MAX_TESS_EVALUATION_UNIFORM_COMPONENTS,
        MaxTessEvaluationTextureImageUnits = All.MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS,
        MaxTessEvaluationOutputComponents = All.MAX_TESS_EVALUATION_OUTPUT_COMPONENTS,
        MaxTessEvaluationUniformBlocks = All.MAX_TESS_EVALUATION_UNIFORM_BLOCKS,
        MaxTessEvaluationInputComponents = All.MAX_TESS_EVALUATION_INPUT_COMPONENTS,
        MaxCombinedTessEvaluationUniformComponents = All.MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS,

        // opengl 4.0 / ARB_texture_gather
        MinProgramTextureGatherOffset = All.MIN_PROGRAM_TEXTURE_GATHER_OFFSET,
        MaxProgramTextureGatherOffset  = All.MAX_PROGRAM_TEXTURE_GATHER_OFFSET,
        //MaxProgramTextureGatherComponents = 0x8F9F,
    
        // opengl 4.0 / ARB_transform_feedback3
        MaxTransformFeedbackBuffers = All.MAX_TRANSFORM_FEEDBACK_BUFFERS,
        MaxTransformFeedbackBindings = MaxTransformFeedbackBuffers,
        MaxVertexStreams = All.MAX_VERTEX_STREAMS,

        #endregion

        #region OpenGL 4.1 Additions.

        ShaderBinaryFormats = All.SHADER_BINARY_FORMATS,
        //NumShaderBinaryFormats = All.NUM_SHADER_BINARY_FORMATS,

        #endregion

        #region OpenGL 4.2 Additions.

        // opengl 4.2 / ARB_compressed_texture_pixel_storage

        PackCompressedBlockWidth = All.PACK_COMPRESSED_BLOCK_WIDTH,
        PackCompressedBlockHeight = All.PACK_COMPRESSED_BLOCK_HEIGHT,
        PackCompressedBlockDepth = All.PACK_COMPRESSED_BLOCK_DEPTH,
        PackCompressedBlockSize = All.PACK_COMPRESSED_BLOCK_SIZE,

        UnpackCompressedBlockWidth = All.UNPACK_COMPRESSED_BLOCK_WIDTH,
        UnpackCompressedBlockHeight = All.UNPACK_COMPRESSED_BLOCK_HEIGHT,
        UnpackCompressedBlockDepth = All.UNPACK_COMPRESSED_BLOCK_DEPTH,
        UnpackCompressedBlockSize = All.UNPACK_COMPRESSED_BLOCK_SIZE,

        // OpenGL 4.2 / ARB_shader_atomic_counters
        AtomicCounterBufferBinding = All.ATOMIC_COUNTER_BUFFER_BINDING,
        /// <summary>
        /// GetIntegeri_64v
        /// </summary>
        AtomicCounterBufferStart = All.ATOMIC_COUNTER_BUFFER_START,
        /// <summary>
        /// GetIntegeri_64v
        /// </summary>
        AtomicCounterBufferSize = All.ATOMIC_COUNTER_BUFFER_SIZE,

        MaxVertexAtomicCounterBuffers = All.MAX_VERTEX_ATOMIC_COUNTER_BUFFERS,
        MaxFragmentAtomicCounterBuffers = All.MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS,
        MaxGeometryAtomicCounterBuffers = All.MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS,
        MaxTessControlAtomicCounterBuffers = All.MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS,
        MaxTessEvaluationAtomicCounterBuffers = All.MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS,

        MaxAtomicCounterBufferSize = All.MAX_ATOMIC_COUNTER_BUFFER_SIZE,
        MaxAtomicCounterBufferBindings = All.MAX_ATOMIC_COUNTER_BUFFER_BINDINGS,

        // OpenGL 4.2 / ARB_shader_image_load_store
        MaxImageUnits = All.MAX_IMAGE_UNITS,
        MaxCombinedImageUnitsAndFragmentOutputs = All.MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS,
        MaxImageSamples = All.MAX_IMAGE_SAMPLES,
        MaxVertexImageUniforms = All.MAX_VERTEX_IMAGE_UNIFORMS,
        MaxFragmentImageUniforms = All.MAX_FRAGMENT_IMAGE_UNIFORMS,
        MaxGeometryImageUniforms = All.MAX_GEOMETRY_IMAGE_UNIFORMS,
        MaxTessControlImageUniforms = All.MAX_TESS_CONTROL_IMAGE_UNIFORMS,
        MaxTessEvaluationImageUniforms = All.MAX_TESS_EVALUATION_IMAGE_UNIFORMS,
        MaxCombinedImageUniforms = All.MAX_COMBINED_IMAGE_UNIFORMS,

        //GetIntegeri_v and GetBooleani_v
        ImageBindingName = All.IMAGE_BINDING_NAME,
        ImageBindingLevel = All.IMAGE_BINDING_LEVEL,
        ImageBindingLayered = All.IMAGE_BINDING_LAYERED,
        ImageBindingLayer = All.IMAGE_BINDING_LAYER,
        ImageBindingAccess = All.IMAGE_BINDING_ACCESS,
        ImageBindingFormat = All.IMAGE_BINDING_FORMAT,

        #endregion

        #region OpenGL 4.3 Additions.

        // ARB_compute_shader
        MaxComputeImageUniforms = All.MAX_COMPUTE_IMAGE_UNIFORMS,
        MaxComputeSharedMemorySize = All.MAX_COMPUTE_SHARED_MEMORY_SIZE,
        MaxComputeWorkGroupInvocations = All.MAX_COMPUTE_WORK_GROUP_INVOCATIONS,

        // Accepted by the <pname> parameter of GetIntegeri_v, GetBooleani_v, GetFloati_v, GetDoublei_v and GetInteger64i_v:
        //MaxComputeWorkGroupCount = All.MAX_COMPUTE_WORK_GROUP_COUNT,
        MaxComputeworkGroupSize = All.MAX_COMPUTE_WORK_GROUP_SIZE,

        //ARB_shader_storage_buffer_object
        MaxShaderStorageBlockSize = All.MAX_SHADER_STORAGE_BLOCK_SIZE,
        MaxCombinedShaderOutputResources = All.MAX_COMBINED_SHADER_OUTPUT_RESOURCES,

        //KHR_debug
        //ContextFlags = All.CONTEXT_FLAGS,
        MaxDebugMessageLength = All.MAX_DEBUG_MESSAGE_LENGTH,
        MaxDebugLoggedMessages = All.MAX_DEBUG_LOGGED_MESSAGES,
        DebugLoggedMessages = All.DEBUG_LOGGED_MESSAGES,
        DebugNextLoggedMessageLength = All.DEBUG_NEXT_LOGGED_MESSAGE_LENGTH,

        CopyReadBufferBinding = All.COPY_READ_BUFFER_BINDING,
        CopyWriteBufferBinding = All.COPY_WRITE_BUFFER_BINDING,

        #endregion

        //ARB_sparse_texture
        MaxSparseTextureSizeARB = All.MAX_SPARSE_TEXTURE_SIZE_ARB,
        MaxSparseTexture3DSizeARB = All.MAX_SPARSE_3D_TEXTURE_SIZE_ARB,
        MaxSparseArrayTextureLayersARB = All.MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB,
        SparseTextureFullArrayCubeMipmapsARB = All.SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB,

        //NV_shader_buffer_load
        MaxShaderBufferAddressNV = All.MAX_SHADER_BUFFER_ADDRESS_NV,

        //NV_vertex_buffer_unified_memory
        /// <summary>
        /// GetIntegerui64i_vNV ONLY
        /// </summary>
        VertexAttribArrayAddress = All.VERTEX_ATTRIB_ARRAY_ADDRESS_NV,
        /// <summary>
        /// GetIntegerui64vNV ONLY
        /// </summary>
        ElementArrayAddressNV = All.ELEMENT_ARRAY_ADDRESS_NV,
        /// <summary>
        /// GetIntegeri_vNV ONLY
        /// </summary>
        VertexAttribArrayLengthNV = All.VERTEX_ATTRIB_ARRAY_LENGTH_NV,

        ElementArrayLengthNV = All.ELEMENT_ARRAY_LENGTH_NV,

        // some hacks?!
        MaxIndicesSize = MaxElementsIndices,
        MaxIndicesVertices = MaxElementsVertices,
        IndicesArrayBufferBinding = ElementArrayBufferBinding,

        // OpenGL 4.5
        // ARB_context_flush_control
        ContextReleaseBehavior = All.CONTEXT_RELEASE_BEHAVIOR,
        // ARB_cull_distance
        MaxCullDistances = All.MAX_CULL_DISTANCES,
        MaxCombinedClipAndCullDinstances = All.MAX_COMBINED_CLIP_AND_CULL_DISTANCES,

        //ARB_sparse_buffer
        SparseBufferPageSize = All.SPARSE_BUFFER_PAGE_SIZE_ARB,

        //EXT_texture_filter_anisotropic
        /// <summary>
        /// MAX_TEXTURE_MAX_ANISOTROPY_EXT
        /// </summary>
        MaxTextureAnisotropyEXT = All.MAX_TEXTURE_MAX_ANISOTROPY_EXT,

        #region OpenGL 2015

        //ARB_sample_locations
        SampleLocationSubPixelBits = All.SAMPLE_LOCATION_SUBPIXEL_BITS_ARB,
        SampleLocationPixelGridWidth = All.SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB,
        SampleLocationPixelGridHeight = All.SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB,
        ProgrammableSampleLocationTableSize = All.PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB,

        //ARB_parallel_shader_compile
        MaxShaderCompilerThreads = All.MAX_SHADER_COMPILER_THREADS_ARB,

        #endregion
    }
}
