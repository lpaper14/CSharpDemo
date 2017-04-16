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

            //ShowEnvironmentDetails();
            FormatNumericalData();
            Console.ReadLine();

            var floatNum = 1.23f;
            var doubleNum = 1.23;
            var decimalNum = 1.23m;
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

        static void FormatNumericalData()
        {
            Console.WriteLine($"c format: {99999:c}");
            Console.WriteLine($"C format: {99999:C}");
            Console.WriteLine($"d9 format: {99999:d9}");
            Console.WriteLine($"f3 format: {99999:f3}");
            Console.WriteLine($"n5 format: {99999:n5}");
            Console.WriteLine($"E format: {99999:E}");
            Console.WriteLine($"e format: {99999:e}");
            Console.WriteLine($"X format: {99999:X}");
            Console.WriteLine($"x format: {99999:x}");
        }
    }
}
