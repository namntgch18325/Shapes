using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Ractangle : Shape
    {
        private double high;
        private double width;

        public double High
        {
            get { return high; }
            set { high = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public Ractangle(double high, double width)
        {
            this.high = high;
            this.width = width;
        }

        public override double CaculatePerimeter()
        {
            return (High+Width) * 2;
        }

        public override double CalculateArea()
        {
            return (High*Width);
        }

        public override void Draw()
        {
            DrawLine(Width, '*', '*');
            for (int i = 1; i < Width - 1; ++i)
            {
                DrawLine(Width, '*', ' ');
            }
            DrawLine(Width, '*', '*');
        }
        private void DrawLine(double width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width - 1; ++i)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }


    }
}
