using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    public class Account
    {
        int userAccountBalance;
        int theUserAccountNumber;

        public void MainMenu() //created method for main menu
        {
            Console.WriteLine("Thank you for entering in your information. We will use it to update your Client Profile. Please select an option so that we may assist you further");
            Console.WriteLine();
            Console.WriteLine("1. View Client Information");  //- [ ] View Client Information
            Console.WriteLine("2. View Account Balance"); //- [ ] View Account Balance    
            Console.WriteLine("3. Deposit Funds"); //- [ ] Deposit Funds          
            Console.WriteLine("4. Withdraw Funds"); //- [ ] Withdraw Funds   
            Console.WriteLine("5. Exit"); //- [ ] Exit
            Console.WriteLine();           
        }
       
        //created method for submenu option allowing user to choose which account they wanted 
        public void CheckingorSavings()
        {
            Console.WriteLine("Which iBank Account would you like to use for your previously selected transaction?\n");
            Console.WriteLine("1. Checking Account");
            Console.WriteLine("2. Savings Account");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
        }        
        int userOption = int.Parse(Console.ReadLine());

        public void UserPicksCheckingOrSavings()
        {
            switch (userOption)
            {
                case 1:
                    Console.ReadLine();
                    break;
                case 2:
                    Console.ReadLine();
                    break;
            }
        }

            public void UserChoosesChecking()
        {
            if (userOption == 1)
            {
                Console.WriteLine("How much would you like to deposit?");
                userOption = int.Parse(Console.ReadLine());
            }
            else
                Console.WriteLine("How much would you like to deposit?");
            userOption = int.Parse(Console.ReadLine());
        }

        }

        //Accounts (ALL Accounts should include the following)
        //An account number
        
        public virtual void TheUserAccountNumber()
        {
            theUserAccountNumber = 123456789;
        }
        //Balance
        
        public virtual void UserAccountBalance()
        {
            userAccountBalance = 500;
        }

        //constructor

        //Instantiate a new object of CheckingAccount class
        //CheckingAccount checking1 = new CheckingAccount("12345", 22347961.77, "Lord Tyrion's Checking Account");
    }



//need constructor in this class for project requirement...
        
        
        //An account type(savings or checking)
        //A way to view the current balance
        //User must be able to withdraw money from either account

        
      

    

