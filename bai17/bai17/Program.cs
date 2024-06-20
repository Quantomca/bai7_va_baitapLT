using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Đặt bảng mã cho console để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo biến xâu kí tự
        string st;

        // Nhập xâu kí tự từ bàn phím
        Console.Write("Nhập xâu kí tự: ");
        st = Console.ReadLine();

        if (st == "#")
        {
            // Phát tiếng beep nếu xâu kí tự là "#"
            Console.Beep();
        }
        else
        {
            // Gọi hàm để đếm và in ra số từ của xâu kí tự
            int wordCount = CountWords(st);
            Console.WriteLine("Số từ của xâu kí tự là: " + wordCount);
        }
    }

    // Hàm đếm số các từ của 1 xâu kí tự
    static int CountWords(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        // Tách xâu kí tự thành các từ
        string[] words = s.Split(new char[] { ' ', '.', '!', '?', ',', ';', ':', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);

        // Trả lại số lượng từ
        return words.Length;
    }
}
