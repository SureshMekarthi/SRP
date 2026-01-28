using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Idiscount discount = new RegularCustomer();
            DiscountCal discountCal = new DiscountCal(discount);
            double result = discountCal.Calculate(100);
            Console.WriteLine(result);
            Console.ReadLine();

        } 
    
    }
}
