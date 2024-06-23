class Program
{
  public static void Main()
  {
    //create object of generic class
    User<int, int> user1 = new User<int, int>();
    User<bool, string> user2 = new User<bool, string>();

    //set value into generic field.
    user1.RegistrationStatus = 1;
    user1.Age = 32;
    Console.WriteLine("User1 RegistrationStatus is: " + user1.RegistrationStatus);
    Console.WriteLine("User1 age is: " + user1.Age);

    user2.Age = "35-40";
    Console.WriteLine("User2 RegistrationStatus is: " + user2.RegistrationStatus);
    Console.WriteLine("User2 age is: " + user2.Age);

    Console.ReadKey();
  }
}