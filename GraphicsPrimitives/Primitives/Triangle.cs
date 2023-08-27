using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsPrimitives
{
    internal class Triangle : AbstractFigure
    {
        public Point TopVertex { get; set; }
        public int Heigth { get; set; }
        public int Angle { get; private set; } = 60; //угол равностороннего треугольника всегда 60
        private Point[] vertexCoords;

        public Triangle() : this(new Point(0, 0), 0, Color.Black, Color.Black)
        {
            
        }
        public Triangle(Point TopVertex, int Height) : this(TopVertex, Height, Color.Black, Color.Black)
        {

        }

        public Triangle(Point TopVertex, int Height, Color FigureColor, Color BorderColor)
        {
            int halfLength = (int)(Height / Math.Sqrt(3));
            this.TopVertex = TopVertex;
            this.Heigth = Height;
            vertexCoords = new[]
            {
                TopVertex,
                new Point(TopVertex.X - halfLength, TopVertex.Y + Height),
                new Point(TopVertex.X + halfLength, TopVertex.Y + Height)
            };
            this.FigureColor = FigureColor;
            this.BorderColor = BorderColor;
        }

        public override void Draw(Graphics graphics)
        {
            Brush brush = new SolidBrush(FigureColor);
            graphics.FillPolygon(brush, vertexCoords);

            Pen pen = new(BorderColor);
            graphics.DrawPolygon(pen, vertexCoords);
        }

        public override bool IsPointBelongFigure(Point point)
        {
            if (point.Y >= TopVertex.Y && point.Y <= (TopVertex.Y + Heigth) &&
                    Math.Abs(TopVertex.X - point.X) <= (int)((point.Y - TopVertex.Y) / Math.Sqrt(3)))
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
