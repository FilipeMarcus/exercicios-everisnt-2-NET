using System;

namespace _1stStepsCSharp01
{
    class Program
    {
        static void Main(string[] args)
        {
            int quilometros = Int32.Parse(Console.ReadLine());
            int minutos = quilometros * 2; // Digite aqui o calculo dos minutos
            Console.WriteLine(minutos + " minutos");
        }
    }
}
