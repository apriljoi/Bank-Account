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
            get                                     //Gain further understanding of why this property works
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
            Account myAccount = new Account(); //instantiated new occurence of Account Class
            Checking myChecking = new Checking(); //instantiated new occurence of Checking Class
            Savings mySavings = new Savings(); //instantiated new occurence of Savings Class
            Client theClient = new Client(); //instantiated new occurrence of Client Class
            //**instantiating these occurrences is making them exist so that the classes can talk and share information

            theClient.GetUserInputForClientProfile();//calling method created for questions I created in order to 
                                                       //get information for Client Profile. I challenged myself and 
                                                       //gathered user input for Client Profile instead of hard coding profile
            
            myAccount.MainMenu();//calling method created for Main Menu. I finally caught on to methods and I 
                                    //created methods for a couple of things that didn't really need methods.
                                    //I was a little method happy in order to practice!
            
            //use Parse method to convert an integer to a string
            int userOption = int.Parse(Console.ReadLine());
            Console.WriteLine(); //I'm so glad that I learned a blank WriteLine will get me the desired spacing for
                                    //user experience

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
                    {
                        myAccount.UserPicksCheckingOrSavings();
                    }
                break;

                case 3:
                    myAccount.CheckingorSavings();
                    {
                        myAccount.UserPicksCheckingOrSavings();
                    }
                    break;

                case 4:
                    myAccount.CheckingorSavings();
                    {
                        myAccount.UserPicksCheckingOrSavings();
                    }
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






    


