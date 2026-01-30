using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstritue
{
    internal class Sparrow : IFlyingBird
    {
        public void Fly()
        {
            Console.WriteLine("sparrow is flying");
        }
    }
}
