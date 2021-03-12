using System;

namespace FirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.Write("Enter a value for a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("Enter a value for b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {a} + {b} equals {AddNumbers(a, b)}");
        }

        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
