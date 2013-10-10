Kraggs.Graphics.Opengl
======================

OpenGL 4.4 Wrapper Libraries.

A collection of manually created wrapper libraries for opengl 4.4 core context.

The solution has these projects.

*Kraggs.Graphics.OpenGL.Core

This is the core library which implements the loader and OpenGL Core v4.4 functions.

*Kraggs.Graphics.OpenGL.ARB

This addon library contains the functions of ARB extensions from OpenGL v3.3 and up.

*Kraggs.Graphics.OpenGL.DSA

This addon library is a collection of DSA style functions across opengl extensions from Core 3.3 to Core 4.4.

As an example:
	ARB_buffer_storage, an extension newly included in OpenGL 4.4, implements BufferStorage and
	where EXT_direct_state_access is present, also implements NamedBufferStorageEXT.
	

Warning: 
Beta State, almost all if not all of the opengl functions is present, work is still in progress for validating all enumerations in use for the functions.
Se also Kraggs.Graphics.OpenGL.DSA for a companion project to this project containing updated DSA functions for core extensions.

License: LGPL

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
