using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApp
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;
// constructors
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        public static implicit operator Book(Student v)
        {
            throw new NotImplementedException();
        }
    }
}