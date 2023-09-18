namespace ATMConsole_APP;

class Program
{
    public static void Main()
    {
        // list of fake people and fake pins, etc...
        List<CardHolder> fake = new List<CardHolder>(){
            new CardHolder("123457890123456", 1234, "John", "Griffith", 150.31),
            new CardHolder("123457890123456", 4321, "Ashley", "Griffith", 321.13),
            new CardHolder("123457890123456", 9999, "Freida", "Dickerson", 105.59),
            new CardHolder("123457890123456", 2468, "Mine", "Harding", 851.84),
            new CardHolder("123457890123456", 4826, "Dawn", "Smith", 54.27),
        };
    }




}