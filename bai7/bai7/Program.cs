using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("Chọn bài tập:");
            Console.WriteLine("a. Tính tổng hai số nguyên không dấu");
            Console.WriteLine("b. Tính diện tích và chu vi hình chữ nhật");
            Console.WriteLine("c. Kiểm tra số chẵn lẻ");
            Console.WriteLine("d. Tính tổng hai số nguyên có dấu");
            Console.WriteLine("e. Tính tổng các số từ 1 đến n");
            Console.WriteLine("g. Tính diện tích và chu vi hình chữ nhật với số thực");
            Console.WriteLine("h. Tìm số lớn nhất trong ba số");
            Console.WriteLine("k. Tính giai thừa của số nguyên không âm");
            Console.WriteLine("l. Kiểm tra số nguyên tố");
            Console.WriteLine("m. Kiểm tra số hoàn hảo");
            Console.WriteLine("q. Thoát");
            Console.Write("Lựa chọn của bạn: ");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case 'a':
                    SumUnsignedIntegers();
                    break;
                case 'b':
                    RectangleAreaPerimeter();
                    break;
                case 'c':
                    CheckEvenOdd();
                    break;
                case 'd':
                    SumSignedBytes();
                    break;
                case 'e':
                    SumFromOneToN();
                    break;
                case 'g':
                    RectangleAreaPerimeterDouble();
                    break;
                case 'h':
                    FindLargestOfThree();
                    break;
                case 'k':
                    CalculateFactorial();
                    break;
                case 'l':
                    CheckPrime();
                    break;
                case 'm':
                    CheckPerfectNumber();
                    break;
                case 'q':
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void SumUnsignedIntegers()
    {
        Console.Write("Nhập số nguyên không dấu thứ nhất: ");
        uint num1 = uint.Parse(Console.ReadLine());
        Console.Write("Nhập số nguyên không dấu thứ hai: ");
        uint num2 = uint.Parse(Console.ReadLine());
        uint sum = num1 + num2;
        Console.WriteLine($"Tổng: {sum}");
    }

    static void RectangleAreaPerimeter()
    {
        Console.Write("Nhập chiều dài: ");
        ushort length = ushort.Parse(Console.ReadLine());
        Console.Write("Nhập chiều rộng: ");
        ushort width = ushort.Parse(Console.ReadLine());
        ushort area = (ushort)(length * width);
        ushort perimeter = (ushort)(2 * (length + width));
        Console.WriteLine($"Diện tích: {area}, Chu vi: {perimeter}");
    }

    static void CheckEvenOdd()
    {
        Console.Write("Nhập số nguyên không dấu: ");
        uint num = uint.Parse(Console.ReadLine());
        if (num % 2 == 0)
            Console.WriteLine("Số chẵn");
        else
            Console.WriteLine("Số lẻ");
    }

    static void SumSignedBytes()
    {
        Console.Write("Nhập số nguyên có dấu thứ nhất: ");
        sbyte num1 = sbyte.Parse(Console.ReadLine());
        Console.Write("Nhập số nguyên có dấu thứ hai: ");
        sbyte num2 = sbyte.Parse(Console.ReadLine());
        sbyte sum = (sbyte)(num1 + num2);
        Console.WriteLine($"Tổng: {sum}");
    }

    static void SumFromOneToN()
    {
        Console.Write("Nhập số nguyên không dấu n: ");
        uint n = uint.Parse(Console.ReadLine());
        uint sum = n * (n + 1) / 2;
        Console.WriteLine($"Tổng từ 1 đến {n}: {sum}");
    }

    static void RectangleAreaPerimeterDouble()
    {
        Console.Write("Nhập chiều dài: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Nhập chiều rộng: ");
        double width = double.Parse(Console.ReadLine());
        double area = length * width;
        double perimeter = 2 * (length + width);
        Console.WriteLine($"Diện tích: {area}, Chu vi: {perimeter}");
    }

    static void FindLargestOfThree()
    {
        Console.Write("Nhập số thứ nhất: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ hai: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Nhập số thứ ba: ");
        int num3 = int.Parse(Console.ReadLine());
        int largest = Math.Max(num1, Math.Max(num2, num3));
        Console.WriteLine($"Số lớn nhất: {largest}");
    }

    static void CalculateFactorial()
    {
        Console.Write("Nhập số nguyên không âm: ");
        uint n = uint.Parse(Console.ReadLine());
        ulong factorial = 1;
        for (uint i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"Giai thừa của {n} là: {factorial}");
    }

    static void CheckPrime()
    {
        Console.Write("Nhập số nguyên không âm: ");
        uint n = uint.Parse(Console.ReadLine());
        if (n <= 1)
        {
            Console.WriteLine("Không phải là số nguyên tố");
            return;
        }
        for (uint i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine("Không phải là số nguyên tố");
                return;
            }
        }
        Console.WriteLine("Là số nguyên tố");
    }

    static void CheckPerfectNumber()
    {
        Console.Write("Nhập số nguyên: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 1)
        {
            Console.WriteLine("Không phải là số hoàn hảo");
            return;
        }
        int sum = 0;
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
                sum += i;
        }
        if (sum == n)
            Console.WriteLine("Là số hoàn hảo");
        else
            Console.WriteLine("Không phải là số hoàn hảo");
    }
}
