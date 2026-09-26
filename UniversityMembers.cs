using System;

namespace UniversityMembers
{
    class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Person(string name, string email)
        {
            Console.WriteLine("Person constructor called");
            Name = name;
            Email = email;
        }

        public void DisplayBasicInfo()
        {
            Console.WriteLine("Name: " + Name + ", Email: " + Email);
        }
    }

    class Student : Person
    {
        public int StudentId { get; set; }
        public double GPA { get; set; }

        public Student(string name, string email, int studentId, double gpa) 
            : base(name, email)
        {
            Console.WriteLine("Student constructor called");
            StudentId = studentId;
            GPA = gpa;
        }

        public void DisplayStudentData()
        {
            Console.WriteLine("Student ID: " + StudentId + ", GPA: " + GPA);
        }
    }

    class Employee : Person
    {
        public int EmployeeId { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string email, int employeeId, double salary) 
            : base(name, email)
        {
            Console.WriteLine("Employee constructor called");
            EmployeeId = employeeId;
            Salary = salary;
        }

        public void DisplayEmployeeData()
        {
            Console.WriteLine("Employee ID: " + EmployeeId + ", Salary: " + Salary);
        }
    }

    class Teacher : Employee
    {
        public string CourseName { get; set; }

        public Teacher(string name, string email, int employeeId, double salary, string courseName) 
            : base(name, email, employeeId, salary)
        {
            Console.WriteLine("Teacher constructor called");
            CourseName = courseName;
        }

        public void Teach()
        {
            Console.WriteLine(Name + " is teaching " + CourseName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Testing Student ---");
            Student s1 = new Student("Ahmed Ali", "ahmed@univ.edu", 44101, 3.75);
            s1.DisplayBasicInfo();
            s1.DisplayStudentData();

            Console.WriteLine("\n--- Testing Teacher ---");
            Teacher t1 = new Teacher("Dr. Khaled", "khaled@univ.edu", 9021, 5000.0, "Object Oriented Programming");
            t1.DisplayBasicInfo();
            t1.DisplayEmployeeData();
            t1.Teach();
        }
    }
}
