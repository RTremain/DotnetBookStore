using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetBookStore.Models;

namespace DotnetBookStore.ViewModels
{
    public class BookGenreViewModel
    {
        public BookGenreViewModel(Genre g)
        {
            BookGenreViewModelId = g.Id;
            Name = g.Name;
            Added = false;
        }

        //This has to exist and be empty
        public BookGenreViewModel() { }

        public int BookGenreViewModelId { get; set; }
        public string Name { get; set; }
        public bool Added { get; set; }
    }


}
