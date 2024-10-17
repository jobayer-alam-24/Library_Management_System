using Model_Transferring.models;

namespace Model_Transferring
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Book book1 = new Book("B1B", "The Great Adventure", "John Doe", true);
                Book book2 = new Book("B2C", "Mystery of the Night", "Jane Smith", false);
                Book book3 = new Book("B3D", "The Last Voyage", "William Turner", true);
                Book book4 = new Book("B4E", "Science and Future", "Albert Einstein", false);
                Book book5 = new Book("B5F", "Journey to Mars", "Elon Musk", true);

                Library library1 = new Library();
                LibraryService libraryService = new LibraryService();
                library1.AddBook(book1);
                library1.AddBook(book2);
                library1.AddBook(book3);
                library1.AddBook(book4);
                library1.AddBook(book5);
                library1.DisplayAllBooks();
                library1.SearchABook("The Great Adventure");
                libraryService.BorrowBook(book1);
                libraryService.ReturnBook(book1);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}