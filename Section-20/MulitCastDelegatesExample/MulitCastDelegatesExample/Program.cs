using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulitCastDelegatesExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create object of sample
      Sample s = new Sample();

      //Create reference variable of MyDelegateType
      MyDelegatType myDelegate;

      //add ref of first target method
      //myDelegate = new MyDelegatType(s.Add);
      myDelegate = s.Add;

      //add ref of second target method
      myDelegate += s.Multiply;

      //invoke both target methods; first Add method; and then Multiply method
      myDelegate.Invoke(4, 5);

      Console.ReadKey();

    }
  }
}
