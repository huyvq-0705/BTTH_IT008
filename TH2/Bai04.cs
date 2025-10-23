using System;
using System.Collections.Generic;

namespace BTTH2
{
    public static class Bai04
    {
        public static void Run()
        {
            var a = ReadFraction("Nhập phân số a (p/q): ");
            var b = ReadFraction("Nhập phân số b (p/q): ");

            Console.WriteLine($"\na + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");

            int n = ReadInt("\nNhập số lượng phân số n = ", 1, 1000);
            var list = new List<Fraction>();
            for (int i = 0; i < n; i++)
                list.Add(ReadFraction($"fs[{i}] = "));

            var max = list[0];
            foreach (var f in list) if (f.CompareTo(max) > 0) max = f;
            Console.WriteLine($"Phân số lớn nhất: {max}");

            list.Sort();
            Console.WriteLine("Danh sách tăng dần:");
            foreach (var f in list) Console.Write(f + " ");
            Console.WriteLine();

            Console.WriteLine("\nNhấn Enter để quay lại menu...");
            Console.ReadLine();
        }

        private static Fraction ReadFraction(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var s = Console.ReadLine();
                try { return Fraction.Parse(s ?? ""); }
                catch { Console.WriteLine("Định dạng sai. Nhập kiểu p/q, ví dụ 3/4."); }
            }
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

    public readonly struct Fraction : IComparable<Fraction>
    {
        public long Num { get; }
        public long Den { get; }

        public Fraction(long num, long den)
        {
            if (den == 0) throw new DivideByZeroException();
            if (den < 0) { num = -num; den = -den; }
            long g = Gcd(Math.Abs(num), den);
            Num = num / g; Den = den / g;
        }

        private static long Gcd(long a, long b) { while (b != 0) { long t = a % b; a = b; b = t; } return Math.Abs(a); }

        public static Fraction operator +(Fraction a, Fraction b) => new(a.Num * b.Den + b.Num * a.Den, a.Den * b.Den);
        public static Fraction operator -(Fraction a, Fraction b) => new(a.Num * b.Den - b.Num * a.Den, a.Den * b.Den);
        public static Fraction operator *(Fraction a, Fraction b) => new(a.Num * b.Num, a.Den * b.Den);
        public static Fraction operator /(Fraction a, Fraction b) => new(a.Num * b.Den, a.Den * b.Num);

        public int CompareTo(Fraction other) => (Num * other.Den).CompareTo(other.Num * Den);
        public override string ToString() => $"{Num}/{Den}";

        public static Fraction Parse(string s)
        {
            var p = (s ?? "").Split('/');
            if (p.Length != 2) throw new FormatException();
            return new Fraction(long.Parse(p[0].Trim()), long.Parse(p[1].Trim()));
        }
    }
}
