using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            float A;
            Console.WriteLine("Escreva um número");

            A = float.Parse(Console.ReadLine());

            if (A % 2 == 0)
            {
                Console.WriteLine("Esse número é par");
            }

            else if (A % 2 != 0 )
            {
                Console.WriteLine("Esse número é ímpar");

            }

            else
            {
                Console.WriteLine("Esse número é 0");
            }

        }
    }
}
