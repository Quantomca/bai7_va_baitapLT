using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Đặt bảng mã cho console để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo biến số thực 8 byte
        double x = ReadDoubleFromConsole();

        // Hiển thị giá trị căn bậc 2 của x
        if (x >= 0)
        {
            double sqrtX = Math.Sqrt(x);
            Console.WriteLine($"Giá trị căn bậc 2 của {x} là: {sqrtX}");
        }
        else
        {
            Console.WriteLine("Không thể tính căn bậc 2 của số âm.");
        }
    }

    // Hàm đọc số thực 8 byte từ bàn phím, nếu nhập sai thì nhập lại
    static double ReadDoubleFromConsole()
    {
        double result;
        while (true)
        {
            Console.Write("Nhập một số thực 8 byte: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out result))
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
