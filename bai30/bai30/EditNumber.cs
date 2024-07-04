using System;

namespace Exercise30
{
    public class EditNumbers
    {
        public static int nhapsonguyenduong()
        {
            int n = 0;
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhập số nguyên dương:");
                    n = int.Parse(Console.ReadLine());

                    if (n <= 0)
                        throw new FormatException();

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bạn đã nhập sai định dạng! Vui lòng nhập lại.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }

            return n;
        }

        public static float nhapsothuc4byte()
        {
            float f = 0.0f;
            while (true)
            {
                try
                {
                    Console.WriteLine("Nhập số thực 4 byte:");
                    f = float.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bạn đã nhập sai định dạng! Vui lòng nhập lại.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }

            return f;
        }
    }
}
