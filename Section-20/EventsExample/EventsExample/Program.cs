﻿using ClassLibrary1;
using System;

namespace EventsExample
{
  public class Program
  {
    static void Main(string[] args)
    {
      Program p = new Program();
      p.DoWork();

      Console.ReadKey();
    }

    public void DoWork()
    {
      //create object of Subscriber class
      //Subscriber subscriber = new Subscriber();

      //create object of Publisher class
      Publisher publisher = new Publisher();

      //handle the event(or)subscribe to event
      //publisher.myEvent += subscriber.Add;

      //Anonymous Method
      //publisher.myEvent += delegate(int a, int b){
      //  int c = a + b;
      //  Console.WriteLine(c);
      //};

      //Lambda Expression with Func demo
      //publisher.myEvent += (a, b) =>
      //{
      //  int c = a + b;
      //  Console.WriteLine(c);
      //  return c; //Added for the Func demo
      //};

      //Inline Lambda Expression
      //publisher.myEvent += (a, b) => Console.WriteLine(a+b);

      //Action
      //publisher.myEvent += (a, b) =>
      //{
      //  int c = a + b;
      //  Console.WriteLine(c);
      //};

      //Predicate
      //publisher.myEvent += (a) =>
      //{
      //  return a >= 0;
      //};

      //EventHandler
      publisher.myEvent += (sender, e) =>
      {
        int c = e.a + e.b;
        Console.WriteLine(c);
      };

      //invoke the event
      //publisher.RaiseEvent(10, 20);
      //publisher.RaiseEvent(11, 22);
      //publisher.RaiseEvent(2, 4);

      //invoke the event for predicate
      //Console.WriteLine(publisher.RaiseEvent(10));
      //Console.WriteLine(publisher.RaiseEvent(-11));
      //Console.WriteLine(publisher.RaiseEvent(2));

      //EventHandler
      publisher.RaiseEvent(this, 10, 20);
      publisher.RaiseEvent(this, 11, 22);
      publisher.RaiseEvent(this, 2, 4);
    }
  }
}
