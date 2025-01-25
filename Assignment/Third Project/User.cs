using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment.Third_Project
{
   public abstract class User
    {
        public string Name{ get; set; }
       public  abstract Discount GetDiscount();



    }
}
