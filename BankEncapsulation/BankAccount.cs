using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }
        private double Balance = 0;


        public void Deposit(double deposit)
        {
            Balance += deposit;
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}


