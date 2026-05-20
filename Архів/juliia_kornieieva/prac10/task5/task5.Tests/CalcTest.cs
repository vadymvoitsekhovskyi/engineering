namespace task5
{
    public class CalcTest
    {
        private readonly ICalculator _calculator;

        public CalcTest()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoNumbers()
        {
            var result = _calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void SubtractTwoNumbers()
        {
            var result = _calculator.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void MultiplyTwoNumbers()
        {
            var result = _calculator.Multiply(4, 3);
            Assert.Equal(12, result);
        }

        [Fact]
        public void DivideTwoNumbers()
        {
            var result = _calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void DivideByZero()
        {
            Assert.Throws<DivideByZeroException>(() => 
                _calculator.Divide(10, 0)
            );
        }
    }
}