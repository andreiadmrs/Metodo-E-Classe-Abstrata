using System;
using System.Collections.Generic;
using System.Text;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Colour colour) : base(colour)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI* Radius*Radius;
        }
    }
}
