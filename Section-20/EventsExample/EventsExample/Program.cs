using ClassLibrary1;
using System;

namespace EventsExample
{
  public class Program
  {
    static void Main(string[] args)
    {
      //create object of Subscriber class
      //Subscriber subscriber = new Subscriber();

      //create object of Publisher class
      Publisher publisher = new Publisher();

      //handle the event(or)subscribe to event
      //publisher.myEvent += subscriber.Add;

      //Anonymous Method
      publisher.myEvent += delegate(int a, int b){
        int c = a + b;
        Console.WriteLine(c);
      };

      //invoke the event
      publisher.RaiseEvent(10, 20);
      publisher.RaiseEvent(11, 22);
      publisher.RaiseEvent(2, 4);

      Console.ReadKey();
    }
  }
}
