using System;
using System.Collections.Generic;
using System.Text;

namespace MT_Number2
{
    class Screen
    {
        protected string name;
        protected string password;

        public Screen(string name,string password)
        {
            this.name = name;
            this.password = password;
        }
        public string GetName()
        {
            return this.name;
        }
        public string GetPassword()
        {
            return this.password;
        }
    }
}
