using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract double CaculatePerimeter();
        public abstract double CalculateArea();

        public virtual void Draw()
        {

        }

    }
}
