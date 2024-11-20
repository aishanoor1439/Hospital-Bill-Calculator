using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Bill_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taking input from user
            Console.WriteLine("Enter the total cost of the tests:");
            double totalCost = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the category (community, needy, employee):");
            string category = Console.ReadLine().ToLower();

            //Declaring varible for final amount
            double payable = totalCost;

            // Determine the discount based on category
            switch (category)
            {
                case "community":
                    payable = totalCost * 0.5; // 50% discount
                    Console.WriteLine("A 50% discount has been applied.");
                    break;

                case "needy":
                    payable = totalCost * 0.7; // 30% discount
                    Console.WriteLine("A 30% discount has been applied.");
                    break;

                case "employee":
                    payable = totalCost * 0.8; // 20% discount
                    Console.WriteLine("A 20% discount has been applied.");
                    break;

                default:
                    Console.WriteLine("No discount applied.");
                    break;
            }

            // Output: Final bill amount after applying the discount
            Console.WriteLine("The final bill: {0:C}", payable);
    }
    }
}
