using System;
using System.Collections.Generic;

namespace RemoveExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create reference variable for List class & //create object of List class
      List<int> myList = new List<int>(5) { 1, 2, 3, 4, 5 };

      //remove 3
      //myList.Remove(3);

      //remove with index 2
      //int ind = 2;
      //if (ind < myList.Count)
      //{
      //  myList.RemoveAt(ind);
      //  Console.Write("Removed");
      //}

      //remove range starts from index 1; count is: 2 elements
      //myList.RemoveRange(1, 2);

      //removeall the odd no's
      //myList.RemoveAll(x => x % 2 != 0);

      //clear all
      myList.Clear();

      //read elements using foreach loop
      Console.WriteLine("Using foreach loop:");

      if (myList.Count == 0) {
        Console.WriteLine("Hey! My List is empty");
      }
      else { 
        foreach (int item in myList)
        {
          Console.WriteLine(item);
        }
      }

      Console.ReadKey();

    }
  }
}
