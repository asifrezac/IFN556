using System;
using static System.Console;
namespace PaintingEstimate
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Input the length of the room: ");
            int length = Convert.ToInt32(ReadLine());

            Write("Input the width of the room: ");
            int width = Convert.ToInt32(ReadLine());

            Write("The estimate painting cost for a room with {0} feet length and {1} feet width is {2}.", length, width, PaintCost(length, width).ToString("C"));
        }

        public static Double PaintCost(int length, int width)
        {
            const int height = 9;
            const double paintRate = 6.00;
            int area = 2 * ((length * height) + (width * height));

            double cost = paintRate * Convert.ToDouble(area);

            return cost;
        }
    }
}
