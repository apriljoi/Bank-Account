using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    class Client
    {
        private string firstAndLastName;
        private string whereILive;
        private string getTheDigits;
        private string typesOfAccountsIHave;

        //This class will populate the client class. As of now, I know nothing about databases, but this would 
        //be a perfect opportunity to be able to redo this project once databases are learned. If this were an 
        //actual account, this information would be kept in a database. For now, I will get user input for 
        //this information and repeat it back to the customer after all input is recieved...


        //This was my template from class for properties...Since I am just using this information for later, 
        //I just used a get not a set
        //public int Seats
        //{
        //  get { return this.seats; }
        //}

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
        public void Account(string firstAndLastName, string whereILive, string getTheDigits, string typesofAccountsIHave)
        {
            this.firstAndLastName = firstAndLastName;
            this.whereILive = whereILive;
            this.getTheDigits = getTheDigits;     
                 
         }




    //public string ViewAccountNumber;
    //public int accountBalance = 500;



}
}
