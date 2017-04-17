using System;
using System.Numerics;

namespace ChapterThree
{
    class Program
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String stringType { get; set; }
        public Int32 intType { get; set; }
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


            var floatNum = 1.23f;
            var doubleNum = 1.23;
            var decimalNum = 1.23m;

            //BigInteger represents an arbitrary large signed value
            BigInteger bi = new BigInteger(123456676.78974f);
            Console.WriteLine($"The value of bi is  {bi}");

            Console.WriteLine($"The max value and min value of byte is {byte.MaxValue} and {byte.MinValue}");
            Console.WriteLine($"The max value and min value of uint is {uint.MaxValue} and {uint.MinValue}");
            Console.WriteLine($"double.Epsilon: {double.Epsilon}");
            Console.WriteLine($"double.PositiveInfinity: {double.PositiveInfinity}");
            Console.WriteLine($"double.NegativeInfinity: {double.NegativeInfinity}");
            Console.WriteLine($"bool.FalseString: {bool.FalseString}");
            Console.WriteLine($"bool.TrueString: {bool.TrueString}");
            CharFunctionality();
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

            bool isFalse = new bool();
            Console.WriteLine($"isFalse is {isFalse}");
        }

        static void CharFunctionality()
        {
            Console.WriteLine($"char.isPunctuation('?'): {char.IsPunctuation('?')}");

            Console.WriteLine($"char.IsPunctuation('!'): {char.IsPunctuation('!')}");
        }
    }
}
