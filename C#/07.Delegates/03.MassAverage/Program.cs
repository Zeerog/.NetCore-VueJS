using System;

namespace _03.MassAverage
{
    class Program
    {
        delegate int Num();
        delegate int Operation(Num[] nums);
        static void Main(string[] args)
        {
            Random ran = new Random();
            Num[] nums = new Num[10];
            for (int i = 0; i < 10; i++)
            {
                nums[i] = () => ran.Next(0, 100);
            }
            Operation operation = (nums) =>
            {
                int res = 0, count = 0;
                foreach (Num num in nums)
                {
                    res += num();
                    count++;
                }
                return res / count;
            };
            Console.WriteLine(operation(nums));
        }
    }
}
