using System;
using System.Timers;

namespace Csharp_LambsDas
{
    class MathService
    {
        public Action<double> MathPerformed;

        public void CalculateNumbers(double value1, double value2, Func<double, double, double> calculation)
        {
            Timer timer = new Timer(5000);

            MathPerformed(calculation(value1, value2));
        }

    }
}
