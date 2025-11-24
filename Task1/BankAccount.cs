namespace Task1;

public class BankAccount
{
    // Private Fields
    private string accountNumber;
    private double balance;

    public BankAccount(string accNumber, double initialBalance)
    {
        accountNumber = accNumber;

        if (initialBalance > 0)
            balance = initialBalance;
        else
            balance = 0; // prevent negative or 0 value
    }
    
    // TWO PUBLIC PROPERTIES
    // 1. read only property for accountnumber
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // 2. read only property for balance
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0) balance = value;
        }
    }
    
    // TWO METHODS
    // 1. Deposit Method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than 0.");
        }
    }

    // 2. Withdraw method
    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }
}