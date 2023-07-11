namespace OpenClosedPrinciple
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
                if (shape is Shape)
                {
                    areas.Add(shape.Area());
                }      
            }

            return areas.Sum();
        }
    }
}
