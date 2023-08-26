using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPrimitives
{
    internal class Circle : AbstractFigure
    {
        public Point Center { get; set; } = new Point(0, 0);
        public int Radius { get; set; } = 0;
        
        public Circle() { }

        public Circle(Point Center, int Radius)
        {
            this.Center = Center;
            this.Radius = Radius;
        }

        public Circle(Point Center, int Radius, Color FigureColor, Color BorderColor)
        {
            this.Center = Center;
            this.Radius = Radius;
            this.FigureColor = FigureColor;
            this.BorderColor = BorderColor;
        }

        public override void Draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(FigureColor);
            graphics.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            Pen pen = new(BorderColor);
            graphics.DrawEllipse(pen, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
        }

        public override bool IsPointBelongFigure(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
