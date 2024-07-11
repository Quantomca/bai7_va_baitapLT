using System;
using System.Collections.Generic;
using System.Text;

class Student
{
    public string ID { get; set; }
    public double GPA { get; set; }
}

class bài48
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Dictionary<string, double> dict1 = new Dictionary<string, double>();

        while (true)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Thêm sinh viên");
            Console.WriteLine("2. Tìm điểm trung bình của sinh viên theo ID");
            Console.WriteLine("3. Hiển thị tất cả sinh viên");
            Console.WriteLine("4. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent(dict1);
                    break;
                case "2":
                    FindStudentGPA(dict1);
                    break;
                case "3":
                    DisplayAllStudents(dict1);
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void AddStudent(Dictionary<string, double> dict1)
    {
        while (true)
        {
            Console.Write("Nhập ID của sinh viên (hoặc '#' để dừng): ");
            string id = Console.ReadLine();
            if (id == "#")
            {
                break;
            }

            Console.Write("Nhập điểm trung bình (GPA): ");
            string gpaInput = Console.ReadLine();
            if (double.TryParse(gpaInput, out double gpa) && gpa >= 0 && gpa <= 4.0)
            {
                if (!dict1.ContainsKey(id))
                {
                    dict1.Add(id, gpa);
                    Console.WriteLine($"Đã thêm sinh viên với ID {id} và GPA {gpa}.");
                }
                else
                {
                    Console.WriteLine($"Sinh viên với ID {id} đã tồn tại. Cập nhật GPA.");
                    dict1[id] = gpa;
                }
            }
            else
            {
                Console.WriteLine("Điểm trung bình không hợp lệ. Vui lòng nhập lại.");
            }
        }
    }

    static void FindStudentGPA(Dictionary<string, double> dict1)
    {
        Console.Write("Nhập ID của sinh viên cần tìm: ");
        string searchID = Console.ReadLine();
        if (dict1.TryGetValue(searchID, out double searchGPA))
        {
            Console.WriteLine($"Điểm trung bình của sinh viên có ID {searchID} là: {searchGPA}");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy sinh viên có ID {searchID}.");
        }
    }

    static void DisplayAllStudents(Dictionary<string, double> dict1)
    {
        Console.WriteLine("Danh sách sinh viên:");
        foreach (var kvp in dict1)
        {
            Console.WriteLine($"ID: {kvp.Key}, GPA: {kvp.Value}");
        }
    }
}

