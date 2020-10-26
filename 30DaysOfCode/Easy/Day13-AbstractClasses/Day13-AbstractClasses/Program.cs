using System;

namespace Day13_AbstractClasses
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-abstract-classes/problem
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }

        public abstract void display();
    }

    //Write MyBook class

    internal class MyBook : Book
    {
        private int price = 0;

        public MyBook(String title, String author, int price) : base(title, author)
        {
            this.price = price;
        }

        public override void display()
        {
            Console.Write($"Title: {title} \nAuthor: {author} \nPrice: {price}");
        }
    }
}