using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    class Savings: Account   
    {
        int userOption = int.Parse(Console.ReadLine());
        public void UserChoosesSavingsDeposit() //method for savings deposit
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

        public void UserChoosesSavingsWithdrawl() //method for savings withdrawl
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
    }
}
