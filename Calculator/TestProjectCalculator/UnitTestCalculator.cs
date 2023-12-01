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
        [Fact]
        public void TestResta5and3()
        {
            // arrange
            decimal a = 5;
            decimal b = 3;
            decimal expectedResult = 2;
            Calculadora calculadora = new Calculadora(a, b);
            // act
            decimal actualResult = calculadora.Restar();

            // assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void TestDivide10and2()
        {
            // arrange
            decimal a = 10;
            decimal b = 2;
            decimal expectedResult = 5;
            Calculadora calculadora = new Calculadora(a, b);
            // act
            decimal actualResult = calculadora.Dividir();

            // assert
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void TestMultiplica10and2()
        {
            // arrange
            decimal a = 10;
            decimal b = 2;
            decimal expectedResult = 20;
            Calculadora calculadora = new Calculadora(a, b);
            // act
            decimal actualResult = calculadora.Multiplicar();

            // assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}