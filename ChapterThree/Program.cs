using System;

namespace ChapterThree
{
    class Program
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //C# 6.0 new feature: string interpolation
        //Please don't use "="!

        //public string GetGradePointPercentage() => $"Name: {LastName}, {FirstName}. G.P.A: {Grades.Average():F2}";
        public string FullName => $"{FirstName} {LastName}";

        static void Main()
        {
            // if we use this method to get command line arguments, we don't even need the args as input parameters in Main().
            var cmdArgs = Environment.GetCommandLineArgs();
            foreach (var arg in cmdArgs)
            {
                Console.WriteLine($"Arg is: {arg}");
            }

            ShowEnvironmentDetails();
            Console.ReadLine();
        }

        static void ShowEnvironmentDetails()
        {
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine($"Drive: {drive}");
            }

            Console.WriteLine($"OS: {Environment.OSVersion}");
            Console.WriteLine($"Number of Processors: {Environment.ProcessorCount}");
            Console.WriteLine($".Net Version： {Environment.Version}");
        }
    }
}
