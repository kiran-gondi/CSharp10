using System;
using System.Collections.Generic;

namespace InsertExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create reference variable for List class & //create object of List class
      List<int> myList = new List<int>(5) { 1, 2, 3, 4, 5 };

      //insert element at position 1
      myList.Insert(1, 101);

      //another list
      List<int> anotherList = new List<int> { 11, 22, 33 };

      //insert another list by an index position of 4
      myList.InsertRange(4, anotherList);

      //read elements using foreach loop
      Console.WriteLine("Using foreach loop:");
      foreach (int item in myList)
      {
        Console.WriteLine(item);
      }

      Console.ReadKey();

    }
  }
}
