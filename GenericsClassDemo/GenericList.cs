using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassDemo
{
    internal class GenericList<AnyType>
    {
        AnyType[] content;
        int arrayLength = 2;
        public int Count { get; private set; } = 0;
        public GenericList()
        {
            content = new AnyType[arrayLength];
        }

        public void Add(AnyType content)
        {
            if(Count == arrayLength)
            {
                arrayLength *= 2;
                Array.Resize(ref this.content, arrayLength);
            }
            this.content[Count++] = content;
        }
        public AnyType this[int index]
        {
            get
            {
                CheckIndexInRange(index);
                return content[index];
            }
            set
            {
                CheckIndexInRange(index);
                content[index] = value;
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
                yield return content[i];
            }
        }
        public void Sort(Func<AnyType, AnyType, bool> compare)
        {
            for(int i = 0; i < Count - 1; i++)
            {
                var lowValIndex = i;
                for(int j = i; j < Count; j++)
                {
                    if(compare(content[j], content[lowValIndex]))
                    {
                        lowValIndex = j;
                    }

                }
                if(lowValIndex != i)
                {
                    var temp = content[i];
                    content[i] = content[lowValIndex];
                    content[lowValIndex] = temp;
                }
            }
        }
    }
}
