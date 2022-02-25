//编写程序输出用户指定数据的所有素数因子

using System;
using System.Collections.Generic;
namespace Homework_0225
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Solution.GetPrime(30);
            foreach(int num in nums)
            {
                Console.Write(num + " ");
            }
        }
    }

    class Solution
    {
        public static int[] GetPrime(int num)
        {
            List<int> primes = new List<int>();
            int i = 2;
            while(num > 2)
            {
                if(num % i == 0)
                {
                    primes.Add(i);
                    num /= i;
                }
                else
                {
                    i++;
                }
            }
            return primes.ToArray();
        }
    }


}
