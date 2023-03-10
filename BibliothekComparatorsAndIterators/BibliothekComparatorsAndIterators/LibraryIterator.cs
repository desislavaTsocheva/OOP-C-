using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothekComparatorsAndIterators
{
    public class LibraryIterator : IEnumerator<Library>
    {
        List<Library> books;
        public int CurrentIndex { get; set; }

        public LibraryIterator(List<Library> books, int currentIndex)
        {
            this.books = new List<Library>(books);
            CurrentIndex = currentIndex;
        }

        public Library Current => this.books[this.CurrentIndex];

        object IEnumerator.Current => this.Current;

        public IEnumerator<Library> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()=>++this.CurrentIndex < this.books.Count;   

        public void Reset()=>this.CurrentIndex = -1;
    }
}
