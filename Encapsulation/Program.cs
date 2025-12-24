
class Program
{
    class BankCard
    {
        private decimal balance;

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            { balance += amount; Console.WriteLine($"Deposited: {amount:C}. New Balance: {balance:C}"); }
            else
            { Console.WriteLine("Deposit amount must be positive."); }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
            { Console.WriteLine("Insufficient funds for this withdrawal."); }
            else if (amount <= 0)
            { Console.WriteLine("Withdrawal amount must be positive."); }
            else
            { balance -= amount; Console.WriteLine($"Withdrew: {amount:C}. New Balance: {balance:C}"); }
        }
    }

    static void Main()
    {
        var card = new BankCard();
        card.Deposit(1000);
        card.Withdraw(500);
        card.Withdraw(600);
        card.Deposit(-200);
        card.Withdraw(0);
        card.Withdraw(-1);
    }
}