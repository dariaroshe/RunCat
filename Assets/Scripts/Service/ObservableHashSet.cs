using System;
using System.Collections;
using System.Collections.Generic;

namespace Service
{
    public class ObservableHashSet<T> : IEnumerable<T>
    {
        public event Action<T> ItemAdded;
        public event Action<T> ItemRemoved;
        
        private HashSet<T> _hashSet = new HashSet<T>();

        public void Add(T item)
        {
            _hashSet.Add(item);
            ItemAdded?.Invoke(item);
        }

        public void Remove(T item)
        {
            _hashSet.Remove(item);
            ItemRemoved?.Invoke(item);
        }

        public void Clear()
        {
            _hashSet.Clear();
        }

        public bool Contains(T item)
        {
            return _hashSet.Contains(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _hashSet.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}