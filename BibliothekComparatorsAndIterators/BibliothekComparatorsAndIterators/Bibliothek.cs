using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothekComparatorsAndIterators
{
    public class Bibliothek
    {
        public string Title { get { return this.Title; } set { this.Title = value; } }
        public int Year { get { return this.Year; } set { this.Year = value; } }

        public IReadOnlyList<string> listAuthors { get; private set; }

        public Bibliothek(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            this.listAuthors = authors;
        }

        public override string ToString()
        {
            return $"Book {this.Title} is disposed {this.Year} by {string.Join(" ", listAuthors)}";
        }

    }
}
