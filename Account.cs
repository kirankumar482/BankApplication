namespace bankapp;
public class Account
{
    // Auto-implemented properties
    public string Id { get; private set; }
    public string Password { get; private set; }
    public string Title { get; private set; }
    public string Name { get; private set; }
    public int Balance { get; private set; }

    public int Age { get; private set; }

    // Constructor
    public Account(string id, string password, string name, int balance, int age)
    {
        Id = id;
        Password=password;
        Name = name;
        Balance = balance;
        Age = age;
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
