using System;
using System.Collections.Generic;
using System.Text;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Colour colour) :base(colour)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
