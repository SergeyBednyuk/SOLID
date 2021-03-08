using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfDependencyPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Id = 1, UserName = "Peter", Password = "12345" };

            LoginManager loginManager = new LoginManager();
            loginManager.Login1(user);
            loginManager.Login2(user);
        }
    }
}
