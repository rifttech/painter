using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace painter.drawing
{
    class DrawingContext
    {
        public Point Origin { get; set; }
        public core.FigureType FigureType { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Graphics Graphics { get; set; }
        public Color FigureColor { get; set; }

        public Action<core.Figure> Printer { get; set; }
    }
}
