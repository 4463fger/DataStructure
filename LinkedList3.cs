using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    //带两个参数的链表
    class LinkedList3<Key, Value>
    {
        private class Node
        {
            public Key key;
            public Value value;
            public Node next;

            public Node(Key key, Value value, Node next)
            {
                this.key = key;
                this.value = value;
                this.next = next;
            }

            public override string ToString()
            {
                return key.ToString() + ": " + value.ToString();
            }
        }

        private Node head;

        private int N;

        //链表初始化
        public LinkedList3()
        {
            head = null;
            N = 0;
        }

        public int Count => N;
        public bool IsEmpty => N == 0;
        //获取Key的引用
        private Node GetNode(Key key)
        {
            //从头开始
            Node cur = head;
            while (cur!=null)
            {
                if (cur.key.Equals(key))
                    return cur;

                cur = cur.next;
            }
            return null;
        }

        //
        public void Add(Key key, Value value)
        {
            //判断链表中是否以及包含key
            Node node = GetNode(key);

            if (node !=null)
            {
                head = new Node(key,value,head);
                N++;
            }
            //如果链表中包含了key，那么只需要修改对应的value
            else
                node.value = value;
        }
        //查看链表是否包含
        public bool Contains(Key key)
        {
            return GetNode(key) != null;
        }
        //通过键，查找值
        public Value Get(Key key)
        {
            Node node = GetNode(key);

            if (node ==null)
                throw new ArgumentException("键" + key + "不存在");
            else
                return node.value;
        }
        //修改键对应的值
        public void Set(Key key,Value newValue)
        {
            Node node = GetNode(key);

            if (node == null)
                throw new ArgumentException("键" + key + "不存在");
            else
                node.value = newValue;
        }
        //删除键值
        public void Remove(Key key)
        {
            if (head == null)
                return;
            //如果值在头部
            if (head.key.Equals(key))
            {
                head = head.next;
                N--;
            }
            else
            {
                Node cur = head;
                Node pre = null;

                while (cur != null) 
                {
                    if (cur.key.Equals(key))
                        break;

                    pre = cur;
                    cur = cur.next;
                }

                if (cur != null)
                {
                    pre.next = pre.next.next;
                    N--;
                }
            }
        }
    }
}
