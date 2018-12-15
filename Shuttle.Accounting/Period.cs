using System;

namespace Shuttle.Accounting
{
    public class Period
    {
        public Period(int value)
        {
            if (value < 1)
            {
                throw new ArgumentException("Argument 'value' may not be less than 1.");
            }

            var split = value / 100m;
            Year = (int) split;
            Month = (int) (split % 1.0m * 100);
        }

        public int Year { get; }
        public int Month { get; }
    }
}