using SOLID_principles.SingleResponsibilityPrinciple;

namespace SOLID_principles
{
    // A class should have one and only one reason to change, meaning
    // that a class should have only one job

    public class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(2),
                new Circle(3),
                new Square(4),
                new Square(5)
            };

            AreaCalculator areaCalculator = new AreaCalculator(shapes);

            // Removed as this violates Single Responsibility principle
            //Console.WriteLine($"{area.Output()}\n\n");

            SumCalculatorOutputter outputter = new SumCalculatorOutputter(areaCalculator);
            Console.WriteLine($"{outputter.JsonOutput()}\n\n");
            Console.WriteLine($"{outputter.TextOutput()}\n\n");
        }
    }

}
