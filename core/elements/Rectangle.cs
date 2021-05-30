using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace painter.core
{
    class Rectangle : Figure
    {
        private static int index = 0;

        public float Width { get; set; }
        public float Height { get; set; }
        public Rectangle(Point point, float width, float height) 
            : base(point) {
            this.Width = width;
            this.Height = height;
            index++;
        }

        public override float GetArea()
        {
            return Width * Height;
        }

        public override string GetName()
        {
            return "RECT_" + index; 
        }

        public override float GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
