using System;
using System.IO;
using System.Text;

class bai11
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Nhập tên file
        Console.Write("Nhập tên file: ");
        string fileName = Console.ReadLine();

        // Nhập nội dung
        Console.Write("Nhập nội dung: ");
        string content = Console.ReadLine();

        // Ghi nội dung vào file
        WriteToFile(fileName, content);

        // Đọc nội dung từ file
        string readContent = ReadFromFile(fileName);

        // Hiển thị nội dung đọc được
        Console.WriteLine("Nội dung file:");
        Console.WriteLine(readContent);
    }

    static void WriteToFile(string fileName, string content)
    {
        Console.OutputEncoding = Encoding.UTF8;
        try
        {
            // Ghi nội dung vào file
            File.WriteAllText(fileName, content);
            Console.WriteLine("Đã ghi nội dung vào file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi ghi file: {ex.Message}");
        }
    }

    static string ReadFromFile(string fileName)
    {
        Console.OutputEncoding = Encoding.UTF8;
        try
        {
            // Đọc nội dung từ file
            return File.ReadAllText(fileName);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
            return "";
        }
    }
}