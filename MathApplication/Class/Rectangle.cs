namespace MathApplication
{
    public class Rectangle : IShape
    {
        /// <summary>
        ///     Find Area of Rectangle
        /// </summary>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <returns>Area</returns>
        public double Area(double width, double length)
        {
            return width * length;
        }

        /// <summary>
        ///     Find Perimeter of Rectangle
        /// </summary>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <param name="value3"></param>
        /// This Param is not being used its for Triangle, so added a optional parameter
        /// <returns>Perimeter</returns>
        public double Perimeter(double width, double length, double value3 = 0)
        {
            return (width + length) * 2;
        }
    }
}