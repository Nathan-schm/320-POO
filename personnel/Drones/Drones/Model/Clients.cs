using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public partial class Clients
    {
        private int _x;
        private int _y;

        public Clients(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void Render(BufferedGraphics drawingSpace)
        {
            // Create pen.
            Pen blackPen = new Pen(Color.Green, 10);

            // Create location and size of Rectangle.
            int width = 10;
            int height = 10;

            // Draw rectangle to screen.
            drawingSpace.Graphics.DrawRectangle(blackPen, _x - (width / 2), _y - (height / 2), width, height);
        }
    }
}
