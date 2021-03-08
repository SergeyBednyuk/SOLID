using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfDependencyPrinciple
{
    interface iAuthenticator
    {
        bool Authentication(User user);
    }
}
