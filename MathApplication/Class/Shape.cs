using System;

namespace MathApplication
{
    [Serializable]
    public class Shape
    {
        public string Name { get; set; }

        public double Area { get; set; }

        public double Perimeter { get; set; }
    }
}