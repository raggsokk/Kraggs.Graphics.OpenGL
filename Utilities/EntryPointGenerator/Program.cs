using System;

using System.IO;

namespace EntryPointGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                if (!File.Exists(args[0]))
                {
                    Console.Error.WriteLine("ERROR: expected filename with work config.");
                    Console.Error.WriteLine("Arguments Found: Arg={0}", string.Join(",Arg=", args));
                    PrintUsage();
                    Environment.Exit(1);
                }

                //var work = clsWorkUnit.FromFile("TestConfig.json");
                var work = clsWorkUnit.FromFile(args[0]);

                var result = EntryPointSlotScanner.ScanWorkUnit(work);

                SimpleCodeWriter.Write(result, work);
            }
            else if (args.Length == 0)
            {
                PrintUsage();
            }
            else
            {
                Console.WriteLine("ERROR: Uknown arguments");
                Console.WriteLine("  Arg={0}", string.Join(",Arg=", args));
                PrintUsage();
                Environment.Exit(1);
            }

        }

        public static void PrintUsage()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("  EntryPointGenerator.exe <work.json>");
            Console.WriteLine("work.json is for example this.");
            Console.WriteLine("{");
            Console.WriteLine("  \"Output\": \"output.autogen.cs\",");
            Console.WriteLine("  \"PartialClasses\": [");
            Console.WriteLine("    \"file.partial1.cs\",");
            Console.WriteLine("    \"file.partial2.cs\",");
            Console.WriteLine("  ]");
            Console.WriteLine("}");
        }
    }
}
