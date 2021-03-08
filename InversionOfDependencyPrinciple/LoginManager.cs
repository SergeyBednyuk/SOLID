using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfDependencyPrinciple
{
    //High level class
    class LoginManager
    {
        //without DI principle
        private SimpleLogin _simpleLogin;
        //with DI principle
        private iAuthenticator _authenticator;

        public LoginManager()
        {
            _simpleLogin = new SimpleLogin();
            _authenticator = new SimpleLogin();
        }

        //without DI principle
        public void Login1(User user)
        {
            _simpleLogin.Authentication(user);
        }
        //with DI principle
        public void Login2(User user)
        {
            _authenticator.Authentication(user);
        }
    }
}
