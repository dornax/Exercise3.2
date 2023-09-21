using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_2
{
    internal class CanNotReadFile : UserError
    {
        public override string UEMessage()
        {
            return "Can not read from file. This fired an error!";
        }
    }
}
