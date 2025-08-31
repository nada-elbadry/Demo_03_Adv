using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryToSolve.Part01
{
    internal class Manger:Employee
    {
        public override void Works()
        {
            base.Works();
            Console.WriteLine("Manger is Manging now");
        }

    }
}
