using System;

namespace Ihor_Lesson3
{
    class Program
    {
        static void MultiplicationTable()
        {
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

                Console.WriteLine();
            }
        }

        static void AsciiTable()
        {
            for (int i = 0; i < 128; i++)
            {
                Console.WriteLine($"{(char)i}\t{i}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(char.IsLetter('5'));
        }
    }
}
