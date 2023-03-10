using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothekComparatorsAndIterators
{
    public class Library : IEnumerable<Bibliothek>
    {
        List<Bibliothek> books;

        public Library(params Bibliothek[]books)
        {
            this.books = new List<Bibliothek>(books);
        }
    
        public IEnumerator<Bibliothek> GetEnumerator()
        {
            return books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var book in books)
            {
                yield return book;  
            }
        }
    }
}
