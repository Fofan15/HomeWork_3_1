using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeHomeWork_3_1
{
    public class MyList<T>
    {
        public T[] _items;

        private int _size;

        public MyList() 
        {
            _items = new T[1];
            _size = 0;
        }

        public void Add(T item) 
        {
            if (_size == _items.Length)
            {
                Array.Resize(ref _items, _size + 1);
            }
            _items[_size++] = item;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            int count = collection.Count();
            if (_size + count > _items.Length)
            {
                Array.Resize(ref _items, _size + count);
            }
            foreach (T item in collection)
            {
                _items[_size++] = item;
            }
        }

        public bool Remove(T item)
        {
            int index = Array.IndexOf(_items, item);
            if (index != -1)
            {
                Array.Copy(_items, index + 1, _items, index, _size - index - 1);
                _items[--_size] = default;
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            Array.Copy(_items, index + 1, _items, index, _size - index - 1);
            _items[--_size] = default;
        }

        public void Sort()
        {
            Array.Sort(_items, 0, _size);
        }
    }
}
