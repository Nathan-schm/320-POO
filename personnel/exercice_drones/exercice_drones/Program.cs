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

            Drone drone1 = new Drone(5,5,80);
            Drone drone2 = new Drone(3, 3, 60);

            List<Drone> flotte = new List<Drone>();
            
            while (drone1._battery > 0)
            {
                foreach (Drone drone in flotte)
                {
                    Console.Clear();
                    drone.Changestate();
                    drone.Draw();
                }
                Thread.Sleep(100);

            }
            Console.Read();
        }
    }
}
