using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03_Adv
{
    internal static class LibraryEngine
    {
        // (a) Using user defined delegate
        //public static void ProcessBooks(List<Book> books, BookFunctions.BookDelegate fPtr)
        //{
        //    foreach (var book in books)
        //    {
        //        Console.WriteLine(fPtr(book));
        //    }
        //}

        // (b) Using BCL delegates (Func)
        public static void ProcessBooks(List<Book> books, Func<Book, string> fPtr)
        {
            foreach (var book in books)
            {
                Console.WriteLine(fPtr(book));
            }
        }
    }
}
