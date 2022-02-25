//求一个整数数组的最大值，最小值，平均值和所有元素的和
using System;

namespace Test02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int max = 0, min = 0, sum = 0;
            double ave = 0;
            Solution.Solve(nums, ref max, ref min, ref ave, ref sum);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(ave);
            Console.WriteLine(sum);

        }
    }

    class Solution
    {
        public static void Solve(int[] nums, ref int max, ref int min, ref double ave, ref int sum)
        {
            if (nums == null)
                throw new Exception("invalid input");
            max = min = nums[0];
            sum = 0;
            foreach(int num in nums)
            {
                if (max < num)
                    max = num;
                if (min > num)
                    min = num;
                sum += num;
            }
            ave = sum / nums.Length;
        }
    }
}
