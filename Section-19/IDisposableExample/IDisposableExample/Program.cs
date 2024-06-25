using ClassLibrary1;
using System;

namespace IDisposableExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create object using "using structure"
      using (Sample s = new Sample())
      {
        s.DisplayDataFromDatabase();
      }

      Console.WriteLine("Some other work here");
      Console.ReadKey();
    }
  }
}
