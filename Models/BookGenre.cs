using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetBookStore.Models
{
    public class BookGenre
    {
        public int BookGenreId { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
