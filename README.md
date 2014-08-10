Kraggs.Graphics.OpenGL
======================

# OpenGL (and OpenGL ES) Wrapper Libraries.

A collection of manually created wrapper libraries for OpenGL 4.4 core context and OpenGL ES 3.x.
The GL Function Pointers are loaded by code from the excellent [OpenTK Project](http://www.opentk.com).
Note this library is not for creating an OpenGL Context. Other excellent project exists for that. (OpenTK, SDL2, GLFW3)

## Usage:
1. Add a reference to Kraggs.Graphics.OpenGL.Core
2. Use your OpenTK, SDL2, GLFW3 to create an OpenGL Core profile, preferable 4.x
3. Add a using statement to your code.
	*Example:*
	
```csharp
using Kraggs.Graphics.OpenGL;
```

4. Call instance function LoadEntryPoints() on the class containing the OpenGL Functions you need.
	*Example:*
	
```csharp	
new Kraggs.Graphics.OpenGL.GL().LoadEntryPoints();
new Kraggs.Graphics.OpenGL.DSA().LoadEntryPoints();
new Kraggs.Graphics.OpenGL.ARB().LoadEntryPoints();
```		
(Kraggs.Graphics.OpenGL added to new statement for clarity...)

5. Start using code.
	*Example:*
	
```csharp
Console.WriteLine("OpenGL Vendor:   {0}", GL.GetString(StringName.Vendor));
Console.WriteLine("OpenGL Renderer: {0}", GL.GetString(StringName.Renderer));
Console.WriteLine("OpenGL Version:  {0}", GL.GetString(StringName.Version));
Console.WriteLine("GLSL Version:    {0}", GL.GetString(StringName.ShadingLanguageVersion));
```
	

**On my computer this takes about 3ms to load!**
	
		
## WARNING:
These projects have just been rewritten from scratch to use the new OpenTK Loader from the [OpenTK Project](http://www.opentk.com) v1.1.4.
Since the new loader from OpenTK rewrites the MSIL as a post build process, it made the old layout with code in multiple libraries problematic.
The new design have now merged all the OpenGL Projects to one and will merge the OpenGL ES to another (when its implemented).
In order to create smaller code deployments, use the same solution as OpenTK uses, which is to run the final executable through Monolinker to merge just the code you use into one assembly.

## The solution has these projects.

### Kraggs.Graphics.OpenGL.Core
This is the OpenGL library which implements the OpenGL Core v4.4 functions. It also contains ARB, DSA, NV and some AMD functions relevant to the core context.

### Kraggs.Graphics.OpenGL.ES
This is the OpenGL ES library, implementing v3.x of spec.
As of now this is not rewritten from old loader yet and is depricated until it is.

### EntryPointGenerator
Scans thru the source code and generates the EntryPoint Arrays used by the OpenTK Loader V2.
This is a pre build step used by both Kraggs.Graphics.OpenGL and Kraggs.Graphics.OpenGLES.
Uses Roslyn/Microsoft.CodeAnalysis for code parsing.
Needs this nuget packages to work:
Install-Package Newtonsoft.Json
Install-Package Microsoft.CodeAnalysis -Pre


### Generator.Rewrite
Cloned from OpenTK project. Modified to be more generic and suitable for my needs.
Mostly that is changed to use a Json config file specifing changes from OpenTK's usage. 
Also change functions to drag this config with itself. Probably could just made it a field on the Program.cs instead.
Is a post build step for rewriting the dllimports to actual code calling into function pointers.
Uses Mono Cecil for rewriting the MSIL.
This is heavy MSIL Magic from the OpenTK Project.

### Discontinued projects.
* Kraggs.Graphics.OpenGL.Core is renamed to Kraggs.Graphics.OpenGL. 
* Kraggs.Graphics.OpenGL.ES is renamed to Kraggs.Graphics.OpenGLES.
* Kraggs.Graphics.OpenGL.Compatibility is for now depricated (was never finished).
* Kraggs.Graphics.OpenGL.DSA is merged into Kraggs.Graphics.OpenGL.
* Kraggs.Graphics.OpenGL.CoreExtended is also merged into Kraggs.Graphics.OpenGL.
* Kraggs.Graphics.OpenGL.Enums is duplicated into both Kraggs.Graphics.OpenGL and Kraggs.Graphics.OpenGLES.

## License: 

The code for loading the OpenGL Function pointers is based/stolen from the excellent [OpenTK Project](http://www.opentk.com) by Stefanos Apostolopoulos and others.
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

The OpenTK Project has other third party license notices at http://www.opentk.com/project/license but the library is not using any code except Mono.Cecil* during building.

#### The Open Toolkit library license

Copyright (c) 2006 - 2013 Stefanos Apostolopoulos (stapostol@gmail.com) for the Open Toolkit library.
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


