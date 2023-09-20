namespace ATMConsole_APP;

public class AppScreen
{
    public void Welcome()
    {
        //clear the console screen
        Console.Clear();

        //sets the title of the console window
        Console.Title = "Simple ATM APP";

        //make sure the color is always consistent white
        Console.ForegroundColor = ConsoleColor.White;

        //welcome message
        Console.WriteLine("-------------------------------------- Welcome to My ATM App ---------------------------------");

        //prompt the user to insert atm card
/*         Console.WriteLine("Please insert your ATM card");
        Console.WriteLine("Note: Actual ATM machine will validate a physical ATM card, read the card number and validate it."); */
    }

}
