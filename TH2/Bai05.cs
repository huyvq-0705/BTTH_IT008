using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BTTH2
{
    public static class Bai05
    {
        private static readonly List<Property> list = new();

        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("=== Quản lý BĐS Đại Phú ===");
                Console.WriteLine("1. Nhập dữ liệu");
                Console.WriteLine("2. In danh sách");
                Console.WriteLine("3. Tổng giá theo loại");
                Console.WriteLine("4. Lọc: (Đất >100m2) OR (Nhà phố >60m2 & năm >=2019)");
                Console.WriteLine("5. Tìm kiếm (Nhà phố/Chung cư) theo địa điểm, giá, diện tích");
                Console.WriteLine("6. Nạp dữ liệu mẫu");
                Console.WriteLine("0. Về menu chính");
                Console.Write("Chọn: ");
                var c = Console.ReadLine();
                Console.WriteLine();

                switch (c)
                {
                    case "1": InputData(); break;
                    case "2": PrintAll(); break;
                    case "3": PrintTotals(); break;
                    case "4": FilterSpecial(); break;
                    case "5": Search(); break;
                    case "6": SeedSample(); Console.WriteLine("Đã nạp mẫu.\n"); break;
                    case "0": return;
                    default: Console.WriteLine("Không hợp lệ.\n"); break;
                }
            }
        }

        // ====== Actions ======
        private static void InputData()
        {
            int landN = ReadInt("Số khu đất: ", 0, 1000);
            for (int i = 0; i < landN; i++) list.Add(ReadLand(i));

            int thN = ReadInt("Số nhà phố : ", 0, 1000);
            for (int i = 0; i < thN; i++) list.Add(ReadTownhouse(i));

            int apN = ReadInt("Số chung cư: ", 0, 1000);
            for (int i = 0; i < apN; i++) list.Add(ReadApartment(i));

            Console.WriteLine("Đã nhập xong.\n");
        }

        private static void PrintAll()
        {
            if (!list.Any()) { Console.WriteLine("Danh sách trống.\n"); return; }
            Console.WriteLine("Danh sách BĐS:");
            foreach (var p in list) Console.WriteLine(p);
            Console.WriteLine();
        }

        private static void PrintTotals()
        {
            if (!list.Any()) { Console.WriteLine("Danh sách trống.\n"); return; }
            Console.WriteLine("Tổng giá theo loại:");
            var totals = list.GroupBy(p => p.Type).Select(g => new { g.Key, Sum = g.Sum(x => x.Price) });
            foreach (var t in totals) Console.WriteLine($"{t.Key}: {t.Sum:N0} VND");
            Console.WriteLine();
        }

        private static void FilterSpecial()
        {
            var filtered = list.Where(p =>
                (p is Land l && l.Area > 100) ||
                (p is Townhouse th && th.Area > 60 && th.Year >= 2019));
            Console.WriteLine("Kết quả lọc:");
            foreach (var p in filtered) Console.WriteLine(p);
            Console.WriteLine();
        }

        private static void Search()
        {
            Console.Write("Từ khóa địa điểm: ");
            string kw = Console.ReadLine() ?? "";
            decimal maxPrice = ReadDecimal("Giá tối đa (VND): ", 0, decimal.MaxValue);
            double minArea = ReadDouble("Diện tích tối thiểu (m2): ", 0, double.MaxValue);

            var result = list.Where(p => p is Townhouse || p is Apartment)
                             .Where(p => (p.Location ?? "")
                                     .IndexOf(kw, StringComparison.OrdinalIgnoreCase) >= 0)
                             .Where(p => p.Price <= maxPrice && p.Area >= minArea);

            Console.WriteLine("\nKết quả tìm kiếm:");
            foreach (var p in result) Console.WriteLine(p);
            Console.WriteLine();
        }

        private static void SeedSample()
        {
            list.Clear();
            list.AddRange(new Property[]
            {
            // ===== Land (3) =====
            new Land { Location="Q1",       Price=12_000_000_000m, Area=120 },
            new Land { Location="Thu Duc",  Price= 3_200_000_000m, Area=120 },
            new Land { Location="Cu Chi",   Price= 3_500_000_000m, Area=300 },

            // ===== Townhouse (3) =====
            new Townhouse { Location="Thu Duc",      Price= 4_200_000_000m, Area=70, Year=2021, Floors=3 },
            new Townhouse { Location="Thu Duc City", Price= 4_900_000_000m, Area=68, Year=2021, Floors=3 },
            new Townhouse { Location="Binh Thanh",   Price= 6_200_000_000m, Area=58, Year=2018, Floors=2 },

            // ===== Apartment (4) =====
            new Apartment { Location="Thu Duc",           Price= 2_100_000_000m, Area=60, Floor=15 },
            new Apartment { Location="TP Thu Duc",        Price= 1_950_000_000m, Area=55, Floor=10 },
            new Apartment { Location="Q7 Phu My Hung",    Price= 2_800_000_000m, Area=72, Floor=20 },
            new Apartment { Location="Binh Thanh - Landmark", Price= 4_000_000_000m, Area=80, Floor=35 },
                });
        }

        // ====== Readers ======
        private static Land ReadLand(int i)
        {
            Console.WriteLine($"-- Khu đất #{i} --");
            return new Land
            {
                Location = ReadString("Địa điểm: "),
                Price = ReadDecimal("Giá (VND): ", 0, decimal.MaxValue),
                Area = ReadDouble("Diện tích (m2): ", 0, double.MaxValue)
            };
        }

        private static Townhouse ReadTownhouse(int i)
        {
            Console.WriteLine($"-- Nhà phố #{i} --");
            return new Townhouse
            {
                Location = ReadString("Địa điểm: "),
                Price = ReadDecimal("Giá (VND): ", 0, decimal.MaxValue),
                Area = ReadDouble("Diện tích (m2): ", 0, double.MaxValue),
                Year = ReadInt("Năm xây dựng: ", 1900, 3000),
                Floors = ReadInt("Số tầng: ", 1, 200)
            };
        }

        private static Apartment ReadApartment(int i)
        {
            Console.WriteLine($"-- Chung cư #{i} --");
            return new Apartment
            {
                Location = ReadString("Địa điểm: "),
                Price = ReadDecimal("Giá (VND): ", 0, decimal.MaxValue),
                Area = ReadDouble("Diện tích (m2): ", 0, double.MaxValue),
                Floor = ReadInt("Tầng: ", 1, 500)
            };
        }

        // ====== Helpers ======
        private static string ReadString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine() ?? "";
        }

        private static int ReadInt(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int v) && v >= min && v <= max)
                    return v;
                Console.WriteLine("Sai định dạng. Thử lại.");
            }
        }

        private static double ReadDouble(string prompt, double min, double max)
        {
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double v)
                    && v >= min && v <= max) return v;
                Console.WriteLine("Sai định dạng (dùng dấu chấm cho số thập phân). Thử lại.");
            }
        }

        private static decimal ReadDecimal(string prompt, decimal min, decimal max)
        {
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out decimal v)
                    && v >= min && v <= max) return v;
                Console.WriteLine("Sai định dạng tiền. Thử lại.");
            }
        }
    }

    // ====== Models ======
    public abstract class Property
    {
        public string Location { get; set; } = "";
        public decimal Price { get; set; }
        public double Area { get; set; }
        public abstract string Type { get; }
        public override string ToString() => $"[{Type}] {Location} | {Price:N0} VND | {Area} m2";
    }

    public class Land : Property
    {
        public override string Type => "Khu đất";
    }

    public class Townhouse : Property
    {
        public int Year { get; set; }
        public int Floors { get; set; }
        public override string Type => "Nhà phố";
        public override string ToString() => base.ToString() + $" | Năm {Year} | {Floors} tầng";
    }

    public class Apartment : Property
    {
        public int Floor { get; set; }
        public override string Type => "Chung cư";
        public override string ToString() => base.ToString() + $" | Tầng {Floor}";
    }
}
