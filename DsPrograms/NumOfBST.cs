using System;
using System.Collections.Generic;
using System.Text;

namespace DsPrograms
{
    class NumOfBST
    {
        public static double FindNumOfBST(int n)
        {
            Console.WriteLine("Enter a value :");
            n = Convert.ToInt32(Console.ReadLine());
            int[] bst = new int[n + 1];
            bst[0] = 1;
            bst[1] = 1;
            for(int i = 2; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    bst[i] = bst[i] + (bst[i - j] * bst[j - 1]);
                }
            }
            double value = Math.Pow(10, 8);
            return Math.Abs(bst[n] % value);
            
        }
    }
}
