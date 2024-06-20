// Seeusing System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Đặt bảng mã cho console để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo biến số nguyên 2 byte không dấu
        ushort n = ReadUShortFromConsole();

        // In ra giá trị được nhập
        Console.WriteLine("Giá trị được nhập là: " + n);

        // Tính tổng bình phương các số từ 1 đến n
        long sumOfSquares = CalculateSumOfSquares(n);

        // In ra tổng bình phương các số từ 1 đến n
        Console.WriteLine("Tổng bình phương các số từ 1 đến " + n + " là: " + sumOfSquares);
    }

    // Hàm đọc số nguyên 2 byte không dấu từ bàn phím, nếu nhập sai thì nhập lại
    static ushort ReadUShortFromConsole()
    {
        ushort result;
        while (true)
        {
            Console.Write("Nhập một số nguyên 2 byte không dấu: ");
            string input = Console.ReadLine();
            if (ushort.TryParse(input, out result))
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

    // Hàm tính tổng bình phương các số từ 1 đến n
    static long CalculateSumOfSquares(ushort n)
    {
        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += (long)i * i;
        }
        return sum;
    }
}
