using Domain;

namespace Calculator_Unit_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calculator = new Calculator();

            if (calculator.Sum(2, 2) != 4)
            {
                throw new Exception();
            }
        }

       
    }
}