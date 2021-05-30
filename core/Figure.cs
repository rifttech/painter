using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace painter.core
{
    abstract class Figure : IArea<float>, IPerimetr<float>
    {
        private Point origin;

        public Figure(Point origin) {
            this.origin = origin;
        }

        public abstract float GetArea();

        public abstract string GetName();

        public abstract float GetPerimeter();

        public Point GetPoint() {
            return this.origin;
        }

        public void SetPoint(Point point) {
            this.origin = new Point(point.X, point.Y);
        }

    }
}
