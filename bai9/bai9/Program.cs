using System;
using System.Text;

class bai9
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Phần a: Đảo ngược chuỗi
        Console.Write("Nhập chuỗi: ");
        string inputString = Console.ReadLine();

        string reversedString = ReverseString(inputString);
        Console.WriteLine("Chuỗi đảo ngược: " + reversedString);

        // Phần b: Đếm số lượng từ
        int wordCount = CountWords(inputString);
        Console.WriteLine("Số lượng từ: " + wordCount);
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static int CountWords(string str)
    {
        string[] words = str.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}