using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace painter.core
{
    class FigurePrinter
    {
        private readonly Figure figure;
        public FigurePrinter(Figure figure) {
            this.figure = figure;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Figure: {figure.GetName()}");
            builder.AppendLine($"Origin: {figure.GetPoint()}");
            builder.AppendLine($"Area: {figure.GetArea()}");
            builder.AppendLine($"Perimetr: {figure.GetPerimeter()}");
            return builder.ToString();
        }
    }
}
