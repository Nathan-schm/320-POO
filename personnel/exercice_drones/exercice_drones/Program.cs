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
            Console.Clear();
            Console.CursorVisible = false;

            Drone drone1 = new Drone(2, 5, 50);
            Drone drone2 = new Drone(2, 10, 80);

            while (drone1._battery > 0 || drone2._battery > 0)
            {
                Console.Clear();
                drone1.Changestate();
                drone1.Draw();

                drone2.Changestate();
                drone2.Draw();

                Thread.Sleep(100);
            }
            Console.Read();
        }
    }
}
