using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class People
    {
        private List<Person> _list = new List<Person>();

        public int Count { get; }

        public void Add(Person person)
        {
            _list.Add(person);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public IEnumerable<Person> GetAllPeople()
        {
            return _list;
        }
        //This method filted people whose mobile type is Android
        public IEnumerable<Person> GetAndroidPeople()
        {
            var android = new List<Person>();

            foreach (var person in _list)
            {
                if (person.MobileType == MobileType.Android)
                {
                    android.Add(person);
                }
            }
            return android;
        }

        //This method filted people whose mobile type is Apple
        public IEnumerable<Person> GetApplePeople()
        {
            var apple = new List<Person>();

            foreach (var person in _list)
            {
                if (person.MobileType == MobileType.Apple)
                {
                    apple.Add(person);
                }
            }
            return apple;
        }

    }
}
