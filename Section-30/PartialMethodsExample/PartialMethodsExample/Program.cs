using PartialMethodsExample;

public class Program
{
  static void Main()
  {
    Student student = new Student();
    student.StudentID = 001;

    Console.WriteLine(student.StudentID);
    Console.WriteLine(student.GetStudentId());

    Console.ReadKey();
  }
}