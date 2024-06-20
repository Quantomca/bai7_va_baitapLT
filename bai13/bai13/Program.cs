using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Đặt bảng mã cho console để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo biến số nguyên 1 byte không dấu
        byte n = ReadByteFromConsole();

        // In ra giá trị được nhập
        Console.WriteLine("Giá trị được nhập là: " + n);
    }

    // Hàm đọc số nguyên 1 byte không dấu từ bàn phím, nếu nhập sai thì nhập lại
    static byte ReadByteFromConsole()
    {
        byte result;
        while (true)
        {
            Console.Write("Nhập một số nguyên 1 byte không dấu (từ 2 đến 10): ");
            string input = Console.ReadLine();
            if (byte.TryParse(input, out result) && result >= 2 && result <= 10)
            {
                break;
            }
            else
            {
                Console.WriteLine("Giá trị nhập không hợp lệ. Vui lòng nhập lại.");
            }
        }
        return result;
    }
}
