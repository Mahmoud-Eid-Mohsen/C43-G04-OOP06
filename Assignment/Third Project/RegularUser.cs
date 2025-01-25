using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project
{
    public  class RegularUser:User
    {
        public RegularUser()
        {
            Name = "Regular User";
        }
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
}
