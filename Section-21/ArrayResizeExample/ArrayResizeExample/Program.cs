using System;

namespace ArrayResizeExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create array
      int[] a = new int[3] { 10, 20, 30 };

      //resize array to 5
      //Array.Resize(ref a, 5);

      //resize array to 2
      Array.Resize(ref a, 2);

      //print array
      foreach (int i in a)
      {
        Console.WriteLine(i);
      }

      Console.ReadKey();
    }
  }
}
