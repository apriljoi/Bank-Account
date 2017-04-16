using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    public class Account
    {
        public int accountBalance;
       
        int userOption = int.Parse(Console.ReadLine());
        int checkingOrSavings = int.Parse(Console.ReadLine());
        

        protected float userAccountNumber; //declare for userAccountNumber...I made this protected so that derived classes
                                           //can see the account number but it remains muteable
        public string checkingDeposit; //declare field for later use when usser makes a deposit to checking acct
                                       //public so that all classes can make a deposit
        protected string checkingWithdrawl; // field for later use when user makes a withdrawl from checking acct
                                            //protected so that derived classes can know what amount is, but not all
                                            //I thought of this like in the real world, deposits anyone can do, but
                                            //withdrawls have to be approached with another layer of privacy
        protected string savingsDeposit;//for later use when user makes a deposit to savings acct
                                     //deposit made public for reason previously stated
        public string savingsWithdrawl;//for later use when usert makes a withdrawl from savings acct
                                          //withdrawl made protected for reason previously stated

        public void CheckingStatus()

        {
            ChooseAccount(); //declare method for later use when user chooses account...
                             //I put this method as protected to be inherited by derived classes, but not
                             //muteable. This way this method can be called in the other classes...

        }

        //this method will be called for each class in order for the user to pick which account
       
        public void ChooseAccount()
        {
            Console.WriteLine("Which iBank Account would you like to use for your previously selected transaction?\n");
            Console.WriteLine("1. Checking Account");
            Console.WriteLine("2. Savings Account");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
        }  
                                  
            
        
        //Accounts (ALL Accounts should include the following)
        //An account number
        //Balance
        //An account type(savings or checking)
        //A way to view the current balance
        //User must be able to withdraw money from either account

        public virtual void viewAccountNumber()
        {
            Console.WriteLine("Your account number is: " + userAccountNumber);
            
        }

        public void CheckingDeposit()// this method will be used when user makes a deposit to checking deposit
        {            
            this.checkingDeposit = Console.ReadLine();
        }

        public void CheckingWithdrawl()// method used when user wants to make a withdrawl from checking
        {
            this.checkingWithdrawl = Console.ReadLine();
        }

        public void SavingsDeposit()
        {
            this.savingsDeposit = Console.ReadLine();
        }

        public void SavingsWithdrawl()
        {
            this.savingsWithdrawl = Console.ReadLine();
        }

        

    }
}
