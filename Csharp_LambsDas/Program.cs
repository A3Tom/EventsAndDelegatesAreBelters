using System;

namespace Csharp_LambsDas
{
    class Program
    {
        static void Main(string[] args)
        {
            MathService mathService = new MathService();

            mathService.MathPerformed += OnMathPerformed;

            mathService.MultiplyNumbers(42.5, 23.9);
        }

        private static void OnMathPerformed(object sender, MathPerformedEventArgs e)
        {
            Console.WriteLine($"Calculation Result: {e.Result}");
        }
    }
}
