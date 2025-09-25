using System;

namespace BTTH1_BT4
{
    public class HowManyDaysInMonth
    {
        // Chương trình nhập tháng và năm, in ra số ngày của tháng đó
        public static int GetDaysInMonth(int month, int year)
        {
            try
            {
                return DateTime.DaysInMonth(year, month);
            }
            catch (ArgumentOutOfRangeException)
            {
                return -1;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter month (1-12): ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            int days = HowManyDaysInMonth.GetDaysInMonth(month, year);

            if (days != -1)
            {
                Console.WriteLine($"Number of days in month {month} of year {year} is: {days}");
            }
            else
            {
                Console.WriteLine("Invalid month or year.");
            }
        }
    }
}
