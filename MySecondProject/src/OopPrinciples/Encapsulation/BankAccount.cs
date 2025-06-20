namespace MySecondProject.OopPrinciples.Encapsulation;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal balance)
    {
        Deposit(balance);
    }

    public decimal GetBalance()
    {
        return balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be greater than 0");
        }

        this.balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdraw amount must be greater than 0");
        }

        if (amount > this.balance)
        {
            throw new InvalidOperationException("Withdrawal amount cannot be greater than balance");
        }

        this.balance -= amount;
    }
}