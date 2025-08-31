using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03_Adv
{
    internal static class BookFunctions
    {
        // (a) User defined delegate
        public delegate string BookDelegate(Book b);

        public static string GetTitle(Book b) => b.Title;
        public static string GetAuthor(Book b) => b.Author;

        // (c) Anonymous method will be used in LibraryEngine

        // (d) Lambda Expression will be used in LibraryEngine
    }
}
