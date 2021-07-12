using System;

namespace AlgorithmPrograms
{
    class Program
    {
            public static void Main()
            {
                String str = "ABC";
                int n = str.Length;
               Permutation.Permute(str, 0, n - 1);
            }
        
    }
}
