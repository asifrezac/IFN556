using System;
using static System.Console;
namespace AdmissionModularized
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your GPA: ");
            double GPA = Convert.ToDouble(ReadLine());

            Write("Enter your test score: ");
            int testScore = Convert.ToInt32(ReadLine());

            Write("With {0} GPA and {1} Test Score, the admission status is {2}.", GPA, testScore, AdmissionStatus(GPA, testScore));
        }
        public static String AdmissionStatus(double GPA, int testScore)
        {
            const int TSL1 = 60, TSL2 = 80;
            const double GPACR = 3.0;
            string status;

            if (GPA >= GPACR && testScore >= TSL1)
                status = "Accept";
            else if (GPA < GPACR && testScore >= TSL2)
                status = "Accept";
            else
                status = "Reject";

            return status;
        }
    }
}
