using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archero
{
    public class Class_Bow
    {
        public int X, Y, Height = 75, Width = 200;

        public Image image_Bow;

        public Class_Bow(Image image_Bow, int X, int Y)
        {
            this.image_Bow = image_Bow;
            this.X = X;
            this.Y = Y;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(image_Bow, X, Y, Width, Height);
        }
    }
}
