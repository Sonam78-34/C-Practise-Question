using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizedGenericeClassNamedLoop
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class Loop<T> : IEnumerable<T>
    {
        private  List<T> items = new List<T>();
        private int index = 0;

        public Loop()
        { 
        }

        public Loop(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                items.Add(item);
            }
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public void RotateRight()
        {
            index--;
            if (index < 0)
            {
                index = items.Count - 1;
            }
        }

        public void RotateLeft()
        {
            index++;
            if (index >= items.Count)
            {
                index = 0;
            }
        }

        public T ShowFirst()
        {
            return items[index];
        }

        public T PopOut()
        {
            T item = items[index];
            items.RemoveAt(index);
            if (index >= items.Count)
            {
                index = 0;
            }
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LoopEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LoopEnumerator : IEnumerator<T>
        {
            private readonly Loop<T> loop;
            private int index;

            public LoopEnumerator(Loop<T> loop)
            {
                this.loop = loop;
                index = loop.index;
            }

            public T Current
            {
                get
                {
                    try
                    {
                        return loop.items[index];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose() { }

            public bool MoveNext()
            {
                index++;
                if (index >= loop.items.Count)
                {
                    index = 0;
                }
                return index != loop.index;
            }

            public void Reset()
            {
                index = loop.index;
            }
        }
    }

   
    

}
