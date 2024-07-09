using System;
using System.Collections.Generic;

public abstract class Person
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    private string _id;
    public string Id
    {
        get { return _id; }
        set
        {
            if (value.Length == 8 && IsNumeric(value))
            {
                _id = value;
            }
            else
            {
                throw new ArgumentException("ID must be 8 characters long and consist of digits.");
            }
        }
    }

    private bool IsNumeric(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
}

public interface Kpi
{
    float kpi();
}

public class Student : Person, Kpi
{
    private string _department;
    public string Department
    {
        get { return _department; }
        set
        {
            if (value == "ICT" || value == "ECO")
            {
                _department = value;
            }
            else
            {
                throw new ArgumentException("Department must be either 'ICT' or 'ECO'.");
            }
        }
    }

    public float kpi()
    {
        // Assume GPA calculation logic here
        return 3.5f; // Dummy value for demonstration
    }
}

class Program
{
    static void Main()
    {
        List<Person> list1 = new List<Person>();
        List<Person> list2 = new List<Person>();
        List<List<Person>> list_list = new List<List<Person>>();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add students to list1 (stop by entering # for name)");
            Console.WriteLine("2. Add students to list2 (stop by entering # for name)");
            Console.WriteLine("3. Display list1 and list2");
            Console.WriteLine("4. Display list_list");
            Console.WriteLine("5. Create dictionary dict1 from list1 and find students with name 'Nam'");
            Console.WriteLine("6. Exit");

            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Adding students to list1:");
                    AddStudentsToList(list1);
                    break;
                case "2":
                    Console.WriteLine("Adding students to list2:");
                    AddStudentsToList(list2);
                    break;
                case "3":
                    Console.WriteLine("\nList 1:");
                    DisplayList(list1);
                    Console.WriteLine("\nList 2:");
                    DisplayList(list2);
                    break;
                case "4":
                    Console.WriteLine("\nList of Lists:");
                    list_list.Clear();
                    list_list.Add(new List<Person>(list1));
                    list_list.Add(new List<Person>(list2));
                    DisplayListList(list_list);
                    break;
                case "5":
                    Console.WriteLine("\nStudents with name 'Nam' in dict1:");
                    Dictionary<string, Student> dict1 = CreateDictionary(list1);
                    DisplayStudentsWithNam(dict1);
                    break;
                case "6":
                    Console.WriteLine("Exiting program.");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please select again.");
                    break;
            }
        }
    }

    static void AddStudentsToList(List<Person> list)
    {
        while (true)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            if (name == "#")
                break;

            Console.Write("ID: ");
            string id = Console.ReadLine();

            Console.Write("Department (ICT or ECO): ");
            string department = Console.ReadLine();

            try
            {
                Person student = new Student
                {
                    Name = name,
                    Id = id,
                    Department = department
                };
                list.Add(student);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    static void DisplayList(List<Person> list)
    {
        foreach (var student in list)
        {
            Console.WriteLine($"{student.Name} - {student.Id} - {(student as Student).Department}");
        }
    }

    static void DisplayListList(List<List<Person>> list_list)
    {
        foreach (var list in list_list)
        {
            foreach (var student in list)
            {
                Console.WriteLine($"{student.Name} - {student.Id} - {(student as Student).Department}");
            }
            Console.WriteLine();
        }
    }

    static Dictionary<string, Student> CreateDictionary(List<Person> list)
    {
        Dictionary<string, Student> dict = new Dictionary<string, Student>();
        foreach (var student in list)
        {
            if (student is Student)
            {
                dict.Add((student as Student).Id, student as Student);
            }
        }
        return dict;
    }

    static void DisplayStudentsWithNam(Dictionary<string, Student> dict)
    {
        foreach (var student in dict.Values)
        {
            if (student.Name.Contains("Nam"))
            {
                Console.WriteLine($"{student.Name} - {student.Id} - {student.Department}");
            }
        }
    }
}

