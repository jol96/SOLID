namespace LiskovSubstitutionPrinciple
{
    public class Circle: Shape
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
