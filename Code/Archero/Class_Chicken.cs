using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archero
{
    public class Class_Chicken
    {
        public int X, Y, Width = 50, Height = 50, location, time;
        public Image image_Chicken;

        public bool Baby;

        public Class_Chicken(int X, int Y, Image image)
        {
            this.X = X;
            this.Y = Y;
            this.image_Chicken = image;

            Baby = false;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(image_Chicken, X, Y, Width, Height);
        }
    }
}
