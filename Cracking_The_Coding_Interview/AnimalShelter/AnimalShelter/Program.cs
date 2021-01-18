using System;
using System.Collections.Generic;

namespace AnimalShelter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Queue<Animal> myQueue = new Queue<Animal>();
            var cat1 = new Cat("george");
            var cat2 = new Cat("meowmeow");
            var dog1 = new Dog("charlie");
            var dog2 = new Dog("koji");
            var dog3 = new Dog("sparky");
            // sparky -> meowmeow -> koji -> charlie -> george
            myQueue.EnQueue(dog3, cat2, dog2, dog1, cat1);
            myQueue.Print();
            Console.WriteLine(myQueue.DeQueueCat().Name);

            myQueue.Print();
        }
    }

    public class Animal
    {
        public string Name;
    }

    public class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
        }
    }

    public class Cat : Animal
    {
        public Cat(string name)
        {
            Name = name;
        }
    }

    public class Queue<Animal>
    {
        public int Count { get; set; }
        private LinkedList<Animal> myList;

        public Queue()
        {
            myList = new LinkedList<Animal>();
        }

        public void EnQueue(params Animal[] animals)
        {
            Array.ForEach(animals, x => EnQueue(x));
        }

        public void EnQueue(Animal animal)
        {
            myList.AddLast(animal);
            Count = myList.Count;
        }

        public void Print()
        {
            if (myList.First == null) return;
            var current = myList.First;
            while (current != null)
            {
                Console.Write(current.Value + " ");

                current = current.Next;
            }
            Console.WriteLine();
        }

        public Animal DeQueueAny()
        {
            if (Count == 0)
                throw new Exception("Queue is empty");

            var last = myList.Last;
            myList.RemoveLast();
            Count = myList.Count;
            return last.Value;
        }

        public Animal DeQueueCat()
        {
            if (Count == 0)
                throw new Exception("Queue is empty");

            var current = myList.Last;
            while (current != null)
            {
                if (current.Value.GetType() == typeof(Cat))
                    return current.Value;

                current = current.Previous;
            }

            throw new Exception("No cats left in shelter");
        }

        public Animal DeQueueDog()
        {
            if (Count == 0)
                throw new Exception("Queue is empty");

            var current = myList.Last;
            while (current != null)
            {
                if (current.Value.GetType() == typeof(Dog))
                    return current.Value;

                current = current.Previous;
            }

            throw new Exception("No cats left in shelter");
        }
    }
}