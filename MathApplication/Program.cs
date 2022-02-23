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
            try
            {
                var shapesList = FillAndAddToCollection();

                // Sort the shapes based on Area & Parameter.
                var sortedShapesOnAreas = SortShapes(MathApplicationConstants.SortTypes.Areas, shapesList);
                var sortedShapesOnPerimeter = SortShapes(MathApplicationConstants.SortTypes.Perimeter, shapesList);


                var serializedValuesInXml =
                    DataSerialize(MathApplicationConstants.SerilazeTypes.XML, sortedShapesOnAreas);

                Console.WriteLine("Serialize the value in XML \n");

                Console.WriteLine(serializedValuesInXml);


                var serializedValuesInJson =
                    DataSerialize(MathApplicationConstants.SerilazeTypes.Json, sortedShapesOnPerimeter);

                Console.WriteLine("Serialize the value in Json \n");

                Console.WriteLine(serializedValuesInJson);


                Console.WriteLine(TrackClassObjectCount(shapesList));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.ReadKey();
            }
        }


        //Adding Static values for each shapes 
        private static List<Shape> FillAndAddToCollection()
        {
            //Triangle Object

            var triangle = new Triangle();

            var shapeTriangle = new Shape
            {
                ShapeName = triangle.TriangleTypeName(5, 5, 5),
                ShapeArea = triangle.Area(2, 3),
                ShapePerimeter = triangle.Perimeter(5, 5, 5)
            };

            var shapeTriangle2 = new Shape
            {
                ShapeName = triangle.TriangleTypeName(2, 5, 8),
                ShapeArea = triangle.Area(3, 5),
                ShapePerimeter = triangle.Perimeter(2, 5, 8)
            };


            //Circle Object

            var circle = new Circle();

            var shapeCircle = new Shape
            {
                ShapeName = MathApplicationConstants.Circle,
                ShapeArea = circle.Area(MathApplicationConstants.Pi, 3),
                ShapePerimeter = circle.Perimeter(MathApplicationConstants.Pi, 3)
            };

            //Square Object

            var square = new Quadrilaterals();

            var shapeSquare = new Shape
            {
                ShapeName = square.QuadrilateralsTypeName(5, 5),
                ShapeArea = square.Area(5, 5),
                ShapePerimeter = square.Perimeter(5, 5)
            };


            //Rectangle Object

            var rectangle = new Quadrilaterals();

            var shapeRectangle = new Shape
            {
                ShapeName = square.QuadrilateralsTypeName(5, 10),
                ShapeArea = rectangle.Area(5, 10),
                ShapePerimeter = rectangle.Perimeter(5, 10)
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
                    return shapesList.OrderByDescending(s => s.ShapeArea).ToList();
                case MathApplicationConstants.SortTypes.Perimeter:
                    return shapesList.OrderByDescending(s => s.ShapePerimeter).ToList();
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
        private static string DataSerialize(MathApplicationConstants.SerilazeTypes serilazeTypes,
            List<Shape> shapesList)
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
            var totalCountTriangleObject = shapesList.Count(x => x.ShapeName.Contains("Triangle"));
            var totalCountCircleObject = shapesList.Count(x =>
                x.ShapeName.Equals(MathApplicationConstants.Circle, StringComparison.CurrentCultureIgnoreCase));
            var totalCountSquareObject = shapesList.Count(x =>
                x.ShapeName.Equals(MathApplicationConstants.Square, StringComparison.CurrentCultureIgnoreCase));
            var totalCountRectangleObject = shapesList.Count(x =>
                x.ShapeName.Equals(MathApplicationConstants.Rectangle, StringComparison.CurrentCultureIgnoreCase));

            return
                $"\n\n\nThe number of Shape objects  Rectangle : {totalCountRectangleObject} \n Square : {totalCountSquareObject} \n Triangle : {totalCountTriangleObject}\n Circle : {totalCountCircleObject}";
        }
    }
}