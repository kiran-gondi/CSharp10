using ClassLibrary1;

namespace InnerClasseExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create an object of inner class
      ClassLibrary1.MarksCalculation.CalclulationHelper ch = new MarksCalculation.CalclulationHelper();

      //call the inner class's method
      //Console.WriteLine(ch.Multiply(20, 3));

      //call outer class's method
      ClassLibrary1.MarksCalculation mc = new MarksCalculation();
      Student s = new Student() {SecuredMarks = 70, MaxMarks = 100 };
      mc.CalculatePercentage(s);
      Console.WriteLine(s.Percentage.ToString());

      Console.ReadKey();
    }
  }
}
