using System;

namespace BTTH1_BT3
{
    public class DateTimeChecker
    {
        // Chương trình nhập ngày tháng năm, cho biết ngày tháng năm đó có hợp lệ hay không
        public static bool IsValidDate(int Date, int Month, int Year)
        {
            try
            {
                DateTime dt = new DateTime(Year, Month, Date);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter date: ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (DateTimeChecker.IsValidDate(date, month, year))
            {
                Console.WriteLine("The date is valid.");
            }
            else
            {
                Console.WriteLine("The date is invalid.");
            }
        }
    }
}
