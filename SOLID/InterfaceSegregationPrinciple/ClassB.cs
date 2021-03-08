using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class ClassB
    {
        private i2 _classI;

        public ClassB(ClassI classI)
        {
            _classI = classI;
        }

        public void CallGetDate()
        {
            Console.WriteLine(_classI.GetDate());
        }
    }
}
