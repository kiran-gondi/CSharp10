using System;
using System.Collections.Generic;

namespace HashSetExample
{
  internal class Program
  {
    static void Main(string[] args)
    {

      //create an object of HashSet
      HashSet<string> messages = new HashSet<string> { 
      "Good Morning", "How are you?", "Have a good day" 
      };

      //Add
      messages.Add("Hello World");

      //Remove
      //messages.Remove("Have a good day");
      //messages.RemoveWhere(x => x.Contains("Have a good day"));
      messages.RemoveWhere(x => x.EndsWith("good day"));

      //Count
      Console.WriteLine("Count: " + messages.Count);

      Console.WriteLine("");
      //foreach
      foreach (string message in messages) { 
        Console.WriteLine(message);
      }

      //Search
      bool b = messages.Contains("Good Morning");
      Console.WriteLine("\nSearching with Contains:" + b);


      Console.ReadKey();
    }
  }
}
