using System;
using MathApplication.Constant;

namespace MathApplication
{
    public class Quadrilaterals : Shape, ICommonShape
    {
        /// <summary>
        ///     Find Area of Square
        /// </summary>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <returns>Perimeter</returns>
        public double Area(double width, double length)
        {
            try
            {
                return width * length;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        ///     Find Perimeter of Square
        /// </summary>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <returns>Perimeter</returns>
        public double Perimeter(double width, double length)
        {
            try
            {
                return (width + length) * 2;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string QuadrilateralsTypeName(double width, double length)
        {
            try
            {
                return width == length ? MathApplicationConstants.Square : MathApplicationConstants.Rectangle;
            }
            catch (Exception e)
            {
                throw e;
            }
            //  equilateral triangle
        }
    }
}