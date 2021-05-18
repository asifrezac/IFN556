using System;
using static System.Console;
namespace Reverse3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 23, middleInt = 45, lastInt = 87;
            WriteLine("The three value are {0}, {1} and {2}.", firstInt, middleInt, lastInt);
            Reverse(ref firstInt, ref middleInt, ref lastInt);
            WriteLine("The three value are {0}, {1} and {2}.", firstInt, middleInt, lastInt);
        }

        public static void Reverse(ref int a, ref int b, ref int c)
        {
            int temp; // temp is used to store backup
            temp = a; // take the backup of value of a in temp
            a = c; //now we have a safe, so we can give value of c to a.
            c = temp; // c will get the original value of a from the backup in temp.
        }
    }
}
