using System;

namespace exe4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler um número e informar seu valor absoluto
            //( Exemplo: ABS(10) = 10 / ABS(-10) = 10)

            int Valor;
            Console.WriteLine("Escreva um número");

            Valor = int.Parse(Console.ReadLine());

            int  ValorAbsoluto = Math.Abs(Valor);

            Console.WriteLine("o Valor Absoluto é:"+ValorAbsoluto);

        }
    }
}
