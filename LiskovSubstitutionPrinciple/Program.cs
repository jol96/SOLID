namespace LiskovSubstitutionPrinciple
{
    //  Liskov substitution principle states:
    //  That every subclass or dervived class should be substitutable for their base or parent class.
    //
    //  Building off the example AreaCalculator class, consider a new volumeCalculator class taht
    //  extends the AreaCalculator class.
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
