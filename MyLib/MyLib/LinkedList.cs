using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace MyLib
{
    public class MyLinkedList<T>:ListInterface<T>
    {

        private Node<T> head;
        private Node<T> tail;

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Push(T item)
        {
            Node<T> current = head;
            if (current == null) addFirst(item);

            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node<T>(item);
            }
        }

        public void InsertAt(T item, int index)
        {
            throw new NotImplementedException();
        }

        public T Pop()
        {
            Node<T> current = head;
            Node<T> previous = current;

            if (current == null)
                throw new ArgumentNullException();

            while (current.Next != null)
            {
                if (current.Next.Next == null)
                {
                    previous = current;
                }
                current = current.Next;
            }

            previous.Next = null;
            return current.Item;
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        private void addFirst(T item)
        {
            head = new Node<T>(item);
        }


        public int Size()
        {
            Node<T> current = head;
            int counter = 1;
            while (current.Next != null)
            {
                current = current.Next;
                counter++;
            }
            return counter;
        }
    }

    /// <summary>
    /// A generic node class which contains the item data and a reference to the next node.
    /// </summary>
    /// <typeparam name="T">A generic type assigned dynamically.</typeparam>
    public class Node<T>
    {
        private T item;
        private Node<T> next;

        public Node(T item)
        {
            this.Item = item;
        }

        public Node(T item, Node<T> next)
        {
            this.Item = item;
            this.Next = next;
        }

        public T Item
        {
            get
            {
                return this.item;
            }
            set
            {
                item = value;
            }
        }

        public Node<T> Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }

    }
}
