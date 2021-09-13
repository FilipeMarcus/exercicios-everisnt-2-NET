using System;

namespace _1stDesafiosCSharp002
{
    class Program
    {
        static void Main(string[] args)
        {
            //double valor1 = double.Parse(Console.ReadLine());
            //double valor2 = double.Parse(Console.ReadLine());
            //double valor3 = double.Parse(Console.ReadLine());
            //double valor4 = double.Parse(Console.ReadLine());
            //double valor5 = double.Parse(Console.ReadLine());
            //double valor6 = double.Parse(Console.ReadLine());
            double valor;
            int ehPositivo = 0;
            
            for (int i = 1; i <=6; i++)
            {
              valor = double.Parse(Console.ReadLine());
              if (valor > 0.0){
                ehPositivo += 1;
              }
            }
           //comtinue com sua solução

            Console.WriteLine(ehPositivo + " valores positivos");
        }
    }
}
