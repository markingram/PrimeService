using System;

namespace Prime.Services
{
    public class PrimeService
    {
        private const int LowestPrimeNumber = 2;

        public bool IsPrime(int candidate)
        {
            if (candidate < LowestPrimeNumber)
            {
                return false;
            }
            throw new NotImplementedException("Please create a test first");
        }
    }
}