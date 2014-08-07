using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;

namespace EntryPointGenerator
{
    /// <summary>
    /// Contains the whole config needed for parsing entry points code for 1 class.    
    /// </summary>
    //TODO: Find better name?
    [DebuggerDisplay("{Output}")]
    public class clsWorkUnit
    {
        /// <summary>
        /// Write output to this file.
        /// </summary>
        /// <returns></returns>
        public string Output { get; set; }

        /// <summary>
        /// Override name of attribute to scan for.
        /// (Still assumes the SlotID is first argument on attribute..)
        /// </summary>
        /// <returns></returns>
        public string SlotAttributeName { get; set; }

        /// <summary>
        /// A list of files containing the class.
        /// </summary>
        /// <returns></returns>
        public string[] PartialClasses { get; set; }

        protected clsWorkUnit()
        {
            //PartialClasses = new string[];
        }

        public static clsWorkUnit FromFile(string filenamepath)
        {
            if (!File.Exists(filenamepath))
                throw new FileNotFoundException();

            var content = File.ReadAllText(filenamepath);

            //var work = new clsWorkUnit();

            var work = JsonConvert.DeserializeObject<clsWorkUnit>(content, new JsonSerializerSettings()
            {
                // no options yet.
            });

            if (string.IsNullOrWhiteSpace(work.SlotAttributeName))
                work.SlotAttributeName = "EntryPointSlot";

            return work;
        }
    }
}
