using System.ComponentModel;
using ATMConsole_APP;

class Validator
{
    // Creates an instance of the Utility class.
    Utility utility = new Utility();
    public T Convert<T>(string prompt)
    {
        string? userInput = string.Empty;
        while (true)
        {
            userInput = utility.GetUserInput(prompt);
            try
            {
                var converter = TypeDescriptor.GetConverter(typeof(T));
                if (converter != null)
                {
                    return (T)converter.ConvertFromString(userInput);
                }
                else
                    return default;
            }
            catch
            {
                PrintMessage("Invalid input. Try again.", false);
            }
        }


    }
    public void PrintMessage(string msg, bool isSuccess = true)
    {
        if (!isSuccess) Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine(msg);
        Console.ResetColor();
        //pressEnterToContinue
    }
}