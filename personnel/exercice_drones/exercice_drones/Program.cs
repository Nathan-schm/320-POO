using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercice_drones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string drone = "X-O-X";
            string deadDrone = "-----";
            int posx = 0;
            int posy = 10;
            int batt = 50;

            Console.SetCursorPosition(posx, posy);
            Console.Write(drone);

            while (batt > 0)
            {
                Console.Clear();
                Console.SetCursorPosition(posx, posy);
                Console.Write(drone);
                posx  ++;
                batt--;
                Thread.Sleep(100);
            }

            if (batt == 0)
            {
                Console.Clear();
                Console.SetCursorPosition(posx, posy );
                Console.Write(deadDrone);
            }


            Console.Read();
        }
    }
}
