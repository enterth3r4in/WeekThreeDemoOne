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

            Console.Write("Enter a 6-digit user ID: ");
            ID = int.Parse(Console.ReadLine());
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine("Customer Info");
            Console.WriteLine("[ID, last, first]\n");
            Console.WriteLine(ID + " " + lastName + ", " + firstName + "\n");

            itemDescription = "Spinning Top";
            quantity = 236;
            weight = 1.27;
            price = 3.76m;

            Console.WriteLine("First Order: ");
            Console.WriteLine("Order of " + quantity + " of " + "'"+itemDescription+"'");
            Console.WriteLine("Approx Cost (before shipping): " + quantity * price);
            Console.WriteLine("Shipping Cost: " + (decimal)(weight * quantity) * shippingConstantPerPound);
            Console.WriteLine("Total Cost: " + ((quantity * price) + ((decimal)weight * shippingConstantPerPound)));
        }
    }
}
