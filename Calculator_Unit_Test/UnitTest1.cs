using Domain;

namespace Calculator_Unit_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_of_2_and_2_should_be_4()
        {
            var calculator  = new Calculator();
            var result = calculator.Sum(2, 2);

            if (result != 4)
            {
                throw new Exception($"The Sum(2, 2) was expected to be 4 but it's {result}.");
            }
        }
    }
}