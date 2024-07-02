using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContravarianceExample
{
  class LivingThing
  {
    public int NoOfLegs { get; set; }
  }

  class Parrot : LivingThing{
    
  }

  class Dog : LivingThing
  {

  }

  interface IMover<in T>
  {
    void Move(T x);
  }

  public class Mover<T> : IMover<T>
  {
    public void Move(T x)
    {
      if(x is Parrot)
        Console.WriteLine("Moving with " + (x as Parrot).NoOfLegs + " legs");
      else
        Console.WriteLine("Moving with " + (x as Dog).NoOfLegs + " legs");
    }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      //create normal object
      Parrot parrot = new Parrot() { NoOfLegs = 2 };
      Dog dog = new Dog() { NoOfLegs = 4 };
      
      //Contravariance = supply the parenttype name, where the child type name is expected.
      IMover<Parrot> obj1 = new Mover<Parrot>();//normal
      IMover<Parrot> obj2 = new Mover<LivingThing>();
      //"Parrot" vs "LivingThing"; supplying the parenttype(LivingThing), where the childtype(Parrot) is expected.
      obj2.Move(parrot);

      IMover<Dog> obj3 = new Mover<LivingThing>();
      obj3.Move(dog);

      Console.ReadKey();
    }
  }
}
