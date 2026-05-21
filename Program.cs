using System;
using System.ComponentModel;
using System.Collections.Generic;
namespace bankapplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount Bank = new BankAccount(
                "BOE",
                "Kaviyan",
                1986460,
                5000.00
            );

            BankName();
            Welcome();
            Menu();
            bool exit = true;
            while (exit)
            {

                Console.Write("Choose an option: ");
                
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    
                    case 1:
                       

                            AccountDetails(Bank.AccHolderName,Bank.AccNumber, Bank.AccBalance);
                        break;

                    case 2:
                        CheckBalance(Bank.AccBalance);
                        break;

                    case 3:
                        Bank.Deposit(Bank.AccBalance);
                        break;

                    case 4:
                        Bank.Withdraw(Bank.AccBalance);
                        break;

                    case 5:
                        exit = false;
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

        static void Menu()
        {
            Console.WriteLine("1.View Account Details");
            Console.WriteLine("2.Check Balance");
            Console.WriteLine("3.Deposit Money");
            Console.WriteLine("4.Withdraw Money");
            Console.WriteLine("5.Exit");
            


        }

        static void AccountDetails(string AccHolderName,int AccNumber,double AccBalance)
        {
            Console.WriteLine("\nAccount Details");
            Console.WriteLine("Name: " + AccHolderName);
            Console.WriteLine("Account Number: " + AccNumber);
            Console.WriteLine("Balance: " + AccBalance);
            
        }

        static void CheckBalance(double AccBalance)
        {
            Console.WriteLine("\nCurrent Balance: " + AccBalance);
        }

        /*static void Deposit(BankAccount account)
        {
            Console.Write("\nEnter deposit amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > 0)
            {
                account.AccBalance += amount;
                Console.WriteLine($"Your Account balance is {account.AccBalance}");
                Console.WriteLine("Deposit Successful");
            }
        }*/

      /* static bool Withdraw(BankAccount account)
        {
            Console.Write("\nEnter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > 0 && amount <= account.AccBalance)
            {
                account.AccBalance -= amount;
                Console.WriteLine("Withdraw Successful");
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
                return false;
            }
        }*/
    }
}