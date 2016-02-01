using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekThreeDemoOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int     ID = 123;
            string firstName = "FIRST_NAME";
            string  lastName = "LAST_NAME";
            string  itemDescription = "ITEM_DESCRIPTION";
            int     quantity = 0;
            double  weight = 0.00;
            decimal price = 0.00m;
            decimal shippingConstantPerPound = 0.89m;
            decimal approximateCost;
            decimal shippingCost;
            decimal finalPrice;

            try
            {
                Console.Write("Enter a 6-digit user ID: ");
                ID = int.Parse(Console.ReadLine());
                Console.Write("Enter your first name: ");
                firstName = Console.ReadLine();
                Console.Write("Enter your last name: ");
                lastName = Console.ReadLine();

                Console.WriteLine("Customer Info");
                Console.WriteLine("[ID, last, first]\n");
                Console.WriteLine(ID + " " + lastName + ", " + firstName + "\n");

                Console.Write("Enter a product description: ");
                itemDescription = Console.ReadLine();
                Console.Write("Enter quantity of product to buy: ");
                quantity = int.Parse(Console.ReadLine());
                Console.Write("Enter the weight of each item: ");
                weight = double.Parse(Console.ReadLine());
                Console.Write("Enter the price of each item: ");
                price = decimal.Parse(Console.ReadLine());

                approximateCost = quantity * price;
                shippingCost = quantity * ((decimal)weight * shippingConstantPerPound);
                finalPrice = approximateCost + shippingCost;

                Console.WriteLine("\n\nFirst Order:\n");
                Console.WriteLine("You have ordered " + quantity + " of " + itemDescription);
                Console.WriteLine("The approximate price (without shipping cost): " + approximateCost);
                Console.WriteLine("Shipping cost: " + shippingCost);
                Console.WriteLine("Final price: " + finalPrice);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
