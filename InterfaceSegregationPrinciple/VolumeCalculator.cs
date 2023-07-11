namespace InterfaceSegregationPrinciple
{
    public class VolumeCalculator : AreaCalculator
    {
        public VolumeCalculator(List<IShape> shapes) : base(shapes)
        {
        }

        public double Sum()
        {
            List<double> volumes = new List<double>();

            foreach (IShape shape in shapes)
            {
                if (shape is IShape)
                {
                    volumes.Add(shape.Area());
                }
            }

            return volumes.Sum();
        }
    }
}
