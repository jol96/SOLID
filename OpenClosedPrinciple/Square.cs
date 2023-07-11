namespace OpenClosedPrinciple
{
    public class Square: Shape
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
