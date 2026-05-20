using System;

namespace bankapplication
{
    public class BankAccount
    {

        public string BankName;
        public string AccHolderName;
        public int AccNumber;
        public double AccBalance;
       
    

       
        public BankAccount(string bankName, string accHolderName, int accNumber, double accBalance)
        {
            BankName = bankName;
            AccHolderName = accHolderName;
            AccNumber = accNumber;
            AccBalance = accBalance;
        }

        // Display Metho
        public void DisplayAccount()
        {
            Console.WriteLine("Bank Name : " + BankName);
            Console.WriteLine("Account Holder Name : " + AccHolderName);
            Console.WriteLine("Account Number : " + AccNumber);
            Console.WriteLine("Account Balance : " + AccBalance);
        }
    }
}