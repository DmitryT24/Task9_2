using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_2
{
    internal class CheckDataInputExp: Exception
    {
        public CheckDataInputExp(string msg): base(msg) { } 
    }
}
