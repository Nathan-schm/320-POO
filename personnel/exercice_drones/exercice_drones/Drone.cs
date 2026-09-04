using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace exercice_drones
{
    public class Drone
    {
        private int _posx;
        private int _posy;
        public int _battery;

        public Drone(int posx, int posy, int battery)
        {
            _posx = posx;
            _posy = posy;
            _battery = battery;
        }

        public void Draw()
        {
            Console.SetCursorPosition(_posx, _posy);

            if (_battery > 0)
            {
                Console.Write("X-O-X");
            }
            else
            {
                Console.Write("_____");
            }

            Console.SetCursorPosition(_posx, _posy -1);
            
            if (_battery > 0)
            {
                Console.Write(_battery);
            }
            else
            {
                Console.Write("0");
            }

        }

        public void Changestate()
        {
            if (_battery <= 0) return;
            _posx++;
            _battery--;
        }
    }
}
