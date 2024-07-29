using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class LinkedList3Dictionary<Key ,Value> :IDictionary<Key,Value>
    {
        private LinkedList3<Key, Value> List;
        
        public LinkedList3Dictionary()
        {
            List = new LinkedList3<Key, Value>();
        }

        public int Count => List.Count;
        public bool IsEmpty => List.IsEmpty;
        public void Add(Key key, Value value)
        {
            throw new NotImplementedException();
        }

        public void Remove(Key key)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(Key key)
        {
            throw new NotImplementedException();
        }

        public Value Get(Key key)
        {
            throw new NotImplementedException();
        }

        public void Set(Key key, Value newValue)
        {
            throw new NotImplementedException();
        }
    }
}
