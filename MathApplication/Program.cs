using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using MathApplication.Constant;
using Newtonsoft.Json;

namespace MathApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shapesList = FillAndAddToCollection();

            //Currently Sort the shapes based on Area & Parameter.
            var sortedShapesOnAreas = SortShapes(MathApplicationConstants.SortTypes.Areas, shapesList);
            var sortedShapesOnPerimeter = SortShapes(MathApplicationConstants.SortTypes.Perimeter, shapesList);


            var serializedValuesInXml = DataSerialize(MathApplicationConstants.SerilazeTypes.XML, sortedShapesOnAreas);

            Console.WriteLine("Serialize the value in XML \n");

            Console.WriteLine(serializedValuesInXml);


            var serializedValuesInJson = DataSerialize(MathApplicationConstants.SerilazeTypes.Json, sortedShapesOnPerimeter);

            Console.WriteLine("Serialize the value in Json \n");

            Console.WriteLine(serializedValuesInJson);


            Console.WriteLine(TrackClassObjectCount(shapesList));

            Console.ReadKey();
        }


        //Adding Static values for each shapes 
        private static List<Shape> FillAndAddToCollection()
        {
            //Triangle Object

            IShape triangle = new Triangle();

            var shapeTriangle = new Shape
            {
                Name = MathApplicationConstants.Triangle,
                Area = triangle.Area(2, 3),
                Perimeter = triangle.Perimeter(1, 2, 3)
            };

            var shapeTriangle2 = new Shape
            {
                Name = MathApplicationConstants.Triangle,
                Area = triangle.Area(3, 5),
                Perimeter = triangle.Perimeter(2, 5, 8)
            };


            //Circle Object

            IShape circle = new Circle();

            var shapeCircle = new Shape
            {
                Name = MathApplicationConstants.Circle,
                Area = circle.Area(MathApplicationConstants.Pi, 3),
                Perimeter = circle.Perimeter(MathApplicationConstants.Pi, 3)
            };

            //Square Object

            IShape square = new Square();

            var shapeSquare = new Shape
            {
                Name = MathApplicationConstants.Square,
                Area = square.Area(5, 5),
                Perimeter = square.Perimeter(5, 5)
            };


            //Rectangle Object

            IShape rectangle = new Rectangle();

            var shapeRectangle = new Shape
            {
                Name = MathApplicationConstants.Rectangle,
                Area = rectangle.Area(5, 5),
                Perimeter = rectangle.Perimeter(5, 5)
            };


            //Adding The shapes to List 
            var shapes = new List<Shape>
            {
                shapeTriangle,
                shapeCircle,
                shapeSquare,
                shapeRectangle,
                shapeTriangle2
            };

            return shapes;
        }


        /// <summary>
        ///     Private Method for SortShapes you can sort either by Area or via Perimeter
        /// </summary>
        /// <param name="sortTypes"></param>
        /// <param name="shapesList"></param>
        /// <returns></returns>
        private static List<Shape> SortShapes(MathApplicationConstants.SortTypes sortTypes, List<Shape> shapesList)
        {
            switch (sortTypes)
            {
                case MathApplicationConstants.SortTypes.Areas:
                    return shapesList.OrderByDescending(s => s.Area).ToList();
                case MathApplicationConstants.SortTypes.Perimeter:
                    return shapesList.OrderByDescending(s => s.Perimeter).ToList();
                default:
                    return shapesList;
            }
        }

        /// <summary>
        ///     Serialize Method
        /// </summary>
        /// <param name="serilazeTypes"></param>
        /// <param name="shapesList"></param>
        /// <returns></returns>
        public static string DataSerialize(MathApplicationConstants.SerilazeTypes serilazeTypes, List<Shape> shapesList)
        {
            switch (serilazeTypes)
            {
                case MathApplicationConstants.SerilazeTypes.XML:
                {
                    var sw = new StringWriter();
                    var s = new XmlSerializer(shapesList.GetType());
                    s.Serialize(sw, shapesList);
                    return sw.ToString();
                }
                case MathApplicationConstants.SerilazeTypes.Json:
                    return JsonConvert.SerializeObject(shapesList);
                default:
                    return shapesList.ToString();
            }
        }


        /// <summary>
        /// </summary>
        /// <param name="shapesList"></param>
        /// <returns></returns>
        private static string TrackClassObjectCount(List<Shape> shapesList)
        {
            //Counts of Each Shapes
            var totalCountTriangleObject = shapesList.Where(x =>
                x.Name.Equals(MathApplicationConstants.Triangle, StringComparison.CurrentCultureIgnoreCase)).Count();
            var totalCountCircleObject = shapesList.Where(x =>
                x.Name.Equals(MathApplicationConstants.Circle, StringComparison.CurrentCultureIgnoreCase)).Count();
            var totalCountSquareObject = shapesList.Where(x =>
                x.Name.Equals(MathApplicationConstants.Square, StringComparison.CurrentCultureIgnoreCase)).Count();
            var totalCountRectangleObject = shapesList.Where(x =>
                x.Name.Equals(MathApplicationConstants.Rectangle, StringComparison.CurrentCultureIgnoreCase)).Count();

            return string.Format(
                "\n\n\nThe number of Shape objects  Rectangle : {0} \n Square : {1} \n Triangle : {2}\n Circle : {3}",
                totalCountRectangleObject, totalCountSquareObject, totalCountTriangleObject, totalCountCircleObject);
        }
    }
}