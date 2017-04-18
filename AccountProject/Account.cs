using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    public class Account
    {
        //I have 5 ReadLines that need to have a key entered into them before the program starts...
        //I am unsure where these came from. I thought that I had some unnecessary readlines somewhere,
        //but after getting rid of those readlines, the program still requires user input for 5 lines...
        //As I continue to fix it, it gets worse, so note to self: figure out how 
        // it happened and how NOT to make this happen again!

        public int savingsBalance;
        public int checkingBalance;
           
        //created method for submenu option allowing user to choose which account they wanted 
        public void CheckingorSavings()
        {
            Console.WriteLine("Which iBank Account would you like to use for your previously selected transaction?\n");
            Console.WriteLine("1. Checking Account");
            Console.WriteLine("2. Savings Account");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
        }
        public int subUserOption = int.Parse(Console.ReadLine());

        public int SubUserOption
        {
            get
            {
                return subUserOption;
            }

            set
            {
                subUserOption = value;
            }
        }


        //methods to call account balances
        public void SavingsAccountBalance()
        {
            savingsBalance = 1000;
        }
        public void CheckingAccountBalance()
        {
            checkingBalance = 500;
        }


        //methods for Deposits...I did attempt to create a virtual method for Deposit, that I could override in 
        //derived classes, but it was not being read by the other classes...after many alterations in code, 
        //i went with multiple methods to avoid errors and be able to run program...I do understand that this
        //was a PERFECT opportunity to use the virtual and override access modifiers...
        public void CheckingDeposit()
        {
            checkingBalance = checkingBalance + 25; //removed this. to simplify. I am already defining and calling
        }                                           //this method in this class
        public void SavingsDeposit()
        {
            savingsBalance = savingsBalance + 10;
        }

        //withdrawl methods...again, a PERFECT opportunity to use access modifiers
        public void CheckingWithdrawl()
        {
            checkingBalance = checkingBalance -25;
        }
        public void SavingsWithdrawl()
        {
            savingsBalance = savingsBalance - 10;
        }

    }
        
        
        
       

      

      

        }

        
    



//need constructor in this class for project requirement...
        
        
        //An account type(savings or checking)
        //A way to view the current balance
        //User must be able to withdraw money from either account

        
      

    

