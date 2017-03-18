using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Iterator
{
    class PeopleEnum : IEnumerator
    {
        private Person[] people;
        
        //To iterate over the elements of the collection
        private int index = -1;

        public PeopleEnum(Person[] val)
        {
            people = val;
        }

        //Get the current element
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Person Current
        {
            get
            {
                return people[index];
            }
        }

        //Check if the next element exists
        public bool MoveNext()
        {
            index++;
            return (index < people.Length);
        }

        //Reset the index count;
        public void Reset()
        {
            index = -1;
        }
    }
}
