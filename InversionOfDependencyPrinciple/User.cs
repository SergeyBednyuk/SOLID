using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfDependencyPrinciple
{
    class User
    {
        private int _id;
        private string _userName;
        private string _password;

        public int Id 
        {
            get { return _id; } 
            set { _id = value; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public override string ToString()
        {
            return $"Id - {Id}, Name - {UserName}, Password - {Password}";
        }
    }
}
