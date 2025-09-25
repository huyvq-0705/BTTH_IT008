using System;

namespace BTTH1_BT6
{
    public class Matrix
    {
        private int[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int n, int m)
        {
            if (n <= 0 || m <= 0)
            {
                throw new ArgumentException("Rows and columns must be greater than 0.");
            }

            rows = n;
            cols = m;
            matrix = new int[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(100);
                }
            }
        }

        // a. Xuất ma trận
        public void PrintMatrix()
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // b. Tìm phần tử lớn nhất, nhỏ nhất trong ma trận
        public void FindMinMax()
        {
            if (rows == 0 || cols == 0)
            {
                Console.WriteLine("The matrix is empty.");
                return;
            }

            int max = matrix[0, 0];
            int min = matrix[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
            }
            Console.WriteLine($"The largest element is: {max}");
            Console.WriteLine($"The smallest element is: {min}");
        }

        // c. Tìm dòng có tổng lớn nhất 
        public void FindRowWithMaxSum()
        {
            if (rows == 0 || cols == 0)
            {
                Console.WriteLine("The matrix is empty.");
                return;
            }

            int max_sum = int.MinValue;
            int row_index = -1;

            for (int i = 0; i < rows; i++)
            {
                int current_sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    current_sum += matrix[i, j];
                }
                if (current_sum > max_sum)
                {
                    max_sum = current_sum;
                    row_index = i;
                }
            }
            Console.WriteLine($"The row with the largest sum is row {row_index + 1} with a sum of {max_sum}.");
        }

        // d. Tính tổng các số không phải số nguyên tố trong ma trận
        public void SumOfNonPrimes()
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!IsPrime(matrix[i, j]))
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"The sum of non-prime numbers in the matrix is: {sum}");
        }

        private bool IsPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        // e. Xóa dòng thứ k 
        public void DeleteRow(int k)
        {
            if (rows <= 0 || cols <= 0)
            {
                Console.WriteLine("The matrix is empty. Cannot delete row.");
                return;
            }

            if (k < 1 || k > rows)
            {
                Console.WriteLine("Invalid row index.");
                return;
            }

            int[,] new_matrix = new int[rows - 1, cols];
            int new_row_index = 0;

            for (int i = 0; i < rows; i++)
            {
                if (i != k - 1)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        new_matrix[new_row_index, j] = matrix[i, j];
                    }
                    new_row_index++;
                }
            }

            matrix = new_matrix;
            rows--;
            Console.WriteLine($"Row {k} has been deleted.");
        }
        private bool IsEmpty()
        {
            return rows == 0 || cols == 0;
        }
        // f. Xóa cột chứa phần tử lớn nhất trong ma trận
        public void DeleteColumnWithMaxElement()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The matrix is empty. Cannot delete column.");
                return;
            }

            int max_value = matrix[0, 0];
            int max_col_index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > max_value)
                    {
                        max_value = matrix[i, j];
                        max_col_index = j;
                    }
                }
            }

            Console.WriteLine($"The largest element is {max_value}, located in column {max_col_index + 1}.");

            int[,] new_matrix = new int[rows, cols - 1];
            for (int i = 0; i < rows; i++)
            {
                int new_col_index = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (j != max_col_index)
                    {
                        new_matrix[i, new_col_index] = matrix[i, j];
                        new_col_index++;
                    }
                }
            }

            matrix = new_matrix;
            cols--;

            if (cols == 0)
            {
                rows = 0;
                Console.WriteLine("Matrix is now empty.");
            }
            else
            {
                Console.WriteLine("The column containing the largest element has been deleted.");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the number of rows (n): ");
                int n = int.Parse(Console.ReadLine() ?? "0");
                Console.Write("Enter the number of columns (m): ");
                int m = int.Parse(Console.ReadLine() ?? "0");

                if (n <= 0 || m <= 0)
                {
                    Console.WriteLine("Error: Rows and columns must be greater than 0.");
                    return;
                }

                Matrix myMatrix = new Matrix(n, m);

                while (true)
                {
                    Console.WriteLine("\n===== MENU =====");
                    Console.WriteLine("1. Print Matrix");
                    Console.WriteLine("2. Find Min and Max");
                    Console.WriteLine("3. Find Row with Max Sum");
                    Console.WriteLine("4. Sum of Non-Prime Numbers");
                    Console.WriteLine("5. Delete Row");
                    Console.WriteLine("6. Delete Column with Max Element");
                    Console.WriteLine("0. Exit");
                    Console.Write("Choose an option: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            myMatrix.PrintMatrix();
                            break;
                        case "2":
                            myMatrix.FindMinMax();
                            break;
                        case "3":
                            myMatrix.FindRowWithMaxSum();
                            break;
                        case "4":
                            myMatrix.SumOfNonPrimes();
                            break;
                        case "5":
                            Console.Write("Enter the row to delete (k): ");
                            int k = int.Parse(Console.ReadLine() ?? "0");
                            myMatrix.DeleteRow(k);
                            myMatrix.PrintMatrix();
                            break;
                        case "6":
                            myMatrix.DeleteColumnWithMaxElement();
                            myMatrix.PrintMatrix();
                            break;
                        case "0":
                            Console.WriteLine("Exiting program...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice, try again!");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
