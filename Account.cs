namespace bankapp;
public class Account
{
    // Auto-implemented properties
    public string Id { get; private set; }
    public string Name { get; private set; }
    public int Balance { get; private set; }

    // Constructor
    public Account(string id, string name, int balance)
    {
        Id = id;
        Name = name;
        Balance = balance;
    }

    // Withdraw method
    public void Withdraw(int amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew ${amount}. New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    // Deposit method
    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // ToString override
    public override string ToString()
    {
        return $"Account ID: {Id}, Name: {Name}, Balance: ${Balance}";
    }
}
