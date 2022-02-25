//用“埃氏筛法”求2~ 100以内的素数。
//2~ 100以内的数，先去掉2的倍数，再去掉3的倍数，再去掉4的倍数，以此类推。最后剩下的就是素数。

using System;
using System.Collections;

namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = Solution.getPrimes();
            foreach(int num in primes)
            {
                Console.Write(num + " ");
            }
        }
    }

    class Solution
    {
        public static int[] getPrimes()
        {
            int[] array = new int[101];
            ArrayList arrayList = new ArrayList();
            //先假设所有数都是素数
            for(int i = 2; i < 101; ++i)
            {
                int flag = 1;
                for (int j = 2; j * j <= i; ++j)
                {
                    if (i % j == 0)
                    { flag = 0; }
                }
                if (flag == 1)
                    arrayList.Add(i);
            }
            return (int[])arrayList.ToArray(Type.GetType("System.Int32"));
        }
    }
}
