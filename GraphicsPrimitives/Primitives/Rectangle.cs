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
        public int Width { get; set; }
        public int Height { get; set; }
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        private Point[] vertexCoords;

        public Rectangle() : this(new Point(0,0), 0, 0, Color.Black, Color.Black) { }

        public Rectangle(Point TopLeft, int Width, int Height) : this(TopLeft, Width, Height, Color.Black, Color.Black) { }

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
            SetCenterPoint();
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

        protected override void SetCenterPoint()
        {
            centerPoint = new Point(TopLeft.X + Width / 2, TopLeft.Y + Height / 2);
        }
    }
}
