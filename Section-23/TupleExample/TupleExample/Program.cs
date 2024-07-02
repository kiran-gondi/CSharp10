using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExample
{
  class Sample
  {
    public Tuple<string, int> GetPersonDetails()
    {
      //create a new Tuple that stores person name and age
      Tuple<string, int> person = new Tuple<string, int>("Scott", 12);
      return person;
    }
  }

  internal class Program
  {
    static void Main()
    {
      //create a new Tuple that stores person name and age
      //Tuple<string, int> person = new Tuple<string, int>("Scott", 12);

      //access values from tuple
      //Console.WriteLine(person.Item1);
      //Console.WriteLine(person.Item2);

      Sample sample = new Sample();
      Tuple<string, int> p = sample.GetPersonDetails();
      Console.WriteLine(p.Item1);
      Console.WriteLine(p.Item2);

      Console.ReadKey();
    }
  }
}
