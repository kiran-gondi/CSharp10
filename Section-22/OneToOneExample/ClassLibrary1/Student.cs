using System;

namespace CollegeObjectRelations
{
  public class Student
  {
      public int RollNo { get; set; }
      public string StudentName { get; set; }
      public string Email { get; set; }

      public Branch Branch { get; set; } //Contains reference to object of Branch class,
                                         //that represents the branch that the current student belongs to.

      public override string ToString()
      {
        Console.WriteLine("Demo for one-on-one object relationship");
        Console.WriteLine("Student details below:");
        return "Roll no: " + RollNo + "\nName: " + StudentName + "\nEmail: " + Email +
                "\nBranch is: " + Branch.BranchName + " - with " + Branch.NoOfSemesters + " Semesters";
      }
  }
}