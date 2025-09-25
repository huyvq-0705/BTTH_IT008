using System;

namespace BTTH1_BT2
{
    class IsPrime
    {
        public static bool Check(int n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            int limit = (int)Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2)
                if (n % i == 0) return false;
            return true;
        }
    }
    //Chương trình nhập số nguyên dương n, tính tổng các số nguyên tố < n và xuất kết quả ra màn hình. 
    public class SumOfPrimeUnderN
    {
        public static int SumOfPrime(int n)
        {
            int sum = 0;
            Console.Write("Cac so nguyen to nho hon {0} la: ", n);
            for (int i = 2; i < n; i++)
            {
                if (IsPrime.Check(i))
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }
            Console.WriteLine();
            return sum;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap n (>0): ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            Console.WriteLine("Tong cac so nguyen to nho hon {0} la: {1}", n, SumOfPrimeUnderN.SumOfPrime(n));
        }
    }
}