using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace painter.drawing
{
    internal abstract class DrawableFigure : core.Figure, core.IDraw
    {
        protected core.Figure Figure { get; private set; }
        protected DrawingContext Context { get; private set; }

        public DrawableFigure(core.Figure figure, DrawingContext context) : base(figure.GetPoint()) {
            this.Figure = figure;
            this.Context = context;
        }

        public abstract void draw();

        public override float GetArea()
        {
            return Figure.GetArea();
        }

        public override string GetName()
        {
            return Figure.GetName();
        }

        public override float GetPerimeter()
        {
            return Figure.GetPerimeter();
        }

        
    }
}
