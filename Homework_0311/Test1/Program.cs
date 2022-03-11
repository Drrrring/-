//为示例中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。
//通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。

using System;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            GenericList<int> genericList = new GenericList<int>();
            for (int i = 0; i < 10; ++i)
            {
                genericList.Add(random.Next(10));
            }

            int max = 0;
            int min = 0;
            int sum = 0;
            genericList.ForEach(num =>
            {
                Console.WriteLine(num);
                max = max > num ? max : num;
                min = min < num ? min : num;
                sum += num;
            });
            
            Console.WriteLine($"max = {max}");
            Console.WriteLine($"min = {min}");
            Console.WriteLine($"sum = {sum}");

        }
    }
}