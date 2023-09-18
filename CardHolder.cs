namespace ATMConsole_APP;
public class CardHolder
{
    private string CardNum { get; set; }
    private string FirstName { get; set; }
    private string LastName { get; set; }
    private double Balance { get; set; }
    private int Pin { get; set; }

    public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
    {
        CardNum = cardNum;
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;
        Pin = pin;
    }

    //printing options
    private static void printOptions()
    {
        Console.WriteLine("Please choose from one of the following options ");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw ");
        Console.WriteLine("3. Show Balance");
        Console.WriteLine("4. Exit");
    }
    // Deposit()
    private void Deposit(CardHolder currentUser)
    {
        Console.WriteLine("How much money do you like to deposit? ");
        currentUser.Balance += Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Thank you, for your deposit. Your current Balance is: {currentUser.Balance} ");
    }

    private void Withdraw(CardHolder currentUser)
    {
        Console.WriteLine("How much money do you like to withdraw? ");
        double withdrawal = Convert.ToDouble(Console.ReadLine());

        // Checking weather the user has enough money

        if (currentUser.Balance > withdrawal)
        {
            currentUser.Balance = currentUser.Balance - withdrawal;
            Console.WriteLine("You're good to go, Thank you!");

        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
    private void ShowBalance(CardHolder currentUser)
    {
        Console.WriteLine($"Current Balance: {currentUser.Balance}");
    }

}