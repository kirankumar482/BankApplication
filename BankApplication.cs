// See https://aka.ms/new-console-template for more information
namespace bankapp;

public class BankApplication
{
    static void Main()
    {
        Console.WriteLine("Let's Build Bank Application");
        
        //List of Accounts
        List<Account> accounts = new List<Account>();

        string id;
        string name;
        int balance;
        Account acc;
        bool exit = false;
        do
        {
            Console.WriteLine("0: create");
            Console.WriteLine("1: access");
            Console.WriteLine("2: accounts");
            Console.WriteLine("3: Exit");

            Console.WriteLine("Enter choice");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0: // Create Account
                    Console.WriteLine("Enter account name:");
                    name = Console.ReadLine();

                    Console.WriteLine("Enter initial balance:");
                    balance = int.Parse(Console.ReadLine());

                    id = name + balance.ToString();

                    acc = new Account(id, name, balance);
                    accounts.Add(acc);
                    Console.WriteLine($"Account created {id}");
                    break;

                case 1:
                    // Access Account
                    Console.WriteLine("Enter account ID:");
                    id = Console.ReadLine();

                    acc = accounts.FindLast( x => x.Id.Equals(id) );

                    if (acc != null)
                    {
                        Console.WriteLine("\nAccount Options:");
                        Console.WriteLine("1. Deposit");
                        Console.WriteLine("2. Withdraw");
                        Console.WriteLine("3. Back");

                        bool keepGoing = true; // Flag to control the account options loop

                        while (keepGoing)
                        {
                            Console.Write("Enter your choice: ");
                            int subChoice = int.Parse(Console.ReadLine());

                            switch (subChoice)
                            {
                                case 1: // Deposit
                                    Console.WriteLine("Enter amount to deposit:");
                                    int depositAmount = int.Parse(Console.ReadLine());
                                    acc.Deposit(depositAmount);
                                    break;

                                case 2: // Withdraw
                                    Console.WriteLine("Enter amount to withdraw:");
                                    int withdrawAmount = int.Parse(Console.ReadLine());
                                    acc.Withdraw(withdrawAmount);
                                    break;

                                case 3: // Back to main menu
                                    Console.WriteLine("Exiting account options...");
                                    keepGoing = false; // Exit the loop
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice.");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Account not found.");
                    }
                    break;

                case 2:
                    accounts.ForEach(x => Console.WriteLine(x));
                    break;

                case 3:
                    exit=true;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }while (!exit);
        

       
       
    }
}