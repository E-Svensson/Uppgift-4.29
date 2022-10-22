using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bestäm triangelns sidlängd: "); int sidlängd = int.Parse(Console.ReadLine());

            for (int i = 0; i < sidlängd; i++)
            {
                Console.WriteLine();

                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
            }

            Console.WriteLine();
        }
    }
}
