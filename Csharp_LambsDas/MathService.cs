using System;
using System.Timers;

namespace Csharp_LambsDas
{
    class MathService
    {
        //public event EventHandler<MathPerformedEventArgs> MathPerformed;

        public delegate void MathPerformedHandler(double result);

        public event MathPerformedHandler MathPerformed;

        public void MultiplyNumbers(double value1, double value2)
        {
            Timer timer = new Timer(5000);

            MathPerformed(value1 * value2);
        }

    }
}
