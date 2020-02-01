using System;

namespace Csharp_LambsDas
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService mathService = new MathService();

            mathService.MathPerformed += (sender, e) => Console.WriteLine($"Calculation Result: {e.Result}");

            mathService.MultiplyNumbers(42.5, 23.9);
        }
    }
}
