using System;

namespace MathApplication
{
    public class Circle : Shape, ICommonShape
    {
        /// <summary>
        ///     Find Area of Circle
        /// </summary>
        /// <param name="pi"></param>
        /// <param name="radius"></param>
        /// <returns>Area</returns>
        public double Area(double pi, double radius)
        {
            try
            {
                return pi * (radius * radius);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        ///     Find Perimeter of Circle
        /// </summary>
        /// <param name="pi"></param>
        /// <param name="radius"></param>
        /// <returns>Perimeter</returns>
        public double Perimeter(double pi, double radius)
        {
            try
            {
                return 2 * pi * radius;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}