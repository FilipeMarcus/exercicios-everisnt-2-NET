using System;

namespace DesafiosCSharp03
{
    class Classe
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double raio = Double.Parse(Console.ReadLine());
            double area = Math.Pow(raio, 2) * pi;
            Console.WriteLine("A={0}\n", area.ToString("N4").Replace(",",""));
        }
    }
}
