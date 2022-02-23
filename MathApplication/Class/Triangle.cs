using System;
using MathApplication.Constant;
using MathApplication.Interface;

namespace MathApplication
{
    public class Triangle : Shape, ITriangleShape
    {
        /// <summary>
        ///     Find Area of Triangle
        /// </summary>
        /// <param name="height"></param>
        /// <param name="baseTriangle"></param>
        /// <returns>Area</returns>
        public double Area(double height, double baseTriangle)
        {
            try
            {
                return height / baseTriangle / 2;
            }
            catch (Exception e)
            {
                throw e;
            }
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
            try
            {
                return height + width * length;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public string TriangleTypeName(double height, double width, double length)
        {
            try
            {
                //  equilateral triangle
                if (height == width && width == length)
                    return MathApplicationConstants.EquilateralTriangle;

                // isosceles triangle
                if (height == width || width == length || length == height)
                    return MathApplicationConstants.IsoscelesTriangle;

                //  scalene triangle
                return MathApplicationConstants.ScaleneTriangle;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}