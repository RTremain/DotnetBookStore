using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotnetBookStore.Models;

namespace DotnetBookStore.Data
{
    public class DbInitializer
    {
        public static void Initialize(BookStoreContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (!context.Book.Any())
            {
                var books = new Book[]
                {
                    new Book{Title="Test", Description="Lorem Ipsum Dolor", AvailableInStore=false}
                };

                foreach (Book b in books)
                {
                    context.Book.Add(b);
                }
                context.SaveChanges();
            }

            if (!context.Genre.Any())
            {
                var genres = new Genre[]
                {
                    new Genre{Name="Fantasy"}
                };

                foreach (Genre g in genres)
                {
                    context.Genre.Add(g);
                }
                context.SaveChanges();
            }
        }
    }
}
