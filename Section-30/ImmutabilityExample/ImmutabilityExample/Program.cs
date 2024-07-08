//class BankAccount
readonly struct BankAccount //Readonly Structs
{
  //public int AccountNumber { get; set; }
  //public double CurrentBalance { get; set; }

  //private fields
  private readonly int _accountNumber;
  private readonly double _currentBalance;

    /*public void Method1()
    {
      _accountNumber = 12;
    }*/

    public BankAccount(int accountNumber, double currentBalance)
    {
       _accountNumber = accountNumber;
       _currentBalance = currentBalance;
    }

    //public properties
    //public int AccountNumber { get { return _accountNumber; } }
    public int AccountNumber { get => _accountNumber;
    //Init-Only Properties
    init => _accountNumber = value; } 
    public double CurrentBalance { get => _currentBalance;
    //Init-Only Properties
      init 
      {
        if (value >= 0)
        {
          _currentBalance = value;
        }
      } 
  }

    //paramter-less constructor
    //public BankAccount()
    //{
        
    //}
}

class DataStorage
{
  //developer1
  public static List<BankAccount> GetBankAccounts()
  {
    //return new List<BankAccount>() { 
    //  new BankAccount(){AccountNumber=1, CurrentBalance=1000},
    //  new BankAccount(){AccountNumber=2, CurrentBalance=2000}
    //};

    return new List<BankAccount> { 
    new BankAccount(){ AccountNumber = 1, CurrentBalance = 1000 },
    new BankAccount(2, 2000)
    };
  }

  //developer2
  public static double GetCurrentBalance(BankAccount bankAccount)
  {
    //bankAccount.AccountNumber = 100;  //Not accessible as its read-only
    return bankAccount.CurrentBalance;
  }
}

class Program
{
  static void Main()
  {
    List<BankAccount> bankAccounts = DataStorage.GetBankAccounts();
    BankAccount firstBankAccount = bankAccounts[0];
    double firstBankAccountBalance = DataStorage.GetCurrentBalance(firstBankAccount);
    Console.WriteLine(firstBankAccount.AccountNumber + "," + firstBankAccountBalance);

    Console.ReadKey();
  }
}