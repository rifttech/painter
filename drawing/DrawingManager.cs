using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace painter.drawing
{
    class DrawingManager
    {
        private DrawingManager() { }

        public static void draw(DrawingContext context) {
            switch (context.FigureType) {
                case core.FigureType.Circle:{
                        DrawFigure((ctx) => new DrawableCircle(ctx), context);
                    }
                    break;
                case core.FigureType.Rectangle: {
                        DrawFigure((ctx) => new DrawableRectangle(ctx), context);
                    }
                    break;
            }
        }


        private static void DrawFigure(Func<DrawingContext, DrawableFigure> supplier, DrawingContext context) {
            var figure = supplier(context);
            figure.draw();
            context.Printer(figure);
        }
    }
}
