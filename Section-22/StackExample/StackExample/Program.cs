using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
  internal class Program
  {
    class Student
    {
        public int Marks { get; set; }
        public int Rank { get; set; }
    }

    static void Main(string[] args)
    {

      //create object of Stack
      Stack<Student> marks = new Stack<Student>();

      //Push
      marks.Push(new Student() { Marks = 45 });
      marks.Push(new Student() { Marks = 61 });
      marks.Push(new Student() { Marks = 91 });

      //Pop
      //Student su = marks.Pop();
      //Console.WriteLine("Pop: " + su.Marks);

      //Peek
      Student su = marks.Peek();
      Console.WriteLine("Peek: " + su.Marks);

      Console.WriteLine();  

      int r = 1;
      foreach (Student item in marks) {
        item.Rank = r;
        Console.WriteLine(item.Rank + " - " + item.Marks);
        r++;
      }

      Console.ReadKey();
    }
  }
}
