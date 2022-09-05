using System;
using System.Collections;

namespace LinkedList.Model
{
    /// <summary>
    /// Односвязный список.
    /// </summary>
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// Первый элемент списка.
        /// </summary>
        public Item<T> Head { get; private set; }

        /// <summary>
        /// Последний элемент списка.
        /// </summary>
        public Item<T> Tail { get; private set; }

        /// <summary>
        /// Количество элементов в списке.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Инициализация пустого списка.
        /// </summary>
        public LinkedList()
        {
            Clear();
        }

        /// <summary>
        /// Инициализация списка с начальным элементом.
        /// </summary>
        /// <param name="data"></param>
        public LinkedList(T data)
        {
            var item = new Item<T>(data);
            SetHeadAndTail(item);
        }

        /// <summary>
        /// Добавить данные в конец списка.
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            var item = new Item<T>(data);

            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(item);
            }
        }

        /// <summary>
        /// Добавить элемент в начало списка.
        /// </summary>
        /// <param name="data"></param>
        public void AppToHead(T data)
        {
            var item = new Item<T>(data);

            item.Next = Head;
            Head = item;
            Count++;
        }

        /// <summary>
        /// Вставить данные после искомого значения.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="data"></param>
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {            
                var current = Head;

                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }

        /// <summary>
        /// Удалить первое вхождение в данный список.
        /// </summary>
        /// <param name="data"></param>
        public void Delete(T data)
        {
            if (Head != null)
            {
                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }
                    else
                    {
                        previous = current;
                        current = current.Next;
                    }
                }
            }
        }

        /// <summary>
        /// Очистить весь список.
        /// </summary>
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        /// <summary>
        /// Получить перечисление всех элементов списка.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Head;

            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        private void SetHeadAndTail(Item<T> item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }

        public override string ToString()
        {
            return "Linked list.\nЭлементов в списке: " + Count + "\n"; 
        }
    }
}
