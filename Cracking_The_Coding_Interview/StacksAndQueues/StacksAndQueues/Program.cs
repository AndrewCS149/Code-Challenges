using System;

namespace StacksAndQueues
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Add(1, 50, 4, 40, 30, 20, 10, 5, 400, 2, 1, 111);
            myStack.Print();
            var newStack = myStack.SortStack();
            Console.WriteLine();
            newStack.Print();
            Console.WriteLine();
            myStack.Print();
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

        public Stack<int> SortStack()
        {
            if (Count <= 1)
                throw new Exception("stack cannot be sorted any further");

            var newStack = new Stack<int>();
            var tmpTop = Top;
            var sortedStack = SortStack(int.Parse(Pop().ToString()), newStack);
            Top = tmpTop;
            return sortedStack;
        }

        private Stack<int> SortStack(int val, Stack<int> newStack)
        {
            if (newStack.Top == null || val <= newStack.Top.Val)
                newStack.Add(val);
            else
            {
                var tmpStack = new Stack<int>();
                while (val > newStack.Peek())
                {
                    tmpStack.Add(newStack.Pop());
                    if (newStack.Top == null) break;
                }

                newStack.Add(val);
                while (tmpStack.Count > 0)
                    newStack.Add(tmpStack.Pop());
            }

            if (Count > 0)
                return SortStack(int.Parse(Pop().ToString()), newStack);
            else
                return newStack;
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