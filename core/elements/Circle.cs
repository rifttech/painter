using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace painter.core
{
    class Circle: Figure
    {
        private static int index = 0;

        public float Radius { get; set; }
        public Circle(Point origin, int radius) : base(origin) {
            this.Radius = radius;
            index++;
        }

        public override float GetArea()
        {
            return Radius * Radius * (float)Math.PI;
        }

        public override string GetName()
        {
            return "CIRCLE_" + index;
        }

        public override float GetPerimeter()
        {
            return 2 * (float)Math.PI * Radius;
        }
    }
}
