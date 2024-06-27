using System;
using System.Collections.Generic;


namespace ListExample
{
  internal class Program
  {
    static void Main()
    {
      //create reference variable for List class
      List<int> myList;

      //create object of List class
      myList = new List<int>(7) { 1, 2, 3, 4, 5 };

      //read elements using foreach loop
      Console.WriteLine("Using foreach loop:");
      foreach (int item in myList)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine();
      Console.WriteLine("Using for loop:");
      for (int i = 0; i < myList.Count; i++) 
      {
        Console.WriteLine(myList[i]);
      }

      Console.WriteLine("\nReverse printing:");
      for (int i = myList.Count-1; i >= 0; i--) {
        Console.WriteLine(myList[i]);
      }

      Console.ReadKey();
    }
  }
}
