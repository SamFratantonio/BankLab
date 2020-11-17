 using System;
 
 abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount()
        {
            Balance = 1000;
        }

         public BankAccount(double balance)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Current Balance: " + Balance);
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
              Balance -= amount;
            }
            else
            {
              Console.WriteLine("Insufficient Funds");
            }
        }
        public abstract void CalculateInterest();

    }