//create an List of strings
List<string> myFriends = new List<string>() { "Scott", "Allen", "Jones", "James", "Sara"};
Console.WriteLine(myFriends[myFriends.Count - 1]);

Console.WriteLine(myFriends[^1]);//Sara
Console.WriteLine(myFriends[^5]);//Scott

Index i = ^4;
Console.WriteLine(myFriends[i]);//Allen

Console.ReadKey();