namespace InterfaceSegregationPrinciple
{
    public class Square: IShape
    {
        public int length;

        public Square(int length)
        {
            this.length = length;
        }

        // length^2
        public double Area()
        {
            return Math.Pow(length, 2);
        }
    }
}
