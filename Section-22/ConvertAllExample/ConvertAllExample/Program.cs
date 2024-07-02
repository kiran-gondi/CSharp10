using System;
using System.Collections.Generic;

namespace ConvertAllExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create source collection
      List<int> intCollection = new List<int>() { 1, 2, 4 };


      //read each value into lambda expression; convert the same value into string
      List<string> resultCollection = intCollection.ConvertAll<string>((n) =>
      {
        string resultWord;

        switch (n)
        {
          case 1: resultWord = "One"; break;
          case 2: resultWord = "Two"; break;
          case 4: resultWord = "Four"; break;
          default: resultWord = "default"; break;
        }
        return resultWord;
      });


      //print the list
      foreach (var item in resultCollection) { 
        Console.WriteLine(item);
      }

      Console.ReadKey();
    }
  }
}
