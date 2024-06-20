using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Đặt bảng mã cho console để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo biến số thực 4 byte
        float x = ReadFloatFromConsole();

        // In ra giá trị được nhập
        Console.WriteLine("Giá trị được nhập là: " + x);
    }

    // Hàm đọc số thực 4 byte từ bàn phím, nếu nhập sai thì nhập lại
    static float ReadFloatFromConsole()
    {
        float result;
        while (true)
        {
            Console.Write("Nhập một số thực 4 byte: ");
            string input = Console.ReadLine();
            if (float.TryParse(input, out result))
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
