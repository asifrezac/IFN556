using System;
using static System.Console;
namespace Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = {2,3,4,5,6,7,8,9};
            AverageCalc(12);
            AverageCalc(12.34, 56.78);
            AverageCalc(array);
        }

        public static void AverageCalc(params double[] table)
        {
            double total = 0;
            double average;

            foreach(double num in table)
            {
                total = total + num;
                Write("{0}  ", num);
            }
            average = total / Convert.ToDouble(table.Length);
            WriteLine(" - - Average is {0}.", average);
        }
    }
}
