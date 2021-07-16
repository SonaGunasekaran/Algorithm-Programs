using System;
using System.Collections.Generic;
using System.Text;
namespace AlgorithmPrograms
{
    class PrimeNumberRange
    {
        public void IsPrime(int a, int b)
        {
            int i, j, flag;
            for (i = a; i <= b; i++)
            {

                // Skip 0 and 1 as they are
                // neither prime nor composite
                if (i == 1 || i == 0)
                    continue;

                // flag variable to tell
                // if i is prime or not
                flag = 1;

                for (j = 2; j <= i/2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                // flag = 1 means i is prime
                // and flag = 0 means i is not prime
                if (flag == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
