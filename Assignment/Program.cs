using Assignment.Second_Project;
using Assignment.Third_Project;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region test Second_Project

            double num1 = 10;
            double num2 = 2;

            Console.WriteLine($"Add: {Math_.Add(num1, num2)}");
            Console.WriteLine($"Subtract:{Math_.Subtract(num1, num2)}");
            Console.WriteLine($"Multiply: {Math_.Multiply(num1, num2)}");
            Console.WriteLine($"Divide: {Math_.Divide(num1, num2)}");

            // Testing division by zero
            Console.WriteLine($"Divide by Zero: {Math_.Divide(num1, 0)}");
            #endregion        }
            #region test third project
            PercentageDiscount perce = new PercentageDiscount(10);
            decimal disccount1= perce.CalculateDiscount(450,10);
            Console.WriteLine(disccount1);
            #endregion
            Console.ReadKey();
        }
    }
}
