using System;

namespace calculator_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Double.Parse(".");
            while (true)
            {
                Console.WriteLine("Enter 2 numbers and an operator: (e.g. 1+1)");
                string input = Console.ReadLine();

                double num1, num2;
                if (input.Contains("+"))
                {
                    string[] nums = input.Split('+');
                    try
                    {
                        num1 = Double.Parse(nums[0]);
                        num2 = Double.Parse(nums[1]);
                        Console.WriteLine("Result: " + (num1 + num2));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                    }
                }
                else if (input.Contains("-"))
                {
                    string[] nums = input.Split('-');
                    try
                    {
                        num1 = Double.Parse(nums[0]);
                        num2 = Double.Parse(nums[1]);
                        Console.WriteLine("Result: " + (num1 - num2));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                    }
                }
                else if (input.Contains("*"))
                {
                    string[] nums = input.Split('*');
                    try
                    {
                        num1 = Double.Parse(nums[0]);
                        num2 = Double.Parse(nums[1]);
                        Console.WriteLine("Result: " + (num1 * num2));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                    }
                }
                else if (input.Contains("/"))
                {
                    string[] nums = input.Split('/');
                    try
                    {
                        num1 = Double.Parse(nums[0]);
                        num2 = Double.Parse(nums[1]);
                        if (num2 == 0)
                            throw new Exception("cannot be divided by 0");
                        Console.WriteLine("Result: " + (num1 / num2));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else Console.WriteLine("invalid input");
            }



        }

       
    }
}
