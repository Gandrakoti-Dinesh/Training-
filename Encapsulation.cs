using System;

class BankAccount
{
    private double _balance;

    public double Balance
    {
        get { return _balance; }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= _balance)
        {
            _balance -= amount;
        }
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();
        
        account.Deposit(1000);
        account.Withdraw(300);

        Console.WriteLine("Current Balance: " + account.Balance);
    }
}
