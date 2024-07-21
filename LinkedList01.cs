using System;
using System.Text;

namespace List
{
    class LinkedList01<T>  
    {
        private class Node
        {
            public T data;//实际存储的数据
            public Node next;//指针，用来指向下一个元素
            //传入数据和指向的下个节点
            public Node(T data, Node next)
            { 
                this.data = data;
                this.next = next;
            }
            //如果不知道下个节点指向的是啥
            public Node(T data)
            {
                this.data = data;
                this.next = null;
            }

            //重写Tostring
            public override string ToString()
            {
                return data.ToString();
            }
        }

        private Node head;//记录链表的头部
        private int N;//链表存储多少元素
        public LinkedList01() 
        {
            //初始化链表，什么都没有，此时head指向null
            head = null;
            N = 0;
        }

        //定义属性，访问链表有多少个元素
        public int Count => N;
        //定义属性，访问链表是否为空
        public bool IsEmpty => N == 0;
        //增
        public void Add(int index ,T t)
        {
            if (index <0 || index > N)
                throw new ArgumentException("非法索引");
            //索引为0，表示添加在链表的头部
            if (index == 0)
            {
                Node node = new Node(t);
                node.next = head;
                head = node;
                //可以合并为head = new Node(t , head);
            }
            else 
            {
                Node pre = head;
                //通过for循环让pre指向index的位置
                for ( int i = 0; i < index-1; i++)
                    pre = pre.next;

                Node node = new Node(t);
                node.next = pre.next;
                pre.next = node;
            }
            N++;
        }
        //头部添加尾部添加
        public void AddFirst(T t) => Add(0, t);
        public void AddLast(T t) => Add(N,t);

        //查询索引的元素
        public T Get(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("非法索引");
            
            Node cur = head;
            for (int i = 0; i < index; i++)
                cur = cur.next;
            return cur.data;
        }
        //获取头部元素
        public T GetFirst() => Get(0);
        public T GetLast() => Get(N - 1);
        //修改
        public void Set(int index ,T newt)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("非法索引");

            Node cur = head;
            for (int i = 0; i < index; i++)
                cur = cur.next;

            cur.data = newt;
        }

        //查找链表是否包含元素
        public bool Contains(T t)
        {
            Node cur = head;
            while (cur != null)
            { 
                if(cur.data.Equals(t))
                    return true;

                cur = cur.next;
            }

            return false;
        }

        //删除节点
        public T RemoveAt(int index)
        {
            if (index < 0 || index >= N)
                throw new ArgumentException("非法索引");
            //删除头结点
            if (index == 0)
            {
                Node delNode = head;
                head = head.next;
                N--;
                return delNode.data;
            }
            //删除中间或尾部
            else 
            {
                Node pre = head;
                for (int i = 0;i < index-1;i++)
                    pre = pre.next;

                Node delNode = pre.next;
                pre.next = delNode.next;
                N--;
                return delNode.data;
            }
        }
        //删除头尾
        public T RemoveFirst() => RemoveAt(0);
        public T RemoveLast() => RemoveAt(N - 1);

        //通过查找元素删除节点
        public void Remove(T e)
        {
            //如果是空链表直接return
            if (head == null)
                return;
            //判断头结点是否是data
            if (head.data.Equals(e))
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
                    if (cur.data.Equals(e))
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
        //打印方法
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node cur = head;
            while (cur != null) 
            {
                sb.Append(cur.data + "->");
                cur = cur.next;
            }
            sb.Append("Null");
            return sb.ToString();
        }
    }
}
