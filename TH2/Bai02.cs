using System;
using System.IO;

namespace BTTH2
{
    public class Bai02
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Enter a directory path (e.g., D:\\): ");
            string? path = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(path) || !Directory.Exists(path))
            {
                Console.WriteLine("❌ Directory not found!");
                return;
            }

            Console.WriteLine($"\nDirectory of {path}");
            Console.WriteLine(new string('-', 60));

            string[] directories = Directory.GetDirectories(path);
            foreach (string dir in directories)
            {
                DirectoryInfo dInfo = new DirectoryInfo(dir);
                Console.WriteLine($"{dInfo.LastWriteTime:dd/MM/yyyy hh:mm tt}    <DIR>    {dInfo.Name}");
            }

            string[] files = Directory.GetFiles(path);
            long totalSize = 0;
            int fileCount = 0;
            foreach (string file in files)
            {
                FileInfo fInfo = new FileInfo(file);
                Console.WriteLine($"{fInfo.LastWriteTime:dd/MM/yyyy hh:mm tt}    {fInfo.Length,15:N0}    {fInfo.Name}");
                totalSize += fInfo.Length;
                fileCount++;
            }

            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"   {fileCount} File(s)\t{totalSize:N0} bytes");

            DriveInfo drive = new DriveInfo(Path.GetPathRoot(path));
            Console.WriteLine($"   {drive.AvailableFreeSpace:N0} bytes free");
        }
    }
}
