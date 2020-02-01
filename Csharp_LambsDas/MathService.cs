﻿using System;
using System.Timers;

namespace Csharp_LambsDas
{
    class MathService
    {
        public event EventHandler<MathPerformedEventArgs> MathPerformed;

        public void MultiplyNumbers(double value1, double value2)
        {
            Timer timer = new Timer(5000);

            MathPerformed(this, new MathPerformedEventArgs { Result = value1 * value2 });
        }

    }
}
