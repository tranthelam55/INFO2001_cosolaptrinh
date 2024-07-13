using System;
using System.Collections.Generic;

class Student
{
    public string ID { get; set; }
    public double GPA { get; set; }
}

class bai48
{
    static void Main()
    {
        var dict1 = new Dictionary<string, double>();
        List<Student> students = new List<Student>();

        while (true)
        {
            Console.Write("Enter Student ID (or '#' to stop): ");
            string id = Console.ReadLine();

            if (id == "#")
                break;

            Console.Write("Enter Student GPA: ");
            if (double.TryParse(Console.ReadLine(), out double gpa) && gpa >= 0 && gpa <= 4.0)
            {
                students.Add(new Student { ID = id, GPA = gpa });
                dict1[id] = gpa;
            }
            else
            {
                Console.WriteLine("Invalid GPA. Skipping this student.");
            }
        }

        Console.WriteLine("\nStudent list:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.ID}, GPA: {student.GPA}");
        }

        // Lấy điểm trung bình của sinh viên có ID "123456"
        if (dict1.TryGetValue("123456", out double avgGPA))
        {
            Console.WriteLine($"\nAverage GPA of student with ID '123456': {avgGPA}");
        }
        else
        {
            Console.WriteLine("\nStudent with ID '123456' not found in the dictionary.");
        }
    }
}
