using System;

namespace BinarySearchExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create array
      double[] a = new double[5] { 10, 20, 30, 40, 40 };

      //search for 40 in the array
      int n1 = Array.BinarySearch(a, 20);
      Console.WriteLine("20 is found at " + n1);

      //search for 100 in the array (not exists)
      int n3 = Array.BinarySearch(a, 40);
      Console.WriteLine("40 is found at " + n3);

      Console.ReadKey();
    }
  }
}
