using System;
using System.Collections;

namespace HashTableExample
{
  internal class Program
  {
    static void Main(string[] args)
    {

      //create a sorted List
      Hashtable employees = new Hashtable {
        {101, "Smith"},
        {103, "Bob"},
        {104, "Rom"},
        {102, "Will"},
        {105, "Com"},
        {"hello", 10.34 },
        {"hello1", 108972.34 }
      };

      //Add element
      employees.Add("106", "Anna");

      //Remove element
      employees.Remove(104);
      //employees.Remove("hello1");

      //foreach
      foreach (DictionaryEntry employee in employees) 
      { 
        Console.WriteLine(employee.Key + ", " + employee.Value);
      }

      //get value based on key
      if (employees[105] is string)
      {
        string value = Convert.ToString(employees[105]);
        Console.WriteLine(value);
      }
      else if (employees[105] is double)
      {
        double value = Convert.ToDouble(employees[105]);
        Console.WriteLine(value);
      }
      
      //search for specific key
      bool k = employees.ContainsKey(105);
      Console.WriteLine("\n105 exists: " + k);

      //search for specific value
      bool k1 = employees.ContainsValue(105);
      Console.WriteLine("\n105 exists: " + k1);

      //Keys 
      Console.WriteLine("\nKeys:");
      foreach(var employee in employees.Keys)
      {
        Console.WriteLine(employee);
      }

      //Values
      Console.WriteLine("\nValues:");
      foreach (var employee in employees.Values)
      {
        Console.WriteLine(employee);
      }

      Console.ReadKey();
    }
  }
}
