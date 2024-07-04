using System;
using System.IO;

namespace Exercise30
{
    public class array_float_2d
    {
        public static float[,] nhapmangfloat2d(int m, int n)
        {
            float[,] arr = new float[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = EditNumbers.nhapsothuc4byte();
                }
            }

            return arr;
        }

        public static void hienthimangfloat2d(float[,] arr)
        {
            Console.WriteLine("Mảng 2 chiều số thực:");
            int m = arr.GetLength(0);
            int n = arr.GetLength(1);

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void ghimang2dfloat_file_csv(float[,] arr, string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    int m = arr.GetLength(0);
                    int n = arr.GetLength(1);

                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            sw.Write(arr[i, j]);
                            if (j < n - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }

                Console.WriteLine($"Đã ghi mảng vào file {fileName} thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }
        }

        public static float[,] docmang2dfloattufilecsv(string fileName)
        {
            float[,] arr = null;

            try
            {
                string[] lines = File.ReadAllLines(fileName);
                int m = lines.Length;
                int n = lines[0].Split(',').Length;
                arr = new float[m, n];

                for (int i = 0; i < m; i++)
                {
                    string[] line = lines[i].Split(',');
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = float.Parse(line[j]);
                    }
                }

                Console.WriteLine($"Đọc mảng từ file {fileName} thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            return arr;
        }
    }
}
