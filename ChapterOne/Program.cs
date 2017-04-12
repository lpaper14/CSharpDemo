using System;

namespace ChapterOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //ObsoleteMethod();
        }
        [Obsolete("This method is Obsolete!")]
        public static void ObsoleteMethod()
        {
            Console.WriteLine("This method is obsolete!");
        }
    }

    public class Winnebago
    {
        //public ulong notCompliant;
    }
}
