using System;
using System.Collections;


namespace DesignPatterns.Iterator
{
    class People : IEnumerable
    {

        private Person[] _people;

        public People(Person[] pArr)
        {
            _people = new Person[pArr.Length];

            for (int i = 0; i < pArr.Length; i++)
            {
                _people[i] = pArr[i];
            }
                
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }
}
