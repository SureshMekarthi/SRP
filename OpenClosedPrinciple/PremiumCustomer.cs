using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class PremiumCustomer : Idiscount
    {
        public double Calculate(double price)
        {
            return price * 0.2;
        }
    }
}
