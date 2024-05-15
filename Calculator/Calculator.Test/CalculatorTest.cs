namespace Calculator.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Sum()
        {
            Assert.Equal(20, CalculationHandler.Sum(10, 10));
        }

        [Fact]
        public void Division()
        {
            Assert.Equal(1, CalculationHandler.Division(10, 10));
        }

        [Fact]
        public void Subtraction()
        {
            Assert.Equal(0, CalculationHandler.Subtraction(10, 10));
        }

        [Fact]
        public void Multiplication()
        {
            Assert.Equal(100, CalculationHandler.Multiplication(10, 10));
        }
    }
}