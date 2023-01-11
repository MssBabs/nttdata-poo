using System;

namespace CalculatorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
                Console.WriteLine("Hello Word");

            #if DEBUG
                Console.WriteLine("DEBUG VERSION");
            #else
                Console.WriteLine("RELEASE VERSION");
            #endif

            if (i == 0)
                Console.WriteLine("Hello Word 2");
        }
    }
}
