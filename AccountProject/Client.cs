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
        private string firstAndLastName;
        private string whereILive;
        private string getTheDigits;
        private string typesOfAccountsIHave;

      
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
        public void Account(string firstAndLastName, string whereILive, string getTheDigits)
        {
            this.firstAndLastName = firstAndLastName;
            this.whereILive = whereILive;
            this.getTheDigits = getTheDigits;           
                           
         }
          
        //method
        public void ClientProfileInformation()
        {
            Console.WriteLine("Name: " + firstAndLastName);
            Console.WriteLine("Address: " + whereILive);
            Console.WriteLine("Phone Number: " + getTheDigits);
            Console.WriteLine("Accounts: " + TypesOfAccountsIHave);
            
        }
    



}
}
