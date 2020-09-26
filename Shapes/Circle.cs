using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CaculatePerimeter()
        {
            return (Radius * 2.0) * Math.PI;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
        public override void Draw()
        {
            double rIn = Radius - 0.4;
            double rOut = Radius + 0.4;
            for (double y = Radius; y >= -Radius; --y)
            {
                for (double x = -Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
