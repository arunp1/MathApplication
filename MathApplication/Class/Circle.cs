namespace MathApplication
{
    public class Circle : IShape
    {
        /// <summary>
        ///     Find Area of Circle
        /// </summary>
        /// <param name="pi"></param>
        /// <param name="radius"></param>
        /// <returns>Area</returns>
        public double Area(double pi, double radius)
        {
            return pi * (radius * radius);
        }

        /// <summary>
        ///     Find Perimeter of Circle
        /// </summary>
        /// <param name="pi"></param>
        /// <param name="radius"></param>
        /// <param name="value3"></param>
        /// This Param is not being used its for Triangle, so added a optional parameter
        /// <returns>Perimeter</returns>
        public double Perimeter(double pi, double radius, double value3 = 0)
        {
            return 2 * pi * radius;
        }
    }
}