using Assignment.Second_Project;

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
        }
    }
}
