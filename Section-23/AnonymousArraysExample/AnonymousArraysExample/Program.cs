using System;

namespace AnonymousArraysExample
{
  internal class Program
  {
    static void Main(string[] args)
    {

      //create anonymous array/implicitly typed array
      var persons = new[] { 
        new {PersonName = "bob", Email = "Bob@one.com"},
        new {PersonName = "bob1", Email = "Bob1@one.com"},
        new {PersonName = "bob2", Email = "Bob2@one.com"},
      };

      //foreach
      foreach (var person in persons) {
        Console.WriteLine(person.PersonName + " - " + person.Email);
      }

      Console.ReadKey();
    }
  }
}
