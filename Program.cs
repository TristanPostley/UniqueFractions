using System;
using System.Collections.Generic;

namespace UniqueFractions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            double total = 0;
            List<double> temp = new List<double>();

            for(double d = 1; d < 10; d++)
            {
                for(double n = 1; n < 9; n++)
                {
                    double fraction = n/d;
                    if(fraction >= 1)
                    {
                        break;
                    }
                    if(temp.Contains(fraction))
                    {
                        continue;
                    }
                    else
                    {
                        temp.Add(fraction);
                        total += fraction;
                    }
                }
            }

            Console.WriteLine($"Total of all unique fractions less than 1 whose numerator and denominator are single digit: {total}");
        }
    }
}
