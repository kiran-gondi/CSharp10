//create an List of strings
List<string> myFriends = new List<string>() { "Scott", "Allen", "Jones", "James", "Sara"};
Console.WriteLine(myFriends[myFriends.Count - 1]);

Console.WriteLine(myFriends[^1]);//Sara
Console.WriteLine(myFriends[^5]);//Scott

Index i = ^4;
Console.WriteLine(myFriends[i]);//Allen

//Range-LINQ
//IEnumerable<string> shortListedFriends = myFriends.Skip(1).Take(3);

//Range Struct
Range r = 1..4;
IEnumerable<string> shortListedFriends = myFriends[r];//myFriends[1..4];
Console.WriteLine("Short Listed Friends");
foreach (string s in shortListedFriends)
{
  Console.Write(s + ", ");
}




Console.ReadKey();