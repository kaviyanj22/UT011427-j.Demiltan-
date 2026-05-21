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
            public void Deposit(double AccBalance)
            {
                Console.Write("\nEnter deposit amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (amount > 0)
                {
                    AccBalance += amount;
                    Console.WriteLine($"Your Account balance is {AccBalance}");
                    Console.WriteLine("Deposit Successful");
                }
            }

        

        public void Withdraw(double AccBalance)
        {
            Console.Write("\nEnter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > 0 && amount <= AccBalance)
            {
                AccBalance -= amount;
                Console.WriteLine("Withdraw Successful");
              
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
              
            }


        }

       


    }

}
