namespace DynamicallyTypedVariablesExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //dynamically typed variable
      dynamic x;

      x = 10;

      x = "Hello";

      x = new Student() { Id = 123, Name = "Ramu" };

      //Console.WriteLine(x.StudentName); Runtime error or exception
      Console.WriteLine(x.Name);
      Console.WriteLine(x.Id);

      Console.ReadKey();
    }
  }

  internal class Student
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public Student()
    {
    }
  }
}
