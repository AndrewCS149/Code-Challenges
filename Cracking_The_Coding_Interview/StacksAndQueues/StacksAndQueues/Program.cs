using System;

namespace StacksAndQueues
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Add(1, 50, 4, 40, 30, 20, 10);
            myStack.Print();
            Console.WriteLine(myStack.Peek());
        }
    }

    public class Node<T>
    {
        public T Val { get; set; }
        public Node<T> Next { get; set; }

        public Node(T val)
        {
            Val = val;
        }
    }

    public class Stack<T>
    {
        public Node<T> Top { get; set; }
        public int Count { get; set; }

        public Stack(T val)
        {
            Top.Val = val;
            Count = 1;
        }

        public Stack()
        {
            Count = 0;
        }

        public void Add(params T[] vals)
        {
            Array.ForEach(vals, x => Add(x));
        }

        public void Add(T val)
        {
            Count++;
            var newNode = new Node<T>(val);

            if (Top == null)
            {
                Top = newNode;
                return;
            }

            var tmp = Top;
            Top = newNode;
            Top.Next = tmp;
        }

        public T Peek()
        {
            return Top == null ? throw new Exception("Stack is empty") : Top.Val;
        }

        public int Min()
        {
            if (Top == null) throw new Exception("Stack is empty");

            int.TryParse(Top.Val.ToString(), out int min);

            var current = Top;
            while (current != null)
            {
                int.TryParse(current.Val.ToString(), out int num);
                if (num < min) min = num;
                current = current.Next;
            }

            return min;
        }

        public T Pop()
        {
            if (Top == null) throw new Exception("Stack is empty");

            Count--;
            var tmp = Top;
            Top = Top.Next;

            return tmp.Val;
        }

        public void Print()
        {
            if (Top == null) return;

            var current = Top;
            while (current != null)
            {
                Console.WriteLine(current.Val);
                current = current.Next;
            }
        }
    }

    public class Queue<T>
    {
        public Node<T> Head { get; set; }
        public int Count { get; set; }

        public Queue(T val)
        {
            Head.Val = val;
            Count = 1;
        }

        public Queue()
        {
            Count = 0;
        }
    }
}