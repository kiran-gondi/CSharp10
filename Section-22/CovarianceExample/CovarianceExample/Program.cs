using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceExample
{
  internal class Program
  {
    class LivingThing
    {
      public int NoOfLegs { get; set; }
    }

    class Parrot : LivingThing
    {

    }

    class Dog : LivingThing
    {

    }

    interface IMover<out T>
    {
      T Move();
    }

    class Mover<T> : IMover<T>
    {
      public T thing { get; set; }
      public T Move()
      {
        return thing;
      }
    }

    class Sample
    {
      public void PrintValues(IEnumerable<object> values)
      {
        foreach (string value in values)
        {
          Console.Write(value + ",");
        }
        Console.ReadKey();
      }
    }

    static void Main(string[] args)
    {
      //create object 
      LivingThing livingThing = new Parrot(); //not covariance
      Parrot p = new Parrot() { NoOfLegs = 2 }; //normal

      //Covariance = supply the child type name, where the parent type name is expected.
      IMover<LivingThing> mover = new Mover<Parrot>() { thing = p };
      //"LivingThing" vs "Parrot" supply the child type(Bird), where the parent type (LivingThing) is expected.
      Console.WriteLine("Moving with " + mover.Move().NoOfLegs);

      //Covariance in real life
      Sample s = new Sample();
      s.PrintValues(new List<string> { "hello", "hi" });


      Console.ReadKey();
    }
  }
}
