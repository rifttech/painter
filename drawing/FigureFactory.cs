using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace painter.drawing
{
    abstract class FigureProvider { 
        private FigureProvider() { }
    
        public static core.Figure CreateCircle(DrawingContext context) {
            return new core.Circle(context.Origin, context.Width);
        }

        public static core.Figure CreateRectange(DrawingContext context){
            return new core.Rectangle(context.Origin, context.Width, context.Height);
        }
    }
}
