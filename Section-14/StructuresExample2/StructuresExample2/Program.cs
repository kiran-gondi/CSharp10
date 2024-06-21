class Program
{
  public static void Main()
  {
    //create structure instance
    Structure1 structure1;
    structure1.x = 10;
    structure1.y = 20;

    //create class instance
    Class1 class1 = new Class1();
    class1.x = 30;
    class1.y = 40;

    //create structure instance 2
    Structure1 structure2 = new Structure1();

    //copy date from structure1 to structure2
    structure2 = structure1;

    //modify data of structure2
    structure2.x = 100;
    structure2.y = 200;

    //print the value of structure1 and structure2
    Console.WriteLine("Struct");
    Console.WriteLine(structure1.x); //Outptut:10
    Console.WriteLine(structure1.y); //Outptut:20
    Console.WriteLine(structure2.x); //Outptut:100
    Console.WriteLine(structure2.y); //Outptut:200

    //create reference variable of Class2
    Class1 class2;

    //copy reference from Class1 to Class2
    class2 = class1;

    //modify data of object through reference variable2
    class2.x = 400;
    class2.y = 500;

    //print the value of object using both reference variables
    Console.WriteLine("\nClass");
    Console.WriteLine(class1.x); //Outptut:400
    Console.WriteLine(class1.y); //Outptut:500
    Console.WriteLine(class2.x); //Outptut:400
    Console.WriteLine(class2.y); //Outptut:500

    Console.ReadKey();
  }
}