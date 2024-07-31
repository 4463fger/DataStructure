namespace List
{
    //字典
    interface IDictionary<Key,Value>
    {
        //查看键值对的数量
        int Count { get; }
        bool IsEmpty { get; }
        void Add(Key key, Value value);
        void Remove(Key key);
        //查看是佛与包含键
        bool ContainsKey(Key key);
        //获取键对应的值
        Value Get(Key key);
        //键对应的改为新值
        void Set(Key key, Value newValue);
    }
}
