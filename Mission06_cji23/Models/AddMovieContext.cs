using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_cji23.Models
{
    public class AddMovieContext : DbContext
    {
        public AddMovieContext(DbContextOptions<AddMovieContext> options) : base(options)
        {
            // leave blank for now
        }

        public DbSet<AddMovie> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
            );

            mb.Entity<AddMovie>().HasData(

                new AddMovie
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "Avengers, The",
                    Year = 2012,
                    Director = "Josh Whedon",
                    Rating = "PG-13", 
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new AddMovie
                {
                    MovieId = 2,
                    CategoryId = 1,
                    Title = "Indiana Jones and the Last Crusade",
                    Year = 1989,
                    Director = "Steven Spielberg",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new AddMovie
                {
                    MovieId = 3,
                    CategoryId = 1,
                    Title = "Pirates of the Caribbean: The Curse of the Black Pearl",
                    Year = 2003,
                    Director = "Gore Verbinski",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            );
        }
    }
}
