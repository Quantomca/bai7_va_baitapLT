using System;
using System.Text;

class bài49
{
    // Hàm generic static để tìm giá trị nhỏ nhất trong mảng
    public static T FindMinValue<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Mảng không được rỗng.");
        }

        T minValue = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(minValue) < 0)
            {
                minValue = item;
            }
        }
        return minValue;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        dynamic min_value;

        while (true)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Tìm giá trị nhỏ nhất trong mảng số nguyên 4 byte");
            Console.WriteLine("2. Tìm giá trị nhỏ nhất trong mảng số nguyên không dấu 4 byte");
            Console.WriteLine("3. Tìm giá trị nhỏ nhất trong mảng số thực 4 byte");
            Console.WriteLine("4. Tìm giá trị nhỏ nhất trong mảng số thực 8 byte");
            Console.WriteLine("5. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {
                        int[] intArray = { 10, 20, 5, 30, 15 };
                        min_value = FindMinValue(intArray);
                        Console.WriteLine("Giá trị nhỏ nhất trong mảng số nguyên 4 byte: " + min_value.ToString());
                    }
                    break;
                case "2":
                    {
                        uint[] uintArray = { 10, 20, 5, 30, 15 };
                        min_value = FindMinValue(uintArray);
                        Console.WriteLine("Giá trị nhỏ nhất trong mảng số nguyên không dấu 4 byte: " + min_value.ToString());
                    }
                    break;
                case "3":
                    {
                        float[] floatArray = { 10.5f, 20.2f, 5.1f, 30.3f, 15.4f };
                        min_value = FindMinValue(floatArray);
                        Console.WriteLine("Giá trị nhỏ nhất trong mảng số thực 4 byte: " + min_value.ToString());
                    }
                    break;
                case "4":
                    {
                        double[] doubleArray = { 10.5, 20.2, 5.1, 30.3, 15.4 };
                        min_value = FindMinValue(doubleArray);
                        Console.WriteLine("Giá trị nhỏ nhất trong mảng số thực 8 byte: " + min_value.ToString());
                    }
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }
}

