interface IAccount // access modifier not required by default it is public
{                           
    void PrintDetails();
}
class CurrentAccount : IAccount     // Implementing  Interface IAccount
{
    public void PrintDetails()
    {
        Console.WriteLine("Current Account");
    }
}
class SavingsAccount : IAccount     // Implementing  Interface IAccount
{
    public void PrintDetails()
    {
        Console.WriteLine("Savings Account");
    }
}
class Account
{
    private IAccount account;
    public Account(IAccount account)    // Parameterized Constructor
    {
        this.account = account;
    }
    public void PrintDetails()
    {
        //var ca = new CurrentAccount();
        //var sa = new SavingsAccount();
        account.PrintDetails(); // declaring object of child class
                                // and storing it in a parent class
    }
}
class Program
{
    static void Main(string[] args)
    {
        IAccount ca = new CurrentAccount();
        Account a = new Account(ca);
        a.PrintDetails();
        Console.ReadLine();
    }
}

       