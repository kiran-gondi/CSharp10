using ClassLibrary1;
using System;

class Program
{
  static void Main()
  {
    //create object of Sample class
    Sample sample = new Sample();

    //create delegate object (OR) delegate
    MyDelegateType myDelegate;

    //add method reference to delegate
    myDelegate = new MyDelegateType(sample.Add);

    //invoke method using delegate object
    Console.WriteLine("Add Delegate output: " + myDelegate.Invoke(3, 4));
    Console.ReadKey();
  }
}