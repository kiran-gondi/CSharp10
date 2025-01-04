namespace FormatExceptionDemo
{
    class BankAccount
    {
        public string AccountHolderName { get;set; }
        public int AccountNumber { get; set; }
        public double CurrentBalance { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //create object of BankAccount
                BankAccount bankAccount = new BankAccount();

                //input from keyboard
                Console.Write("Enter account holder name:");
                bankAccount.AccountHolderName = Console.ReadLine();

                Console.Write("Enter account number:");
                bankAccount.AccountNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter current balance:");
                bankAccount.CurrentBalance = int.Parse(Console.ReadLine());

                Console.WriteLine("\n New Bank account details:");

                Console.Write("Account holder name:" + bankAccount.AccountHolderName);
                Console.Write("Account number:" + bankAccount.AccountNumber);
                Console.Write("Current Balance:" + bankAccount.CurrentBalance);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
