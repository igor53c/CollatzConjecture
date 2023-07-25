using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzChallengeImplementation
{
    public static class CollatzConjecture
    {
        public static int CountStepsToOne(int number)
        {
            if (number <= 0)
                throw new ArgumentOutOfRangeException("Number must be a positive integer greater than 0.");

            int steps = 0;
            while (number != 1)
            {
                if (number % 2 == 0)
                {
                    number /= 2;
                }
                else
                {
                    number = number * 3 + 1;
                }
                steps++;
            }
            return steps;
        }
    }
}
