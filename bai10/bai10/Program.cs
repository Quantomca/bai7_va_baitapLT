using System;
using System.Text;

struct Student
{
    public string Name;
    public float Score;
}

class bai10
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine());

        Student[] students = new Student[n];

        // Nhập thông tin của từng sinh viên
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhập thông tin sinh viên thứ {i + 1}:");
            Console.Write("Tên: ");
            students[i].Name = Console.ReadLine();
            Console.Write("Điểm: ");
            students[i].Score = float.Parse(Console.ReadLine());
        }

        // Hiển thị thông tin của từng sinh viên
        Console.WriteLine("\nThông tin của từng sinh viên:");
        foreach (var student in students)
        {
            Console.WriteLine($"Tên: {student.Name}, Điểm: {student.Score}");
        }

        // Tính điểm trung bình của cả lớp
        float totalScore = 0;
        foreach (var student in students)
        {
            totalScore += student.Score;
        }
        float averageScore = totalScore / n;
        Console.WriteLine($"\nĐiểm trung bình của cả lớp: {averageScore}");
    }
}