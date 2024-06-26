using System;

namespace SwitchExpressionExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int operation = 43; //1 to 4
      string result;

      //switch expression
      result = operation switch
      {
        1 => "Customer",
        2 => "Employee",
        3 => "Supplier",
        4 => "Distributor",
        _ => "No case available"
      };

      Console.WriteLine(result);
      Console.ReadKey(); 
    }
  }
}
