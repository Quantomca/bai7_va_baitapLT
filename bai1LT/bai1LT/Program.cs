using System;
using System.Text;

namespace UniversityAdmission
{
    // Bước 1: Tạo lớp ngoại lệ tùy chỉnh
    public class AgeOutOfRangeException : Exception
    {
        public AgeOutOfRangeException(string message) : base(message)
        {
        }
    }

    class Program
    {
        // Bước 2: Viết phương thức kiểm tra độ tuổi
        static void CheckAgeForAdmission(int age)
        {
            if (age < 18 || age > 25)
            {
                throw new AgeOutOfRangeException("Tuổi phải nằm trong khoảng từ 18 đến 25 để đủ điều kiện nhập học.");
            }
            else
            {
                Console.WriteLine("Học sinh đủ điều kiện để nhập học.");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                // Bước 3: Nhập tuổi và kiểm tra
                Console.Write("Nhập tuổi của học sinh: ");
                int age = int.Parse(Console.ReadLine());

                CheckAgeForAdmission(age);
            }
            catch (AgeOutOfRangeException ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên hợp lệ.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi không xác định: {ex.Message}");
            }
        }
    }
}
