using System;

namespace StackOfPlates
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1);
            myStack.Print();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            myStack.Pop(1);
            myStack.Pop(1);
            myStack.Pop(1);
            myStack.Pop(1);


            myStack.Print();
            Console.WriteLine(myStack.Top.Value);
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node(int val)
        {
            Value = val;
        }
    }

    public class Stack
    {
        private List<Stack> _stacks = new List<Stack>();
        private int _threshold = 4;
        private int Count { get; set; } = 0;
        public Node Top { get; set; }

        public void Print()
        {
            foreach (Stack stack in _stacks)
            {
                Node current = stack.Top;
                while (current != null)
                {
                    Console.WriteLine(current.Value);
                    current = current.Next;
                }

                Console.WriteLine();
            }
        }

        public Node Pop(int pos)
        {
            if (_stacks.Count == 0 || pos < 0 || pos >= _stacks.Count)
                return null;

            Node result = _stacks[pos].Top;

            if (--_stacks[pos].Count == 0)
                _stacks.RemoveAt(pos);
            else
                _stacks[pos].Top = _stacks[pos].Top.Next;

            //Top = _stacks[0].Top;
            return result;
        }

        public Node Pop()
        {
            if (_stacks.Count == 0)
                return null;

            Node result = Top;

            if (--_stacks[0].Count == 0)
                _stacks.RemoveAt(0);
            else
                _stacks[0].Top = _stacks[0].Top.Next;

            Top = _stacks[0].Top;
            return result;
        }
        public void Push(int val)
        {
            Node newNode = new Node(val);
            if (_stacks.Count == 0 || _stacks[0].Count == _threshold)
                _stacks.Insert(0, new Stack());
            else
                newNode.Next = _stacks[0].Top;

            _stacks[0].Top = newNode;
            Top = newNode;
            _stacks[0].Count++;
        }

        public void Push(params int[] values)
        {
            foreach (int val in values) Push(val);
        }
    }
}

/*
 
1
2
3
4
5
6
7
8


0    1      2

1    5      9
2    6      10
3    7      11
4    8      12



*/