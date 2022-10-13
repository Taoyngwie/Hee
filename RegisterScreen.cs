using System;
using System.Collections.Generic;
using System.Text;

namespace MT_Number2
{
    class RegisterScreen:Screen
    {
        private string typeofuser;
        public RegisterScreen(string name, string password,string typeofuser) : base(name, password)
        {
            this.typeofuser = typeofuser;
        }
    }
}
