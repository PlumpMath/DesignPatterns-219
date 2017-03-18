using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    class Person
    {
        private string firstName;
        private string lastName;

        public Person(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

        //Property to access firstName and lastName;
        public string FName
        {
            get
            {
                return firstName;
            }
        }

        public string lName
        {
            get
            {
                return lastName;
            }
        }
    }
}
