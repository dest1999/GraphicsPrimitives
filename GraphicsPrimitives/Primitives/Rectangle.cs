using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPrimitives
{
    internal class Rectangle : AbstractFigure
    {
        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;
        public Point TopLeft { get; set; } = new Point(0, 0);
        public Point BottomRight { get; set; } = new Point(0, 0);

        private Point[] vertexCoords;

        public Rectangle() { }

        public Rectangle(Point TopLeft, int Width, int Height)
        {
            this.TopLeft = TopLeft;
            this.Height = Height;
            this.Width = Width;
            BottomRight = new Point(Width + TopLeft.X, Height + TopLeft.Y);
            vertexCoords = new[]
            {
                TopLeft,
                new Point(TopLeft.X + Width, TopLeft.Y),
                BottomRight,
                new Point(TopLeft.X, Height + TopLeft.Y),
            };
        }

        public Rectangle(Point TopLeft, int Width, int Height, Color FigureColor, Color BorderColor)
        {
            this.TopLeft = TopLeft;
            this.Height = Height;
            this.Width = Width;
            BottomRight = new Point(Width + TopLeft.X, Height + TopLeft.Y);
            vertexCoords = new[]
            {
                TopLeft,
                new Point(TopLeft.X + Width, TopLeft.Y),
                BottomRight,
                new Point(TopLeft.X, Height + TopLeft.Y),
            };
            this.FigureColor = FigureColor;
            this.BorderColor = BorderColor;
        }

        public override bool IsPointBelongFigure(Point point)
        {
            if ((point.X >= TopLeft.X && point.X <= BottomRight.X) && (point.Y >= TopLeft.Y && point.Y <= BottomRight.Y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(FigureColor);
            graphics.FillPolygon(brush, vertexCoords);

            Pen pen = new(BorderColor);
            graphics.DrawPolygon(pen, vertexCoords);

        }
    }
}
