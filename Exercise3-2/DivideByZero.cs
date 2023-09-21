using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_2
{
    internal class DivideByZero : UserError
    {
        public override string UEMessage()
        {
            return "You tried to divide by zero. " +
                "This fired an error!";
        }
    }
}
