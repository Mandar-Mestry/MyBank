using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public class Owner
    {
        public int PersonID { get; set; }
        public int AccountNumber { get; set; }

        public Owner(int personID, int accountNumber)
        {
            PersonID = personID;
            AccountNumber = accountNumber;
        }
    }
}
