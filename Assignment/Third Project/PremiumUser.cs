using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment.Third_Project
{
    class PremiumUser : User
    {
        public PremiumUser()
        {
            Name = "Premium User";
        }


        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
}
