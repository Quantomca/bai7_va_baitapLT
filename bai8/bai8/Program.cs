using System;
using System.Text;
using System.Collections.Generic;

class bai8
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // a. Hiển thị bảng mã ASCII
        Console.WriteLine("Bảng mã ASCII:");
        Console.WriteLine("Ký tự\tMã ASCII");
        Console.WriteLine("-----------------------------");

        for (int i = 0; i <= 127; i++)
        {
            Console.WriteLine((char)i + "\t" + i);
        }

        Console.WriteLine();

        // b. Hiển thị bảng mã UTF-8 của trang mã 65001
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        Encoding utf8 = Encoding.GetEncoding(65001);

        Console.WriteLine("Bảng mã UTF-8 (trang mã 65001):");
        Console.WriteLine("Ký tự\tMã UTF-8");
        Console.WriteLine("-----------------------------");

        for (int i = 0; i <= 255; i++)
        {
            byte[] bytes = new byte[] { (byte)i };
            string character = utf8.GetString(bytes);
            Console.WriteLine(character + "\t" + i);
        }

        Console.WriteLine();

        // c. Phát tiếng beep khi nhấn phím space
        Console.WriteLine("Nhấn phím space để phát tiếng beep. Nhấn Esc để thoát.");

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Spacebar)
            {
                Console.Beep();
            }
            else if (key.Key == ConsoleKey.Escape)
            {
                break;
            }
        }

        Console.WriteLine();

        // d. Đếm số lần xuất hiện của mỗi ký tự trong một chuỗi
        Console.Write("Nhập vào một chuỗi ký tự: ");
        string input = Console.ReadLine();

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        Console.WriteLine("Số lần xuất hiện của mỗi ký tự:");
        foreach (KeyValuePair<char, int> kvp in charCount)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}