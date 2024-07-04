using bai32;
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Person obs = new Student { Name = "Nguyễn Văn Nam", Major = "ICT" };

        if (obs is Student student)
        {
            student.kpi();
            Console.WriteLine($"Student Name: {student.Name}, Major: {student.Major}");
        }
        else
        {
            Console.WriteLine("The object is not a Student.");
        }
    }
}
