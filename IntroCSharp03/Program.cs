using System;

namespace IntroCSharp03
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeInSeconds = int.Parse(Console.ReadLine());

            //continue a solucao
            int hours = timeInSeconds / 3600;
            int minutes =   (timeInSeconds - (hours*3600) ) / 60;
            int seconds =   timeInSeconds - (hours*3600) - (minutes*60);

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}
