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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddMovie>().HasData(

                new AddMovie
                {
                    MovieId = 1,
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
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
                    Category = "Action/Adventure",
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
