Kraggs.Graphics.OpenGL
======================

OpenGL and OpenGL ES Wrapper Libraries.

A collection of manually created wrapper libraries for OpenGL 4.4 core context and OpenGL ES 3.x.
The GL Function Pointers are loaded by code from the excellent OpenTK Project.

WARNING:
These projects are in the process of being rewritten from scratch to use the new OpenTK Loader from OpenTK v1.1.4. 
Also since the new loader rewrites the dll file as a post process it makes the current layout with code split in multiple libraries problematic.
The problem is cased by the internal references detects library changes between builds and other issues.
So the new design will for now merge all the OpenGL projects to one and OpenGL ES to another, until the above issue is fixed. 
To create smaller code deployments, use the same solution as OpenTK uses, which is to run the final executable through MonoLinker.

## The solution has these projects.

### Kraggs.Graphics.OpenGL.Core
This is the OpenGL library which implements the OpenGL Core v4.4 functions. It also contains some ARB and DSA functions relevant to the core context.

### Kraggs.Graphics.OpenGL.ES
This is the OpenGL ES library, implementing v3.x of spec.
Alpha State. Work still in progress.

### EntryPointGenerator
Scans thru the source code and generates the EntryPoint Arrays used by the OpenTK Loader V2.
This is a pre build step used by both Kraggs.Graphics.OpenGL and Kraggs.Graphics.OpenGLES.
Uses Roslyn/Microsoft.CodeAnalysis for code parsing.

### Generator.Rewrite
Cloned from OpenTK project. Modified to be more generic and suitable for our needs.
Is a post build step for rewriting the dllimports to actual code calling into function pointers.
Uses Mono Cecil for rewriting the MSIL.

### Discontinued projects.
* Kraggs.Graphics.OpenGL.Core is renamed to Kraggs.Graphics.OpenGL. 
* Kraggs.Graphics.OpenGL.ES is renamed to Kraggs.Graphics.OpenGLES.
* Kraggs.Graphics.OpenGL.Compatibility is for now depricated (was never finished).
* Kraggs.Graphics.OpenGL.DSA is merged into Kraggs.Graphics.OpenGL.
* Kraggs.Graphics.OpenGL.CoreExtended is also merged into Kraggs.Graphics.OpenGL.
* Kraggs.Graphics.OpenGL.Enums is duplicated into both Kraggs.Graphics.OpenGL and Kraggs.Graphics.OpenGLES.

## License: 

The code for loading the OpenGL Function pointers is based/stolen from the excellent OpenTK Project by Stefanos Apostolopoulos and others.
Also the code for rewriting the DLL using Cecil is from the OpenTK Project. The licenses in all these cases are retained, but marked as modified.
Since a large portion of these projects depends on code from OpenTK Project, we are using the same license as the OpenTK Project.

#### Kraggs.Graphics.OpenGL (github.com/raggsokk)

 Copyright (c) 2014 Jarle Hansen (github.com/raggsokk)
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

### Third Parties

The OpenTK Project has other third party license notices at http://www.opentk.com/project/license but since we are not using any code covered by those.

#### The Open Toolkit library license

Copyright (c) 2006 - 2013 Stefanos Apostolopoulos (stapostol@gmail.com) for the Open Toolkit library.
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


