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
            List.Add(key,value);
        }

        public void Remove(Key key)
        {
            List.Remove(key);
        }

        public bool ContainsKey(Key key)
        {
           return List.Contains(key);
        }

        public Value Get(Key key)
        {
            return List.Get(key);
        }

        public void Set(Key key, Value newValue)
        {
           List.Set(key,newValue);
        }
    }
}
