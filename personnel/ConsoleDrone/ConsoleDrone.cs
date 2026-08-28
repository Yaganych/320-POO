using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int battery = 50;
            int posX = 0;
            const int POS_Y = 0;
            const int TIME_TO_WAIT = 300;

            Console.Clear();
            Console.WriteLine("x-0-x");
            Thread.Sleep(TIME_TO_WAIT);

            while (battery > 0)
            {
                posX+= 2;
                battery-=2;
                Console.Clear();
                Console.SetCursorPosition(posX, POS_Y);
                Console.WriteLine("x-0-x");
                Thread.Sleep(TIME_TO_WAIT);
            }

            Console.WriteLine("Il est mort");
            Console.ReadKey();
        }
    }
}
