using System;

namespace FirstProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numberA = 0, numberB = 0;

            Console.Write("Enter a value for a: ");
            numberA = Int32.Parse(Console.ReadLine());

            Console.Write("Enter a value for b: ");
            numberB = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Adding {numberA} + {numberB} equals {SubstractNumbers(numberA, numberB)}");
        }

        public static int SubstractNumbers(int numberA, int numberB)
        {
            return numberA - numberB;
        }
    }
}