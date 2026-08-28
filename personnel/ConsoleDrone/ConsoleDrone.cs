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
            int POS_Y = 0;
            int TIME_TO_WAIT = 300;

            while (battery > 0)
            {
                ConsoleToShow(posX, POS_Y, TIME_TO_WAIT);
                StatusChange(ref posX, ref battery);
            }

            Console.WriteLine("Il est mort");
            Console.ReadKey();
        }

        static void StatusChange (ref int posX, ref int battery)
        {
            posX += 2;
            battery -= 2;
        }

        static void ConsoleToShow(int posX, int posY, int timeToWait)
        {
            Console.SetCursorPosition(posX, posY);
            Console.WriteLine("x-0-x");
            Thread.Sleep(timeToWait);
            Console.Clear();
        }
    }
}
