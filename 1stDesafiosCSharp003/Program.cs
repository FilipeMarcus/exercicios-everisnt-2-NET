using System;

namespace _1stDesafiosCSharp003
{
    class Program
    {
        static void Main(string[] args)
        {
            double entrada, nota1=0, nota2=0, media;
            bool n1 = false, n2 = false;
            do
            {
              entrada = double.Parse(Console.ReadLine());
              if (entrada >= 0.0 && entrada <= 10.0)
              {
                if (n1 == false)
                {
                  nota1 = entrada;
                  n1 = true;
                }
                else
                {
                  nota2 = entrada;
                  n2 = true;
                }
              }
              else
              {
                Console.WriteLine("nota invalida");
              }
            }while(n1==false || n2==false);
            
            media = (nota1 + nota2) / 2;
            Console.WriteLine("media = {0:N}", media);
        }
    }
}
