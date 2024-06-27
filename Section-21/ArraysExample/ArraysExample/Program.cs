using System;

namespace ArraysExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create an array
      int[] a = new int[5] { 10, 20, 30, 40, 50 };
      string[] b = new string[5] { "demo1", "demo2", "demo3", "demo4", "demo5" };

      //display the values of elements
      //Console.WriteLine(a[0]);
      //Console.WriteLine(a[1]);
      //Console.WriteLine(a[2]);
      //Console.WriteLine(a[3]);
      //Console.WriteLine(a[4]);
      //Console.WriteLine();
      //Console.WriteLine(b[0]);
      //Console.WriteLine(b[1]);
      //Console.WriteLine(b[2]);
      //Console.WriteLine(b[3]);
      //Console.WriteLine(b[4]);
      //Console.WriteLine();

      //display the values of elements
      //for (int i = 0; i < b.Length; i++) 
      //{ 
      //  Console.WriteLine(b[i]);
      //}

      //foreach (string i in b) {
      //  Console.WriteLine(i);
      //}

      //reverse
      for (int i = b.Length - 1; i >= 0; i--) {
        Console.WriteLine(b[i]);
      }

      Console.ReadKey();
    }
  }
}
