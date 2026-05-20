using System;

namespace bankapplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(
                "BOE",
                "Kaviyan",
                1986460,
                5000.00
            );

            BankName();
            Welcome();
            Menu(account);
            bool exit = true;
            while (exit)
            {

                Console.Write("Choose an option: ");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AccountDetails(account);


                        break;

                    case 2:
                        CheckBalance(account);
                        break;

                    case 3:
                        Deposit(account);
                        break;

                    case 4:
                        Withdraw(account);
                        break;

                    case 5:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }

        static void BankName()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("-----------BOE-----------");
            Console.WriteLine("=========================");
        }

        static void Welcome()
        {
            Console.WriteLine("WELCOME TO BANK OF EELAM");
            Console.WriteLine("=========================");
        }

        static void Menu(BankAccount account)
        {
            Console.WriteLine("1.View Account Details");
            Console.WriteLine("2.Check Balance");
            Console.WriteLine("3.Deposit Money");
            Console.WriteLine("4.Withdraw Money");
            Console.WriteLine("5.Exit");
            


        }

        static void AccountDetails(BankAccount account)
        {
            Console.WriteLine("\nAccount Details");
            Console.WriteLine("Name: " + account.AccHolderName);
            Console.WriteLine("Account Number: " + account.AccNumber);
            Console.WriteLine("Balance: " + account.AccBalance);

        }

        static void CheckBalance(BankAccount account)
        {
            Console.WriteLine("\nCurrent Balance: " + account.AccBalance);
        }

        static void Deposit(BankAccount account)
        {
            Console.Write("\nEnter deposit amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > 0)
            {
                account.AccBalance += amount;
                Console.WriteLine("Deposit Successful");
            }
        }

        static void Withdraw(BankAccount account)
        {
            Console.Write("\nEnter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > 0 && amount <= account.AccBalance)
            {
                account.AccBalance -= amount;
                Console.WriteLine("Withdraw Successful");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
    }
}