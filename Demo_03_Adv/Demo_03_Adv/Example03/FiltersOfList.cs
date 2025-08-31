using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03_Adv.Example03
{
    internal static class FiltersOfList
    {
        public static bool CheckOdd(int number)
        {
            return number % 2 == 1;
        }
        public static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }
        public static bool DivisibleBy7(int number)
        {
            return number % 7 == 0;
        }
        public static bool DivisibleBy10(int number)
        {
            return number % 10 == 0;
        }

        public static bool CheckLengthMoreThanFour(string? name)
        {
            return name?.Length > 4;
        }
        public static bool CheckLengthLessThanFour(string? name)
        {
            return name?.Length < 4;
        }
    }
}
