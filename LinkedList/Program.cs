using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new Model.LinkedList<int>();

            //for (int i = 1; i < 6; i++)
            //{
            //    list.Add(i);
            //}

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //list.Delete(3);
            //list.Delete(1);
            //list.Delete(7);

            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //list.AppToHead(7);
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //list.InsertAfter(4, 8);
            //foreach (var item in list)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            var circularList = new Model.CircularLinkedList<int>();

            for (int i = 1; i < 6; i++)
            {
                circularList.Add(i);
            }

            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            circularList.Delete(3);
            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


            var duplexList = new Model.DuplexLinkedList<int>();

            for (int i = 1; i < 6; i++)
            {
                duplexList.Add(i);
            }

            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }

            duplexList.Delete(3);
            foreach (var item in duplexList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            var reverse = duplexList.Reverse();
            foreach (var item in reverse)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


            var list = new Model.LinkedList<int>();

            for (int i = 1; i < 6; i++)
            {
                list.Add(i);
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.Delete(3);
            list.Delete(1);
            list.Delete(7);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.AppToHead(7);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            list.InsertAfter(4, 8);
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
