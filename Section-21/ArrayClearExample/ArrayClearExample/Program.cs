using System;

namespace ArrayClearExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create array
      int[] a = new int[] { 10, 20, 30, 40, 50, 60 };

      //clear elements of array
      //Array.Clear(a, 0, a.Length
      Array.Clear(a, 2, 3);

      //display array
      foreach (int item in a) {
        Console.WriteLine(item);
      }

      Console.ReadKey();
    }
  }
}
