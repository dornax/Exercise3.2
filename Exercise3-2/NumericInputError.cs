using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_2
{
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input " +
                "in a text only field. This fires an error!";
        }
    }
}
