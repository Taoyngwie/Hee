using System;
using System.Collections.Generic;
using System.Text;

namespace MT_Number2
{
    class Registerlist
    {
        private List<RegisterScreen> personList;

        public Registerlist()
        {
            this.personList = new List<RegisterScreen>();
        }

        public void AddNewPerson(RegisterScreen person)
        {
            this.personList.Add(person);
        }
    }
}
