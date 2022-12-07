using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassDemo
{
    internal class ListOfPerson : IEnumerable
    {
        Person[] people;
        int arrayLength = 2;
        public int Count { get; private set; } = 0;
        public ListOfPerson()
        {
            people = new Person[arrayLength];
        }

        public void Add(Person person)
        {
            if(Count == arrayLength)
            {
                arrayLength *= 2;
                Array.Resize(ref people, arrayLength);
            }
            people[Count++] = person;
        }
        public Person this[int index]
        {
            get
            {
                CheckIndexInRange(index);
                return people[index];
            }
            set
            {
                CheckIndexInRange(index);
                people[index] = value;
            }
        }

        private void CheckIndexInRange(int index)
        {
            if(index >= Count || index < 0)
                throw new IndexOutOfRangeException();
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < Count; i++)
            {
                yield return people[i];
            }
        }
        public void Sort()
        {
            for(int i = 0; i < Count - 1; i++)
            {
                var lowValIndex = i;
                for(int j = i; j < Count; j++)
                {
                    if(people[j].YearOfBirth < people[lowValIndex].YearOfBirth)
                    {
                        lowValIndex = j;
                    }

                }
                if(lowValIndex != i)
                {
                    var temp = people[i];
                    people[i] = people[lowValIndex];
                    people[lowValIndex] = temp;
                }
            }
        }
        public void Sort(Func<Person, Person, bool> compare)
        {
            for(int i = 0; i < Count - 1; i++)
            {
                var lowValIndex = i;
                for(int j = i; j < Count; j++)
                {
                    if(compare(people[j], people[lowValIndex]))
                    {
                        lowValIndex = j;
                    }

                }
                if(lowValIndex != i)
                {
                    var temp = people[i];
                    people[i] = people[lowValIndex];
                    people[lowValIndex] = temp;
                }
            }
        }
    }

}

