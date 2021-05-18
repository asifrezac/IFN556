using System;
using static System.Console;

namespace IntegerFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int totalElements = FillArray(nums);
            WriteLine("Total elements used is {0}.", totalElements);
            for (int x = 0; x < totalElements; x++)
                WriteLine("{0}", nums[x]);
            int big, small, total;
            double average;
            Statistics(nums, totalElements, out big, out small, out total, out average);
            WriteLine("The largest value among the array elements is {0}.", big);
            WriteLine("The smallest value among the array elements is {0}.", small);
            WriteLine("The sum of the array elements is {0}.", total);
            WriteLine("The average of the array elements is {0}.", average);
        }

        public static int FillArray(int[] array)
        {
            int pos = 0, content = 0;
            const int QUIT = 999;
            while (pos < array.Length && content != QUIT)
            {
                WriteLine("Please enter integer value or {0} to quit.", QUIT);
                if (int.TryParse(ReadLine(), out content))
                {
                    array[pos] = content;
                    pos++;
                }
                else
                    WriteLine("Invalid Integer value, please enter again.");
            }
            return pos - 1;
        }

        public static void Statistics(int[] list, int usedEle, out int high, out int low, out int sum, out double avg)
        {
            sum = 0;
            high = low = list[0];

            for (int x = 0; x < usedEle; x++)
            {
                sum = sum + list[x];
                if (list[x] > high)
                    high = list[x];
                if (list[x] < low)
                    low = list[x];
            }
            avg = Convert.ToDouble(sum) / Convert.ToDouble(usedEle);
        }
    }
}
