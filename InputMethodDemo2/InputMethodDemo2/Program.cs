using System;
using static System.Console;
namespace InputMethodDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second;
            InputMethod(out first, out second);
            WriteLine("The first value is {0} and the second value is {1}.", first, second);

        }

        private static void InputMethod(out int one, out int two)
        {
            one = DataEntry("first");
            two = DataEntry("second");
        }

        private static int DataEntry(string whichOne)
        {
            int one;
            string S1;
            WriteLine("Please enter {0} value.", whichOne);
            S1 = ReadLine();
            one = Convert.ToInt32(S1);
            return one;
        }
    }
}
