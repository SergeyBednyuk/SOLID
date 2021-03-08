using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class ClassI : i1, i2
    {
        public string GetName()
        {
            return "Name";
        }

        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
