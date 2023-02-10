using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIssion6_jacobs27.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {

        }
        public DbSet<Movie> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID = 2,
                    Title = "Starwars: Episode 2 - Attack of the Clones",
                    Year = "2002",
                    Category = "Sci-FI",
                    Director = "George Lucas",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Brandon Jacobs",
                    Notes = "No Notes"
                },
                new Movie
                {
                    MovieID = 1,
                    Title = "Starwars: Episode 1 - The Phantom Menace",
                    Year = "1999",
                    Category = "Sci-FI",
                    Director = "George Lucas",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Brandon Jacobs",
                    Notes = "No Notes"
                },
                new Movie
                {
                    MovieID = 3,
                    Title = "Starwars: Episode 3 - Revenge of the Sith",
                    Year = "2005",
                    Category = "Sci-FI",
                    Director = "George Lucas",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "Brandon Jacobs",
                    Notes = "No Notes"
                });
        }
    }
}
