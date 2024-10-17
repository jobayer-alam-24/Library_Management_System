using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_Transferring.models
{
    public class Book
    {
        public string ISBN;
        public string Title;
        public string Author;
        public bool IsAvailable;

        public Book(string ISBN, string Title, string Author, bool IsAvailable)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Author = Author;
            this.IsAvailable = IsAvailable;
        }
        public void PrintBookDetails()
        {
            Console.WriteLine($"=====Book Information======");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Is Available: {IsAvailable}");
        }
    }
}