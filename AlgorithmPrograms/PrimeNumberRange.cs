using System;
using System.Collections.Generic;
using System.Text;
namespace AlgorithmPrograms
{
   public class PrimeNumberRange
   {
        List<int> primeList = new List<int>();
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
                   PrimePalindrome(i);
            }
        }
        public void PrimePalindrome(int num)
        {
            Palindrome palindrome = new Palindrome();
            if (palindrome.IsPalindrome(num) == 1)
            {
               primeList.Add(num);
            }
            
        }
        //Printing Prime Palindrome
        public void PrintPalindrome()
        {
            foreach (int i in primeList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
