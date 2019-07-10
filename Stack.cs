using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamicStack
{
    public class Stack<T>
    {
        private T[] items;
        private int count;

        public Stack()
        {
            items = new T[15];
        }

        public Stack(int length)
        {
            items = new T[length];
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public int Count
        {
            get { return count; }
        }

        private void Resize()
        {
            Array.Resize(ref items, items.Length + 15);
        }

        public void Push(T item)
        {
            if (count == items.Length)
            {
                Resize();
            }
            items[count++] = item;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T item = items[--count];
            items[count] = default(T);
            if (count > 0 && count < items.Length - 15)
            {
                Resize();
            }
            return item;
        }
        public T Peek()
        {
            return items[count - 1];
        }

        public T Clear()
        {
            Array.Clear(items, 0, items.Length);
            return items[count];
        }
    }
}
