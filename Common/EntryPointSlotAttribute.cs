using System;
using System.Collections.Generic;
using System.Text;

namespace Kraggs.Graphics
{
    /// <summary>
    /// Slot or array index in EntryPoint* Arrays containg the function pointer of this function.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class EntryPointSlotAttribute : Attribute
    {
        public int SlotID { get; set; }

        /// <summary>
        /// Slot or array index in EntryPoint* Arrays containg the function pointer of this function.
        /// </summary>
        /// <param name="SlotID"></param>
        public EntryPointSlotAttribute(int SlotID)
        {
            this.SlotID = SlotID;
        }
    }
}
