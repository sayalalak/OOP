using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    public class CustPrivillage : Customer
    {
        public int AccessLoungeId { get; private set; }

        public CustPrivillage()
        {

        }
        public CustPrivillage(int accessLoungeId)
        {
            AccessLoungeId = accessLoungeId;
        }
    }
}
