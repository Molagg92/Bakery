using System;
using Bakery.Models;
using System.Collections.Generic;

namespace ProjectName
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("");
            Console.WriteLine("==================================");
            Console.WriteLine("Pierre's Bakery");
            Console.WriteLine("==================================");
            Console.WriteLine("Press Enter to Continue");
            Console.WriteLine("");

            // Order Bread!
            Console.ReadLine();
            Console.WriteLine("==================================");
            Console.WriteLine("How many loaves of bread?");
            Console.WriteLine("");
            string breadInput = Console.ReadLine();  
            int breadWants = int.Parse(breadInput);
            Bread newBread = new Bread(breadWants);
            Console.WriteLine("");

            // Order Pastry!
            Console.WriteLine("==================================");
            Console.WriteLine("How many pastries?");
            Console.WriteLine("");
            string pastryInput = Console.ReadLine();
            int pastryWants = int.Parse(pastryInput);
            Pastry newPastry = new Pastry(pastryWants);
            Console.WriteLine("");

            // Point of Sale!
            int totalCost = newBread.BreadOrder() + newPastry.PastryOrder();
            Console.WriteLine("==================================");
            Console.WriteLine("");
            Console.WriteLine($"Your loaves of bread: ${newBread.BreadOrder()}");
            Console.WriteLine($"Your pastries: ${newPastry.PastryOrder()}");
            Console.WriteLine(""); 
            Console.WriteLine($"Your order total: ${totalCost}!"); 
            Console.WriteLine(""); 
            Console.WriteLine($"Have a lovely day");  
            Console.WriteLine("==================================");
            Console.WriteLine("");
            Console.WriteLine("Enter to Exit");
            Console.ReadLine();
            






        }
    }
}