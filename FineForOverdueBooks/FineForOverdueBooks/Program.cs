using System;
using static System.Console;
namespace FineForOverdueBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter the books that are overdue: ");
            int books = Convert.ToInt32(ReadLine());

            Write("Enter te days the books are overdue: ");
            int days = Convert.ToInt32(ReadLine());

            Write("{0} books for {1} days of overdue will result to {2} fine.", books, days, CalculateFine(books, days).ToString("C"));
        }
        public static double CalculateFine(int books, int days)
        {
            double fine;
            const double FINE1 = 0.1, FINE2 = 0.2;
            const int DAYLIMIT = 7;

            if (days <= DAYLIMIT)
                fine = Convert.ToDouble(books * days) * FINE1;
            else
                fine = (Convert.ToDouble(books * DAYLIMIT) * FINE1) + (Convert.ToDouble(books * (days - DAYLIMIT)) * FINE2);

            return fine;
        }
    }
}
