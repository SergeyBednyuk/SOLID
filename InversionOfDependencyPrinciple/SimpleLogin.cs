using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfDependencyPrinciple
{
    //Low level class 
    class SimpleLogin : iAuthenticator
    {
        public bool Authentication(User user)
        {
            //some logic
            return true;
        }
    }
}
