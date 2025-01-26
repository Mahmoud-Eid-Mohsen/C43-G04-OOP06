using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project
{
    public class BuyOneGetOneDiscount:Discount
    {
        #region method


        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity > 1)

                return (price) * (quantity / 2);


            else
                return 0;
        }

        #endregion
        #region constrctor
        public BuyOneGetOneDiscount() { }

        
        #endregion
    }
}
