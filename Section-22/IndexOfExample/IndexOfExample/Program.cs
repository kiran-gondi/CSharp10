using System;
using System.Collections.Generic;

namespace IndexOfExample
{
  internal class Program
  {
    static void Main(string[] args)
    {

      //collection
      List<int> myList = new List<int>() { 10, 20, 30, 40, 50, 40};

      //search for 40
      int ind = myList.IndexOf(40);
      Console.WriteLine("40 is found at " + ind);

      //search for 100
      int n = myList.IndexOf(100);
      if (n >= 0)
        Console.WriteLine("100 is fount at " + n);
      else
        Console.WriteLine("100 is not found");

      //search for second occurence of 40
      int n1 = myList.IndexOf(40, ind + 1);
      if (n1 >= 0)
        Console.WriteLine("second occurence of 40 is found at " + n1);
      else
        Console.WriteLine("second occurence of 40 is nots found");

      Console.WriteLine("\nBinary Search");
      //Collection for binary search
      List<int> myList2 = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
      int n2 = myList2.BinarySearch(80);
      Console.WriteLine("Binary search of 80: " + n2);

      Console.WriteLine("\n Contains");
      //contains
      bool b = myList2.Contains(110);
      Console.WriteLine("110 is found in myList2:" + b);

      bool b1 = myList2.Contains(20);
      Console.WriteLine("20 is found in myList2:" + b1);

      Console.ReadKey();
    }
  }
}
