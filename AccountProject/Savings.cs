using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    class Savings: Account
    {
        int theUserAccountNumber;

        public override void TheUserAccountNumber()//this is my attempt to use an override method...
                                                   //I'm not sure that I executed this properly
        {
            theUserAccountNumber = 987654321;
        }

        int userAccountBalance;
        public override void UserAccountBalance()//this is my attempt to use an override method... 
                                                //I'm not sure that I executed this properly
        {
            userAccountBalance = 750;
        }
    }
}
