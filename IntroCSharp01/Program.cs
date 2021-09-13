using System;

namespace IntroCSharp01
{
    class Program
    {
        static void Main(string[] args)
        {
            string v = Console.ReadLine();
            char[] arr = v.ToCharArray();
            int contador = 0;
            foreach (char c in arr)
            {
              contador++;
            }
            if( contador <= 140 ) //complete a condicional
                Console.WriteLine("TWEET");
            else
                Console.WriteLine("MUTE");
        }
    }
}
