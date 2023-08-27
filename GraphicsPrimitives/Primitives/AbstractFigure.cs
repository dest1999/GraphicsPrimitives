using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPrimitives
{
    internal abstract class AbstractFigure
    {
        public Color FigureColor { get; set; }
        public Color BorderColor { get; set; }

        public abstract void Draw(Graphics graphics);
        public abstract bool IsPointBelongFigure(Point point);
    }
}
