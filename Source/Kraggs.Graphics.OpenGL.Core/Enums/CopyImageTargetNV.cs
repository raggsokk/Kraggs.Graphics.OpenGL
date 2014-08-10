using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kraggs.Graphics.OpenGL
{
    public enum CopyImageTargetNV
    {
        Renderbuffer = All.RENDERBUFFER,
        Texture1D = All.TEXTURE_1D,
        Texture1DArray = All.TEXTURE_1D_ARRAY,
        Texture2D = All.TEXTURE_2D,
        Texture2DArray = All.TEXTURE_2D_ARRAY,

        Texture3D = All.TEXTURE_3D,
        TextureCubemap = All.TEXTURE_CUBE_MAP,
    }
}
