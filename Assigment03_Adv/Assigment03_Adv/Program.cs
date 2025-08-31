namespace Assigment03_Adv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>
        {
            new Book("Clean Code", "Robert Martin", "12345", new DateTime(2008, 8, 1)),
            new Book("C# in Depth", "Jon Skeet", "67890", new DateTime(2019, 4, 2))
        };

            Console.WriteLine("=== Using User Defined Delegate ===");
           // LibraryEngine.ProcessBooks(books, new BookFunctions.BookDelegate(BookFunctions.GetTitle));

            Console.WriteLine("=== Using BCL Delegate (Func) ===");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthor);

            Console.WriteLine("=== Using Anonymous Method ===");
            LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });

            Console.WriteLine("=== Using Lambda Expression ===");
            LibraryEngine.ProcessBooks(books, static b => b.PublicationDate.ToShortDateString());
        }
    }
}





