using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Drone
    {
        public int posX;
        public int posY;
        public int battery;

        public Drone(int posX, int posY, int battery)
        {
            this.posX = posX;
            this.posY = posY;
            this.battery = battery;
        }

        public void ConsoleToShow()
        {
            Console.SetCursorPosition(posX, posY);
            Console.Write("x-0-x");
        }

        public void StatusChange()
        {
            posX += 1;
            battery -= 2;
        }

        public void ToDieMessage()
        {
            Console.SetCursorPosition(posX, posY);

            Console.WriteLine("____");
            Console.SetCursorPosition(posX + 4, posY);
            Console.WriteLine("Il est mort");
        }
    }
}
