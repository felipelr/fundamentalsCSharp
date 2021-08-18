using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start(6);
        }

        static void Start(int time = 3)
        {
            int currentTime = 0;
            while (currentTime < time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado.");
            Thread.Sleep(2500);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 10 minutos");
            Console.WriteLine("0 = Sair");

            Console.WriteLine("Quanto tempo deseja contar?");
            string data = Console.ReadLine().ToLower();
            int time = int.Parse(data.Substring(0, data.Length - 1));

            if (time == 0)
                System.Environment.Exit(0);

            char type = char.Parse(data.Substring(data.Length - 1, 1));

            int multiplier = 1;
            if (type == 'm')
                multiplier = 60;

            Start(time * multiplier);
        }
    }
}
