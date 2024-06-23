namespace BoxingExample
{
  internal class Program
  {
    static void Main(string[] args)
    {

      #region BOXING
      //primitive variable
      int x = 10;

      //Boxing (value-type to reference-type)
      object obj = x;

      Console.WriteLine(x);
      Console.WriteLine(obj);
      #endregion

      #region UNBOXING
      //reference-type variable
      object obj1 = 10;

      //Unboxing (reference-type to value-type)
      int x1 = (int)obj1;

      Console.WriteLine(x1);
      Console.WriteLine(obj1); 
      #endregion

      Console.ReadKey();
    }
  }
}
