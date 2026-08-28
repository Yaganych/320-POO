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
            var drone1 = new Drone();

            while (drone1.battery > 0)
            {
                drone1.ConsoleToShow(drone1.posX, drone1.POS_Y, drone1.TIME_TO_WAIT);
                drone1.StatusChange(ref drone1.posX, ref drone1.battery);
                drone1.ToDieMessage(drone1.posX, drone1.POS_Y, drone1.battery);
            }
            Console.ReadKey();
        }

        public class Drone
        {
            public int battery { get; set; } = 50 ;
            public int posX { get; set; } = 0 ;
            public string color { get; set; } = "Red" ;
            public int POS_Y { get; set; } = 0 ;
            public int TIME_TO_WAIT { get; set; } = 100 ;


            public void ConsoleToShow(int posX, int posY, int timeToWait)
            {
                Console.SetCursorPosition(posX, posY);
                Console.ForegroundColor = ConsoleColor.color;
                Console.WriteLine("x-0-x");
                Thread.Sleep(timeToWait);
                Console.Clear();
            }

            public void StatusChange(ref int posX, ref int battery)
            {
                posX += 1;
                battery -= 2;
            }

            public void ToDieMessage(int posX, int posY, int battery)
            {
                Console.SetCursorPosition(posX, posY);
                if (battery <= 0) Console.WriteLine("____");
                Console.SetCursorPosition(posX + 4, posY);
                if (battery <= 0) Console.WriteLine("Il est mort");
            }
        }
    }
}
