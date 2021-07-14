using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Permutation
    {
        public static void Permute(String str,
                                int start, int end)
        {
            if (start == end)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = Swap(str, start, i);
                    Permute(str, start+ 1, end);
                    str = Swap(str, start, i);
                }
            }
        }
        public static String Swap(String str,
                                  int i, int j)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        
    }
}
