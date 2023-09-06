using System.Collections;

namespace BibliIterator
{
    public class CCollection<T> : IList<T>
    {
        private List<T> maCollection;

        public CCollection()
        {
            maCollection = new List<T>();
        }
        public T this[int index] { get => maCollection[index]; set => throw new NotImplementedException(); }

        public int Count => maCollection.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            maCollection.Add(item);
        }

        public void Clear()
        {
            maCollection.Clear();
        }

        public bool Contains(T item)
        {
            return maCollection.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            maCollection.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new CEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new CEnumerator<T>(this);
        }

        public int IndexOf(T item)
        {
            return maCollection.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            maCollection.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return maCollection.Remove(item);
        }

        public void RemoveAt(int index)
        {
            maCollection.RemoveAt(index);
        }

        
    }
}