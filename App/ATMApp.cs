namespace ATMConsole_APP;

class ATMApp
{
    public static void Main()
    {
        // Instances of screen and utility
        var appScreen = new AppScreen();
        var utility = new Utility();

        // calling welcome screen
        appScreen.Welcome();
        utility.PressEnterToContinue();

        string? cardNumber = utility.GetUserInput("your card Number");
        Console.WriteLine($"Your card number is {cardNumber}");

        utility.PressEnterToContinue();
    }
}
