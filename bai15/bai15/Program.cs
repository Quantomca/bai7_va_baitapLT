using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Đặt bảng mã cho console để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo số nguyên n 1 byte không dấu
        byte n = ReadByteFromConsole();
        Console.WriteLine("Giá trị số nguyên n được nhập là: " + n);

        // Khai báo và cấp phát mảng số thực 4 byte
        float[] a = new float[n];

        // Nhập giá trị các phần tử của mảng a từ bàn phím
        for (int i = 0; i < n; i++)
        {
            a[i] = ReadFloatFromConsole();
        }

        // In ra các giá trị của mảng a
        Console.WriteLine("Các giá trị của mảng a:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"a[{i}] = {a[i]}");
        }
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
