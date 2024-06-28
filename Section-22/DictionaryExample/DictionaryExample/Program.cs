using System;
using System.Collections.Generic;

namespace DictionaryExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create an empty dictionary
      Dictionary<int, string> employeeDictionary = new Dictionary<int, string>()
      {
        { 101, "Scott"},
        { 102, "Morton"},
        { 103, "Alien"}

      };

      //foreach loop for dictionary
      foreach (KeyValuePair<int, string> employee in employeeDictionary)
      {
        Console.WriteLine(employee.Key + ", " + employee.Value);
      }

      Console.WriteLine();
      //get values based on key
      string s = employeeDictionary[101];
      Console.WriteLine("Value of 101 is: "+ s);

      Console.WriteLine();
      //Keys
      Dictionary<int, string>.KeyCollection keys = employeeDictionary.Keys;
      foreach (int keyItem in keys)
      {
        Console.WriteLine("Keys are " + keyItem);
      }

      Console.WriteLine();

      //Duplicate key: exception
      //employeeDictionary.Add(101, "Ramu");
      //employeeDictionary.Add(101, "");

      //Remove
      employeeDictionary.Remove(102);
      //foreach loop for dictionary
      foreach (KeyValuePair<int, string> employee in employeeDictionary)
      {
        Console.WriteLine(employee.Key + ", " + employee.Value);
      }

      //ContainsKey
      bool a = employeeDictionary.ContainsKey(101);
      Console.WriteLine("ContainsKey " + a);

      //ContainsValue
      bool sa = employeeDictionary.ContainsValue("Scott");
      Console.WriteLine("ContainsValue " + sa);

      //Clear
      employeeDictionary.Clear();



      Console.ReadKey();
    }
  }
}
