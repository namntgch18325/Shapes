using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public static class ProgShapes
    {
        public static void Run()
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"S of Circle is {circle.CalculateArea()}");
            Console.WriteLine($"Perimeter of Circle is {circle.CaculatePerimeter()}");
            circle.Draw();

            Ractangle ractangle = new Ractangle(10, 10);

            Console.WriteLine($"S of Ractangle is {ractangle.CalculateArea()}");
            Console.WriteLine($"Perimeter of Ractangle is {ractangle.CaculatePerimeter()}");
            ractangle.Draw();

        }
    }
}
