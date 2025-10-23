using System;

namespace BTTH2
{
    public class Bai01
    {
        public static void Run()
        {
            int month = ReadInt("Enter month (1-12): ", 1, 12);
            int year = ReadInt("Enter year (1-9999): ", 1, 9999);

            DateTime firstDay = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int startDay = (int)firstDay.DayOfWeek; // Sunday=0

            Console.WriteLine($"\nMonth: {month:D2}/{year}");
            const string sep = "-------------------------------------------";
            Console.WriteLine(sep);
            Console.WriteLine("| Sun | Mon | Tue | Wed | Thu | Fri | Sat |");
            Console.WriteLine(sep);

            int col = 0;
            for (int i = 0; i < startDay; i++) { Console.Write("|     "); col++; }

            for (int day = 1; day <= daysInMonth; day++)
            {
                Console.Write($"| {day,2}  ");
                col++;

                if (col == 7)
                {
                    Console.WriteLine("|");
                    if (day != daysInMonth) Console.WriteLine(sep);
                    col = 0;
                }
            }

            if (col > 0)
            {
                for (int i = col; i < 7; i++) Console.Write("|     ");
                Console.WriteLine("|");
            }
            Console.WriteLine(sep);
        }

        private static int ReadInt(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                string? s = Console.ReadLine();

                if (int.TryParse(s, out int value) && value >= min && value <= max)
                    return value;

                Console.WriteLine($"Invalid input. Enter an integer in range [{min}..{max}].\n");
            }
        }
    }
}
