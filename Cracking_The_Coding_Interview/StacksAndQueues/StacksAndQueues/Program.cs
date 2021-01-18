using System;

namespace StacksAndQueues
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Queue<int> myQueue = new Queue<int>();
            myQueue.EnQueue(1, 2, 3, 4, 5);
            myQueue.Print();
            Console.WriteLine(myQueue.Peek());
            //Console.WriteLine(myQueue.Front.Val);
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

        public void Push(params T[] vals)
        {
            Array.ForEach(vals, x => Push(x));
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
                newStack.Push(val);
            else
            {
                var tmpStack = new Stack<int>();
                while (val > newStack.Peek())
                {
                    tmpStack.Push(newStack.Pop());
                    if (newStack.Top == null) break;
                }

                newStack.Push(val);
                while (tmpStack.Count > 0)
                    newStack.Push(tmpStack.Pop());
            }

            if (Count > 0)
                return SortStack(int.Parse(Pop().ToString()), newStack);
            else
                return newStack;
        }

        public void Push(T val)
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
        public int Count { get; set; }

        private Stack<T> stack;

        public Queue()
        {
            stack = new Stack<T>();
            Count = 0;
        }

        public void EnQueue(params T[] vals)
        {
            Array.ForEach(vals, x => EnQueue(x));
        }

        public void EnQueue(T val)
        {
            stack.Push(val);
            Count = stack.Count;
        }

        public T Peek()
        {
            if (Count == 0)
                throw new Exception("Queue is empty");

            var current = stack.Top;
            while (current.Next != null)
                current = current.Next;

            return current.Val;
        }

        public void DeQueue(int count)
        {
            for (int i = 0; i < count; i++)
                DeQueue();
        }

        public T DeQueue()
        {
            var tmpStack = new Stack<T>();
            while (stack.Count > 1)
                tmpStack.Push(stack.Pop());

            var result = stack.Pop();
            while (tmpStack.Count > 0)
                stack.Push(tmpStack.Pop());

            Count = stack.Count;
            return result;
        }

        public void Print()
        {
            var current = stack.Top;
            while (current != null)
            {
                Console.Write(current.Val + " -> ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}