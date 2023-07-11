namespace OpenClosedPrinciple
{
    //  Open closed princple states:
    //  Objects or entities should be open for extension but closed for modification.
    //
    //  This means that a class should be extendable without modifying the class itself.

    //  Consider a sceanrio were the user would like the sum of additional shapes like triangle, pentagons, hexagons etc.
    //  You would constantly have to edit the AreaCalculator class. That would violate the open closed principle.

    //  A better approach would be to move the calculation of the are of each shape  out of the AreaCalculator class
    //  and into each shape class.

    public class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(2),
                new Circle(3),
                new Square(4),
                new Square(5),
                new Triangle(2,2)
            };

            AreaCalculator areaCalculator = new AreaCalculator(shapes);
            SumCalculatorOutputter outputter = new SumCalculatorOutputter(areaCalculator);
            Console.WriteLine($"{outputter.JsonOutput()}\n\n");
            Console.WriteLine($"{outputter.TextOutput()}\n\n");
        }
    }

}
