namespace LiskovSubstitutionPrinciple
{
    public class VolumeCalculator : AreaCalculator
    {
        public VolumeCalculator(List<Shape> shapes) : base(shapes)
        {
        }

        public double Sum()
        {
            List<double> volumes = new List<double>();

            foreach (Shape shape in shapes)
            {
                if (shape is Shape)
                {
                    volumes.Add(shape.Area());
                }
            }

            return volumes.Sum();
        }
    }
}
