namespace ATMConsole_APP;

class ATMApp
{
    // Instances of screen and utility
    static Validator validator = new Validator();
    static AppScreen appScreen = new AppScreen();
    static Utility utility = new Utility();
    public static void Main()
    {

        // calling welcome screen
        appScreen.Welcome();
        utility.PressEnterToContinue();

        long cardNumber = validator.Convert<long>("you card number");
        Console.WriteLine($"Your card number is {cardNumber}");

        utility.PressEnterToContinue();
    }
}
