using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_Transferring.models
{
    public class Library
    {
        private List<Book> bookLists = new List<Book>();
        public void AddBook(Book book)
        {
            bookLists.Add(book);
        }
        public void DisplayAllBooks()
        {
            if (bookLists.Any())
            {
                Console.WriteLine($"=====Displaying All Books========");
                foreach (Book book in bookLists)
                {
                    Console.WriteLine($"Title: {book.Title}");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"ISBN: {book.ISBN}");
                    Console.WriteLine($"Is Available: {book.IsAvailable}");
                    Console.WriteLine($"------------------------");
                }
            }
            else
            {
                throw new ArgumentException("No Books Are Available! Sorry");
            }
        }
        public void SearchABook(string title)
        {
            bool HasFound = false;
            
            foreach (Book book in bookLists)
            {
                if (book.Title == title)
                {
                    Console.WriteLine($"=====Found By Title=======");
                    Console.WriteLine($"Title: {book.Title}");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"ISBN: {book.ISBN}");
                    Console.WriteLine($"Is Available: {book.IsAvailable}");

                    HasFound = true;
                    break;
                }
            }
            if(!HasFound)
            {
                throw new ArgumentException("Not Found!");
            }
        }
    }
}