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
                // 0 and 1 are neither prime nor composite
                if (i == 1 || i == 0)
                    continue;
                flag = 1;
                for (j = 2; j <= i/2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                // if flag = 1 then i is prime
                // else i is not prime
                if (flag == 1)
                    Console.WriteLine(i);
            }
        }
    }
}
