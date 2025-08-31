using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryToSolve.Part01
{
    internal class DerivedClass1:BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Hi from child");
        }
    }
}
