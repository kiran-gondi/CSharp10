using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortReverseExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create a list
      List<int> list = new List<int>() { 30, 20, 60, 10, 40, 50 };

      //sort-asc
      list.Sort();
      foreach (var item in list)
      {
        Console.WriteLine(item);
      }

      Console.WriteLine();

      //reverse - sort in desc
      list.Reverse();
      foreach (var item in list)
      {
        Console.WriteLine(item);
      }

      Console.ReadKey();
    }
  }
}
