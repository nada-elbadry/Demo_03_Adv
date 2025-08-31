using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test02
{
    enum Securitylevel
    {
        None=0,
        Guest=1<<0,
        Developer=1<<1,
        Secretary=1<<2,
        DBA=1<<3,
        FullAccess = Guest | Developer | Secretary | DBA
    }
}
