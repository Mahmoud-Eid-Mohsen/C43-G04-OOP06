using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment.Third_Project
{
    class GuestUser : User
    {
        public GuestUser()
        {
            Name = "Guest User";
        }

        public override Discount GetDiscount()
        {
            return null; // No discount for guest users
        }
    }

}
