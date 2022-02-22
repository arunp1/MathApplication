namespace MathApplication
{
    public class Triangle : IShape
    {
        /// <summary>
        ///     Find Area of Triangle
        /// </summary>
        /// <param name="height"></param>
        /// <param name="baseTriangle"></param>
        /// <returns>Area</returns>
        public double Area(double height, double baseTriangle)
        {
            return height / baseTriangle / 2;
        }


        /// <summary>
        ///     Find Perimeter of Triangle
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <returns>Perimeter</returns>
        public double Perimeter(double height, double width, double length)
        {
            return height + width * length;
        }
    }
}