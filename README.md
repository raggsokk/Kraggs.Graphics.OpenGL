Kraggs.Graphics.OpenGL
======================

OpenGL 4.4 Wrapper Libraries.

A collection of manually created wrapper libraries for OpenGL 4.4 core context and OpenGL ES 3.x.

## The solution has these projects.

### Kraggs.Graphics.OpenGL.Enums
This is the common dll used by both OpenGL context libs and OpenGL ES 3.x libs.
It contains common enum values used by both opengl and es but not all enum values is valid in both contexts.
It also contains the OpenTK Loader used to load opengl functions.

### Kraggs.Graphics.OpenGL.Core

This is the core library which implements the OpenGL Core v4.4 functions.

### Kraggs.Graphics.OpenGL.CoreExtended

This addon library contains the functions of ARB/EXT extensions from OpenGL v3.3 and up.
It also contains some other usefull extensions and therefore is named CoreExtended instead of CoreExtensions.

### Kraggs.Graphics.OpenGL.DSA

This addon library is a collection of DSA style functions across opengl extensions from Core 3.3 to Core 4.4.

As an example:
	ARB_buffer_storage, an extension newly included in OpenGL 4.4, implements BufferStorage and
	where EXT_direct_state_access is present, also implements NamedBufferStorageEXT.
	

Warning: 
Beta State, almost all if not all of the opengl functions is present, work is still in progress for validating all enumerations in use for the functions.
Se also Kraggs.Graphics.OpenGL.DSA for a companion project to this project containing updated DSA functions for core extensions.

# License: 

## Kraggs.Graphics.OpenGL (github.com/raggsokk)

### Copyright (c) 2013 Jarle Hansen (github.com/raggsokk)
 Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:
 
 The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.
 
 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.

