using System;
using System.Collections.Generic;
using System.Text;


namespace Kraggs.Graphics
{
    /// <summary>
    /// Decorates a function with its corrosponding dllimport.
    /// Used only during rewrite of il code. Can be removed afterwards.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class EntryPointAttribute : Attribute
    {
        /// <summary>
        /// Name of dll import name.
        /// </summary>
        public string FunctionName { get; protected set; }

        /// <summary>
        /// Decorates a function with its corrosponding dllimport.
        /// </summary>
        /// <param name="FunctionName"></param>
        public EntryPointAttribute(string FunctionName)
        {
            this.FunctionName = FunctionName;
        }
    }
}
