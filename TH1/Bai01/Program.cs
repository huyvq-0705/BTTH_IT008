using System;

namespace BTTH1_BT1
{
    // a. Tính tổng các số lẻ trong mảng 
    public class SumOfAllOddNumbers
    {
        public static int SumOdd(int[] arr)
        {
            int sum = 0;
            foreach (int x in arr)
            {
                if (x % 2 != 0) sum += x;
            }
            return sum;
        }
    }

    // b. Đếm các số nguyên tố trong mảng
    public class CountAllPrimeNumbers
    {
        private static bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            int limit = (int)Math.Sqrt(num);
            for (int i = 3; i <= limit; i += 2)
                if (num % i == 0) return false;

            return true;
        }

        public static int CountPrimes(int[] arr)
        {
            int count = 0;
            foreach (int num in arr)
                if (IsPrime(num)) count++;
            return count;
        }
    }

    // c. Tìm số chính phương nhỏ nhất trong mảng
    public class PerfectSquareFinder
    {
        private static bool IsPerfectSquare(int x)
        {
            if (x < 0) return false;
            int r = (int)Math.Sqrt(x);
            return r * r == x;
        }

        public static int FindSmallestPerfectSquare(int[] arr)
        {
            int? best = null;
            foreach (int x in arr)
            {
                if (IsPerfectSquare(x))
                {
                    if (best == null || x < best.Value)
                        best = x;
                }
            }
            return best ?? -1;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            int n = ReadPositiveInt("Enter n (>0): ");
            int[] arr = CreateRandomArray(n, -100, 100);

            // Print the array immediately
            Console.WriteLine("\nGenerated array: " + string.Join(" ", arr));

            int choice;
            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Print array");
                Console.WriteLine("2. Sum of all odd numbers");
                Console.WriteLine("3. Count prime numbers");
                Console.WriteLine("4. Find the smallest perfect square");
                Console.WriteLine("0. Exit");
                Console.Write("Your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Array: " + string.Join(" ", arr));
                        break;
                    case 2:
                        Console.WriteLine("Sum of odd numbers: " + SumOfAllOddNumbers.SumOdd(arr));
                        break;
                    case 3:
                        Console.WriteLine("Number of primes: " + CountAllPrimeNumbers.CountPrimes(arr));
                        break;
                    case 4:
                        Console.WriteLine("Smallest perfect square: " + PerfectSquareFinder.FindSmallestPerfectSquare(arr));
                        break;
                    case 0:
                        Console.WriteLine("Program terminated.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 0);
        }

        // Helper: read a positive integer
        static int ReadPositiveInt(string message)
        {
            int n;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            return n;
        }

        // Helper: create a random integer array
        static int[] CreateRandomArray(int n, int minVal, int maxVal)
        {
            var rnd = new Random();
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(minVal, maxVal + 1);
            return a;
        }
    }
}
