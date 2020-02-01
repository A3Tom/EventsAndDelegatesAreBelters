using System;

namespace Csharp_LambsDas
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService mathService = new MathService();

            mathService.MathPerformed += (result) => Console.WriteLine($"Calculation Result: {result}");

            mathService.CalculateNumbers(42.5, 23.9, (double value1, double value2) => value1 * value2);
        }
    }
}
