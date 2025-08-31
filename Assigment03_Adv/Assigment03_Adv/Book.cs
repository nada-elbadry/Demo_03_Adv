using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment03_Adv
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationDate { get; set; }

        public Book(string title, string author, string isbn, DateTime pubDate)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationDate = pubDate;
        }

        public override string ToString()
        {
            return $"{Title} - {Author} - {ISBN} - {PublicationDate:yyyy-MM-dd}";
        }
    }
}
