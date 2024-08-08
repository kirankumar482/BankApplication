// See https://aka.ms/new-console-template for more information
namespace bankapp;

public class BankApplication
{
    static void Main()
    {
        Console.WriteLine("Let's Build Bank Application");
        Account acc = new Account("kkr","kiran",567);
        acc.ToString();
        //List of Accounts
        //switch statements (create,access)
        //if create create account obj and append (take details)
        //else if access account using id of acc (deposit,withdraw)
    }
}