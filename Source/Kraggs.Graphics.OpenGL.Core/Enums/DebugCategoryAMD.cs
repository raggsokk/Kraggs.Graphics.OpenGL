using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kraggs.Graphics.OpenGL
{
    public enum DebugCategoryAMD
    {
        AllCategories = 0,
        //DontCare = All.DONT_CARE,
        ApiError = All.DEBUG_CATEGORY_API_ERROR_AMD,
        WindowSystem = All.DEBUG_CATEGORY_WINDOW_SYSTEM_AMD,
        Deprication = All.DEBUG_CATEGORY_DEPRECATION_AMD,
        UndefinedBehavior = All.DEBUG_CATEGORY_UNDEFINED_BEHAVIOR_AMD,
        Performance = All.DEBUG_CATEGORY_PERFORMANCE_AMD,
        ShaderCompiler = All.DEBUG_CATEGORY_SHADER_COMPILER_AMD,
        Application = All.DEBUG_CATEGORY_APPLICATION_AMD,
        Other = All.DEBUG_CATEGORY_OTHER_AMD,
        
    }
}
