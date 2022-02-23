using System;

namespace MathApplication
{
    [Serializable]
    public class Shape
    {
        public string ShapeName { get; set; }

        public double ShapeArea { get; set; }

        public double ShapePerimeter { get; set; }
    }
}