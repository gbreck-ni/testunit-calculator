using Calculator;

namespace TestProjectCalculator
{
    public class UnitTestCalculator
    {
        [Fact]
        public void TestSuma2and3()
        {
            // arrange
            decimal a = 2;
            decimal b = 3;
            decimal expectedResult = 5;
            Calculadora calculadora = new Calculadora(a, b);
            // act
            decimal actualResult = calculadora.Sumar();

            // assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}