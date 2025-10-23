using System;
using System.Text;

namespace BTTH2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("=== BTTH2 Main Menu ===");
                Console.WriteLine("1. Calendar Program (Bài 1)");
                Console.WriteLine("2. Directory Listing (Bài 2)");
                Console.WriteLine("3. Ma trận 2D (Bài 3)");
                Console.WriteLine("4. Phân số + Max + Sort (Bài 4)");
                Console.WriteLine("5. Quản lý BĐS (Bài 5)");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");

                var key = Console.ReadLine();

                switch (key)
                {
                    case "1": Bai01.Run(); break;
                    case "2": Bai02.Run(); break;
                    case "3": Bai03.Run(); break;
                    case "4": Bai04.Run(); break;
                    case "5": Bai05.Run(); break;
                    case "0": return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        Console.WriteLine("Nhấn Enter để tiếp tục...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
