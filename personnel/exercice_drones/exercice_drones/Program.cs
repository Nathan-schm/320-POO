using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercice_drones
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string deadDrone = "-----";
            int batt = 50;
            int posx = 0;
            int posy = 10;

            while (batt > 0)
            {
                Console.Clear();
                Drone(posx, posy);
                posx  ++;
                batt--;
                Thread.Sleep(100);
            }

            if (batt == 0)
            {
                Console.Clear();
                Console.SetCursorPosition(posx, posy);
                Console.Write(deadDrone);
            }

            Console.Read();
        }
        
        static void Drone(int posx,int posy)
        {
            string drone = "X-O-X";
            Console.SetCursorPosition(posx, posy);
            Console.Write(drone);
        }
        
    }
}
