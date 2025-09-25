using System;

namespace BTTH1_BT5
{
    public class whatIsDayOfWeek
    {
        // Chương trình nhập ngày tháng năm, in ra ngày đó là thứ mấy trong tuần
        public static string GetDayOfWeek(int day, int month, int year)
        {
            try
            {
                DateTime dt = new DateTime(year, month, day);
                return dt.DayOfWeek.ToString();
            }
            catch
            {
                return "Invalid date";
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

            string dayOfWeek = whatIsDayOfWeek.GetDayOfWeek(date, month, year);
            Console.WriteLine($"The day of the week is: {dayOfWeek}");
        }
    }
}
