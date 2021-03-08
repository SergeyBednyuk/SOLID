using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiscovSobstitutionPrinciple
{
    public class ClassA
    {
        protected string _text;

        public ClassA()
        {
            _text = "ClassA";
        }

        public virtual void DoSmth()
        {
            Console.WriteLine(_text);
        }
    }
}
