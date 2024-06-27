using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create reference variable for List class & //create object of List class
      List<int> myList = new List<int>(5) { 1, 2, 3, 4, 5 };

      //add new element at the end of existing collection
      myList.Add(111);

      //another collection
      List<int> otherCollection = new List<int>() { 6, 7, 8, 9 }; 

      //adding another collection to the existing collection
      myList.AddRange(otherCollection);

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
