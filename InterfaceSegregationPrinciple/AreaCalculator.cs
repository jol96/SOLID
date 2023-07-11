namespace InterfaceSegregationPrinciple
{
    public class AreaCalculator
    {
        protected List<IShape> shapes;

        public AreaCalculator(List<IShape> shapes) 
        {  
            this.shapes = shapes; 
        }

        public double Sum()
        {
            List<double> areas = new List<double>();

            
            foreach (IShape shape in shapes)
            {
                if (shape is IShape)
                {
                    areas.Add(shape.Area());
                }      
            }

            return areas.Sum();
        }
    }
}
