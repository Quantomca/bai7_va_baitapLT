using System;
using System.IO;
using System.Text;

class FileOperations
{
    // a. Đếm số dòng, số kí tự và số từ trong file Program.cs
    public static int CountLines(string filePath)
    {
        int lineCount = 0;
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.ReadLine() != null)
            {
                lineCount++;
            }
        }
        return lineCount;
    }

    public static int CountCharacters(string filePath, char character)
    {
        int charCount = 0;
        using (StreamReader reader = new StreamReader(filePath))
        {
            int c;
            while ((c = reader.Read()) != -1)
            {
                if ((char)c == character)
                {
                    charCount++;
                }
            }
        }
        return charCount;
    }

    public static int CountWords(string filePath)
    {
        int wordCount = 0;
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                wordCount += words.Length;
            }
        }
        return wordCount;
    }

    // b. Đọc và ghi file UTF-8
    public static void ReadWriteUtf8(string readFilePath, string writeFilePath)
    {
        using (StreamReader reader = new StreamReader(readFilePath, Encoding.UTF8))
        using (StreamWriter writer = new StreamWriter(writeFilePath, false, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line);
            }
        }
    }

    // c. Đọc và ghi file UTF-16
    public static void ReadWriteUtf16(string readFilePath, string writeFilePath)
    {
        using (StreamReader reader = new StreamReader(readFilePath, Encoding.Unicode))
        using (StreamWriter writer = new StreamWriter(writeFilePath, false, Encoding.Unicode))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line);
            }
        }
    }

    // d. Ghi và đọc file nhị phân
    public static void WriteBinaryFile(string filePath, double[,] data)
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);
            writer.Write(rows);
            writer.Write(cols);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    writer.Write(data[i, j]);
                }
            }
        }
    }

    public static double[,] ReadBinaryFile(string filePath)
    {
        using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
        {
            int rows = reader.ReadInt32();
            int cols = reader.ReadInt32();
            double[,] data = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    data[i, j] = reader.ReadDouble();
                }
            }
            return data;
        }
    }

    // Ví dụ sử dụng các hàm
    static void Main(string[] args)
    {
        string filePath = "Program.cs";
        char characterToCount = 'a';

        // a. Tính toán số dòng, số kí tự và số từ
        int lines = CountLines(filePath);
        int charCount = CountCharacters(filePath, characterToCount);
        int words = CountWords(filePath);

        Console.WriteLine($"Số dòng: {lines}");
        Console.WriteLine($"Số kí tự '{characterToCount}': {charCount}");
        Console.WriteLine($"Số từ: {words}");

        // b. Đọc và ghi file UTF-8
        ReadWriteUtf8("vd1_read.txt", "vd1_ghi.txt");

        // c. Đọc và ghi file UTF-16
        ReadWriteUtf16("vd1_read.txt", "vd1_ghi.txt");

        // d. Ghi và đọc file nhị phân
        double[,] dataToWrite = {
            { 1.1, 2.2, 3.3 },
            { 4.4, 5.5, 6.6 }
        };

        WriteBinaryFile("a2d.dat", dataToWrite);

        double[,] dataRead = ReadBinaryFile("a2d.dat");

        Console.WriteLine("Dữ liệu đọc từ file nhị phân:");
        for (int i = 0; i < dataRead.GetLength(0); i++)
        {
            for (int j = 0; j < dataRead.GetLength(1); j++)
            {
                Console.Write(dataRead[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
