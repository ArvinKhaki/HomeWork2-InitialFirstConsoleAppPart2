namespace HomeWork2.Task2;

internal class BankAccount
{
    private int _balance;

    public int Deposit(double amount)
    {
        return _balance += (int)amount;
    }

    public int Withdraw(double amount)
    {
        if (_balance < (int)amount)
        {
            Console.WriteLine("Insufficient funds!!");
        }
        
        return _balance -= (int)amount;
    }
}
