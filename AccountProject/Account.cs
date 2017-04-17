using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    public class Account
    {              
        public int userAccountNumber;
             
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



        int userOption = int.Parse(Console.ReadLine());
        int checkingOrSavings = int.Parse(Console.ReadLine());

      

    }
}
