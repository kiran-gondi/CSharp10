namespace OperatorsExample
{
  class Program
  {
    static void Main()
    {
      //Arithmetical Operators
      decimal a = 10M;
      decimal b = 3M;
      decimal c = a + b;
      decimal d = a - b;
      decimal e = a * b;
      decimal f = a / b;
      decimal g = a % b;

      Console.WriteLine(c);
      Console.WriteLine(d);
      Console.WriteLine(e);
      Console.WriteLine(f);
      Console.WriteLine(g);


      //Assignment Operators
      a += 20M;
      Console.WriteLine();
      Console.WriteLine(a);
      a -= 20M;
      Console.WriteLine(a);
      a *= 3M;
      Console.WriteLine(a);
      a /= 3M;
      Console.WriteLine(a);
      a %= 3M;
      Console.WriteLine(a);

      //Increment/Decrement Operators
      a = 10M;
      Console.WriteLine();
      Console.WriteLine(++a);
      Console.WriteLine(a++);
      Console.WriteLine(a);
      Console.WriteLine(--a);
      Console.WriteLine(a--);
      Console.WriteLine(a);

      //Comparison Operators
      Console.WriteLine();
      bool b1 = a == 10;
      Console.WriteLine(b1);
      bool b2 = a != 10;
      Console.WriteLine(b2);
      bool b3 = a < 10;
      Console.WriteLine(b3);
      bool b4 = a > 10;
      Console.WriteLine(b4);
      bool b5 = a <= 10;
      Console.WriteLine(b5);
      bool b6 = a >= 10;
      Console.WriteLine(b6);

      //Logical Operators
      Console.WriteLine();
      bool b7 = a == 10 & b == 10;
      Console.WriteLine(b7);
      bool b8 = a == 10 && b == 10;
      Console.WriteLine(b8);
      bool b9 = a == 10 | b == 10;
      Console.WriteLine(b9);
      bool b10 = a == 10 || b == 10;
      Console.WriteLine(b10);
      bool b11 = !(a == 10);
      Console.WriteLine(b11);
      bool b12 = a == 10 ^ b == 10;
      Console.WriteLine(b12);

      //Concatenation Operator
      string name = "Bob";
      int age = 7;
      string message = "hey, " + name + " your age is " + age;
      Console.WriteLine(message);

      //Ternary Operator
      string tile = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Teenager" : "Adult";
      Console.WriteLine(tile);

      //Operator Precedence
      double z = 10 + 4 * 30 / 10;
      Console.WriteLine(z);

      Console.ReadKey();
    }
  }
}
