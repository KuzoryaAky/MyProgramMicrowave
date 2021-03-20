using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    class Microwave : IMenu
    {
        public void Cook(Food food)
        {
            Console.WriteLine($"{food} is done");
        }

        public void Start(HotMode hotMode)
        {
            Console.WriteLine("Cook Food");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Microwave");
        }

        public int TimeCook(int time)
        {
            for (int i = 0; i < time; time--)
            {
                for (int y = 0; y < time; y++)
                {
                    Console.WriteLine("Tic Tac");
                    System.Threading.Thread.Sleep(100);
                    if (time == i)
                    {
                        Console.WriteLine("Din Don");
                    }
                }
            }
            return time;
        }
    }
}
