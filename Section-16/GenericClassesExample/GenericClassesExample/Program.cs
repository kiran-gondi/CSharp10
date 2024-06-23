class Program
{
  public static void Main()
  {
    //create object of generic class
    User<int> user1 = new User<int>();
    User<bool> user2 = new User<bool>();

    //set value into generic field.
    user1.RegistrationStatus = 1;
    Console.WriteLine("User1: " + user1.RegistrationStatus);


    Console.WriteLine("User2: " + user2.RegistrationStatus);

    Console.ReadKey();
  }
}