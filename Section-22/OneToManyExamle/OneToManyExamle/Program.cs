using CollegeOneToMany;
using System;

namespace OneToManyExamle
{
  internal class Program
  {
    static void Main(string[] args)
    {

      //create object of Student
      Student student = new Student();
      student.RollNo = 1;
      student.StudentName = "Rom";
      student.Email = "test@one.com";
      student.Examinations = new System.Collections.Generic.List<Examination>();
      student.Examinations.Add(new Examination { ExaminationName = "test1", Month = 5, MaxMarks = 100, SecuredMarks = 20, Year = 2021 });
      student.Examinations.Add(new Examination { ExaminationName = "test2", Month = 2, MaxMarks = 100, SecuredMarks = 22, Year = 2022 });
      student.Examinations.Add(new Examination { ExaminationName = "test3", Month = 3, MaxMarks = 100, SecuredMarks = 23, Year = 2023 });

      //print
      Console.WriteLine("Roll no: " + student.RollNo);
      Console.WriteLine("Student Name: " + student.StudentName);
      Console.WriteLine("Email: " + student.Email);
      foreach (var examination in student.Examinations) { 
        Console.WriteLine(examination.ExaminationName + ", " + examination.Year + ", " 
          + examination.SecuredMarks + "/" + examination.MaxMarks);
      }


      Console.ReadKey();
    }
  }
}
