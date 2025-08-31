using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03_Adv.Example02
{
    internal static class SortingStrategy
    {
        public static bool SortAsc(int X, int Y)
        {
            return X > Y;
        }
        public static bool SortDesc(int X, int Y)
        {
            return X < Y;
        }

        public static bool SortAsc(string? X, string? Y)
        {
            return X?.Length > Y?.Length;
        }
        public static bool SortDesc(string? X, string? Y)
        {
            return X?.Length < Y?.Length;
        }
    }
}
