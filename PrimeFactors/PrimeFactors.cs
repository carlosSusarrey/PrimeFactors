using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class PrimeFactors
    {
        public static List<int> Generate(int i)
        {
            var primes = new List<int>();
            for (var candidate = 2; i > 1; candidate++)
            {
                for (;i % candidate == 0; i /= candidate)
                {
                    primes.Add(candidate);
                }
            }
            return primes;
        }
    }
}
