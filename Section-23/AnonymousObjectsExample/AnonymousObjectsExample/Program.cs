using ClassLibrary1;
using System;

namespace AnonymousObjectsExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create object of Person clas
      Person person = new Person();

      //call methods
      //Console.WriteLine(person.GetPersonName());
      //Console.WriteLine(person.GetPersonAge());


      var p1 = new { PersonName = person.GetPersonName(), PersonAge = person.GetPersonAge() };
      Console.WriteLine(p1.PersonName + ", " + p1.PersonAge);

      //p1.PersonName = "rahul";


      Console.ReadKey();
    }
  }
}
