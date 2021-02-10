using System;
using System.Collections.Generic;

namespace TaleOfTwoStacks
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/ctci-queue-using-two-stacks/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=stacks-queues
        // FOUND SOLUTION ONLINE.
        private static void Main(string[] args)
        {
            MyQueue queue = new MyQueue();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int operation = int.Parse(line[0]);

                if (operation == 1)
                { // enqueue
                    queue.Enqueue(int.Parse(line[1]));
                }
                else if (operation == 2)
                { // dequeue
                    queue.Dequeue();
                }
                else if (operation == 3)
                { // print/peek
                    Console.WriteLine(queue.Peek());
                }
            }
        }

        public class MyQueue
        {
            private Stack<int> stackNewestOnTop = new Stack<int>();
            private Stack<int> stackOldestOnTop = new Stack<int>();

            public void Enqueue(int value)
            {
                stackNewestOnTop.Push(value);
            }

            public int Peek()
            {
                PrepOld();
                return stackOldestOnTop.Peek();
            }

            public int Dequeue()
            {
                PrepOld();
                return stackOldestOnTop.Pop();
            }

            public void PrepOld()
            {
                if (stackOldestOnTop.Count == 0)
                    while (stackNewestOnTop.Count > 0)
                        stackOldestOnTop.Push(stackNewestOnTop.Pop());
            }
        }
    }
}