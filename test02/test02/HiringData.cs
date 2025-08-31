using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test02
{
    internal class HiringData:IComparable<HiringData>
    {
        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }

        public int CompareTo(HiringData?other)
        {
            if(other == null) return 1;
            if(Year!=other.Year) return ;
        }
    }
}
