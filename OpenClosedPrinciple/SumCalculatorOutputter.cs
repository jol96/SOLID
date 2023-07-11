using Newtonsoft.Json;

namespace OpenClosedPrinciple
{
    public class SumCalculatorOutputter
    {
        AreaCalculator calculator;

        public SumCalculatorOutputter(AreaCalculator calculator)
        {
            this.calculator = calculator;
        }

        public string JsonOutput()
        {
            var area = calculator.Sum();
            return $"Json outputter. Sum of the areas of provided shapes: {JsonConvert.SerializeObject(area)}";
        }

        public string TextOutput()
        {
            return string.Join(Environment.NewLine, new string[] {
                "",
                "Test outputter. Sum of the areas of provided shapes: " + calculator.Sum(),
                ""
            });
        }
    }
}
