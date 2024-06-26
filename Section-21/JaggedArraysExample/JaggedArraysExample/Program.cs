using System;

namespace JaggedArraysExample
{
  internal class Program
  {
    static void Main(string[] args)
    {

      //create jagged arrays
      int[][] a = new int[5][];
      a[0] = new int[3] { 10, 11, 12 };
      a[1] = new int[4] { 20, 21, 22, 23 };
      a[2] = new int[5] { 30, 31, 32, 33, 34 };
      a[3] = new int[2] { 40, 41 };
      a[4] = new int[1] { 50 };

      //read jagged array
      for (int i = 0; i < 5; i++) {
        for (int j = 0; j < a[i].Length; j++) {
          Console.Write(a[i][j]);
          Console.Write(" ");
        }
        Console.WriteLine();
      }

      Console.ReadKey();
    }
  }
}
