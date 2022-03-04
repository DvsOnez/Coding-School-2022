using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class PrimeCalculator
    {
        public int UpperBound;

        public PrimeCalculator(int upperBound)
        {
            UpperBound = upperBound;
        }

        private bool IsPrime(int x)
        {
            if (x == 0 || x == 1)
                return false;

            var upperCheckLimit = (int)Math.Sqrt(x);
            for (int i = 2; i <= upperCheckLimit; i++)
            {
                if (x % i == 0)
                    return false;
            }

            return true;
        }

        public void DisplayPrimes()
        {
            Console.Write($"The primes between 0 and {UpperBound} are ");
            for (int i = 0; i < UpperBound; i++)
            {
                if (IsPrime(i))
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}