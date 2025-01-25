using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Third_Project
{
    public class PercentageDiscount : Discount

    {
        #region field
        public decimal Percentage { get; set; }
        #endregion
        #region constractor
        public PercentageDiscount(decimal Percentage)
        {
            this.Percentage=Percentage;
        }
        #endregion
        #region method
        public override decimal CalculateDiscount(decimal price, int quantity)
        {

            return (price * quantity)-( (price * quantity )* (Percentage / 100));
        } 
        #endregion
    }

}
