using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public float AverageRating { get; set; }
        public float OnlinePrice { get; set; }
        public float InStorePrice { get; set; }
        public bool AvailableInStore { get; set; }

    }
}
