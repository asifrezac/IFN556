using System;
using static System.Console;
namespace MovieTime
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieDuration("Matrix", 113);
            MovieDuration("The Greenbook");
            MovieDuration();
        }

        static void MovieDuration(string name = "300", int duration = 90)
        {
            WriteLine("The {0} movie is {1} minutes long.", name, duration);
        }
    }
}
