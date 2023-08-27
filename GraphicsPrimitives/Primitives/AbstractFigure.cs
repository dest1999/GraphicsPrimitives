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

        protected Point centerPoint;

        public abstract void Draw(Graphics graphics);
        public abstract bool IsPointBelongFigure(Point point);
        
        public void LinkTo(AbstractFigure TargetFigure, Graphics graphics)
        {
            graphics.DrawLine(new Pen(FigureColor), centerPoint, TargetFigure.centerPoint);
        }

        protected abstract void SetCenterPoint();
    }
}
