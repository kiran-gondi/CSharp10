using System;
using System.Linq.Expressions;

namespace ExpressionTreeExample
{
  class Student
  {
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      ////Create expression tree with Func
      //Expression<Func<int, int>> expression = a => a * a;

      ////Compile expression using Complile method to invoke i as Delegate
      //Func<int, int> myDelegate = expression.Compile();

      ////Execute the method
      //int result = myDelegate.Invoke(10);

      //Console.WriteLine(result);

      //Create object of Student class
      Student s = new Student() { StudentId = 101, StudentName = "Rob", Age = 15 };

      //Create expression tree with Func
      Expression<Func<Student, bool>> expression = st => st.Age > 12 && st.Age <20;

      //Compile expression using Complile method to invoke i as Delegate
      Func<Student, bool> myDelegate = expression.Compile();

      //Execute the method
      bool result = myDelegate.Invoke(s);

      Console.WriteLine(result);

      Console.ReadKey();
    }
  }
}
