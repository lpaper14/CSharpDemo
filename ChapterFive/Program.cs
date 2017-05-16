using System;

namespace ChapterFive
{
    class Program
    {
        static void Main(string[] args)
        {
            var motor = new Motorcycle();

            motor.SetDriverName("Jacob");

            Console.WriteLine($"The drive name is {motor.name}");

            Console.ReadKey();
        } 
    }
}
