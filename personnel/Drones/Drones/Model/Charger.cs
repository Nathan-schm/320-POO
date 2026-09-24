using Drones.Helpers;
using Drones.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public partial class Charger
    {
        private int _x;
        private int _y;

        public Charger(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int GetX()
        {
            return _x;
        }
        public int GetY()
        {
            return _y;
        }

        public void Render(BufferedGraphics drawingSpace)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create location and size of ellipse.
            int width = 100;
            int height = 100;

            // Draw ellipse to screen.
            drawingSpace.Graphics.DrawEllipse(blackPen, _x -50, _y -50, width, height);
        }
    }
}
