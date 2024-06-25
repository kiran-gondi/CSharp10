using ClassLibrary1;
using System;

namespace IDisposableExample
{
  internal class Program
  {
    static void Work()
    {
      //create object using "using declaration"
      using Sample s = new Sample();
        s.DisplayDataFromDatabase();
    }//Dispose gets called here

    static void Main(string[] args)
    {
      //create object using "using structure"
      //using (Sample s = new Sample())
      //{
      //  s.DisplayDataFromDatabase();
      //}

      Work();

      Console.WriteLine("Some other work here");

      Console.ReadKey();
    }
  }
}
