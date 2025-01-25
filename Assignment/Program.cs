using Assignment.first_project;
using Assignment.Second_Project;
using Assignment.Third_Project;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //#region test Second_Project

            //double num1 = 10;
            //double num2 = 2;

            //Console.WriteLine($"Add: {Math_.Add(num1, num2)}");
            //Console.WriteLine($"Subtract:{Math_.Subtract(num1, num2)}");
            //Console.WriteLine($"Multiply: {Math_.Multiply(num1, num2)}");
            //Console.WriteLine($"Divide: {Math_.Divide(num1, num2)}");

            //// Testing division by zero
            //Console.WriteLine($"Divide by Zero: {Math_.Divide(num1, 0)}");
            //#endregion        }
            //#region test third project
            //PercentageDiscount perce = new PercentageDiscount(10);
            //decimal disccount1= perce.CalculateDiscount(450,10);
            //Console.WriteLine(disccount1);
            //BuyOneGetOneDiscount buyOneGetOneDiscount = new BuyOneGetOneDiscount();
            //decimal disccount2 = buyOneGetOneDiscount.CalculateDiscount(47, 20);
            //Console.WriteLine(disccount2);
            //decimal disccount3 = buyOneGetOneDiscount.CalculateDiscount(100, 1);
            //Console.WriteLine(disccount3);
            //FlatDiscount flat= new FlatDiscount(50);
            //decimal disccount4 =flat.CalculateDiscount(100, 25);
            //Console.WriteLine(disccount4);

            //#endregion 
            #endregion
            #region integration
            //Console.WriteLine("enter your  type (Regular, Premium, or Guest");
            //string userType= Console.ReadLine().ToLower();

            //Console.WriteLine("Enter product price:");
            //decimal price = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("Enter product quantity:");
            //int quantity = int.Parse(Console.ReadLine());
            //User user;
            //switch (userType)
            //{
            //    case "regular":
            //        user = new RegularUser();
            //        break;
            //    case "premium":
            //        user = new PremiumUser();
            //        break;
            //    case "guest":
            //        user = new GuestUser();
            //        break;
            //    default:
            //        Console.WriteLine("Invalid user type.");
            //        return;
            //}
            //Discount discount = user.GetDiscount();
            //decimal discountAmount = 0;
            //decimal finalPrice = price * quantity;

            //if (discount != null)
            //{
            //    discountAmount = discount.CalculateDiscount(price, quantity);
            //    finalPrice -= discountAmount;
            //}

            //// Display results
            //Console.WriteLine($"User Type: {user.Name}");
            //Console.WriteLine($"Product Price: {price:C}");
            //Console.WriteLine($"Product Quantity: {quantity}");
            //Console.WriteLine($"Discount Applied: {(discount != null ? discount.Name : "None")}");
            //Console.WriteLine($"Discount Amount: {discountAmount:C}");
            //Console.WriteLine($"Final Price: {finalPrice:C}");
            #endregion
            #region first project
            // Read points from user
            Point3D P1 = ReadPoint("P1");
            Point3D P2 = ReadPoint("P2");

            // Test == operator
            Console.WriteLine($"P1 == P2: {P1 == P2}");

            // Clone P1
            Point3D P3 = (Point3D)P1.Clone();
            Console.WriteLine($"Cloned P1: {P3}");

            // Create an array of points and sort
            Point3D[] points = { P1, P2, P3, new Point3D(5, 5, 5), new Point3D(1, 2, 3) };
            Array.Sort(points);

            Console.WriteLine("Sorted Points:");
            foreach (var point in points)
            {
                Console.WriteLine(point);
            }
        }

        static Point3D ReadPoint(string pointName)
        {
            Console.WriteLine($"Enter coordinates for {pointName} (X, Y, Z):");

            int x = ReadCoordinate("X");
            int y = ReadCoordinate("Y");
            int z = ReadCoordinate("Z");

            return new Point3D(x, y, z);
        }

        static int ReadCoordinate(string coordinateName)
        {
            int value;
            while (true)
            {
                Console.Write($"{coordinateName}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }
    }
    #endregion

        }
    
