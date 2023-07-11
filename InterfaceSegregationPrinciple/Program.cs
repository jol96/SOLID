namespace InterfaceSegregationPrinciple
{
    //  Interface segregation principle states:
    //  a client should never be forced to implement an interface that it doesn't use,
    //  or clients shouldn't be forced to depend on methods they do not use.

    // Lets consider if we wanted to support 3d shapes, we could implement the volume method within the Shape interface.
    //  However, 2d shapes do not have volumes, so we would be forcing the Square and Circle classes to 
    //  implement a method it has no use for.

    //  This would violate the interface segregation principle. 
    // Instead you could create another interface call ThreeDimensionalShapeInterface that has the volume contract
    // and 3d shapes can implement this interface.
    public class Program
    {
        static void Main(string[] args)
        {
            // 2-D
            List<IShape> shapes = new List<IShape>
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

            // 3-D
            List<IShape> threeDimShapes = new List<IShape>
            { 
                new Cuboid(2,2,2)
            };

            AreaCalculator areaCalculator2 = new AreaCalculator(threeDimShapes);
            SumCalculatorOutputter outputter2 = new SumCalculatorOutputter(areaCalculator2);
            Console.WriteLine($"{outputter2.JsonOutput()}\n\n");
            Console.WriteLine($"{outputter2.TextOutput()}\n\n");
        }
    }

}
