using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
    SavingsAccount a = new SavingsAccount();
    a.Deposit(2000);
    a.Withdraw(5000);
    a.CalculateInterest();
    a.Withdraw(500);
            /*Test case 1
             * Create a savingsaccount object
             * Deposit $2000
             * Withdraw $5000
             * Calculate interest
             * Withdraw $500
            */

            /*Test case 2
            * Create a checkingaccount object
            * Deposit $2000
            * Withdraw $5000
            * Calculate interest
            * Withdraw $500
           */
  }
}