namespace LocalFunctionsExample
{

  class Student
  {

    public void DisplayMarks(int marks1, int marks2, int marks3)
    {
      double avgMarks = getAverageMarks();
      Console.WriteLine($"Marks1: {marks1}");
      Console.WriteLine($"Marks2: {marks2}");
      Console.WriteLine($"Marks3: {marks3}");

      Console.WriteLine($"Average marks: { avgMarks }");

      //create local function
      double getAverageMarks()
      {
        double avg;
        avg = (double)(marks1 + marks2 + marks3) / 3;
        return avg;
      }
    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      Student student = new Student();

      student.DisplayMarks(80, 45, 71);

      Console.ReadKey();
    }
  }
}
