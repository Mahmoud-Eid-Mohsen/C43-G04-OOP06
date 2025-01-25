using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Assignment.Third_Project
{
     abstract class Discount
    {
       
        public string? name { get; set; }
        public abstract decimal CalculateDiscount(decimal price, int quantity);



    }
}
