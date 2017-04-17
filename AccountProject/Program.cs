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
        private static string typesOfAccountsIHave;

        public static string TypesOfAccountsIHave //the lightbulb help feature helped me come to inserting this property
        {                                           //Note to self, why does this work and could this have been included in another class?
            get
            {
                return typesOfAccountsIHave;
            }

            set
            {
                typesOfAccountsIHave = value; //Note to self, what does the value keyword do?
            }
        }

        static void Main(string[] args)
        {
            Account myAccount = new Account(); //instantiated new occurence of Account
            Checking myChecking = new Checking();
            Savings mySavings = new Savings();
            Client theClient = new Client();

            theClient.GetUserInputForClientProfile();
            
            myAccount.MainMenu();
            
            //use Parse method to convert an integer to a string
            int userOption = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (userOption) //Note to self...should this be in the Account class to allow derived classes to inherit? 
                                //I might have to change this later
            {
                case 1:
                    theClient.ClientProfileInformation();
                    
                break;

                case 2:
                    myAccount.CheckingorSavings();
                    myAccount.UserPicksCheckingOrSavings();
                break;

                case 3:
                    myAccount.CheckingorSavings();
                    myAccount.UserPicksCheckingOrSavings();

                    break;

                case 4:
                    myAccount.CheckingorSavings();
                    myAccount.UserPicksCheckingOrSavings();

                    break;

                case 5:
                    Console.WriteLine("Thank you for banking with iBank of America. Be Well");
                    break;


            }

          
        }

        

        //Note to self: start with prefered switch case to provide functionality to menu, 
        //if doesn't work, use if else

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

            howMuchMoneyDoIHave = 500;
        }

        



    }









}






    


