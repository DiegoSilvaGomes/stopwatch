using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor do tempo que deseja cronometrar");
            Console.WriteLine("S = Segundos => 1s = 1 segundo");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length -1));

            if(type == 's')
                PreStart(time);
            if(type == 'm')
                PreStart(time * 60);
            if(time == 0)
            {
                System.Environment.Exit(0);
            }
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            for( ; currentTime <= time; currentTime++)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Menu();
        }
    }
}
