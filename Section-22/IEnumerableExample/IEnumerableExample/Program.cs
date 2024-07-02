using System;
using System.Collections.Generic;

namespace IEnumerableExample
{
  internal class Program
  {
    static void Main(string[] args)
    {

      //create a collection
      IEnumerable<string> messages;
      messages = new List<string>() { "Hi", "Hello", "World", "Hello World" };

      //foreach
      Console.WriteLine("IEnumerable: ");
      foreach (string message in messages) { 
        Console.WriteLine(message);
      }

      Console.WriteLine();

      //IEnumerator
      IEnumerator<string> enumerator = messages.GetEnumerator();
      enumerator.Reset();
      while (enumerator.MoveNext())
      {
        Console.WriteLine(enumerator.Current);
      }
      //Console.WriteLine(enumerator.Current);//Hi
      //enumerator.MoveNext();
      //Console.WriteLine(enumerator.Current);//Hello

      Console.ReadKey();
    }
  }
}
