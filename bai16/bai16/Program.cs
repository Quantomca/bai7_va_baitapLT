using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Đặt bảng mã cho console để hiển thị tiếng Việt
        Console.OutputEncoding = Encoding.UTF8;

        // Khai báo số nguyên m, n 1 byte không dấu
        byte m = ReadByteFromConsole("Nhập số hàng của mảng (từ 2 đến 10): ");
        byte n = ReadByteFromConsole("Nhập số cột của mảng (từ 2 đến 10): ");
        Console.WriteLine($"Giá trị m được nhập là: {m}, giá trị n được nhập là: {n}");

        // Khai báo và cấp phát mảng 2 chiều các số nguyên 4 byte
        int[,] a = new int[m, n];

        // Nhập giá trị các phần tử của mảng a từ bàn phím
        Read2DArrayFromConsole(a, m, n);

        // In ra các giá trị của mảng a
        Console.WriteLine("Các giá trị của mảng a:");
        Print2DArray(a, m, n);

        // Tính tổng các phần tử của mảng chia hết cho 2024
        int sum = SumOfElementsDivisibleBy(a, m, n, 2024);
        Console.WriteLine($"Tổng các phần tử của mảng chia hết cho 2024 là: {sum}");
    }

    // Hàm đọc số nguyên 1 byte không dấu từ bàn phím, nếu nhập sai thì nhập lại
    static byte ReadByteFromConsole(string message)
    {
        byte result;
        while (true)
        {
            Console.Write(message);
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

    // Hàm đọc số nguyên 4 byte từ bàn phím, nếu nhập sai thì nhập lại
    static int ReadIntFromConsole(string message)
    {
        int result;
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            if (int.TryParse(input, out result))
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

    // Hàm nhập giá trị vào mảng 2 chiều các số nguyên 4 byte
    static void Read2DArrayFromConsole(int[,] array, byte m, byte n)
    {
        for (byte i = 0; i < m; i++)
        {
            for (byte j = 0; j < n; j++)
            {
                array[i, j] = ReadIntFromConsole($"Nhập giá trị phần tử a[{i},{j}]: ");
            }
        }
    }

    // Hàm in mảng 2 chiều ra màn hình
    static void Print2DArray(int[,] array, byte m, byte n)
    {
        for (byte i = 0; i < m; i++)
        {
            for (byte j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Hàm tính tổng các phần tử của mảng chia hết cho một số nguyên dương p
    static int SumOfElementsDivisibleBy(int[,] array, byte m, byte n, int p)
    {
        int sum = 0;
        for (byte i = 0; i < m; i++)
        {
            for (byte j = 0; j < n; j++)
            {
                if (array[i, j] % p == 0)
                {
                    sum += array[i, j];
                }
            }
        }
        return sum;
    }
}
