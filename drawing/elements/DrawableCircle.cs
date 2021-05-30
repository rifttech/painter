using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace painter.drawing
{
    internal class DrawableCircle : DrawableFigure
    {
        
        public DrawableCircle(DrawingContext context)
            : base(FigureProvider.CreateCircle(context), context) {
        }

        public override void draw()
        {
            var g = Context.Graphics;
            var r = (Figure as core.Circle).Radius;
            var brush = new SolidBrush(Context.FigureColor);
            g.FillEllipse(brush, GetPoint().X-r/2, GetPoint().Y-r/2, r, r);
        }
    }
}
