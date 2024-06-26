using System;

namespace ArraySortExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] a = new int[5] { 50, 40, 30, 20, 10 };

      Array.Sort(a);

      foreach (int i in a)
      {
        Console.WriteLine(i);
      }

      Console.ReadKey();
    }
  }
}
