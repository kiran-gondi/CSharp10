using ClassLibrary1;
using System;

namespace ExpressoinBodiedMembersExamples
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //created student object
      Student s = new Student() { StudentName = "Robbie" };

      Console.WriteLine(s.StudentName);
      Console.WriteLine(s.GetStudentNameLength());

      Console.ReadKey();
    }
  }
}
