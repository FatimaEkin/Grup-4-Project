namespace App.Domain;

public class StudentList
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
