using System;

namespace QueueAndDeque
{
    class Program
    {
        static void Main(string[] args)
        {
            var deque = new Model.Deque<int>();

            deque.PushFront(1);
            deque.PushFront(2);
            deque.PushFront(3);
            deque.PushBack(4);
            deque.PushBack(5);
            deque.PushFront(6);
            deque.PushBack(7);

            Console.WriteLine(deque.PopFront());
            Console.WriteLine(deque.PopFront());
            Console.WriteLine(deque.PopFront());
            Console.WriteLine(deque.PopFront());
            Console.WriteLine(deque.PopFront());

            Console.ReadLine();

            var queue = new Model.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());

            Console.ReadLine();
        }
    }
}
