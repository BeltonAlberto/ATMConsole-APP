namespace ATMConsole_APP
{
    public class CardHolder
    {
        private string cardNum;
        private string firstName;
        private string lastName;
        private double balance;
        private int pin;

        public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
            this.pin = pin;
        }

        // Manual Getters

        public string getNum() => cardNum;
        public string getFirstName() => firstName;
        public string getLastName() => lastName;
        public double getBalance() => balance;
        public int getPin() => pin;

        // Manual setters
        public void setNum(string newCardNum) => cardNum = newCardNum;
        public void setFirstName(string newFirstName) => firstName = newFirstName;
        public void setLastName(string newLastName) => lastName = newLastName;
        public void setBalance(double newBalance) => balance = newBalance;
        public void setPin(int newPin) => pin = newPin;

        public static void Main(string[] args)
        {

        }

    }
}