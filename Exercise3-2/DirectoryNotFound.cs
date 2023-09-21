using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_2
{
    internal class DirectoryNotFound : UserError
    {
        public override string UEMessage()
        {
            return "Directory not found. This fired an error!";
        }
    }
}
