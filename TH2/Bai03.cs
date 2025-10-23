using System;

namespace BTTH2
{
    public static class Bai03
    {
        public static void Run()
        {
            int m = ReadInt("m (số dòng) = ", 1, 100);
            int n = ReadInt("n (số cột)  = ", 1, 100);
            int[,] a = new int[m, n];

            // Nhập ma trận
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = ReadInt($"a[{i},{j}] = ", int.MinValue, int.MaxValue);

            // Xuất ma trận
            Console.WriteLine("\nMa trận:");
            PrintMatrix(a);

            // Tìm kiếm giá trị x
            int x = ReadInt("\nTìm giá trị x = ", int.MinValue, int.MaxValue);
            bool found = false;
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (a[i, j] == x)
                    {
                        Console.WriteLine($"Tìm thấy tại ({i},{j})");
                        found = true;
                    }
            if (!found) Console.WriteLine("Không có.");

            // Liệt kê số nguyên tố
            Console.WriteLine("\nCác số nguyên tố (theo thứ tự duyệt):");
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    if (IsPrime(a[i, j])) Console.Write($"{a[i, j]} ");
            Console.WriteLine();

            // Đếm SNT theo từng dòng + in tất cả dòng có nhiều SNT nhất
            Console.WriteLine("\nSố lượng số nguyên tố theo từng dòng:");
            int[] cnt = new int[m];
            for (int i = 0; i < m; i++)
            {
                int c = 0;
                for (int j = 0; j < n; j++)
                    if (IsPrime(a[i, j])) c++;
                cnt[i] = c;
                Console.WriteLine($"Row {i}: {c} SNT");
            }

            int max = 0;
            for (int i = 0; i < m; i++)
                if (cnt[i] > max) max = cnt[i];

            if (max == 0)
            {
                Console.WriteLine("\nKhông có số nguyên tố nào trong ma trận.");
            }
            else
            {
                Console.Write("\nCác dòng nhiều SNT nhất: ");
                bool first = true;
                for (int i = 0; i < m; i++)
                {
                    if (cnt[i] == max)
                    {
                        Console.Write((first ? "" : ", ") + i);
                        first = false;
                    }
                }
                Console.WriteLine($" (số lượng = {max})");
            }

            Console.WriteLine("\nNhấn Enter để quay lại menu...");
            Console.ReadLine();
        }

        private static void PrintMatrix(int[,] a)
        {
            int m = a.GetLength(0), n = a.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++) Console.Write($"{a[i, j],6}");
                Console.WriteLine();
            }
        }

        private static bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n % 2 == 0) return n == 2;
            int r = (int)Math.Sqrt(n);
            for (int i = 3; i <= r; i += 2)
                if (n % i == 0) return false;
            return true;
        }

        private static int ReadInt(string prompt, int min, int max)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int v) && v >= min && v <= max)
                    return v;
                Console.WriteLine("Giá trị không hợp lệ. Thử lại.");
            }
        }
    }
}
