namespace Try_Catch_Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int a, b;
				Console.WriteLine("Enter number 1: ");
				string firstNumber = Console.ReadLine();
				a = int.Parse(firstNumber);

				Console.WriteLine("Enter second 2: ");
				string secondNumber = Console.ReadLine();	
				b = int.Parse(secondNumber);

				int c = a / b;
				Console.WriteLine("Result of division " + c);
			}
			catch (DivideByZeroException ex)
			{

				Console.WriteLine(ex.Message);
			}
			finally
			{
				Console.ReadLine();
			}
        }
    }
}
