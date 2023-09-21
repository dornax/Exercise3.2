using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_2
{
    internal class CanNotWriteFile : UserError
    {
        public override string UEMessage()
        {
            return "Can not write to file. This fired an error!";
        }
    }
}
