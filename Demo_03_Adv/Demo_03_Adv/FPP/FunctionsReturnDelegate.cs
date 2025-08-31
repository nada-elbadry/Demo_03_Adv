using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03_Adv.FPP
{
    internal static class FunctionsReturnDelegate
    {
        public static Action DelegateAction()
        {
            return () => Console.WriteLine("Hello Route");
        }
        public static Predicate<int> DelegatePredicate()
        {
            return x => x > 0;
        }

        public static Func<char[], string> DelegateFunc()
        {
            return chars => new string(chars);
        }

    }
}
