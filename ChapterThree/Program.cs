using System;

namespace ChapterThree
{
    class Program
    {
        static void Main()
        {
            // if we use this method to get command line arguments, we don't even need the args as input parameters in Main().
            var cmdArgs = Environment.GetCommandLineArgs();
            foreach (var arg in cmdArgs)
            {
                Console.WriteLine($"Arg is: {arg}");
            }

            Console.ReadLine();
        }
    }
}
