using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
  public class Sample
  {
    public List<double> Prices { get; set; }  = new List<double>() { 90, 30, 12, 80};

    public IEnumerable<double> Method()
    {
      double sum = 0;

      foreach (double price in Prices) { 
        sum += price;
        yield return sum;
      }

      //sum += Prices[0];//90
      //yield return sum;
      //sum += Prices[1];//124
      //yield return sum;
      //sum += Prices[2];//124
      //yield return sum;
      //sum += Prices[32];//124
      //yield return sum;

    }

    //public IEnumerable<int> Method()
    //{
    //  Console.WriteLine("Iterator method executes");
    //  yield return 10;
    //  Console.WriteLine("Iterator method execution continued");
    //  yield return 20;
    //}
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      Sample s = new Sample();
      var prices_enumerable1 = s.Method();

      var prices_enumerator1 = prices_enumerable1.GetEnumerator();
      prices_enumerator1.MoveNext(); //90
      Console.WriteLine("Total price up to first product: " + prices_enumerator1.Current);
      Console.WriteLine("Some stuff...");

      prices_enumerator1.MoveNext();
      Console.WriteLine("Total price up to second product: " + prices_enumerator1.Current);
      Console.WriteLine("Some stuff...");


      //foreach (var item in enumerable1)
      //{
      //  Console.WriteLine(item);
      //}

      //prices_enumerator1.MoveNext();
      //  Console.WriteLine(prices_enumerator1.Current);

      Console.ReadKey();
    }
  }
}
