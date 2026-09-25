using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public partial class Pizzeria
    {
        private int _x;
        private int _y;

        public Pizzeria(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void Render(BufferedGraphics drawingSpace)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Gray, 25);

            // Create location and size of Rectangle.
            int width = 25;
            int height = 25;

            // Draw rectangle to screen.
            drawingSpace.Graphics.DrawRectangle(blackPen, _x -( width / 2), _y - (height / 2), width, height);
        }
    }
}
