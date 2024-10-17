using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_Transferring.models
{
    public class LibraryService
    {
        public void BorrowBook(Book book)
        {
            if(book.IsAvailable == true)
            {
                book.IsAvailable = false;
                Console.WriteLine($"Messege: Borrowed Successfully!");
            }
            else
            {
                throw new ArgumentException("Book is Already Borrowed");            
            }
        }
        public void ReturnBook(Book book)
        {
            if(book.IsAvailable == false)
            {
                book.IsAvailable = true;
                Console.WriteLine($"Returned Successfully!");
            }
            else
            {
                throw new ArgumentException("You did not Borrow this Book. Something is Wrong!");
            }
        }
    }
}