using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliIterator
{
    public class CEnumerator2<T> : IEnumerator<T>
    {
        private int position;
        private IList<T> list;
        public T Current => list[position];

        public CEnumerator2(IList<T> t) : this(t, -2)
        {
        }

        public CEnumerator2(IList<T> t, int position)
        {
            list = t;
            this.position = position;
        }
        object IEnumerator.Current => list[position];

        public void Dispose()
        {
           
        }

        public bool MoveNext()
        {
            if (position + 2 >= list.Count)
            {
                return false;
            }
            position+=2;
            return true;
        }

        public void Reset()
        {
            position = -2;
        }
    }
}
