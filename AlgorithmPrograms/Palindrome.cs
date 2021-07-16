using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Palindrome
    {
        public int IsPalindrome(int num)
        {
            int rem = 0;
            int temp = num;
            int sum = 0;
            while (temp != 0)
            {
                rem = num % 10;
                //multiply the sum with 10 and then add the remainder
                sum = (sum * 10) + rem;
                //Get the quotient by dividing the number with 10 
                num = num / 10;
            }
            if (sum == num)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
