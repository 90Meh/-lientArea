using GeometryLibrary;
internal class Program
{
    private static void Main(string[] args)
    {
        Double radius = 5;
        double circleArea = GeometryCalculator.CalculateCircleArea(radius);
        Console.WriteLine($"Площадь круга с радиусом {radius} равна {circleArea}");

        double sideA = 3;
        double sideB = 4;
        double sideC = 5;
        double triangleArea = GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC);
        Console.WriteLine($"Площадь треугольника со сторонами {sideA}, {sideB}, {sideC} равна {triangleArea}");
    } 
}