using System;
using System.Text;

namespace List
{
    //带有尾指针的单链表
    class LinkedList02<T>
    {
        //链表的节点类
        private class Node
        {
            public T data;
            public Node next;
            public Node(T data, Node next)
            {
                this.data = data;
                this.next = next;
            }
            public Node(T data)
            {
                this.data = data;
                this.next = null;
            }
            public override string ToString()
            {
                return base.ToString();
            }
        }

        private Node head;
        private Node tail;
        private int N;

        public LinkedList02()
        {
            head = null;
            tail = null;
            N = 0;
        }

        public int Count => N;
        public bool IsEmpty => N == 0;
        //往链表尾部添加元素
        public void AddLast(T t)
        {
            Node node = new Node(t);
            if(IsEmpty) 
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
            N++;
        }
        //链表头部删除节点
        public T RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("链表为空");
            //删除的元素
            T t = head.data;
            //移动指针
            head = head.next;

            N--;

            if (head == null)
            {
                tail = null;
            }

            return t;
        }
        //查看头部
        public T GetFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("链表为空");


            return head.data;
        }
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
