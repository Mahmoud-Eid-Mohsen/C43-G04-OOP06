using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Second_Project
{
    public class Math_
    {


        #region methods
        public static double Add(double _var1, double _var2)
        {
            return _var1 + _var2;
        }
        public static double Subtract(double _var1, double _var2)
        {
            return _var1 - _var2;
        }
        public static double Multiply(double _var1, double _var2)
        {
            return _var2 * _var1;
        }
        public static double Divide(double _var1, double _var2)
        {
            if (_var2 == 0.0)
            {
                Console.WriteLine("can not divide by zero ");
                return double.NaN;
            }
            else
                return _var1 / _var2;

        }
        #endregion

    }
}
