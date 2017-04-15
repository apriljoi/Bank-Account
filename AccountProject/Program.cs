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
            Account yourAccount = new Account();

            //define variables
            int userOption;
            


            //- [ ] View Client Information
            //- [ ] View Account Balance
            //- [ ] Checking Account Balance
            //- [ ] Savings Account Balance
            //- [ ] Deposit Funds
            //- [ ] To Checking Account
            //- [ ] To Savings Account
            //- [ ] Withdraw Funds
            //- [ ] From Checking Account
            //- [ ] From Savings Account
            //- [ ] Exit

            Console.WriteLine("Welcome to The Interactive Bank of America. Please select an option so that I may assist you further");
            Console.WriteLine();
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            

            //use Parse to convert an integer to a string
            userOption = int.Parse(Console.ReadLine());
        }
            


        }
    }


