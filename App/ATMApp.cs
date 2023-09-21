namespace ATMConsole_APP;

class ATMApp
{
    // Instances of screen and utility
    private static Validator _validator = new Validator();
    private static AppScreen _appScreen = new AppScreen();
    private static Utility _utility = new Utility();
    public static void Main()
    {

        // calling welcome screen
        _appScreen.Welcome();
        _utility.PressEnterToContinue();

        long cardNumber = _validator.Convert<long>("you card number");
        Console.WriteLine($"Your card number is {cardNumber}");

        _utility.PressEnterToContinue();
    }
}
