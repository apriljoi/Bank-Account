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

        static void Main(string[] args)
        {
            Account yourAccount = new Account(); //instantiated new occurence of Account

            //Greeting for the user
            Console.WriteLine("Welcome to The Interactive Bank of America, better known as iBank. Please answer the Client Profile questions to make sure that we have the most up to date information on file");
            Console.WriteLine();

            Console.Write("Please enter your first and last name: "); //gather the user name for client info to be used later
            string firstAndLastName = Console.ReadLine();
            firstAndLastName = firstAndLastName.ToUpper();

            Console.Write("Please enter your street address: "); //gather user address for use later in client info
            string whereILive = Console.ReadLine();
            whereILive = whereILive.ToUpper();

            Console.Write("Please enter your phone number in this format 000-000-0000: "); //gather user phone # for use later in client info
            string getTheDigits = Console.ReadLine();
            getTheDigits = getTheDigits.ToUpper();

            Console.WriteLine();//I like to include a blank writeline method to help with spacing
                                //I believe that it provides for a better user experience

           


            Console.WriteLine("Thank you for entering in your information. We will use it to update your Client Profile. Please select an option so that we may assist you further");
            Console.WriteLine();
            Console.WriteLine("1. View Client Information");  //- [ ] View Client Information
            Console.WriteLine("2. View Account Balance"); //- [ ] View Account Balance    
            Console.WriteLine("3. Deposit Funds"); //- [ ] Deposit Funds          
            Console.WriteLine("4. Withdraw Funds"); //- [ ] Withdraw Funds   
            Console.WriteLine("5. Exit"); //- [ ] Exit
            Console.WriteLine();

            //use Parse method to convert an integer to a string
            int userOption = int.Parse(Console.ReadLine());
        }

        //Note to self: start with prefered switch case to provide functionality to menu, 
        //if doesn't work, use if else

        //constructor //note to self; this actually belongs in the account class
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






    


