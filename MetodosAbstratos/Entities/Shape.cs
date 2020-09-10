using System;
using System.Collections.Generic;
using System.Text;
using MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    abstract class Shape
    {
        public Colour Colour { get; set; }

        public Shape(Colour colour)
        {
            Colour = colour;
        }

        public abstract double Area();
    }
}