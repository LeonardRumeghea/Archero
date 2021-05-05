using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archero
{
    public class Class_Aim
    {
        public int X, Y;

        public Class_Aim(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(Properties.Resources.Aim, X, Y, 15, 15);
        }
    }
}