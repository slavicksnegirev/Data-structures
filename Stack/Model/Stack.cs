using System;
using System.Linq;
using System.Collections.Generic;

namespace Stack.Model
{
    public class Stack<T> : ICloneable
    {
        private List<T> items = new List<T>();

        public int Count => items.Count;
        public bool IsEmpty => items.Count == 0;
        
        public void Push(T item)
        {
            items.Add(item);
        }

        public void Clear()
        {
            items.Clear();
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Стек пуст.");
            }
        }

        public T Peek()
        {
            if (!IsEmpty)
            {
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Стек пуст.");
            }
        }

        public override string ToString()
        {
            return $"Стек с {Count} элементами.";
        }

        public object Clone()
        {
            var newStack = new Stack<T>();
            newStack.items = new List<T>(items);
            return newStack;
        }
    }
}
