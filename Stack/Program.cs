using System;
using Stack.Model;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            for (int i = 1; i < 4; i++)
            {
                stack.Push(i);
            }

            var item = stack.Pop();
            var item2 = stack.Peek();

            Console.WriteLine(item);
            Console.WriteLine(item2);
            Console.ReadLine();

            Stack<double> stack1 = new Stack<double>();

            var linkedStack = new LinkedStack<int>();

            for (int i = 10; i < 40; i += 10)
            {
                linkedStack.Push(i);
            }

            Console.WriteLine(linkedStack.Peek());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Pop());
            Console.WriteLine(linkedStack.Peek());
            Console.ReadLine();

            var arrayStack = new ArrayStack<int>(5);
            Console.WriteLine(arrayStack.Count);
            arrayStack.Push(100);
            Console.WriteLine(arrayStack.Count);
            arrayStack.Push(200);
            arrayStack.Push(300);
            arrayStack.Push(400);
            arrayStack.Push(500);

            Console.WriteLine(arrayStack.Peek());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Pop());
            Console.WriteLine(arrayStack.Peek());

            Console.ReadLine();
        }
    }
}
