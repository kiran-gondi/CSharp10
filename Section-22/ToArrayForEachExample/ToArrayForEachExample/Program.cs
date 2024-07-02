using System;
using System.Collections.Generic;

namespace ToArrayForEachExample
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //create list
      List<string> myFriends = new List<string>() { "Abin", "Thomas", "Ramu", "Kaka" };

      //ForEach method
      myFriends.ForEach(friend => { Console.WriteLine(friend); });

      //convert to array
      string[] myFriendsArray = myFriends.ToArray();

      //display array
      //foreach (string friend in myFriendsArray) { 
      //  Console.WriteLine(friend);
      //}

      

      Console.ReadKey();
    }
  }
}
