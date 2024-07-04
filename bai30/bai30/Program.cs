//using System;

namespace Exercise30
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bước 30.a
            int m = EditNumbers.nhapsonguyenduong();
            int n = EditNumbers.nhapsonguyenduong();
            float x = EditNumbers.nhapsothuc4byte();

            Console.WriteLine("Giá trị của m: " + m.ToString());
            Console.WriteLine("Giá trị của n: " + n.ToString());
            Console.WriteLine("Giá trị của x: " + x.ToString());

            // Bước 30.b
            float[,] arr = array_float_2d.nhapmangfloat2d(m, n);

            // Bước 30.c
            array_float_2d.hienthimangfloat2d(arr);

            // Bước 30.d
            array_float_2d.ghimang2dfloat_file_csv(arr, "a2d.csv");

            // Bước 30.e
            float[,] arrFromFile = array_float_2d.docmang2dfloattufilecsv("a2d.csv");
            array_float_2d.hienthimangfloat2d(arrFromFile);
        }
    }
}
