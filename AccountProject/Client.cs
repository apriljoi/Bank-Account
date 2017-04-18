using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    class Client
    {
        //Client Class
        //3 properties
        //1 constructor
        //1 method
        //Client information should be filled in here

         //fields
        public string firstAndLastName;
        public string whereILive;
        public string getTheDigits;
        public string typesOfAccountsIHave;
       
        //Greeting for the user (method)
        public void GetUserInputForClientProfile()
        {
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
        }

                 
        //Properties...4/3 required
        //These properties will be used to get the Client information that is required for this project
        //I took the route of getting user input for this information to make it seem more realistic. If 
        //I had SQL or databases in my toolbox, this information would be collected from a database.

        public string FirstAndLastName
        {
            get { return firstAndLastName; }
            set { firstAndLastName = Console.ReadLine(); }
        }
        
        public string WhereILive
        {
            get { return whereILive; }
            set { whereILive = Console.ReadLine(); }
        }


        public string GetTheDigits
        {
            get { return getTheDigits; }
            set { getTheDigits = Console.ReadLine(); }
        }

        public string TypesOfAccountsIHave
        {
            get { return typesOfAccountsIHave; }
            set { typesOfAccountsIHave = "You currently have both Checking and Savings accounts with iBank of America"; }
        }
                
        
        //constructor
        //1/1 constructor required...
        public void Account()//default constructor
        {

        }
        public Client(string firstAndLastName, string whereILive, string getTheDigits, string typesOfAccountsIHave)
        {
            this.firstAndLastName = firstAndLastName;
            this.whereILive = whereILive;
            this.getTheDigits = getTheDigits;
            this.typesOfAccountsIHave = typesOfAccountsIHave;
        }

        public Client()
        {
        }


        // 1 method
        //Client information should be filled in here
        
        public void ClientProfileInformation()
        {
            Console.WriteLine("Name: " + firstAndLastName);            
            Console.WriteLine("Address: " + whereILive);            
            Console.WriteLine("Phone Number: " + getTheDigits);            
            Console.WriteLine("Accounts: " + typesOfAccountsIHave);

        }





    }
}
