using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archero
{
    public class Class_Arrow
    {
        public int X, Y, Height = 50, Width = 20, nivel;

        public Image Image_Arrow = Properties.Resources.Arrow;

        public Class_Arrow()
        {

        }

        public Class_Arrow(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(Image_Arrow, X, Y, Width, Height);
        }
    }
}
