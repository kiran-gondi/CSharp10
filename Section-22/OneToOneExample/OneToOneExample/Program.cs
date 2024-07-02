using System;
using CollegeObjectRelations;

namespace OneToOneExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create a student object
      Student student = new Student();
      student.RollNo = 1;
      student.StudentName = "Bob";
      student.Email = "Bob@one.com";

      //Branch class's object
      Branch branch = new Branch();
      branch.BranchName = "EE";
      branch.NoOfSemesters = 8;

      //one-to-one relation
      student.Branch = branch;

      //Display
      Console.WriteLine(student.ToString());

      Console.ReadKey();
    }
  }
}
