using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    class Program
    {            
        
        static void Main(string[] args)
        {                       
            Account yourAccount = new Account(); //instantiated new occurence of Account
            
            //Greeting for the user
            Console.WriteLine("Welcome to The Interactive Bank of America, better known as iBank. Please select an option so that we may assist you further");
            Console.WriteLine();

            Console.WriteLine("Please enter your first and last name"); //gather the user name for client info to be used later
            string firstAndLastName = Console.ReadLine();
            firstAndLastName = firstAndLastName.ToUpper();

            Console.WriteLine("Please enter your street address"); //gather user address for use later in client info
            string userAddress = Console.ReadLine();
            userAddress = userAddress.ToUpper();

            Console.WriteLine("Please enter your phone number in this format 000-000-0000"); //gather user phone # for use later in client info
            string getTheDigits = Console.ReadLine();
            getTheDigits = getTheDigits.ToUpper();
       
            Console.WriteLine();//I like to include a blank writeline method to help with spacing
                                //I believe that it provides for a better user experience

            //Note to self: start with prefered switch case to provide functionality to menu, 
            //if doesn't work, use if else


            Console.WriteLine("1. View Client Information");  //- [ ] View Client Information
            Console.WriteLine("2. View Account Balance"); //- [ ] View Account Balance    
            Console.WriteLine("3. Deposit Funds"); //- [ ] Deposit Funds          
            Console.WriteLine("4. Withdraw Funds"); //- [ ] Withdraw Funds   
            Console.WriteLine("5. Exit"); //- [ ] Exit
            Console.WriteLine();

            //use Parse method to convert an integer to a string
            int userOption = int.Parse(Console.ReadLine());

        }








    }
}





    


