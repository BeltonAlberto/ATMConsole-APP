using System.Diagnostics;

namespace ATMConsole_APP;

class Utility
{

    public void PressEnterToContinue()
    {
        Console.WriteLine("Press Enter to continue...");
        Console.ReadKey();
    }
    public string? GetUserInput(string prompt)
    {
        Console.WriteLine($"Enter {prompt}");
        return Convert.ToString(Console.ReadLine());
    }


}