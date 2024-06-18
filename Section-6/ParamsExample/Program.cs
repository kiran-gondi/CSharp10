namespace ParamsExample
{
  class Student
  {
    public void DisplaySubjects(params string[] subjects)
    {
      //Console.WriteLine(subjects[0]);
      //Console.WriteLine(subjects[1]);
      //Console.WriteLine(subjects[2]);
      //Console.WriteLine(subjects[3]);
      foreach (var subject in subjects)
      {
        Console.WriteLine(subject);
      }
    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      Student student = new Student();  

      student.DisplaySubjects("EC", "CS", "M1", "M4", "D1", "EC11");

      Console.ReadKey();
    }
  }
}
