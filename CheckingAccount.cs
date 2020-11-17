using System;

class CheckingAccount : BankAccount
    {
      public CheckingAccount() : base() 
      {

      } 
      public CheckingAccount(double balance) : base(balance)
      {

      }
      public override void CalculateInterest()
      {
        DateTime now = DateTime.Today;
        int years = now.Year - DateCreated.Year;
        Balance += (years * (0.05 * Balance));
      }
      public override void Withdraw(double amount) 
      {
        base.Withdraw(amount);
      }
    }