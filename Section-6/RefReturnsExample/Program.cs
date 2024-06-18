namespace RefReturnsExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Student student = new Student();
      student.PrintGrade();

      //Call DoWork
      ref int g = ref student.DoWork();

      //Update the value of 'ref return'
      g = 5;

      //Call PrintGrade after updating the value of 'ref return'
      student.PrintGrade();//Output is 5

      Console.ReadKey();
    }
  }

  class Student
  {
    public int grade = 2;

    public void PrintGrade()
    {
      Console.WriteLine($"Grade: { grade }");
    }

    //public method with ref return
    public ref int DoWork()
    {
      //return reference of 'grade' field
      return ref grade;
    }

  }

}
