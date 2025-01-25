using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment.Third_Project
{
   public class FlatDiscount:Discount
    {

        public decimal FlatAmount { get; set; }

        public FlatDiscount( decimal flatAmount)
        {
           
            FlatAmount = flatAmount;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return FlatAmount * Math.Min(quantity, 1);
        }
    }
}
