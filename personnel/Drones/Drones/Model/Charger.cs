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
    internal class Charger
    {
        private int _x;
        private int _y;

        public Charger(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void Render(BufferedGraphics drawingSpace)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create location and size of ellipse.
            _x = 0;
            _y = 0;
            int width = 20;
            int height = 20;

            // Draw ellipse to screen.
            drawingSpace.Graphics.DrawEllipse(blackPen, _x, _y, width, height);
        }
    }
}
