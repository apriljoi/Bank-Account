using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    class Program
    {
        //define variables
        public int userOption;

        static void Main(string[] args)
        {
            //- [ ] View Client Information
            //- [ ] View Account Balance            
            //- [ ] Deposit Funds          
            //- [ ] Withdraw Funds          
            //- [ ] Exit

            Account yourAccount = new Account(); //instantiated new occurence of Account
            Console.WriteLine("Welcome to The Interactive Bank of America, better known as iBank. Please select an option so that we may assist you further");
            Console.WriteLine();
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            
            //use Parse method to convert an integer to a string
            int userOption = int.Parse(Console.ReadLine());
            
            Console.WriteLine();//I like to include a blank writeline method to help with spacing
                                //I believe that it provides for a better user experience

            //Note to self: start with prefered switch case to provide functionality to menu, if doesn't work, use if else

        }


       





    }
}





    


