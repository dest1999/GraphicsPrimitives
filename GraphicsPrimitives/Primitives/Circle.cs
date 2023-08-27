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
        
        public Circle() : this(new Point(0, 0), 0, Color.Black, Color.Black) { }

        public Circle(Point Center, int Radius) : this(Center, Radius, Color.Black, Color.Black)
        {

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
            var pointToCenterDistance = Math.Sqrt(Math.Pow((point.X - Center.X), 2) + Math.Pow((point.Y - Center.Y), 2));
            if (Radius > pointToCenterDistance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
