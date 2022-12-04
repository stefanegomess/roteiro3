using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            float A;
            Console.WriteLine("Escreva um número");

            A = float.Parse(Console.ReadLine());

            if (A > 0)
            {
                Console.WriteLine("Esse número é positivo");
            }

            else if (A < 0)
            {
                Console.WriteLine("Esse número é negativo");

            }

            else
            {
                Console.WriteLine("Esse número é 0");
            }

        }
    }
}
