using System;

namespace IndexOfExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create array
      double[] a = new double[5] { 10, 20, 30, 40 ,40 };

      //search for 40 in the array
      int n1 = Array.IndexOf(a, 40);
      Console.WriteLine("40 is found at " + n1);

      //search for 40 in the array (second occurrence)
      int n2 = Array.IndexOf(a, 40, 4);
      Console.WriteLine("40 is found at " + n2);

      //search for 100 in the array (not exists)
      int n3 = Array.IndexOf(a, 100, 4);
      Console.WriteLine("100 is found at " + n3);

      Console.ReadKey(); 
    }
  }
}
