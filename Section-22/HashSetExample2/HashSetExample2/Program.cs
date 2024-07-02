using System;
using System.Collections.Generic;

namespace HashSetExample2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create two HashSet's
      HashSet<string> employees2021 = new HashSet<string>() { "Amar", "Akhil", "Samareen", "John" };
      HashSet<string> newemployees2022 = new HashSet<string>() { "John", "Scott", "Smith", "David" };

      //Console.WriteLine("With Union");
      //Union
      //employees2021.UnionWith(newemployees2022);

      //foreach (string employee202 in employees2021)
      //{
      //  Console.WriteLine(employee202);
      //}

      Console.WriteLine("\nAfter intersection");
      //Intersection
      employees2021.IntersectWith(newemployees2022);
      foreach (string employee202 in employees2021)
      {
        Console.WriteLine(employee202);
      }

      Console.ReadKey();
    }
  }
}
