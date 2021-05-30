using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace painter.drawing
{
    internal class DrawableRectangle : DrawableFigure
    {
        public DrawableRectangle(DrawingContext context):
            base (FigureProvider.CreateRectange(context), context){
        }

        public override void draw()
        {
            var g = Context.Graphics;
            var rect = (Figure as core.Rectangle);
            var brush = new SolidBrush(Context.FigureColor);
            g.FillRectangle(brush, 
                GetPoint().X- rect.Width/2, 
                GetPoint().Y - rect.Height/2, 
                rect.Width, 
                rect.Height
            );
        }
    }
}
