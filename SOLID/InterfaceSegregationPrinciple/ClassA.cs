using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    public class ClassA
    {
        private i1 _classI;

        public ClassA()
        {
            _classI = new ClassI();
        }

        public ClassA(ClassI classI)
        {
            _classI = classI;        }

        public void CallGetName()
        {
            Console.WriteLine(_classI.GetName());
        }
    }
}
