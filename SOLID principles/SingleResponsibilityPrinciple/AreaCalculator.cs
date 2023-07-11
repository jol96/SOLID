namespace SOLID_principles.SingleResponsibilityPrinciple
{
    public class AreaCalculator
    {
        private List<Shape> shapes;

        public AreaCalculator(List<Shape> shapes) 
        {  
            this.shapes = shapes; 
        }

        public double Sum()
        {
            List<double> areas = new List<double>();

            foreach (Shape shape in shapes)
            {
                if (shape is Square)
                {
                    Square square = (Square)shape;
                    areas.Add(Math.Pow(square.length, 2));
                }
                else if (shape is Circle)
                {
                    Circle circle = (Circle)shape;
                    areas.Add(Math.PI * Math.Pow(circle.radius, 2));
                }
            }

            return areas.Sum();
        }

        //  The problem with the output method is ThreadStaticAttribute it handles the logic
        //  to output the data.

        //  Consider a scenario where the output should be converted to another format like JSON.

        //  All of the logic would be handle by the AreaCalculator class. This would voilate
        //  the Single-Responsibility principle.

        //  The AreaCalculator class should only be responsible for calculating the area.

        //  To address this, you can create a seperate SumCalculatorOutputter class that handles
        //  the logic to output to the user.

        //public string Output()
        //{
        //    return string.Join(Environment.NewLine, new string[] {
        //    "",
        //    "Sum of the areas of provided shapes: " + Sum(),
        //    ""
        //    });
        //}
    }
}
