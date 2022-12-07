using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassDemo
{
    internal class GenericList<AnyType> : IEnumerable
    {
        AnyType[] collection;
        int arrayLength = 2;
        public int Count { get; private set; } = 0;
        public GenericList()
        {
            collection = new AnyType[arrayLength];
        }

        public void Add(AnyType item)
        {
            if(Count == arrayLength)
            {
                arrayLength *= 2;
                Array.Resize(ref this.collection, arrayLength);
            }
            this.collection[Count++] = item;
        }
        public AnyType this[int index]
        {
            get
            {
                CheckIndexInRange(index);
                return collection[index];
            }
            set
            {
                CheckIndexInRange(index);
                collection[index] = value;
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
                yield return collection[i];
            }
        }
        public void Sort(Func<AnyType, AnyType, bool> comparer)
        {
            for(int i = 0; i < Count - 1; i++)
            {
                var lowValIndex = i;
                for(int j = i; j < Count; j++)
                {
                    if(comparer(collection[j], collection[lowValIndex]))
                    {
                        lowValIndex = j;
                    }

                }
                if(lowValIndex != i)
                {
                    var temp = collection[i];
                    collection[i] = collection[lowValIndex];
                    collection[lowValIndex] = temp;
                }
            }
        }
    }
}
