namespace OpenClosedPrinciple
{
    public class Triangle : Shape
    {
        public double tBase;
        public double height;

        public Triangle(double tBase, double height)
        {
            this.tBase = tBase;
            this.height = height;
        }

        // Half the base * height
        public double Area()
        {
            return (tBase/2) * height;
        }
    }
}
