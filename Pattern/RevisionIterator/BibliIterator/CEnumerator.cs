using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliIterator
{
    public class CEnumerator<T> : IEnumerator<T>
    {
        private int position;
        private IList<T> list;
        public T Current => list[position];

        public CEnumerator(IList<T> t)
        {
            position = -1;
            list = t;
        }
        object IEnumerator.Current => list[position];

 
        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (position+1 >= list.Count)
            {
                return false;
            }
            position++;
            return true;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
