using ClassLibrary1;

namespace PatternMatchingExmaple
{
  class Program
  {
    static void Main()
    {
      //reference variable of parent class
      ParentClass pc;

      //object of child class
      pc = new ChildClass() { x = 10, y = 20 };

      //access parent class's members
      //Console.WriteLine(pc.x);

      //Old way
      //if (pc is ChildClass) { 
      //  ChildClass cc = (ChildClass)pc;
      //  Console.WriteLine(cc.x);
      //  Console.WriteLine(cc.y);
      //}

      //C# PatternMatching
      if(pc is ChildClass cc)
      {
        Console.WriteLine(cc.x + " & " + cc.y);
      }

      Console.ReadKey();
    }
  }
}
