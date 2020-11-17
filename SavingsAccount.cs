using System;

class SavingsAccount : BankAccount
{
  public SavingsAccount() : base() 
  {

  }
  public SavingsAccount(double amount) : base(amount)
  {

  }
  public override void CalculateInterest()
  {
    DateTime now = DateTime.Today;
    int years = now.Year - DateCreated.Year;
    Balance += (years * (0.5 * Balance));
  }
  public override void Withdraw(double amount)
  {
    if (Balance < 2000)
    {
      Console.WriteLine("Insufficient Balance");
    }
    else {
      base.Withdraw(amount);
    }
  }
}