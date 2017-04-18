using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    class Checking : Account
    {

        int userOption = int.Parse(Console.ReadLine());

        public void UserChoosesCheckingDeposit() //method for checking deposit
        {
            if (userOption == 1)
            {
                Console.WriteLine("How much would you like to deposit?");
                userOption = int.Parse(Console.ReadLine());
            }
            else
                Console.WriteLine("How much would you like to deposit?");
            userOption = int.Parse(Console.ReadLine());
        }

        public void UserChoosesCheckingWithdrawl() //method for checking withdrawl
        {
            if (userOption == 1)
            {
                Console.WriteLine("How much would you like to withdraw?");
                userOption = int.Parse(Console.ReadLine());
            }
            else
                Console.WriteLine("How much would you like to withdraw?");
            userOption = int.Parse(Console.ReadLine());
        }
        //Instantiate a new object of CheckingAccount class
        //CheckingAccount checking1 = new CheckingAccount("12345", 22347961.77, "Lord Tyrion's Checking Account");



    }
}
