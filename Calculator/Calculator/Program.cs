// See https://aka.ms/new-console-template for more information
using Calculator;

Console.WriteLine("Calculadora con Test Unit!");

Console.Write("Numero a: ");
decimal a = Convert.ToDecimal(Console.ReadLine());

Console.Write("Numero b: ");
decimal b = Convert.ToDecimal(Console.ReadLine());

Calculadora calc = new Calculadora(a, b);

Console.WriteLine("Suma: {0}", calc.Sumar());
Console.WriteLine("Resta: {0}", calc.Restar());
Console.WriteLine("Multiplicación: {0}", calc.Multiplicar());
Console.WriteLine("División: {0}", calc.Dividir());

Console.ReadKey();