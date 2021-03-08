using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiscovSobstitutionPrinciple
{
    public class ClassB : ClassA
    {
        public ClassB()
        {
            _text = "ClassB";
        }

        public override void DoSmth()
        {
            Console.WriteLine(_text);
        }
    }
}
