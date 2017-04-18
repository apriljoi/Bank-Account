using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    class Program
    {
        //fields 
        protected string firstAndLastName;
        protected string getTheDigits; 
        //I set this to a string so that the user input was able to accept the 000-000-0000 format

        protected string whereILive;
        protected int howMuchMoneyDoIHave;

        public static int subUserOption { get; private set; }

        static void Main(string[] args)
        {
            Account myAccount = new Account(); //instantiated new occurence of Account Class
            Checking myChecking = new Checking(); //instantiated new occurence of Checking Class
            Savings mySavings = new Savings(); //instantiated new occurence of Savings Class
            Client theClient = new Client(); //instantiated new occurrence of Client Class
                                             //**instantiating these occurrences is making them exist so that the classes can talk and share information

            Console.WriteLine("Thank you for entering in your information. We will use it to update your Client Profile. Please select an option so that we may assist you further");
            Console.WriteLine();
            Console.WriteLine("1. View Client Information");  //- [ ] View Client Information
            Console.WriteLine("2. View Account Balance"); //- [ ] View Account Balance    
            Console.WriteLine("3. Deposit Funds"); //- [ ] Deposit Funds          
            Console.WriteLine("4. Withdraw Funds"); //- [ ] Withdraw Funds   
            Console.WriteLine("5. Exit"); //- [ ] Exit
            Console.WriteLine(); //I'm so glad that I learned a blank WriteLine will get me the desired spacing for
                                 //user experience

            //use Parse method to convert an integer to a string
            int userOption = int.Parse(Console.ReadLine());
            if(userOption == 2)
            {
                myAccount.CheckingorSavings();
                    if(subUserOption == 1)
                    {
                        Console.WriteLine("Your Checking Account Balance is: " + myAccount.checkingBalance);
                    }
                    else
                    {
                        Console.WriteLine("Your Savings Account Balance is: " + myAccount.savingsBalance);
                }

                if(userOption == 3)
                {
                    myAccount.CheckingorSavings();
                        if(subUserOption == 1)
                        {
                            myAccount.CheckingDeposit();
                        }
                        else
                        {
                            myAccount.SavingsDeposit();
                        }
                }

                if(userOption ==4)
                {
                    myAccount.CheckingorSavings();
                        if(subUserOption ==1)
                        {
                            myAccount.CheckingWithdrawl();
                        }
                        else
                        {
                            myAccount.SavingsWithdrawl();
                        }
                }
            }
            switch (userOption) //Note to self...should this be in the Account class to allow derived classes to inherit? 
                                //I might have to change this later
                                //Note to self: start with prefered switch case to provide functionality to menu, 
                                //if doesn't work, use if else
            {
                case 1:
                    theClient.ClientProfileInformation(); //The method calls, but the variables are not showing up             
                break;

                case 2:
                    myAccount.CheckingorSavings();               
                break;

                case 3:
                    myAccount.CheckingorSavings();                  
                    break;

                case 4:
                    myAccount.CheckingorSavings();                    
                    break;

                case 5:
                    Console.WriteLine("Thank you for banking with iBank of America. Be Well");
                    break;

            }
            
        }

        //constructor //note to self; this probably belongs in the account class
        public void Account()//default constructor
        {

        }
        public virtual void Account(string firstAndLastName, string whereILive, string getTheDigits, int howMuchMoneyDoIHave)
        {
            this.firstAndLastName = firstAndLastName;
            this.whereILive = whereILive;
            this.getTheDigits = getTheDigits;
            this.howMuchMoneyDoIHave = howMuchMoneyDoIHave;
                        
        }
       





    }









}






    


