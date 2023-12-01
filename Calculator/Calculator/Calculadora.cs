namespace Calculator
{
    public class Calculadora
    {
        private decimal _a;
        private decimal _b;

        public decimal Resultado;
        public Calculadora(decimal a, decimal b)
        {
            _a = a;
            _b = b;
        }

        public decimal Sumar() => Resultado = _a + _b;
        public decimal Restar() => Resultado = _a - _b;
        public decimal Dividir() => Resultado = _a / _b;
        public decimal Multiplicar() => Resultado = _a * _b;
    }
}
