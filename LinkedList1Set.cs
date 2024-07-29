using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class LinkedList1Set<T> :ISet<T>
    {
        private LinkedList01<T> _list;

        public LinkedList1Set()
        {
            _list = new LinkedList01<T>();
        }
        public int Count => _list.Count;
        public bool IsEmpty => _list.IsEmpty;
        public void Add(T t)
        {
            _list.AddFirst(t);
        }

        public void Remove(T t)
        {
           _list.Remove(t);
        }

        public bool Contains(T t)
        {
            return _list.Contains(t);
        }
    }
}
