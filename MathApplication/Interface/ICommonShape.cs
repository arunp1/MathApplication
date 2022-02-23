namespace MathApplication
{
    internal interface ICommonShape
    {
        double Area(double value1, double value2);

        //Added a Optional Parameter for 
        double Perimeter(double value1, double value2);
    }
}