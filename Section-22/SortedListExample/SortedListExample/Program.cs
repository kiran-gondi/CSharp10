using System;
using System.Collections.Generic;

namespace SortedListExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create a sorted List
      SortedList<int, string> employees = new SortedList<int, string>() {
        {101, "Smith"},
        {103, "Bob"},
        {104, "Rom"},
        {102, "Will"},
        {105, "Com"}
      };

      //Add element
      employees.Add(106, "Dom");

      //Remove element
      employees.Remove(103);

      //foreach
      foreach (KeyValuePair<int, string> employee in employees) { 
        Console.WriteLine(employee.Key + ", " + employee.Value);  
      }

      //get value based on key
      Console.WriteLine("\nEmployee name at 104: " + employees[104]);

      //search for specific key
      bool k = employees.ContainsKey(105);
      Console.WriteLine("\n 105 exists " + k);

      //search for specific value
      bool v = employees.ContainsValue("Scott");
      Console.WriteLine("\n Scott exists " + v);

      //index of specific key
      int k1 = employees.IndexOfKey(105);
      Console.WriteLine("\n 105 exists " + k1);

      //index of specific value
      int k2 = employees.IndexOfValue("Allen");
      Console.WriteLine("\n Allen index exists " + k2);

      Console.WriteLine("\nPrint All keys");
      //Keys
      foreach (int itemKey in employees.Keys)
      {
        Console.WriteLine(itemKey);
      }

      Console.WriteLine("\nPrint All values");
      //Values
      foreach (string itemValue in employees.Values)
      {
        Console.WriteLine(itemValue);
      }

      Console.ReadKey();
    }
  }
}
