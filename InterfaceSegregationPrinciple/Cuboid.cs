namespace InterfaceSegregationPrinciple
{
    public class Cuboid : IShape, IThreeDimensionalShapes
    {
        public double length;
        public double width;
        public double height;

        public Cuboid(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            return 2*(length + width + height);
            
        }

        public double Volume()
        {
            return length * width * height;
        }
    }
}
