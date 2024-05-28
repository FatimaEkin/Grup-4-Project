

using System;

namespace StudentListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentList studentList = new StudentList();

            while (true)
            {
                Console.WriteLine("1. Öğrenci ekle");
                Console.WriteLine("2. Öğrenci Sil");
                Console.WriteLine("3. Tüm öğrencileri görüntüle");
                Console.WriteLine("4. Çıkış");
                Console.Write("Bir seçenek seçin: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Öğrenci Adı : ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Öğrenci Soyadı: ");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Öğrenci Numarası: ");
                        int studentNumber = Convert.ToInt32(Console.ReadLine());

                        Student newStudent = new Student
                        {
                            Name = name,
                            Surname = surname,
                            StudentNumber = studentNumber
                        };

                        studentList.AddStudent(newStudent);
                        Console.WriteLine("Student added successfully.");
                        break;

                    case "2":
                        Console.WriteLine("Enter student number to remove: ");
                        int studentNumberToRemove = Convert.ToInt32(Console.ReadLine());
                        // Öğrenci silme işlemi burada gerçekleştirilir.
                        break;

                    case "3":
                        Console.WriteLine("All Students:");
                        studentList.DisplayAllStudents();
                        break;

                    case "4":
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int StudentNumber { get; set; }
    }

    class StudentList
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void DisplayAllStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Surname: {student.Surname}, Student Number: {student.StudentNumber}");
            }
        }
    }
}