using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap18___Making_Your_Own_Classes
{
    internal class Book
    {
        // Variables.
        private string title;
        private string author;
        private int pages;
        private int wordCount;

        // Constructors.

        public Book()
        { }
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public Book(string title, string author, int pages, int wordCount)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.wordCount = wordCount;
        }

        // Modules.
        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        public int AssignWordCountFromText(string text)
        {
            return wordCount = text.Split(' ').Length;
        }

    }


}
