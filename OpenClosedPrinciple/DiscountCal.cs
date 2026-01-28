using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class DiscountCal
    {
        private readonly Idiscount idiscount;

        public DiscountCal(Idiscount idiscount)
        {
            this.idiscount = idiscount;
        }

        public double Calculate(double price)
        {
           return  idiscount.Calculate(price);
        }

      
    }
}
