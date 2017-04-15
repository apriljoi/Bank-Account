using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProject
{
    class Client        
    {
        public string clientInformation;
        private string ViewAccountNumber;

        public string ClientInformation()
        {
            Console.WriteLine("Account Number: " + ViewAccountNumber);
           return; 
        }
    }
}
