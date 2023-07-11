namespace InterfaceSegregationPrinciple
{
    public class Circle: IShape
    {
        public int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        // PI*radius^2
        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
