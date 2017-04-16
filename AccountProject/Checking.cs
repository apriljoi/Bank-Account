using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    class Checking : Account
    {
        int checkingAccountBalance; //define variable for use of checking account balance in this class
                               //default is private
        public void CheckingAccountNumber()
        {
            this.userAccountNumber = 123456789; //checking acct number
        }

        
    }
}
